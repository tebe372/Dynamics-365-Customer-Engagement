---
title: "Create workstreams in Customer Service | MicrosoftDocs"
description: "Use this topic to understand how to create workstreams for unified routing in Customer Service and Omnichannel for Customer Service apps."
ms.date: 03/02/2022
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.topic: article
ms.custom: intro-internal
---

# Create workstreams for unified routing

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## Overview

A workstream is a container to enrich, route, and assign work items. The workstream is associated with a channel, such as live chat, voice, or case.

The workstream can belong to multiple channels of the same type, like multiple chat channels. In this case, all the conversations from these channels inherit the routing and work assignment settings of the workstream they belong to.

The workstream can be one of the following types:

- **Messaging**: To route conversations from live chat, SMS, social, and Teams channels.
- **Record**: To route records, such as case, email, and activity.
- **Voice**: To route calls made to the support numbers listed on the customer portal. More information: [Overview of voice channel](voice-channel.md)

> [!IMPORTANT]
>
> - Unified routing must be enabled in the service configuration settings in Customer Service Hub for records to be routed using unified routing. More information: [Provision unified routing](provision-unified-routing.md)
> - Workstreams that you created in the Omnichannel Administration app can't be modified in the Omnichannel admin center app. You'll need to migrate the existing workstreams and then manage them in the Omnichannel admin center app. More information: [Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md)

## Create a workstream

You can create workstreams for unified routing in the Customer Service admin center (preview), Omnichannel admin center, or Customer Service Hub app.

**To create the workstream**

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, select **Workstreams** in **Customer support**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     - In the site map, select **Workstreams** in **General settings**.
    
   ### [Customer Service Hub](#tab/customerservicehub)

     -  In the site map, select **Workstreams** in **Unified Routing**.

1. Select **New workstream**.

1. In the **Create a workstream** dialog, enter the following details:

    - **Name**: Enter an intuitive name, such as **Contoso chat workstream**.
    
    - **Type**: Select one of the following types:
         - **Messaging**
         - **Record**
         - **Voice**
    
    - **Channel**: This box appears if you have selected the type as **Messaging**. Select a channel from the list.
         - If you select **Chat**, the **Make chats persistent** checkbox appears. Select the checkbox if you want to configure persistent chat. Also make sure that you select **Keep same agent for entire conversation** in the **Work distribution** settings of the workstream. More information: [Configure persistent chat](persistent-chat.md).
    
    - **Record**: This box appears if you have selected the type as **Record**. Select the record from the list.  More information: [Set up record routing](set-up-record-routing.md)
    
    - **Work distribution mode**: Select **Push** or **Pick**.
         - In **Push** mode, a work item is dispatched to agents automatically using a message alert. You can configure the push work item to be explicitly picked up. For voice, only push mode is available.
         - In **Pick** mode, a work item is dispatched to agents when they explicitly pick the work item from the **Open work items** in the agent dashboard.

2. Select **Create**. The workstream that you created is displayed with the option to configure the selected channel instance.
    > [!div class=mx-imgBorder]
    > ![Set up a channel.](media/set-up-chat.png "Set up a channel")

