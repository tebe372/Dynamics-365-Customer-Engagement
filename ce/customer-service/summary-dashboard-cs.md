---
title: Summary Dashboard | Microsoft Docs
description: Learn about the Summary dashboard insights overview to better understand your organization's customer service experience.
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/22/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Preview: Summary dashboard

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

The Summary dashboard gives you a broad overview of the customer service experience in your organization. It uses AI to surface insights into which topics are generating the highest volume and with topics are emerging with the highest rate of change in volume.

![Summary dashboard](media/summary-dashboard-analytics-cs.png "View the Summary dashboard")

To view the Summary dashboard, navigate to customer service historical analytics and select **Summary** at the top of the workspace. 

The KPI summary dashboard includes a variety of charts with graphical views of your system's key performance indicators. 

The case volume drivers and emerging case volume by topic charts use natural language understanding to group support cases as *topics* that are a collection of related cases. These charts show you the customer support topics that are generating the most volume and emerging topics with the highest rate of change in volume, helping you identify areas for improvement that can have the greatest impact on system performance.

By default, the dashboard shows you KPIs for the past month and for all channels, queues, and agents in your system. The data filtering options allow you to select data for specific time periods, channels, queues, and agents. To filter data by duration, channel, queue, or agent, select a value from the respective drop-down list. 

> [!NOTE]
> If you switch to a different dashboard, the filter you specify persists and is applied to the data on all dashboards.


## Key insights card

![Key insights discovery card](media/key-insights-card.png)

The Key insights card has two areas:

- **KPI insights**: Important subjects that impact performance, such as CSAT pertaining to priority, volume pertaining to channel, and open cases pertaining to queues.

- **Topics to watch**: Topics that rank high across the three key areas to make it easier for customer service managers to discover top issues.
  

## Report details

The KPI summary charts summarize the key performance indicators for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, and agent.

KPIs for the following areas are displayed:

- Incoming cases
- Active cases
- Escalated cases
- Average resolve time
- Average CSAT
- Average survey sentiment

Charts are displayed as follows:

- Case volume by status
- Open cases by priority
- Incoming cases by channel
- Open cases by age
- Case volume trend
- Average CSAT trend
- Average survey sentiment trend
- Top 10 volume topics
- Emerging case volume by topic
- Case metrics by channel
- Case metrics


A blue up-and-down indicator next to the value indicates the percent change in a positive direction. A red indicator indicates the percent change in a negative direction.


### See also
- [Dashboard overview](customer-service-analytics-insights-csh.md) <br>
- [Agent dashboard](agent-dashboard-cs.md) <br>
- [Topics dashboard](topics-dashboard-cs.md) 
