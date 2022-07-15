---
title: "Support for live chat and asynchronous channels | MicrosoftDocs"
description: "Get information on the support for adaptive cards, emojis, file attachments, and message formatting in live chat and asynchronous channels in Omnichannel for Customer Service."
ms.date: 06/17/2022
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi

ms.reviewer: nenellim
---

# Support for live chat and asynchronous channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Support for adaptive cards

The following table lists the rich cards that are supported across different channels when you're using bots. The support categories are intentionally broad because many possible combinations of cards, features, and channels are applicable. We recommend that you use the information in the table as a base reference, and test each of your cards in the required channels.

| Channel | Hero card | Thumbnail card | Sign in card |Audio card | CardCarousel |
|---------------|-----------|----------------|-------------|------------|----|
| Microsoft Teams  | ✔     |  ✔   | ✔  | ✖  | ✔  |
| Facebook | ✔  |  ✔  | ✔ | 🌐  |  ✔| 
| LINE    | ✔ | ✔   | ✔ | 🌐  | ✔|
| Custom (Telegram)  | ✔ | ✔ | ✔ | 🌐 | ✔ |
| Custom (Direct Line) | ✔ |  ✔ | ✔ | ✔*  | ✔* |


✔: Supported; card is supported fully with the exception that some channels support a subset of the card actions. The number of actions allowed on each card might be limited that varies by channel.

⚠: Partial support; varies by channel; card might not be displayed at all if it contains inputs or buttons. 

✔* : Card elements are supported in the Webchat version of Custom (Direct Line), but not in the Android version.

✖: No support.

🔶: Card is converted to an image.

🌐: Card is converted to unformatted text, links might not be active, images might not be displayed, or media might not work. The behavior might vary by channel.

The markdown element for adaptive cards is partially supported across all chat channels. For example, the markdown element isn't supported in live chat, whereas, it's supported in LINE.

Media or audio card and date input elements for adaptive cards are only supported in Live chat channels. Adaptive card elements like text block and images are also supported across channels.

Other social channels, such as Twitter, SMS, WhatsApp, and WeChat don't support any cards listed in the preceding table.

