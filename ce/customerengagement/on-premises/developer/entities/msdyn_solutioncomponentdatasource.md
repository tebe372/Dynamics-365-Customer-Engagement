---
title: "msdyn_solutioncomponentdatasource Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_solutioncomponentdatasource entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_solutioncomponentdatasource Entity Reference



**Added by**: Microsoft Dynamics 365 Settings APIs Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_solutioncomponentdatasources<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_solutioncomponentdatasources(*msdyn_solutioncomponentdatasourceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_solutioncomponentdatasources(*msdyn_solutioncomponentdatasourceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_solutioncomponentdatasources<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_solutioncomponentdatasources(*msdyn_solutioncomponentdatasourceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_solutioncomponentdatasources|
|DisplayCollectionName|Solution Component Data Sources|
|DisplayName|Solution Component Data Source|
|EntitySetName|msdyn_solutioncomponentdatasources|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_solutioncomponentdatasources|
|LogicalName|msdyn_solutioncomponentdatasource|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_solutioncomponentdatasourceid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_solutioncomponentdatasource|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_solutioncomponentdatasourceId](#BKMK_msdyn_solutioncomponentdatasourceId)


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description||
|DisplayName|msdyn_name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_solutioncomponentdatasourceId"></a> msdyn_solutioncomponentdatasourceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Solution Component Data Source|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_solutioncomponentdatasourceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_msdyn_solutioncomponentdatasource_Annotations"></a> msdyn_solutioncomponentdatasource_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_solutioncomponentdatasource_Annotations](annotation.md#BKMK_msdyn_solutioncomponentdatasource_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_solutioncomponentdatasource_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_solutioncomponentdatasource?text=msdyn_solutioncomponentdatasource EntityType" />