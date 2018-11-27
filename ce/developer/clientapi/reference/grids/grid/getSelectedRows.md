---
title: "getSelectedRows (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 11/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 49f39f0f-33ef-41d1-9ab3-14966ae075b5
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getSelectedRows (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getSelectedRows-description.md](./includes/getSelectedRows-description.md)]

## Grid types supported

Read-only and editable grids

## Syntax

`var allSelectedRows = gridContext.getGrid().getSelectedRows();`

## Return Value

**Type**: Collection

**Description**: A collection of selected rows in the grid.

## Remarks

To get the `gridContext`, see [Getting the grid context](../../grids.md#bkmk_gridcontext).

See [Collections (Client API reference)](../../collections.md) for information on the methods available to access data in a collection.

