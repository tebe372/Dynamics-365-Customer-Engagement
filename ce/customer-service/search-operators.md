---
title: Learn how search works for knowledge management in Dynamics 365 Customer Service | Microsoft Docs
description: Use knowledge article search mechanisms in Customer Service Hub.
ms.date: 04/04/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
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
---

# Understand how search works in knowledge management

## Introduction

Setting up a comprehensive knowledge base is the key to increased customer satisfaction and improved productivity. A knowledge base is created to help you with solutions to the most common customer issues to assist customers quickly. This topic describes how various search methods work in a knowledge base and how you can view accurate search results based on the fields or operators that you use to search the knowledge base.

Dataverse search is enabled by default on all production environments, except those using their own encryption key. More information: [Enable Dataverse search](/power-platform/admin/configure-relevance-search-organization#enable-dataverse-search). When Dataverse search is enabled, knowledge management search control uses Dataverse search to search for knowledge articles. More information: [What is Dataverse search?](/power-platform/admin/configure-relevance-search-organization). Otherwise, the search mechanism switches to full-text search, which lets you run full-text queries against character-based data in SQL Server tables. More information: [Full-text search](/sql/relational-databases/search/full-text-search).

Depending on the configurations made in Dataverse search through the Quick Find view columns list, you can view the information provided in the search results, such as keywords, description, attachments, or article number. More information: [Before you begin using Dataverse search](search-knowledge-articles-csh.md#before-you-begin-using-dataverse-search).

## Search operators

The following section describes the search operators that you can use to search for your knowledge articles when Dataverse search is enabled for your environment.

### Boolean operators

By default, the search mode is "any". However, if you have Dataverse search enabled along with the **Knowledge search logic** option in **Settings**, the search mode will be set to "all". This ensures that all the search words must match to consider an article as a match. More information: [Set up knowledge search logic](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-search-logic).

- Query: searchmode= all

#### AND operator

Use the AND operator when you need to search with a combination of words. The search results will show articles that contain all the individual terms separated by (+). For example, **Delivery + order** returns the article **Delivery Never Arrived** which has **Delivery** and **order** in the article content.

:::image type="content" source="media/and-operator.png" alt-text="AND operator":::

- Query: AND operator; denoted by +

#### OR operator

Use the OR operator to search for either of terms. Search terms separated by a vertical bar ( | ). For example, searching for **delivery | order** returns records with reference to either term.

:::image type="content" source="media/or-operator.png" alt-text="OR operator":::

Query syntax: OR operator; denoted by |

#### NOT operator

Use the NOT operator with a hyphen (-) before a keyword to indicate that it should be excluded from the search results.
For example, when you search for **product**, all rows matching the term product will appear in the search results. However, searching for **product -order** will match all rows that contain the term **product** but not the term **order**.

:::image type="content" source="media/not-operator.png" alt-text="NOT operator":::



- Query syntax: NOT operator; denoted by -

### Wildcards

Use wildcards as placeholders for one or more text characters. Use an asterisk at the beginning or end of a keyword. For example, searching on **pro*** will show results for all records associated with a keyword that starts with **pro**. **Pro*** searches for **product**, **products**, and **procedure**.

:::image type="content" source="media/wildcard-search.png" alt-text="Wildcard search":::

- Query syntax: Search term with asterisk at the beginning or end of a keyword.

### Exact matches

Use double quotation marks around a keyword to perform an exact match. For example, searching on "order shipping time" will match the exact keywords in an knowledge article. The search ignores commonly used words such as a, an, and the.

:::image type="content" source="media/exact matches.png" alt-text="Exact matches search query":::

- Query syntax: Search term with double quotation marks around it.

### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)

[Set up a search provider in Customer Service Hub](set-up-search-providers.md)

[Add a knowledge article subgrid to a form](add-knowledge-base-search-control-forms.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
