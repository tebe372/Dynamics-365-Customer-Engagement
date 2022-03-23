---
title: "Change the parent of a product (reparenting) (Dynamics 365 Sales) | MicrosoftDocs"
description: "Create a product hierarchy by associating products and product families in a parent-child relationship in Dynamics 365 Sales."
ms.date: 03/23/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-product
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Change the parent of a product (reparenting) 

Create a product hierarchy by associating products and product families in a parent-child relationship in Dynamics 365 Sales.

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Change or remove the parent of a product

To organize your company's product catalog better, you may want to change the parent of an existing product record so the child products inherit the appropriate product properties. You can change the parent of an existing product, bundle, or family to a new parent or delete an existing parent.

**To change the parent of a product, bundle, or family:**

1. Open the record that you want to parent.
1. In the **Parent** field, select the new parent record. 

    :::image type="content" source="media/parent-product.png" alt-text="Screenshot of a product page with the Parent field highlighted.":::
    
    To delete the parent, just remove the parent record from the **Parent** field.

Things to consider when changing reparenting:

-	Products which are re-parented can't be reverted. When a product is reparented, the properties inherited from the previous parent are lost. Thus, you can't revert the properties of the reparented product to the last active version of the product. 
- You can only select a product family as a parent.
- You can only set product families that are in the Under Revision, Draft, or Active state as a parent.
-	You can only change or remove the parent from records that are in the **Under Revision** or **Draft** status.
-	For an **Under Revision** record, only an **Under Revision** or **Active** record can be selected as its parent.
-	For a **Draft** record, only an **Under Revision**, **Draft**, or **Active** record can be selected as its parent.  

When you reparent an existing record, all the existing inherited properties of the record and its child records are removed, and the new properties of the new parent (if any) are added. 

For example, think of a TV that was previously classified as "Plasma." The organization decides it’s better to organize TVs as Smart vs Non-Smart TVs. They decide to move it from the "Plasma" family to the "Smart TV" family. A new set of properties relating to Smart TV are added and Plasma properties are removed from the parent. 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Set up products (Sales and Sales Hub)](create-product-sales.md)  
[Set up a product family (Sales and Sales Hub)](create-product-family.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
