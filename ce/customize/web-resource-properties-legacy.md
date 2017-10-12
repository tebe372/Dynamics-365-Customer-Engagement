---
title: "Web resource properties (Dynamics 365 Customer Engagement) | MicrosoftDocs"
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
ms.assetid: 82cd41ea-95b0-4606-9e7d-43eb5ce9ecd6
caps.latest.revision: 63
ms.author: "rdubois"
manager: "brycho"
---
# Web resource properties

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 You can add or edit web resources on a Dynamics 365 Customer Engagement form to make it more appealing or useful to users. Form enabled web resources are images, HTML files, or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] controls.  
  
 For step-by-step instructions, see [Create and edit web resources](create-edit-web-resources.md).  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**General**|**Web resource**|**Required**: The image, HTML, or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource that you want.|  
||**Name**|**Required**: A unique name for the field. The name can contain only alphanumeric characters and underscores.|  
||**Label**|**Required**: A label to display for the web resource.|  
||**Visible by default**|Showing the web resource is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)|  
||**Custom Parameter**|A custom value to pass as the `data` query string parameter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Pass parameters to web resources](../customize/web-resource-properties-legacy.md#BKMK_PassingParametersToWebResource)|  
||**Alternative Text**|When an image web resource is displayed, this value will provide tooltip text for people using screen readers.|  
||**Restrict cross-frame scripting, where supported**.|When pages exist on different domains you may want to prevent them from accessing the content of your form pages. Web resources are always in the same domain, so this should not be an issue with web resources.|  
||**Pass record object-type code and unique identifiers as parameters**|Data about the organization, user, and the record can be passed to the web resource so it can adapt to organization settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)]  [Pass parameters to web resources](../customize/web-resource-properties-legacy.md#BKMK_PassingParametersToWebResource)|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the web resource has more than one column you can set the field to occupy up to the number of columns that the section has.|  
||**Select the number of rows the control occupies**|You can control the height of the web resource by specifying a number of rows.|  
||**Automatically expand to use available space**|You can allow the web resource height to expand to available space.|  
||**Select the scrolling type for the IFRAME**|An HTML web resource is added to the form using an IFRAME.<br /><br /> - **As Necessary**: Show scrollbars when the size of the web resource is larger than the available.<br />- **Always**: Always show scrollbars.<br />- **Never**:  Never show scrollbars.|  
||**Display border**|Display a border around the web resource.|  
|**Dependencies**|**Dependent fields**|A web resource may interact with fields in the form using script. If a field is removed from the form the script in the web resource may break. Add any fields referenced by scripts in the web resource to the **Dependent fields** so that they cannot be removed accidentally.|  
  
<a name="BKMK_PassingParametersToWebResource"></a>   
### Pass parameters to web resources  
 An HTML or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource can accept parameters to be passed as query string parameters.  
  
 Information about the record can be passed by enabling the **Pass record object-type code and unique identifiers as parameters** option. If information is typed into the **Custom Parameter(data)** field it will be passed using the data parameter. The values passed are:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`data`|This parameter is only passed when text is provided for **Custom Parameter(data)**.|  
|`orglcid`|The Organization default language LCID.|  
|`orgname`|The name of the organization.|  
|`userlcid`|The user’s preferred language LCID|  
|`type`|The entity type code. This value can be different for custom entities in different organizations. Use entity type name instead.|  
|`typename`|The entity type name.|  
|`id`|The id value of the record. This parameter has no value until the entity record is saved.|  
  
 Any other parameters are not allowed and the web resource will not open if other parameters are used. If you need to pass multiple values, the data parameter can be overloaded to include more parameters within it.   
