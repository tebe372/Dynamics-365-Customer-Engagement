---
title: "Set up an event portal (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Set up a Dynamics 365 for Marketing event portal, where people can read about your event and its speakers, create an account, register for the event, purchase passes, view their session schedule, and more."
keywords: event;portals;event portal
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: b83e8cb2-38a4-462f-87bc-0fc52357f01e
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

# Set up the event portal

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

> [!IMPORTANT]
> This topic describes the sample event portal that is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. *The sample event portal is intended for demo and testing purposes only.* Any customizations that you make to the sample event portal will likely get overwritten the next time you update [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so if you want to create a custom event portal to use in production, you must create a new website in your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal. You can start by recreating the sample event portal on the new site, and then apply customizations as needed. For more information about how to create a new website in the portal, see [Create and manage websites](../portals/websites.md). Alternatively, you could download the event portal as an Angular project, customize as required, and then publish as a new site on your portal or on your own website, as described in [Customize the event portal and host it anywhere](#angular). The sample event portal is editable, so you can still experiment with it, but be aware that your customizations are only temporary and are likely to be entirely overwritten the next time you update the system.

The event portal is a customer-facing website that people can use to read about your event and its speakers, create an account, register for the event, purchase passes, view their session schedule, and more. The following image shows a site map of your event portal as your attendees will see it.

![Sitemap for the standard event portal](media/event-portal-sitemap-ill.png Site map for the standard event portal)

The event portal is built by using the standard portals capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] solution, so you can see all its constituent elements by going to the **Portals** work area of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. However, you usually won't need to work with any of these elements unless you want to customize the portal. The event portal is preconfigured to publish all the relevant information about each published event, and to enable visitors to register for the event, create an account (including username and password), edit their profile, and choose session passes. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Engage with customers online with Dynamics 365 for Customer Engagement portals](portals.md)

[!INCLUDE[cc-marketing-cookies](../includes/cc-marketing-cookies.md)]

## Publish events, sessions, tracks, and related records to the portal

Most of the information shown on the portal comes directly from your event model and its various related records, so all you need to do get the portal online is make sure that all the information is available in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] and that the event itself, plus its relevant sessions and tracks, are set to be published on the portal. 

To publish an event, session, or track, open the relevant record and set its **Publish Status** in the drop-down list (usually shown in the upper-right corner of the form) to **Published**. Set the **Publish Status** to any other value to unpublish an event, session, or track if needed, thus removing it from your event portal.

![The Publish Status menu](media/event-publish-ill.png How to set the publish status of an event to the portal)

The following table summarizes how to publish each publishable entity to the portal, and which types of information are publish for each of them. Be especially careful and thorough when entering values for published fields, because they are exposed to the public.


|   **Entity**   |  **How and where it gets published**   |  **Which fields get published** |
|-------|----|-----------|
|     Events     |  Publish each event manually by opening the event record and setting the **Publish status** to **Published**. Unpublished events won't be shown on the portal.<p>All published events are listed on the **All Events** page of the portal.</p> |  Event name, Start date & time, End date & time, Primary venue, Description|
|    Sessions    | Publish each session manually by opening the session record and setting the **Publish status** to **Published**. Unpublished sessions won't be shown on the portal.<p>Each published session is listed on the **Sessions** page for the event it belongs to, on the **Speaker** page for the speaker presenting it, and on the **Session Tracks** page for tracks it belongs to. | Session title, Start date & time, End date & time, Session summary, Detailed description, Session tracks, Duration|
|    Speakers    | Speakers are published automatically when you publish the session they are assigned to.<p>Published speakers are listed on the front for each event where they are speaking, on the **Speakers** page, and on session pages for each session they are running. A speaker profile page shows additional details and a schedule of sessions for that speaker.</p> | Name, Photo, Title, About, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], [!INCLUDE[tn-twitter](../includes/tn-twitter.md)], Website |
| Session Tracks |    Publish each track manually by opening the track record and setting the **Publish status** to **Published**. Unpublished tracks won't be shown on the portal.<p>Published external tracks are listed on the **Session Tracks** page for the event they belong to. Each session track shows its name and a list of sessions that belong to it (with links).<p>You can only publish external tracks (not internal ones).</p>     |  Name, Audience |
|     Passes     | Passes are published automatically when you publish the event they belong to.<p>All passes associated with a published session track are listed on the **Pass Information** page for the event the track belongs to. The system tracks the number of passes available and the number assigned, and indicates when passes are sold out.</p>| Name, Name of the related track record, Pass price, Sold out status</p>             |
|    Sponsors    | Sponsors are published automatically when you publish the event they belong to.<p>Sponsors associated with published events are displayed at the bottom of most pages of the portal for those events.  |  Event sponsor (the  name of the related account record), Logo (taken from the related account record for each sponsor)</p>                          |

## Customize portal graphics

The portal features a banner image for each event, and also shows speaker photos and sponsor logos.

- You can customize the banner image shown for any event by [editing the event record](set-up-event.md), going to the **General** tab and using the **Portal banner image** setting.

- Speaker images come from each speaker record (not from the associated contact record). To upload a speaker image, go to **Events** > **Participants** > **Speakers** and open the relevant speaker record. Then select the existing photo (or generic placeholder) in the heading area of the page to open a dialog where you can upload an image. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up an event](set-up-event.md)  
    ![Edit the speaker image](media/speaker-edit-image.png Edit the speaker image)

- Sponsor images come from each sponsorship record, which you can edit by working in the event record where the sponsorship applies (found on the **Agenda** tab, which links to related sponsorship records), or by finding the appropriate sponsorship record under **Events** > **Sponsorship management** > **Sponsorships**. As with speaker images, you can edit the image by selecting the existing photo (or generic placeholder) in the heading area of the sponsorship record page.

## Open the sample event portal

To find the URL for your sample event portal and open it:

1. Open the relevant event record.
1. Make sure the **Publish status** is set to **Published**.
1. Open the **General** tab and find the **Key information** section.
1. The **Event URL** field here shows the address of the portal for this event. Select the globe button at the edge of this field to open the URL.

<a name=angular></a>

## Customize the event portal and host it anywhere

If you are comfortable developing web applications using the [Angular](https://angular.io/) framework, then a good way to customize the sample event portal for production is to download it as an Angular project, customize it in your preferred development environment, and then publish it either on your own website, or as a new site on your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal. For details, see [Build and host a custom event portal](developer/event-management-web-application.md).

### See also

[Set up online payment for events](event-payment-gateway.md)  
[Engage customers online with portals](portals.md)  
[Set up an event](set-up-event.md)  
[Go live with publishable entities and track their status](go-live.md)
