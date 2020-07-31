---
title: "Add a chat widget | MicrosoftDocs"
description: "Instructions to add a chat widget in Omnichannel for Customer Service."
ms.date: 04/29/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Add a chat widget

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

1. Sign in to Omnichannel Administration.

2. Go to **Channels** > **Chat**.

3. Select **New**. The **New Chat Widget** page is displayed.

4. On the **Basic details** tab, specify the information in the fields of the different sections as outlined in the following table.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | **General information** | Name | Specify the name of the widget. | Contoso chat |
    |  | **Language**| Select the language of the chat widget from the list. | English - United States |
    |  | **Agent display name** | Select an agent display name type from the list: **Full name**, **First name**, **Last name**, and **Nick name**. <br> More information: [Configure agent display name](agent-display-name.md) | Full name |
    |  | **Authentication settings** |Select an authentication setting from the list. This is an optional field. More information: [Create chat authentication settings](create-chat-auth-settings.md) | Chat authentication |

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | **Work distribution** | **Work stream** | Select a work stream from the list. Initially, a default a work stream is selected. <br>More information: [Understand and create work streams](work-streams-introduction.md) <br> **Note:** <br> If you save the chat widget, you can't edit the **Work stream** field. If you want to edit the field, you must delete the chat widget and create a new one. | Live work stream |
    
    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|    
    | **Proactive chat** | **Enable Proactive Chat** | Select whether to enable proactive chat. <br>More information: [Configure proactive chat](proactive-chat.md) | Yes |

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|    
    |**File attachments** | **Enable file attachments for customers** |Select whether to allow customers to attach and send files as attachments. <br> More information: [Configure file attachment capability](configure-file-attachment.md) | Yes |
    | | **Enable file attachments for agents** | Select whether to allow agents to attach and send files as attachments. <br> More information: [Configure file attachment capability](configure-file-attachment.md) | Yes |
    
    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|        
    | **Chat Transcripts** | **Allow download of transcript** | Select whether to allow chat transcripts to be downloaded. <br> More information: [Configure download and email of chat transcripts](download-email-chat-transcripts.md) | Yes |
    | | **Allow email of transcript** |Select whether to allow chat transcripts to be emailed. <br> More information: [Configure download and email of chat transcripts](download-email-chat-transcripts.md) | Yes |
    | | **Email Template** |If you selected **Yes** for the **Allow email of transcript** field, the **Email Template** field is displayed. Select the email template you want to use to send the chat transcript as an email to the customer. | Conversation transcript email template |
    | | **From mailbox ** | If you selected **Yes** for the **Allow email of transcript** field, the **"From" mailbox** field is displayed. Select the mailbox from which you want to send the chat transcript email to the customer. | Contoso |

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|            
    |**Customer waiting** | **Show position in queue** | Select whether to show customers their position in the queue when they're waiting to interact with an agent. <br> More information: [Show customers their position in a queue](show-queue.md) | Yes |
    | | **Show average wait time**| Select whether to show customers average wait time in the queue when they're waiting to interact with an agent. <br> More information: [Show customers their average wait time in a queue](average-wait-time.md) | Yes |

5. Select **Save**. The following sections are displayed:
    - **Code snippet:** The code snippet that you need to embed in the HTML source of your website to display the chat widget is displayed in the **Widget snippet** box.
    - **Chat Reconnect:** The toggle to configure options for providing a reconnect link to the chat user is displayed. More information: [Configure reconnection to a previous chat session](configure-reconnect-chat.md)


    > [!div class=mx-imgBorder]
    > ![Configure the basic details of a chat widget](../media/oc-chat-widget-basic-details-tab.png "Configure the basic details of a chat widget")


