---
title: "MobileOfflineProfileItemAssociation Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the MobileOfflineProfileItemAssociation entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# MobileOfflineProfileItemAssociation Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Information on relationships to be used to follow related entity's records for mobile offline profile item.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/mobileofflineprofileitemassociations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/mobileofflineprofileitemassociations(*mobileofflineprofileitemassociationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/mobileofflineprofileitemassociations(*mobileofflineprofileitemassociationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/mobileofflineprofileitemassociations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrieveUnpublished|<xref href="Microsoft.Dynamics.CRM.RetrieveUnpublished?text=RetrieveUnpublished Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedRequest>|
|RetrieveUnpublishedMultiple|<xref href="Microsoft.Dynamics.CRM.RetrieveUnpublishedMultiple?text=RetrieveUnpublishedMultiple Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedMultipleRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/mobileofflineprofileitemassociations(*mobileofflineprofileitemassociationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Mobile Offline Profile Item Association<br />
**DisplayCollectionName**: Mobile Offline Profile Item Associations<br />
**SchemaName**: MobileOfflineProfileItemAssociation<br />
**CollectionSchemaName**: MobileOfflineProfileItemAssociations<br />
**LogicalName**: mobileofflineprofileitemassociation<br />
**LogicalCollectionName**: mobileofflineprofileitemassociations<br />
**EntitySetName**: mobileofflineprofileitemassociations<br />
**PrimaryIdAttribute**: mobileofflineprofileitemassociationid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [IntroducedVersion](#BKMK_IntroducedVersion)
- [MobileOfflineProfileItemAssociationId](#BKMK_MobileOfflineProfileItemAssociationId)
- [MobileOfflineProfileItemId](#BKMK_MobileOfflineProfileItemId)
- [MobileOfflineProfileItemIdName](#BKMK_MobileOfflineProfileItemIdName)
- [Name](#BKMK_Name)
- [ProcessId](#BKMK_ProcessId)
- [ProfileItemAssociationEntityFilter](#BKMK_ProfileItemAssociationEntityFilter)
- [RelationshipData](#BKMK_RelationshipData)
- [RelationshipDisplayName](#BKMK_RelationshipDisplayName)
- [RelationshipId](#BKMK_RelationshipId)
- [SelectedRelationShipsSchema](#BKMK_SelectedRelationShipsSchema)
- [StageId](#BKMK_StageId)
- [TraversedPath](#BKMK_TraversedPath)


### <a name="BKMK_IntroducedVersion"></a> IntroducedVersion

**Description**: Version in which the Mobile offline Profile Item Association is introduced.<br />
**DisplayName**: Introduced Version<br />
**LogicalName**: introducedversion<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: VersionNumber<br />
**IsLocalizable**: False<br />
**MaxLength**: 48


### <a name="BKMK_MobileOfflineProfileItemAssociationId"></a> MobileOfflineProfileItemAssociationId

**Description**: Unique identifier of the mobile offline profile item associaition.<br />
**DisplayName**: Mobile Offline profileitemassociation<br />
**LogicalName**: mobileofflineprofileitemassociationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_MobileOfflineProfileItemId"></a> MobileOfflineProfileItemId

**Description**: Id of the parent profile item.<br />
**DisplayName**: Regarding<br />
**LogicalName**: mobileofflineprofileitemid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: mobileofflineprofileitem


### <a name="BKMK_MobileOfflineProfileItemIdName"></a> MobileOfflineProfileItemIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: mobileofflineprofileitemidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_Name"></a> Name

**Description**: Enter the name of the mobile offline profile item association.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProfileItemAssociationEntityFilter"></a> ProfileItemAssociationEntityFilter

**Description**: Profile item association entity filter criteria.<br />
**DisplayName**: Profile item association entity filter<br />
**LogicalName**: profileitemassociationentityfilter<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_RelationshipData"></a> RelationshipData

**Description**: Internal Use Only<br />
**DisplayName**: Internal Use Only<br />
**LogicalName**: relationshipdata<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_RelationshipDisplayName"></a> RelationshipDisplayName

**Description**: Entity relationship schema name<br />
**DisplayName**: Entity Relationship<br />
**LogicalName**: relationshipdisplayname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_RelationshipId"></a> RelationshipId

**Description**: Shows the relationship<br />
**DisplayName**: Shows the relationship<br />
**LogicalName**: relationshipid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SelectedRelationShipsSchema"></a> SelectedRelationShipsSchema

**Description**: List of relationships of entity selected in parent profile item<br />
**DisplayName**: Entity Relationship<br />
**LogicalName**: selectedrelationshipsschema<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Picklist<br />
**Options**:




### <a name="BKMK_StageId"></a> StageId

**Description**: Shows the ID of the stage.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: For internal use only.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [IsManaged](#BKMK_IsManaged)
- [IsValidated](#BKMK_IsValidated)
- [MobileOfflineProfileItemAssociationIdUnique](#BKMK_MobileOfflineProfileItemAssociationIdUnique)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [OverwriteTime](#BKMK_OverwriteTime)
- [PublishedOn](#BKMK_PublishedOn)
- [RelationshipName](#BKMK_RelationshipName)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ComponentState"></a> ComponentState

**Description**: For internal use only.<br />
**DisplayName**: Component State<br />
**LogicalName**: componentstate<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Published
- **Value**: 1 **Label**: Unpublished
- **Value**: 2 **Label**: Deleted
- **Value**: 3 **Label**: Deleted Unpublished



### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Shows who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_IsManaged"></a> IsManaged

**Description**: For internal use only.<br />
**DisplayName**: Is Managed<br />
**LogicalName**: ismanaged<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Managed
- **FalseOption Value**: 0 **Label**: Unmanaged

**DefaultValue**: False


### <a name="BKMK_IsValidated"></a> IsValidated

**Description**: Information about whether profile item association is validated or not<br />
**DisplayName**: Is Valid For Mobile Offline<br />
**LogicalName**: isvalidated<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_MobileOfflineProfileItemAssociationIdUnique"></a> MobileOfflineProfileItemAssociationIdUnique

**Description**: For Internal Use Only<br />
**DisplayName**: Unique Id<br />
**LogicalName**: mobileofflineprofileitemassociationidunique<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Shows who last updated the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the Mobile Offline Profile Item Association.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OverwriteTime"></a> OverwriteTime

**Description**: For internal use only.<br />
**DisplayName**: Record Overwrite Time<br />
**LogicalName**: overwritetime<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_PublishedOn"></a> PublishedOn

**Description**: Displays the last published date time.<br />
**DisplayName**: Published On<br />
**LogicalName**: publishedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_RelationshipName"></a> RelationshipName

**Description**: Display name of entity relationship<br />
**DisplayName**: Entity Relationship<br />
**LogicalName**: relationshipname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_SolutionId"></a> SolutionId

**Description**: Unique identifier of the associated solution.<br />
**DisplayName**: Solution<br />
**LogicalName**: solutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

**Description**: For internal use only.<br />
**DisplayName**: Solution<br />
**LogicalName**: supportingsolutionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: False<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the Mobile Offline profileitemassociation.<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_mobileofflineprofileitemassociation_modifiedby](#BKMK_lk_mobileofflineprofileitemassociation_modifiedby)
- [lk_mobileofflineprofileitemassociation_modifiedonbehalfby](#BKMK_lk_mobileofflineprofileitemassociation_modifiedonbehalfby)
- [MobileOfflineProfileItem_MobileOfflineProfileItemAssociation](#BKMK_MobileOfflineProfileItem_MobileOfflineProfileItemAssociation)
- [lk_MobileOfflineProfileItemAssociation_createdby](#BKMK_lk_MobileOfflineProfileItemAssociation_createdby)
- [MobileOfflineProfileItemAssociation_organization](#BKMK_MobileOfflineProfileItemAssociation_organization)
- [lk_mobileofflineprofileitemassociation_createdonbehalfby](#BKMK_lk_mobileofflineprofileitemassociation_createdonbehalfby)


### <a name="BKMK_lk_mobileofflineprofileitemassociation_modifiedby"></a> lk_mobileofflineprofileitemassociation_modifiedby

See systemuser Entity [lk_mobileofflineprofileitemassociation_modifiedby](systemuser.md#BKMK_lk_mobileofflineprofileitemassociation_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_mobileofflineprofileitemassociation_modifiedonbehalfby"></a> lk_mobileofflineprofileitemassociation_modifiedonbehalfby

See systemuser Entity [lk_mobileofflineprofileitemassociation_modifiedonbehalfby](systemuser.md#BKMK_lk_mobileofflineprofileitemassociation_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_MobileOfflineProfileItem_MobileOfflineProfileItemAssociation"></a> MobileOfflineProfileItem_MobileOfflineProfileItemAssociation

See mobileofflineprofileitem Entity [MobileOfflineProfileItem_MobileOfflineProfileItemAssociation](mobileofflineprofileitem.md#BKMK_MobileOfflineProfileItem_MobileOfflineProfileItemAssociation) One-To-Many relationship.

### <a name="BKMK_lk_MobileOfflineProfileItemAssociation_createdby"></a> lk_MobileOfflineProfileItemAssociation_createdby

See systemuser Entity [lk_MobileOfflineProfileItemAssociation_createdby](systemuser.md#BKMK_lk_MobileOfflineProfileItemAssociation_createdby) One-To-Many relationship.

### <a name="BKMK_MobileOfflineProfileItemAssociation_organization"></a> MobileOfflineProfileItemAssociation_organization

See organization Entity [MobileOfflineProfileItemAssociation_organization](organization.md#BKMK_MobileOfflineProfileItemAssociation_organization) One-To-Many relationship.

### <a name="BKMK_lk_mobileofflineprofileitemassociation_createdonbehalfby"></a> lk_mobileofflineprofileitemassociation_createdonbehalfby

See systemuser Entity [lk_mobileofflineprofileitemassociation_createdonbehalfby](systemuser.md#BKMK_lk_mobileofflineprofileitemassociation_createdonbehalfby) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.mobileofflineprofileitemassociation?text=mobileofflineprofileitemassociation EntityType" />