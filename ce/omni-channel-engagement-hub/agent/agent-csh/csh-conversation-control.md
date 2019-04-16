---
title: "Omni-channel Engagement Hub Communication panel (Conversation control) | MicrosoftDocs"
description: "Conversation control is a communication panel in Omni-channel Engagement Hub where you interact with the customer."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6172303E-4BB8-4E54-BC23-71AC2514A248
ms.custom: 
---

# View communication panel

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Communication panel is where you, as an agent, interact with your customer. When you sign in to the application,by default, communication panel is in minimized mode. That is, the minimized communication panel appears at the bottom left side. Expanding the communication panel displays the welcome screen with certain key features.

 > [!div class=mx-imgBorder] 
 > ![Omni-channel Engagement Hub conversation control landing page](../../media/csh-conversation-control-landing-page.png "Omni-channel Engagement Hub conversation control landing page")  

For a chat channel, you can send quick replies and search for and share knowledge articles with the customer with whom you are interacting. You can transfer the conversation (work item) to another agent or queue. Use the consult option if you need help to resolve the work item. Also, you can switch between internal and public mode to send messages to the internal participants (other agents and/or supervisors).

The landing page explains some of the key features of Omni-channel Engagement Hub and communication panel. When you interact with a customer, you can see the following interface in the communication panel.

 > [!div class=mx-imgBorder]
 > ![Omni-channel Engagement Hub communication panel chat interface](../../media/csh-conversation-control-chat-interface.png "Omni-channel Engagement Hub communication panel chat interface")  

In communication panel, you can see the following options:
 
| Annotation | Option     | Description                                   | Shortcut |
|------|------------------|-----------------------------------------------|----------|
|  1   | Public           | Send messages to public | `/P` |
|  2   | Internal         | Send messages to internal users | `/I` |
|  3   | Customer summary | View customer summary |  |
|  4   | Quick replies    | Send templatized messages  | `/Q` |
|  5   | Notes            | Take notes specific to conversation | |
|  6   | Knowledge articles | Search for knowledge articles and share | `/KB` |
|  7   | Link to conversation | Link the record to this conversation | |
|  8   | Consult          | View list to consult with other users | `/C` |
|  9   |  Transfer        | View list to transfer the request | `/T` and `/TQ` |

## Send messages using Public and Internal mode

The communication panel allows you to send messages in two ways - **Internal** and **Public**. 

When you want to send messages only to the internal participants like other agents and/or supervisors, then use the **Internal** option. The internal messages are not shown to the customers.

 > [!div class=mx-imgBorder]
 > ![Reply messages by selecting internal or public mode](../../media/csh-cc-public-internal-modes.png "Reply messages by selecting internal or public mode")

You can use keyboard shortcuts to send internal and public messages:

- **/I** – Press the Slash (/) key and the letter I to send an internal message to other agents and/or a supervisor.

- **/P** – Press the Slash (/) key and the letter P to send a public message to all the participants in the interaction.

## Customer summary

The Customer summary page displays details about a customer with whom you interact. When you are conversing with more than one customer simultaneously, and when you switch from one chat conversation to another, the customer session details are fetched according to the context.

Also, you can manually refresh the Customer summary page to get the details of the customer when switching from one customer session to another. Use the Refresh button to refresh the Customer summary page to get relevant details about the customer based on chat conversations with the customer.

 > [!div class=mx-imgBorder]
 > ![Session overview refresh button in the communication panel](../../media/csh-cc-options-refresh-session-overview-customer360.png "Session overview refresh button in the communication panel")

## Send templatized messages in the chat

The communication panel allows you to send templatized messages to the customer with whom you're interacting with. These templatized messages are stored as quick replies. Select the **Quick replies** button to retrieve the messages and send it to the customers.

 > [!div class=mx-imgBorder] 
 > ![Use quick replies option to send faster replies to customers](../../media/csh-send-quick-replies-chat.png "Use quick replies option to send faster replies to customers")  