3. Perform the steps outlined in one of the following sections depending on the channel that you've selected.
   - [Configure a chat widget](add-chat-widget.md#configure-a-chat-widget)
   - [Configure a voice channel](voice-channel-route-queues.md#configure-a-voice-channel)
   - [Configure a Facebook channel](configure-facebook-channel.md)
   - [Configure a WeChat instance](configure-wechat-channel.md)
   - [Configure a LINE channel](configure-line-channel.md)
   - [Configure a Twitter channel](configure-twitter-channel.md)
   - [Configure a WhatsApp channel](configure-whatsapp-channel.md)
   - [Configure a Microsoft Teams channel](configure-microsoft-teams.md)
   - [Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)
   - [Configure an SMS channel for TeleSign](configure-sms-channel.md)
   - [Configure an SMS channel for Twilio](configure-sms-channel-twilio.md)
   - [Configure a custom messaging channel](configure-custom-channel.md)
   - [Configure record routing](set-up-record-routing.md)

> [!NOTE]
> If asynchronous plug-ins are installed but disabled in your organization, ensure that you set the value of "DisabledForAsyncProcessing" to "No" to avoid issues when you're creating workstreams.


### Configure routing rules

Routing rules for a workstream consist of work classification rules and route-to-queue rules. For the steps to configure routing rules, see the following:

- [Configure work classification rules](configure-work-classification.md)
- [Configure route-to-queue rules](configure-work-classification.md#configure-route-to-queues-rulesets-and-rules)

### Configure work distribution

In the **Work distribution** area of a workstream, you can either accept the default settings or select **See more** and update the following options:

- **Auto-close after inactivity**: Select a time period after which inactive conversations will be moved to the closed state automatically. This option is available for only persistent chat, SMS, social, and Microsoft Teams channels.
 
- **Work distribution mode**: The option that you selected in step 3 is displayed and can't be edited.
- **Capacity**: Select one of the following options. More information: [Create and manage capacity profiles](capacity-profiles.md)
  - **Unit based**: Enter a value if your organization has configured unit-based capacity.
  - **Profile based**: Specify a profile in the list if your organization has configured profile-based capacity.
- **Block capacity for wrap up**: Select a duration to block capacity when the agent is in **Wrap-up** state, such as **1 minute** or **15 minutes**. After the specified duration, agent capacity is released and presence is automatically reset. By default, **Always block** is selected, where agent capacity is blocked as long as the conversation is in **Wrap-up** state. You can also select **Don't block**, where agent capacity is released immediately, when the conversation moves to the **Wrap-up** state.

  > [!NOTE]
  > If you have selected **End of Day mode** in capacity profile, agent capacity won't be reset after the duration selected in the **Block capacity for wrap up** field is over.

- **Allowed presences**: Select the presences in which agents will be assigned.
- **Default skill matching algorithm**: Select **Exact Match**, **Closest Match**, or **None**.
- **Keep same agent for entire conversation**: Set the toggle to yes if you want the conversation to remain assigned to the originally assigned agent. More information: [Agent affinity](#agent-affinity)

### Configure advanced settings

For a selected workstream, expand **Advanced settings** to configure the following options:

- [Sessions](../app-profile-manager/session-templates.md)
- [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
- [Context variables](context-variables-for-bot.md)
- [Smart assist bots](smart-assist-bot.md)
- [Quick replies](create-quick-replies.md)

### Add a bot to a workstream

To add a bot to a workstream, the bot must be configured and available for selection.

For Power Virtual Agents bots, see [Connect omnichannel to your Power Virtual Agents bot](/power-virtual-agents/configuration-hand-off-omnichannel#connect-omnichannel-to-your-power-virtual-agents-bot).
For Azure bots, see [Integrate a bot with Omnichannel for Customer Service](configure-bot.md#integrate-a-bot-with-omnichannel-for-customer-service).

**To add the bot to the workstream**

1. In Customer Service admin center (preview) or Omnichannel admin center, go to **Workstreams**, and select a workstream.
2. For the selected workstream and channel, in the **Bot** area, select **Add bot**.
3. In the **Add a bot** dialog, select the required bot from the **Name** dropdown list, and then select **Save and close**.

When a work item needs to be assigned, the classification rules are run and the work distribution system checks and routes the work item to the bot, if the selected workstream has a bot. After a bot is added to the workstream, the incoming work item is first routed to the selected bot at runtime.

> [!Note]
> 
> - The bot is supported only in push type of workstreams.
> - We recommend that you don't add bots to workstreams that are meant for record routing.

### Manage workstreams

You can manage workstreams on the workstreams page in the Omnichannel admin center or Customer Service Hub app.

Select a workstream to perform any of the following actions:

- **Edit**: Lets you edit the workstream, such as add a new channel or update the existing settings.
- **Copy**: Lets you create a copy of the workstream with all the properties, such as the rules, so that you can reuse the configured workstream in another organization. The copied workstream name is prefixed with "Copy of "*`<workstream>`*.
- **Delete**: Lets you delete the workstream if you no longer need it in your organization. You can't delete workstreams that are used in intake rules for record routing. You'll be prompted to remove the dependencies and then try to delete the workstream.

### Agent affinity

When a conversation becomes active from the waiting status, it might not be assigned to the same agent who had previously handled it. You can use the **Keep same agent for entire conversation** option in the work distribution settings of the workstream to reassign the conversation to the agent who had worked on it earlier. This helps save the effort to reorient the agent or set the context about the customer issue again. Agent affinity works as follows:

- Is enabled by default for SMS, social channels, and Microsoft Teams.
- Is available only for push type of work distribution.
- Reassigns conversations to the same agent, irrespective of the agent's capacity and presence.

Because the conversation assignment takes place using the notification alert, the agent has the option to reject the assignment.

### Associate templates

You can keep the default templates for sessions and notifications or update to use custom templates. More information: [Associate templates in Omnichannel admin center](../app-profile-manager/associate-templates.md#associate-templates-with-workstreams-in-omnichannel-admin-center)

### See also

[Set up record routing](set-up-record-routing.md)  
[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Create workstream for entity record routing in Omnichannel Administration](set-up-entity-workstream.md)  
[Work with queues](queues-omnichannel.md)  
[Automatically identify customers using pre-chat responses](record-identification-rule.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
