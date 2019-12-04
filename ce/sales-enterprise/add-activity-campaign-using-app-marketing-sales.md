---
title: "Add an activity to a campaign using in-app marketing (Dynamics 365 Sales) | MicrosoftDocs"
description: "Add planning and campaign activities to a campaign to make it successful."
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Add an activity to a campaign using in-app marketing (Sales)

Make your marketing campaigns successful by creating, distributing, and assigning planning and campaign activities in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. Planning activities are those you want to perform before you launch the campaign, and campaign activities are those you want to manage as part of the campaign. Examples of planning and campaign activities you can add include:  
  
- Identify advertising channels and supporting materials  
  
- Contact media channels to reserve time or space for advertising  
  
- Create or refine target marketing lists  
  
- Contact a design agency to request creation of collateral pieces and advertising materials  
  
  By default, a campaign targets an activity to the group of marketing lists that you select for the campaign. If you want to run a campaign activity on a subset of your marketing lists, you can distribute the activity to certain members instead.  
  
<a name="Collapsed1"></a>   
## Add a planning activity to a campaign  
  
1. [!INCLUDE[proc_marketing_campaigns](../includes/proc-marketing-campaigns.md)]  
  
2. In the campaign record you want to add the planning activity to, on the nav bar, click the down arrow ![User profile security option More Options button](../sales-enterprise/media/user-profile-security-options.gif "User profile security option More Options button") next to the campaign you're working on and then click **Planning Activities**.  
  
3. To add a new activity, click **Add New Activity**, and then select the type of activity you want to create.  
  
    -OR-  
  
    To add an existing activity, click **Add Existing Activity**. In the inline lookup field, search for and select the activity.  
  
4. In the new activity form, add or change information in the text boxes.  
  
5. When you're ready to save your data, click **Save**.  
  
## Add a campaign activity to a campaign  
  
1. [!INCLUDE[proc_marketing_campaigns](../includes/proc-marketing-campaigns.md)]  
  
2. In the campaign record you want to add the campaign activity to, on the nav bar, click the down arrow ![User profile security option More Options button](../sales-enterprise/media/user-profile-security-options.gif "User profile security option More Options button") next to the campaign you're working on and then click **Campaign Activities**.  
  
3. Click **Add New Campaign Activity**.  
  
4. In the **Summary** section of the **Campaign Activity** form, enter the required information: 

    a.  **Subject**. Type the objective of the campaign activity.
    
    b.  **Used in Campaign.** When you create the campaign activity from a campaign, the campaign is automatically added here. 
    
    c.  Scheduled start and end date. Enter the expected date and time the activity is scheduled to start and end.   

5. In the **Anti-Spam Settings** section, enter the frequency cap (in days) for marketing activities directed at any contact. Contacts that have been contacted more recently than this will be excluded from new campaign activity distributions. Enter "0" to disable the limit.

6. On the Campaign Activity form, select **Save**.

7. To add a marketing list, click **+**. In the **Look Up Records** box, type in your search and click the **Search** button, select one or more marketing lists, and click **Add**.  
  
8. To distribute the new campaign activity, on the command bar, click **Distribute Campaign Activity**.  
  
9. In the activity form, type or modify information in the text boxes, and click **Distribute**.  
  
10. Choose who will own the activities, and click **Distribute**.  
  
   > [!NOTE]
   > 1.  You can only distribute campaign activities of type "mail merge" to marketing lists that contain the same type of record. For example, if one marketing list contains accounts and a second marketing list contains leads, the mail merge campaign activity will fail. Create a separate mail merge campaign activity for each group of marketing lists with the same record type. 
   > 2.  When you distribute a campaign activity or run a quick campaign, and if a contact, account, or lead in the target audience (typically specified in a marketing list) doesn't have data in the Email, Fax, Address, or Primary Phone fields, respective activities like Email, Phone, Letter, and Fax won't be created for that contact, account or lead. 
  
9. After all the distributed activities are closed, you can close the campaign activity. To close the campaign activity, open the campaign activity record, and on the command bar, click **Close Campaign Activity**. Set an appropriate status for the activity, and click **OK**.  
  
10. When the activity is completed, update the campaign activity record with the actual costs. Open the campaign activity and update the **Actual Cost** field. This can help guide you in planning future campaign activities.  
  
  
### See Also  
 [Get started with in-app marketing](../sales-enterprise/get-started-app-marketing-sales.md)   
 [Create a marketing list using in-app marketing](../sales-enterprise/create-marketing-list-using-app-marketing-sales.md)   
 [Create or edit a campaign using in-app marketing](../sales-enterprise/create-edit-campaign-using-app-marketing-sales.md)   
 [Create a quick campaign using in-app marketing](../sales-enterprise/create-quick-campaign-using-app-marketing-sales.md)   
 [Add a marketing list, sales literature, or product to a campaign using in-app marketing](../sales-enterprise/add-marketing-list-sales-literature-product-campaign-using-app-marketing-sales.md)   
 [Track a marketing campaign response using in-app marketing](../sales-enterprise/track-marketing-campaign-response-using-app-marketing-sales.md)   
