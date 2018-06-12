---
title: openUrl | Microsoft Docs
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
ms.assetid: 590078f3-c604-4bd0-ac74-9cf6d8806802

---

# openUrl

[!INCLUDE [openurl-description](includes/openurl-description.md)]


## Syntax

`openUrl(url, options)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|url|`string`|yes|Url to be opened.|
|options|`OpenUrlOptions`|yes|Window options for the url. The OpenUrlOptions has the following parameters: <br/>- **height**: `number`. Height of the window to display the resultant page in pixels.<br/>- **width**: `number`. Width of the window to display the resultant page in pixels.|




### Related topics

[Navigation](../navigation.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
