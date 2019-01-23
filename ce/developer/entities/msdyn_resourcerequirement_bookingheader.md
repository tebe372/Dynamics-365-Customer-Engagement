---
title: "msdyn_resourcerequirement_bookingheader Entity Reference (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_resourcerequirement_bookingheader entity."
ms.date: 12/05/2017
ms.service: crm-online
ms.topic: reference
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: JimDaly
ms.author: jdaly
manager: jdaly
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# msdyn_resourcerequirement_bookingheader Entity Reference




## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_resourcerequirement_bookingheaderset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName||
|DisplayName||
|EntitySetName|msdyn_resourcerequirement_bookingheaderset|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|msdyn_resourcerequirement_bookingheader|
|OwnershipType|None|
|PrimaryIdAttribute|msdyn_resourcerequirement_bookingheaderid|
|PrimaryNameAttribute||
|SchemaName|msdyn_resourcerequirement_bookingheader|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [bookableresourcebookingheaderid](#BKMK_bookableresourcebookingheaderid)
- [msdyn_resourcerequirement_bookingheaderId](#BKMK_msdyn_resourcerequirement_bookingheaderId)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_bookableresourcebookingheaderid"></a> bookableresourcebookingheaderid

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bookableresourcebookingheaderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_resourcerequirement_bookingheaderId"></a> msdyn_resourcerequirement_bookingheaderId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirement_bookingheaderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_resourcerequirementid"></a> msdyn_resourcerequirementid

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirementid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_resourcerequirement_bookingheader entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_resourcerequirement_bookingheader"></a> msdyn_resourcerequirement_bookingheader

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_bookingheader](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_bookingheader) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 for Customer Engagement apps](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_resourcerequirement_bookingheader?text=msdyn_resourcerequirement_bookingheader EntityType" />
