---
title: "setSharedVariable (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
description: "Learn about the getEventSource method that returns a reference to the form or an item on the form depending on where the method was called."
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 702a13c1-f4ae-4de2-9e8b-95360ad9240c
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# setSharedVariable (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Sets the value of a variable to be used by a handler after the current handler completes.

## Syntax

`ExecutionContextObj.setSharedVariable(key, value)`

## Parameters

- **key**: String: The name of the variable
- **Value**: Object. The values to set



## Return value

**Type**: Object

**Description**: The specific type depends on what the value object is.

### Related topics
[getSharedVariable](getSharedVariable.md)

[Execution context](../execution-context.md)





