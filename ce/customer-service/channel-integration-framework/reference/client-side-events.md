---
title: "Client-side Events (JavaScript API Reference) for Channel Integration Framework (CIF) version 1.0 | Microsoft Docs"
description: "Read about the client side events that you can use to trigger the client-side code."
ms.date: 02/23/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Events (CIF JavaScript API reference)

All client-side code is initiated by events and the events occur in Dynamics 365 Unified Interface. You associate s specific function in a JavaScript library to execute when an event occurs. This specific function is called an *event handler*.

Each event handler specifies a function within a JavaScript library and the parameters that you can pass to the function. The JavaScript API provides methods that you can use to attach event handlers to the events.

## Events

| Events | Description |
|---------|-------------|
| [onClickToAct](events/onClickToAct.md) | Invoked when user selects the outbound communication (ClickToAct) field in a form. |
| [onModeChanged](events/onModeChanged.md) | Invoked when the panel mode is manually toggled between **Minimized (0)**, **Docked (1)** and **Hidden (2)**. |
| [onPageNavigate](events/onPageNavigate.md) | Invoked when the main Unified Interface page navigation occurs. |
| [onSendKBArticle](events/onSendKBArticle.md) | Invoked when the user selects the **Send** button in the Knowledge Base control. |
| [onSizeChanged](events/onSizeChanged.md) | Invoked when the side panel width is changed. |
| [onSessionSwitched](/dynamics365/customer-servi/dynamics365/channel-integration-framework/referen/v2/reference/events/onSessionSwitched) | Invoked when the session is switched. |
| [onSessionClosed](/dynamics365/customer-servi/dynamics365/channel-integration-framework/referen/v2/reference/events/onSessionClosed) | Invoked when the session is closed. |
| [CIFInitDone](events/cifinitdone.md) | Invoked when the Channel Integration framework is loaded to determine if Channel Integration Framework APIs are ready to be consumed. |


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
