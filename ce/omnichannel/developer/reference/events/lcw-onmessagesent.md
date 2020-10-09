---
title: "lcw onMessageSent | MicrosoftDocs"
description: 
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.topic: article
---
# lcw:onMessageSent  (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when a new message is sent by the customer engaged on the chat widget. You can use this event to create custom experiences around when users send a message. For example, this event can be used to detect user activity and engagement on the chat widget. 

## Example

```javascript
window.addEventListener("lcw:onMessageSent", function handleWidgetMessageSentEvent(){ // Handle the live chat widget message sent event }); 
```

### See also

[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)
