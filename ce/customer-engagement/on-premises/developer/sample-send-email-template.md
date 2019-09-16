---
title: "Sample: Send an email using a template (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to send an email message by using a template using the SendEmailFromTemplateRequest message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - sample for sending email messages, activity entities
  - activity entities samples, sending email messages
ms.assetid: d5e9b6e6-abf1-4d27-bed0-df2cd1006487
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Send an email using a template

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity entities](https://code.msdn.microsoft.com/Activities-Samples-61bf7504).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to send an email message by using a template using the <xref:Microsoft.Crm.Sdk.Messages.SendEmailFromTemplateRequest> message.  
  
## Example  
 [!code-csharp[Activities#SendEmailUsingTemplate](../snippets/csharp/CRMV8/activities/cs/sendemailusingtemplate.cs#sendemailusingtemplate)]  
  
### See also  
 [Sample Code for Activity](sample-code-activity-entities.md)   
 [Sample: Send an Email](sample-send-email.md)   
 [E-mail Activity Entities](email-activity-entities.md)   
 [Template Entity](entities/template.md)   
 [Sample: CrmServiceHelper Class](https://code.msdn.microsoft.com/Sample-Quick-start-for-650dbcaa/sourcecode?fileId=182557&pathId=222952671)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.SendEmailFromTemplateRequest>
