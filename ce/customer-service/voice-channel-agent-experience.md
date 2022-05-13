---
title: "Use agent dashboard and call controls in the voice channel | MicrosoftDocs"
description: "Use this article to understand how the agent can use the agent dashboard, use call controls, and also make and receive customer calls in Omnichannel for Customer Service."
ms.date: 04/05/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---

# Use agent dashboard and call controls in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The voice channel in Omnichannel for Customer Service is integrated directly with Dynamics 365 by way of the agent dashboard. The dashboard offers you as an agent a consolidated view of the calling interface, the customer summary, case history, and timeline. This helps you provide quick, effective, and proactive solutions to customer issues. The agent experience in the voice channel is similar to the chat and other channels, which reduces agent training time and costs.

## Make and receive customer calls

You can call a customer by using the phone dialer on the customer summary page or the **Launch dialer** button on the menu. More information: [Call a customer](voice-channel-call-customer.md)

When a customer calls your business, the incoming call is received by an intelligent bot. The bot gathers basic information about the customer issue and then transfers the call to you for further action. You'll receive a notification about the incoming call on your agent desktop so you can accept it. The following section describes the call controls and other features you can use during your conversation.

## Call controls

The conversation panel in the agent dashboard includes the following call controls that you can use when you call or answer phone calls from customers.

> [!div class="mx-imgBorder"]
> ![Screenshot of call controls.](./media/voice-channel-call-controls.png)

- **Mute**: Mute your microphone so your voice isn't audible to the customer.
- **Hold**: Put the customer on hold; the customer will hear the hold music.
- **Consult**: Consult with or bring another agent or supervisor into the call. You can have a *public* consultation, where the customer is actively involved in the conversation. Or you can have a *private* consultation, where you can put the customer on hold before you talk to your peers or supervisor.
- **Transfer**: View the options and transfer the call to:
    - An agent or queue. During a transfer the following to the queue, the customer is automatically put on hold. When you tranfer a call to another agent, your number is displayed on the called id. The transcription and recording of transferred calls will continue if the administrator has enabled the [option](voice-channel-configure-transcripts.md#enable-call-recordings-and-transcripts-for-voice). You can disable recording from the dashboard.
    - A Teams user
    - An external phone number
- **End**: End the call.
- **Show number pad**: Open the number pad so you can dial an extension number, when required.
- **Mark number as spam**: [Report the incoming call as spam](#report-a-phone-number-as-spam). If you happened to accidentally mark a number as spam, you can select the **Unmark as spam** option.
- **Device settings**: Configure your microphone and speaker settings.
- **Take notes**: Make note of important information or specific details from your conversation with the customer. Note that this is in addition to the call recording and transcription that happen during the conversation.
- **Pause transcription**: If you don't want to capture some details of the conversation—such as bank details, billing, or payment information—you can temporarily pause the transcription and resume it later.
- **Knowledge Articles**: Get a list of knowledge base articles pertaining to the conversation that you can use to resolve the customer issue.
- **Link to conversation**: You can link another conversation, case, or knowledge article to the conversation.
- **Transcription**: When the transcription and recording service is enabled by your administrator, all of the conversation between you and the customer is automatically transcribed in real time, which means that you as an agent don't need to take notes during the call. This feature also helps your supervisor or agent (in case of a call transfer) to see the call history.
- **Sentiment analysis**: The transcript also powers *live* sentiment analysis. This means that you or your supervisor can instantly view and gauge the customer's mood and feeling via the sentiment icons.

## Report a phone number as spam

You can report a phone number as a spam call while you're on the call by using the call controls on the conversation panel. A notification is then sent to your administrator for review and further action.

To report a phone number as spam, select the ellipsis to open more actions, and then select **Mark number as spam**.

You can add notes to help your administrator review and block numbers. After you mark a number as spam, it goes into the pending review tab on the **Blocked numbers** page.

## Consult with Microsoft Teams users

If your administrator has enabled the option for you to consult with subject matter experts (SMEs) through Microsoft Teams, you can contact them by navigating to the **Teams** tab in the **Consult** section of the communication panel. Your supervisor can monitor the calls and after the call ends, the call recording and transcript of the conversation with the Teams user is saved in Dynamics 365 for reporting and compliance.

Do the following steps to consult while you're on a call:

1. Select the **Consult** option, and go to the **Teams** tab in the **Consult** section that appears.

2. Use the search option to search for an SME. The results are filtered by the name and live presence in Microsoft Teams.

3. Select **Add** for the SME you want to consult. The SME will receive a call in Teams.

4. Optionally, you can transfer the call to the SME.

## Use chat consult with other agents and transfer calls

You can use the chat **Consult** option to contact another agent and consult with them on questions that you might have when you're on a call with a customer.

**To use chat consult and transfer the call**

1. In the call window, select the **Consult** option. The **Consult** dialog appears.


  > :::image type="content" source="media/voice-consult.png" alt-text="Voice consult dialog for consulting with other agents.":::

1. Search for the agent who you want to chat with and select **Add to chat** for the required agent. A consult notification appears for the secondary agent that you select.

1. When the secondary accepts the consult request, a consult pane appears for you and the secondary agent. You can exchange messages in this consult pane. More information: [Consult experience](oc-conversation-control.md#consult-with-agent-or-supervisor)

1. If you want to transfer the call to the secondary agent, select the **Transfer** option in the call window. A notification goes to the secondary agent and the call is transferred after the agent accepts the transfer request. The secondary agent becomes the primary agent, and you'll be disconnected from the call and consult pane with no option to send any further messages.

### See also

[Overview of the voice channel](voice-channel.md)  
[Enable voice consult with Microsoft Teams users](voice-consult-microsoft-teams-user.md)  
[Make and receive your first call](voice-channel-first-call.md)  
[Call a customer](voice-channel-call-customer.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
