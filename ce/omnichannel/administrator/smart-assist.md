---
title: "Configure Smart Assist for agents | MicrosoftDocs"
description: "Learn about how to smartly assist agents with the next-best steps in the Omnichannel Administration app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: "dynamics-365-customerservice"
ms.topic: article
---

# Smart assist

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview of smart assist

The new-age customer service industry is moving toward the vision of being intelligent rather than process-driven while interacting with customers. Pivoting on intelligence capabilities helps unleash the productivity of agents to perform better on key performance indicators and&mdash;at the same time&mdash;deliver better customer experience.

Smart assist is an intelligent assistant that provides real-time recommendations to agents, helping them to take actions while interacting with customers. It allows organizations to build a custom bot and plug-in to their environment. These custom bots interpret conversations in real time and provide relevant recommendations such as knowledge articles, similar cases, and next-best steps to the agent's user interface.

The smart assist feature can be enabled across all channels, such as Chat for Dynamics 365 Customer Service, SMS, and Facebook (excluding Entity Records Channel), making it a consistent experience for agents.

## Value proposition

- Contextual recommendations are generated based on real-time conversations.

- Plug-in organization-specific recommendations are displayed to agents in real time.

- Action-oriented recommendations are given for agents to send responses or execute automated actions.

- Intelligence is powered by using Microsoft Azure or third-party capabilities.

- Agents can achieve improved average handling time and first call resolution.

## Prerequisites

- Productivity pane must be enabled. Out of the box, productivity pane is enabled by default.
- Smart assist must be enabled.
- One of the following:
    - AI-based suggestions for ongoing conversations and knowledge articles should be enabled by your administrator. More information: [Enable AI suggestions for similar cases and knowledge articles](../../customer-service/csw-enable-ai-suggested-cases-knowledge-articles.md)
    - Develop a smart assist bot and integrate it with Omnichannel for Customer Service. The smart-assist bot interprets the conversation context in real time and provides suggestions to agents. For information: [Build a smart assist bot](../developer/how-to/smart-assist-bot.md).

## Settings to enable AI-suggested similar cases and knowledge articles

You can enable AI-suggested similar cases and knowledge articles that will appear for agents during ongoing conversations. These settings need to be configured in the Service Management area of Customer Service Hub. More information: [Enable AI suggestions for similar cases and knowledge articles](../../customer-service/csw-enable-ai-suggested-cases-knowledge-articles.md).

## Settings to enable smart assist using custom Azure bot

[Step 1: Create a bot user](#step-1-create-a-bot-user)

[Step 2: Add smart assist bot to a workstream](#step-2-add-smart-assist-bot-to-a-workstream)

[Step 3: Enable Smart Assist](#step-3-enable-smart-assist)

### Step 1: Create a bot user<a name="step-1-create-a-bot-user"></a>

Create a bot user in the application to work as a smart assistant to the agent. A bot user is created as an application user and assigned the **Omnichannel agent** role. If your bot needs to search for knowledge base articles, then you need to provide either the **Customer Service Manager** or **Customer Service Representative** role.

You can create an application user only in the web client. Use the bot application ID of the smart assist bot to create the bot user. For information: [Create a bot user](configure-bot.md#step-1-create-a-bot-user).

### Step 2: Add a smart assist bot to a work stream<a name="step-2-add-smart-assist-bot-to-a-workstream"></a>

After you create a bot user, you need to add the bot to the work stream so that agents who are part of this workstream can see the suggestions.

1. Sign in to the Omnichannel Administration app.

2. Under **Work Distribution Management**, select **Work Streams**.

3. Select the work stream for which you want to add the smart-assist bot.

4. Select the **Smart Assist** tab.

5. In the **Smart Assist** section, select **Add Existing**. The **Lookup Records** pane appears.

6. Select the search icon to see the list of available smart-assist bots, select a bot from the list, and then select **Add**.
You can add multiple bots to a work stream based on your business requirements.

7. Select **Save**.

### Step 3: Enable Smart Assist<a name="step-3-enable-smart-assist"></a>

After you've created the agent script, you need to enable it in the productivity pane to display the scripts to agents in Omnichannel for Customer Service.

To learn more about the productivity pane, see [Productivity pane overview](productivity-pane.md). You can enable agent productivity tools in the [App profile manager](../../app-profile-manager/overview.md) in the Power Apps portal.

After you've enabled Smart Assist in the App profile manager, agents can see the smart-assist cards in Omnichannel for Customer Service.

> [!Note]
> - If you don't create smart-assist cards and enable the productivity pane, users won't see the pane in Omnichannel for Customer Service.
> - We recommend that you remove the smart-assist control if you've customized a form to add smart-assist. If you don't remove the smart-assist control, agents won't be able to see the smart-assist control in the form or productivity pane.

### See also

[Macros](macros.md)  
[Agent scripts](agent-scripts.md)
