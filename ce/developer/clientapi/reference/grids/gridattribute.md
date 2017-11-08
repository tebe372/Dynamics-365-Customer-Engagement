---
title: "GridAttribute (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 8139c622-e4d9-478f-9510-414d140e5556
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# GridAttribute (Client API reference)

GridRowData is returned by the [GridRow](gridrow.md).[getData](gridrow/getData.md) method.

GridRowData also provides methods for retrieving information specific to a record displayed in an editable grid row, including a collection of all the attributes included in the row. Attribute data is limited to the columns presented by the editable grid. See [Collections (Client API reference)](../collections.md) for information on the methods available to access data in a collection.

```JavaScript
var myRows = gridContext.getGrid().getRows();
var myRow = myRows.get(arg);
var gridRowData = myRow.getData();
```

## Methods

|Name|Description|
|--|--|
|[getEntity](gridrowdata/getEntity.md)|[!INCLUDE[gridrowdata/includes/getEntity-description.md](gridrowdata/includes/getEntity-description.md)]|


