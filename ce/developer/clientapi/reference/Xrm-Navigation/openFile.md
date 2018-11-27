---
title: "openFile (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 6a2497fe-08ad-4953-b3ff-44c72bc25082
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# openFile (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/openFile-description.md](./includes/openFile-description.md)]

## Syntax

`Xrm.Navigation.openFile(file,openFileOptions)`

## Parameters

| Parameter Name        | Type           | Required  |Description  |
| ------------- |-------------| -----|-----|
|file |Object | Yes|An object describing the file to open. The object has the following attributes:<br/>- **fileContent**: String. Contents of the file.  <br/>- **fileName**: String. Name of the file.<br/>- **fileSize**: Number. Size of the file in KB.<br/>- **mimeType**: String. MIME type of the file.|
|openFileOptions |Number | No|Specify whether to open or save the file:<br/> `1:Open`<br/> `2:Save`<br/>If you do not specify this parameter, by default **1** (open) is passed.|

### Related topics

[Xrm.Navigation](../xrm-navigation.md)
