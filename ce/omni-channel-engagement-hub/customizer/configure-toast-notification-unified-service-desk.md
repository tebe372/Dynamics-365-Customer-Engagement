---
title: "Configure toast notifications in Unified Service Desk | MicrosoftDocs"
description: "Learn how to configure toast notification for agents in Omni-channel Engagement Hub using Unified Service Desk settings."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 476eb2cf-05e7-42ef-a268-4cb6342fb9b2
ms.custom: 
---
# Configure toast notifications in Unified Service Desk.

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Prerequisites

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Steps for configuring toast notification

The process of configuring toast notification (floating notification) settings in Unified Service Desk involves multiple steps:

1. Create forms with notifications definition (XAML).

2. Create Hosted Control.

3. Create Action Calls.

4. Attach the Action Calls to Events

5. Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations.

Consider a scenario where you receive a case request. What is the interaction experience for this case request?

You see a toast notification for the case request. Therefore, the following events must be created: 

 - Create an event to open a session when the agent selects the toast notification.

 - Create an event and action when an agent does not act, and the notification hides after a brief wait time.

## Create an event to open a session when the agent selects the toast notification

You must define an event and attach the action calls for an agent to select the case request notification. When the agent selects the notification, the agent will experience the following actions:

-  The notification closes.

-  The right panel expands.

-  Omni-channel customer session is created.

-  The communication control panel does not load as it is not a chat request.

-  Load the form of the case

-  Load the Omni-channel session for the case entity

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)

## See also

- [Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create an action call to display the notification](toastnotification-step3-create-action-call-display-notification.md)
- [Step 4: Add the action calls to the events](toastnotification-step4-add-action-calls-events.md)
- [Step 5: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)
