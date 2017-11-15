---
title: "Sample: Azure aware custom workflow activity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write a custom workflow activity that can post the data context from the current Dynamics 365 operation to the Azure Service Bus"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "azure"
ms.assetid: 089bc521-c50e-4030-bcd1-7b71e0d34557
caps.latest.revision: 32
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Azure aware custom workflow activity

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample obtains the data context from the current [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement operation and posts it to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)].  
  
 This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with Microsoft Dynamics 365 and Azure Integration](https://code.msdn.microsoft.com/Sample-Dynamics-365-and-6a95df2a)  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 You must configure [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to connect with [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] before registering and executing this sample custom workflow activity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Microsoft Azure Integration with Dynamics 365](configure-azure-integration.md).  
  
 Notice the “Input id” required argument in the code. When you add this activity to a workflow, you must provide the GUID of a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] service endpoint.
  
 When registering this custom workflow activity with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], you must register it in the sandbox (partial trust).  
  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to write a custom workflow activity that can post the data context from the current [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] operation to the [!INCLUDE[windows_azure_service_bus](../includes/windows-azure-service-bus.md)]. The posting of the data context is done through the [IExecutionContext)](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iserviceendpointnotificationservice.execute\(microsoft.xrm.sdk.entityreference,microsoft.xrm.sdk.iexecutioncontext\)) method.  
  
## Example  
 [!code-csharp[WindowsAzure#AzureAwareWorkflowActivity](../snippets/csharp/CRMV8/windowsazure/cs/azureawareworkflowactivity.cs#azureawareworkflowactivity)]  
  
### See also  
 [Sample Code for Dynamics 365 and Microsoft Azure Integration](sample-code-azure-integration.md)   
 [Sample: Persistent Queue Listener](sample-persistent-queue-listener.md)   
 [Custom Workflow Activities](custom-workflow-activities-workflow-assemblies.md)   
 <xref:Microsoft.Xrm.Sdk.IServiceEndpointNotificationService>
