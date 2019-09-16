---
title: "Security enhancements: User session and access management | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 599f849d-c4cb-4b1c-84a0-9fde48a1601a
caps.latest.revision: 59
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Security enhancements: User session and access management 

You can use security enhancements to better secure Dynamics 365 Customer Engagement (on-premises). 

## User session timeout management

The maximum user session timeout of 24 hours is removed.  This means that a user is not forced to login with their credentials to use the Customer Engagement (on-premises) apps and other Microsoft service apps like Outlook that were opened in the same browser session every 24 hours. 

### Honor Azure AD session policy 
By default, the Customer Engagement (on-premises) apps leverage the Azure Active Directory (Azure AD) [session policy](https://docs.microsoft.com/azure/active-directory/develop/active-directory-configurable-token-lifetimes) to manage the user session timeout.  Customer Engagement (on-premises) apps use the Azure AD ID Token with a Policy Check Interval (PCI) claims.  Every hour a new Azure AD ID Token is fetched silently in the background and the Azure AD instant policy is enforced (by Azure AD). For example, if an administrator disables or deletes a user account, blocks the user from signing in, and an administrator or user revokes the refresh token, the Azure AD session policy is enforced. 

This Azure AD ID token refresh cycle continues in the background based on the Azure AD token lifetime policy configurations.  Users continue to access Customer Engagement (on-premises)/Common Data Service data without the needs to re-authenticate until the Azure AD token lifetime policy expires. 

> [!NOTE]
> - The default Azure AD refresh token expiration is 90 days.  This token lifetime properties can be configured. For detailed information, see [Configurable token lifetimes in Azure Active Directory](https://docs.microsoft.com/azure/active-directory/develop/active-directory-configurable-token-lifetimes#configurable-token-lifetime-properties).
> - The Azure AD session policy is bypassed and the maximum user session duration is reverted back to 24 hours in the following scenarios:
>   - In a browser session, you went to the **Dynamics 365 Administration Center** and opened an environment by manually keying in the environment URL (either on the same browser tab or a new browser tab).<br/> 
>     **To workaround** the policy bypass and maximum 24 hour user session, open the environment from the Dynamics 365 Administration Center **Instances** tab by selecting the **Open** link.
>   - In the same browser session, open a version 9.1.0.3647 or higher environment and then open a version earlier 9.1.0.3647. <br/>
>     **To workaround** the policy bypass and user duration change, open the second environment in a separate browser session.
>
> To determine your version, sign in to [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps, and in the upper-right side of the screen, select the **Settings** button (![User profile Settings button](media/user-profile-settings-button.gif)) > **About**. 


### Resilience to Azure AD outages 
In an event that there are intermittent Azure AD outages, authenticated users can continue to access Customer Engagement (on-premises)/Common Data Service data if the PCI claims has not expired or the user has opted in the ‘Stay signed in’ during authentication. 

### Set Custom Session timeout for individual environment 
For environments that require different session timeout values, administrators can continue to set the session timeout and/or inactivity timeout in the System Settings.  These settings override the default Azure AD session policy and users will be directed to Azure AD for re-authentication when these settings expired.   

### To change this behavior

- To enforce users to re-authenticate after a pre-determined period of time, admins can set a session timeout for Customer Engagement (on-premises).  Users can only remain signed in the application for the duration of session.  The application signs out the user when the session expires.  Users need to sign-in with their credentials to return to Customer Engagement (on-premises) apps.

> [!NOTE]
> User session timeout is not enforced in the following:
> 1. [!INCLUDE [pn-oc-online-short](../includes/pn-oc-online-short.md)]
> 2. [!INCLUDE [pn-dyn-365-phones](../includes/pn-dyn-365-phones.md)] and [!INCLUDE [pn-dyn-365-tablets](../includes/pn-dyn-365-tablets.md)]
> 3. [!INCLUDE [pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client using [WPF](https://docs.microsoft.com/dotnet/framework/wpf/) browser (Internet Explorer is supported)
> 4. Live Assist (Chat)

## Configure session timeout 

1. In Customer Engagement (on-premises), choose **Settings** > **Administration** > **System Settings** > **General** tab.
2. Under **Set session timeout**, set the values to apply to all your users.

> [!NOTE]
> Default values are:
> - Maximum Session Length: 1440 minutes
> - Minimum Session Length: 60 minutes
> - How long before session expires before showing timeout warning: 20 minutes

## Inactivity timeout

By default, Customer Engagement (on-premises) does not enforce an inactivity session timeout.  A user can remain logged in the application until the session timeout expires.  You can change this behavior.

- To enforce users to automatically signed out after a pre-determined period of inactivity, admins can set an inactivity timeout period for Customer Engagement (on-premises). The application signs out the user when the inactivity session expires.

> [!NOTE]
> Inactivity session timeout is not enforced in the following:
> 1. [!INCLUDE [pn-oc-online-short](../includes/pn-oc-online-short.md)]
> 2. [!INCLUDE [pn-dyn-365-phones](../includes/pn-dyn-365-phones.md)] and [!INCLUDE [pn-dyn-365-tablets](../includes/pn-dyn-365-tablets.md)]
> 3. [!INCLUDE [pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client using [WPF](https://docs.microsoft.com/dotnet/framework/wpf/) browser (Internet Explorer is supported)
> 4. Live Assist (Chat)

To enforce the inactivity session timeout for Web Resources, Web Resources need to include the ClientGlobalContext.js.aspx file in their solution.

The Customer Engagement (on-premises) portal has its own settings to manage its session timeout and inactivity session timeout independent of these system settings.

## Configure inactivity timeout

1. In Customer Engagement (on-premises), choose **Settings** > **Administration** > **System Settings** > **General tab**.
2. Under **Set inactivity timeout**, set the values to apply to all your users.

> [!NOTE]
> Default values are:
> - Minimum Duration of Inactivity: 5 minutes
> - Maximum Duration of Inactivity: less than Maximum Session length or 1440 minutes

## Access management

Customer Engagement (on-premises) uses Azure Active Directory as the identity provider.  To secure the user’s access to Customer Engagement (on-premises), the following were implemented:

- To enforce users to re-authenticate, users are required to sign in with their credentials after they signed out within the application. 
- To prevent users from sharing credentials to access Customer Engagement (on-premises), the user access token is validated to ensure that the user who was given access by the identity provider is the same user who is accessing Customer Engagement (on-premises).

