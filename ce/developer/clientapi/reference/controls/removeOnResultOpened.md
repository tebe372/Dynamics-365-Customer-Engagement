---
title: "removeOnResultOpened (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4d025f92-db16-440c-9f82-e40d71e09862
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# removeOnResultOpened (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Removes an event handler from the [OnResultOpened](../events/onresultopened.md) event. 

## Control types supported

knowledge base search control

## Syntax

```
var kbSearchControl = formContext.getControl("<name>");
kbSearchControl.removeOnResultOpened(myFunction);
```

## Parameters

|Name | Type | Required | Description|
|--|--|--|--|
|myFunction |Function |Yes|The function to remove from the **OnResultOpened** event.|

### Related topics

[OnResultOpened event](../events/onresultopened.md)

[addOnResultOpened](addOnResultOpened.md) 


