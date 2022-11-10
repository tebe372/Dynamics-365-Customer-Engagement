---
title: "Configure real-time analytics for supervisors | MicrosoftDocs"
description: "Learn how to configure real-time analytics for Omnichannel in Dynamics 365 Customer Service."
ms.date: 10/28/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure real-time analytics reports in Omnichannel for Customer Service (preview)

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!Important]
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

You can configure real-time analytics in Omnichannel for Customer Service and give your supervisors access to real-time metrics and KPIs that reflect the situation in the contact center as they oversee agents handling customer conversations coming through multiple channels.

The following real-time analytics reports are available:

- Summary
- Voice
- Agents
- Ongoing conversation

Make sure that you have the required administrator permissions for Dynamics 365. You can configure Omnichannel real-time analytics reports in the Customer Service admin center app.

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. On the **Insights** page, **Report Settings** section, go to  **Real-time Analytics (preview)** and select **Manage**.
1. On the **Real-time analytics (preview)** page, set the **Enable Omnichannel real-time analytics** toggle to **On**.
1. In the **Additional options** section, select the **Add real-time analytics for Omnichannel voice** option.
    This option will be available only if your organization has the voice feature configured.

    :::image type="content" source="media/enable real-time.png" alt-text="Enable the Omnichannel real-time analytics option in Customer Service admin center app":::

To configure other user roles to access analytics reports, see [Configure user roles to access analytics reports](configure-user-roles-report-access.md).

### See also

[Overview of Omnichannel real-time analytics reports (preview)](intro-realtime-analytics-dashboard.md)  
[View and understand the Summary report in Omnichannel real-time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)  
[View and understand the Voice report in Omnichannel real-time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)  
[View and understand the Agents report in Omnichannel real-time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)  
[View and understand the Ongoing Conversation report in Omnichannel real-time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversation-report-in-omnichannel-real-time-analytics-preview)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
