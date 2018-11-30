---
title: "Delete or deactivate a view in PowerApps | MicrosoftDocs"
description: "Learn how to delete or deactivate a view"
ms.custom: ""
ms.date: 04/17/2018
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
ms.assetid: 60865f78-7482-42da-8960-adbd3c155028
caps.latest.revision: 25
ms.author: "matp"
manager: "kvivek"
search.audienceType: 
  - customizer
search.app: 
  - D365CE
---
# Delete or deactivate a view 

[!INCLUDE [cc-applies-to-powerapps-and-update-9-0-0](../includes/cc-applies-to-powerapps-and-update-9-0-0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]
  
<a name="BKMK_RemoveViews"></a>   

 You may have a view that you don’t want people to see. Depending on the type of view, you can either delete it or deactivate it.  
  
### Delete a view  
 You can delete any custom public view. Use the steps in [Access view definitions](../customize/accessing-view-definitions.md) to find the view you want to delete and use the ![Delete button](../customize/media/delete.gif "Delete button")**Delete** command. Once you verify that you really want to delete it, the view will be permanently deleted.  
  
 If you don’t want to delete the view permanently, you can deactivate it instead.  
  
### Deactivate or activate views  
 You cannot delete or deactivate any [system views](../customize/types-of-views.md#BKMK_SystemViews), including public views the system created. You can deactivate any public view, including public views the system created.  
  
#### Deactivate or activate a public view  
  
1.  Navigate to **System Views** as described in [Access view definitions](../customize/accessing-view-definitions.md).  
  
2.  Select a public view. To see inactive views, use the **Inactive Public Views** view.  
  
3.  On the menu bar, select **More Actions**, and then select either **Deactivate** or **Activate**.  
  
4.  Select **Publish All Customizations**. 

### See also
[Create or edit a view](create-edit-views.md)
