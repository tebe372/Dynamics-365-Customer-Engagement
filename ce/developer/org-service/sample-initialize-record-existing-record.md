---
title: "Sample: Initialize a record from an existing record (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to use the IOrganizationService.InitializeFromRequest message to create new records from an existing record"
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1d0d6df3-e905-4b63-beaa-3f72f73bfa17
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 15
topic-status: Drafting
---

# Sample: Initialize a record from an existing record

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. [Download the Sample: Initialize a record from an existing record (early bound)](https://code.msdn.microsoft.com/Sample-Initialize-a-record-f81879fa). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
-   [Full Sample – C#](sample-initialize-record-existing-record.md#full_C)  
  
## Demonstrates  
 This sample shows how to use the<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Crm.Sdk.Messages.InitializeFromRequest> message to create new records from an existing record.  
  
## Example  
 [!code-csharp[StrongTypes#InitializeFrom1](../../snippets/csharp/CRMV8/strongtypes/cs/initializefrom1.cs#initializefrom1)]  
  
<a name="full_C"></a>   
## Full Sample – C#  
 [!code-csharp[StrongTypes#InitializeFrom](../../snippets/csharp/CRMV8/strongtypes/cs/initializefrom.cs#initializefrom)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Retrieve license information](sample-retrieve-license-information.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.InitializeFromRequest>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*>