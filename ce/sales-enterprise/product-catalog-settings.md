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
| **Maximum number of properties that are allowed for a product or bundle**  |                                                                                                                                                                                                                                                                                                Specify the maximum number of properties that can be associated with a product or bundle.<br /><br /> Product properties are added to a product family record, and all the child products and bundles under the product family inherit the properties added to the parent product family. The number specified in this setting comes into effect only when you publish a product or a bundle with the associated properties, and not at the time when you add the properties to a draft product family record.                                                                                                                                                                                                                                                                                                |
  
## Migrate product catalog configuration data  
 To migrate the product catalog configuration data, use the Configuration Migration Tool. For more information on how to use the tool, see: [Manage configuration data](manage-configuration-data.md).  
  
 You must select the following entities for migrating the product catalog configuration data:  
  
-   Product  
-   Product Relationship (not a mandatory entity, needed only for relationships)  
-   Property  
-   Property Association  
-   Property Option Set Item  
-   Notes (needed,  if there are any notes for the product)  
-   Currency  
-   Price List  
-   Price List Item  
-   Unit  
-   Unit Group  
-   Territory (needed if there is a default price list configuration)  
-   Connection (needed, if there is a default price list configuration)  
-   Competitor (needed, if there are any competitors for product)  
-   Sales Literature and Sales Literature Item (needed, if there is any sales literature for product)  
-   Discount (not a mandatory entity, needed only for discounts when added to price lists)  
-   Discount List (not a mandatory entity, needed only for discounts)  
  
> [!NOTE]
>  During product catalog configuration data transfer, you may see a schema validation warning, saying that the data transfer may be inconsistent. This is because you didn't include the Entitlement entity and the Entitlement Template entity in the transfer. However, these entities are not required and you can disregard the warning. The product catalog configuration data will be migrated correctly.  
  
 Certain conditions and restrictions apply during migration:  
  
-   Only active and retired products can be exported or imported.  
    > [!NOTE]
    > Transferring bundle products isn't currently supported. 
  
-   If importing of a product record fails because of a missing dependency, the related property records are not imported. When importing the product hierarchy, if creation of a record fails because of a missing dependency, the record's child hierarchy will not be imported.  
  
-   If for exporting, you selected the product entity, without selecting other entities required for export, the product records are exported without the associated properties.  
  
-   If for exporting, you select only the property entities (Property, Property Associations and Property Option Sets), without selecting the product entity, no data is exported.  
  
-   For a product record, any new property created in the source system, will also be created in the target system, after the import.   
    For a product record, the source data will override any changes in the property that also exists in the target data, after the import.   
    For a product record, if a property exists in both systems, source and target, when the property is removed from the source system, it is not removed from the target system, after the import.  
  

