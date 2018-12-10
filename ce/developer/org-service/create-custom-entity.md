---
title: "Create a custom entity (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "Learn how to create a custom user-owned entity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: f53639b1-7d62-4470-8ca6-c9a6500c9230
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Create a custom entity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic shows how to create a custom user-owned entity called **Bank Account** and add four different types of attributes to it.  
  
 You can also create organization-owned custom entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Entity ownership](../introduction-entities.md#entity-ownership)  
  
> [!NOTE]
>  You won’t be able to see this entity in the application navigation unless the entity properties are edited to set the **Areas that display this entity** are set.  
  
<a name="BKMK_CreateCustomEntity"></a>   
## Create a custom entity  
 The following sample uses the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> to create the entity and the <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata><xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.PrimaryAttribute>.  
  
 The `_customEntityName` value is “new_bankaccount”.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata1](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata1.cs#createupdateentitymetadata1)]  
  
<a name="BKMK_AddStringAttribute"></a>   
## Add a String attribute to the custom entity  
 The following sample adds a <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> attribute to the `Bank Account` entity.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata2](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata2.cs#createupdateentitymetadata2)]  
  
<a name="BKMK_AddMoneyAttribute"></a>   
## Add a Money attribute to the custom entity  
 The following sample adds a <xref:Microsoft.Xrm.Sdk.Metadata.MoneyAttributeMetadata> attribute to the `Bank Account` entity.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata3](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata3.cs#createupdateentitymetadata3)]  
  
<a name="BKMK_AddDateTimeAttribute"></a>   
## Add a DateTime attribute to the custom entity  
 The following sample adds a <xref:Microsoft.Xrm.Sdk.Metadata.DateTimeAttributeMetadata> attribute to the `Bank Account` entity.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata4](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata4.cs#createupdateentitymetadata4)]  
  
<a name="BKMK_AddLookupAttribute"></a>   
## Add a Lookup attribute to the custom entity  
 The following sample uses <xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest> to create a one-to-many relationship with the `Contact` entity so that a <xref:Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata> attribute is added to the `Bank Account` entity.  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata5](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata5.cs#createupdateentitymetadata5)]  
  
### See also  
 [Use the IOrganizationService Sample and Helper Code](use-sample-helper-code.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>   
 [Customize entity metadata](../customize-entity-metadata.md)   
 [Which Entities are Customizable?](../which-entities-are-customizable.md)   
 [Retrieve, update, and delete entities](retrieve-update-delete-entities.md)   
 [Create and update an entity than can be emailed](create-update-entity-emailed.md)   
 [Create a custom activity entity](create-custom-activity-entity.md)   
 [Change Entity Icons](../modify-icons-entity.md)   
 [Change Entity Messages](../modify-messages-entity.md)
