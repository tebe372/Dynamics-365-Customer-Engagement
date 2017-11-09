---
title: "Grids and subgrids in Customer Engagement for Dynamics 365| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 9d35c036-637f-4580-8ba0-027a44c0fdee
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Grids and subgrids in Customer Engagement (Client API reference)

[!INCLUDE[](../../../includes/cc_applies_to_update_9_0_0.md)]

Grids present data in a tabular format in Customer Engagement. Grids can span the entire form or can be one of the items on a form; the latter are called *subgrids*.

## Types of grids

There are two types of grids in Customer Engagement:
- **Read-only grids**: Display data in a tabular format. To edit the data displayed in a read-only grid, you have to click the record in the grid to open the form, edit the data, and then save.
-  **Editable grids**: In addition to displaying data in a tabular format, provides rich inline editing capabilities on web and mobile clients including the ability to group, sort, and filter data within the same grid so that you do not have to switch records or views. The editable grid is a custom control, and is supported in the main grid and subgrids on a form in the web client and in dashboards and on form grids on the mobile clients. Although the editable grid control provides editing capability, it honors the read-only grid metadata and field-level security settings.

<a name="bkmk_gridcontext"></a>
## Getting the grid context

Grid context is the grid or subgrid instance on a form against which you want to run your code. You can use the execution context to get the form context, and then use the form context to get the grid context. For example:

```JavaScript
function doSomething(executionContext) {
    var formContext = executionContext.getFormContext(); // get the form context
    var gridContext = formContext.getControl("<Grid_Name>"); // get the grid context
    gridContext.getEntityName(); // excecute methods using the grid context
    // perform other operations on grids
}
```
## Events

|Name|Description|Applicable for|
|--|--|--|
|[Subgrid OnLoad Event](events/subgrid-onload.md)|Occurs every time the subgrid refreshes. This includes when users sort values in subgrid by clicking the column headings.|Read-only grids|
|[Grid OnChange](events/grid-onchange.md)|Occurs when a value is changed in a cell in the editable grid and the cell loses focus|Editable grids|
|[Grid OnRecordSelect](events/grid-onrecordselect.md)|Occurs when a single row (record) is selected in the editable grid|Editable grids|
|[Grid OnSave](events/grid-onsave.md)|Occurs before sending the updated information to the server, and when any of the following occurs: there is a change in the record selection, the user explicitly triggers a save operation using the editable grid’s save button, or the user applies a sort, filter, group, pagination, or navigation operation from the editable grid while there are pending changes.|Editable grids|

>[!NOTE]
>You can register for the **OnChange**, **OnRecordSelect**, and **OnSave** events using the **Events** tab of the Dynamics 365 Customer Engagement page that is used to enable editable grids for an entity or a read-only grid.

## Methods

|Name|Description|Available for|
|--|--|--|
|[GridControl](grids/gridcontrol.md)|Provides methods to work with the grid or subgrid control.|Editable and read-only grids|
|[Grid](grids/grid.md)|Provides methods to access information about data in the grid.|Editable and read-only grids|
|[GridRow](grids/gridrow.md)|Provides methods to work with rows or selected rows in the grid.|Editable and read-only grids|
|[GridRowData](grids/gridrowdata.md)|Provides methods to work with rows or selected rows in the grid.|Editable and read-only grids|
|[GridEntity](grids/gridentity.md)|Provides methods to access data about the specific records in the rows.|Editable and read-only grids|
|[GridAttribute](grids/gridattribute.md)|Provides methods to access the data in the cell of an editable grid.|Editable grid|
|[GridCell](grids/gridcell.md)|Provides methods to access the data related to control on a form that is tied to an attribute in an editable grid.|Editable grid|
|[ViewSelector](grids/viewselector.md)|Provides methods to get or set information about the view selector of the subgrid control.|Read-only grid|


### Related topics

[Client API Reference for Customer Engagement](../reference.md)

[Client API grid context](../clientapi-grid-context.md)

