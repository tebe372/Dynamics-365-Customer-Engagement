---
title: "showProgressIndicator (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 36e17a06-e381-4efd-b3a6-62391377b613
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# showProgressIndicator (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/showProgressIndicator-description.md](./includes/showProgressIndicator-description.md)]

Any subsequent call to this method will update the displayed message in the existing progress dialog with the message specified in the latest method call.

>[!WARNING]
>The progress dialog blocks the UI until it is closed using the [closeProgressIndicator](closeProgressIndicator.md) method. So, you must use this method with caution.

## Syntax

`Xrm.Utility.showProgressIndicator(message)`

## Parameters 

|Name |Type |Required |Description |
|---|---|---|---|
|message|String|Yes|The message to be displayed in the progress dialog.|



### Related topics

[closeProgressIndicator](closeProgressIndicator.md)

[Xrm.Utility](../xrm-utility.md)  



