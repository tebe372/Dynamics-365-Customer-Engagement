---
title: "createSession (JavaScript API Reference) for Channel Integration Framework (CIF) | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 67525775-FB29-45CA-B2D1-582BAE59C3AF
author: susikka
ms.author: susikka
manager: shujoshi
---

# createSession

Creates a session based on the session template defined as part of the template and returns the unique identifier of the session (Id) that was created.

## Syntax

Microsoft.CIFramework.createSession(input, correlationId).then(successCallback, errorCallback);

## Parameters

| **Name**              | **Type** | **Required** | **Description**                                                                                                                      |
|-----------------------|----------|--------------|--------------------------------------------------------------------------------------------------------------------------------------|
| Input                 | String   | Yes          | JSON string                                                                                                                          |
| successCallback       | Function | No           | A function to call when the request is successful. The input to this function is the unique identifier of the newly created session. |
| errorCallback         | Function | No           | A function to call when the request fails                                                                                            |

The structure of the `Input` parameter JSON is shown below.

```json
{ 
   "templateName":"<name of session template>",
   "templateTag":"<template tag>",
   "templateParameters":{ 
      "globalparam":"number value OR boolean value OR json string value OR parameterized string value",
      "app template 1":{ 
         "param 1":"number value OR boolean value OR json string value OR parameterized string value",
         "param 2":"..."
      },
      "app template 2":"…."
   }
}
```

## Return Value

Promise with the value as String

## Example

```javascript
var input = {
templateName: "CallSessionTemplate",
// name of the configured template
templateParameters: {
customer: "Contoso",
}
// Global and application tab template parameters, these values will override configured values
};
Microsoft.CIFramework.createSession(input).then(
function success(sessionId) {
console.log(sessionId);
// perform operations on session Id retrieved
},
function (error) {
console.log(error.message);
// handle error conditions
}
);
```