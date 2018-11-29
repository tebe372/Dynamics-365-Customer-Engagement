---
title: "Sample: Dump global option set information to a file | MicrosoftDocs"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: b9437469-70b5-4a3c-ae49-115522fb5cee
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Dump global option set information to a file

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] apps. Download the sample: [Work with global option sets](https://code.msdn.microsoft.com/Samples-of-option-set-37c4b418). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write out all the global OptionSet metadata to an XML file. It uses the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllOptionSetsRequest> message.  
  
 The following sample creates a new file at `\OptionSets\bin\Debug\AllOptionSetValues.xml`. You can open this file in [!INCLUDE[pn_MS_Excel_Full](../../includes/pn-ms-excel-full.md)] to see a tabular report. You may need this information to discover the entity type code for a custom entity for use in reports.  
  
## Example  
 [!code-csharp[optionsets#DumpOptionSetInfo](../../snippets/csharp/CRMV8/optionsets/cs/dumpoptionsetinfo.cs#dumpoptionsetinfo)]  
  
### See also  
 [Use the Organization service with Dynamics 365 for Customer Engagement apps metadata](use-organization-service-metadata.md)   
 [Customize Global Option Sets in Dynamics 365 for Customer Engagement apps](../org-service/customize-global-option-sets.md)   
 [Global Option Set Messages](customize-global-option-sets.md#messages)   
