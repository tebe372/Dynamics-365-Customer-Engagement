---
title: Provide consent to collect data from Microsoft 365
description: Provide consent for Dynamics 365 to use data from Microsoft 365.
ms.date: 03/03/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent to collect data from Microsoft 365  

Dynamics 365 Sales uses Microsoft 365 data to generate the following insights:

- Relationship analytics KPIs and health score
- Who knows whom suggestions

Previously, the consent for these capabilities were provided from **Microsoft 365 admin center** > **Settings** > **Org settings** > **Dynamics 365 Sales Insights - Analytics** and **Dynamics 365 Sales Insights - Connection graph** respectively. The consent to use office data is now consolidated and is applicable for all Dynamics 365 applications.  
   
> [!IMPORTANT]
> The consent provided for relationship analytics in **Dynamics 365 Sales Insights - Analytics** is valid until September 2022. After that, you'll need to provide consent as described in this article. We recommend that you provide consent as early as possible to avoid any loss of functionality.

The relationship analytics and who knows whom capabilities in Dynamics 365 Sales include insights based on email interactions and meetings from Exchange Online. 

To enable Dynamics 365 to collect information from your organization's Exchange server, your Microsoft 365 administrator must provide consent to use Exchange data.  

> [!NOTE]
> When consent is provided, Dynamics 365 analyzes Exchange emails from the last one year.  

If you're Microsoft 365 administrator, here's how you provide consent:

1. In **Microsoft 365 admin center**, select **Settings** > **Org settings** > **Dynamics 365 Applications**.

    :::image type="content" source="./media/office365-consent-form.png" alt-text="A screenshot of the Microsoft 365 admin center Org settings, with the Dynamics 365 Apps consent form shown.":::
    
3. Read the description carefully and select the **Aggregated insights for other users** option. 

    > [!IMPORTANT]
    >- The consent provided is applicable to all the Dynamics 365 applications that require **Insights for other users** permission.
    >- When you disable the consent, the system can take up to 24 hours to remove data from all apps and up to 30 days to remove backed-up data from Microsoft 365 storage accounts.  

4. (Optional) Opt out security groups of users who don't want to share their collaboration and communication data. Add their Microsoft 365 security group ID in the text box.
    > [!NOTE]
    > Individual users can opt out too. More information: [Turn off data sharing with Dynamics 365 applications](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications)
1. Save the changes.  
    Dynamics 365 applications can now access the Microsoft 365 data.


### See also

[Insights generated from Microsoft 365 data](insights-from-m365.md)
[Configure relationship analytics and health](configure-relationship-analytics.md)
[Use relationship analytics to gather KPIs](./relationship-analytics.md)
[Configure who knows whom](configure-who-knows-whom.md)
[How to get introduced to leads or contacts](who-knows-whom.md)
