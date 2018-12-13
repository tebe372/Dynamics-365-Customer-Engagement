---
title: "getMax (Client API reference)| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 6bcd4b47-b3b6-4a9c-899f-a5dce4cbab51
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getMax (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Returns a number indicating the maximum allowed value for an attribute. 

## Attribute types supported

decimal, integer, double, money

## Syntax

`formContext.getAttribute(arg).getMax()`

## Return Value

**Type**: Number. 

**Description**: The maximum allowed value for the attribute.

