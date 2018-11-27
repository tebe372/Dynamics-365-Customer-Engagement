---
title: "getInitialValue (Client API reference)| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 56fb62e6-d357-4096-bf4c-f4c1b543d633
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getInitialValue (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns a value that represents the value set for a **Boolean**, **OptionSet** or **MultiSelectOptionSet** attribute when the form is opened.

## Attribute types supported

Boolean, OptionSet, MultiSelectOptionSet 

## Syntax

`formContext.getAttribute(arg).getInitialValue()`

## Return Value

**Type**: Number

**Description**: The initial value for the attribute.


