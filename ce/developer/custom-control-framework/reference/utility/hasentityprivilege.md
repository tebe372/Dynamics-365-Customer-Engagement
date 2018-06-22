---
title: hasEntityPrivilege | Microsoft Docs
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
ms.assetid: f22723f0-c606-465c-abba-0a8c46a10e32

---

# hasEntityPrivilege

[!INCLUDE [hasentityprivilege-description](includes/hasentityprivilege-description.md)]

## Syntax

`hasEntityPrivilege(entityTypeName, privilegeType, privilegeDepth)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|entityTypeName|`string`|yes|Entity type name|
|priviligeType|`enum`|no|Entity privilege types. It has the following attributes:<br/>- `None =1`<br/>- `Create =1` <br/>- `Read =2`<br/>- `Write =3`<br/>- `Delete =4`<br/>- `Assign =5`<br/>- `Share =6`<br/>- `Append =7`<br/>- `AppendTo =8`|
|priviligeDepth|`enum`|no|Entity privilege depth. It has the following attribute: <br/>- `None =-1`<br/>- `Basic =0`<br/>- `Local =1`<br/>- `Deep =2`<br/>- `Global =3`|

## Return Value

**Type**: `boolean`


### Related topics

[Utility](../utility.md)<br />
[PowerApps Control Framework API Reference](../index.md)<br />
[PowerApps Control Framework Overview](../../powerapps-control-framework-overview.md)<br />
