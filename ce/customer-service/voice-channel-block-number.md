---
title: "Block spam numbers in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how to review, mark, and block spam numbers in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/02/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage spam numbers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

In Omnichannel for Customer Service, you can block spam phone numbers that your agents receive as part of their incoming customer calls. This helps your agents engage with real customers​, instead of attending to unsolicited or irrelevant calls that don't correspond to your line of business. This capability for administrators to control which calls can be received by your agents helps improve efficiency and productivity of agents​. It also helps to prevent long waits for actual customers in queues​. Your agents and supervisors can also flag off incoming calls as spam, that you can later review and block as spam.

## Review phone numbers marked as spam


**To review phone numbers marked as spam**

1. In the site map of Omnichannel admin center, go to **Advanced settings** > **Customer settings**.
   
2. In the **Customer experience** area, select **Blocked numbers**, and then select **Manage**.

3. On the **Blocked numbers**, you can do the following:
    
    - **Pending review** tab - Shows the list of numbers that have been flagged as spam by your agents and supervisors. You can view the report for each phone number, and then block the specific number as spam. Select any number from the **Pending review** list, and then you can do the following:
      - **Block** - Select to block the number; the agent will no longer receive any calls from the blocked number.
      - **Remove from list** - Select to remove the number from the **Pending review** numbers list; the number is unmarked as spam.
      - **View report history** - Select to view the reports for the specific phone number in the **Pending review** list. You can review all spam notification reports by viewing the report history​. You can visit the conversation history page to review the conversation or recordings.​ You can also choose to either block the number or remove the number from pending review list.
    
    - **Blocked** tab - Shows the list of phone numbers that have been blocked as spam.

## Manually block a phone number

1. In the site map of Omnichannel admin center, go to **Advanced settings** > **Customer settings**.
  
2. In the **Customer experience** area, select **Blocked numbers**, and then select **Manage**.

3. Select **Block a number**.

## Automatically block phone numbers

You can set conditions so that some numbers are automatically added to the blocked numbers list if they match certain conditions based on the number of reports. Using the **Auto-block** option, you can also automatically block numbers if they're reported as spam, say two or more times. This not only saves time in reviewing every blocked call report received from your agents, but also helps remove any delay from your end when you have too many spam numbers to review. The auto-block option is also useful in situations or instances where there might be a surge in spam calls from different numbers.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
