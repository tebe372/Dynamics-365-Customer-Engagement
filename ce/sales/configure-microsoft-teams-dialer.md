---
title: "Configure Microsoft Teams dialer in Dynamics 365 Sales | MicrosoftDocs"
description: "How to configure Microsoft Teams dialer in Dynamics 365 Sales."
ms.date: 03/08/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
ms.custom: 
  - dyn365-sales
---
# Configure Microsoft Teams dialer (Preview)

> [!IMPORTANT]
> - While in preview, Teams calls does not support emergency calling.
> - Preview features are not complete, but are made available to you before general availability so you can evaluate them and provide feedback to Microsoft. Preview features are not intended for production use and may have limited or restricted functionality, as further explained in our [Product Terms](https://go.microsoft.com/fwlink/?linkid=2173816). 

Microsoft Teams dialer helps sellers to be more productive and get work done more effectively by calling customers directly from within Dynamics 365 Sales app.

> [!NOTE]
> You can also enable Teams dialer through quick setup (with the Dynamics 365 Sales Enterprise license). More information: [Microsoft Teams calls with conversation intelligence](digital-selling.md#microsoft-teams-calls-with-conversation-intelligence)

## License and role requirements
| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## How to configure the dialer

As an administrator, you must configure Microsoft Teams dialer for sellers to use. Perform the following steps:

1.	[Review the prerequisites](#review-the-prerequisites).
2.	[Configure the dialer](#configure-the-dialer).

## Review the prerequisites

Review the following requirements before you configure Microsoft Teams dialer in your Dynamics 365 Sales Hub app:     
-	You have a license for using Microsoft Teams. Any Microsoft Teams license will work. More information: [Microsoft Teams add-on licenses](/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business).      
-	Your organization has a phone system installed, with a valid license to use it. More information: [Set up Phone System in your organization](/MicrosoftTeams/setting-up-your-phone-system).          

## Configure the dialer

1.	Sign in to your Dynamics 365 Sales Hub app.          
2.	Go to **App settings**, and under **General settings**, select **Teams calls (preview)**.    
    > [!div class="mx-imgBorder"]
    > ![Microsoft Teams dialer configuration page.](media/teams-dialer-configuration-page.png "Microsoft Teams dialer configuration page")     
3.	In the **What you need to set up Microsoft Teams calls** section, the application validates that your organization has sufficient privileges to use **Phone system** and **Microsoft Teams**.
    - Upon successful validation, the status corresponding to **Phone system license** and **Teams license** displays **Status: Successfully set up**. Proceed to step 4.   
        > [!div class="mx-imgBorder"]
        > ![Phone system and Microsoft Teams licenses successful validation.](media/teams-dialer-systems-validation-successful.png "Phone system and Microsoft Teams licenses successful validation")      
    - <a name="tenant-admin-contact"></a> If any of the validations fails, you can't proceed with the configuration. Contact your tenant administrator to set up the phone system and Microsoft Teams for your organization.    
    When the tenant administrator completes the configuration of [phone system](/MicrosoftTeams/setting-up-your-phone-system) and [Teams licenses](/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business), you can continue with the configuration. Select **Check status**.
        > [!div class="mx-imgBorder"]
        > ![Phone system and Microsoft Teams licenses failed validation.](media/teams-dialer-systems-validation-failed.png "Phone system and Microsoft Teams licenses failed validation")
4.	Select **Enable preview**.    
    >[!NOTE]
    >The **Enable preview** option will only be available after the phone system and Microsoft Teams licenses are successfully validated.
    
    > [!div class="mx-imgBorder"]
    > ![Enable the preview.](media/teams-dialer-enable-preview.png "Enable the preview") 
5.	In the **Security role** section, select one of the following options to provide permissions to users to access Microsoft Teams dialer. 

    | Option | Description |
    |--------|-------------|
    | All security roles | Allows all the security roles to access Microsoft Teams dialer. |
    | Specific security roles | Allows only the selected security roles to access Microsoft Teams dialer.<br>**Note**:<br> - Ensure that the security roles you’ve selected are associated with the root business unit (top level in the business unit hierarchy). If not, the users will not see the Teams dialer in the Sales Hub app. More information: [Create or edit business units](/power-platform/admin/create-edit-business-units)|
    
    >[!NOTE]
    >- Ensure that users who need to access the Teams dialer are assigned to the selected security roles. More information: [Assign a security role to a user](/power-platform/admin/assign-security-roles)
    >- Ensure that the selected security roles have read privileges to the following records in manage security roles page: 
    > - Under the **Core Records** tab, read access to **Note**
    > - Under the **Custom Entities** tab, read access to **Teams Dialer Admin settings**
    >More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)
    >- Ensure that the security roles you've selected can access the Teams dialer. More information: [Configure the dialer](configure-microsoft-teams-dialer.md#configure-the-dialer)

    > [!div class="mx-imgBorder"]
    > ![Select security roles.](media/teams-dialer-select-security-roles.png "Select security roles")
6.	Select **Advanced options**, and in the **Select app** drop-down list, select, and add apps such as your custom apps. By default, **Sales Hub** is selected.     
    > [!div class="mx-imgBorder"]
    > ![Select apps to use Microsoft Teams dialer.](media/teams-dialer-select-apps.png "Select apps to use Microsoft Teams dialer")

    >[!NOTE]
    >When Microsoft Teams dialer is enabled in your organization for Sales Hub app, other telephony systems that are connected to the Sales Hub app through Dynamics 365 Channel Integration Framework will stop working. As an administrator, you can deactivate or delete the Dynamics 365 Channel Integration Framework phone system. Follow these steps:
    >1.	Go to your **Channel Integration Framework** app.
    >2.	From the **Active Channel Providers** view, select the phone system.
    >3.	From the toolbar, select **Deactivate** or **Delete** according to your requirements.

7.	Save and publish the configuration.
    A confirmation message is displayed, and the Microsoft Teams dialer is enabled in your organization for selected security roles in the selected app. 
    >[!NOTE]
    >You must refresh the configuration page to make the changes available in the application. 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Microsoft Teams integration](../teams-integration/teams-integration.md)   
[Call using Microsoft Teams](call-using-microsoft-teams.md)   
[Call a customer](/dynamics365/ai/sales/connect-with-customers#call-a-customer)      
[View and understand call summary pages](/dynamics365/ai/sales/view-and-understand-call-summary)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
