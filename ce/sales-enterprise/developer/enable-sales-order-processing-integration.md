---
title: "Enable sales order processing integration (Dynamics 365 Sales) | MicrosoftDocs"
description: <!--Need a description here.-->
ms.date: 07/09/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: get-started-article
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: susikka
---
# Enable sales order processing integration

Sales order processing integration makes it convenient to connect Dynamics 365 Sales with an external back-office order processing application. It allows a sales order created on Dynamics 365 Sales to be submitted, after which the order can be synced to an external order processing application where the lifecycle of the order continues. A submitted order is locked for editing on Dynamics 365 Sales unless it was submitted by an integration user (to sync changes from the external order processing system to Dynamics 365 Sales). 

By default, sales order processing is turned off. When sales order processing is turned off, Dynamics 365 Sales allows invoices to be created from orders. More information: [Create an invoice from an order](../create-edit-invoice-sales.md)

> [!NOTE]
> Price computation can be triggered by Dynamics 365 Sales only if the sales entities&mdash;like<!--Is this the complete list of sales entities for this context? If so, you don't need "like".--> Opportunity, Quote, Sales order, and Invoice&mdash;are editable.

## Enable sales order processing integration

You can enable sales order processing integration by setting the value of the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) attribute on the [Organization entity](../../customerengagement/on-premises/developer/entities/organization.md) to **Yes (1)**.

## What happens when sales order processing is turned on?

When sales order processing is turned on:  

- The **Create Invoice** button isn't shown on the command bar of the order records. 

- Order records will support a **Submit** order button.<!--What does "will support" mean here? Does the reader need to make this happen, or will the **Submit** button automatically appear?--> When the order is submitted, the status for the order is marked as `Submitted` and the order is made read-only, unless it was created by an integration user. More information: [IsIntegrationUser attribute](../../customerengagement/on-premises/developer/entities/systemuser.md#BKMK_IsIntegrationUser)<!--You don't need this additional cross-reference because you're already pointing the reader to this article.-->

The following table lists the conditions that need to be satisfied before Dynamics 365 Sales executes price computation for various entities.
<!--In the following table, I don't know what the hyphen meant. I assume replacing it with "the" is valid. -->
|Entity name|Create|Update|Delete|Recalculate|
|------|------|------|------|------|
|Opportunity|Calculate always|Calculate always|Not applicable<!--Via Writing Style Guide-->|Calculate always|
|Quote|Calculate always|Calculate always|Not applicable|Calculate always|
|Sales order|Calculation is skipped if the <!--I don't know what the hyphen and line break are meant to indicate here. I don't think you need them.-->[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the sales order is in a submitted state or the signed-in user is an integration user|Not applicable|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the sales order is in a submitted state|
|Invoice|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Not applicable|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|
|Opportunity product|Calculate always|Calculate always|Calculate always|Not applicable|
|Quote product|Calculate always|Calculate always|Calculate always|Not applicable|
|Sales order product|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user or the sales order is in a submitted state|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user or sales order is in a submitted state|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Not applicable|
|Invoice product|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Calculation is skipped if the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to **Yes (1)** and the signed-in user is an integration user|Not applicable|

#### To turn off the sales order processing setting

1. Go to **Sales Hub**, and then select **App Settings**.
2. Select **General/Overview**, and then select **Back Office Order Processing Integration**.
3. Select **Manage**, and then set the toggle switch to **Off**.

> [!NOTE]
> The setting can only be turned off if it was already enabled. After it's turned off, the setting won't be displayed in the UI.

### See also

[Organization entity reference](../../customerengagement/on-premises/developer/entities/organization.md)<br />
[System user entity reference](../../customerengagement/on-premises/developer/entities/systemuser.md)<br />
[Quote, order, and invoice entities](../../customerengagement/on-premises/developer/quote-order-invoice-entities.md)
