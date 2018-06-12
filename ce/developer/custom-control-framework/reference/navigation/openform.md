---
title: openForm | Microsoft Docs
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
ms.assetid: bea56947-d976-4974-9ac7-2d5f5c7b6732
---

# openForm

[!INCLUDE [openform-description](includes/openform-description.md)]

## Syntax

`openForm(options, parameters)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|options|`EntityFormOptions`|yes|The EntityFormOptions has the following attributes:<br/>- **createFromEntity**: [EntityReference](../entityreference.md). Designates a record that will provide default values based on mapped attribute values. The lookup object has the following String properties: entityType, id, and name. <br/>- **entityId**: `string`. ID of the entity record to display the form for.<br/>- **entityName**: `string`. Logical name of the entity to display the form for.<br/>- **formId**: `string`. ID of the form instance to be displayed.<br/>- **height**: `number`. Height of the form window to be displayed in pixels.<br/>- **openInNewWindow**: `boolean`. whether to display form in a new window.<br/>- **useQuickCreateForm**: `boolean`. whether to open a quick create form. If you do not specify this, by default `false` is passed.<br/>- **width**: `number`. Width of the form window to be displayed in pixels.<br/>- **windowPosition**: `number`. Specify one of the following values for the window position of the form on the screen: `1:center` <br/> `2:side`|
|parameters|`key`|yes|Entity form parameters.|

## Return Value

Type: `Promise`

### Related topics

[Navigation](../navigation.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
