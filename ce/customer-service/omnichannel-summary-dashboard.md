---
title: Summary Dashboard for PVA-OC integration | Microsoft Docs
description: Integrate PVA and Omnichannel analytics to better understand your organization's customer service experience
ms.date: 10/03/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
searchScope:
- D365-App-customerservicehub
- D365-Entity-*
- D365-UI-Dashboard
- Dynamics 365
- Customer Service
- Customer Engagement
---

# Omnichannel Summary dashboard 

The **Summary** dashboard provides a seamless end-to-end reporting of metrics across the customer service journey. This integrated analytics report aligns key metrics in Power Virtual Agents and Omnichannel for Customer Service. With the Summary dashboard  Customer Service Managers or Supervisors:
- Use the Power Virtual Agents bot metrics such as escalation and deflection rate and agent metrics such as engagement rate and abandon rate to get an overview of how customers interact with bots and bot performance.
- Evaluate how different bot topic areas and their corresponding agent conversation topic impact your organization’s support performance.
- Get actionable insights to handle bot escalations and customer requests effectively, thereby improving customer satisfaction and decreasing costs.

 :::image type="content" source="media/oc-summary-dashboard.png" alt-text="Screenshot that shows the Omnichannel Historical Summary dashboard.":::

**Navigation**

You can view the Conversation dashboard in the Customer Service workspace or Omnichannel for Customer Service app. In the Customer Service workspace, you can navigate to the **Summary** dashboard as follows:

- In the default view, Select the plus (**+**) icon, and then select **Omnichannel historical analytics**. On the page that appears, select **Summary**.
- If the enhanced multisession workspace view is enabled, select the Sitemap and then select **Omnichannel historical analytics**. On the page that appears, select **Summary**.

## Report details

The report summarizes the KPIs for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, or conversation status.

 :::image type="content" source="media/oc-summary-bot-metrics.png" alt-text="Screenshot shows the bot metrics with respect to conversations.":::

| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations that were initiated by customers. |
| Bot deflection rate | The percentage of conversations engaged by bots that were resolved.|
| Bot escalation rate | The percentage of conversations engaged by bots that were escalated to a human agent.  |
| Incoming conversations  | The total number of conversations that are initiated by the customer and are presented to a human agent. Conversation escalated by the Power Virtual Agents bots is also included.|
| Engaged conversations | Offered conversations that are engaged by an agent. Customer-to-agent communication begins at this point.|
| Abandon rate | The percentage of conversations that are in a human agent's queue but aren't engaged by agents. |
|Average time to answer |The average time customers waited in the queue before being connected to an agent. |

An up-and-down indicator below the value indicates the percent change in either a positive or negative direction. 

The following charts are displayed in the Summary dashboard.

 :::image type="content" source="media/oc-bot-summary-charts.png" alt-text="Screenshot shows the charts for integrated conversations .":::

| Title | Description |
| ------- | ------------------ |
| Total conversations | A graphical view of the conversations that were initiated by the customer and were connected to a human agent directly, resolved by the Power Virtual Agents bot, or escalated by to the human agent.|
| Agent engagement rate over time | A graphical view of the daily incoming conversations, conversations engaged by an agent, and abandoned conversations over time. |
| Bot conversations| A graphical view of the daily deflection and escalation rate, and abandon rate over the specified time period. |

## Bot escalation topic metrics

The **Bot escalation topic metrics** section provides insights into the performance of individual bot topics and their key business metrics. Supervisors can drilldown into a topic to view the corresponding agent conversation topics, and analyze how a bot is resolving a topic versus how an agent is resolving an escalated conversation topic.  This helps them better understand how different topic areas impact your organization’s support performance.

 :::image type="content" source="media/oc-summary-topics.png" alt-text="Screenshot shows the bot conversation topics and customer journey.":::
 
 To view further bot topics and their related metrics, see [Bot dashboard](oc-bot-dashboard.md).   

## Language availability for topics 

The topics capability in the Customer Service historical analytics reports comes with a natural language understanding model that can understand the text semantics and intent in the following languages: 

- English 
- French 
- German 
- Italian 
- Japanese 
- Portuguese 
- Simplified Chinese 
- Spanish 

> [!NOTE]
> While topic discovery is not prevented and still possible in languages that are not listed above, there may be differences in experience for users who leverage topics in unsupported languages.

### See Also

[Conversation dashboard](oc-conversation-dashboard.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard.md)  
[Bot dashboard](oc-bot-dashboard.md)  
[Manage report bookmarks](manage-bookmarks.md)  
