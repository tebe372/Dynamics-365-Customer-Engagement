---
title: "Manage app properties in the Dynamics 365 Customer Engagement app designer | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 10/30/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e773e60f-0211-4c4b-a1af-663be4997629
ms.author: udag
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 14
topic-status: Drafting
---

# Manage app properties in the app designer

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

App properties define important details about the app, like its title or URL. You define app properties when you create an app. If you want to change those properties later, you can do that in the app designer.  
  
1.  In the app designer, on the right side, click the **Properties** tab.  
  
    ![App designer Properties pane](../customize/media/app-designer-properties-tab.png "App designer Properties pane")  
  
2.  Change the information, as required:  

    |Property|Description|  
    |--------------|-----------------|
    |**Name**|Enter a unique and meaningful name for the app.|  
    |**Description**|Type a short description of what the app is.|  
    |**Icon**|By default, the **Use Default App** check box is selected. To select a different web resource as an icon for the app, clear the check box, and then select an icon from the drop-down list. This icon is displayed on the app's preview tile.|
    |**Unique Name**| You cannot change the unique name. Using the unique name, you can query tables to get data from the database.| 
    |**Client**|Defines the type of client that the app will be used for.<br/>-  **Web:** This is the classic [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web browser client.<br/>-  **Unified Interface:** This is the new [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web browser client that has a similar interface across PC and mobile devices.|
    |**App URL Suffix**| The URL you chose while creating the app is shown here by default. You can change the app URL in the **Manage App** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access to apps with security roles](../customize/manage-access-apps-security-roles.md)|
    |**Choose a welcome page for the app**|This option allows you to select from the web resources available in your organization. The welcome pages you create can contain useful information to users such as links to videos, upgrade instructions, or getting started information. For more information about how to create a web resource, such as an HTML file that you can use as a welcome page, see [Create and edit web resources to extend the web application](create-edit-web-resources.md).|
  
3.  Save the app.  
  
### See also  
 [Create or edit an app](../customize/create-edit-app.md)
