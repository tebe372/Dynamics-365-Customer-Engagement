---
title: "setProgress (Client API reference) in Dynamics 365 for Customer Engagement apps| MicrosoftDocs"
ms.date: 11/20/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 649fe7b0-016d-409f-ba3c-b14e0f1953e0
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# setProgress (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/setProgress-description.md](./includes/setProgress-description.md)]

## Syntax

`stepObj.setProgress(stepProgress,message);`

## Parameters

<table style="width:100%">
<tr>
<th>Name</th>
<th>Type</th>
<th>Required</th>
<th>Description</th>
</tr>
<tr>
<td>stepProgress</td>
<td>Number</td>
<td>Yes</td>
<td>Specify one of the following values to specify the step progress:
<ul>
<li>0: None</li>
<li>1: Processing</li>
<li>2: Completed</li>
<li>3: Failure</li>
<li>4: Invalid</li>
</ul>
</td>
</tr>
<tr>
<td>message</td>
<td>String</td>
<td>No</td>
<td><p>An optional message that is set as the Alt text on the icon for the step.</td>
</tr>
</table>


## Return Value

**Type**: String. 

**Description**: Returns "invalid" or "success" depending on whether the step progress was updated.

## Remarks

This method is supported only for the action steps. Action steps are buttons on the business process stages that users can click to trigger an on-demand workflow or action. Action step is a preview feature introduced in the [!INCLUDE[pn_crm_9_0_0_online](../../../../../includes/pn-crm-9-0-0-online.md)] release. More information: See the **Business Process Flow automation with Action Steps** section in [Blog: New automation and visualization features for Business Process Flows (public preview)](https://blogs.msdn.microsoft.com/crm/2017/10/25/new-automation-and-visualization-features-for-business-process-flows-public-preview/).

### Related topics

[getProgress](getprogress.md)
 
[formContext.data.process](../../formContext-data-process.md)

