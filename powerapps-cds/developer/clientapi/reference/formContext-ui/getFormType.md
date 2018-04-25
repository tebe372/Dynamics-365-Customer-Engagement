---
title: "getFormType (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 6c57db71-a76d-404c-852e-9c36a1c549ee
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getFormType (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getFormType-description.md](./includes/getFormType-description.md)]

## Syntax

`formContext.ui.getFormType();`

## Return Value

**Type**: Number

**Description**: Form type. Returns one of the following values 

|Value |Form type |
|---|---|
|0|Undefined|
|1|Create|
|2|Update|
|3|Read Only|
|4|Disabled|
|6|Bulk Edit|

>[!NOTE]
>Quick Create forms return 1.


### Related topics

[formContext.ui](../formContext-ui.md)

[formContext](../../clientapi-form-context.md)

