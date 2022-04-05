---
title: Configure the inbox | MicrosoftDocs
description: Learn how to enable the inbox in Dynamics 365 Customer Service App profile manager and configure inbox settings in Customer Service admin center.
ms.date: 04/04/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Configure the inbox

As an administrator, you can configure the inbox setting so that when your agents open Customer Service workspace or Omnichannel for Customer Service, they can select the inbox icon to show all the cases and conversations that are assigned to them. The inbox is designed to help agents efficiently work on high velocity tasks, and promote inbox sessions to regular sessions when they need more time to resolve cases and complete their conversations.

You can configure the inbox settings for custom experiences only.

The following asynchronized channels are available in the conversation inbox.

- SMS
- Persistent chat
- Facebook
- Twitter
- WeChat
- LINE
- WhatsApp
- Teams

## Configure the inbox setting for agents

You can configure the inbox in the [Customer Service admin center](/app-profile-manager/app-profile-manager#create-agent-experience-profiles-in-customer-service-admin-center-preview) by editing the agent experience profile to meet your preferred inbox settings.

1. Open the Customer Service admin center app.

1. In **Agent experience**, select **Workspaces**.

1. In **Agent experience profiles**, select **Manage**.

1. Select the profile for which you want to configure the inbox.

   > [!Note]
   > Channel providers must have **All active channels** set to **On** to use and configure the chat setting in the inbox.

1. In **Inbox**, select the **Settings** icon, and then toggle **Inbox** to on.

1. You can either modify an existing view or create a new one by selecting **Edit**.
   The following fields can be configured:
   - **Name:** Specify a name that will show in the inbox. Alphanumeric values are valid names.
   - **Record Type:** Select the record types for which the settings need to be applied. You can select more than one record type.
   - **Chat Status**: Is available if you select the record type as chat. Select one or more of the following settings:
     -  **Assigned**
     -  **Unassigned**
     -  **Resolved**
   - **Email**: Is available if you select the record type as Email. Select all the options that you want to enable.
     - Assigned to me:
       - Emails sent to me
       - Emails assigned to me
     - Unassigned
       - Emails in my team
       - Emails in my queue(s)
       - Emails in a shared mailbox
    - **Agent Visibility**: Select one of the following options to show or hide the view to agents:
      - **Show**
      - **Hide**

## Enable the inbox in App profile manager

After you enable the inbox for a profile, any user who is added to the profile can use the inbox. More information: [Configure the inbox view in App profile manager.](/dynamics365/app-profile-manager/app-profile-manager#configure-the-inbox-view)

## Inbox views

The following views are supported in the inbox:

- **Cases**: Shows all cases that are owned by the user, including active and resolved cases.
- **Assigned Conversations**: Shows all conversations that have been assigned to the user, including active and closed conversations.
- **Resolved Conversations**: Shows all conversations that have been marked as closed, and where the user was the primary agent in the conversation.
- **Unassigned Conversations**: Shows all active conversations and emails in a team or queue in which the user is a member. The user is able to assign conversations to themselves and reply to emails directly from this view.

Inbox views are refreshed every five minutes. Agents can manually refresh the view by using the **Refresh** icon.

## Real-time translation
For information about how to configure real-time translation for conversations in the inbox, see [Enable real-time translation of conversations](enable-real-time-translation.md)


### See also

[Customer Service admin center](/app-profile-manager/app-profile-manager)<br>
[Enable real-time translation of conversations](enable-real-time-translation.md) 
