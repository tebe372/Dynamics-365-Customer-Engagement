---
title: "Form OnLoad Event (Client API reference) in Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 89123cde-7c66-4c7d-94e4-e287285019f8
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Form OnLoad Event (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

The form `OnLoad` event occurs after the form has loaded. It cannot prevent the window from loading. Use the `OnLoad` event to apply logic about how the form should be displayed, to set properties on fields, and interact with other page elements.

When the Microsoft Dynamics 365 for Customer Engagement apps for tablets client is disconnected, the `OnLoad` event is the only event that will occur. 