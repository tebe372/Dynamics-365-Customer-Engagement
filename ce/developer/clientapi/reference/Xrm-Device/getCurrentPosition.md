---
title: "getCurrentPosition| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 062a52d8-170c-4e98-b48a-ac99ec759f83
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getCurrentPosition (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getCurrentPosition-description.md](./includes/getCurrentPosition-description.md)]


## Syntax

`Xrm.Device.getCurrentPosition().then(successCallback, errorCallback)`

## Parameters

| Parameter Name        | Type           | Required  |Description  |
| ------------- |-------------| -----|-----|
|successCallback |Function | Yes|A function to call when the current geolocation information is returned. A geolocation object with the following attributes is passed to the function.:<br/>- **coords**: Contains a set of geographic coordinates along with associated accuracy as well as a set of other optional attributes such as altitude and speed. <br/>- **timestamp**: Represents the time when the object was acquired and is represented as DOMTimeStamp.|
|errorCallback |Function | Yes|A function to call when the operation fails. An object with the following properties will be passed: <br/>- **code**: The error code. Number. <br/>- **message**: RLocalized message describing the error details. String.<br/><br/>If the user location setting is not enabled on your mobile device, the error message indicates the same. If you are using an earlier version of the Dynamics 365 Customer Engagement mobile client or if geolocation capability is not available on your mobile device, null is passed to the error callback.|
 

## Return Value
On success, returns a promised base64 encoded audio object with the attributes specified earlier.

## Remarks
For the **getCurrentPosition** method to work, the geolocation capability must be enabled on your mobile device, and the Dynamics 365 Customer Engagement mobile clients must have permissions to access the device location, which isn't enabled by default.

This method is supported only for the mobile clients.

### Related topics
[Xrm.Device](../xrm-device.md)

