---
title: "msdyn_callablecontext EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_forecastdefinition EntityType"
keywords: 
ms.date: 03/07/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 6713A40E-A1A2-4EEA-B25A-22AA8008A623
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 22
topic-status: Drafting
---
# msdyn_callableContext EntityType

Entity Set Path: `[organizationURI]/api/data/v9.1/msdyn_callablecontexts`<br />
Display Name: Playbook calling record type <br />
Primary key: msdyn_callablecontextid <br />
Operations supported: Create, Retrieve, Update and Delete<br />

## Properties

Properties represent fields of data stored in the entity. Some properties are read-only.

|Name|Display name|Type|Description|
|-----|-----|-----|-----|
|createdby|Created By|Edm.Guid|Unique identifier of the user who created the record|
|createdon|Created On|Edm.DateTimeOffset|Date and time when the record was created|
|createdonbehalfby|CreatedOnBehalfBy|Edm.Guid|Unique identifier of the delegate user who created the record|
|importsequencenumber|Import Sequence Number|Edm.Int32|Sequence number of the import that created this record|
|modifiedby|Modified By|Edm.Guid|Unique identifier of the user who modified the record|
|modifiedon|Modified On|Edm.DateTimeOffset|Date and time when the record was modified|
|modifiedonbehalfby|Modified On Behalf By|Edm.Guid|Unique identifier of the delegate user who modified the record|
|msdyn_callablecontextid|Playbook calling record type|Edm.Guid|Unique identifier for entity instances|
|msdyn_EntityLogicalName|Name|Edm.String|The name of the custom entity|
|msdyn_EntityOTC|Fiscal Year|Edm.Int32|Internal use only|
|overriddencreatedon|Record Created On|Edm.DateTimeOffset|Date and time that the record was migrated|
|owner|Owner|Edm.Guid|Owner Id|
|owningbusinessunit|Owning Business Unit|Edm.Guid|Unique identifier for the business unit that owns the record|
|owningteam|Owning Team|Edm.Guid|Unique identifier for the team that owns the record|
|owninguser|Owning User|Edm.Guid|Unique identifier for the user that owns the record|
|statecode|Status|Edm.Int32|Status of the Forecast Definition|
|statuscode|Status reason|Edm.Int32|Reason for the status of the Forecast Definition|
|timezoneruleversionnumber|Time Zone Rule Version Number|Edm.Int32|For internal use only|
|utcconversiontimezonecode|UTC Conversion Time Zone Code|Edm.Int32|Time zone code that was in use when the record was created|
|versionnumber|Version Number|Edm.Int64|Version Number|
