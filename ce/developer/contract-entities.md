---
title: "Contract entities (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Learn about contract entity that is used to track customer service agreements. You can create contracts for existing customers that specify the type of service and terms that apply to each customer."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
helpviewer_keywords: 
  - "contract status options, contract entities"
  - "status options, contract entities"
  - "contract entities, contract templates"
  - "contract entities, rules for using"
  - "contract entity, definition"
  - "contract templates, contract entities"
  - "contract entities, tracking customer services agreements"
  - "contract entities, status options"
  - "contract entities, introduction"
  - "tracking customer services agreements, contract entities"
ms.assetid: 631e9570-86e5-490e-98dd-ee27925ea8e8
caps.latest.revision: 30
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Contract entities

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], a *contract* is an agreement to provide support during specified coverage dates or for a specified number of cases or length of time. When customers contact customer service, the level of support they receive is determined by their contract.  
  
 The contract entity is used to track customer service agreements. You can create contracts for existing customers that specify the type of service and terms that apply to each customer. New contracts are created based on the contract template. You can create contracts only for existing accounts and contacts.  
  
 A contract has the status of “Draft” until it is invoiced. You can change the contract template until the contract status changes. Each new contract is assigned a unique ID that can’t be used for another contract unless it is being renewed. When you renew a contract, it is saved as a draft with an ID that corresponds to the original contract. If a contract with a status of “Invoiced” or “Active” is modified, the amended contract remains associated with the original account.  
  
## In This Section  
 [Contract Entity](entities/contract.md)  
  
 [ContractDetail Entity](entities/contractdetail.md)  
  
 [Sample: Manage Contracts](sample-manage-contracts.md)  
  
## Related Sections  
 [Service entities (contract, incident, knowledge base)](service-entities.md)  
  
 [Incident (case) entities](incident-case-entities.md)  
  
 [Knowledge base entities](knowledge-management-entities.md)
