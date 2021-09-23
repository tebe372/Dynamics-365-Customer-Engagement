---
title: "Understand conversation states in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about various states and status reasons of conversations or work items in Omnichannel for Customer Service."
ms.date: 09/24/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Understand conversation states in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic explains the various states and status reasons of the conversation (work item) in Omnichannel for Customer Service.

The conversation can be in an open or closed state and can have the following status reasons:

- [Open](#open)
- [Active](#active)
- [Waiting](#waiting)
- [Wrap-up](#wrap-up)
- [Closed](#closed)

> [!NOTE]
> Additionally, the conversation might have the resolved or scheduled status reason, which is for internal use only.

 ![Omnichannel conversation states.](media/oc-conversation-state.png "Conversation states")

 *Channel* refers to the chat, SMS, social, and Teams channels supported in Omnichannel for Customer Service.

## Open

The conversation (work item) that is in the queue and not assigned to you (agent) is classified under **Open** state.

The conversation (work item) transitions from **Open** to **Active** or **Closed** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | When you pick the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to you. | Channel and Record |
| Open          | Closed           | When the customer disconnects or ends the chat before the conversation is assigned to you.| Chat |

![Transition from open to active or closed.](media/oc-conversation-open1.png "Transition from open to active or closed")

## Active

The conversation that you pick or that is assigned to you is classified under **Active**. In **Active**, your capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, or **Wrap-up** under the following scenarios.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Wrap-up          | When you select the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget (only for a chat channel). | Channel |
| Active        | Open             | When you disconnect the conversation and don't reconnect within a specified timeout period. <br><br> When you release the conversation to the queue. <br><br> When you transfer the conversation to another queue. <br><br> | Channel  |
| Active        | Waiting          | When you close the session (not ending the conversation by selecting the **End** button) while the conversation is active.<br><br> When the customer is disconnected from the conversation.  |  Channel  |
| Active | Closed | When you resolve the case (or get a record to non-active state) and close the session. | Record |


![Transition from active to closed, open, waiting, wrap-up, or in-progress state.](media/oc-conversation-active.png "Active state")

## Wrap-up

This is an intermediate state after you end the conversation, when you can do post-conversation activities, such as, taking notes and update the customer information before moving the conversation to **Closed**. In **Wrap-up**, your (agent) capacity is consumed.

The conversation (work item) transitions from **Wrap-up** to **Closed** under the following scenario.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | When you select the **End** button in communication panel and close the session. | Channel |

![Transition from wrap-up to closed state.](media/oc-conversation-wrap-up1.png "Wrap-up state")

## Waiting

A conversation in waiting doesn't block your capacity. The conversation gets transitioned to waiting when you (agent) close the session without ending the conversation (without selecting **End** button on communication panel) or the customer closes the browser window without closing the chat widget. For example, you're waiting for some information from customer and don't want to end the conversation or the customer's browser closes unexpectedly.

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | When there's no activity on this conversation from either customer or agent, within inactivity timeout period. <br><br> When the customer selects the **End** button to end the conversation and close the session (only for a chat channel).| Channel  |
| Waiting       | Active           | When you revive the session from your **My work items** stream on **Omnichannel Agent Dashboard**. | Channel |
| Waiting       | Open             | When the customer revives the conversation within a specified timeout period while the session is still active in the browser. | Channel |

![Transition from waiting to closed, active, or open state.](media/oc-conversation-waiting1.png "Waiting state")

## Closed

The conversations that are completed by ending them or by closing the session are classified as **Closed** conversations. When you close a conversation, you can't reactivate or reopen the conversation again.

## Automatic closure of a conversation

Omnichannel for Customer Service has a default time set for the conversation to close automatically. That is, if a conversation in a certain stage remains in the stage for more than the default time, then the conversation is moved to the closed state. Conversations achieve a closure, and agents can focus on important conversation, which ultimately enhances the productivity.

The Omnichannel for Customer Service application checks the conversations every 12 hours to identify those that do not transition for more than the default configured time. Such conversations become eligible for automatic closure, and the next time that the scheduler runs, these conversations are moved from the existing state to the **Closed** state.

> [!IMPORTANT]
> To avoid inaccurate statuses, we recommend that you don't change the conversation state and status reason by manually updating the records in Microsoft Dataverse.

### Default time for automatic closure of conversations

All channels have different default configured time after which conversations can be moved to the **Closed** state. 

The following table describes the channel, status reason, and default configured time.

 | Channel | Existing status reason | Default configured time | Description |
 |--------------------|-------|-------------|--------------------------------------|
 | Chat | Open |  20 min   | For a chat channel, a conversation in the **Open** state for more than 20 minutes is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | Chat | Active | None | For a chat channel, a conversation in the Active won’t be automatically closed. |
 | Chat | Wrap-up | 15 minutes | For a chat channel, a conversation that is in the **Wrap-up** stage for more than 15 minutes is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |
 |  |  |  |  |
 | Records (Case) | Open | None | For an entity channel, a conversation in the **Open** won’t be automatically closed. |
 | Records (Case) | Active | None | For an entity channel, a conversation that is  **Active** won’t be automatically closed. |
 |  |  |  |  |
 | SMS, Teams, and social | Open | 30 days | In an asynchronous channel&mdash;such as SMS, Teams, or a social channel&mdash;a conversation that has been in the **Open** state for more than 30 days is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | SMS, Teams, and social | Active | 30 days | In an asynchronous channel&mdash;such as SMS, Teams, or a social channel&mdash;a conversation that has been in the **Active** state for more than 30 days is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Active** to the **Closed** state. |
 | SMS, Teams, and social | Wrap-up | 1 day | In an asynchronous channel&mdash;such as SMS, Teams, or a social channel&mdash;a conversation that has been in the **Wrap-up** state for more than 1 day is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |

**Example**

The scheduler runs for every 12 hours considering starting at 0000 hours AM.

For the chat channel, consider a conversation that's in the **Open** state at 1100 hours of Jan 10, 2020, and remains in this state until 2259 hours at night. Since the conversation is open for more than 20 minutes (default configured time), this conversation is eligible for automatic closure. At 2300 hours of Jan 10, 2020, when the scheduler runs, the conversation that's in the **Open** state is moved to the **Closed** state.

> [!Note]
> The scheduler runs every 12 hours to close all eligible conversations. However, the exact time at which the scheduler runs is dependent on the Omnichannel for Customer Service deployment time in your region. For more information, contact Microsoft support.

### Conversation in waiting

For chat and SMS channel, a conversation in **Waiting** is moved to the **Closed** state when the conversation is inactive for a specified time. The inactive time can be set in the work stream for the **Auto-close after inactivity** option, based on which the conversation will be moved to the closed state after the criteria is met.

For example, when you set **Auto-close after inactivity** to 5 minutes, the conversation is moved to the **Closed** state if it has been in **Waiting** for more than 5 minutes.

To learn more, see [Create a workstream](work-streams-introduction.md#create-a-work-stream).

### Set default time using APIs

Programmatically, you can change the default time and set it as per your organization's requirements using the Web APIs. To learn more, see [Automatic closure of a conversation](auto-close-conversation.md).

### See also

[View communication panel](oc-conversation-control.md)  
[Automatic closure of a conversation](auto-close-conversation.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
