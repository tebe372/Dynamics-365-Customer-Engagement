---
title: Copilot in Dynamics 365 Sales overview
description: Learn how to use copilot to get quick summaries of records, prepare for meetings, compose emails, and stay up-to-date with news.
ms.date: 10/26/2023
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/02/2023
search.app: salescopilot-docs
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Copilot in Dynamics 365 Sales overview

Copilot is an AI assistant that helps sales teams be more productive and efficient in their daily work. It has a chat interface that sellers can use to get a quick summary of their opportunity and lead records, catch up on updates, prepare for meetings, and read the latest news about their accounts.

Copilot is turned on by default in all sales apps with lead and opportunity entities, for orgs in North America. If your org is in a different region, you need to [turn on copilot manually](enable-setup-copilot.md).

Copilot is also available as an add-in in Outlook and an integrated app in Teams, allowing you to capture, access, and update your customer account data in the apps you use every day. The add-in and Teams app have generative AI capabilities such as record summarization and email content generation. Learn more about [Microsoft Sales Copilot](/microsoft-sales-copilot/introduction) and its [generative AI capabilities](/microsoft-sales-copilot/ai-sales-copilot).

## Copilot capabilities

Copilot offers the following capabilities:

- [Record summarization](#record-summarization)
- [Record catch up](#record-catch-up)
- [Meeting preparation](#meeting-preparation)
- [Email assistance](#email-assistance)
- [News updates](#news-updates)

### Record summarization

Record summarization helps you get a quick summary of your opportunity and lead records. By default, Copilot generates the summary from your default opportunity and lead views. A system administrator can configure Copilot to generate the summary from other fields. Ensure that your entire sales team agrees on the top seven fields that are most relevant for your business.

**More information:**

- [Summarize an opportunity or a lead](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) 
- [Configure fields for summarization](configure-sales-copilot.md#configure-record-summary-and-catch-up-fields)

### Record catch-up

To help you stay on top of your opportunities and leads, Copilot summarizes any changes made to your records since your last visit or in the last seven days. Copilot generates the catch-up summary from the records' audit history. A system administrator configures the columns that are included in the catch up. Ensure that your entire sales team agrees on the top 10 fields that are most relevant for your business.

**More information:**

- [Catch up with an opportunity or lead](use-sales-copilot.md#catch-up-with-an-opportunity-or-lead)  
- [Configure fields for summarization](configure-sales-copilot.md#configure-record-summary-and-catch-up-fields)

### Meeting preparation

Copilot helps you prepare for your upcoming meetings effortlessly, summarizing relevant information from the opportunity or lead records that are associated with the upcoming meeting.

**More information:**

[Prepare for upcoming meetings](use-sales-copilot.md#prepare-for-upcoming-meetings)

### Email assistance

Copilot can help you compose professional-looking emails, summarize email conversations to add to your customer notes, and get reminders to follow up on emails you haven't replied to. 

**More information:**

- [Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)  
- [View and copy email summary](view-copy-email-summary.md)  
- [Show emails you haven't replied to](use-sales-copilot.md#show-emails-you-havent-replied-to)


### News updates

Copilot news updates help you stay current with the latest news about your accounts. News updates can be great conversation starters and help you understand the dynamics of your customers' organizations. Ask Copilot to get you the latest news related to an account and it returns a list of articles that feature or mention the account, curated by Bing. As with any content that's provided by AI, make sure you read the news articles thoroughly and confirm that they're from an authentic source and are indeed about the customer.

**More information:**

[Show the latest news about an account](use-sales-copilot.md#show-the-latest-news-about-an-account)

## Region availability and languages supported

Copilot is available in all regions in English only. If you turn on the feature outside of North America, you need to opt in to share some data with the Azure OpenAI Service outside of your default geography. [Learn more about how Copilot data moves across geographies](./sales-copilot-data-movement.md).
