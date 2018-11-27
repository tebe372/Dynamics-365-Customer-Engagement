---
title: "getControlType (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 72d6c761-bcc7-4de6-b73f-5f2833297825
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getControlType (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getControlType-description.md](./includes/getControlType-description.md)]

## Syntax

`quickViewControl.getControlType();`

## Return Value

**Type**: String.

**Description**: For a quick view control, the method returns "quickform". 

For a constituent control in a quick view control, the method returns the actual category of the control. For more information about possible return values, see [getControlType](../controls/getControlType.md)..

### Related topics

[formContext.ui.quickForms](../formContext-ui-quickForms.md)
