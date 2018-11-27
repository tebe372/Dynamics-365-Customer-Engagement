---
title: "Sample: Audit user access (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrating the auditing of user access to records."
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: db508858-7386-44f3-9f91-29493e6fe2c4
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - "auditing entity data changes in Microsoft Dynamics CRM, sample for auditing user access"
  - "sample for auditing user access"
  - "auditing user access sample"
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Audit user access

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the code samples of audit entity data changes and audit user access](https://code.msdn.microsoft.com/Audit-entity-data-changes-93eb8ae0).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 [!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)] This sample requires the logged on user to have the System Administrator role for enabling auditing on an organization.  
  
## Demonstrates  
 This sample demonstrates how to audit user access to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Example  
 The sample first enables user access auditing with the logged on user’s organization. Next, it creates and modifies an account entity so that audit records are generated. Finally, the sample displays the audited information.  
  
 [!code-csharp[auditing#useraccessauditing](../snippets/csharp/CRMV8/auditing/cs/useraccessauditing.cs#useraccessauditing)]  
  
### See also  
 [Audit Entity Data Changes in Dynamics 365 for Customer Engagement](audit-entity-data-changes.md)   
 [Audit Entity](entities/audit.md)<!-- Bug 696490 -->
