---
title: "Export customer journey insights to Excel (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to export Dynamics 365 Marketing customer journey data to Excel for further analysis or reporting."
ms.date: 02/25/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Export customer journey insights into a .CSV file

> [!IMPORTANT]
> This is an early access feature, which means that it's currently available only on opted-in instances. You can opt in for early access on any instance, but we recommend that you do so only on trial, test, or sandbox instances, which will give you a chance to learn the new functionality before it shows up on your production instances later this year.
>
> For instructions on how to opt in and enable early access, see [Opt in to early access updates](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates). For more information about the 2020 release wave 1 schedule, and for answers to frequently asked questions about the early access program, see [2020 release wave 1 features available for early access](https://docs.microsoft.com/dynamics365-release-plan/2020wave1/features-ready-early-access).
>
>We encourage all customers to provide feedback related to early access features on the [Dynamics 365 Marketing Forum](https://community.dynamics.com/365/marketing/f/dynamics-365-for-marketing-forum), your Microsoft contact or partner, and/or through [Microsoft Support](https://docs.microsoft.com/power-platform/admin/get-help-support).

You can now export all customer journey interactions into a .CSV file for further analysis or reporting. You can easily export interactions from the same category (for example, Delivered emails) with just a click of a button.

## Export a .CSV file

1. Go to **Insights** and select the interaction category you want to export (for example, **Delivered emails**).

2. Click the **Export to CSV** button in the right top corner of the selected table.

3. The .CSV file is automatically downloaded with the same columns and data as the table you selected to export.

    ![Export a category to CSV](media/customer-journey-export.png "Export a category to CSV")

> [!IMPORTANT]
> You cannot download different categories of interactions (e.g., **Sent** + **Delivered** + **Blocked** + **Delivery failed**) all at once into a single file. You must export each category individually.