You can use a keyboard shortcut to see the list of quick replies. Press the Slash (/) key and the letter Q (**/Q**).

## Take notes specific to conversation

Use the notes option to capture information specific to the conversation when you interact with the customers. Use the option in the communication panel to launch the notes.

 > [!div class=mx-imgBorder]
 > ![Launch notes panel for taking notes](../../media/csh-cc-option-notes.png "Launch notes panel for taking notes")

More information [Take notes specific to conversation](csh-take-notes.md)

## Search for and share knowledge articles

From the communication panel, you can search for relevant knowledge articles based on the context of the session and share it with the customers through the communication panel. Use the shortcut to launch knowledge articles search.

 > [!div class=mx-imgBorder]
 > ![Use the knowledge articles option in the communication panel to launch the knowledge search page](../../media/csh-cc-options-knowledge-articles.png "Use the knowledge articles option in the communication panel to launch the knowledge search page")  

**/KB** (forward slash, letter K, and letter B) is the keyboard shortcut to launch the knowledge articles search control. You can search and share the article with the customer through the communication panel. Use the **Send link** button to share the knowledge article link with the customer.

To learn more, see [Search for and share knowledge articles](csh-search-knowledge-articles.md)

### Link to conversation

When you have a conversation with a customer, you can link the conversation to the record (case or account/contact). 

> [!div class=mx-imgBorder]
 > ![Use the link to conversation option to launch the link the conversation to a record](../../media/csh-cc-options-ellipsis-link.png "Use the link to conversation option to launch the link the conversation to a record")

To learn more, see [Search for records to the conversation](csh-search-record.md)

## Consult with agent or supervisor

The communication panel allows you to consult with other agents and/or supervisor using the consult option. You can invite the agent or supervisor by selecting the **Consult** button in the communication panel.

 > [!div class=mx-imgBorder]
 > ![Use the consult option to launch the consulting list](../../media/csh-cc-options-ellipsis-consult.png "Use the consult option to launch the consulting list")  

You can use a keyboard shortcut to see the list of agents and/or the supervisor who are available for consultation. Press the Slash (/) key and the letter C (**/C**).


## Transfer the conversation

The communication panel allows you to transfer a conversation request. You can transfer the conversation (work item) either to an agent or a queue.

 > [!div class=mx-imgBorder]
 > ![Use the transfer option to launch the transfer list](../../media/csh-cc-options-ellipsis-tansfer.png "Use the transfer option to launch the transfer list")

You can transfer a request only to agents who are configured in the same work stream and queue. If the request belongs to another queue and when you transfer the request, routing rules assign the conversation (work item) to the appropriate agent in the queue.

Use a keyboard shortcut to see the list of agents and/or the supervisor who is available for transfer. Press the Slash (/) key and the letters t (**/T**).

Use a keyboard shortcut to see the list of queues to transfer the conversation request. Press the Slash (/) key and the letters T and Q (**/TQ**).

 ![Transfer agent list](../../media/csh-cc-transfer-agent-list.png "transfer agent list") ![Transfer queue list](../../media/csh-cc-transfer-queue-list.png "Transfer queue list")

**/T** (forward slash, letter t) launches the **Agent** and **Queue** tabs. Select either tab and then select the agent or the queue from the list to transfer the conversation. The **/T** shortcut keeps the focus on the agent tab whereas the **/TQ** shortcut keeps the focus on the queue tab.

> [!div class="nextstepaction"]
> [Next topic: Set user presence](csh-set-user-presence-status.md)

## See also

- [Introduction to the agent interface](csh-introduction-agent-interface-omni-channel-engagement-hub-customer-service-hub.md)
- [View customer summary and know everything about customers](csh-customer-360-overview-of-the-existing-challenges.md)
- [Search for and share knowledge articles](csh-search-knowledge-articles.md)
- [Take notes specific to conversation](csh-take-notes.md)
- [View customer summary for an incoming conversation request](csh-view-customer-360-incoming-conversation-request.md)
- [Create a record](csh-create-record.md)
- [Search for records](csh-search-record.md)
