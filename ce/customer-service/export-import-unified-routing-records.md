---
title: "Export and import record routing data | MicrosoftDocs"
description: "Learn to export and import data pertaining to records enabled for unified routing from source to target environments in Omnichannel for Customer Service."
ms.date: 04/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Export and import data for record channel

By using the Configuration Migration tool, you can migrate the configurations from the source organization to the target organization for the records that're configured to use unified routing.

For information on how to use the Configuration Migration tool, see the following articles:

- [Download Configuration Migration Tool](/powerapps/developer/data-platform/download-tools-nuget)
- [How the Configuration Migration tool works](/power-platform/admin/manage-configuration-data)

## Prerequisites

The following prerequisites must be met:

- In the source organization, if a ruleset refers to custom entities, attributes, relationships, option sets or lookup values, then ensure that they exist in the target organization before you proceed with the migration.
- Ensure that the user who performs the migration has the required privileges on the following entities in the source and target organizations:
  - Characteristic (characteristic)
  - Rating Model (ratingmodel)
  - Rating Value (ratingvalue)
  - Capacity Profile (msdyn_capacityprofile)
  - Queue (queue)
  - Decision contract (msdyn_decisioncontract)
  - Decision rule set (msdyn_decisionruleset)
  - Assignment Configuration (msdyn_assignmentconfiguration)
  - Assignment Configuration Step (msdyn_assignmentconfigurationstep)
  - Master Entity Routing Configuration (msdyn_masterentityroutingconfiguration)
  - Workstream (msdyn_liveworkstream)
  - Routing configuration (msdyn_routingconfiguration)
  - Routing configuration step (msdyn_routingconfigurationstep)
  - Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)

## Export and import data for the record channel

You must perform the steps in the order they're listed to migrate your configuration data successfully from the source to the target organization. Use the information in the tables and refer to the corresponding sample schemas for each configuration.

1. Export and import skill-based configuration
2. Export and import capacity profiles configuration
3. Export and import record queues configuration
4. Export and import intake rules configuration for records
5. Export and import workstreams configuration for records

> [!IMPORTANT]
> The migration of the following items is not in scope:
> 
> - Intelligent skill finder
> - Effort estimation for routing
> - Sentiment prediction for routing
> - Operating hours
> - Role Persona Mapping
> - Notification template
> - Session template
> - Presence
> - Queue membership

### How to use FetchXML to filter records for exporting data

**To generate FetchXML**

