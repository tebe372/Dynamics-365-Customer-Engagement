---
title: "Use the event portal to promote your event and accept registrations in Dynamics 365 for Marketing | Microsoft Docs  "
description: "Details about the event portal, including site map, information sources, and how to publish your events in Dynamics 365 for Marketing"
keywords: "events; event management; portal; event portal; registration"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.date: 10/20/2017
ms.service: crm-online
ms.topic: article
ms.assetid: fb12fb67-69b7-4a23-a574-9d6f53d3c8b6
ms.reviewer: renwe
---
# Set up the event portal

The event portal is a customer-facing website that people can use to read about your event and its speakers, create an account, register for the event, purchase passes, view their session schedule, and more. The following image shows a site map of your event portal as your attendees will see it.

![Sitemap for the standard event portal](media/event-portal-sitemap-ill.png "Site map for the standard event portal")

The event portal is built by using the standard portals capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] solution, so you can see all its constituent elements by going to the **Portals** work area of [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. However, you usually won't need to work with any of these elements unless you want to customize the portal. The event portal is preconfigured to publish all the relevant information about each published event, and to enable visitors to register for the event, create an account (including username and password), edit their profile, and choose session passes. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Engage with customers online with Dynamics 365 portals](portals.md)

Most of the information shown on the portal comes directly from your event model and its various related records, so all you need to do get the portal online is make sure that all the information is available in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] and that the event itself, plus its relevant sessions and tracks, are set to be published on the portal. To publish any of these items, open the relevant record and set its **Publish Status** in the drop-down list (usually shown in the upper-right corner of the form) to **Published**. Other relevant information related to the event, like speakers and sponsorships, will be published automatically so you don't need to publish them separately. Set the **Publish Status** to any other value to unpublish an event, session, or track if needed, thus removing it from your event portal.

![The Publish Status menu](media/event-publish-ill.png "How to set the publish status of an event to the portal")

The following table summarizes which types of information are publish to the portal. Be especially careful and thorough when entering values for these fields, because they are exposed to the public.

| **Entity**    | **Where it gets published** | **Which fields get published**|
|---------------|-----------------------------|-------------------------------|
| Events         | All published events are listed on the **All Events** page of the portal.|**Event Name**<p>**Start and end dates**</p><p>**Primary Venue**</p><p>**Description**</p>|
| Sessions       | Each published session is listed on the **Sessions** page for the event it belongs to, on the **Speaker** page for the speaker presenting it, and on the **Session Tracks** page for tracks it belongs to.| **Session Title**<p>**Start Date & Time**</p><p>**End Date & Time**</p><p>**Session Summary**</p><p>**Session Detail Description**</p><p>**Session Tracks**</p><p>**Duration**</p>|
| Speakers       | Published speakers are listed on the front for each event where they are speaking, on the **Speakers** page, and on session pages for each session they are running. A speaker profile page shows additional details and a schedule of sessions for that speaker. |**Name**<p>**Photo**</p><p>**Title**</p><p>**About**</p><p>**[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)]**</p><p>**[!INCLUDE[tn-twitter](../includes/tn-twitter.md)]**</p><p>**Website**</p>|
| Session Tracks | Published external tracks are listed on the **Session Tracks** page for the event they belong to. Each session track shows its name and a list of sessions that belong to it (with links).<p>You can only publish external tracks (not internal ones).</p>|**Name**<p>**Audience**</p>|
| Passes         | All passes associated with a published session track are listed on the **Pass Information** page for the event the track belongs to. The system tracks the number of passes available and the number assigned, and indicates when passes are sold out.|**Name**<p>Track **Name** from the related track record</p><p>**Pass Price**</p><p>Sold out status, indicated when the **Passes Remaining** field for a pass reaches zero</p>|
| Sponsors       | Sponsors associated with published events are displayed at the bottom of most pages of the portal for those events.|**Event Sponsor** (the **Account Name** of the related account record)</p><p>**Logo** (taken from the related account record for each sponsor)</p>|