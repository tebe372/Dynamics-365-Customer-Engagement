---
title: "Enable Azure storage for portals in Dynamics 365 | MicrosoftDocs"
description: "Steps to enable Azure storage for portals."
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 450D4748-1ED4-48F6-ACEC-349B577E78EE
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Enable [!include[Azure](../includes/pn-azure-shortest.md)] Storage

[!include[Azure](../includes/pn-azure-shortest.md)] Storage integration for portals enables you to take advantage of the greater file storage capability of [!include[Azure](../includes/pn-azure-shortest.md)], using the same interface and providing the same user experience as for default file attachments. This feature is supported for web files, entity forms, and web forms.

You must create a storage account with **Resource manager** as the deployment model. [!include[More information](../includes/proc-more-information.md)] [Create an Azure storage account](https://docs.microsoft.com/en-us/azure/storage/storage-create-storage-account#create-a-storage-account).

After the storage account is running, portals require certain global settings that tell the application how to locate your storage account. From [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], navigate to **Settings** > **Portal Settings**, and add a new setting named **FileStorage/CloudStorageAccount**.

To locate the value for FileStorage/CloudStorageAccount, you must get a connection string from your [!include[Azure portal](../includes/pn-azure-portal.md)].

1. Sign in to your [!include[Azure portal](../includes/pn-azure-portal.md)].

2. Navigate to your storage account.

3. Select **Access Keys**.

    ![Locate value for connection string from your Azure portal](media/key-azure-storage.png "Locate the value for the connection string from your Azure portal")

4. In the resulting panel, locate the field labeled **Connection String**. Select the **Copy** icon next to the field for which you need to copy the value, and then paste that value into your new setting:

    ![Primary connection string value](media/primary-connection-string-azure-storage.png "Primary connection string value")

    ![Portal setting for cloud storage account](media/portal-site-setting-cloud-storage-account.png "Portal setting for your cloud storage account")

## Specify the storage container

If you do not already have an [!include[Azure](../includes/pn-azure-shortest.md)] Blob container in your storage account, you must add one by using your [!include[Azure portal](../includes/pn-azure-portal.md)].

From [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], navigate to **Settings** > **Portal Settings**, and add a new setting named FileStorage/CloudStorageContainerName, using the name of your container as the value.

![Portal setting for cloud storage container](media/portal-site-setting-cloud-storage-container.png "Portal setting for your cloud storage container")

You must also enable cross-origin resource sharing (CORS) on your [!include[Azure](../includes/pn-azure-shortest.md)] Storage account as follows, otherwise you will see the regular attachment icon rather than the cloud icon:

- **Allowed origins**: Specify your Dynamics 365 domain. For example, contoso.crm.dynamics.com.
- **Allowed verbs**: GET, PUT, DELETE, HEAD, POST
- **Allowed headers**: Specify the request headers that the origin domain may specify on the CORS request. For example, x-ms-meta-data\*, x-ms-meta-target\*. 
- **Exposed headers**: The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. For example, x-ms-meta-\*.
- **Maximum age (seconds)**: Specify the maximum amount time that a browser should cache the preflight OPTIONS request. For example, 200.
 
[!include[More information:](../includes/proc-more-information.md)] [CORS support for the Azure Storage Services](https://docs.microsoft.com/rest/api/storageservices/cross-origin-resource-sharing--cors--support-for-the-azure-storage-services)

With these settings, your portal capabilities for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] application is ready to begin uploading and downloading files to and from [!include[Azure](../includes/pn-azure-shortest.md)] Storage. However, you cannot take full advantage of this feature until you [add a web resource to enable uploading attachments to Azure Storage](add-web-resource.md), and configure [entity forms](entity-forms-custom-logic.md#notes-configuration-for-entity-form) or [web forms](configure-notes.md) to use it.