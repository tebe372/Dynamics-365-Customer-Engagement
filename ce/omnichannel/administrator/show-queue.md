---
title: "Show customers their position in a queue | MicrosoftDocs"
description: "How to show customers their queue position for a chat widget in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Show customers their position in a queue


[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

As an administrator, you can turn on the feature that displays a customer’s position in the queue when they are waiting to chat with an agent. This feature can help to set customer expectations when wait times are longer due to higher volumes of customers needing support, understaffing, or longer-than-expected handle times (for example, new issues or new agents). Displaying a customer’s queue position can help the customer decide whether to wait in the queue or come back later when the wait time is shorter.

When this feature is turned on, a customer who submits a request when other customers already are waiting is placed in the queue and notified with the following message: **People ahead of you: \<n\>.** 

The number of customers waiting to chat counts down each time a customer in line is served. When no other customers are ahead in the queue, the customer waiting is notified with the following message: **You’re next in line…**.

> [!NOTE] 
> In a scenario where a customer is waiting in the queue and another customer who has been waiting longer is transferred over by an agent, the customer who has been waiting longer is served first, and the other customer does not see a position change in the queue.

## Enable queue position

To configure the queue display feature, follow these steps:

1.	Sign in to Omnichannel Administration.

2.	Go to **Channels** > **Chat**.

3.	Open the chat widget in which you want to enable the queue position setting.

4.	Go to the **Basic details** tab.

5.	In **Queue position**, change **Show position in queue** to **Yes** (this feature is set to **No** by default).

6.  Select **Save**.

## See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Dynamics 365 Portals](embed-chat-widget-portal.md)
