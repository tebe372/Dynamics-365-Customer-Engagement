---
title: "Unified Service Desk for Dynamics 365 for Customer Engagement apps system requirements | MicrosoftDocs"
description: "Describes the supported dependent and optional components you need to install and use Unified Service Desk for Dynamics 365 for Customer Engagement apps. "
keywords: 
ms.date: 01/25/2019
ms.service:
  - dynamics-365-customerservice
ms.custom:
  - dyn365-USD, dyn365-admin
ms.topic: get-started-article
applies_to:
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: 8a0e7dc4-5d32-412a-ae72-b6ce010c1c85
author: kabala123
ms.author: kabala
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Requirements
This topic provides information about the system requirements for installing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application and deploying the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications on a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps instance.  

<a name="hardware"></a>   
## Hardware requirements for the Unified Service Desk client  
 The following table lists the minimum and recommended hardware requirements when you run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  


| Component |                                           Minimum                                           |                                                                                                                                                                            Recommended                                                                                                                                                                            |
|-----------|---------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Processor | x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor |                                                                                                                                    x86- or x64-bit 1.9 gigahertz (GHz) dual core with SSE2 instruction set or faster processor                                                                                                                                    |
|  Memory   |                                      ^4-GB RAM or more                                       |                                                                                                                                                                         8-GB RAM or more                                                                                                                                                                          |
| Hard disk |                            \*1.5 GB of available hard disk space                            | 12 GB of available hard disk space: 2 GB of available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application files and 10 GB additional available hard disk space for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client log files<br /><br /> 7200 RPM or more |

 ^The minimum memory is for running basic scenarios. The actual memory required for Unified Service Desk increases with the complex configurations and custom development (UI experience).
 
 *Requires disabling [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client logging. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure client diagnostic logging in Unified Service Desk](../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  

<a name="client"></a>   
## Software requirements for the Unified Service Desk client

 To install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on a computer, the following is required:  

| Requirement | Recommended Version | Supported Version|
|---------------------------|---------------------------|-------------------------------------|
| Operating system | <ul><li>[!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)] </li></ul> |<ul><li> [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)] </li><li> [!INCLUDE[pn_windows_8_1](../../includes/pn-windows-8-1.md)]</li><li> [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)]</li><li> [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)] Service Pack 1 (SP1)</li></ul>  |
| Hosting Types | <ul><li> Chrome Process </li></ul> | <ul><li> Chrome Process </li><li> IE Process</li><li>Edge Process</li></ul> **Note:** Currently Edge Process is in Preview. |
| Microsoft .NET Framework | <ul><li>[!INCLUDE[pn_NET_Framework_462_long](../../includes/pn-net-framework-462-long.md)] (installed during [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Setup if missing)</li></ul> |  |
| Windows Identity Foundation  | <ul><li> Windows Identity Foundation 3.5 (installed during Unified Service Desk Setup if missing) </li></ul> |  |
| Screen resolution | <ul><li> 1920 x 1080 (Pixels) </li></ul> |  |
| Magnifier | <ul><li> 100 % </li></ul> |


## Support matrix of Microsoft Dynamics 365 for Customer Engagement and Unified Service Desk

This matrix describes supported versions of Microsoft Dynamics 365 for Customer Engagement and Unified Service Desk and compatible versions.

| | Customer Engagement 9.1 | Customer Engagement 9.0 | Customer Engagement 8.2 |
|:---------------------------:|:---------------------------:|:---------------------------:|:---------------------------:|
| Unified Service Desk 4.1 |![Yes](../../unified-service-desk/media/tick.PNG "Yes") | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") |
| Unified Service Desk 4.0 | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") |
| Unified Service Desk 3.3 | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") | ![Yes](../../unified-service-desk/media/tick.PNG "Yes") |

> [!Note]
> In the following scenarios, we recommend upgrading your Unified Service Desk and/or Customer Engagement to the latest version.
> - If you install Unified Service Desk 4.1 or a higher version and use with any version lesser than Customer Engagement 8.2, we recommend upgrading your Customer Engagement instance to the latest version.
>
> - If you upgrade from an older version to the latest version of Unified Service Desk but use with any version lesser than Customer Engagement 8.2, we recommend upgrading your Customer Engagement instance to the latest version.

<!-- <a name="SampleApps"></a>   
## Software requirements for deploying Unified Service Desk sample applications  
 To deploy a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample application, an instance of [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps (online or on-premises) as per the above mentioned matrix is mentioned.

> [!IMPORTANT]
>  We recommend that you upgrade to the lastest version of [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)] for Customer Engagement and Unified Service Desk so you can use the new features available.  
> [Get Unified Service Desk 4.1 for Dynamics 365 for Customer Engagement apps now](../download-unified-service-desk.md).


 For information about the sample applications available for this release, see [Deploy sample Unified Service Desk applications to Dynamics 365 for Customer Engagement server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md).   -->

<a name="packdeploy"></a>   
## Software requirements for the Package Deployer tool  
 The [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] is used for deploying [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample applications. For more information on the requirements, see [Deploy packages using Dynamics CRM Package Deployer and Windows PowerShell](/dynamics365/customer-engagement/admin/deploy-packages-using-package-deployer-windows-powershell).  
## Impact of Unified Interface Only availability with Unified Service Desk

You have deployed Unified Service Desk in a Customer Engagement Sandbox environment and when you reset the sandbox environment, you will have only have Unified Interface experience. To enable the Web Client experience, set **No** for the **Use the new Unified Interface Only** option in the system settings. More information: [How to enable/disable Unified Interface Only mode](/dynamics365/customer-engagement/admin/enable-unified-interface-only#how-to-enable-unified-interface-only-mode).

After you enable Web Client experience, go to the Window Navigation Rules and update the navigation URLs for the all the rules.

<a name="appvirtual"></a>   
## Software requirements for Citrix XenApp application virtualization  
 You can install and run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client as a published app on Citrix XenApp 7.6. This allows agents to access the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client from a central location.  

 You can also configure a Windows application as a virtual application on Citrix XenApp 7.6 that run as a hosted application in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Integrate with Citrix applications](../integrate-citrix-applications.md)  

## See also  
 [Install Unified Service Desk Client](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)   
 [Deploy Unified Service Desk packages to Dynamics 365 for Customer Engagement server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)   
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)