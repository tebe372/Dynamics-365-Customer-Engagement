---
title: "Sample: Web access from a sandboxed plug-in (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample demonstrates how to code a plug-in that has Web (network) access and be registered in the sandbox. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 5cfa323a-1407-4651-a602-9f99e6370e5f
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Web access from a sandboxed plug-in

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]
Download the sample: [Work with plug-ins](https://code.msdn.microsoft.com/Sample-Create-a-basic-plug-64d86ade).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. 
  
 Register the compiled plug-in to run in the sandbox on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server.  
  
## Demonstrates  
 Demonstrates how to code a plug-in that has Web (network) access and be registered in the sandbox.  
  
## Example  
 [!code-csharp[Plug-ins#WebClientPlugin](../snippets/csharp/CRMV8/plug-ins/cs/webclientplugin.cs#webclientplugin)]  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Write a Plug-in](write-plugin.md)   
 <xref:Microsoft.Xrm.Sdk.IPlugin>   
 <xref:Microsoft.Xrm.Sdk.ITracingService>
