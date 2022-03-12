---
title: "Track a marketing campaign response using in-app marketing | MicrosoftDocs"
description: "Track the replies to your campaigns by using campaign responses in Dynamics 365 Sales."
ms.date: 11/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-campaign
  - D365-Entity-campaignactivity
  - D365-Entity-campaignresponse
  - D365-Entity-bulkoperation
  - D365-UI-Form
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Track a marketing campaign response using in-app marketing

Record the replies you get from potential customers in response to a specific marketing campaign to make sure your team can act on the responses. Measure the success of specific campaign activities based on their response rates. You can manually create campaign responses or have [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] generate them automatically.  

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | All primary sales roles such as salesperson, sales manager, and so on.<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|
|||

  
## Create campaign responses manually  
  
1. In the site map, select **Marketing Lists**.
  
2.  Open a marketing list record, and then in the **Campaigns** area, open the campaign to which you want to add campaign responses, and on the **Related** tab, select **Campaign Responses**.

3. Select **New Campaign Response**.
  
4. In the **New Campaign Response** form, add the required information.
  
5. Select **Save**.  
  
## Create campaign responses automatically

**Prerequisite**: [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  

1. On the navigation bar, select the **Settings** icon ![Settings icon on the navigation bar.](media/settings-icon.png "Settings icon on the navigation bar"), and then select **Advanced Settings**.

2. On the navigation bar, select **Settings**, and then select **Administration**.

3. Select **System Settings**, and then select the **Marketing** tab.  

4. Set the **Create campaign responses for incoming email** option to **Yes**.  

> [!NOTE]
> If there are multiple email replies from a customer to an email sent out from a campaign activity, only the first reply is tracked as a campaign response in the campaign.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
  
### See also  
 [System Settings dialog box - Marketing tab](/power-platform/admin/system-settings-dialog-box-marketing-tab)   
 [Get started with in-app marketing](get-started-app-marketing-sales.md)   
 [Create a marketing list using in-app marketing](create-marketing-list-using-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](create-quick-campaign-using-app-marketing-sales.md)   
 [Add an activity to a campaign using in-app marketing](add-activity-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Create or edit a campaign template using in-app marketing](create-edit-campaign-using-app-marketing-sales.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
