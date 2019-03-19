---
title: "Send authentication token | Microsoft Docs"
description: ""
keywords: ""
ms.date: 03/19/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: 51737308-BFD6-4C66-96D6-F11EDCB71E33
author: susikka
ms.author: susikka
manager: shujoshi

---
# Send authentication token

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

<!--note from editor:  Suggest changing the sentence 
"When a user initiates a chat, you can pass an authentication token to Omni-channel Engagement Hub, which helps in authenticating the user." 
to this:
"To authenticate a user when they initiate a chat, pass an authentication token to Omni-channel Engagement Hub." -->

When a user initiates a chat, you can pass an authentication token to Omni-channel Engagement Hub, which helps identify the user. Custom authentication is optional and is relevant only when hosting the chat widget outside Dynamics 365 for Customer Engagement Portal. It is used to send verified information about the current logged-in user. This information will be used to identify the account or contact entity record by Omni-channel Engagement Hub.

<!--note from editor:Should the below sentence say "Follow these steps to pass an authentication token:"?    -->


Follow these steps to send context when starting a chat:

<!--note from editor: In Step 1, are the "live chat SDK methods" the same thing as the methods under "JavaScript API Reference" in this developer guide? If so, make that connection clear.   -->

1. Generate a valid JWT token from the JSON payload. More information: [setAuthTokenProvider](../reference/methods/setAuthTokenProvider.md).
2. Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked only after the widget loads fully and the **lcw:ready** event is fired. You can listen for this event by adding your own event listener on the window object.
3. Once the **lcw:ready** event is raised, register an authentication token provider with live chat by using the [setAuthTokenProvider](../reference/methods/setAuthTokenProvider.md) method.

## Sample code

```JavaScript
let payloadToEncrypt = {
    "sub" : "87b4d06c-abc2-e811-a9b0-000d3a10e09e",
    "lwicontexts" :"{\"msdyn_cartvalue\":\"10000\", \"msdyn_isvip\":\"false\"}",
    "iat" : 1542622071,
    "iss" : "contosohelp.com",
    "exp" : 1542625672,
    "nbf" : 1542622072
};

function convertToJwtToken(payloadToEncrypt){
    // Ideally, you should call your service to convert the payload to a valid JWT token
    return Promise.resolve("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI4N2I0ZDA2Yy1hYmMyLWU4MTEtYTliMC0wMDBkM2ExMGUwOWUiLCJsd2ljb250ZXh0cyI6IntcIm1zZHluX2NhcnR2YWx1ZVwiOlwiMTAwMDBcIiwgXCJtc2R5bl9pc3ZpcFwiOlwiZmFsc2VcIn0iLCJpYXQiOjE1NDI2MjIwNzEsImlzcyI6ImNvbnRvc29oZWxwLmNvbSIsImV4cCI6MTU0MjYyNTY3MiwibmJmIjoxNTQyNjIyMDcyfQ.r37z1M5rMyRYMOJ-rhyTRYFOgvl9N7KvTMueSFPkiuM");
}

function authTokenProvider(callback){
    convertToJwtToken(payloadToEncrypt).then(function (jwtToken){
        // Calling the callback with the valid JWT token
        callback(jwtToken);
    });
}

window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
    // Handle live chat ready event
    // Can use the SDK methods now
    // Setting authentication token provider to be used for the chat
    Microsoft.Omnichannel.LiveChatWidget.SDK.setAuthTokenProvider(authTokenProvider);

    // Starting a new chat
    Microsoft.Omnichannel.LiveChatWidget.SDK.startChat();
});

window.addEventListener("lcw:error", function handleLivechatErrorEvent(errorEvent){
    // Handle livechat error event
    console.log(errorEvent);
});
```

> [!div class="nextstepaction"]
> [Next topic: Initiate chat when user has been waiting](initiate-chat-wait-time.md)

### See also

[JavaScript API reference](../omni-channel-reference.md)<br />
[Manage custom context](send-context-starting-chat.md)