---
title: openWebResource | Microsoft Docs
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
ms.assetid: 27a1e54c-71fe-450f-8f84-b4cc125970bf
---

# openWebResource

[!INCLUDE [openwebresource-description](includes/openwebresource-description.md)]

## Syntax

`openWebResource(name, options, data)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|name|`string`|yes|The name ofthe HTML web resource to open.|
|options|`OpenWebResourceOptions`|yes|Window options for the web resource. The OpenWebResourceOptions has the following attributes:<br/>- **height**: `number`. Height of the window to display the resultant page in pixels.<br/>- **width**: `number`. Width of the window to display the resultant page in pixels.<br/>- **openInNewWindow**: `boolean`. whether to open the web resource in a new window.|
|data|`string`|no|Data to be passed into the data parameter.

### Related topics

[Navigation](../navigation.md)<br />
[PowerApps Control Framework API Reference](../index.md)<br />
[PowerApps Control Framework Overview](../../powerapps-control-framework-overview.md)<br />