6. On the **Design** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Online | Theme color | Select a color from the list for the chat widget. | Blue |
    | Online | Logo | Logo for the chat widget. | https://oc-cdn-ocprod.azureedge.net/livechatwidget/images/chat.svg |
    | Online | Title | Specify the name for the widget that's displayed for customers in the chat widget. | Let's Chat! |        
    | Online | Subtitle | Specify the name for the widget that's displayed for customers in the chat widget. | We're Online |
    | Online | Position | Specify the position of the widget. | Bottom right |
    | Online | Operating hours | Select an operating hour window for the chat widget from the list. <br> More information: [Create and manage operating hours](create-operating-hours.md) | Regular shift |

    > [!div class=mx-imgBorder]
    > ![Configure the design of a chat widget](../media/oc-chat-widget-design-tab.png "Configure the design of a chat widget")

7. On the **Pre-chat survey** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Pre-chat survey | Pre-chat survey | Select whether to set up a pre-chat survey in the chat widget. The survey will be shown to users before a conversation is initiated. | Yes |
    | Pre-chat unauthenticated questions | Pre-chat unauthenticated questions | If you selected **Yes** for the **Pre-chat survey** field, the **Pre-chat unauthenticated questions** section is displayed. <br> Add the pre-chat questionnaires <br> More information: [Configure a pre-chat survey](configure-pre-chat-survey.md) | Product |

    > [!div class=mx-imgBorder]
    > ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

8. On the **Location** tab, in the **Widget location** section, select **Add** to specify the website domain where the chat widget must be shown. The domain format should not include the protocol (for example, **http** or **https**).

9.  In the **Visitor location** section, specify whether you need to detect the visitor's location, and then select a **Geo Location Provider**. More information: [Set up location detection](geo-location-provider.md)

    > [!NOTE]
    > If no domains are specified, the chat widget can be embedded on any website without restrictions. If you specify a domain, the chat widget can be hosted only on the specified domain.

    > [!div class=mx-imgBorder]
    > ![Configure widget and visitor location in a chat widget](../media/chat-widget-location-tab.png "Configure widget and visitor location in a chat widget")

10. On the **Conversation options** tab, specify the information for the following fields. 

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    |Voice and video calls | Call options | Select a call option from the list: <ul>**No calling**: <br>Agents can't make voice or video calls. </ul><br> <ul>**Video and voice calling**:<br> Agents can make both voice and video calls. </ul><br><ul>**Voice only**:<br> Agents can make only voice calls.  </ul>| Video and voice calling |
    | Visual engagement | Screen sharing | Select whether to enable third-party screen sharing. You must install a third-party provider from AppSource to use the feature. | Enabled |
    | Visual engagement | Screen sharing provider | Select the provider from the list.| *Screen sharing provider* |
    | Visual engagement | Co-browse | Select whether to enable third-party co-browse. You must install a third-party provider from AppSource to use the feature. | Enabled |
    | Visual engagement | Co-browse provider | Select the provider from the list. | *Co-browse provider* |
    
   > [!div class=mx-imgBorder]
   > ![Enable third-party co-browse and screen sharing through conversation options in a chat widget](../media/chat-widget-conversation-options.png "Enable third-party co-browse and screen sharing through conversation options in a chat widget")
        
   > [!NOTE]
   > You can select one co-browse provider and/or one screen sharing provider for each chat widget. Only co-browse and screen sharing providers that have published a solution on AppSource will appear in the drop-down lists. 

12. On the **Custom messages** tab, view and add custom system messages that will appear in the chat widget. To learn more, see [Set up custom messages](chat-custom-messages.md).

   > [!div class=mx-imgBorder]
   > ![Custom messages in a chat widget](../media/oc-chat-widget-custom-messages-tab.png "View and add custom messages in a chat widget")

11. On the **Related** tab, view activity associated with your chat widget, such as survey responses, chat widget locations, and system messages. 

   > [!div class=mx-imgBorder]
   > ![Related chat widget activity](../media/oc-chat-widget-related-tab.png "Related chat widget activity")

12. Select **Save** to save the configurations.

After you configure, agents can get the capabilities while they are in a conversation. To learn more, see [Call options and visual engagement in live chat](../agent/agent-oc/call-options-visual-engagement.md).

### See also

[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure proactive chat](proactive-chat.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md) 
