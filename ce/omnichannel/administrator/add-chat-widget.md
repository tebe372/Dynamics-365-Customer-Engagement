---
title: "Add a chat widget | MicrosoftDocs"
description: "Instructions to add a chat widget in Omnichannel for Customer Service."
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.date: 08/29/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Add a chat widget

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

1. Sign in to Omnichannel Administration.
2. Go to **Channels** &gt; **Chat**.
3. Select **New** to create a chat widget.
4. On the **New Chat Widget** page, provide the appropriate information on each tab:

    - **Basic details**:

        1. In the **General information** section, enter a name for the chat widget and select the agent name to be displayed. More information on agent display name: [Configure agent display name](agent-display-name.md).
        
            You can optionally specify authentication settings. For more information about how to specify authentication settings, see [Create chat authentication settings](create-chat-auth-settings.md). You must save the record to enter more details.

        2. In the **Work Distribution** section, browse and select the work stream you created for the chat widget. By default, **Live chat workstream** is selected. More information on work stream: [Understand and create work streams](work-streams-introduction.md)
        
        > [!NOTE]
        > - If you save the chat widget, you can't edit the **Work stream** field. If you want to edit the field, you must delete the chat widget and create a new one. 
        >
        > - If no domains are specified, the chat widget can be embedded on any website without restrictions. If you specify a domain, the chat widget can be hosted only on the specified domain.
        
        3. Copy the value in the **Code snippet** section and embed it in the HTML source of your website.
        
        > [!div class=mx-imgBorder]
        > ![Configure the basic details of a chat widget](../media/oc-chat-widget-basic-details-tab.png "Configure the basic details of a chat widget")

    - **Design**: Use this tab to specify the theme color, logo, title, subtitle, and operating hours of the chat widget. For more information about how to set up operating hours, see [Create and manage operating hours](create-operating-hours.md).

        > [!div class=mx-imgBorder]
        > ![Configure the design of a chat widget](../media/oc-chat-widget-design-tab.png "Configure the design of a chat widget")

    - **Pre-chat survey**: Use this tab to set up a pre-chat survey. This survey is shown to users before a conversation is initiated. For more information, see [Configure a pre-chat survey](configure-pre-chat-survey.md).

        > [!div class=mx-imgBorder]
        > ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

    - **Location**:
        1. In the **Widget location** section, select **Add** to specify the website domain where the chat widget must be shown. The domain format should not include the protocol (for example, **http** or **https**).
        2. In the **Visitor location** section, specify if you need to detect the visitor's location. For more information about how to set up location detection, see [Set up location detection](geo-location-provider.md).

        > [!div class=mx-imgBorder]
        > ![Configure widget and visitor location in a chat widget](../media/chat-widget-location-tab.png "Configure widget and visitor location in a chat widget")

### See also

[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Dynamics 365 Portals](embed-chat-widget-portal.md)
