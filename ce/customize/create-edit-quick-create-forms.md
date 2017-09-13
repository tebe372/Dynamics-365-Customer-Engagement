---
title: "Create and edit quick create forms in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 68ca9059-cc5a-45e7-88bd-cc57186bbb48
caps.latest.revision: 18
ms.author: "rdubois"
manager: "brycho"
---
# Create and edit quick create forms for a streamlined data entry experience
In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], quick create forms appear when you click the **Create** button in the navigation bar or when you choose **+ New** when creating a new record from a lookup or sub-grid. With quick create forms, you can have a streamlined data entry experience with full support for logic defined by form scripts and business rules.  
  
 The mobile apps use quick create forms for creating new records. If an entity already has a quick create form configured for it, the mobile apps use that form. If an entity doesn't have a configured quick create form, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] generates a quick create form  for creating records in the mobile apps based on the main form definition.  
  
<a name="BKMK_QuickCreateFormEntities"></a>   
## Entities with quick create forms  
 By default only the following system entities have quick create forms.  
  
|||||  
|-|-|-|-|  
|Account|Campaign Response|Case|Competitor|  
|Contact|Lead|Opportunity||  
  
 Although you can create quick create forms for System Activity entities, they do not support quick create forms. Any of the other [Updated entities](../customize/create-design-forms.md#BKMK_UpdatedEntities) and any custom entities can be enabled to support these forms by selecting **Allow Quick Create** in the entity definition and creating a quick create form for them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable or disable options](../customize/create-edit-entities.md#BKMK_EnableDisableOptions)  
  
 You can enable custom activity entities to support quick create forms, and you can create quick create forms for those entities. However, the quick create form for custom activity entities will not be used when people click the **Create** button on the nav bar. These quick create forms can be used only when people add a new record for a subgrid that displays that specific custom activity entity.  
  
<a name="BKMK_CreateQuickCreate"></a>   
## Create a quick create form  
 Although you can define multiple quick create forms, only one quick create form can be used by everyone. The form everyone will use is set using the form order. Quick create forms cannot be assigned to security roles and they do not provide the capability for the user to switch forms.  
  
> [!NOTE]
>  The entity must have the **Allow Quick Create** option enabled for the quick create form to be displayed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable or disable options](../customize/create-edit-entities.md#BKMK_EnableDisableOptions)  
  
#### To create a quick create form  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Choose **Customizations**, then choose **Customize the System**.  
  
3.  In the solutions explorer, expand the entity that you want and select **Forms**.  
  
4.  Select **New** > **Quick Create Form** from the tool bar.  
  
5.  Drag any fields from the **Field Explorer** into the sections in the form.  
  
6.  When you are finished, click **Save and Close**.  
  
7.  Publish customizations to see the new form in the application.  
  
<a name="BKMK_EditQuickCreate"></a>   
## Edit a quick create form  
 While quick create forms support form scripts and business rules, their purpose is different from main forms and they don’t support all the capabilities of main forms. Quick create forms always have one section with three columns. You can’t add additional sections or columns.  
  
 The following controls cannot be added to quick create forms:  
  
-   Sub-grids  
  
-   Quick View Forms  
  
-   Web resources  
  
-   IFRAMEs  
  
-   Notes  
  
-   Bing Maps  
  
 If you add a composite field to a quick create form, it will be displayed as separate fields.  
  
#### To edit a quick create form  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Choose **Customizations**, then choose **Customize the System**.  
  
3.  In the solutions explorer, expand the entity that you want and select **Forms**.  
  
4.  In the form list, double-click a form where the **Form Type** is **Quick Create**.  
  
5.  Drag any fields from the **Field Explorer** into the sections in the form.  
  
     See [Configure event handlers](../customize/use-the-form-editor.md#BKMK_EventHandlers) for information about editing event handlers for form scripts.  
  
6.  When you are finished, click **Save and Close**.  
  
7.  Publish customizations to see the modified form in the application.  
  
### See also  
 [Create and design forms](../customize/create-design-forms.md)   
 [Use the form editor](../customize/use-the-form-editor.md)   
 [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)
