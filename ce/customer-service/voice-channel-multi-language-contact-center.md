---
title: "Set up a multilingual contact center in the voice channel | MicrosoftDocs"
description: "Learn how to set up a multilingual contact center in the voice channel for Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 04/04/2022
ms.topic: article

---

# Set up a multilingual contact center

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Agents are increasingly serving global and diverse customers who speak multiple languages, so it's important that the communication tools they use be able to work across languages.

You can configure a phone number in a workstream that allows the customer to choose the language in which they speak, as well as choose the language of the bot.

## Prerequisites

- Set up a phone number. More information: [Manage phone numbers](voice-channel-manage-phone-numbers.md)
  
- Create the queues you need for your business, based on the customer's language. For the **Type**, select **Voice**. More information: [Create and manage queues](queues-omnichannel.md)

- Create a workstream. For the **Type**, select **Voice**. More information: [Create and manage workstreams](create-workstreams.md)
   
## Add a phone number to the workstream and configure language settings

1. In Customer Service admin center or Omnichannel admin center, go to the voice workstreams, and then select the workstream to configure the phone number.

1. Select **Edit** next to the pencil icon, and then on the **Voice settings** page, select the number to add to the workstream, and then select **Next**.

1. On the **Language** tab, select **Add primary language**. A language page is displayed, where you set the primary language for the channel. You can add additional languages to this voice channel, and each language added will have its own settings.
   The **Primary language** is the first language the bot uses to greet the customer. This allows your organization to have one phone number that services multiple languages, rather than have multiple phone numbers, each with one language, and then ask customers to call the right number.

1. Select the type of hold and wait music you want the customer to hear. For example, for the primary language, you might always want to use a certain type of hold music, but for a secondary language, you might choose a different type of music.

1. In **Voice profile**, select a voice, voice style, speaking speed, and pitch for the bot.

1. Turn on the **Post-call survey** toggle if you want the bot to present a survey to the customer at the end of the call. If this feature is on, the call is automatically transferred to the survey bot after the agent hangs up.

1. When you've finished configuring the settings, select **Confirm**.

   > ![Language settings for the voice channel.](media/voice-language-settings.png "Language settings for the voice channel.")

## Create language-specific routing rules

Define the language-based routing rules. More information: [Configure work classification rulesets for unified routing](configure-work-classification.md)

## Create a multilingual IVR bot using Azure Bot Framework

