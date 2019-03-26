---
title: "Switching from the list component or changing the SharePoint deployment for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 03/19/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: f002a65b-59c8-451e-b82a-aef154109668
caps.latest.revision: 9
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Switching from the list component or changing the SharePoint deployment

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

This topic provides an overview about how to switch from the list component to server-based authentication. This topic can also help if you change the [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] deployment type, such as moving from [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] on-premises to [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)].  
  
<a name="BKMK_switchlistcomp"></a>   

## Switch from the list component to server-based authentication  
 If your organization is already using the list component with [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] for document management with [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps, you can switch to server-based authentication by following these steps.  
  
1. Follow the steps to set up server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration that best fits your deployment type. For more information, see the appropriate topic for your [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] deployment below.  


|Environment  |Topic  |
|---------|---------|
|Dynamics 365 for Customer Engagement apps (online) and SharePoint Online  |  [Configure server-based authentication with Dynamics 365 for Customer Engagement apps (online) and SharePoint Online](configure-server-based-authentication-sharepoint-online.md)           |
|Dynamics 365 for Customer Engagement apps (online) and SharePoint on-premises     |   [Configure server-based authentication with Dynamics 365 for Customer Engagement apps (online) and SharePoint on-premises](../admin/configure-server-based-authentication-sharepoint-on-premises.md)      |
  
   > [!NOTE]
   >  If you've made changes to [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], such as new [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] servers, new site collections, or migrated from [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] on-premises to [!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)], consider deactivating outdated [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site records. When you run the Enable Server-Based SharePoint Integration wizard, the wizard will attempt to validate all active [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] sites. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Deactivate a site](../admin/switching-list-component-changing-deployment.md#BKMK_deact_site)  
  
2. Although it is not required for server-based authentication, we recommend that you deactivate and then delete the list component [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] solution from the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site collection. To do this, after you have confirmed that server-based authentication is enabled, in a web browser follow these steps. 
      1. Sign-in to the site collection, click the **Settings** button in the top-right corner, then **Site Settings**, and then under **Web Designer Galleries**, click **Solutions**. 
      2. Choose **crmlistcomponent**, and then on the tool bar click **Deactivate**. 
      3. Choose the **crmlistcomponent** again, and then on the tool bar click **Delete**.  
  
<a name="BKMK_changeSP"></a>   

## Changing the SharePoint deployment type  
  
1. After the migration of [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] to either online or on-premises is completed, deactivate the outdated [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site records. You must do this because, when you run the Enable Server-Based SharePoint Integration wizard, the wizard will attempt to validate all active [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] sites. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Deactivate a site](../admin/switching-list-component-changing-deployment.md#BKMK_deact_site)  
  
2. Follow the steps to set up server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration that best fits your deployment type. For more information, see the above section [Switching from the list component or changing the SharePoint deployment](#switching-from-the-list-component-or-changing-the-sharepoint-deployment).
  
<a name="BKMK_deact_site"></a>   

### Deactivate a site  
  
1. [!INCLUDE[proc_settings_doc_management](../includes/proc-settings-doc-management.md)]  
  
2. Click **SharePoint Sites**.  
  
3. Select the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site you want to remove, and then on the tool bar select **Deactivate**.  
  
4. Repeat step three for all sites that you want to deactivate.  

### See also
[Set up SharePoint integration with Microsoft Dynamics 365 for Customer Engagement](../admin/set-up-sharepoint-integration.md) 
  
<!-- 
[Configure server-based authentication with Microsoft Dynamics 365 for Customer Engagement apps (on-premises) and SharePoint Online](Configure%20server-based%20authentication%20with%20Microsoft%20Dynamics%20365%20\(on-premises\)%20and%20SharePoint%20Online.md)   
 [Configure server-based authentication with Microsoft Dynamics 365 for Customer Engagement apps (on-premises) and SharePoint on-premises](Configure%20server-based%20authentication%20with%20Microsoft%20Dynamics%20365%20\(on-premises\)%20and%20SharePoint%20on-premises.md)   
--> 
