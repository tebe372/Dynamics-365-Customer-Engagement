---
title: "Configure real-time analytics for supervisors | MicrosoftDocs"
description: "Learn how to configure realtime analytics for Omnichannel in Dynamics 365 Customer Service."
ms.date: 10/12/2022
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

You can enable real-time analytics in Omnichannel for Customer Service and give your supervisors access to real-time metrics and KPIs that reflect the situation in the contact center as agents handle customer conversations coming through multiple channels.

The following real-time analytics reports are available:

- Summary
- Voice
- Agents
- Ongoing conversations

You can enable Omnichannel real-time analytics reports in the Customer Service admin center app.

Make sure that you have the required administrator permissions for Dynamics 365.

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. On the **Insights** page, **Report Settings** section, go to  **Real time analytics (preview)** and select **Manage**.
1. On the **Real time analytics (preview)** page, set the **Enable Omnichannel real-time analytics** toggle to **On**.
1. In the **Additional options** section, select the **Add real-time analytics for voice** option.
You will see the above option, only if your organization has the Voice feature enabled.

## Provide report access to additional security roles
Perform the following steps to enable users with different privileges to access reports beyond the default ones.

1. In Dynamics 365, navigate to **Settings** and select **Advanced settings**.

1. Select **Security** and then **Security roles**.

1. Select the security role that you want to enable access for. For example, agent manager.

1. Select the **Custom Entities** tab.

1. Grant Read privileges to the following entities:

   - **Omnichannel for Customer Service real-time analytics**
   - **Insights**
1. Select **Save and close**. The agent manager can now see the Omnichannel for Customer Service real-time analytics report.

You can see the reports by navigating to the **Service** > **Analytics and Insights** > **Omnichannel for Customer Service real-time  analytics** page. By default, the **Summary** page is displayed.

### See also

[!INCLUDE[footer-include](../includes/footer-banner.md)]
