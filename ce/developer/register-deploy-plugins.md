---
title: "Register and Deploy Plug-Ins (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Learn about register plug-ins and custom workflow activities with Dynamics 365 for Customer Engagement apps using the Plug-in Registration Tool."
ms.custom: 
ms.date: 1/24/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
f1_keywords: 
  - plugins
  - plugin
ms.assetid: c3ee3447-ec0d-494e-8b35-4ec58ce93eea
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Register and Deploy Plug-Ins

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Plug-ins and custom workflow activities are custom code that you develop to extend the existing functionality of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. Before a plug-in or custom workflow activity can be used, it must be registered with the server. A plug-in and custom workflow activity registration tool is available for download.

 While this topic focuses primarily on plug-ins, most of the information is also applicable to custom workflow activities. One difference between the two is that for custom workflow activity assemblies, you register just the assembly. For plug-ins, you register the plug-in assembly and one or more steps per plug-in. For more information about custom workflow activities, see [Custom Workflow Activities (Workflow Assemblies)](custom-workflow-activities-workflow-assemblies.md).

> [!IMPORTANT]
> Do not register any plug-in or custom workflow activity unless it is obtained from a reliable and trusted source.

 For more information about registering plug-ins, see the CDS for Apps topic [Register a plug-in](/powerapps/developer/common-data-service/register-plug-in.md).

<a name="bkmk_pluginstor"></a>

## Plug-in Storage

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 
For an on-premises deployment, plug-ins that are not registered in the sandbox can be stored in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps server's database or the *on-disk* file system. We strongly recommend that you store your production-ready plug-ins in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps database, instead of on-disk. Plug-ins stored in the database are automatically distributed across multiple [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps servers in a data center cluster. On-disk storage of plug-ins is useful for debugging plug-ins using [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. However, you can debug a plug-in that is stored in the database. For more information, see [Debug a Plug-in](debug-plugin.md).  

Plug-ins registered in the sandbox must be stored in the database regardless of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps deployment (on-premises, IFD, or Online).

<a name="bkmk_deployment"></a>

## Deployment

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 
For on-premises or Internet-facing (IFD) [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps installations, when you deploy plug-ins from another computer to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps server disk (on-disk deployment), the plug-in assembly must be manually copied to the server before registration. The assembly must be deployed to the `<installdir>`\Program Files\Microsoft CRM\server\bin\assembly folder on each server where the plug-in is to execute.  

Plug-in registration should be done after the assembly has been copied to the …\bin\assembly folder on the server to prevent the situation where a system user causes an event in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps to be raised but the registered plug-in assembly does not yet exist on the server. For server database deployment, the plug-in assembly is automatically copied during plug-in registration so that the earlier situation is not an issue.  

Depending on your plug-in’s design, your plug-ins may require other referenced assemblies to run. Regardless of whether you deploy your plug-in to the database or disk, if your plug-in requires other assemblies to run, you must put copies of these assemblies in the global assembly cache on each server where the plug-in is to execute. This does not apply to a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps server because you do not have access to the global assembly cache on that server.  

**To move a plug-in from a development environment to a staging or production server**

1. On the development computer, build the plug-in code. Do not include debug information. Optimize the plug-in for performance.
2. Register the plug-in in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps server database.
3. Using the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application, create a solution or use an existing one, and add the plug-in to that solution.
4. After you have added any other desired components to the solution, export the solution.
5. Import the solution on to the staging or production server.

<a name="bkmk_securityrestrictions"></a>

## Security Restrictions

 There is a security restriction that enables only privileged users to register plug-ins. For plug-ins that are not registered in isolation, the system user account under which the plug-in is being registered must exist in the **Deployment Administrators** group of Deployment Manager. Only the System Administrator user account or any user account included in the **Deployment Administrators** group can run Deployment Manager.  

> [!IMPORTANT]
> For non-isolated plug-ins, failure to include the registering user account in the **Deployment Administrators** group results in an exception being thrown during plug-in registration. The exception description states "Not have enough privilege to complete Create operation for an SDK entity."  

 The system user account under which the plug-in is being registered must have the following organization-wide security privileges:
- prvCreatePluginAssembly
- prvCreatePluginType
- prvCreateSdkMessageProcessingStep
- prvCreateSdkMessageProcessingStepImage
- prvCreateSdkMessageProcessingStepSecureConfig

  For more information, see [The Security Model of Dynamics 365 for Customer Engagement apps](security-dev/Security-model.md).  

  For plug-ins registered in the sandbox (isolation mode), the system user account under which the plug-in is being registered must have the System Administrator role. Membership in the **Deployment Administrators** group is not required.  
  
<a name="bkmk_registerprog"></a>

## Register Plug-ins Programmatically

 You can programmatically register plug-ins and custom workflow activities with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps by writing registration code using certain entity classes. The key entity types used to register plug-ins and images are:    `PluginAssembly`,    `PluginType`,  `SdkMessageProcessingStep`, and `SdkMessageProcessingStepImage`. The key entity types used to register custom workflow activities are `PluginAssembly` and `PluginType`. Use these entities with the create, update, retrieve, and delete operations.

 For more information on images, see [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md).  

<a name="bkmk_enablecode"></a>

## Enable or Disable Custom Code Execution

 You can use [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] to enable or disable custom code, including plug-ins and custom workflow activities, on the server as described here. Alternatively, you can use the Deployment Web service. For more information, see [Deployment Entities and Deployment Configuration Settings](https://msdn.microsoft.com/library/gg328063.aspx) to set the `CustomCodeSettings`.<xref:Microsoft.Xrm.Sdk.Deployment.CustomCodeSettings.AllowExternalCode> property.

### To enable custom code execution

1. Open a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command window.

2. Add the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps PowerShell snap-in:

    ```powershell
    Add-PSSnapin Microsoft.Crm.PowerShell
    ```

3. Retrieve the current setting:

    ```powershell
    $setting = get-crmsetting customcodesettings
    ```

4. Modify the current setting:

    ```powershell
    $setting.AllowExternalCode="True"
    set-crmsetting $setting
    ```

5. Verify the setting:

    ```powershell
    get-crmsetting customcodesettings
    ```

### To disable custom code execution

1. Open a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command window.
2. Add the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps PowerShell snap-in:
    ```powershell
    Add-PSSnapin Microsoft.Crm.PowerShell
    ```
3. Retrieve the current setting:
    ```powershell
    $setting = get-crmsetting customcodesettings
    ```

4. Modify the current setting:
    ```powershell
    $setting.AllowExternalCode=0
    set-crmsetting $setting
    ```

5. Verify the setting:
    ```powershell
    get-crmsetting customcodesettings
    ```

### See also

 [Plug-in Development](plugin-development.md)<br />
 [Debug a Plug-in](debug-plugin.md)<br />
 [Plug-in Isolation, Trust, and the Disallowed List](plugin-isolation-trusts-statistics.md)<br />
 [Package and Distribute Extensions with Dynamics 365 for Customer Engagement apps Solutions](package-distribute-extensions-use-solutions.md)<br />
