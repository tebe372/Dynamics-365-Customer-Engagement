---
title: "Editable Products grid on Opportunity, Quote, Order, and Invoice forms (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Editable Products grid helps sales users to make changes to the product details inline in Dynamics 365 for Sales."
keywords: product, opportunity, editable grid, quote, order, invoice
ms.date: 09/24/2018
ms.service:
  - dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - Dynamics 365 for Customer Engagement
  - Dynamics 365 for Customer Engagement apps version 9.x
ms.assetid: e426b768-bd64-4e64-8560-667634006d74
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
---

# Editable Products grid on Opportunity, Quote, Order, and Invoice forms (Sales Hub)

Products grid on the Opportunity, Quote, Order, or Invoice forms is now editable, so you don’t have to open individual product records to make changes to the product. 

Currently, the preconfigured Products grid is available only on apps built on the Unified Interface framework and is optimized to work on the web.

With [!INCLUDE[pn-crm-9-0-2-online](../includes/pn-crm-9-0-2-online.md)], the product editable grid is added out-of-the-box to the **Product Line Items** section of the Opportunity form of type **Main**. For Quote, Order, or Invoice, it is added to the Products section of the forms of type **Main**. 

If you’re upgrading to [!INCLUDE[pn-crm-9-0-2-online](../includes/pn-crm-9-0-2-online.md)] and you’ve made customizations to the **Product Line Items** or **Products** sections of these forms, your customizations will prevail, and the product editable grid won’t be added to the forms by default. You must manually enable the product editable grid, though the product grid configurations for the editable grid already will be defined. If there are no customizations to these sections, the Products grid will be automatically configured and enabled after the upgrade. 

To enable the editable products grid on the Opportunity, Quote, Order, or Invoice form:

1. Go to **Settings** > **Customization**. 

2. Select **Customize the System** to open the default solution. 

3. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**. 

4. In the list of forms, open the form of type Main.

5. If you’re enabling the editable product grid in the Opportunity form, select the **Action Cards** area in the **Product Line items** section, and in the **Edit** group, select **Change Properties**.

    ![Action Cards area in the Product Line Items section](media/action-cards-area-product-line-items-section.png "Action Cards area in the Product Line Items section")
    
    **– OR –** 
    
    If you’re enabling the editable product grid in the Quote, Order, or Invoice form, select the **Products** area in the **Products** section, and in the **Edit** group, select **Change Properties**.
  
    ![Products area](media/products-area.png "Products area in the Products section")

6.	In the **Set Properties** dialog box, select the devices on which you want the editable grid to be available by selecting the corresponding radio button. Currently, the editable grid is optimized to work on the web.

    ![Editable grid control in the Set Properties dialog box](media/editable-grid-set-properties-dialog-box.png "Editable grid control in the Set Properties dialog box")

    Notice that the properties of the editable grid such as Grid view or Nested grid view are preconfigured by default.
 
7.	Select **OK**.


### See also  

[Make grids (lists) editable using the Editable Grid custom control](../customize/make-grids-lists-editable-custom-control.md)
