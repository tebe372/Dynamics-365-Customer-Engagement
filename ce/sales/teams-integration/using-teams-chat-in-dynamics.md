---
title: "Use Teams chat in Sales Hub | MicrosoftDocs"
description: "Start Teams chat conversations from within Dynamics 365 Sales Hub and link them to records"
ms.date: 05/24/2022
ms.topic: article
author: sbmjais
search.app: 
  - D365CE
  - Powerplatform
ms.author: shjais
manager: shujoshi
---

# Use Microsoft Teams chat in Sales Hub (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../../includes/preview-disclaimer.md)]

You can now engage in a Teams chat conversation from within Dynamics 365 Sales Hub. While you're working on a sales record, you can start a new Teams chat or link an existing chat to the record, and thus collaborate efficiently without switching context. Linking all the associated chats to the record helps you maintain all the conversations related to the record in one place.

> [!NOTE]
> - When you associate a Teams channel to a record, the channel gets linked to the record. However, unlike chat conversations, channel conversations can't be accessed from within Dynamics 365.
> - Your administrator must have enabled this functionality. For more information, go to [Enable or disable the Teams chat in Dynamics 365 (preview)](enable-teams-chat.md).
> - For the embedded Teams chat functionality to work properly, ensure that web browser settings allow pop-ups for the Dynamics website.


You can do the following Teams collaboration activities from Dynamics 365:

- **Start a new linked chat conversation**: The chat gets automatically linked to the record.

- **Add users to an existing linked chat**: The chat appears as a linked chat for all the users involved in the conversation.

- **Link an existing chat to a record**: The entire chat conversation will be visible to all the users who are part of the linked chat.

- **Access all your recent Dynamics 365 chats**: The list pages, such as the opportunities list page, display all of your recent chats that are linked to Dynamics 365 records.

- **Access all your recent chats**: Your top 200 Teams chat conversations are listed on the list and record pages.

- **Link an existing channel to a record**: Although the channel is linked to the record, the channel conversations can only be accessed from within Teams. 


## Open Teams chats and channels related to a record

Open any Dynamics 365 customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false"::: at the upper-right of the page.

:::image type="content" source="media/teams-chat-dynamics365-view.png" alt-text="Screenshot of the Teams collaboration pane for a selected opportunity.":::

The **Teams chats (Preview)** pane opens and displays the following sections on the **Chat** tab:

- **Chats linked to *record*** lists Teams chats that either you've linked to the selected record or someone else has linked with you as a participant.
    
- **Suggested contacts** lists suggested contacts depending on the users who are working on the record. For more information, go to [How contact suggestions work](#how-contact-suggestions-work), later in this topic.

- **Other chats** lists your top 200 chat conversations on Teams. You can select any existing conversation and link it to a record.

The **Channel** tab lists the channels that you've linked to the selected record, and any channels someone else has linked to where you're a participant. If you've linked a record to a channel by using the basic or enhanced collaboration experience, that channel is also listed on this tab.

### How contact suggestions work

The suggested contacts list displays users who are connected or have interacted with the record. Accordingly, a suggested contact can be one or more of the following users, in the given order:

-   If the record is assigned to a user, the owner of the record.

-   If the record is assigned to a team:

    -   The team admin.

    -   Team members who have logged an activity in the record timeline.

-   *(Applicable only for an opportunity)* Sales team members who are connected with the opportunity and have logged an activity in the record timeline.

-   Users who have linked chats with the record.

-   Other users who have logged an activity in the record timeline.

-   *(Applicable only for an opportunity)* All the connected sales team members.

## View all linked Dynamics 365 chats

Open the dashboard or list view of any Dynamics 365 customer engagement table or entity, such as an opportunities list view, and select :::image type="icon" source="media/teams-icon.png" border="false":::. All your linked Dynamics 365 chats will appear under **Chats linked to records**.

## Start a linked Teams chat in Dynamics 365

You can start a new linked chat or convert an existing Teams chat into a linked chat to associate the chat with a Dynamics 365 record.

1.  Open any Dynamics 365 customer engagement record and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** pane opens.

2.  Use one of the following methods:

    -  To start a new linked chat with a participant, select **New linked chat** in the **Chats linked to *record*** section.

    -  To start a linked chat with a suggested contact, select **More (…)** > **Start a linked chat with _contact_** in the **Suggested contacts** section.

    -  To convert an existing chat into a linked chat, select the chat from the **Other chats** section, and then select **More (…)** > **Link to this _record_**.

    The chat name uses the record name or the participant's names, depending on the configuration that your administrator chose. To set the chat name as the record name, you can ask your administrator to turn on the **Use record title as the default chat name for linked chats** setting. You can modify the chat name. It's a good idea to provide a meaningful name so that you can identify the chat even when you're in Teams.

3.  Add more participants to the chat, if you want to.

All the participants in the linked chat will see the chat when they open the record in Dynamics 365.

## Link or unlink an existing chat from a record

You can link a chat to a single record or multiple records. For example, if you had a chat about a lead that turned into an opportunity, you could also link the chat to the opportunity. If you decided later that you didn't want the chat linked to the lead, you could unlink it.

- To link an existing chat to a record, select the chat from the **Other chats** section, and then select **More (…)** > **Link to this _record_**.

- To unlink a chat from a record, select the chat from the **Other chats** section, and then select **More (…)** > **Unlink from this _record_**.

## Link a Teams channel to a record

Link relevant Teams channels to a record so that all the members can easily access the linked channels from the record and follow the conversations.

1.  Open any Dynamics 365 customer engagement record, and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** pane opens.

    Alternatively, select **Collaborate** on the command bar to link a channel to the record. For more information, go to [Enhanced Collaboration Experience with Microsoft Teams](teams-collaboration-enhanced-experience.md).

2.  Select the **Channel** tab. The tab lists the channels that are already linked to the record.

3.  Select the **Link channel** icon :::image type="icon" source="media/link-channel-icon.png" border="false"::: in the upper-right corner of the **Teams chats (preview)** pane.

    The **Collaborate with Microsoft Teams** dialog opens.

4.  To start a new linked channel, select **Create a new connection**.

5.  To link an existing channel, select the channel from the list, and then select **Start collaboration**.

## Start a regular or unlinked Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

While you're in any of the records or in the list pane, select :::image type="icon" source="media/teams-icon.png" border="false":::, and then select the **Compose chat** icon :::image type="icon" source="media/compose-chat-icon.png" border="false"::: in the upper-right corner of the **Teams chats (preview)** pane. This option starts an individual or group chat but doesn't link it to the record.


### See also

[Enable or disable Microsoft Teams chat in Sales Hub](enable-teams-chat.md)
