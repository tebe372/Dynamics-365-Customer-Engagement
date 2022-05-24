---
title: "sendMessageToConversation (Omnichannel JavaScript API reference) | MicrosoftDocs"
description: "Includes reference information about sendMessageToConversation method, syntax, and parameters in Omnichannel JavaScript API reference."
ms.date: 05/24/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---
# sendMessageToConversation

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This function can be used to send messages to a conversation.  

> [!Note]
> - The conversation must be assigned to the agent that's logged in.
> - Supported messages include only string literals and valid rich object JSON.

## Syntax

`Microsoft.Omnichannel.sendMessageToConversation(message, toSendBox, liveWorkItemId);`

## Parameters

| Parameter         | Type    | Description |
| ----------------- | ------- | ----------- |
| message           | String or JSON object  | Indicates the message to be sent to a conversation. | 
| toSendBox         | Boolean  | Determines if the message is sent to sendBox or directly to the conversation. |
| liveWorkItemId    | String  | Unique identifier of the conversation to which the message is to be sent. |

## Return value

Returns a resolved or rejected promise based on the outcome of the operation. 

## Example

```javascript
// Sending message directly to the chat of conversation with provided liveWorkItemId
Microsoft.Omnichannel.sendMessageToConversation("Test message",  false, "00000000-0000-0000-0000-000000000000");
```

```javascript
// Sending valid rich object to conversation
let validRichObjJSON = {
  "survey": {
    "Answers": {
      "Section": [
        {
          "Listitems": [
            {
              "OptionTitle": "Xbox Controller multi color",
              "OptionDescription": "Xbox Controller multi color",
              "OptionImageURL": "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RWwBPt?ver=d74f&w=270&h=222&q=90&m=6&p=48&b=%23FFFFFFFF&f=png&o=f&aim=true"
            }
          ],
          "SectionTitle": "XBox Controllers",
          "Multiselect": true
        }
      ],
      "Title": "Microsoft Xbox Controllers",
      "subtitle": "Choose a controller you like",
      "ImageURL": "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE2XP73?ver=7371&w=270&h=222&q=90&m=6&p=48&b=%23FFFFFFFF&f=png&o=f&aim=true",
      "ResponseMessage": "Thanks for choosing."
    }
  },
  "richObjectId": "00000000-0000-0000-0000-000000000000",
  "richObjectType": 192350002,
  "richObjectName": "Test with 0 guid",
  "tabKey": ""
}

Microsoft.Omnichannel.sendMessageToConversation(validRichObjJSON,  false);
```

### See also

[Live chat SDK reference](../../omnichannel-reference.md)
[Omnichannel JavaScript API reference](../../omnichannel-api-reference.md)
[getConversationId](getConversationId.md)  
[linkToConversation](linkToConversation.md)  
[unlinkFromConversation](unlinkFromConversation.md)  
[getConversations](getConversations.md)  
[sendMessageToConversation](sendMessageToConversation.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
