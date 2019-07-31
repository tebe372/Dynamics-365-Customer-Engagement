---
title: "Create or edit a lead (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Use leads to track business prospects that you haven't yet qualified."
keywords: "lead, qualify, sales process, activities"
ms.date: 08/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.x"
ms.assetid: 8c65b7d5-b1bc-4dd7-bf10-c8bdc6334491
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 69
topic-status: Tech Reviewing
---

# Create or edit a lead (Sales and Sales Hub)

In [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)], you use leads to keep track of business prospects that you haven't yet qualified through your sales process. A lead can be an existing client or someone you've never done business with before. You might get leads from different sources, such as advertising, networking, or email campaigns.  
  
<a name="bkmk1"></a>   
## Create a lead  (Sales Hub)
  
1. In the site map, select **Leads**. 
  
2. Select **+ New**.

3. Follow the process bar to enter data into fields to move the lead to the next stage. 

4. If you’re creating the lead for new customers, enter name, contact details, and company name in the **Lead** form.

    -OR-
    
    If you’re creating the lead for an existing account or contact, in the **Qualify** stage of the process bar, select the existing account or contact.

    - When you select an existing account while creating a lead record, the company name is automatically populated. 
    
    -	When you select an existing contact while creating a lead record, the following information is automatically populated in the **Lead** form: First Name, Last Name, Job Title, Business Phone, Mobile Phone and Email.

        > [!IMPORTANT]
        >
        > The feature of automatically populating relevant fields when an existing contact or account is selected is a preview feature. [What are Preview features and how do I enable them?](../admin/what-are-preview-features-how-do-i-enable-them.md)


   > [!NOTE]
   > 
   > On new (unsaved) lead records, the **Existing Contact** and **Existing Account** fields allow you to choose any records. Once you save the lead record, these fields are filtered to show only the records that meet the duplicate detection rules to avoid duplicates.    
  
5. In the **Timeline** section, add any notes or activities (for example, phone calls or tasks) related to this lead. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Keep track of notes, tasks, calls, or email with activities](../basics/work-with-activities.md)  

6. In the **Stakeholders** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

   In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you've entered the name you want, select **Add**. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer. 
  
7. In the **Details** area of the **Lead** form, enter information about your lead's industry and preferred contact method.  
   
8. On the command bar, select **Save**.  


## Create a lead  (Sales)
  
1. [!INCLUDE[proc_sales_leads](../includes/proc-sales-leads.md)]  
  
2. Select **New**.  
 
3. Follow the process bar to enter data into fields to move the lead to the next stage. 

4. If you’re creating the lead for new customers, enter name, contact details, and company name in the **Lead** form.

    -OR-
    
    If you’re creating the lead for an existing account or contact, in the **Qualify** stage of the process bar, select the existing account or contact.

    - When you select an existing account while creating a lead record, the company name is automatically populated. 
    
    -	When you select an existing contact while creating a lead record, the following information is automatically populated in the **Lead** form: First Name, Last Name, Job Title, Business Phone, Mobile Phone and Email. 

        > [!IMPORTANT]
        >
        > The feature of automatically populating relevant fields when an existing contact or account is selected is a preview feature. [What are Preview features and how do I enable them?](../admin/what-are-preview-features-how-do-i-enable-them.md)

4. Add any notes or activities (for example, phone calls or emails) related to this lead. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Keep track of notes, tasks, calls, or email with activities](../basics/work-with-activities.md)  

5. In the **Stakeholders** section, select the **Add Connection record** button ![Add Connection record button](media/add-connection-record-button.png "Add Connection record button") to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

   In the Lookup box, enter a name or select the Lookup icon to choose from a list of suggestions. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the Role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer.
  
6. Select **Save** in the lower-right corner of the form.  
    
## Additional considerations  
  
-   Nurture your leads through a marketing campaign. [Get started with in-app marketing](../sales-enterprise/get-started-app-marketing-sales.md)  

-   Research leads through social media channels like LinkedIn and Twitter. [Get sales Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)  

-   Increase your marketing and sales effectiveness.  [Boost sales with Versium Predict](../versium-predict/versium-predict.md) (applies to the Sales app only)
  

## Tips and tricks  
 Need a faster way to enter leads? Try one of these:  
  
-   [Quick create: Enter new contacts--fast!](../basics/quick-create-enter-data-fast.md)  
  
-   [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Qualify a lead and convert it to an opportunity](../sales-enterprise/qualify-lead-convert-opportunity-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
### See also  
[Print leads, quotes, and other records](../basics/print-leads-quotes-other-records.md)
