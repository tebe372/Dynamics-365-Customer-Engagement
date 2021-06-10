---
title: "lcw onMinimize | MicrosoftDocs"
description: lcw onMinimize (Omnichannel for Customer Service JavaScript API reference)
ms.topic: article
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.reviewer: nenellim
---
# lcw:onMinimize (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when the customer engaged on the chat widget minimizes the widget. You can use this event to create custom experiences around this activity. For example, if you have implemented a custom button, you can update your button to reflect that the chat has been minimized.

## Example

```javascript
window.addEventListener("lcw:onMinimize", function handleWidgetMinimizeEvent(){ // Handle the live chat widget minimize event }); 
```

### See also

[lcw:onMaximize](lcw-onmaximize.md)<br />
[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
