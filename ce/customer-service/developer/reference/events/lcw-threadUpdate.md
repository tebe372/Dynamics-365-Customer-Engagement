---
title: "lcw threadUpdate | MicrosoftDocs"
description: lcw threadUpdate (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# lcw:threadUpdate (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is raised by live chat when an agent ends a conversation.

Listen for the `lcw:threadUpdate` event, and call the [closeChat](../methods/closeChat.md) method to end the conversation from the client side. You can listen for this event by adding your own event listener on the window object.

## Example

```JavaScript
window.addEventListener("lcw:threadUpdate", function handleLivechatThreadUpdateEvent(){
        // Handle the live chat threadUpdate event, for example:
        // End the conversation using the closeChat method
        Microsoft.Omnichannel.LiveChatWidget.SDK.closeChat();
});
```

### See also

[`lcw:error`](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md) 


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)] 
