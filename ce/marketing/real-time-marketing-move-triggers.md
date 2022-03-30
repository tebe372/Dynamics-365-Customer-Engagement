---
title: "Move custom triggers between environments (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to move real-time marketing custom triggers between Dynamics 365 Marketing environments."
ms.date: 03/29/2022
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

# Move custom triggers between environments

If you use multiple environments for testing customizations, triggers, or other assets before making them available in a production environment, you can move draft custom trigger “definitions” between environments. 

> [!NOTE]
> Because each environment’s triggers are published using an ingestion key unique to that environment, it is currently not possible to move a *published* trigger to a new environment.

To move draft custom trigger definitions between environments, use the following steps:

1. Ensure the triggers you want to move are in a *Draft* state. If they’ve already been published, you can stop them and the customer journeys using them.
1. Use [solution export/import](transfer-solution.md) to copy the *msdynmkt_eventmetadata* entity from the test environment to the production environment. This entity carries the definitions of the custom triggers.
1. In the target environment, once you’ve verified that the custom trigger definitions have been copied, re-publish all the triggers so that they can be used in the journeys.
1. Any web/mobile/other applications that need to trigger journeys in your target environment now need to call the trigger using the new ingestion key. A developer will need to update the ingestion key. You can find the ingestion key by opening any custom trigger and opening the one-time setup code snippet for that trigger. To learn more about integrating the code snippet, see [Trigger integration](real-time-marketing-custom-triggers.md#2-trigger-integration).

    > [!div class="mx-imgBorder"]
    > ![Setup code snippet download.](media/real-time-marketing-move-ingestion.png "Setup code snippet download")

    - If you’re using a Power Automate flow to raise the real-time marketing custom trigger, this step is not required. However, make sure to create a new flow definition in the new environment and use it to raise the custom trigger.

Learn more about managing environments and ALM operations: [Manage your Dynamics 365 Marketing environments](manage-marketing-environments.md).