---
title: "GridRow (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 02fef0b4-b895-4277-b604-3f525c29dca3
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# GridRow (Client API reference)

A collection of GridRow is returned by [Grid](grid.md).[getRows](grid/getRows.md) and [Grid](grid.md).[getSelectedRows](grid/getSelectedRows.md) methods.

```JavaScript
var myRows = gridContext.getGrid().getRows();
var gridRow = myRows.get(arg);
```

## Properties

|Name|Description|
|--|--|
|data|A collection containing the [GridRowData](gridrowdata.md) for the GridRow. See [Collections (Client API reference)](../collections.md) for information on the methods available for accessing data in a collection.|


## Methods

|Name|Description|
|--|--|
|[getData](gridrow/getData.md)|[!INCLUDE[gridrow/includes/getData-description.md](gridrow/includes/getData-description.md)]|

### Related topics

[GridRowData](gridrowdata.md)


