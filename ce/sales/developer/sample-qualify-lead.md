---
title: "Sample: Qualify a lead (Dynamics 365 Sales)"
description: "The sample demonstrates how to qualify a lead and create an account, contact, or opportunity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
helpviewer_keywords: 
  - sample for qualifying leads
  - qualifying leads, sample
  - creating lead-based accounts; contacts; or opportunities, sample
  - sample that creates lead-based accounts; contacts; or opportunities
ms.assetid: fb89b821-ed96-4a24-bae9-3e217f2cf1dc
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
---
# Sample: Qualify a lead

This sample code is for Dynamics 365 Sales. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../customerengagement/on-premises/includes/sdk-seeconnectionhelper.md)

## Demonstrates  
 This sample shows how to qualify a lead and create an account, contact, or opportunity based on the lead.  
  
## Example  
 [!code-csharp[BusinessManagement#WorkingWithLeads](../../snippets/csharp/CRMV8/businessmanagement/cs/workingwithleads.cs#workingwithleads)]  
  
### See also  
 [Sales Tables (Lead, Opportunity, Competitor, Quote, Order, Invoice)](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 <xref:Microsoft.Crm.Sdk.Messages.QualifyLeadRequest>   
 [Lead Table](lead-entity.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
