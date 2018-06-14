---
title: EntityFormOptions | Microsoft Docs
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
ms.assetid: 418871c0-59dc-4a7c-a8f9-9364a19f7662
---
# EntityFormOptions


[!INCLUDE [cc_applies_to_update_9_0_0]](../../../includes/cc_applies_to_update_9_0_0.md)

## createFromEntity: EntityReference

Designates a record that will provide default values based on mapped attribute value. The lookup object has following properties: entity type, id and name.

## entity
Unique Id of the entity record to display the form for. 

**Type**: `string`

## entityName

Logical name of the entity to display the form for. 

**Type**: `string`

## formId

ID of the form instance to be displayed.

**Type**: `string`

## height

Height of the form window to be displayed in pixels.

**Type**: `number`

## openInNewWindow

Whether to display the form in new window

**Type**: `booleean`

## useQuickCreateForm

Whether to open a quick create form. If you don't specify this, by default false is passed. 

**Type**: `boolean`

## width
Width of the form window to be displayed in pixels.

**Type**: `boolean`

## windowPosition

Specifies the window position on the screen. 

**Type**: `number`

The windowPosition value is a number with the following possible values

|Value|Position|
|---|---|
|1|Center|
|2|Side|

### Related topics

[PowerApps Control Framework API Reference](index.md)<br />
[PowerApps Control Framework Overview](../powerapps-control-framework-overview.md)
