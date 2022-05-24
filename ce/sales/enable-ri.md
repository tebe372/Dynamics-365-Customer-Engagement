---
title: "Enable relationship intelligence"
description: "Relationship intelligence provides relationship analytics and who knows whom capabilities."
ms.date: 05/13/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Enable relationship intelligence  

Enable relationship intelligence to get the following insights based on your sellers interactions with their customers:  

- Relationship analytics KPIs and customer relationship health score
- Who knows whom suggestions 

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## To enable relationship intelligence

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
     
3.  Under **Relationship insights**, select **Overview**.  

    >[!NOTE]
    >If you don't see **Relationship insights**, make sure the advanced Sales Insights features are turned on. To learn more, see [Install and configure premium Sales Insights features](./intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features).

1. Turn on the toggle under **Get started with Relationship Intelligence**.
    The relationship intelligence features&mdash;relationship analytics and who knows whom&mdash;are turned on by default.  
    :::image type="content" source="media/enable-ri-overview.png" alt-text="A screenshot of the Overview page to enable the relationship intelligence features":::
1. Select the security roles of users who are allowed to contribute to relationship insights.  
    If you have selected specific security roles, the data of users who belong to those security roles are collected and used for generating insights.
1. Save the changes.  
    Relationship intelligence features are enabled but you must complete the [next steps](#next-steps), for the features to be fully functional.  



## Next steps

- Work with your Microsoft 365 admin to [provide consent](provide-consent-office365.md) to use Exchange data.

    > [!NOTE]
    >- Until the consent is provided, a banner is displayed on the **Overview** page to notify the pending action.  
    > :::image type="content" source="media/enable-ri-overview-banner.png" alt-text="A screenshot highlighting the message banner when the consent isn't provided":::
    >- After the consent is provided, Dynamics 365 will analyze Exchange emails pertaining to the last one year.  
    >- Make sure the consent is provided within 14 days of turning on the relationship intelligence features. Otherwise, who knows whom and exchange integration for relationship analytics will be automatically turned off on the 14th day.  

- Select **Options** in the respective feature section to configure the feature. For more information on what you can configure, see:
    - [Configure relationship analytics and health](configure-relationship-analytics.md)
    - [Configure who knows whom](configure-who-knows-whom.md) 
- [Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for lead or contact.



[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]