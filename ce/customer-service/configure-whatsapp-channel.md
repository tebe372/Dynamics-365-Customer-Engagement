---
title: "Configure a WhatsApp channel through Twilio | MicrosoftDocs"
description: "Learn about the WhatsApp channel through Twilio and how to configure the channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/29/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Configure a WhatsApp channel through Twilio

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview of WhatsApp channel through Twilio

Many customers use social messaging channels like WhatsApp for their personal communication needs and prefer to use the WhatsApp channel to engage with businesses also.

The success of social media customer service, like all other customer service, depends on the quality of care provided. Communications from agents should be timely, accurate, sensitive, brief, and friendly, which ultimately improves the customer satisfaction and brand loyalty.

The WhatsApp channel feature lets you integrate WhatsApp through Twilio with Omnichannel for Customer Service to engage with customers who prefer the WhatsApp channel.

## Prerequisites

- Make sure channels are provisioned in your environment. For information, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md).
  > [!NOTE]
  >
  > To enable the Twilio channel in an existing Omnichannel environment, you must upgrade to the latest version of Omnichannel for Customer Service. For information, [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md).

- Obtain a Twilio account with an appropriate subscription or a Twilio sandbox account. For information on configuring a Twilio sandbox account, see [Integrate a Twilio sandbox account with Omnichannel for Customer Service](#integrate-a-twilio-sandbox-account-with-omnichannel-for-customer-service)

- Connect Twilio Number to your WhatsApp Business Profile. To learn more, see [Connect your Twilio Number to your WhatsApp Business Profile](https://www.twilio.com/docs/sms/whatsapp/tutorial/connect-number-business-profile).

## WhatsApp message types and 24 hours session rule

- **Template messages:** These are the outbound messages that agents send through Twilio using one of the pre-approved templates. They are typically transactional messages, such as delivery alerts and appointment reminders, sent to users who have opted in to receive messages from your organization. For messages requiring localization, you must get the message approved by WhatsApp in each language. For more information about WhatsApp message templates, see [WhatsApp documentation](https://developers.facebook.com/docs/whatsapp/message-templates/).

- **Session messages:** According to WhatsApp, session messages are incoming messages from a customer or outgoing replies by an agent to the incoming messages, within 24 hours. A messaging session starts when agents receive a message from a customer. It lasts for 24 hours from the most recently received message. Session messages do not need to follow a template, and can include media attachments.

- **24 hours session rule:** A messaging session starts when an agent receives a message from a customer or replies to the incoming message from the customer. When the customer sends a message, the agent has 24 hours to reply from the time the agent received it. However, after 24 hours, the agent can send a message to customer only by using a predefined and approved template.

## End-to-end walk-through

[Step 1: Fetch Twilio account details](#fetch-twilio-account-details)

[Step 2: Create a WhatsApp channel](#create-a-whatsapp-channel)

[Step 3: Create routing rules](#create-routing-rules)

[Step 4: Modify settings for a specific WhatsApp phone number](#modify-settings-for-a-specific-whatsapp-phone-number)

## Fetch Twilio account details

To integrate a WhatsApp channel through Twilio with Omnichannel for Customer Service, you need to go to your Twilio account and fetch the **ACCOUNT SID** and **AUTH TOKEN** values. Save those safely. These two values are required to create a WhatsApp channel configuration in the Omnichannel Administration app.

Go to your **Twilio Console Dashboard** > **Settings** > **General** to fetch the details.

## Create a WhatsApp channel

After you create a work stream for the WhatsApp channel through Twilio, create a WhatsApp channel in the Omnichannel Administrator app.

To create a WhatsApp channel, follow these steps:

1. Sign in to the Omnichannel Administration app. Select **WhatsApp** under **Channels**.

2. In the **New WhatsApp** page, do the following.

    | Section | Field | Description | Example  value |
    |-------------|-------------------|---------------------------|--------------------------------------|
    | Twilio account details |Name| Specify a name for the WhatsApp channel.| WhatsApp channel |
    | Twilio account details |Account SID | Fetch the value from your Twilio account and paste it here. | AC9a805fb460119c9baabb9b726ce8fc90 |
    | Twilio account details |Auth Token | Get the value from your Twilio account and paste it here. | dd40ed7df8376b1fa959be99c45fbfce |

    > [!div class=mx-imgBorder]
    > ![Create a WhatsApp channel](media/whatsapp-channel-1.png "Create a WhatsApp channel")

3. Select **Save**. In the **Callback information** section, the **Twilio inbound URL** field is generated with a link. Copy the link from the field.

   > [!div class=mx-imgBorder]
   > ![Copy the Twilio inbound URL](media/whatsapp-channel-2.png "Copy the Twilio inbound URL")

4. Go to your Twilio console, select **Senders** and then select the WhatsApp phone number. Under **Messaging**, paste the link that you copied in step 4 in the **Twilio inbound URL** field.

5. In the **WhatsApp phone numbers** section, select **New WhatsApp Number**. The **New WhatsApp Number** page is displayed.

6. Do the following.

    | Section | Field | Description | Example  value |
    |-------------|-------------------|---------------------------|--------------------------------------|  
    | Phone number details | Name | Specify a name for the WhatsApp channel. | WhatsApp phone number |
    | Phone number details | WhatsApp Account | The **WhatsApp Account** field is populated by default. However, you can change the value using the lookup. | WhatsApp channel |
    | Phone number details | WhatsApp Number | Specify the WhatsApp number. | 123456989 |
    | Work distribution | Work stream | Select the out-of-the-box work stream from the lookup. <br> To create a new work stream, see [Create work streams](work-streams-introduction.md). | WhatsApp channel work stream |

    > [!div class=mx-imgBorder]
    > ![Create a WhatsApp channel phone number](media/whatsapp-channel-3.png "Create a WhatsApp channel phone number")

7. Select **Save**. The WhatsApp phone number is saved.

8. Select the back button on the browser to go to the WhatsApp channel page. You can see that the WhatsApp phone number is added in the **WhatsApp phone numbers** section.

9. Select **Save**.

10. In the **Validation** section, select **Validate** to validate the Account SID, Auth token, and phone numbers.  After you validate, a toast notification displays with the success or error.

    > [!div class=mx-imgBorder]
    > ![Validate Account SID, Auth token, and phone number](media/whatsapp-channel-5.png "Validate Account SID, Auth token, and phone number")

### Integrate a Twilio sandbox account with Omnichannel for Customer Service

1. In Twilio, go to the **Programmable SMS** > **Programmable Messaging** > **WhatsApp sandbox**.
2. In the **WHEN A MESSAGE COMES IN** box, enter the Twilio inbound URL that you generated in Omnichannel for Customer Service, and save the changes.
3. To test the WhatsApp channel with the Twilio sandbox, you can send a WhatsApp message to the number provided by Twilio with a unique code that is also provided by Twilio. You can also use the sandbox message template provided by Twilio to test sending messages outside of the 24-hour window.

## Create routing rules

1.	Go to **Work Distribution Management** > **Work Streams**.
2.	Open the out-of-the-box work stream or the one you created.
3.	On the **Routing rules items** tab, you can create a routing rule to transfer the message to an appropriate agent. Select the entity as **WhatsApp Engagement Context**. For example, you can create a rule to transfer WhatsApp chat from a customer to the default queue.

When you create conditions for routing rules, the **WhatsApp Engagement Context (Conversation)** entity enables you to set the **Customer Phone Number** and **Customer First Message** attributes. The **Customer First Message** attribute lets you create a pre-filled message that will automatically appear in the text field of a customer chat, which can be used for routing.

## Modify settings for a specific WhatsApp phone number 

1. In the Omnichannel Administration app, go to your WhatsApp application and select the WhatsApp phone number you want to modify. 

2. On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your WhatsApp phone number.
    
    - **Work stream**: Select an existing work stream or create a new one.

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**. 

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app sends the blob storage URL to the channel. Otherwise, set **No**. 
    
       To learn more about attachments, see [File attachments](enable-file-attachments.md). 
       
       To learn more about uploading media in WhatsApp, see [Twilio support documentation](https://support.twilio.com/hc/en-us/articles/360017961894-Sending-and-Receiving-Media-with-WhatsApp-Messaging-on-Twilio-Beta-).
    
3. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md). 

4. On the **Message templates** tab, you can configure agents' ability to send WhatsApp-approved messages. If 24 hours pass after a customer's last message, agents will only be able to send messages from WhatsApp approved templates until the customer responds.

    > [!NOTE]
    >
    > Create your message templates in your Twilio account and have them approved by WhatsApp before you add them in Omnichannel for Customer Service.

    Click **New** to create a new template and complete the following fields:

    - **Name**: Label the group of messages that will go in this template.
    
    - **Message trigger**: Select the event that will trigger the message to be sent.
    
    - **Message description**: Give the message template a description.
    
    > [!div class=mx-imgBorder]
    > ![Create WhatsApp message template](media/whatsapp-message-template-new-message.png "Create WhatsApp message template")
    
    Click **Save** and the **Localization Data (Message template)** panel appears. Select **New localization** and complete the following fields:
    
    - **Language code**: Select the language for the message.
    
    - **Localized text**: Write the message in the language specified. You must create a new localization for each translation of the message.
    
    > [!div class=mx-imgBorder]
    > ![Create WhatsApp message template localized message](media/whatsapp-message-template-new-message-locale.png "Create WhatsApp message template localized message")
    
5. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Create and manage routing rules](routing-rules.md)<br>
[Configure automated messages](configure-automated-message.md)<br> 
[Configure a post-conversation survey](configure-post-conversation-survey.md)<br>
[Skill-based routing](overview-skill-work-distribution.md)<br>
[Create message templates](create-message-templates.md)<br>
[Templates](templates-overview.md)<br>
[Delete a configured channel](delete-channel.md)
