---
title: "Sample: Share records using GrantAccess, ModifyAccess and RevokeAccess messages (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to share a record using the following messages:GrantAccessRequest, ModifyAccessRequest, and RevokeAccessRequest."
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 791aa59d-b217-4e8d-93d3-edd4ecfc8403
author: KumarVivek
ms.author: kvivek
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - "sharing records sample"
topic-status: Drafting
---

# Sample: Share records using GrantAccess, ModifyAccess and RevokeAccess messages

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://code.msdn.microsoft.com/Work-with-early-bound-6914f6e7).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to share a record using the following messages:  
  
-   <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>  
  
-   <xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>  
  
-   <xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>  
  
## Example  
 [!code-csharp[strongtypes#UserAccess](../snippets/csharp/CRMV8/strongtypes/cs/useraccess.cs#useraccess)]  
  
### See also  
 [User and Team Entities](user-team-entities.md)   
 [Introduction to Entities in Dynamics 365](introduction-entities.md#Share)   
 <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>   
 [Sample: Create an On-Premises User](sample-create-on-premises-user.md)   
 [Introduction to Entities in Dynamics 365](introduction-entities.md)
