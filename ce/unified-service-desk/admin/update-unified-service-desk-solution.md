---
title: "Update Unified Service Desk solution | MicrosoftDocs"
description: "Learn how to update your existing installation of Unified Service Desk to the latest version. Also, learn how to check the current version before you update."
ms.date: 06/28/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# Update Unified Service Desk solution

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

Read this topic only if you have an existing installation of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] from the previous release of Microsoft Dataverse, and want to update to the latest release.  
  
 If you’re installing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for the first time, you can skip this topic.  
  
<a name="check"></a>

## Check if you need to update the Unified Service Desk solution

 If you’re unsure whether you need to update your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] installation, check the following versions to be sure.  
  
### Check the Unified Service Desk solution version
 In your Dataverse instance, navigate to Dataverse, then select **Settings** > **Solutions**. If the version numbers of the solutions match those in the table, you have the latest version of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], and don’t need to update.  
  
|Solution name                  |Version      |  
|-------------------------------|-------------|  
|UiiForMicrosoftDynamicsCRM2011 |4.0.0.xxx    |  
|DynamicsUnifiedServiceDesk     |4.0.0.xxx    |
  
<a name="UpdateSolutions"></a>   
## Update Unified Service Desk solutions  
 Before you update your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solutions, ensure that the version of your Customer Engagement (on-premises) organization is [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)], [!INCLUDE[pn_crm_2015_shortest](../../includes/pn-crm-2015-shortest.md)], or [!INCLUDE[pn_crm_2013_sp_shortest](../../includes/pn-crm-2013-sp-shortest.md)].  
  
1. [Download the Unified Service Desk package file](https://go.microsoft.com/fwlink/p/?LinkID=2159819) (Dynamics365-USD-4.2.0.16-PackageDeployer.exe), and save it on your computer.  
  
2. Run the downloaded file to extract the contents into a folder.  
  
    After the files are extracted, if the [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)] starts automatically, close it.  
  
3. In the extracted folder, locate the following two solution files in the UnifiedClientDemoPackage\\*\<PackageName>* folder, where *\<PackageName>* is the name of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] package you currently have installed in your Dataverse instance:  
  
   - UiiForMicrosoftDynamicsCRM_3_0_managed.zip  
  
   - DynamicsUnifiedServiceDesk_1_0_managed.zip 

   - UnifiedInterfaceDemoCustomization_1_0_managed.zip 
   
   - USDUnifiedInterfaceCustomization_1_0_managed.zip
  
     For example, if you currently have Base package installed, you must navigate to the USDPackageDeployer\BasePackage folder to find the solution files for updating.  
  
4. Sign in to the Dynamics 365 instance.  
  
5. Go to **Settings** > **Solutions**.   
  
6. On the **Actions** toolbar, select **Import**.  
  
7. Browse to the UiiForMicrosoftDynamicsCRM_3_0_managed.zip file in the appropriate folder as explained in step 4, and select to import it to update the existing solution in your Dataverse instance.  
  
8. The next page will display a yellow bar saying **This solution package contains an update for a solution that is already installed**. Review the information about the solution, and select **Next**.  
  
9. On the next page, select the **Maintain customizations (recommended)** option and ensure that the **Enable any SDK message processing steps included in the solution** check box is selected. Select **Next**.  
  
     After the solution import completes successfully, the **UiiForMicrosoftDynamicsCRM** solution is updated.  
  
10. Repeat steps 6 to 9 for the DynamicsUnifiedServiceDesk_1_0_managed.zip, UnifiedInterfaceDemoCustomization_1_0_managed.zip, and USDUnifiedInterfaceCustomization_1_0_managed.zip files to update the **DynamicsUnifiedServiceDesk**, **UnifiedInterfaceDemoCustomization**, and **USDUnifiedInterfaceCustomization** solutions in your Dataverse instance.  
  
     For detailed information about updating solutions in Dataverse, see [Import, update, and export solutions](/dynamics365/customer-engagement/customize/import-update-export-solutions).  
  
11. In Dataverse, verify the version numbers of the updated solutions with those listed in the preceding table to ensure they’re the latest versions.  
  
12. Close the browser instance, and sign in again to Dataverse to see the new features in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [What's new in Unified Service Desk for administrators](../../unified-service-desk/admin/whats-new-unified-service-desk-administrators.md).  
  
### See also

[Connect to Dataverse instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md)  
[Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)  
[Upgrade Unified Service Desk](upgrade-unified-service-desk-solution.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
