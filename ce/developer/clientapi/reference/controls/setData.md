---
title: "setData (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 4d025f92-db16-440c-9f82-e40d71e09862
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# setData (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Sets the value of the data query string parameter passed to a Silverlight web resource.

## Control types supported

webresource 

## Syntax

`formContext.getControl(arg).setData(string);`

## Parameter

|Name|Type|Required|Description|
|--|--|--|--|
|string|String|Yes|The data value to pass to the Silverlight web resource.|

## Related topics

[getData](getData.md)
