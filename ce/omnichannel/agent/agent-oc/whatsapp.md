---
title: "WhatsApp channel agent experience in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about WhatsApp channel through Twilio agent experience in Omnichannel for Customer Service."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 04/06/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Use WhatsApp channel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../../legal/dynamics-insider-agreement.md).

## WhatsApp channel overview

When you sign in to Omnichannel for Customer Service, you can see your work items in Omnichannel Agent Dashboard. To learn more, see [View agent dashboard and agent conversations (work items)](oc-agent-dashboard.md).

## Prerequisite

Make sure your administrator has configured a WhatsApp channel through Twilio.

### Incoming WhatsApp notification

You'll receive a notification when a customer requests a WhatsApp conversation. Accepting the WhatsApp request starts a session and you'll see the communication panel in which you can exchange messages with the customer.

**Unauthenticated customer incoming notification**

> [!div class=mx-imgBorder]
> ![WhatsApp chat agent notification](../../media/whatsapp-agent-notif.png "WhatsApp chat agent notification")

**Authenticated customer incoming notification**

> [!div class=mx-imgBorder]
> ![WhatsApp chat agent notification](../../media/whatsapp-agent-notif2.png "WhatsApp chat agent notification")

In Omnichannel for Customer Service, you can:

- [View customer summary](oc-customer-summary.md)
- [View communication panel](oc-conversation-control.md)
- [Use call options and visual engagement in live chat](call-options-visual-engagement.md)
- [Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)
- [Manage sessions](oc-manage-sessions.md)
- [Manage applications](oc-manage-applications.md)
- Use productivity tools
    - [Use agent scripts](oc-agent-scripts.md)
    - [View Smart assist cards](oc-smart-assist.md)
    - [Use productivity pane](oc-productivity-pane.md)
- [Create a record](oc-create-record.md)
- [Search, link, and unlink a record](oc-search-link-unlink-record.md)
- [Search for and share knowledge articles](oc-search-knowledge-articles.md)
- [Take notes specific to conversation](oc-take-notes.md)
- [Understand conversation states](oc-conversation-state.md)
- [Manage presence status](oc-manage-presence-status.md)
- [Search for transcripts](oc-search-transcipts.md)
- [View conversation and session forms](oc-view-activity-types.md)
- [View customer summary for an incoming conversation request](oc-view-customer-summary-incoming-conversation-request.md)
- [Search for transcripts](oc-search-transcipts.md)

## WhatsApp message type and 24 hours session rule

- **Session messages**: According to WhatsApp, session messages are incoming messages from a customer, or outgoing responses to the incoming messages, within 24 hours. A messaging session starts when you receive a message from a customer. It lasts for 24 hours from the most recently received message. Session messages do not need to follow a template, and can include media attachments.

- **24 hours session rule**: A messaging session starts when you receive a message from a customer or reply to an incoming message from a customer. When the customer sends a message, you have 24 hours to reply to the customer from the time you received it. However, after 24 hours, if you try to send a message to the customer, an error is displayed: **This conversation has exceeded the 24 hour limit to respond to the customer.**


## See also

[Configure a WhatsApp channel](../../administrator/configure-whatsapp-channel.md)