1. [Use Advanced find to create a custom view](/power-apps/user/advanced-find#create-edit-or-save-a-view-using-legacy-advanced-find).

1. [Select one or multiple records of the entity to export](/power-apps/user/advanced-find#share-a-personal-view). After step 6 is complete, select Download FetchXML.

1. Edit the XML as follows, and save it

   1. Remove "output-format=xml-platform".

   1. Remove all attribute elements.

   1. Remove the order attribute element.

<!-- <Remove the this procedure> **To use FetchXML to export data from the required entity**

> [!NOTE]
> Use the DataMigrationUtility App instead of the DataMigrationUtility.exe to use the Configuration Migration Tool.


1. In the Configuration Migration Tool, select **Configure Import Settings from Tools**.

1. Select the entity that needs to run FetchXML from the **Available Entity** drop-down list.

1. Select **Edit FetchXML**. Put the XML generated from **Download FetchXML**, and select **OK**.

1. Select **Save**.

-->
## Export and import skill-based configuration

If skill-based routing rulesets are used in your unified routing setup, perform the steps to migrate the corresponding configuration.

> [!NOTE]
> You need to manually create bookableresourcecharacteristictype (Global option set value) in the target organization if required.

**Sample schema**

[Sample schema for skill-based routing](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20skill-based%20routing.xml) to get all the required records.


**To migrate the skill-based routing data**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for skill-based routing configuration.
  
  - **Entity display name**: When you create the schema, select the entities in the sequence that's mentioned in the table.
  - **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes, such as Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes if required.

    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|
    |Characteristic (characteristic)    | <ul><li>Characteristic Type (characteristictype)</li><li>Characteristic (characteristicid)</li><li>Description (description)</li><li>Name (name)</li></ul> |         |
    |Rating Model (ratingmodel)     |<ul><li>Max Rating Value (maxratingvalue)</li><li>Min Rating Value (minratingvalue)</li><li>Name (name)</li><li>Rating Model (ratingmodelid)</li></ul>         |         |
    |Rating Value (ratingvalue)     | <ul><li>Name (name)</li><li>Rating Model (ratingmodel)</li><li>Rating Value (ratingvalueid)</li><li>Value (value)</li></ul> |         |
    |   |         |         |

1. Generate the schema and save it.

1. Export the data and generate the compressed (zip) file.

1. Use the Configuration Migration tool, and select the option to import data in to the target organization using the compressed file.


## Export and import capacity profiles configuration

If you have configured capacity profiles in your unified routing setup, perform the steps to migrate the corresponding configuration.

**Sample schema**

[Sample schema for capacity profiles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20capacity%20profiles.xml) to get all the required records.

**To migrate the capacity profiles data**

1. Use the Configuration Migration tool to create the schema and export data in source organization for capacity profiles configuration.

    [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]

    |Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |---------|---------|---------|
    |Capacity Profile (msdyn_capacityprofile)     | <ul><li>Block Assignment (msdyn_blockassignment)</li><li> Capacity Profile (msdyn_capacityprofileid)</li><li>Default Max Units (msdyn_defaultmaxunits)</li>Name (msdyn_name)</li><li> Reset Duration(msdyn_resetduration)</li><li>Unique Name (msdyn_uniquename)</li></ul> | **Option 1: For all capacity profile records**<br>`  <fetch>` <br>  `<entity name="msdyn_capacityprofile">` <br>`<filter type="and">`<br>`<condition attribute="ismanaged" operator="eq" value="0" />`<br>`</filter>`<br>`</entity>`<br>  `</fetch>`<br><br> **Option 2: For a single capacity profile record** <br> `<fetch>` <br>`<entity name="msdyn_capacityprofile">`<br>`<filter type="and">`<br>`<condition attribute="msdyn_capacityprofileid" operator="eq" uiname="Demo Capacity Profile 1" uitype="msdyn_capacityprofile" value="{F57CFE3C-14BD-D53E-F423-A1E7F9749DFB}" />`<br> `</filter>`<br> `</entity>`<br> `</fetch>` <br><br> **Option 3: For multiple capacity profile records** <br> `<fetch>`<br> `<entity name="msdyn_capacityprofile">`<br> `<filter type="and">` <br> `<condition attribute="msdyn_capacityprofileid" operator="in">`<br>`<value uiname="Demo Capacity Profile 1" uitype="msdyn_capacityprofile">{F57CFE3C-14BD-D53E-F423-A1E7F9749DFB}</value>`<br> `<value uiname="Demo Capacity Profile 2" uitype="msdyn_capacityprofile">{D0B8ABFB-4A9F-0B1F-6FF4-8003E29A623C}</value>`<br>`</condition>`<br>`</filter>`<br>`</entity>`<br>`</fetch>` |
    |     |         |         |

2. Generate the schema and save it.

3. Export the data and generate the compressed (zip) file.

4. Use the Configuration Migration tool, and select the option to import data to the target organization.

## Export and import record queues configuration

 > [!NOTE]
 > If you are using the out-of-the-box assignment methods for queues, such as highest capacity and round robin, skip the following entities that are listed in step 1.
 >
 > - Decision rule set
 > - Assignment configuration
 > - Assignment configuration step

 > - If you want to update a queue in the target organization after a successful import for queues and import again, remove the following line from the sample schema xml and data. `<field displayname="Queue type" name="msdyn_queuetype" type="optionsetvalue" customfield="true" />`
**Sample schema**

[Sample schema for unified routing-based record queues](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20queues.xml) to get all the required records.


**To migrate the unified routing-based record queues**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for unified routing-based record queues configuration.

    [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]
    - **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.


    |S.No.| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |-----|---------|---------|---------|
    | 1. | Queue (queue) |  <ul><li>Assignment Input Contract Id (msdyn_assignmentinputcontractid)</li><li>Assignment Strategy (msdyn_assignmentstrategy) </li> <li> Description (description) </li><li> Is Default Queue (msdyn_isdefaultqueue) </li><li> Is Omnichannel queue (msdyn_isomnichannelqueue) </li><li> Name (name) </li><li> Priority (msdyn_priority) </li><li> Queue (queueid) </li><li> Queue type (msdyn_queuetype) </li><li> Type (queueviewtype) </li></ul>  |  [**Option 1: All queues for unified routing-based records**](#BKMK1all-ur-qs) <br><br> [**Option 2: Single queue for unified routing-based records**](#BKMK2single-ur-qs) <br><br> [**Option 3: Multiple queues for unified routing-based records**](#BKMK3multiple-ur-qs)   |
    | 2. | Decision contract (msdyn_decisioncontract)  |  <ul> <li>Contract definition (msdyn_contractdefinition)</li> <li>Decision contract (msdyn_decisioncontractid) </li> <li>Name (msdyn_name) </li> <li>Unique name (msdyn_uniquename) </li> </ui>  | [**Option 1: Decision contract for all unified routing-based record queues**](#BKMK1all-ur-dc) <br> <br>  [**Option 2: Decision contract for a single unified routing-based record queue**](#BKMK2single-ur-dc) <br> <br> [**Option 3: Decision contract for multiple unified routing-based record queues**](#BKMK3multiple-ur-dc) <br> |
    | 3. |  Decision ruleset (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li>Authoring mode (msdyn_authoringmode)</li><li>Decision rule set (msdyn_decisionrulesetid)</li><li>Description (msdyn_description)</li><li>Input contract (msdyn_inputcontractid)</li><li>Is input collection (msdyn_isinputcollection)</li><li>ML model type (msdyn_mlmodeltype)</li><li>Name (msdyn_name)</li><li>Output contract (msdyn_outputcontractid)</li><li>Rule set definition (msdyn_rulesetdefinition)</li><li>Rule set type (msdyn_rulesettype)</li><li>Unique name (msdyn_uniquename)</li></ul>  |  [**Option 1: Decision ruleset for all unified routing-based record queues**](#BKMK1all-ur-rls) <br> <br> [**Option 2: Decision ruleset for a single unified routing-based record queue**](#BKMK2single-ur-rls) <br> <br> [**Option 3: Decision ruleset for multiple unified routing-based record queues**](#BKMK3multiple-ur-rls) <br>  |
    | 4. |  Assignment Configuration (msdyn_assignmentconfiguration)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Description (msdyn_description)</li><li>Is Active Configuration (msdyn_isactiveconfiguration)</li><li>Name (msdyn_name)</li><li>Queue (msdyn_queueid)</li><li>Unique Name (msdyn_uniquename)</li></ul>  | [**Option 1: Assignment configuration for all unified routing-based record queues**](#BKMK1all-ur-ac) <br> <br>[**Option 2: Assignment configuration for a single unified routing-based-record queue**](#BKMK2single-ur-ac) <br> <br>[**Option 3: Assignment configuration for multiple unified routing-based record queues**](#BKMK3multiple-ur-ac) <br>   |
    | 5. |  Assignment Configuration Step (msdyn_assignmentconfigurationstep)  |  <ul><li>Assignment Configuration (msdyn_assignmentconfigurationid)</li><li>Assignment Configuration Step (msdyn_assignmentconfigurationstepid)</li><li>Is default ruleset (msdyn_isdefaultruleset)</li><li>Name (msdyn_name)</li><li>Rule Set (msdyn_rulesetid)</li><li>Rule Set - (msdyn_rulesetid)</li><li>Step Order (msdyn_steporder)</li><li>Step Type (msdyn_type)</li><li>Unique Name (msdyn_uniquename)</li></ul>  |  [**Option 1: Assignment configuration step for all unified routing-based record queues**](#BKMK1all-ur-acs) <br> <br> [**Option 2: Assignment configuration step for a single unified routing-based record queue**](#BKMK2single-ur-acs) <br> <br> [**Option 3: Assignment configuration step for multiple unified routing-based record queues**](#BKMK3multiple-ur-acs) <br>   |
    |||||

2. Generate the schema and save it.

3. Export the data and generate the compressed (zip) file.

4. Extract the zip file, open the data.xml file present in the extracted folder, and perform the following operations:

   - In the source and target organizations, run the following OData API and note the GUID of `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_assignmentoutput'

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization  with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API and note the GUID of `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_selectionruleoutput'

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization  with the msdyn_decisioncontractid GUID of the target organization.

5. Package the extracted content again.

6. Use the Configuration Migration tool, and select the option to import data into the target organization.



### FetchXML for queues

**Option 1: All queues for unified routing-based records**<a name="BKMK1all-ur-qs"></a>

```
<fetch> 
   <entity name="queue">
    <filter type="and">
      <condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
      <condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
      <condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
    </filter>
  </entity>
</fetch>
```

**Option 2: Single queue for unified routing-based records**<a name="BKMK2single-ur-qs"></a>

```
<fetch> 
   <entity name="queue"> 
    <filter type="and"> 
      <condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" /> 
    </filter> 
   </entity> 
</fetch>
```

**Option 3: Multiple queues for unified routing-based records**<a name="BKMK3multiple-ur-qs"></a>

```
<fetch> 
   <entity name="queue"> 
    <filter type="and"> 
     <condition attribute="queueid" operator="in"> 
      <value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value> 
      <value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value> 
     </condition> 
    </filter> 
   </entity> 
</fetch> 
```

### FetchXML for decision contract entity

**Option 1: Decision contract for all unified routing-based record queues**<a name="BKMK1all-ur-dc"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_queuetype" entityname="aw" operator="eq" value="192350001" />
				<condition attribute="msdyn_isomnichannelqueue" entityname="aw" operator="eq" value="1" />
				<condition attribute="queueid" entityname="aw" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_isomnichannelqueue" entityname="be" operator="eq" value="1" />
				<condition attribute="msdyn_queuetype" entityname="be" operator="eq" value="192350001" />
				<condition attribute="queueid" entityname="be" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_isomnichannelqueue" entityname="bm" operator="eq" value="1" />
				<condition attribute="msdyn_queuetype" entityname="bm" operator="eq" value="192350001" />
				<condition attribute="queueid" entityname="bm" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
		</filter>
		<link-entity name="queue" from="msdyn_assignmentinputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="aw"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bb">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bc">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bd">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="be"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bj">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bk">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bl">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="bm"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch>  
```

**Option 2: Decision contract for a single unified routing-based record queue**<a name="BKMK2single-ur-dc"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="queueid" entityname="aw" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="be" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="bm" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
		</filter>
		<link-entity name="queue" from="msdyn_assignmentinputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="aw"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bb">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bc">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bd">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="be"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bj">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bk">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bl">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="bm"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Option 3: Decision contract for multiple unified routing-based record queues**<a name="BKMK3multiple-ur-dc"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="queueid" entityname="aw" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="be" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="queueid" entityname="bm" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
		</filter>
		<link-entity name="queue" from="msdyn_assignmentinputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="aw"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bb">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bc">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bd">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="be"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bj">
			<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bk">
				<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="outer" alias="bl">
					<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="outer" alias="bm"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for decision ruleset entity for queues

**Option 1: Decision ruleset for all unified routing-based record queues**<a name="BKMK1all-ur-rls"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
			<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
				<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
					<filter type="and">
						<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
						<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
						<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

**Option 2: Decision ruleset for a single unified routing-based record queue**<a name="BKMK2single-ur-rls"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
			<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
				<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
					<filter type="and">
						<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Option 3: Decision ruleset for multiple unified routing-based record queues**<a name="BKMK3multiple-ur-rls"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_assignmentconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="am">
			<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="an">
				<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="ao">
					<filter type="and">
						<condition attribute="queueid" operator="in">
							<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
							<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
						</condition>
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for assignment configuration entity

**Option 1: Assignment configuration for all unified routing-based record queues**<a name="BKMK1all-ur-ac"></a>

```
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
				<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
				<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Option 2: Assignment configuration for a single unified routing-based-record queue**<a name="BKMK2single-ur-ac"></a>

```
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Option 3: Assignment configuration for multiple unified routing-based record queues**<a name="BKMK3multiple-ur-ac"></a>

```
<fetch>
	<entity name="msdyn_assignmentconfiguration">
		<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="bi">
			<filter type="and">
				<condition attribute="queueid" operator="in">
					<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
					<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for assignment configuration step entity

**Option 1: Assignment configuration step for all unified routing-based record queues**<a name="BKMK1all-ur-acs"></a>

```
<fetch>
	<entity name="msdyn_assignmentconfigurationstep">
		<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
			<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
				<filter type="and">
					<condition attribute="msdyn_queuetype" operator="eq" value="192350001" />
					<condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" />
					<condition attribute="queueid" operator="ne" uiname="Default entity queue" uitype="queue" value="{5A4B76B0-DAB5-4717-9743-9490F2F822C6}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Option 2: Assignment configuration step for a single unified routing-based record queue**<a name="BKMK2single-ur-acs"></a>

```
<fetch>
	<entity name="msdyn_assignmentconfigurationstep">
		<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
			<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
				<filter type="and">
					<condition attribute="queueid" operator="eq" uiname="Test Record Queue 1" uitype="queue" value="{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

**Option 3: Assignment configuration step for multiple unified routing-based record queues**<a name="BKMK3multiple-ur-acs"></a>

```
<fetch>
	<entity name="msdyn_assignmentconfigurationstep">
		<link-entity name="msdyn_assignmentconfiguration" from="msdyn_assignmentconfigurationid" to="msdyn_assignmentconfigurationid" link-type="inner" alias="bq">
			<link-entity name="queue" from="queueid" to="msdyn_queueid" link-type="inner" alias="br">
				<filter type="and">
					<condition attribute="queueid" operator="in">
						<value uiname="Test Record Queue 1" uitype="queue">{A5ED5CAA-3A54-EC11-8F8F-000D3A1CBB9E}</value>
						<value uiname="Test Record Queue 2" uitype="queue">{B2862B31-3B54-EC11-8F8F-000D3A1CBB9E}</value>
					</condition>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

## Export and import intake rules configuration for records

**Sample schema**

[Sample schema for intake rules for record routing](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20intake%20rules%20for%20record%20routing.xml) to get all the required records.

**To migrate the unified routing-based intake rules for records**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for a record routing configuration. 
   
    - If in the target organization, a record routing hub exists for the record type that you want to migrate, then do one of the following steps:
      
       - Delete the record routing hub and in Intake Data.xml, remove the attribute msdyn_rulesetdefinition from the entity msdyn_decisionruleset.
       - Keep the value of msdyn_rulesetdefinition as empty.
  
    [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]
    - **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.
   
     > [!Note]
	 > Update the entity logical name in the sample code to migrate entities other than incident.

    | S.No.| Entity display name (Logical name)  |Attribute display name (Logical name)  |Use FetchXML to filter records  |
    |-----|---------|---------|---------|
    | 1. | Decision contract (msdyn_decisioncontract) |  <ul><li>Contract definition (msdyn_contractdefinition)</li><li>Decision contract (msdyn_decisioncontractid) </li><li>Name (msdyn_name) </li><li>Unique name (msdyn_uniquename) </li></ul>  |  [**Option 1: Decision contract for all routed records**](#BKMK1dc-all-rr) <br><br> [**Option 2: Decision contract for the incident entity**](#BKMK2dc-incident) <br><br>  [**Option 3: Decision contract for the incident and task entities**](#BKMK3dc-incident-task)  |
    | 2. |  Decision ruleset (msdyn_decisionruleset)  |  <ul><li>AI builder model (msdyn_aibmodelid)</li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li> Description (msdyn_description) </li><li>  Input contract (msdyn_inputcontractid) </li><li>  Is input collection (msdyn_isinputcollection) </li><li> ML model type (msdyn_mlmodeltype) </li><li> Name (msdyn_name) </li><li> Output contract (msdyn_outputcontractid) </li><li>  Rule set definition (msdyn_rulesetdefinition) </li><li>  Rule set type (msdyn_rulesettype) </li><li> Unique name (msdyn_uniquename) </li></ul> |  [**Option 1: Decision ruleset for all routed records**](#BKMK1drl-all-rr) <br><br> [**Option 2: Decision ruleset for the incident entity**](#BKMK2drl-incident) <br><br> [**Option 3: Decision ruleset for the incident and task entities**](#BKMK3drl-incident-task) <br> <br>  |
    | 3. | Master Entity Routing Configuration (msdyn_masterentityroutingconfiguration) | <ul><li>Entity (msdyn_entitylogicalname) </li><li> Master Entity Routing Configuration (msdyn_masterentityroutingconfigurationid) </li><li> Name (msdyn_name) </li><li> Rule set (msdyn_rulesetid) </li><li> Unique Name (msdyn_uniquename) </li></ul> |  [**Option 1: Master entity routing configuration for a routed records**](#BKMK1mer-rr) <br> <br>  [**Option 2: Master entity routing configuration for the incident entity**](#BKMK2mer-incident) <br> <br> [**Option 3: Master entity routing configuration for the incident and task entities**](#BKMK3mer-incident-task) |
    |||||

2. Generate the schema and save it.

3. Export the data and generate the compressed (zip) file.

4. Extract the zip file, open the data.xml file present in the extracted folder, and perform the following operations:

   - In the source and target organizations, run the following OData API and note the `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfiguration'

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

   - In the source and target organizations, run the following OData API and note the `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfigurationunifiedrouting'

     In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization  with the msdyn_decisioncontractid GUID of the target organization.

5. Package the extracted content again.

6. Use the Configuration Migration tool, and select the option to import data into the target organization.


### FetchXML for decision contract entity for intake rules

**Option 1: Decision contract for all routed records**<a name="BKMK1dc-all-rr"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="not-null" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="not-null" />
			</filter>
		</filter>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" linktype="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer"alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" linktype="outer" alias="bt" /></link-entity>
	</entity>
</fetch>
```
**Option 2: Decision contract for the incident entity**<a name="BKMK2dc-incident"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
		</filter>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch>
```

**Option 3: Decision Contract for the incident and task entities**<a name="BKMK3dc-incident-task"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="task" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="task" />
			</filter>
		</filter>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch> 
```
### FetchXML for decision ruleset entity for intake rules

**Option 1: Decision ruleset for all routed records**<a name="BKMK1drl-all-rr"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="cp">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" operator="not-null" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Option 2: Decision ruleset for the incident entity**<a name="BKMK2drl-incident"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="cp">
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

**Option 3: Decision ruleset for the incident and task entities**<a name="BKMK3drl-incident-task"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="inner" alias="cp">
			<filter type="and">
				<filter type="or">
					<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
					<condition attribute="msdyn_entitylogicalname" operator="eq" value="task" />
				</filter>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for entity routing configuration for intake rules

**Option 1: Master entity routing configuration for a routed records**<a name="BKMK1mer-rr"></a> 

```
<fetch>
	<entity name="msdyn_masterentityroutingconfiguration">
		<filter type="and">
			<condition attribute="msdyn_entitylogicalname" operator="not-null" />
		</filter>
	</entity>
</fetch> 
```

**Option 2: Master entity routing configuration for the incident entity**<a name="BKMK2mer-incident"></a> 

```
<fetch>
	<entity name="msdyn_masterentityroutingconfiguration">
		<filter type="and">
			<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
		</filter>
	</entity>
</fetch> 
```

**Option 3: Master entity routing configuration for the incident and task entities**<a name="BKMK3mer-incident-task"></a>

```
<fetch>
	<entity name="msdyn_masterentityroutingconfiguration">
		<filter type="and">
			<filter type="or">
				<condition attribute="msdyn_entitylogicalname" operator="eq" value="incident" />
				<condition attribute="msdyn_entitylogicalname" operator="eq" value="task" />
			</filter>
		</filter>
	</entity>
</fetch>
```

## Export and import workstreams configuration for records

**Sample schema**

[Sample schema for unified routing record workstream](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/unified-routing-sample-schemas/Sample%20schema%20for%20unified%20routing%20record%20workstreams.xml) to get all the required records.

**To migrate the unified routing-based record workstreams**

1. Use the Configuration Migration tool to create the schema and export data from the source organization for unified routing-based record workstreams.

    [!INCLUDE[ur-migration](../includes/cc-ur-migration.md)]
    - **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.
    
	**<Note to be added>**

    | S.No. | Entity display name (Logical name)  | Attribute display name (Logical name)  | Use FetchXML to filter records  |
    |-----|---------|---------|---------|
    | 1. |  Workstream (msdyn_liveworkstream)  |  <ul><li>Allow Automated Messages (msdyn_enableautomatedmessages)</li> <li> </li> <li>Allowed Presences (msdyn_allowedpresences)</li> <li>Assign WorkItem After Decline or Timeout (msdyn_assignworkitemafterdecline)</li> <li>Auto-close after inactivity (msdyn_autocloseafterinactivity)</li> <li>Block capacity for wrap up state (msdyn_blockcapacityforwrapup)</li> <li>Bot queue (msdyn_bot_queue)</li> <li>Bot rule (msdyn_bot_rule)</li> <li>Bot user (msdyn_bot_user)</li> <li>Capacity (msdyn_capacityrequired)</li> <li>Capacity format (msdyn_capacityformat)</li> <li>Channel (msdyn_streamsource)</li> <li>Contract Id (msdyn_routingcontractid)</li> <li>Default (msdyn_sessiontemplate_default)</li><li>Default Queue (msdyn_defaultqueue)</li> <li>Direction (msdyn_direction)</li> <li>Enable selecting from push-based work streams (msdyn_enableselectingfrompushbasedworkstreams)</li> <li>Entity (msdyn_masterentityroutingconfigurationid)</li> <li>FallBack Language (msdyn_fallbacklanguage)</li> <li>Follow-up after waiting (msdyn_followupafterwaiting)</li> <li>Handling Time Threshold (msdyn_handlingtimethreshold)</li> <li>Incoming authenticated (msdyn_notificationtemplate_incoming_auth)</li> <li>Is Default (msdyn_isdefault)</li> <li>Keep same agent for entire conversation (msdyn_enableagentaffinity)</li> <li>Matching Logic (msdyn_matchinglogic)</li> <li>Max Concurrency (msdyn_maxconcurrentconnection)</li> <li>Mode (msdyn_mode)</li> <li>Name (msdyn_name)</li> <li>Notification (msdyn_notification)</li> <li>Outbound queue (msdyn_outboundqueueid)</li> <li>Record Identification Rule (msdyn_recordidentificationrule)</li> <li>Record Identification Validation Rule (msdyn_recordidentificationvalidationrule)</li> <li>Screen pop timeout (msdyn_screenpoptimeout)</li> <li>Screen pop timeout (msdyn_screenpoptimeout_optionSet)</li> <li>Skill Attachment Rules Count (msdyn_skillattachmentrulescount)</li> <li>Skill Attachment Rules Count (Last Updated On) (msdyn_skillattachmentrulescount_date)</li> <li>Skill Attachment Rules Count (State) (msdyn_skillattachmentrulescount_state)</li> <li>Waiting Time Threshold (msdyn_waitingtimethreshold)</li> <li>Work Distribution Mode (msdyn_workdistributionmode)</li> <li>Work Stream (msdyn_liveworkstreamid)</li> </ui>  |  [**Option 1: All unified routing-based record workstreams**](#BKMK1all-ur-ws) <br> <br>  [**Option 2: Single unified routing-based record workstream**](#BKMK2single-ur-ws) <br> <br>  [**Option 3: Multiple unified routing-based record workstreams**](BKMK3multiple-ur-ws) <br> |
    | 2. |  Decision contract (msdyn_decisioncontract)  |  <ul><li>Contract definition (msdyn_contractdefinition) </li> <li> Decision contract (msdyn_decisioncontractid) </li> <li> Name (msdyn_name) </li> <li> Unique name (msdyn_uniquename) </li> </ul>  |  [**Option 1: Decision contract for all unified routing-based record workstreams**](#BKMK1dc-ur-ws) <br> <br>  [**Option 2: Decision contract for a single unified routing-based record workstream of type = incident**](#BKMK2dc-ur-ws) <br> <br> [**Option 3: Decision contract for multiple unified routing-based record workstreams of type = incident and type = task**](#BKMK3dc-ur-ws) <br> <br> |
    | 3. |  Decision rule set (msdyn_decisionruleset)  |  <ul><li> AI builder model (msdyn_aibmodelid)</li><li> Authoring mode (msdyn_authoringmode) </li><li> Decision rule set (msdyn_decisionrulesetid) </li><li>Description (msdyn_description) </li><li>Input contract (msdyn_inputcontractid) </li><li>Is input collection (msdyn_isinputcollection) </li><li>ML model type (msdyn_mlmodeltype) </li><li>Name (msdyn_name) </li><li>Output contract (msdyn_outputcontractid) </li><li>Rule set definition (msdyn_rulesetdefinition) </li><li>Rule set type (msdyn_rulesettype) </li><li>Unique name (msdyn_uniquename) </li></ul>  |  [**Option 1: Decision ruleset for all unified routing-based record workstreams**](#BKMK1drl-ur-ws) <br> <br> [**Option 2: Decision ruleset for a single unified routing-based record workstream of type = incident**](#BKMK2drl-ur-ws) <br> <br> [**Option 3: Decision ruleset for multiple unified routing-based record workstreams type = incident and type = task**](#BKMK3drl-ur-ws) <br><br> |
    | 4. | Routing configuration (msdyn_routingconfiguration) |  <ul> <li> Is active configuration (msdyn_isactiveconfiguration) </li> <li> Name (msdyn_name) </li> <li> Routing configuration (msdyn_routingconfigurationid) </li> <li> Unique name (msdyn_uniquename) </li> <li>Workstream (msdyn_liveworkstreamid) </li> </ul>  |  [**Option 1: Routing configuration for all unified routing-based record workstreams**](#BKMK1rc-ur-ws) <br><br> [**Option 2: Routing configuration for a single unified routing-based record workstream**](#BKMK2rc-ur-ws) <br> <br> [**Option 3: Routing configuration for multiple unified routing-based record workstreams**](#BKMK3rc-ur-ws) <br><br> |
    | 5. |  Routing configuration step (msdyn_routingconfigurationstep)  |  <ul><li> Name (msdyn_name) </li><li> Routing configuration (msdyn_routingconfigurationid) </li><li> Routing configuration step (msdyn_routingconfigurationstepid) </li><li> Rule set (msdyn_rulesetid) </li><li> Step order (msdyn_steporder) </li><li> Step type (msdyn_type) </li><li> Unique name (msdyn_uniquename) </li></ul>  |  [**Option 1: Routing configuration step for all unified routing-based record workstreams**](#BKMK1rs-ur-ws) <br><br> [**Option 2: Routing configuration step for a single unified routing-based record workstream**](#BKMK2rs-ur-ws) <br><br> [**Option 3: Routing configuration step for multiple unified routing-based record workstreams**](#BKMK3rs-ur-ws) <br><br>  |
    | 6. |  Workstream capacity profile (msdyn_liveworkstreamcapacityprofile)  |  <ul><li> Capacity Profile (msdyn_capacityprofile_id)</li><li> Name (msdyn_name) </li><li>Workstream (msdyn_workstream_id) </li><li>Workstream Capacity profile (msdyn_liveworkstreamcapacityprofileid)</li></ul>  | [**Option 1: Workstream capacity profile for all unified routing-based record workstreams**](#BKMK1cp-ur-ws) <br><br> [**Option 2: Workstream capacity profile for a single unified routing-based record workstream**](#BKMK2cp-ur-ws) <br><br> [**Option 3: Workstream capacity profile for multiple unified routing-based record workstreams**](#BKMK3cp-ur-ws) <br><br>   |
    |||||

2. Generate the schema and save it.

3. Export the data and generate the compressed (zip) file.

4. Extract the zip file, open the data.xml file present in the extracted folder, and perform the following operations:

   1. In the source and target organizations, run the following OData API and note the `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfiguration'

   2. In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization  with the msdyn_decisioncontractid GUID of the target organization.

   3. In the source and target organizations, run the following OData API and note the `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_baseoutputcontractmasterentityroutingconfigurationunifiedrouting'

   4. In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.
   
   5. In the source and target organizations, run the following OData API and note the `msdyn_decisioncontractid`.

      https://`<OrgURL>`/api/data/v9.1/msdyn_decisioncontracts?$select=msdyn_decisioncontractid&$filter=msdyn_uniquename eq 'msdyn_demandqueueidentificationoutput'

   6. In data.xml file, replace all the occurrences of the msdyn_decisioncontractid GUID in the source organization with the msdyn_decisioncontractid GUID of the target organization.

5. Package the extracted content again.

6. Use the Configuration Migration tool, and select the option to import data into the target organization.

### FetchXML for workstream entity

**Option 1: All unified routing-based record workstreams**<a name="BKMK1all-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_mode" operator="eq" value="717210001" />
			<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
		</filter>
	</entity>
</fetch> 
```
**Option 2: Single unified routing-based record workstream**<a name="BKMK2single-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
		</filter>
	</entity>
</fetch> 
```
**Option 3: Multiple unified routing-based record workstreams**<a name="BKMK3multiple-ur-ws"></a>

```
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">
	<entity name="msdyn_liveworkstream">
		<filter type="and">
			<condition attribute="msdyn_liveworkstreamid" operator="in">
				<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
				<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
			</condition>
		</filter>
	</entity>
</fetch> 
```

### FetchXML for decision contract entity

**Option 1: Decision contract for all unified routing-based record workstreams**<a name="BKMK1dc-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_mode" entityname="an" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="an" operator="eq" value="192350000" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_mode" entityname="bd" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="bd" operator="eq" value="192350000" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="not-null" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="not-null" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba">
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb">
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc">
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch> 
```
**Option 2: Decision contract for a single unified routing-based record workstream of type = incident**<a name="BKMK2dc-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba">
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb">
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc">
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch>
```
**Option 3: Decision contract for multiple unified routing-based record workstreams of type = incident and type = task**<a name="BKMK3dc-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisioncontract">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="an" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="bd" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="incident" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bp" operator="eq" value="task" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="bt" operator="eq" value="task" />
			</filter>
		</filter>
		<link-entity name="msdyn_liveworkstream" from="msdyn_routingcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="an"></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="ba">
			<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bb">
				<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="bc">
					<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="bd"></link-entity>
				</link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_inputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bo">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bp" /></link-entity>
		<link-entity name="msdyn_decisionruleset" from="msdyn_outputcontractid" to="msdyn_decisioncontractid" link-type="outer" alias="bs">
			<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="bt" /></link-entity>
	</entity>
</fetch> 
```
### FetchXML for decision ruleset entity

**Option 1: Decision ruleset for all unified routing-based record workstreams**<a name="BKMK1drl-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_mode" entityname="af" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" entityname="af" operator="eq" value="192350000" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="not-null" />
			</filter>
		</filter>
		<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad">
			<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af"></link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="dc"></link-entity>
	</entity>
</fetch> 
```
**Option 2: Decision ruleset for a single unified routing-based record workstream of type = incident**<a name="BKMK2drl-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
			<filter type="and">
				<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="eq" value="incident" />
			</filter>
		</filter>
		<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad">
			<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af"></link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="dc"></link-entity>
	</entity>
</fetch>
```
**Option 3: Decision ruleset for multiple unified routing-based record workstreams type = incident and type = task**<a name="BKMK3drl-ur-ws"></a>

```
<fetch distinct="true">
	<entity name="msdyn_decisionruleset">
		<filter type="or">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" entityname="af" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
			<filter type="and">
				<filter type="or">
					<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="eq" value="incident" />
					<condition attribute="msdyn_entitylogicalname" entityname="dc" operator="eq" value="task" />
				</filter>
			</filter>
		</filter>
		<link-entity name="msdyn_routingconfigurationstep" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="ad">
			<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="outer" alias="ae">
				<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="outer" alias="af"></link-entity>
			</link-entity>
		</link-entity>
		<link-entity name="msdyn_masterentityroutingconfiguration" from="msdyn_rulesetid" to="msdyn_decisionrulesetid" link-type="outer" alias="dc"></link-entity>
	</entity>
</fetch> 
```
### FetchXML for routing configuration entity

**Option 1: Routing configuration for all unified routing-based record workstreams**<a name="BKMK1rc-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Option 2: Routing configuration for a single unified routing-based record workstream**<a name="BKMK2rc-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Option 3: Routing configuration for multiple unified routing-based record workstreams**<a name="BKMK3rc-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_routingconfiguration">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="ah">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for routing configuration step entity

**Option 1: Routing configuration step for all unified routing-based record workstreams**<a name="BKMK1rs-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_mode" operator="eq" value="717210001" />
					<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```
**Option 2: Routing configuration step for a single unified routing-based record workstream**<a name="BKMK2rs-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```
**Option 3: Routing configuration step for multiple unified routing-based record workstreams**<a name="BKMK3rs-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_routingconfigurationstep">
		<link-entity name="msdyn_routingconfiguration" from="msdyn_routingconfigurationid" to="msdyn_routingconfigurationid" link-type="inner" alias="ak">
			<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_liveworkstreamid" link-type="inner" alias="al">
				<filter type="and">
					<condition attribute="msdyn_liveworkstreamid" operator="in">
						<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
						<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
					</condition>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch> 
```

### FetchXML for workstream capacity profile entity

**Option 1: Workstream capacity profile for all unified routing-based record workstreams**<a name="BKMK1cp-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_mode" operator="eq" value="717210001" />
				<condition attribute="msdyn_streamsource" operator="eq" value="192350000" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Option 2: Workstream capacity profile for a single unified routing-based record workstream**<a name="BKMK2cp-ur-ws"></a>

```
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="eq" uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream" value="{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}" />
			</filter>
		</link-entity>
	</entity>
</fetch> 
```
**Option 3: Workstream capacity profile for multiple unified routing-based record workstreams**<a name="BKMK3cp-ur-ws"></a>
```
<fetch>
	<entity name="msdyn_liveworkstreamcapacityprofile">
		<link-entity name="msdyn_liveworkstream" from="msdyn_liveworkstreamid" to="msdyn_workstream_id" link-type="inner" alias="am">
			<filter type="and">
				<condition attribute="msdyn_liveworkstreamid" operator="in">
					<value uiname="Test Record Workstream Case 1" uitype="msdyn_liveworkstream">{759255C7-7AC8-98E0-7E3E-59A7F0312EFC}</value>
					<value uiname="Test Record Workstream Task 1" uitype="msdyn_liveworkstream">{E6246229-33AC-5A9E-2FFE-51668AD44215}</value>
				</condition>
			</filter>
		</link-entity>
	</entity>
</fetch>
```    
## Considerations for export and import of data

[!INCLUDE[ur-migration considerations](../includes/cc-ur-migration-considerations.md)]

### See also

[Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)  
[Export and import configuration for live chat](export-import-unified-routing-live-chat.md)  