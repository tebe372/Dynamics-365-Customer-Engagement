---
title: "Regional availability and service limits for Customer Service | MicrosoftDocs"
description: "Learn about regional availability and service limits for Customer Service applications."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Regional availability of insights in Customer Service

The following table lists the regional availability of Customer Service features.

| Feature | North America| Europe | Asia Pacific | South America | OCE |Japan | India | Canada | United Kingdom | France | United Arab Emirates | Switzerland |Germany
| ------- | ----- | ------- | -------- | ----- | ------- | ------- | ----- |---- | ------ | ------ | -------- | ------ | 
| Customer Service historical analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ ||  |
| Case Topic Clustering | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ ||  |
| Smart Assist Suggestions | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ || |
| Omnichannel historical analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ || |
| Conversation Topic clustering | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ || |
| Sentiment analysis | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ ||  |
| AI suggestions for cases and knowledge articles | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |✖ |
| AI suggestions for article keywords and description | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |✖ |


✔ : Available  
✖ : Not available

## Service limits in Dynamics 365 Customer Service Insights

Customer Service Insights service has built-in limits that are designed to ensure reliability and stability of the service. Any requests for changes can be made through the Ideas forum.

### Service limits

The following table lists the built-in limits for the embedded version of insights in Customer Service Hub, Customer Service workspace, and Omnichannel for Customer Service.

| Area | Limits | Notes |
| ------------ | ------------- | ----------------- |
| Data age limit | 24-month period | Reports are limited to case data from the past 24 months. |
| Dashboard interaction | No limit | No limits on the number of interactions or drill-throughs within reports. |
| Topics | At least three related cases | Topics require at least three semantically related cases for the model to generate topics. |
| Topics refresh | 100k per run | Refresh of topics uses up to 100,000 cases or conversations per run. |
| Data refresh | Once every 24 hours | Data refresh occurs automatically each day, starting at midnight UTC. The time when the refresh completes isn't guaranteed. For more information, see [Dashboard overview](customer-service-analytics-insights-csh.md). |
| AI suggestions for active cases | Each user license adds 30 active cases where agents can get AI suggested knowledge articles and similar cases in real time. |
| AI suggestions for conversations | 150 conversations per month per user license | Each user license adds 150 Omnichannel conversations where agents can get AI suggested knowledge articles and similar cases in real time. |

## Service protection limits for AI suggestions

AI suggestions for case and knowledge are available starting October 2020. We're introducing service protection limits on these capabilities to maintain a consistent quality of service for all our customers, but there aren't penalties if customers exceed pre-defined limits. Over time, Microsoft may adjust these limits in keeping with customer usage patterns and provide options for customers with high usage scenarios and patterns to purchase additional capacity in a manner minimally disruptive to those customers.

For information on the service protection limits for AI suggestions, see [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md). The total limits are pooled at the tenant level based on the number of Customer Service Enterprise user licenses that are available in the tenant.

## Power platform capacity impact

Enabling the insights feature will impact Dataverse entitlements. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage)
