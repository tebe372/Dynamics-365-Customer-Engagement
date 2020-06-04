---
title: "Create quick responses | MicrosoftDocs"
description: "Instructions to set up quick responses in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 05/29/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Create quick responses

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Quick responses are pre-defined messages that can be created for agents to quickly reply to common questions by customers. For information about the agent's quick response experience, see [Send quick responses in the chat](../agent/agent-usd/left-control-panel.md#send-quick-replies-in-the-chat).  

1. Sign in to Omnichannel Administration.
2. Go to **Agent Experience** > **Quick responses**.
3. Select **New** to add a quick reply. To edit an existing quick response, select the name of the quick response.
4. Provide or change the following information:

    - **Title:** Enter the title of the message.
    - **Locale:** Specify the language of the message.
    
        > [!NOTE]
        > Omnichannel for Customer Service does not localize quick responses. To provide quick responses in multiple languages, create a separate quick response record for each language and select its corresponding locale.

    - **Message:** Enter the text of the message.

      > [!div class=mx-imgBorder]
      > ![Create a quick reply](../media/oc-create-a-quick-reply.png "Create a quick reply")

     The **Message** field supports the following slugs.  

    | Slug | Description | 
    |-----------------|-----------------------------|
    | {FullName{Customer}}  | The full name of the customer who initiated the conversation. |
    | {LastName{Customer}}| The last name of the customer.|
    | {NickName{Customer}}| The nickname for the customer.|
    | {FullName{Agent}}| The full name of the agent who is assigned to the conversation.|
    | {FirstName{Agent}}| The first name of the agent.|
    | {LastName{Agent}}| The last name of the agent.|
    | {Nickname{Agent}}| The nickname for the agent.|

      For more information, see [Slugs](automation-dictionary-keys.md#slugs).

5. Select **Save**.

## Create or edit tags for common categories of quick responses

Quick replies can be classified and tagged into categories. The categorization capability can also be leveraged to group quick replies into logical chunks that represent key conversational states for agents. These logical chunks help agents select appropriate messages that correspond to customer issues.

1. Sign in to Omnichannel Administration.

2. Go to **Agent Experience** > **Quick responses**.

3. Select two or more quick replies for which you want to create a tag, and then select **Edit Tags**.

> [!div class=mx-imgBorder]
> ![Create a quick reply](../media/oc-active-quick-replies.png "Create a quick reply")

  The **Edit Tags** dialog box appears.

4. In the **Add new tag** field, start typing the tag you want to create. If it already exists, it will appear in a list below the field. If it doesn’t appear, select the plus **+** sign to add it.

> [!div class=mx-imgBorder]
> ![Add a tag](../media/oc-quick-reply-add-tag.png "Add a tag")

5. When finished, select **Close**.

## Associate quick responses to a work stream

For organizations with diverse lines of businesses, agents will send a variety of messages depending on their area of expertise. Administrators can determine which quick replies are necessary for different groups of agents to use. Administrators can associate quick replies with work streams in order show agents only the quick replies that apply to them. If no work stream is associated, the quick reply is available for all agents. 

1. Sign in to Omnichannel Administration.

2. Go to **Agent Experience** > **Quick responses**.

3. Select a quick reply from the list.

4. In the **Workstreams** section, click the ellipsis.

5. Select **Add Existing Work Stream**.

6. Select the work stream from the list of records and then click **Add**.

   The work stream appears in the list.

7. Click **Save** to save your quick reply.

   If you click the work stream in the list, you can view the work stream record and click the **Quick Replies** tab to view all the quick replies associated with that work stream.

### See also

[Add a chat widget](add-chat-widget.md)  
[Configure a pre-chat survey](configure-pre-chat-survey.md)  
[Create and manage operating hours](create-operating-hours.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)  