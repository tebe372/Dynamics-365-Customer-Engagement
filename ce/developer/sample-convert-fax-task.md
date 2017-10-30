---
title: "Sample: Convert a fax to a task (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create a task for a fax by using the IOrganizationService.Entity) method"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f82fe3eb-1867-4edb-869d-58081f38d653
caps.latest.revision: 23
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Sample: Convert a fax to a task
This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity entities](https://code.msdn.microsoft.com/Activities-Samples-61bf7504). 
  
## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a task for a fax by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method.  
  
## Example  
 [!code-csharp[Activities#ConvertFaxToTask](../snippets/csharp/CRMV8/activities/cs/convertfaxtotask.cs#convertfaxtotask)]  
  
### See also  
 [Sample Code for Activity](sample-code-activity-entities.md)   
 [Fax Entity](entities/fax.md)   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 [Sample: Promote an Email Message to Dynamics 365](sample-promote-email-message.md)
