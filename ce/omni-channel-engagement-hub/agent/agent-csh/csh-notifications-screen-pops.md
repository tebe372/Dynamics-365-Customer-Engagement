---
title: "Notification and screen pop for agents working in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn about notifications and their types. Agents will see nofications and screen pops in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 4/18/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6043F127-BF47-4F97-8D1E-319B1D578D8A
ms.custom: 
---

# View notifications and screen pops 

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A notification is a visual alert you see as a dialog box each time you get a call, email, chat, or SMS conversation request from a customer. When you get a notification, you see the details of the customer with whom you are going to interact. In addition, in certain types of notifications, you see an accept and reject button that indicates the action you need to perform to accept or reject an incoming conversation request. When you accept the request, a session is started and you can view the contextual information of the customer and case in the customer summary page.

Some of the scenarios for which you can see the screen pop or notifications are:

- Incoming chat

- Incoming email

- Conversation (work item) assignment

- Conversation transfer

- Conversation escalation

## Types of notifications

There are two types of notifications:

- Toast notifications or floating notifications

- Alert notifications

### Toast notifications or floating notifications

A toast notification or floating notification is a notification message type where you receive information in a dialog, which disappears after a stipulated time. If you select the notification, the associated session or application opens.

Toast notifications or floating notifications appear for SMS, email, chat, and voice scenarios. Also, they appear for conversation (work item) assignments, conversation escalations, and conversation transfer scenarios. This kind of notification might have buttons that require action from you, depending on your business requirements.

### Alert notifications

An alert notification is a type of notification where a dialog appears with actionable buttons. When you select the **Accept** button, a screen pops up with Customer summary details. You need to take an action within the stipulated time; the screen-pop dialog vanishes when the time is up. If your business requires an auto-accept request for an incoming request based on the routing rules, you will see the notification with no buttons.

 > [!div class=mx-imgBorder]
 > ![Alert notification for an incoming request](../../media/oceh/chat-notification-request.png "Alert notification for an incoming request")

## Incoming chat notification

You see a notification for an incoming chat request. When you accept the chat request, you’ll see a screen pop with details about the customer in the Customer summary page. A simultaneous session starts, and a chat window expands in the left panel of the Unified Service Desk.

 > [!div class=mx-imgBorder]
 > ![Incoming chat notification](../../media/oceh/chat-notification-request.png "Incoming chat notification")  

The details you’ll see for a chat channel are:

 - Customer profile

 - Snapshot

 - Conversation summary

 - Recent cases

 - Recent activities

> [!div class="nextstepaction"]
> [Next topic: View customer summary and know everything about customers](csh-customer-360-overview-of-the-existing-challenges.md)

## See also

- [View communication panel](csh-conversation-control.md)
- [Set user presence](csh-set-user-presence-status.md)
- [Search for and share knowledge articles](csh-search-knowledge-articles.md)
- [Take notes specific to conversation](csh-take-notes.md)
- [View customer summary for an incoming conversation request](csh-view-customer-360-incoming-conversation-request.md)
