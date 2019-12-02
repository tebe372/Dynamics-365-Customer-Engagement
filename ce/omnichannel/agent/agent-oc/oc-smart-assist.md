---
title: "Smart assist for agents | MicrosoftDocs"
description: "Learn how to use smart assist feature in the Omnichannel for Customer Service app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Smart assist for agents

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../../legal/dynamics-insider-agreement.md).

## Overview of smart assist

Smart assist is an intelligent assistant that provides real-time recommendations to you (an agent), helping you to take actions while interacting with customers. It shows relevant recommendations such as knowledge articles, similar cases, and next-best steps.

## Smart assist control

The smart assist control can appear in any of the entity forms as configured by your administrator. 

The smart assist bot interprets the conversation in the communication panel and provides real-time recommendations.

The recommendations appear in the user interface as cards. The most recent card (recommendation) appears at the top on the control. If you feel a recommendation doesn't meet the context of the conversation, you can choose to dismiss the card.

For a macro recommendation card, if the execution is successful, a success message is displayed; otherwise, an error message is displayed in the user interface.

When a conversation is escalated from a bot, the agent needs to accept the request and start the conversation with the customer. Now, from this instance, the smart assist bot interprets the conversation in real-time and provides recommendations.

> [!div class=mx-imgBorder]
> ![Smart assist](../../media/oceh/smart-assist.png "Smart assist")

## See also

[Smart assist for agents (admin)](../../administrator/smart-assist.md)
