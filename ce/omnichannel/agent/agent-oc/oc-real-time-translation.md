---
title: "Real-time translation in Omnichannel for Customer Service | MicrosoftDocs"
description: "Overview of language translation for agent and customer chats in the Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/18/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Real-time translation of conversations for agents and customers

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - This feature is a preview, which means that it is made available to you before general availability so you can test and evaluate the preview and provide feedback to Microsoft.
> - This preview may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, this preview is not meant to be used with any "live" or production Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Any use of "live" data is at your sole risk and it is your sole responsibility to notify your end users that they should not include sensitive information with their use of the Preview.
> - This preview, and any support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty. This preview is subject to the [Preview Terms](../../legal/supp-dynamics365-preview.md).

## Introduction

When language translation is enabled for conversations that are exchanged between the agent and customer or among agents internally, agents can view the conversation in the language that's set as the default for them. The customer receives the agent's messages in the language they used for initiating the chat. This feature removes the necessity of routing conversations only to agents who know the language being used by the customer.

## How language translation of conversations works

When a customer initiates a chat conversation on the portal, irrespective of the language used by the customer, the assigned agent receives the chat text in the language that's set as the default for them. The language translation happens in real time. For example, if a customer initiates a chat in Spanish, the message text appears to an English-speaking agent in Spanish along with the translated English version. The agent has the option to view and respond to the chat in the customer's language or the agent's default language.

If the agent has to consult a peer or supervisor, it can be done in the language preferred between the agent and peer or agent and supervisor, which can be different from the language used between the agent and customer. The chat transcripts are saved in the languages used in the conversation.

The agent can see the following details pertaining to the feature:

- Information about the language in which the agent receives the chat content is displayed at the top of the chat window.

- The chat content is displayed in the customer's language and translated language.

The following image shows a sample screenshot of the agent experience.

  > [!div class=mx-imgBorder]
  > ![Real-time language translation for the agent](../../media/oc-agent-translated-messages.png "Real-time language translation for agent")

The following image shows a sample screenshot of the customer experience.

  > [!div class=mx-imgBorder]
  > ![Real-time language translation for the customer](../../media/oc-customer-translated-messages.png "Real-time language translation for the customer")

### See also

[View a customer summary](oc-customer-summary.md)  
[View communication panel](oc-conversation-control.md)  