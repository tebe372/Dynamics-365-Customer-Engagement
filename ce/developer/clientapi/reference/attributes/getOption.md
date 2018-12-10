---
title: "getOption (Client API reference)| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: e334d2d9-91c0-4953-956d-444a84dc9da2
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getOption (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns an option object with the value matching the argument (label or enumeration value) passed to the method. 

## Attribute types supported

OptionSet, MultiSelectOptionSet

## Syntax

`formContext.getAttribute(arg).getOption(value)`

## Parameters

**String** (label of the option) or **Number** (enumeration value of the option).

## Return Value

**Type**: Option object. 

**Description**: The logical name of the attribute.

