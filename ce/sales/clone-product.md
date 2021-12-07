---
title: "Clone products (Dynamics 365 Sales) | MicrosoftDocs"
description: "Quickly create a copy of an existing product in Dynamics 365 Sales including all its details by cloning it."
ms.date: 02/10/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
ms.custom: 
  - "dyn365-sales"
---
# Clone products (Sales Hub) 

Quickly create a copy of an existing product in Dynamics 365 Sales including all its details by cloning it.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Clone a product

When you're creating a new product, family or bundle, save time by cloning an existing one. Cloning creates a copy of the original record with all the details except for the name and ID. If the product, bundle, or family has any properties, they're also copied to the cloned record.  
  
1. [!INCLUDE[proc_permissions_admin_cust_mgr_vp_sales_ceo](../includes/proc-permissions-admin-cust-mgr-vp-sales-ceo.md)]  
  
2. In the site map, select **Products**.   
  
3. Select a product family, product, or bundle record that you want to clone, and on the command bar, select **Clone**. 

    > [!div class="mx-imgBorder"]
    > ![List of products with Clone button.](media/clone-product.png "List of products with Clone button")

    A confirmation dialog box appears.
    
    ![Confirm cloning of product.](media/confirm-clone-product.png "Confirm cloning of product")

4. Select **Confirm**.
    
    A new product record will open with the same details as the original one except for the name and ID.  
  
    The new record is created under the same parent node as the original one.  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See Also  
 [Create a product](create-product-sales.md)   
 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
