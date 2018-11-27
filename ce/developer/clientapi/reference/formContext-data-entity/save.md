---
title: "save (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: a27f8267-9b24-42b7-a075-420a26db6693
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# save (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/save-description.md](./includes/save-description.md)]

## Syntax

`formContext.data.entity.save(saveOption);`

## Parameters

|Name|Type|Required|Description|
|--|--|--|--|
|saveOption|String|No|Specify options for saving the record. If no parameter is included in the method, the record will simply be saved. This is the equivalent of using the **Save** command.<br/>You can specify one of the following values:<br/><br/>- **saveandclose**: This is the equivalent of using the **Save and Close** command.<br/><br/>- **saveandnew**: This is the equivalent of the using the **Save and New** command.|

## Example

To open a new form after the save is completed:

`formContext.data.entity.save("saveandnew");`

### Related topics

[formContext.data.save](../formContext-data/save.md)

[formContext](../../clientapi-form-context.md)

