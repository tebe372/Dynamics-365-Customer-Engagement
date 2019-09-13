---
title: "Sample: Promote an email message to Dynamics 365 Customer Engagement (on-premises)| MicrosoftDocs"
description: "This sample shows how to create an email activity instance from the specified email message in Dynamics 365 for Customer Engagement by using the DeliverPromoteEmailRequest message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 69763a0a-af67-48b8-adf2-470c1cdf6196
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Promote an email message to Dynamics 365 Customer Engagement (on-premises)

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity entities](https://code.msdn.microsoft.com/Activities-Samples-61bf7504). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
    
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create an email activity instance from the specified email message in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by using the <xref:Microsoft.Crm.Sdk.Messages.DeliverPromoteEmailRequest> message.  
  
## Example  
 [!code-csharp[Activities#DeliverPromoteEmail](../snippets/csharp/CRMV8/activities/cs/deliverpromoteemail.cs#deliverpromoteemail)]  
  
### See also  
 [Sample Code for Activity](sample-code-activity-entities.md)   
 [E-mail Activity Entities](email-activity-entities.md)   
 [Sample: CrmServiceHelper Class](org-service/helper-code-serverconnection-class.md)   
 [Sample: Send an Email Using a Template](sample-send-email-template.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.DeliverPromoteEmailRequest>
