---
title: "msdyn_forecastdefinition EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_forecastdefinition EntityType"
keywords: 
ms.date: 03/05/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 069F9158-8D8A-4892-BD41-3CA6E7EF16D9
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 22
topic-status: Drafting
---
# msdyn_forecastdefinition EntityType

[!INCLUDE[msdyn_forecastdefinition-description](../includes/msdyn_forecastdefinition-description.md)]

Entity Set Path: `[organizationURI]/api/data/v9.1/msdyn_forecastdefinitions`<br />
Display Name: Forecast definition <br />
Primary key: msdyn_forecastdefinitionid <br />
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
|msdyn_fiscalmonth|Fiscal Month|Edm.Int32|Select the fiscal month for the forecast definition|
|msdyn_fiscalquarter|Fiscal Quarter|Edm.Int32|Select the fiscal quarter for the forecast definition|
|msdyn_fiscalyear|Fiscal Year|Edm.Int32|Select the fiscal year for the forecast definition|
|msdyn_forecastdefinition|Forecast definition|Edm.Guid|Unique identifier for the forecast definition|
|msdyn_forecastdefinitionname|Forecast name|Edm.String|Name of the forecast definition|
|msdyn_forecastperiodtype|Forecast period|Edm.Int32|Select the type of period for which the forecast must be generated|
|msdyn_metricid|Forecast metric|Edm.Guid|Select metric to attach with forecast|
|msdyn_numberofrecurrences|Number of recurrences|Edm.Int32|Indicate the number of recurrences that the forecast will be generated|
|msdyn_quotasource|Quota source|Edm.Int32|Select whether the quota for the forecast must to be taken from a goal or entered manually|
|msdyn_rollupquery|Rollup query|Edm.Guid|Select the query that will be used to calculate data for the rollup field|
|msdyn_validfrom|Valid from|Edm.Date|Shows the date from which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 for Customer Engagement apps options|
|msdyn_validto|Valid to|Edm.Date|Shows the date till which the forecast is applicable. The date and time are displayed in the time zone selected in Dynamics 365 for Customer Engagement apps options|
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

## Navigation properties

|Name|Type|Partner|
|-----|-----|-----|
|createdby|mscrm.systemuser|lk_msdyn_forecastdefinition_createdby|
|createdonbehalfby|mscrm.systemuser|lk_msdyn_forecastdefinition_createdonbehalfby|
|modifiedby|mscrm.systemuser|lk_msdyn_forecastdefinition_modifiedby|
|modifiedonbehalfby|mscrm.systemuser|lk_msdyn_forecastdefinition_modifiedonbehalfby|
|owninguser|mscrm.systemuser|user_msdyn_forecastdefinition|
|owningteam|mscrm.team|team_msdyn_forecastdefinition|
|ownerid|mscrm.principal|owner_msdyn_forecastdefinition|
|owningbusinessunit|mscrm.businessunit|business_unit_msdyn_forecastdefinition|
|msdyn_forecastdefinition_SyncErrors|Collection(mscrm.syncerror)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_DuplicateMatchingRecord|Collection(mscrm.duplicaterecord)|duplicaterecordid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_DuplicateBaseRecord|Collection(mscrm.duplicaterecord)|baserecordid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_AsyncOperations|Collection(mscrm.asyncoperation)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_MailboxTrackingFolders|Collection(mscrm.mailboxtrackingfolder)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_ProcessSession|Collection(mscrm.processsession)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_BulkDeleteFailures|Collection(mscrm.bulkdeletefailure)|regardingobjectid_msdyn_forecastdefinition|
|msdyn_forecastdefinition_PrincipalObjectAttributeAccesses|Collection(mscrm.principalobjectattributeaccess)|objectid_msdyn_forecastdefinition|
|msdyn_metricid|mscrm.metric|msdyn_metric_msdyn_forecastdefinition_metricid|
|msdyn_msdyn_forecastdefinition_msdyn_forecastinstance|Collection(mscrm.msdyn_forecastinstance)|msdyn_forecastdefinitionid|
|msdyn_rollupquery|mscrm.goalrollupquery|msdyn_goalrollupquery_msdyn_forecastdefinition_rollupquery|
|msdyn_msdyn_forecastdefinition_msdyn_forecastrecurrence|Collection(mscrm.msdyn_forecastrecurrence)|msdyn_ForecastDefinitionId|

## See also

[Custom actions for Manual forecasting](../custom-actions-manual-forecasting.md)<br />
[Entity reference for Manual forecasting](../manual-forecasting-entity-reference.md)<br />
[msdyn_forecastinstance EntityType](msdyn_forecastinstance.md)<br />
[msdyn_forecastrecurrence EntityType](msdyn_forecastrecurrence.md)