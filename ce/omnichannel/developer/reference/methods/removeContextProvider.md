---
title: "removeContextProvider (Omnichannel for Customer Service JavaScript API reference)| MicrosoftDocs"
description: 
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
---
# removeContextProvider

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[removeContextProvider-description](../includes/removeContextProvider-description.md)]

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();`

## Parameters

None

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
                 'contextKey1': 'contextValue1', // string value
                 'contextKey2': 12.34, // number value
                 'contextKey3': true // boolean value
      };
   });

   // Removes the currently set custom context provider, if any
   Microsoft.Omnichannel.LiveChatWidget.SDK.removeContextProvider();
});
```

## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)
