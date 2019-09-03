---
title: "Design a static segment (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to create a static segment by selecting specific contacts individually in Dynamics 365 for Marketing"
keywords: segment; compound segment
ms.date: 09/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 6620a363-8996-4d94-bbbe-fb5bffaf1ceb
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Define a static segment

To create a static segment, set its **Segment type** to **Static** on the **General** tab. Then use the **Definition** tab to find and add contacts to it, one at a time.

When you are working with a static segment, the **Definition** tab lists all of the contacts from your database, with a check box shown for each. Select the check box for each contact you want to include in the segment, and clear the check box for all other contacts.

> [!IMPORTANT]
> Static segments can contain a maximum of 5,000 members. If you need to curate a larger list than this, then please create a static marketing list instead. You can bring a static marketing list into a dynamic profile segment using relations if needed. For more information about marketing lists and how they are different from segments, see [Marketing segments vs. marketing lists](segments-vs-lists.md) and [Create a marketing list using in-app marketing (Sales)](../sales-enterprise/create-marketing-list-using-app-marketing-sales.md).

Because your database probably includes a large number of contacts, the **Definition** tab can't show all of them at once. It provides paging controls at the bottom and a search filter at the top. Select the filter button at the top of the list to open a form where you can build a query that can help you find the contacts you want to add.

![A static segment with filter](media/abm-segment-static.png "A static segment with filter")

> [!TIP]
> Each time you adjust the filter settings, you must select the **Apply** button to update the list.

### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Manage segment memberships from a contact record](manage-segments-from-contacts.md)
