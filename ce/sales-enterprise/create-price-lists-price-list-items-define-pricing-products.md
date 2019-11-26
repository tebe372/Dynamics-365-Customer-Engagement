---
title: "Define product pricing with price lists and price list items (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define what to charge for your products or services in Dynamics 365 Sales."
ms.date: 10/01/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: get-started-article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Define product pricing with price lists and price list items (Sales and Sales Hub)

Price lists tell your sales agents what to charge for your products or services. You can create multiple price lists so that you can maintain separate price structures for different regions you sell your products in or for different sales channels.  
  
Price lists tie the unit, product, and pricing details together, so before you create a price list, make sure the units and products are in place.  
 

## Create a price list and price list items and add default price list for a territory (Sales Hub)

1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
2. Select the Site map icon ![Site map icon](media/site-map-icon.png "Site map icon"), then select ellipses ![Ellipses to open more options](media/ellipsis-more-options.png "Ellipses to open more options"), and then select **App Settings**. 
  
3. In the **Product Catalog** area, select **Price Lists**. 

    ![Price list in site map](media/site-map-product-catalog.png "Price list in site map")
  
4. To create a new price list, select **New**.  
  
    -OR-  
  
    To edit a price list, open a price list from the list.  
  
5. In the price list form, fill in your information, and then select **Save**. 

    a.  **Name**. Type a descriptive name for the price list. For example, if you are creating a price list for retail, mention that.

    b.  **Start Date**/**End Date**. Select the start date and end date for the price list. For example, if this is a promotional price list that’s effective only for the promotional period, select that period.

    c.  **Currency**. Select the currency you’re creating the price list for. You can have different price list for different currencies.

    ![General tab in price list form](media/price-list-form.png "General tab in price list form")
  
6.	To add price per unit for a product, create and add price list items.

    a.	In the **Price List** form, select the **Price List Items** tab, and then select **Add New Price List Item**.

    ![Add New Price List Item button on the Price List Items tab](media/price-list-form-price-list-items-tab.png "Add New Price List Item button on the Price List Items tab")
 
    b.  In the **Price List Item** form, fill in the information, and select **Save**:

       -  **Product**. Select the product for which you’re creating this price list.

       -  **Unit**. Select the unit for the product you’re creating this price list for.

       -  **Currency**. The currency defined for the price list is automatically populated.

       -  **Discount List**. If you want to offer a discount on the products, select a discount list to the price list item. 

       -  **Quantity Selling Option**. select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the Quantity field of Quote Product, Order Product, and Invoice Product records. 

          ![Price list item form](media/price-list-item-form.png "Price list item form")

    c.  In the **Price List item** form, on the **Pricing information** tab, fill in the following information, and select **Save & Close**:

       -  **Pricing Method**. select an option that determines how the pricing will be calculated. It could be a certain amount, or a percentage of the current or standard cost. The available options are as follows: 
          -  **Currency Amount**. Use this to ignore a product's list price in the product catalog and to enter a different price manually for this price list.  
          
          -  **Percent of List**. Use this to calculate a product's price in the price list as a percentage of the list price of the associated product.  
        
          -  **Percent Markup - Current Cost**. Use this to add a percent markup on top of the current cost of the product.   

          - **Percent Markup - Standard Cost**. Use this to add a percent markup on top of the standard cost of the product.

          -  **Percent Margin - Current Cost**. Use this for the price offered in the price list to yield a percentage margin of the current cost of the product. 

          -  **Percent Margin - Standard Cost**. Use this for the price offered in the price list to yield a percentage margin of the standard cost of the product.

       -  **Amount**. If you selected **Currency Amount** as the pricing method, type the amount at which the product will be sold.

       -  **Percentage**. If you selected any value other than **Currency Amount** as the pricing method, type the percentage for the pricing method that you want.

       -  **Rounding Policy**. If you selected a pricing method other than **Currency Amount**, you can set up a rounding policy. For example, if you want per unit prices to be in the form of $0.99, you can select a rounding policy where all prices per unit automatically have a price that ends in 99 cents. To do this, you select the rounding policy to round the price up, and then set the price to end in a certain amount, such as 99 cents.

          -  **None**. Prices are not rounded.

          -  **Up**. Prices are rounded up to the nearest rounding amount.

          -  **Down**. Prices are rounded down to the nearest rounding amount.
    
          -  **To Nearest**. Prices are rounded to the nearest rounding amount.

       -  **Rounding Option**. Select **Ends in** or **Multiple of** if you want the price to end in a certain amount or multiples of a certain amount.

       -  **Rounding Amount**. Enter the amount.

          ![Pricing information tab on the price list form](media/pricing-information-tab-price-list-item-form.png "Pricing information tab on the price list form")
 
7.  You can also associate default price lists for territories so that the sales reps working with accounts on contacts in certain territories have the price list selected by default. 

    a.  In the price list record, select the **Territory Relationship** tab.

    b.	In the **Territories** section, select **Add New Connection**.

    c.	In the **New Connection** form, enter the following, and select **Save & Close**:

      -  **Name**. Select the Lookup button and select a territory.
      
      -  **As this role**. Select a connection role that is associated with the territory record type. 

          ![Add territory as connection](media/add-territory-as-connection.png "Add territory as connection")
 
    d.	In the price list record, select **Save & Close**.
  
      > [!NOTE]
      >  You must create at least one price list for each of the currencies that your organization does business in.  

## Create a price list  (Sales)
  
1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_prod_catalog](../includes/proc-settings-prod-catalog.md)]  
  
3. In the **Product Catalog** area, select **Price Lists**.  
  
4. To create a new price list, select **New**.  
  
    -OR-  
  
    To edit a price list, open a price list from the list.  
  
5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
6. Select **Save**.  
  
> [!NOTE]
>  You must create at least one price list for each of the currencies that your organization does business in.  
  
## Add items to the price list (Sales)

Create a price list item for each unit in which the product is available. For example, if the product is available as a single item (each), in a dozen, and in a gross, create three list items. This lets you order the product in any quantity you want, using the same price list. You can add price list items from the product form also.  
  
1. In the price list record, in the **Price List Items** section, select the **Add Record** button ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button").  
  
2. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
   - In the Product and Unit box, select the product and unit for which you're creating this price list item.  
  
   - To offer a discount on the combination of the product and unit, select a discount list.  
  
   - In the **Quantity Selling Option** drop-down box, select whether the product or service can be ordered in whole, partial, or both types of quantities. This information is used in the **Quantity** field of **Quote Product**, **Order Product**, and **Invoice Product** records:  
  
     - **No Control**. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] doesn't enforce a quantity selling option.  
  
     - **Whole**. Selling a partial product isn't allowed. For example, digital cameras cannot be sold in fractions.  
  
     - **Whole and Fractional**. The product can be sold both in whole and fractional units. For example, wood chips can be sold in cubic yards, or in fractions of a cubic yard.  
  
   - In the **Pricing Method** drop-down box, select an option that determines how the pricing will be calculated. It could be a certain amount, or a percentage of the current or standard cost. The available options are as follows: 
      -  **Currency Amount**. Use this to ignore a product's list price in the product catalog and to enter a different price manually for this price list.  
          
      -  **Percent of List**. Use this to calculate a product's price in the price list as a percentage of the list price of the associated product.  
        
      -  **Percent Markup - Current Cost**. Use this to add a percent markup on top of the current cost of the prouct.   

      - **Percent Markup - Standard Cost**. Use this to add a percent markup on top of the standard cost of the prouct.

      -  **Percent Margin - Current Cost**. Use this for the price offered in the price list to yield a percentage margin of the current cost of the product. 

      -  **Percent Margin - Standard Cost**. Use this for the price offered in the price list to yield a percentage margin of the standard cost of the product.
   
   - If you selected **Currency Amount** as the pricing method, in the **Amount** box, type the amount at which the product will be sold.  
  
      -OR-  
  
      If you selected any value other than **Currency Amount** as the pricing method, type the percentage for the pricing method that you want.  
  
   - If you selected a pricing method other than **Currency Amount**, you can set up a rounding policy. For example, if you want per unit prices to be in the form of $0.99, you can select a rounding policy where all prices per unit automatically have a price that ends in 99 cents. To do this, you select the rounding policy to round the price up, and then set the price to end in a certain amount, such as 99 cents.  
  
     - **None**. Prices are not rounded.  
  
     - **Up**. Prices are rounded up to the nearest rounding amount.  
  
     - **Down**. Prices are rounded down to the nearest rounding amount.  
  
     - **To Nearest**. Prices are rounded to the nearest rounding amount.  
  
   - In the **Rounding Option** drop-down box, select **Ends in** or **Multiple of** if you want the price to end in a certain amount or multiples of a certain amount.  
  
   - In the **Rounding Amount** box, enter the amount.  
  
3. Select **Save**.  
  
## Define default price list for territories  (Sales)

Make sales agents' job easier by adding default pricelists for territories or customer segments the agents are managing. When sales agents are working on opportunities, they see the default price list. Sales agents can later select other price list that they've permission on. You can have one price list as the default for multiple territories.  
   
1.  In the price list record, in the **Territory Relationships** section, select the **Add Record** button ![Add a record button](../sales-enterprise/media/add-recordbutton.gif "Add a record button").  
  
2.  In the **Connection** form, in **Name**, select the **Lookup** button, and select a territory.  
  
3.  Select **Save & Close**.  
  
4.  In the price list form, select the **Auto Save** button ![Auto save button](../sales-enterprise/media/auto-save-button.png "Auto save button").  
  
     When the sales agents set or change the customer for an opportunity, if a default price list is added to their territory (customer segment), it is shown.  
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/walkthrough-orange-right-arrow.png "Right arrow button") [Publish a product or bundle to make it available for selling](publish-product-bundle-make-available-selling.md)  
  
 ![Home button](../sales-enterprise/media/walkthrough-home.png "Home button") [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)  
  
### See also  
 [System Settings dialog box - Sales tab](../admin/system-settings-dialog-box-sales-tab.md)   
 [Classify products and bundles into product families](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)
