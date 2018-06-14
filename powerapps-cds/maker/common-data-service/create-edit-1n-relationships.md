---
title: "Create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships in PowerApps | MicrosoftDocs"
description: "Learn how to create one-to-many or many-to-one entity relationships"
ms.custom: ""
ms.date: 05/27/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
author: "Mattp123"
ms.assetid: 52c00707-b2bc-4950-abec-89baefd94f6e
caps.latest.revision: 33
ms.author: "matp"
manager: "kvivek"
tags: 
---
# Create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships

In Common Data Service for Apps 1:N (one-to-many) or N:1 (many-to-one) relationships define how two entities are related to each other. 
  
Before you create a custom entity relationship, evaluate whether using an existing entity relationship would meet your requirements. More information: [Create new metadata or use existing metadata?](create-edit-metadata.md#create-new-metadata-or-use-existing-metadata)

There are two designers you can use to create and edit 1:N (one-to-many) or N:1 (many-to-one) relationships:

|Designer| Description|
|--|--|
|[PowerApps portal](https://web.powerapps.com)|Provides an easy streamlined experience, but some special settings are not available. More information: [Create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships in PowerApps portal](create-edit-1n-relationships-portal.md)|
|Solution explorer|Not as easy, but provides for more flexibility for less common requirements. More information: [Create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships in PowerApps solution explorer](create-edit-1n-relationships-solution-explorer.md) |

> [!NOTE]
> You can also create new entity relationship in your environment using the following:
> - In model-driven apps, select **New Field** from the form editor and create a *Lookup* field. More information: [Add a field to a form](../model-driven-apps/add-field-form.md)
> - Create a new Lookup field for the related entity. More information: [Create and edit fields](create-edit-fields.md)
> - Import a solution that contains the definition of the entity relationship. More information: [Import, update, and export solutions](import-update-export-solutions.md)
> - Use Power Query to create new entities and fill them with data. More information: [Quickstart: Add data to an entity in the Common Data Service by using Power Query](/powerapps/maker/common-data-service/data-platform-cds-newentity-pq).
> - A developer can use [Metadata services](/powerapps/developer/common-data-service/use-web-services#metadata-services) to write a program to create and update entity relationships. More information: [Customize entity relationship metadata](/dynamics365/customer-engagement/developer/customize-entity-relationship-metadata)

Information in this topic will help you choose which designer you can use. 

You should use the PowerApps portal to create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships unless you need to address any of the following requirements:

- Make a Hierarchical relationship
- Define whether the relationship is hidden in advanced find.
- Set a requirement level for the lookup field in the related entity
- Configure navigation pane options for model-driven app
- Configure relationship behaviors


## Community tools

**[Entity Relation Diagram Creator](https://www.xrmtoolbox.com/plugins/JourneyIntoCRM.XrmToolbox.ERDPlugin/)** is a tool that XrmToolbox community developed for CDS for Apps. Please see the [Developer tools for Common Data Service for Apps](../../developer/common-data-service/developer-tools.md) topic for more community developed tools.

> [!NOTE]
> The community tools are not a product of Microsoft and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com).

### See also

[Create and edit relationships between entities](create-edit-entity-relationships.md)<br />
[Create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships in PowerApps portal](create-edit-1n-relationships-portal.md)<br />
[Create and edit 1:N (one-to-many) or N:1 (many-to-one) entity relationships in PowerApps solution explorer](create-edit-1n-relationships-solution-explorer.md)


