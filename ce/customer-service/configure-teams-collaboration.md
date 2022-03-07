---
title: "Configure Microsoft Teams collaboration | MicrosoftDocs"
description: "Learn how to configure collaboration with Microsoft Teams in Customer Service."
ms.date: 11/05/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure AI suggestions for contacts in Microsoft Teams (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Agents can collaborate with other contacts directly through Microsoft Teams to quickly resolve customer issues. As an administrator, you can enable the Microsoft Teams collaboration feature to help them find the right contacts.

This feature uses the AI capability to automatically suggest contacts in real-time, based on the currently open active case or support conversation when agents explore contacts in the embedded chat experience.

> [!NOTE]
> The Omnichannel for Customer Service app for Dynamics must be configured for agents connect and engage with their customers via channels like Chat for Dynamics 365 Customer Service and SMS.

## How AI-suggested contacts works

The suggestions capability uses AI to recommend contacts who might be able to help agents resolve an issue described in an active case or a support based on similar cases those contacts have worked on. It uses similar case suggestions to find similar cases, and then identifies the most logical contacts based on a few factors related to the experience and proficiency of the contacts in resolving those similar cases, including the following:

- The number of similar cases that the suggested contacts have resolved. A higher number of similar cases that the suggested contacts have resolved might indicate that they have more experience in resolving the issue described in the cases or conversations.

- The similarity level of the similar cases to the active case. A higher similarity of the cases means that the similar cases the contacts have resolved are more related to the active case or conversation that agents are currently working on.

- How recently the suggested contacts have resolved the similar cases. More recent experience might indicate the contact has more current knowledge about resolving the issue described in the cases or conversations.

- The average time that the suggested contacts use to resolve similar cases. Less time spent in resolving similar cases compared to others might indicate that the contact is more familiar than others about how to resolve the issue type.

AI-suggested contacts works with a set of out-of-the-box AI models, so that admins can enable the feature by setting the toggle without the need for extra model training.

For more information about similar case suggestions that impact the AI-suggested contacts, see [How AI suggestions for similar cases and knowledge articles work](csw-enable-ai-suggested-cases-knowledge-articles.md#how-ai-suggestions-for-similar-cases-and-knowledge-articles-work).

## Regional availability and supported languages

The AI suggestions are supported in geographical locations that AI suggestions for similar cases supports. More information: [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md)

The AI suggestions feature is supported in the following languages:

- Dutch
- English
- French
- German
- Italian
- Japanese
- Spanish

## Prerequisites

- AI suggestions for similar cases must be enabled. More information: [Enable AI suggestions for similar cases](csw-enable-ai-suggested-cases-knowledge-articles.md)

- Tenant permissions to enable the enhanced integration with Microsoft Teams feature.

## Enable collaboration with Microsoft Teams


**To enable collaboration with Microsoft Teams and chat**

1. In Customer Service Hub, go to **Service Management**.

2. In the site map, under **Microsoft Teams Integration**, select **Collaboration**.

3. Set the toggle for **Turn on the linking of Dynamics 365 records to Microsoft Teams channels** to **Yes**.

4. To get suggested contacts for active cases or supported conversations, perform the following steps:
   
   1. Select **Case** or **Conversation** in the **Link chat to Dynamics 365 records** section. Based on your selection, the **Case settings** or **Conversation settings** flyout menu appears on the right.

   2. In **Suggested contacts**, turn on the toggle for **AI-based suggested contacts**.

    It takes 24 hours for the data to be preprocessed for the first time use.

    :::image type="content" source="media/enable-ai-suggested-contacts.png" alt-text="Enable the settings for AI-suggested contacts.":::

5. Optionally, set the toggle for **Turn on Enhanced Microsoft Teams Integration** to **Yes**. This setting lets agents pin records and views to a Teams channel directly from Dynamics 365 and also suggests agents who worked on similar cases.

6. Optionally, set the toggle for **Enable Confidential Labels** to **Yes** to create private Teams messages and add sensitivity or confidentiality labels in enhanced Microsoft Teams integration.


### See also

[Collaborate with AI-suggested contacts in Microsoft Teams chat](use-ai-suggested-contacts-teams.md)  
[Overview of Customer Service workspace](csw-overview.md)  

