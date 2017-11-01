---
title: "captureAudio| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: fa39d18e-4b82-423a-84a0-e54450b7964e
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# captureAudio (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/captureAudio-description.md](./includes/captureAudio-description.md)]


## Syntax

`Xrm.Device.captureAudio().then(successCallback, errorCallback)`

## Parameters

| Parameter Name        | Type           | Required  |Description  |
| ------------- |-------------| -----|-----|
|successCallback |Function | Yes|A function to call when audio is returned. A base64 encoded audio object with the following attributes is passed to the function:<br/>- **fileContent**: Contents of the audio file. String <br/>- **fileName**: Name of the audio file. String.<br/>- **fileSize**: Size of the audio file in KB. Number.<br/>- **mimeType**: Audio file MIME type. String.|
|errorCallback |Function | Yes|A function to call when the operation fails. |
 

## Return Value
On success, returns a promised base64 encoded audio object with the attributes specified earlier.

## Remarks
This method is supported only for the mobile clients.

### Related topics
[Xrm.Device](../xrm-device.md)