Create the bot. More information: [Azure Bot Service](https://azure.microsoft.com/services/bot-services/)

### Sample code for multilingual IVR bot

> [!Note]
> The bot author must set the va_CustomerLocale context variable field during the IVR handoff with the locale code for the language they want to support. For information on supported locale codes, see [Supported languages and locale codes](voice-channel-region-availability.md#supported-languages-and-locale-codes).

```csharp
        // Copyright (c) Microsoft Corporation. All rights reserved.
        // Licensed under the MIT License.
        using System.Collections.Generic;
        using System.Threading;
        using System.Threading.Tasks;
        using Microsoft.Bot.Builder;
        using Microsoft.Bot.Schema;

        namespace Microsoft.BotBuilderSamples.Bots
                {
                    public class EchoBot : ActivityHandler
                    {
                        // Method executed when input from a participant is received (such as someone speaking or pressing a number on their keypad)
                        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
                        {
                            if (turnContext.Activity.Text.Contains("agent") || turnContext.Activity.Text.Contains("Agent") || turnContext.Activity.Text.Contains("0"))
                            {
                                await turnContext.SendActivityAsync("Transferring to an agent who can help you with this.");

                                Dictionary<string, object> handOffContext = new Dictionary<string, object>()
                                {
                                    { "va_AgentMessage", "Customer wants to speak with an agent." }
                                };

                                var handoffevent = EventFactory.CreateHandoffInitiation(turnContext, handOffContext);

                                await turnContext.SendActivityAsync(handoffevent);
                            } else if (turnContext.Activity.Text.Contains("2"))
                            {
                                await turnContext.SendActivityAsync(MessageFactory.Text(spanishSelected, spanishSelectedSSML), cancellationToken);

                                Dictionary<string, object> handOffContext = new Dictionary<string, object>()
                                {
                                    { "va_CustomerLocale", "es-ES" }
                                };

                                var handoffevent = EventFactory.CreateHandoffInitiation(turnContext, handOffContext);

                            } else {
                                var english = "I didn't catch that. To speak with an agent, say agent at any time or press zero.";
                                var englishSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"en-US\"><voice name=\"en-US-JennyNeural\"><prosody rate=\"0%\" pitch=\"0%\">I didn&apos;t catch that. To speak with an agent, say agent at any time or press zero.</prosody></voice></speak>";

                                var spanishGreeting = "Para Español, oprema dos."; // For Spanish press 2
                                var spanishGreetingSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"es-ES\"><voice name=\"es-MX-DaliaNeural\"><prosody rate=\"0%\" pitch=\"0%\">Para Espa\u00F1ol, oprema dos.</prosody></voice></speak>";

                                await turnContext.SendActivityAsync(MessageFactory.Text(english, englishSSML), cancellationToken);
                                await turnContext.SendActivityAsync(MessageFactory.Text(spanishGreeting, spanishGreetingSSML), cancellationToken);
                            }
                        }

                        // Method executed when a participant is added. The is the inital greeting.
                        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
                        {
                            var welcomeText = "Hello and welcome! To speak with an agent, say agent at any time or press zero.";
                            var welcomeSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"en-US\"><voice name=\"en-US-JennyNeural\"><prosody rate=\"0%\" pitch=\"0%\">Hello and welcome! To speak with an agent, say agent at any time or press zero.</prosody></voice></speak>";

                            var spanishGreeting = "Para Español, oprema dos."; // For Spanish press 2
                            var spanishGreetingSSML = "<speak xmlns=\"http://www.w3.org/2001/10/synthesis\" xmlns:mstts=\"http://www.w3.org/2001/mstts\" xmlns:emo=\"http://www.w3.org/2009/10/emotionml\" version=\"1.0\" xml:lang=\"es-ES\"><voice name=\"es-MX-DaliaNeural\"><prosody rate=\"0%\" pitch=\"0%\">Para Espa\u00F1ol, oprema dos.</prosody></voice></speak>";

                            await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeSSML), cancellationToken);
                            await turnContext.SendActivityAsync(MessageFactory.Text(spanishGreeting, spanishGreetingSSML), cancellationToken);
                        }
                    }
                }
              
```

## Add your bot to the workstream

Add the bot as an IVR bot to the workstream. More information: [Configure Azure bots for voice (Preview)](voice-channel-azure-bot-service.md)


## Supported languages and locale codes

| Language Name |	Locale Code |
| ---- | ---- |
| Arabic - Saudi Arabia	| ar-SA  |
| Basque - Spain | 	eu-ES  |
| Bulgarian - Bulgaria | 	bg-BG  |
| Catalan - Spain	| ca-ES  |
| Chinese - China	| zh-CN  |
| Chinese - Hong Kong | 	zh-HK  |
| Chinese - Taiwan	| zh-TW  |
| Croatian - Croatia | 	hr-HR  |
| Czech - Czech Republic	| cs-CZ  |
| Danish - Denmark	| da-DK  |
| Dutch - Netherlands | 	nl-NL  |
| English - United States | 	en-US  |
| Estonian - Estonia	| et-EE  |
| Finnish - Finland	| fi-FI  |
| French - France	| fr-FR  |
| Galician - Spain	| gl-ES  |
| German - Germany	| de-DE  |
| Greek - Greece	| el-GR  |
| Hebrew - Israel	| he-IL  |
| Hindi - India	| hi-IN  |
| Hungarian - Hungary	| hu-HU  |
| Indonesian - Indonesia	| id-ID  |
| Italian - Italy	| it-IT  |
| Japanese - Japan	| ja-JP  |
| Kazakh - Kazakhstan	| kk-KZ  |
| Korean - Korea	| ko-KR  |
| Latvian - Latvia	| lv-LV  |
| Lithuanian - Lithuania	| lt-LT  |
| Malay - Malaysia	| ms-MY  |
| Norwegian Bokmal - Norway	| nb-NO  |
| Polish - Poland	| pl-PL  |
| Portuguese - Brazil	| pt-BR  |
| Portuguese - Portugal	| pt-PT  |
| Romanian - Romania	| ro-RO  |
| Russian - Russia	| ru-RU  |
| Serbian (Cyrillic) - Serbia	| sr-Cyrl-CS  |
| Serbian (Latin) - Serbia	| sr-Latn-CS  |
| Slovak - Slovakia	| sk-SK  |
| Slovenian - Slovenia	| sl-SI  |
| Spanish - Spain	| es-ES  |
| Swedish - Sweden	| sv-SE  |
| Thai - Thailand	| th-TH  |
| Turkish - Turkey	| tr-TR  |
| Ukrainian - Ukraine	| uk-UA  |
| Vietnamese - Vietnam	| vi-VN | 

## Configuration considerations

The language of the bot must be the same as that of the voice workstream to which the bot will be attached. You can configure different geographic locales for the bot and voice workstream.<br><br>

For example, you can set English-UK in the voice profile and English-US in the bot.<br>

The bot's accuracy depends on the similarities between locales. However, if you configure different locales, preconfigured entities for the bot, such as zipcode, mightn't be accurate. 

### See also

[Introduction to the voice channel](voice-channel.md)  
[Azure cognitive services - speech to text](https://azure.microsoft.com/services/cognitive-services/text-to-speech/#features)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
