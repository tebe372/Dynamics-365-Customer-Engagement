---
title: "prependOrgName (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 89123cde-7c66-4c7d-94e4-e287285019f8
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# prependOrgName (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

Prefixes the current organization's unique name to a string, typically a URL path.

## Syntax

 ```JavaScript
var globalContext = Xrm.Utility.getGlobalContext();
globalContext.prependOrgName(sPath);
```

## Parameters

|Name |Type |Required |Description |
|---|---|---|---|
|sPath |String |Yes |A local path to a resource. |

## Return Value

**Type**: String

**Description**: A path string with the organization name prefixed in the following format:

`"/"+ orgName + sPath`

### Related topics

[Xrm.Utility.getGlobalContext](../getGlobalContext.md)