For more information, see the following:

  - [Sending and Receiving Media with WhatsApp Messaging on Twilio](https://support.twilio.com/hc/articles/360017961894-Sending-and-Receiving-Media-with-WhatsApp-Messaging-on-Twilio-Beta-)
  - [Upload media, Twitter developer documentation](https://developer.twitter.com/docs/media/upload-media/uploading-media/media-best-practices)

## Support for suggested actions

Suggested actions are supported fully with the exception that some channels might limit the number of actions allowed. Also, the number of actions supported varies by channel.

| Channel                        | Supported?                      |
|--------------------            |---------------------------------|
| Microsoft Teams                | No                              |
| Facebook                       | Yes                             |
| LINE                           | Yes                             |
| Twitter                        | No                              |
| WeChat                         | No                              |
| WhatsApp                       | No                              |
| SMS                            | No                              |
| Custom messaging (Telegram)    | Yes                             |
| Custom messaging (Direct Line) | Yes                             |

## Support for file attachments

You can enable file attachments on the **General settings** tab of a channel so that customers and agents can send files as attachments. Inbound attachments refer to attachments that customers send to agents, and outbound attachments refer to attachments that agents send to customers. For more information about file attachments, see [Enable file attachments](enable-file-attachments.md).

| Channel              | Inbound attachments                        | Outbound attachments                  | 
|----------------------|--------------------------------------------|---------------------------------------|
| Microsoft Teams      | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx  | 
| Facebook             | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx, .xls |
| LINE                 | Image, Audio, Video, and GIF                   | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif | 
| Twitter              | Image, Video, GIF, and Emoji                   | Image, Video, and GIF  <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp4, .gif |
| WeChat               | Image, Audio, and Video                        | Image, Audio, and Video <br><br> Allowed file extensions: .jpg, .jpeg, .png, .amr, .mp4 |
| WhatsApp             | Image, Audio, Video, GIF, and PDF               | Image, Audio, Video, and PDF  <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf |
| SMS (Twilio)         | Image, Video, GIF, and Emoji                   | Image, Audio, Video, and GIF   <br><br> Allowed file extensions: .jpg, .jpeg, .gif, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .csv |
| Custom messaging (Telegram)    | Image, Audio, Video, Document, GIF, and Emoji | Image, Audio, Video, Document, and GIF <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif |
| Custom messaging (Direct Line) | All types except blocked types in org      | All types except blocked types in org <br><br> Allowed file extensions: .jpg, .jpeg, .png, .mp3, .oga, .ogg, .amr, .mp4, .pdf, .docx, .txt, .gif, .xlsx |

> [!Note]
>
> - For Microsoft Teams, when a customer sends an emoji from the Teams client, the agent receives a PNG image. When an agent sends a GIF image (outbound), the customer will receive a PNG image.
> - The Direct Line channel supports the above attachment types, but it's up to the client to implement them.
> - For LINE inbound and outbound messages, when a GIF image is sent, the recipient will receive a JPG image.
> - For WhatsApp messages, when a customer sends an attachment in document format (for example, a DOCX, XLSX, or TXT file), the agent will receive the attachment name as message text. We recommend converting documents to PDF format before sending them as attachments.

## Support for emojis

| Channel            | Emoji behavior                                                      |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Yes. Emoji in PNG format                                            |
| Facebook           | Yes. Emoji in text like “😀”                                       |
| LINE               | Yes. When an emoji is sent, the recipient sees a sticker.           |
| Twitter            | Yes. Emoji in text like “😀”                                       |
| WeChat             | Yes. When an emoji is sent, the recipient sees characters like :-) |
| WhatsApp           | Not supported.                                                      |
| SMS (Twilio)       | Yes. Emoji in text like “😀”                                       |
| Custom messaging (Telegram) | Yes. Emoji in text like “😀”                              |
| Custom messaging (Direct Line) | Yes. Emoji in text like “😀”                           |

> [!Note]
> The Direct Line channel supports emojis, but it's up to the client to implement them.

## Support for stickers

| Channel            | Sticker behavior                                                    |
|--------------------|---------------------------------------------------------------------|
| Microsoft Teams    | Not supported.                                                      |
| Facebook           | Yes, as a PNG image.                                                 |
| LINE               | Not supported. Recipient sees "Sticker" text.                       |
| Twitter            | Not supported.                                                      |
| WeChat             | Not supported. Recipient sees "Unsupported message" text.           |
| WhatsApp           | Not supported.                                                      |
| Custom messaging (Telegram) | Not supported.                                             |
| Custom messaging (Direct Line) | Yes, as sticker image.                                  |

> [!Note]
> The Direct Line channel supports stickers, but it's up to the client to implement them.

## Support for social profiles

Omnichannel for Customer Service creates a social profile for incoming requests from asynchronous channels. When a social profile is created for a conversation within a channel, later conversations will be linked to the same social profile for this channel.

With social profiles, you can do the following:

- [Automatically identify customers](record-identification-rule.md) on social channels
- Display the customer name or phone number with conversations on the agent dashboard
- Send outbound messages

| Channel            | Supported?                                                          | Visitor name|
|--------------------|---------------------------------------------------------------------|-------------|
| Facebook           | Yes                                                                 | User name |
| LINE               | Yes                                                                 | Display name |
| Twitter            | Yes                                                                 | Twitter handle name |
| WeChat             | Yes                                                                 | Visitor |
| WhatsApp           | Yes                                                                 | Phone number |
| Custom messaging (Telegram) | Yes                                                        | User name |
| | | |

## Preview: Support for formatted messages <a name="formatted-messages"></a>

> [!IMPORTANT]
> This section is pre-release documentation and is subject to change.

Agents can use basic formatting capabilities in their outbound messages across both asynchronous and live chat channels. However, for your agents to send and receive formatted messages, you must [enable formatted messages](enable-formatted-messages.md).

The following table lists the text styles supported by Microsoft Teams, Facebook, WhatsApp, Telegram, and Direct Line-based channels.

| Style                | Live chat  | Microsoft Teams | Facebook | WhatsApp | Custom messaging (Telegram)| Custom messaging (Direct Line) |
|----------------------| ---------- | -------------   | -------- | ---------|------------------          |------------------------------  |
| bold                 | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| italics              | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| strikethrough        | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| blockquote           | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |
| monospace            | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| hyperlink with text  | ✔          | ✔              | ✖        | ✖       | ✔                          | ✔                             |
| hyperlink            | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| new line             | ✔          | ✔              | ✔        | ✔       | ✔                          | ✔                             |
| headers              | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |
| numbered list        | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |
| unordered list       | ✔          | ✔              | ✖        | ✖       | ✖                          | ✔                             |

> [!Note]
> - Twitter, WeChat, and SMS channels don't support formatted messages.
> - A few text styles such as blockquote, headers, numbered lists, and unordered lists, are currently not supported across some channels.

## Preconfigured asynchronous automated message triggers

|**Channel** | **Recipients** | **Message trigger** | **Definition** | **When to trigger** |  
|-----------------|-----------------|----------------|------------|-----------------|
|Apple Messages for Business |Agent | Message or attachment failed to send. Providing error details including error code, reason for failure, message id, timestamp, and transaction id | Message displayed to agent when  agent's message or attachment  failed to send | When agent's message or attachment  failed to send |
|Apple Messages for Business |Agent| Customer's file couldn't be attached because it's too big| Message displayed to agent when customer sent an attachment which exceeds the allowed limit   | When customer sent an attachment which exceeds the allowed limit  |
|Apple Messages for Business |Agent| Message couldn't be delivered: Unsupported message type| Message displayed to agent When customer sent an unsupported message type.| When customer sent an unsupported message type. |
|Apple Messages for Business  | Customer| Customer's file couldn't be attached because it's too big |  |  |
|Apple Messages for Business |Customer |Message couldn't be delivered: Unsupported message type |  |   |
|Apple Messages for Business |Customer| Greeting Message for Async Channels |   |  |
|Custom| Agent| Message or attachment failed to send. Providing error details including error code, reason for failure, message id, timestamp, and transaction id| Message displayed to agent when  agent's message or attachment  failed to send | When agent's message or attachment  failed to send |
|Custom |Agent | Customer disconnected| |   |
|Custom| Agent | Customer ended conversation| | |
|Custom |Agent | Customer's file couldn't be attached because it's too big | Message displayed to agent when customer sent an attachment which exceeds the allowed limit  | When customer sent an attachment which exceeds the allowed limit |
|Custom |Agent | Message couldn't be delivered: Unsupported message type| Message displayed to agent when customer sent an unsupported message type. | When customer sent an unsupported message type.|

### See also

[Overview of channels](channels.md)  
[Bring your own custom messaging channel: Direct Line](bring-your-own-channel.md)  
[Configure custom messaging channel](configure-custom-channel.md)  
[Enable file attachments](enable-file-attachments.md)  
[Enable formatted messages](enable-formatted-messages.md)  
[Markdown formats: Direct Line](markdown-formats-dev.md)  
[Use Markdown to format messages](markdown-formats-agents.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
