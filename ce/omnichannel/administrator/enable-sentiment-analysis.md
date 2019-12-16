---
title: "Enable sentiment analysis to view in Omnichannel Ongoing Conversation dashboard | MicrosoftDocs"
description: "How to enable sentiment analysis for Omnichannel Ongoing Conversation dashboard in Omnichannel for Customer Service."
author: lalexms
ms.author: lalexms
manager: shujoshi
applies_to: 
  - ""
ms.date: 12/13/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable sentiment analysis

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Enable sentiment analysis so supervisors can use the **Omnichannel Ongoing Conversation** dashboard to view customer sentiment in real time during conversations between customers and agents. You can enable or disable real-time sentiment through **Sentiment Analysis Settings** in **Omnichannel Administration**.

> [!NOTE]
> Sentiment analysis is enabled by default.

1. Sign in to **Omnichannel Administration**.

2. Go to **Settings** > **Sentiment Analysis**, and then select **Real-Time Sentiment Analysis**.

    > [!div class=mx-imgBorder]
    > ![Select sentiment analysis](../media/supervisor-admin-activat-sentiment-analysis.png "Select sentiment analysis")

3. On the **General** tab, set **Monitor real-time customer sentiment** to **Enabled**, and then select **Save**.

  > [!div class=mx-imgBorder]
  > ![Enable sentiment analysis](../media/monitor-real-time.png "Enable sentiment analysis")

After you enable real-time customer sentiment, you can view scores in the [Omnichannel Insights dashboards](configure-historical-sentiment-dashboard-supervisor.md).

Multi-language sentiment scoring is enabled by default. Conversations in more than 40 languages are scored. The languages are listed in the following table.

<table>
<tbody>
<colgroup span = "3">
<col width = "34%"></col>
<col width = "33%"></col>
<col width = "33%"></col>
</colgroup>
<tr>
<td>Arabic<br>
Bulgarian<br>
Chinese (Hong Kong SAR)<br>
Catalan<br>
Chinese Simplified<br>
Chinese Traditional<br>
Croatian<br>
Czech<br>
Danish<br>
Dutch<br>
English<br>
Estonian<br>
Finnish<br>
French<br>
</td>
<td>German<br>
Greek<br>
Hebrew<br>
Hindi<br>
Hungarian<br>
Indonesian<br>
Italian<br>
Japanese<br>
Korean<br>
Latvian<br>
Lithuanian<br>
Malay<br>
Norwegian<br>
Polish<br>
</td>
<td>Portuguese<br>
Romanian<br>
Russian<br>
Serbian (Cyrillic)<br>
Serbian (Latin)<br>
Slovak<br>
Slovenian<br>
Spanish<br>
Swedish<br>
Thai<br>
Turkish<br>
Ukrainian<br>
Vietnamese<br>
</td>
</tbody>
</table>


### See also

[Monitor conversations](../supervisor/monitor-conversations.md)
