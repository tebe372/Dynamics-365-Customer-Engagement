---
title: "Download and email chat transcripts | MicrosoftDocs"
description: "Learn how to download or email chat transcripts"
author: platkat
ms.author: ktaylor
manager: autumna
ms.date: 04/16/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---

# Configure download and email of chat transcripts

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Chat for Dynamics 365 Customer Service allows customers to download and email a copy of their chat transcripts. When download and email options are enabled by an administrator, customers can download or request an email of their chat transcript at any time during a chat session. At the end of the conversation, customers can request a transcript. If the customer requests an email of the chat transcript, the email is sent at the end of the conversation.

**Prerequisite**: Administrators should set up mailboxes before enabling, and must select the **Allow other Dynamics 365 users to send email on your behalf** checkbox for this feature to work. For more information, see [Dynamics 365 Email Setup](https://support.microsoft.com/help/4020807/dynamics-365-e-mail-setup-configuration-and-dynamics-365-for-mobile-ho) and [Dynamics 365 Email tab options](../customerengagement/on-premises/basics/set-personal-options.md#email-tab-options).

## Download and email chat transcripts in Omnichannel admin center

Perform the following steps to configure the options to download and email chat transcripts for both customers and agents:

1. In Omnichannel admin center, select the workstream of the chat widget in which you need to configure the settings.
2. Select **Edit** for the chat channel that you need to update, and select the **User features** tab.
3. For **Conversation transcripts**, set the toggle to **On** and select the following check boxes:
   - Allow download of transcripts
   - Allow email of transcripts
4. Select a template in **Email template**.
5. Select a mailbox in **From mailbox**.
6. Select **Save and close**.

## Download and email chat transcripts in Omnichannel Administration

1. Sign in to Omnichannel Administration.

2. Go to **Channels** > **Chat**.

3. Open the chat widget in which you need to configure download and email of chat transcripts.

4. Go to the **General settings** tab.

5. Under **Chat Transcripts**, select **Yes** or **No** for the following:

   - **Allow download of transcript**: Allows your customers to download the chat transcript.

   - **Allow email of transcript**: Allows your customers to send the chat transcript as an email.

   By default, both the options are set to **No**.

6. If you select **Yes** for **Allow email of transcript**, you must select an email template and a mailbox from which the email will be sent. Administrators have a choice to either:

    - Use an email template provided by Chat for Dynamics 365 Customer Service by selecting an option from the **"From" mailbox** drop-down list.

    - Modify the email template provided by Chat for Dynamics 365 Customer Service.
    
    - Create their own email template.

    > [!NOTE] 
    > Whether an administrator chooses to use the email template provided or create their own, the "{conversation.transcript}" text determines where the transcript is injected into email.

    > [!div class=mx-imgBorder]
    > ![Customize email chat transcript](media/oc-chat-transcript-customize-email-transcript.png "Customize email chat transcript")

## Customer experience

Customers can choose to download and email a copy of their chat transcript conversation from the chat window: 

- **Download the chat transcript**: Select the download icon at the bottom of the chat screen. 

    > [!div class=mx-imgBorder]
    > ![Download chat transcript](media/oc-chat-transcript-download.png "Download chat transcript")

- **Email the chat transcript**: Select the email icon at the bottom of the chat screen.

    1. Enter email address in pop-up window.
        
    2. Select **Send** to receive a copy of the chat transcript once the conversation ends.
    
    
       

     > [!div class=mx-imgBorder]
     > ![Email chat transcript](media/oc-chat-transcript-email.png "Email chat transcript")

    At the end of the chat conversation, the following window appears reminding the customer they can either download or email a copy of their chat transcript to themselves.

    > [!div class=mx-imgBorder]
    > ![Chat transcript prompt](media/oc-chat-transcript-prompt-screen.png "Chat transcript prompt")


### See also

[Add a chat widget](add-chat-widget.md)<br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]