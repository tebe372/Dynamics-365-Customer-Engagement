---
title: "Download the Web Client - Unified Interface Migration Assistant | MicrosoftDocs"
description: "Download Web Client - Unified Interface Migration Assistant to migrate your Unified Service Desk configurations from Dynamics 365 Web Client to Unified Interface App"
keywords: ""
ms.date: 07/30/2018
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - "dyn365-USD, dyn365-admin"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: AC23FCF9-5B36-4C1B-9B29-31F93ADEB3AF
author: kabala123
ms.author: kabala
manager: shujoshi
---

# Download the Migration Assitant for migrating the Unified Service Desk configurations from Web Client to Unified Interface App

The Web Client - Unified Interface Migration Assistant is an executable file, which you can download and run to start the migration process.

Download the [Web Client – Unified Interface Migration Assistant](https://go.microsoft.com/fwlink/?linkid=2005839).


## Prerequesites: Download Configuration Migration Tool

The migration of Unified Service Desk configurations from Dynamics 365 Web Client to Unified Interface App is a two stage process:

- Fetch and migrate the configuration elements to a **Data.zip** file using the Web Client - Unified Interface Migration Assistant.
- Import the **Data.zip** to the Unified Interface App using the Configuration Migration Tool (DataMigrationUtility.exe).

Hence, you must download the Configuration Migration Tool (DataMigrationUtility.exe), which is available as a [NuGet package](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.ConfigurationMigration.Wpf). 

To download the tool, see [Download the tools from NuGet](../../developer/download-tools-nuget.md). Follow the steps on this page to extract the Configuration Migration Tool (DataMigrationUtility.exe).

## See also

[Migration of Unified Service Desk configurations from Dynamics 365 Web Client to Dynamics 365 Unified Interface App](overview-migration-assistant.md)

[Migration steps of the configurations from Dynamics 365 Web Client to Unified Interface App](web-client-unified-interface-configuration-steps.md)