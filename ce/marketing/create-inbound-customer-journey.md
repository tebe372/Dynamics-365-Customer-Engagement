---
title: "Inbound marketing with Dynamics 365 for Marketing | Microsoft Docs"
description: "How to set up a customer journey to implement inbound marketing that attracts new contacts to register with your organization in Dynamics 365 for Marketing"
keywords: tutorial; inbound marketing; landing page; page
ms.date: 10/16/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 5b3164e5-3a2a-4254-9085-c3e512c14867
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

# Create an inbound customer journey

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

*Inbound customer journeys* seek to attract new, unknown contacts, so they typically start with a landing page that new contacts use to register for a newsletter, download, or some other perk. You'd typically promote your inbound campaign by running ads and posting links on social media. (In comparison, an *outbound* customer journey is one that starts with a segment made up of contacts that are already included in your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database, so an outbound journey usually starts by sending out marketing emails to the members of a segment.)

Though messaging and promotion strategies are typically quite different for an inbound campaign compared to an outbound one, you design inbound customer journeys in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] by using the same basic tools as you would to create an outbound customer journey (as we've seen in several previous exercises). The most important difference is that you typically start an inbound customer journey with a landing page or event instead of a segment. In this configuration, all contacts (both new and existing) who submit the form from the landing page or register for the event immediately start down that journey.

![An example of a simple inbound journey](media/journey-inbound-example.png "An example of a simple inbound journey")

Another way to create an inbound journey is to start with an [interaction segment](segments-interaction.md) that is based on form-submit interactions. If you are [embedding your marketing forms on your own website](embed-forms.md) rather than on a [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] marketing page, then this is the only way to find and target contacts who submitted the form; but you can also use this technique to find submissions from [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] marketing pages.

### See also

[Create a simple customer journey](create-simple-customer-journey.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
