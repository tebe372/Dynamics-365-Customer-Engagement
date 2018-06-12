---
title: openConfirmDialog | Microsoft Docs
description: 
keywords:
ms.author: nabuthuk
manager: 
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 83f2c208-696c-48b1-b65c-2ba7374d6cfc
---


# openConfirmDialog

[!INCLUDE [openconfirmdialog-description](includes/openconfirmdialog-description.md)]


## Syntax

`openConfirmDialog(confirmStrings, options)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|confirmstrings|`ConfirmDialogStrings`|yes|Strings used in the dialog. The ConfirmDialogStrings has the following attributes:<br/>- **title**: `string`. Confirm Dialog Title. <br/>- **subtitle**: `string`. Confirm Dialog subtitle.<br/>- **text**: `string`. Confirm Dialog Text/Message.<br/>- **confirmButtonLabel**: `string`. The confirm button label. If you do not specify the button label, OK (in user's preferred language) is used as the button label.|
|options|`ConfirmDialogOptions`|yes|Options for the dialog. The ConfirmDialogOptions has the following attributes:<br/>- **height**: `string`. Height of the confirmation dialog in pixels. <br/>- **width**:`string`. Width of the confirmation dialog in pixels|

## Return Value

Type: `Promise`


### Related topics

[Navigation](../navigation.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
