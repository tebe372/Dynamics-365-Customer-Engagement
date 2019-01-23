---
title: "Client API Xrm object for Dynamics 365 for Customer Engagement | MicrosoftDocs"
description: "The topic provides client API reference for Dynamics 365 for Customer Engagement apps."
ms.date: 12/05/2017
ms.service: crm-online
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 15272ad9-25d7-499e-9361-a65f789daf20
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Client API Xrm object

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The **Xrm** object is globally available to use in your code without having to use the execution context in Client API.

## Xrm object model 

The following illustration displays the Xrm object model:

![Xrm Object Model](../media/ClientAPI-XrmModel.png)

Here is the information about each of the namespaces in the Xrm object:

|Namespace  |Description  |
---------|---------------
|[Xrm.Device](reference/xrm-device.md)|Provides methods to use native device capabilities of mobile devices.|
|[Xrm.Encoding](reference/xrm-encoding.md)|Provides methods to encode strings.|
|[Xrm.Navigation](reference/xrm-navigation.md)|Provides methods for navigating forms and items in Customer Engagement.|
|[Xrm.Panel](reference/xrm-panel.md)|Provides a method to display a web page in the side pane of Customer Engagement form.|
|[Xrm.Utility](reference/xrm-utility.md)|Provides a container for useful methods.|
|[Xrm.WebApi](reference/xrm-webapi.md)|Provides methods to use Web API to create and manage records and execute Web API actions and functions.<br/><br/>[Xrm.WebApi.offline](reference/xrm-webapi/offline.md): Provides methods to create and manage records in the Dynamics 365 for Customer Engagement apps mobile clients while working in the *offline* mode.<br/><br/>[Xrm.WebApi.online](reference/xrm-webapi/online.md): Provides methods to use Web API to create and manage records and execute Web API actions and functions when connected to the server.|

## Client API global context

Use the **Xrm.Utility**.[getGlobalContext](reference/xrm-utility/getGlobalContext.md) method in forms to retrieve information specific to an organization, a user, or the client where script is run without going through the form execution context. This is a change from previous versions where you had to use the form context to retrieve global context by using **Xrm.Page.context**.

> [!NOTE]
> **Xrm.Page.context** is [deprecated](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming#some-client-apis-are-deprecated) in the current release, and you should now use the new **Xrm.Utility.**[getGlobalContext](reference/xrm-utility/getGlobalContext.md) method to get global context in your code targeting version 9.0 or later. 

To access the global context information in a standalone HTML Web resource, you should include a reference to **ClientGlobalContext.js.aspx** in the web resource, and then use the **GetGlobalContext** function. More information: [GetGlobalContext function and ClientGlobalContext.js.aspx](reference/GetGlobalContext-ClientGlobalContext.js.aspx.md)

### Related topics

[Understand the Client API object model](understand-clientapi-object-model.md)

[Deprecated client APIs](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming#some-client-apis-are-deprecated)
