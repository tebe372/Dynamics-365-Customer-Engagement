---
title: "focusTab (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/31/2019
ms.topic: reference
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# focusTab

[!include[cc-beta-prerelease-disclaimer](../../../../../includes/cc-beta-prerelease-disclaimer.md)]

Sets the focus on a tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.

## Syntax

`Microsoft.CIFramework.focusTab(tabId, correlationId).then(successCallback, errorCallback);`

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                |
|-----------------|----------|--------------|------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab                   |
| successCallback | Function | No           | A function to call when a record is retrieved. |
| errorCallback   | Function | No           | A function to call when the operation fails.   |

## Return Value

None

## Example

```javascript
Microsoft.CIFramework.focusTab(tabId, correlationId).then(
function(result) {
return Promise.resolve(result);
},
function(error) {
return Promise.reject(error)
};
```
