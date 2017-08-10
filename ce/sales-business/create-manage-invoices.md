---
title: "Create and manage invoices in Dynamics 365 for Sales, Business Edition | Microsoft Docs"
description: "Use invoices in Dynamics 365 for Sales, Business edition to bill your customers for the upcoming sale. "
keywords: "Invoice; quote; create invoice; email invoice"
author: shubhadaj
ms.author: shujoshi
manager: sakudes
applies_to: "Dynamics 365 (online)"
ms.date: 07/15/2017
ms.service: dynamics-365
ms.topic: article
ms.assetid: df953df7-d0ae-4b06-b41c-34cd9d7c3f5e
ms.reviewer: 
---
# Create and manage invoices in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)]

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Once your customer accepts the quote, you can create an invoice in [!INCLUDE[pn-ms-dyn-365-for-sales](../includes/pn-ms-dyn-365-for-sales.md)] to bill them for the upcoming sale.

You may also create an invoice that doesn’t generate from a quote.

## Create an invoice from a quote

1.  Click the Menu icon ![Icon to open the menu](media/open-menu-icon.png "Icon to open the menu"), and then click **Quotes**.

2.  Choose the active quote that you want to create an invoice from.

3.  On the command bar, click **Create Invoice**.

4.  Review the contents of the invoice and make any additions or corrections before sending to your customer.

## Create an invoice

1.  Click the Menu icon ![Icon to open the menu](media/open-menu-icon.png "Icon to open the menu"), and then click **Invoices**.

2.  Choose **New**.

3.  Add your customer’s contact information.

4.  Choose **Save** at the top left to create the invoice record.

5.  To add products from your opportunity to your order, choose **Get Products** at the top of the screen, select your opportunity, and click **OK**.

6.  To add information about a product on the invoice, in the **Products** area, choose the **Add a Product** button ![Icon for adding a record](media/add-record-icon.png "Icon for adding a record"), and then choose one of the following options:  

    - **Existing Product**. A product created in the product catalog that is associated with a price list.

    - **Write-in Product**. A product that is available but not a part of the product catalog.

    - **Get Products**. Select products from a previously created opportunity.

 You need to enter the tax amount when you add a product to a quote, order, or invoice. [!INCLUDE[pn-crm-shortest](../includes/pn-crm-shortest.md)] doesn’t automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.

7.  In the **Shipping Information** area, type shipping details.

8.  In the **Addresses** area, type shipping and billing addresses.

9.  Choose the **Save** button at the bottom right corner of the screen.

## Lock or unlock prices of an invoice

Price locked locks the price for a product in an open invoice. Even if the price changes in the product catalog, that invoice remains at the agreed price.

To lock the prices

1.  Go to the list of invoices and open the invoice that you want.

2.  To lock the price, on the command bar, click **Lock Pricing**. 

  - OR -
 
  To use the price of a product from the product catalog, click **Use Current Pricing**.  

## Close an invoice

You close an invoice either by canceling the invoice or setting the invoice status as paid. To do this, open the invoice you want to close, and on the command bar, click **Cancel Invoice** or **Invoice Paid**.

## Email an invoice

When you’ve added all the details to the invoice, send it to the customer.

To directly send an email to customer with an invoice attached, open the invoice, and on the command bar, click the **More Commands** icon ![Icon for More Commands](media/more-commands-icon.png "Icon for More Commands"), and then click **Send by Email**.  


### See Also
[Develop sales from lead to cash in Dynamics 365 for Sales, Business edition](develop-sales-lead-to-cash.md)  
[Meet the Sales app for small to medium-sized business](introduction-dynamics-365-for-sales-business-edition.md)
