---
title: "Common field properties (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2b91ee28-7f09-435e-9fae-5225aa698e22
caps.latest.revision: 63
ms.author: "rdubois"
manager: "brycho"
---
# Common field properties

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 Fields in Dynamics 365 Customer Engagement forms display controls people use to view or edit data in an entity record. Fields can be formatted to occupy up to four columns within a section.  
  
 The following table describes properties that all fields have. Certain types of fields have special properties. These are described in [Special field properties](../customize/special-field-properties-legacy.md).  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Label**|**Required**: By default the label will match the display name of the field. You can override that name for the form by entering a different label here.|  
||**Display label on the form**|You can choose not to display the label at all.|  
||**Field is read-only**|You can specify that the field is not editable. Using form scripts you can change this to enable or disable editing based on criteria evaluated in the script.|  
||**Lock the field on the form**|This will prevent the field from being removed from the form accidentally. This will prevent any configuration you have applied to the field, such as event handlers, from being cleared if the field were removed. To remove this field a customizer would need to clear this setting first.|  
||**Visible by default**|Showing the field is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the fields has more than one column you can set the field to occupy up to the number of columns that the section has.|  
|**Details**|**Display Name**, **Name**, and **Description**|These read-only fields are for reference. Click the **Edit** button for convenient access to the field definition if you want to edit it.<br /><br /> Each instance of a field in the form has a name property so that they can be referenced in form scripts, but this name is managed by the application. The first instance of the field is the name of the field specified when it was created. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit fields](create-edit-fields.md#create-and-edit-fields)<br /><br /> For each additional time that a field is included in a form, the name appends a number starting with 1 to the end. So if the field name is ‘new_cost’, the first instance is ‘new_cost’, the second is ‘new_cost1’, and so on for each instance of the field in the form.<br /><br />**Note:** The field **Description** value provides tooltip text for the field when people place their cursor over it.|  
|**Events**|**Form Libraries**|Specify any [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources that will be used in the field `OnChange` event handler.<br /><br />|  
||**Event Handlers**|Configure the functions from the form libraries that should be called for the field `OnChange` event. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Event Handlers](../customize/configure-event-handlers-legacy.md)|  
|**Business Rules**|**Business Rules**|View and manage any business rules that reference this field. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create business rules and recommendations](create-business-rules-recommendations-apply-logic-form.md)|  
