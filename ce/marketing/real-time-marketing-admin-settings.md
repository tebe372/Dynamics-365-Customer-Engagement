---
title: "Real-time marketing administrator settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about administrator settings required for real-time marketing functionality in Dynamics 365 Marketing."
ms.date: 11/12/2021

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

# Real-time marketing administrator settings

This article describes administrator settings required for real-time marketing features.

## Customer journeys

Real-time marketing customer journeys utilize a Power Automate connector to publish customer journeys. To ensure real-time marketing customer journey functionality, the shared_dynamics365marketing connector is required to be categorized in the **Business** data group within your data loss prevention (DLP) policy. [DLP policies](/power-platform/admin/wp-data-loss-prevention) are an administrator-level feature from Power Platform that prevent misuse or abuse of company data by restricting usage of Power Platform connectors or combinations of connectors.

The **Business** categorization allows business data to be shared with Power Automate. The connector does not allow sharing or storage of any personal data. The DLP setting for the connector can only be set by an administrator.

Learn more about connector settings and DLP policies: [Connector classification](/power-platform/admin/dlp-connector-classification).
