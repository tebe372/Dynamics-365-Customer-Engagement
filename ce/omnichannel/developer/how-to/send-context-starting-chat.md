---
title: "Manage custom context | Microsoft Docs"
description: "Read how you can send custom context to a chat session which can help decide which queue to route the chat to."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/29/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Manage custom context

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

When a customer initiates a chat from the portal, you can pass custom context to Omnichannel for Customer Service. This custom context can be used for displaying in UI and for creating routing rules, which eventually determine which queue to route the chat to.

The custom context is a collection of key/value pairs. Only primitive values are allowed for any key. The keys of custom context must correspond to context variables that are created for the associated work stream in Omnichannel for Customer Service. If no context variables have been created under live work stream with a matching logical name, variables are created at runtime assuming the type as String. The custom context provider would be invoked by live chat widget when starting a new chat.

Follow these steps to send custom context when starting a chat:

1. Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
2. Once the **lcw:ready** event is raised, register a custom context provider with live chat using the [setContextProvider](../reference/methods/setContextProvider.md) method.
3. Use [startChat](../reference/methods/startChat.md) SDK to initiate a chat.

## Sample code

```JavaScript
function contextProvider(){
	//Here it is assumed that the corresponding work stream would have context variables with logical name of 'contextKey1', 'contextKey2', 'contextKey3'. If no context variable exists with a matching logical name, items are created assuming Type:string               
	return {
			'contextKey1': 'contextValue1', // string value
			'contextKey2': 12.34, // number value
			'contextKey3': true // boolean value
	};
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
	// Handle LiveChat Ready event
	// SDK methods are ready for use now
	// Setting custom context provider to be used with Chat for Dynamics 365
	// The custom context provided by custom context provider can be used for routing the chat to a particular queue
	Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(contextProvider);
	// Starting a new chat
	Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
	// Handle LiveChat SDK error event
	console.log(errorEvent);
});
```

To display the context variables in the Conversation Summary Control for a conversation, make sure that you include `isDisplayable` attribute in the body of [setContextProvider](../reference/methods/setContextProvider.md) method and set its value to `true`. More information: [Display custom context](display-custom-context.md).

> [!div class="nextstepaction"]
> [Next topic: Send authentication token](send-auth-token-starting-chat.md)

### See also

[setContextProvider](../reference/methods/setContextProvider.md)<br />
[getContextProvider](../reference/methods/getContextProvider.md)<br />
[removeContextProvider](../reference/methods/removeContextProvider.md)<br />
[JavaScript API reference](../omnichannel-reference.md)
