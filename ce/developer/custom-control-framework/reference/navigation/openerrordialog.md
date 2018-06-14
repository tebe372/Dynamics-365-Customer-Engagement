---
title: openErrorDialog | Microsoft Docs
description: 
keywords:
ms.author: nabuthuk
manager: jdaly
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 10c154b9-45a0-44ee-a621-73d6a9009c6d
---
# openErrorDialog

[!INCLUDE [openerrordialog-description](includes/openerrordialog-description.md)]

## Syntax

`openErrorDialog(options)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|options|`ErrorDialogOptions`|yes|Error dialog options. The ErrorDialogOptions has the following attributes: <br/>- **details**: `string`. Details about the error. When you specify this, the Download Log File button is available in the error message, and clicking it will let users download a text file with the content specified in this attribute.<br/>- **errorCode**: `number`. If you just set errorCode, the message for the error code is automatically retrieved from the server and displayed in the error dialog. If you specify an errorCode value, an error dialog with a default error message is displyed.<br/>- **message**: `string`. The message to be displayed in the error dialog.|

## Return Value

Type: `Promise`

## Remarks

See [Promise](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Promise) and [File](https://developer.mozilla.org/docs/Web/API/File)

### Related topics

[Navigation](../navigation.md)<br />
[PowerApps Control Framework API Reference](../index.md)<br />
[PowerApps Control Framework Overview](../../powerapps-control-framework-overview.md)<br />
