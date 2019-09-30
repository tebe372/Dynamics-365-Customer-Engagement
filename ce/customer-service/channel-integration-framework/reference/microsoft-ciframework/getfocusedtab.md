---
title: "getFocusedTab (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: A31C497C-CA8A-47DF-8D8D-5A1458C9FBA1
author: susikka
ms.author: susikka
manager: shujoshi
---

# getFocusedTab 

Returns the focused tab's tabId in focused session, if the session belongs to the provider.

## Syntax

Microsoft.CIFramework.getFocusedTab().then(successCallback,errorCallback);

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                 |
|-----------------|----------|--------------|-------------------------------------------------|
| successCallback | Function | No           | A function to call when the operation succeeds. |
| errorCallback   | Function | No           | A function to call when the operation fails.    |

## Returns

Promise with the value as String

## Example

```javascript
Microsoft.CIFramework.getFocusedTab().then(
function success(result) {
console.log(result);
// perform operations on tab id value
},
function (error) {
console.log(error.message);
// handle error conditions
}
);
```