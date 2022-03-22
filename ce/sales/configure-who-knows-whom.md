---
title: "Configure who knows whom"
description: "Configure who knows whom to help sellers quickly identify colleagues within their organization who can introduce them to leads or contacts."
ms.date: 02/11/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
topic-status: Drafting
---
# Configure who knows whom 

The Who knows whom feature helps sellers to quickly identify colleagues who can introduce them to leads or contacts, based on their email interactions. To configure the feature, perform the following tasks:
1. [Enable the who knows whom feature](#enable-the-who-knows-whom-feature)
2. [Enable the connection graph](#enable-the-connection-graph)


>[!NOTE]
>- To know whether the Who knows whom feature is available in your region, see [In which region are the features available?](faqs-sales-insights.md#in-which-region-are-the-features-available).
>- For Office 365 data, your organization's data location must be in one of the following locations and not in your region-specific datacenter location:
>    - Global Geography 1 – EMEA (Austria, Finland, France, Ireland, Netherlands)
>    - Global Geography 2 – Asia Pacific (Hong Kong, Japan, Malaysia, Singapore, South Korea).
>    - Global Geography 3 – Americas (Brazil, Chile, United States).    
> To learn more on data center locations, see [Data Center Locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

## License and role requirements
| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Enable the who knows whom feature

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**. 
     
3.  Under **Relationship insights**, select **Who knows whom**.

    > [!NOTE]
    > If you don't see the **Who knows whom** menu, verify whether the advanced Sales Insights features are enabled. To learn more, see [Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features).

4. In the **Who knows whom** section, select **Turn on Who Knows Whom for your organization**.

    > [!div class="mx-imgBorder"]
    > ![Enable who knows whom](media/si-admin-who-knows-whom-enable.png "Enable who knows whom")

5. (Optional) Select the email template to use when a seller wants to contact a colleague, so as to get introduced to a lead or contact. By default, the who knows whom introduction emails template is selected.
    
    The following screenshot shows an example introduction email:

    :::image type="content" source="media/wkw_mail_to_introduction.png" alt-text="Screenshot of an example introduction email":::
    > [!NOTE]
    > For instructions on creating a new email template, go to [Create email templates](/powerapps/user/email-template-create) 

6. Select **Save**.

The who knows whom feature is configured. As a next step, work with your Microsoft 365 administrator to [Enable the connection graph](#enable-the-connection-graph). This step is mandatory; users will see the suggestions only after the connection graph is enabled.  

## Enable the connection graph

After the who knows whom feature is enabled in the Sales Hub app, as a Microsoft 365 administrator, enable **Dynamics 365 Sales Insights – Connection Graph** from the Microsoft 365 admin center. This allows Dynamics 365 Sales to collect the communication and collaboration details of users from Exchange server.

To configure the Sales Insights connection graph, follow these steps:

1. Go to the **Microsoft 365 admin center**.

2. Select **Settings** > **Org settings** > **Dynamics 365 Sales Insights – Connection Graph**.

    > [!div class="mx-imgBorder"]
    > ![Enable and save the connection graph](media/sales-insights-addon-admincenter-connection-graph-enable.png "Screenshot of connection graph settings")

3.  Read the description carefully and then select the **Enable Dynamics 365 Sales Insights - Connection Graph for your entire organization** option.

4. (Optional) If you don't want to collect information about a group of users in your organization, add their group ID in the text box. 

5. Select **Save**.

>[!NOTE]
> Sellers can opt out of the connection graph if they don't want sales insights to analyze their communication and collaboration data. More information: [Opt out of the connection graph](who-knows-whom.md#opt-out-of-the-connection-graph)


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Add Relationship intelligence widgets to custom forms](add-ri-widgets-to-custom-form.md)  
[Get introduced to a lead](../sales/who-knows-whom.md)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)  
[Who knows whom FAQs](faqs-sales-insights.md#who-knows-whom)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
