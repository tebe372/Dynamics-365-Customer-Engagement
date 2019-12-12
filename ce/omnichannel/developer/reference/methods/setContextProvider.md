---
title: "setContextProvider (Omnichannel for Customer Service JavaScript API reference) | MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/29/2019
ms.topic: article
---
# setContextProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[setContextProvider-description](../includes/setContextProvider-description.md)]

> [!IMPORTANT]
> - The custom context is a collection of key/value pairs. Only primitive values are allowed for any key.
> - The keys of custom context must correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service.
> - The custom context provider would be invoked by live chat widget when starting a new chat.

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| contextProvider | Function | Function that when invoked, returns the custom context |

## Return Value

None

## Example

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
        // Set the custom context provider
        // Throws error if contextProvider is not a function
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
                   //Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'. If no context variable exists with a matching logical name, items are created assuming Type:string               
	               return {
                             'contextKey1': {'value': 'contextValue1', 'isDisplayable': true},
                             'contextKey2': {'value': 12.34, 'isDisplayable': false},
                             'contextKey3': {'value': true}
                   };
        });
});
```
In the sample code given above, the `value` attribute contains the value of the context variables.

The `isDisplayable` attribute, if set to `true`, will display the passed items within a third tab on the Conversation Summary Control for a given Conversation. This is an optional parameter and its default value is `false`.

> [!NOTE]
> If no context variables have been created under live work stream with a matching logical name, variables are created at runtime assuming the type as String.

![Display context keys](../../../media/context-variable-display.png "Display context keys")

<a name="bkmk_navigationhistory"></a>

### Pass customer's portal navigation as context

You can pass a customer's portal navigation as context at the start of a conversation with that customer.

Given below is the sample code that shows how to use the `setContextProvider` method for this.

```javascript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){

Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
    return {
            'Navigation': { 'value' : 
                '[ {"msdyn_displaytitle":"PageTitle1", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_endtime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350000}, \
                   {"msdyn_displaytitle":"PageTitle2", "msdyn_starttime":"yyyy-mm-ddThh:mm:ssZ","msdyn_endtime":"yyyy-mm-ddThh:mm:ssZ","msdyn_type":192350001} \
                 ]'
             }, // Additional context can be added as shown below
                //Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'. If no context variable exists with a matching logical name, items are created assuming Type:string
                'contextKey1': {'value': 'contextValue1', 'isDisplayable': true},
                'contextKey2': {'value': 12.34, 'isDisplayable': false},
                'contextKey3': {'value': true}
         };
    });
});
```

## Error codes

The following error codes can occur with this method.

|Error Code|Error message|
|-----|-----|
|1|Context provider method execution failed|

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
