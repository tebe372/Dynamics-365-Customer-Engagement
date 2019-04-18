---
title: "Configure communication panel for agents | MicrosoftDocs"
description: "Learn how to configure communication panel for agents using Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 68C78C8A-A4A3-4213-A0A4-F641B11A8541
ms.custom: 
---

# Configure communication panel for agents

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to set up a communication panel for agents to converse with customers. When agents accept an incoming conversation notification request, they use the communication panel to engage with the customer.

## Prerequisites 

- You must have the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)


- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The steps for configuring a communication panel in Unified Service Desk are as follows:

1.  Create hosted control.

2.  Create action calls.

3.  Attach the action calls to events.

4.  Add the hosted controls, actions, and events to the agent and supervisor configurations.

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create communication panel entity search forms](communication-panel-step1-create-entity-searches.md)

## See also

- [Step 2: Create action calls related to communication panel](communication-panel-step2-create-action-calls.md)
- [Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md)
- [Step 3: Attach communication panel-related action calls to events](communication-panel-step3-create-action-calls.md)
- [Step 5: Add the hosted control, action calls, and events to configurations](communication-panel-step5-add-hosted-control-action-calls-events-configurations.md)
