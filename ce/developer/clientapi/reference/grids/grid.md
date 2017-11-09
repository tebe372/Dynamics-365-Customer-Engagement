---
title: "Grid (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 11/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 02fef0b4-b895-4277-b604-3f525c29dca3
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Grid (Client API reference)

Grid is returned by the **gridContext**.[getGrid](gridcontrol/getGrid.md) method. Use Grid methods to access information about data in the grid.

`var myGrid = gridContext.getGrid();`

## Methods

|Name|Description|Available for|
|--|--|--|
|[getRows](grid/getRows.md)|[!INCLUDE[grid/includes/getRows-description.md](grid/includes/getRows-description.md)]|Editable and read-only grids|
|[getSelectedRows](grid/getSelectedRows.md)|[!INCLUDE[grid/includes/getSelectedRows-description.md](grid/includes/getSelectedRows-description.md)]|Editable and read-only grids|
|[getTotalRecordCount](grid/getTotalRecordCount.md)|[!INCLUDE[grid/includes/getTotalRecordCount-description.md](grid/includes/getTotalRecordCount-description.md)]|Editable and read-only grids|

### Related topics

[GridRow](gridrow.md)

[Grids and subgrids in Customer Engagement](../grids.md)
