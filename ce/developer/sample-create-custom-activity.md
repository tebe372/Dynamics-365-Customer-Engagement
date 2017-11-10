---
title: "Sample: Create a custom activity (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The following code example demonstrates how to create a custom activity using the CreateEntityRequest and CreateAttributeRequest messages"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4cd4c951-7c4f-4280-b928-0d901f62ef08
caps.latest.revision: 19
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Create a custom activity

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample of [work with entity metadata](https://code.msdn.microsoft.com/Samples-of-entities-916efa41). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The following code example demonstrates how to create a custom activity using the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> and <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> messages.  
  
## Example  
 [!code-csharp[Entities#CreateCustomActivityEntity](../snippets/csharp/CRMV8/entities/cs/createcustomactivityentity.cs#createcustomactivityentity)]  
  
### See also  
 [Sample Code for Activity Entities](sample-code-activity-entities.md)   
 [Custom Activities in Dynamics 365](custom-activities.md)   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)   
 [Sample: Create, Retrieve, Update, and Delete an Email Attachment](sample-create-retrieve-update-delete-email-attachment.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>