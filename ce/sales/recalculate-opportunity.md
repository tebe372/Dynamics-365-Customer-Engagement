---
title: "Recalculate an opportunity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Recalculate the opportunity in Dynamics 365 Sales to change the estimated revenue of an opportunity based on any changes you've made to the associated products or product quantities."
ms.date: 10/25/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Recalculate an opportunity in Dynamics 365 Sales

When you add a product to an opportunity, the opportunity's estimated revenue value is calculated based on the price, discounts, taxes, and other pricing modifications for the product.

To change the estimated revenue value of an opportunity based on any changes to the associated products or product quantities, recalculate the opportunity.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Recalculate an opportunity

1. In the list of opportunities, open the opportunity for which you want to recalculate the estimated revenue.

2. Go to the **Product Line Items** tab, and verify that **Revenue** is set to **System Calculated**.

3. In the grid, modify the list of products associated with the opportunity.

4. Select **Save**.

5. On the command bar, select **Recalculate Opportunity**.

> [!IMPORTANT]
> If there are any changes to existing opportunity products associated with closed opportunities, the prices aren't recalculated.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also  

[Create or edit an opportunity](../sales-enterprise/create-edit-opportunity-sales.md)  
[Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)   
[Print leads, quotes, and other records](../customerengagement/on-premises/basics/print-leads-quotes-other-records.md)  
[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  




[!INCLUDE[footer-include](../includes/footer-banner.md)]
