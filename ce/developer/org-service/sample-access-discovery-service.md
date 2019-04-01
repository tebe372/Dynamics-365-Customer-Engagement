---
redirect_url: https://docs.microsoft.com/powerapps/developer/common-data-service/org-service/discovery-service
title: "Sample: Access the Discovery service (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "The sample demonstrates how to obtain organization information, including the organization’s URL, from the DiscoveryService Web service."
ms.custom: 
ms.date: 12/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 34249eb1-378e-4dd2-9c02-f14bcd470b64
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Access the Discovery service

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete: [Access the discovery service](https://code.msdn.microsoft.com/Sample-Access-the-6dea28f1). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Demonstrates  
 How to obtain organization information, including the organization’s URL, from the DiscoveryService Web service.  
  
## Example  
 [!code-csharp[DiscoveryService#DiscoveryService](../../snippets/csharp/CRMV8/discoveryservice/cs/discoveryservice.cs#discoveryservice)]  
  
### See also  
 [Use IDiscoveryService to Discover the URL for Your Organization](discover-url-organization-organization-service.md)   
 <xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy>   
 <xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationsRequest>   
 <xref:Microsoft.Xrm.Sdk.Discovery.OrganizationDetail>
