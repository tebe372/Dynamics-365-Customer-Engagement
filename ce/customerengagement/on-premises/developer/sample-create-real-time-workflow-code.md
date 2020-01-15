---
title: "Sample: Create a real-time workflow in code (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows you how to create a real-time workflow in code instead of using the interactive workflow designer in the web application. This sample works only with an on-premises or an Internet-facing deployment (IFD) of Dynamics 365 Customer Engagement because custom XAML workflows aren’t supported in Dynamics 365 Customer Engagement (on-premises). "
ms.custom: 
ms.date: 1/14/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 78a964e8-0f5a-4075-8d22-32b984e3c0c3
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a real-time workflow in code

[!INCLUDE[cc-sample-note](./includes/cc-sample-note.md)]

Download the sample: [Workflow](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/Workflow)

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  

To obtain a local copy of all samples, do the following:
1. Download or clone the  [Samples](https://github.com/microsoft/PowerApps-Samples) repo so that you have a local copy.
2. (Optional) Edit the cds/App.config file to define a connection string specifying the instance/org you want to connect to.
3. Open the sample solution in Visual Studio and press **F5** to run the sample. After you specify a connection string in cds/App.config, any sample you run will use that connection information.

If you do not specify a connection string in cds/App.config file, a dialog will open each time you run the sample and you will need to enter information about which instance/org you want to connect to and which credentials you want to use. This dialog will cache previous connections so that you can choose a previously used connection.

Consult the sample's [README](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/Workflow/README.md) for additional information about the sample.
  
## Demonstrates  
 The sample shows you how to create a real-time (synchronous) workflow in code instead of using the interactive workflow designer in the web application.

## Example  
[CreateRealTimeWorkflow.cs](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/Workflow/Workflow/CreateRealTimeWorkflow.cs)
  
### See also  
 [Create real-time workflows](create-real-time-workflows.md)   
 [Sample: Set the State of a Workflow](sample-set-state-workflow.md)   
 [Workflow and Process Entities](workflow-process-entities.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)
