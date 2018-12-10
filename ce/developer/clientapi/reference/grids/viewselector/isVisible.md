---
title: "isVisible (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 11/10/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: d22cd046-064c-47ef-9e46-5cc4c8b6e280
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# isVisible (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/isVisible-description.md](./includes/isVisible-description.md)]

## Grid types supported

Read-only grid

## Syntax

`viewSelector.isVisible();`

## Return Value

**Type**: Boolean

**Description**: true if visible; false otherwise.

## Remarks

If the subgrid control is not configured to display the view selector, calling this method on the **ViewSelector** returned by the GridControl.getViewSelector method will throw an error.

To get the `viewSelector` object, see [ViewSelector](../viewselector.md).



