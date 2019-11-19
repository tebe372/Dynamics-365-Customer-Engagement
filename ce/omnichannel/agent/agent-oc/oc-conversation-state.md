---
title: "Understand conversation states in Omnichannel | MicrosoftDocs"
description: "Learn what the conversation states are in Omnichannel."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 08/29/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Understand conversation states in Omnichannel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

The topic explains the various states of the conversation (work item) in Omnichannel.

Types of conversation states:

 - [Open](#open)

 - [Active](#active)
 
 - [Wrap-up](#wrap-up)

 - [Waiting](#waiting)

 - [Closed](#closed) 

 ![Omnichannel conversation states](../../media/oc-conversation-state.png "Conversation states")

## Open

The conversations (work items) that are in the queue and not assigned to you (agent) are classified under **Open** state. 

The conversation (work item) transitions from **Open** to **Active** or **Closed** state under the following scenarios.

| From state | To state | Scenario  | Type (Chat, SMS, and Entity Record) |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | When you pick the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to you. | SMS, Chat, and Entity Record |
| Open          | Closed           | When the customer disconnects or ends the chat before the conversation is assigned to you.| Chat |

![Transition from open to active or closed state](../../media/oc-conversation-open.png "Open state")

## Active

The conversations that you pick or is assigned to you are classified under **Active** state. In the **Active** state, your capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, or **Wrap-up** state under the following scenarios.

| From state | To state | Scenario  | Type (Chat, SMS, and Entity Record) |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Wrap-up          | When you select the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget.| Chat and SMS |
| Active        | Open             | When you disconnect the conversation and doesn't reconnect with in a specified timeout period. <br><br> When you release the conversation to the queue. <br><br> When you transfer the conversation to another queue. <br><br> | Chat and SMS |
| Active        | Waiting          | When you close the session (not ending the conversation by selecting the **End** button) while the conversation is active.<br><br> When the customer is disconnected from the conversation and you are no longer getting reply, you can close the session without ending the conversation. This will keep conversation in waiting state. |   Chat and SMS |
| Active | Closed | When you resolve the case (or get an entity record to non-active state) and close the session. | Entity Record |

![Transition from active to closed, open, waiting, wrap-up, or in-progress state](../../media/oc-conversation-active.png "Active state")

## Wrap-up

This is an intermediate state after you end the conversation, where you can do after active conversation activities like taking notes and update the customer information before moving the conversation to **Closed** state. In the **Wrap-up** state, your (agent) capacity is consumed.

The conversation (work item) transitions from **Wrap-up** to **Closed** state under the following scenario. 

| From state | To state | Scenario  | Type (Chat, SMS, and Entity Record) |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | When you select the **End** button in communication panel and close the session. | Chat and SMS |

![Transition from wrap-up to closed state](../../media/oc-conversation-wrap-up.png "Wrap-up state")

## Waiting

Conversation in waiting state don't block your capacity. The conversations get transitioned to waiting state when you (agent) close the session without ending the conversation (without clicking **End** button on communication panel). For example, you are waiting for some information from customer and do not want to end the conversation. 

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** state under the following scenarios.

| From state | To state | Scenario  | Type (Chat, SMS, and Entity Record) |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | When there is no activity on this conversation from either customer or agent, with in inactivity timeout period. <br><br> When the customer selects the **End** button to end the conversation and close the session.| Chat and SMS |
| Waiting       | Active           | When you revive the session from your **My work items** stream on **Omnichannel Agent Dashboard**. | Chat and SMS |
| Waiting       | Open             | When the customer revives the conversation within a specified timeout period. | Chat and SMS |

![Transition from waiting to closed, active, or open state](../../media/oc-conversation-waiting.png "Waiting state")

## Closed

The conversations that are completed by ending, and closing the session are classified under **Closed** state. When you close a conversation, you cannot reactivate or reopen the conversation again.

## Automatic closure of a conversation

Omnichannel for Customer Service has a default time set for the conversations to close automatically. That is, if a conversation in a certain state remains in the same state more than the default time, then the conversation is automatically moved to the closed state.

Advantages of automatically closing a conversation:

- Conversations don’t stay in a state for long duration.
- Capacity of the agent is unblocked.
- Conversations achieve a closure and agents can focus on important conversations thus enhancing productivity.

### Understand working of auto-close of conversations

The Omnichannel for Customer Service application checks the conversations every 24 hours to identify the conversations that remains in the same state more than the default time, then the conversation is automatically moved to the **Closed** state.

### Default time for automatic closure of conversation

The conversations coming from different channel has varied scenarios and hence the different threshold time. The matrix describes the channel, state, and default automatic closure time.

 | Channel | State | Automatic closure time | Description |
 |--------------------|-------|-------------|--------------------------------------|
 | Chat | Open |  20 min   | For a chat channel, a conversation in the **Open** state for more than 20 minutes is automatically moved to the **Closed** state. |
 | Chat | Active | None | For a chat channel, a conversation in the Active won’t be automatically closed. |
 | Chat | Wrap-up | 15 minutes | For a chat channel, a conversation in the **Wrap-up** state for more than 15 minutes is automatically moved to the **Closed** state. |
 |  |  |  |  |
 | CDS Entity (Case) | Open | None | For an entity channel, a conversation in the **Open** won’t be automatically closed. |
 | CDS Entity (Case) | Active | None | For an entity channel, a conversation in the **Active** state won’t be automatically closed. |
 |  |  |  |  |
 | SMS | Open | 30 days | For a SMS channel, a conversation in the **Open** state for more than 30 days is automatically moved to the **Closed** state. |
 | SMS | Active | 30 days | For a SMS channel, a conversation in the **Active** state for more than 30 days is automatically moved to the **Closed** state. |
 | SMS | Wrap-up | 1 day | For a SMS channel, a conversation in the **Wrap-up** state for more than 1 day is automatically moved to the **Closed** state. |

### Conversation in waiting state

For chat and SMS channel, a conversation in the **Waiting** state is moved to the **Closed** state when the conversation is inactive for a specified time. **Auto-close after inactivity** is the option in the work stream configuration based on which the conversation is moved to the closed state. 

For example, You set the **Auto-close after inactivity** as 5 minutes. Now, if the conversation is in **Waiting** state for more than 5 minutes, then the conversation is moved to the **Closed** state.

To learn more, see [Create a work stream](../../administrator/work-streams-introduction.md#create-a-work-stream).

### Set default time using APIs

Programmatically, you can change the default time and set it as per your organization's requirements using the Web APIs. To learn more, see [Automatic closure of a conversation](../../developer/auto-close-conversation.md).

> [!div class="nextstepaction"]
> [View communication panel](oc-conversation-control.md)

## See also

[Automatic closure of a conversation](../../developer/auto-close-conversation.md)
