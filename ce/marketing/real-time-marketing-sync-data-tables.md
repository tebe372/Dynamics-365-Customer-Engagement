---
title: "Preview: Sync data tables into the segment builder (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to sync data tables into the segment builder in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 11/03/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Preview: Sync data tables into the segment builder

> [!IMPORTANT]
>
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

The real-time marketing segment builder allows you to sync data tables without relying on the help of administrators. This saves you time when setting up segments, letting you directly add data tables to Dynamics 365 Marketing without using the Dynamics 365 admin center.

**Example**: You want to create a segment using attributes from the Fax table in Dataverse, but you notice that Fax isn’t available in your related data tables.

To add the Fax table directly from the Marketing app, go to the real-time marketing segment builder and create or select a segment. Then, in the **Elements** side pane, select **+Add table** next to **Related tables**. Search for the Fax table, select the check box next to it, then select **Next** to add the table to the segment builder. 

> [!div class="mx-imgBorder"]
> ![add table to segment builder](media/real-time-marketing-add-table-to-segment-builder.png "add table to segment builder")

After you add the new table, you can use the attributes from Fax immediately in your segment creation.

> [!div class="mx-imgBorder"]
> ![use attributes right away](media/real-time-marketing-use-attributes-right-away.png "use attributes right away")

> [!NOTE]
> It can take up to 24 hours for a data table to be synchronized into the system. At this time, the segment member size estimate and preview features are not available. You cannot view the segment membership until the table is synchronized into the system.  
