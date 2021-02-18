---
title: "Configure product catalog settings  | MicrosoftDocs"
description: "Configure settings in Dynamics 365 Sales for building your product catalog."
ms.date: 02/11/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Configure product catalog settings

Product catalog helps companies sell products and services with greater efficiency. Use the product catalog settings to configure things like pricing or discounting methods.

## Configure product catalog  
 To configure the product catalog:  
  
1. In the Sales Hub app, at the bottom of the site map, select the <area> **Change area** icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

2. Under **Prodcut Catalog**, select **Product Catalog Settings**.

3. In the **Product Catalog Settings** page, set the appropriate values for the following settings and save the changes:  
  
|  Setting | Description  | 
|------|--|
|   **Create products in active state**  |     Select whether product records without a parent product family record are created in an `active` or `draft` state.<br /><br /> In the current release, by default, all the product records (product family, product, and bundle) are created in the `draft` state. This setting ensures compatibility for your applications working with the previous version where the product records were created in an `active` state.<br /><br /> By default, its set to **No** in the new installations, and set to **Yes**, for the upgrading systems.                 |
| **Allow selection of default price list for opportunity via inbuilt rule** |                                                                                                                                                                                                                                                                                                                                                                                                                                 Select whether the default price list for an opportunity is automatically selected based on the territory relationship for the price list and the current user who is creating the opportunity.<br /><br /> By default, it's set to **Yes**.                                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                 **Maximum number of products in a bundle**                 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Specify the maximum number of products that can be added in a bundle.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                     **Use system pricing calculation**                     | Select whether to use the system pricing engine to calculate prices in opportunities, quotes, orders, and invoices or to use custom pricing.<br /><br /> You can choose to use custom pricing logic instead of the system pricing to calculate prices when you add products in opportunities, quotes, orders, and invoices. To use custom pricing, select **No** for this option. Additionally, you must register a plug-in on the `CalculatePrice` message, provided in the Web services, that contains your custom pricing code. Every time you create or change the product information in an opportunity, quote, order, or invoice, the custom code is invoked instead of the system pricing engine to calculate the prices. For more information, see [Use custom pricing for products](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/use-custom-pricing-products). |
|                      **Discount calculation method**                       |                                                                                                                                                                                                                                                                                                                                                                                                                                               Select whether you want to calculate discounts at the line-item level or at the per-unit level in each line item in an opportunity, quote, order, or invoice.<br /><br /> By default, it's set to **Line item**.                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| **Maximum number of properties that are allowed for a product or bundle**  |                                                                                                                                                                                                                                                                                                Specify the maximum number of properties that can be associated with a product or bundle.<br /><br /> Product properties are added to a product family record, and all the child products and bundles under the product family inherit the properties added to the parent product family. The number specified in this setting comes into effect only when you publish a product or a bundle with the associated properties, and not at the time when you add the properties to a draft product family record.                                                                                                                                                                                                   


### See also
[Preview: Enable the enhanced experience of adding products (Sales Hub)](enable-enhanced-add-product-experience.md)  
[Set up a product catalog](set-up-product-catalog-walkthrough.md)