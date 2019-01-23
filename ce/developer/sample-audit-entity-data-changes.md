---
title: "Sample: Audit entity data changes (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Sample demonstrating how to audit entity data changes."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: d30356c5-da29-4466-8356-ec3d1acad578
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sample for audit entity data changes
  - auditing entity data changes in Microsoft Dynamics CRM, sample for audit entity data changes
  - sample for enabling and disabling auditing, on entities and their attributes
  - enabling and disabling auditing sample, on entities and their attributes
  - audit entity data changes sample
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Audit entity data changes

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the code samples of audit entity data changes and audit user access](https://code.msdn.microsoft.com/Audit-entity-data-changes-93eb8ae0).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 [!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)] This sample requires the logged on user to have the System Administrator role.  
  
## Demonstrates  
 How to enable and disable auditing on an entity and its attributes, retrieve the data change history of the audited entity, and delete the audit records.  
  
## Example  
 [!code-csharp[Auditing#Auditing](../snippets/csharp/CRMV8/auditing/cs/auditing.cs#auditing)]  
  
### See also  
 [Audit Entity Data Changes in Dynamics 365 for Customer Engagement apps](audit-entity-data-changes.md)   
 [Sample: Audit User Access](sample-audit-user-access.md)   
 [Audit Entity](entities/audit.md)<!-- Bug 696490 -->  
 <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled>   
 <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsAuditEnabled>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveRecordChangeHistoryRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AttributeAuditDetail>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveAuditPartitionListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.DeleteAuditDataRequest>
