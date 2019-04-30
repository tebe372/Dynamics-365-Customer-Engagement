---
title: "Enable sales order processing integration (Dynamics 365 for Sales) | MicrosoftDocs"
description: ""
keywords: sales, developer guide
ms.date: 04/30/2019
ms.service:
  - dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: get-started-article
applies_to:
  - Dynamics 365 for Customer Engagement
  - Dynamics 365 for Customer Engagement apps version 9.x
ms.assetid: 94DFA02D-0793-48AA-B3E4-D5E61F0330CD
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: susikka
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 5
topic-status: Drafting
---
# Enable sales order processing integration

Sales order processing integration makes it convenient to connect Dynamics 365 for Sales with an external back office order processing application. It allows a sales order created on Dynamics 365 for Sales to be submitted, upon which the order can be synced to an external order processing application where the lifecycle of the order continues. A submitted order is locked for editing on Dynamics 365 for Sales except, if submitted by an integration user (to sync changes from the external order processing system to Dynamics 365 for Sales). 

By default, sales order processing is turned off. When sales order processing is turned off, Dynamics 365 for Sales allows invoices to be created from orders. For more information, see [Create an invoice from an order](../create-edit-invoice-sales.md). 

> [!NOTE]
> Price computation can be triggered by Dynamics 365 for Sales only if the sales entities, like Opportunity, Quote, Sales order and Invoice are editable.

## Enable sales order processing integration

You can enable sales order processing integration by setting the value of the [IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) attribute on the [Organization entity](../../developer/entities/organization.md) to Yes (1).

## What happens when sales order processing is turned on?

When sales order processing is turned on,  

- The **Create Invoice** button is not shown on the command bar of the Order records. 

- Order records will support a Submit order button. Upon submitting an order, the order is marked to `Submitted` status. The order is made read-only except, if created by an integration user. For more information about `IsIntegrationUser` attribute, see [IsIntegrationUser attribute](../../developer/entities/systemuser.md#BKMK_IsIntegrationUser) on [SystemUser entity](../../developer/entities/systemuser.md).

The table shown below lists the conditions that need to be satisfied before price computation is executed by Dynamics 365 for Sales for various entities.

|Entity name|Create|Update|Delete|Recalculate|
|------|------|------|------|------|
|Opportunity|Calculates always|Calculate always|NA|Calculate always|
|Quote|Calculate always|Calculate always|NA|Calculate always|
|Sales order|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|Calculation skips if -<br />([IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and sales order is in submitted state) or (logged in user is an integration user)|NA|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and sales order is in submitted state|
|Invoice|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|NA|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1)|
|Opportunity product|Calculate always|Calculate always|Calculate always|NA|
|Quote product|Calculate always|Calculate always|Calculate always|NA|
|Sales order product|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and ( logged in user is an integration user or sales order is in submitted state)|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and (logged in user is an integration user or sales order is in submitted state)|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|NA|
|Invoice product|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and logged in user is an integration user|NA|

## See also

[Organization entity reference](../../developer/entities/organization.md)<br />
[System user entity reference](../../developer/entities/systemuser.md)<br />
[Quote, order and invoice entities](../../developer/quote-order-invoice-entities.md)
