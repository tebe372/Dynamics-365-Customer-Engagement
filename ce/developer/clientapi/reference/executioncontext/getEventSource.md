---
title: "getEventSource (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
description: "Learn about the getEventSource method that returns a reference to the object that the event occurred on."
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 9f3b2fed-fde5-46e4-8c59-43aa51aa82df
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getEventSource (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns a reference to the object that the event occurred on.

## Syntax

`ExecutionContextObj.getEventSource()`

## Return value

**Type**: Object

**Description**: Returns the object from the **Xrm** object model that is the source of the event, not an HTML DOM object. For example, in an [OnChange](../events/attribute-onchange.md) event, this method returns the **formContext.data.entity** attribute object that represents the changed attribute.


### Related topics
[Execution context](../execution-context.md)





