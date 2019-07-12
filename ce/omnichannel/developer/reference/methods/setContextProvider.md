---
title: "setContextProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: 
ms.topic: article
ms.assetid: 1C92A31B-70DF-4CE7-9C7A-BE398F34C6F6
ms.custom: 
---
# setContextProvider

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!INCLUDE[setContextProvider-description](../includes/setContextProvider-description.md)]

> [!IMPORTANT]
> The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.
> The keys of custom context must correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service.
> The custom context provider would be invoked by live chat widget when starting a new chat.

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| contextProvider | Function | Function which when invoked, returns the custom context |

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Set the custom context provider
        // Throws error if contextProvider is not a function
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
                   // Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'.
	               return {
                             'contextKey1': {'Value': 'contextValue1', 'IsDisplayable': true},
                             'contextKey2': {'Value': 12.34, 'IsDisplayable': false},
                             'contextKey3': {'Value': true}
                   };
        });
});
```
In the sample code given above, the `Value` attribute contains the value of the context variables.

The `IsDisplayable` attribute, if set to `true` will display the passed items within a third tab on the Conversation Summary Control for a given Conversation.

## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|1|Context provider method execution failed|

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)