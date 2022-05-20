---
title: "Configure who knows whom"
description: "Configure who knows whom to help sellers quickly identify colleagues within their organization who can introduce them to leads or contacts."
ms.date: 05/13/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Configure who knows whom 

Configure who knows whom to select a customized email template for sending introduction emails.

>[!NOTE]
>- To know whether the Who knows whom feature is available in your region, see [In which region are the features available?](faqs-sales-insights.md#in-which-region-are-the-features-available).
>- For Office 365 data, your organization's data location must be in one of the following locations and not in your region-specific datacenter location:
>    - Global Geography 1 – EMEA (Austria, Finland, France, Ireland, Netherlands)
>    - Global Geography 2 – Asia Pacific (Hong Kong, Japan, Malaysia, Singapore, South Korea).
>    - Global Geography 3 – Americas (Brazil, Chile, United States).    
> To learn more on data center locations, see [Data Center Locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## To configure who knows whom 

1. Enable [relationship intelligence](enable-ri.md) if you haven't already.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**. 
   
3.  Under **Relationship insights**, select **Who Knows Whom**.

5.  Select the email template to use when a seller wants to contact a colleague to get introduced to a lead or contact. By default, the who knows whom introduction emails template is selected.
    
    The following screenshot shows an example introduction email:

    :::image type="content" source="media/wkw_mail_to_introduction.png" alt-text="Screenshot of an example introduction email":::
    > [!NOTE]
    > For instructions on creating a new email template, go to [Create email templates](/powerapps/user/email-template-create) 

6. Save the changes.

 
## Next steps

- Work with your Microsoft 365 admin to [provide consent](provide-consent-office365.md) to use Exchange data.

    > [!NOTE]
    > Until the consent is provided, a banner is displayed on the **Overview** page to notify the pending action.
    > :::image type="content" source="media/enable-ri-overview-banner.png" alt-text="A screenshot highlighting the message banner when the consent isn't provided":::

- [Add the who knows whom widget to custom forms](add-ri-widgets-to-custom-form.md) if your organization is using a custom sales app or a custom form for lead or contact.


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Get introduced to a lead](../sales/who-knows-whom.md)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)  
[Who knows whom FAQs](faqs-sales-insights.md#who-knows-whom)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
