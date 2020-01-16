---
title: "Initial and ongoing event planning (Dynamics 365 Marketing) | Microsoft Docs "
description: "How to plan an event (including: register basic info; set up your team; manage sessions and speakers; set the event schedule; issue passes;  and manage venues) in Dynamics 365 Marketing"
keywords: events; event management
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: a3d1dc05-8a69-43dd-94ee-a36ea4de650e
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

# Set up an event

To get started planning an event with Dynamics 365 Marketing, you start by creating an event record, which collects all of your planning details, gives links to related records, and provides a business-process timeline that helps guide you through each step of the event-planning process. Then you set up your event team, manage speakers and sessions, set up event passes, and set up a venue.

## Create the root event record

The first thing you'll do when setting up your event in Dynamics 365 Marketing is to set up an event record. Everything that you do related to a given event will either be stored directly in the event record itself, or stored in other records that are linked to that event.

Though the solution offers many different views into other record types, you'll probably do most of your work directly in the relevant event record because you'll be able to view and create most types of related records from here, and everything that you do will automatically be related to that event.

You can see a list of all your event records by [opening the **Events** work area](open-events.md) and going to **Events** > **Event** > **Events**. From here you can use the standard list-view controls to search, sort, and filter the list to find and open an existing event, or to create a new event record.

If you often run similar events, then you can save time by setting up one or more [event templates](event-templates.md) and then choosing an appropriate template when you first create a new event. 

![Example of an event record](media/event-record.png "An example of an event record")

As with many other forms in Dynamics 365, the event form provides a summary of its most important settings at the top, where you'll also find the business workflow timeline, which helps organize your work at each stage of the event-management process. A standard business workflow for events is provided out of the box, but you can customize it to match the process in place at your organization.

The first time you create a new event, you must specify values for each of the required fields (marked with a red asterisk), and we recommend that you fill out the business-critical fields, too (marked with a blue plus sign). All required and business-critical fields are available at the top of the page in the business workflow, where you can fill them out quickly and easily. All settings that you enter in the business workflow will also be visible among the other event details farther down the page. You'll still be able to see and edit these settings even after you move forward to the next stage in the workflow.

After you enter values for all the required fields, you can save the record. You'll probably return to the event record many times over several days while you plan your event. Use the workflow as a to-do list and to track your progress during each stage.

The main body of the page repeats all the important information requested by, and shown in, the workflow, plus much more. It's organized into tabs, which you can navigate by using the links provided near the top of the page body. You can enter your planning details in the main body of the page whenever you want to&mdash;you don't have to wait until you get to a specific part of the workflow. See the following subsections for a summary of how to use each available tab.

Only live events, sessions, and tracks are shown on the event website. When you're ready to go live with an event, session, or track, open the relevant record and go live as described in [Publish events, sessions, tracks, and related records to the website](set-up-event-portal.md#publish-event).

### The General tab

Here you can see and edit your basic event information, including

- **Key information**: Includes the name of your event and other basic details. The following settings are provided:
  - **Event name**: Enter a name for the event.
  - **Event type**: Choose which type of event this is. This is for information only and won't affect any features. Use it to make your event easier to find and identify.
  - **Format** Set up your event as a [webinar](set-up-webinar.md),  webinar simulcast, or on-site only.
  - **Registration count**: Shows the number of people who registered for the event. The maximum value that can be shown here is 50,000, but you can still store more registrations than this in the system.
  - **Check-in count**: Shows the number of attendees that checked in during the event. The maximum value that can be shown here is 50,000, but you can still store more check-ins than this in the system.
  - **Custom event URL**: If you are [hosting your event website](set-up-event-portal.md) on your own server, or in a custom location of your Dynamics 365 Portals solution, then select this check box and edit the **Event URL** as needed.
  - **Event URL**: Shows the address of your [event website](set-up-event-portal.md). If you're using the default location on your Dynamics 365 Portals solution, then this value is read-only and provided automatically. If you are hosting your website at a custom location, then select the **Custom event URL** check box and edit the value here. Select the globe button next this field to open the site. More information: [Open the event website](set-up-event-portal.md#open-site)
  - **Create leads for event registrations**: Set to **Yes** to create a new lead for each contact that registers for the event. Set to **No** to turn off lead generation for events. More information: [Generate and match contacts and leads from event registrations](set-up-event-portal.md#generate-leads)
    > [!NOTE]
    > As mentioned, the **Registration count** and **Check-in count** fields can each count up to a maximum of 50,000 contacts. The system can easily handle more registrations and/or check-ins than this, but for values higher than 50,000, these fields are no longer accurate.
- **Website**: Use these settings to configure your [event website](set-up-event-portal.md). The following settings are provided:
  - **Readable event ID**: This is a unique ID for the event. It is generated the first time you save the event, and is based on the event name. This becomes [part of the URL](set-up-event-portal.md#open-site) for opening the event website to a particular event.
  - **Enable CAPTCHA**: Set this to **Yes** to include a [CAPTCHA](https://www.captcha.net/) on the [registration page](set-up-event-portal.md#registration) of your event website. Set this to **No** to disable the CAPTCHA.
  - **Portal payment gateway**: To enable online payment during online event registration, set up an account with a third-party online payment provider and then [prepare a payment page](event-payment-gateway.md) on your portal according to their instructions. Then choose that page here. This setting only has an effect for event websites [hosted on the Dynamics 365 Portal](set-up-event-portal.md#customize) (it has no effect on externally hosted event websites).
  - **Enable multi-attendee registration**: Set this to **Yes** to allow users of the event website to register several attendees at once. Set to **No** to allow just one attendee per registration.
  - **Event image**: Choose a banner image to show on the event website when browsing this event. You can choose any image that is already [uploaded to your file library](upload-images-files.md), or upload a new one from here.
  - **Allow anonymous registrations**: Controls whether contacts can freely register themselves for an event on the event website, or if they must first set up an account with a user name and password. Contacts who create an account have several advantages including: the ability to register any number of attendees and the ability to return to view schedules or edit their registrations at any time. This setting only has an effect for event websites [hosted on the Dynamics 365 Portal](set-up-event-portal.md#customize) (it has no effect on externally hosted event websites).
- **Schedule**: Provides settings for specifying the time zone, start, and end dates for your event. You can also set up a [recurring event](event-recurring.md) here. Note that if you change the start date for an event that's already been saved, you'll be asked whether you want to change the end date and the session schedule to match it.
- **Timeline**: As with most types of entities in Dynamics 365, you can use this section to build a record of the activities (such as calls, emails, and appointments) that you and others do in relation to the current record. You can also share notes here. Use the links, buttons, and menus at the top of this area to create new items and to search and sort the list.
- **Location**: Specify the location where your event will take place. The location is hierarchical, and you can specify only as much detail as you need. For example, you can specify just a building, but to specify a room, you must first choose the building that contains that room. You'll also be able to assign a separate location to each session if applicable. You can create location records from here, or choose from among existing [venue records](#venues). Each location record can hold useful information such as address, facilities, capacity, and more.
- **Venue constraints**: This section only appears for on-site events. Each time you set a new **Location**, the **Maximum event capacity value** shown here updates to match the capacity configured for your last selected building, room, or layout (if available); you can then edit the value manually to override this if needed. You can also enable the [waitlist](event-waitlist.md) here to handle registrations that arrive after the event is full.
- **Waitlist**: This section only appears if you enable the waitlist in the **Venue constraints** section. Use it to configure options for how to [invite waiting contacts](event-waitlist.md) when space becomes available.
- **Webinar setup**: This section only appears for webinar and hybrid events. Use the settings here to [set up your webinar configuration](set-up-webinar.md) and find the URLs for viewing and presenting the webinar.

<a name="agenda-tab"></a>

### The Agenda tab

The **Agenda** tab includes details about the schedule of sessions happening during your event. Here you can find, create, and edit each of the following for the current event:

- **Allow registrants to create their own agenda**: This setting is only available for events that don't have any [passes](#event-passes) set up; it's shown above the calendar when no passes are defined, but is hidden when passes are defined. It affects the way checkout works on the [event website](set-up-event-portal.md) as follows:
    - When this is set to **Yes**, the website offers [session-level registration](session-level-registration.md). When a registrant selects **Register now**, the event website shows a list of all of the available sessions, and the registrant can add one, some, or all of them as needed.
    - When this is set to **No** (or if the setting is hidden), the website offers event-level registration. When a registrant selects **Register now**, the event website shows a list of [passes](#event-passes) available, each of which provides access to one or more specific sessions and can also show a different price. Registrants can choose the pass that best matches their needs, but can't make custom session selections.
- **Sessions calendar**: Shows a calendar of sessions defined for your event. You can both create and edit sessions using the calendar. More information: [Work with marketing calendars](marketing-calendar.md).
- **Sessions list**: Each [session](#sessions) is typically a single presentation, class, discussion, or webinar. This table repeats the information also shown in the calender. You can also create or edit sessions here.
- **Tracks**: Each (external) [track](#sessions) is a collection of related, non-conflicting sessions that likely would be of interest to the same audience. Attendees might sign up for a specific track, which you can manage by using [passes](#event-passes). You can also set up internal tracks, which are not exposed to attendees but can help you with your planning.
- **Speaker engagements**: Each [speaker engagement](#speakers) maps a speaker to a session occurring at your event.
- **Sponsors**: Companies who are [sponsoring the event](manage-event-sponsorships.md).

### The Registration and attendance tab

Use the **Registration and attendance** tab to see who registered for the event, who attended, and who canceled. You can also create registrations and check-ins here. The following sections are available:

- **Passes**: View and create types of [passes](#event-passes), which function as tickets to your events, sessions, and tracks.
- **Event custom registration fields**: Here you can [view and create custom registration fields](custom-registration-fields.md), which enable registrants to provide extra information  (such as dietary restrictions or gift options) when they register for the event.
- **Event registrations**: This table provides a list of people who  [registered](invite-register-house-event-attendees.md) for your event. You can also [register people manually](invite-register-house-event-attendees.md) here. If you are using [custom registration fields](custom-registration-fields.md), then you can also view the values submitted by each attendee here.
- **Event check-ins**: Here you can see who attended the event and enter attendance records.
- **Waitlist**: See who's on the [waitlist](event-waitlist.md) for this event.
- **Contacts who canceled**: Lists contacts who were registered for the event but who have now cancelled their registration. The list includes cancellations made by contacts using the event website and by users using the Marketing app. If you'd like to communicate with contacts who cancelled from one or more events, you can set up an behavioral segment based on `EventRegistrationCancelled` interactions and then use that segment to target a customer journey.

### The Additional information tab

Use the **Additional information** tab to set up your event team and record general information, goals, and financial details. The following sections are provided here:

- **Additional information**: Enter a basic description and outline your goals.
- **Financials**: [View and record financial details](event-financials.md) for your event. These values appear in dashboard charts and analytics, but are intended for information only, not for formal accounting or bookkeeping.
- **Event team members**: [Set up your event team](#set-up-your-event-team) by adding links to coworkers and external contacts who are helping you organize the event. The table here shows each team member's name and role, so you can easily see who to call and find their contact info when needed.

### The room reservations tab

The **Room reservations** tab provides a calendar that shows the rooms assigned to the currently displayed event and its sessions. Unreserved rooms aren't shown, nor are events or sessions without assigned rooms. This calendar is read-only, so you can't create any sessions or reservations here. More information: [Work with marketing calendars](marketing-calendar.md)

### The Post event tab

Here you can [view and create online surveys](surveys.md) related to your event. You'd typically use this to collect attendee opinions about how it went. A second table provides links to individual survey responses.

Surveys are provided by the [Voice of the Customer](../voice-of-customer/help-hub.md) feature.

## Set up your event team

Your event team includes coworkers and external contacts who are helping you organize the event. Each event record lists each team member's name and role, plus links for more information, so you can easily see who to call and find their contact info when needed.

- You can view and edit the list of all team members who worked, are working, or will work on all your events by going to **Events** > **Event** > **Event Team Members**. Use this area to set up a database of people who are available to help with your various events.
- You can view and edit the list of team members associated with a specific event by going to **Events** > **Event** > **Events**, opening the appropriate event, and looking at the **Event Team Members** section of the **Additional information** tab. The list on the **Events** page works the same as the list on the **Event Team Members** page, except that it only shows and adds team members who are assigned to the current event.

Each team member record can be associated with a contact or user record.

- *Users* are people who work for your organization and have a Dynamics 365 license.
- *Contacts* come from your contact database, which will include customers, potential customers, vendors, partners, and other external people (or internal people who don't use Dynamics 365).

When you create a new team member record, you'll be able to choose whether to associate it either with a user or a contact. If you choose to associate the record with a contact, the team-member record will display relevant information from that contact record. User records don't include any contact information, so if you associate the record with a user, the association will be shown but no additional information will be loaded. The team-member record also provides information about that member's role and which events he or she has worked on. You can create team members from either the **Event Team Members** list page or directly from a specific **Event** record.

When you're looking at a list view of team members, the list includes both a **User** and a **Contacts** column, but only one of these will show a value. From the list, you can go to the user or contact record by selecting the name in the list, or you can open the team-member record itself by double-clicking on a row anywhere away from the person's name.

## Manage event sessions and speakers

The core attractions of your event offering will typically be its sessions and speakers. A simple event might have just one session, whereas a conference will typically have several sessions spread over several days.

<a name="sessions"></a>

### Set up event sessions and tracks

A session represents a subdivision of things that are happening at your event. Each session is usually a something like a seminar or keynote, but the concept is actually quite flexible so you can adapt it as needed. For example, if your event is a trade show rather than a conference, you can use sessions to represent booths.

A large conference might have several sessions running concurrently, and might even feature several session *tracks*, which organize multiple related and non-conflicting sessions by audience so attendees can easily choose the best track for themselves without having to study the entire offering. Later, you'll be able up event and session passes to manage ticketing.

There are two types of tracks: _internal_ and _external_. Use internal tracks during the planning phase to group sessions along organization lines, such as according to team resources or required equipment. Use external tracks to group sessions by content or audience. External tracks are published on customer-facing platforms such as event websites and mobile apps. As needed, you can set up a pass type for each relevant external track, but you wouldn't set up passes for internal tracks. Use the **Track Type** setting, at the top of the form to set the track to internal or external.

Use the **Agenda** tab of an event record to view and set up sessions and sessions tracks for that event.

- Each session is associated with a specific event and speaker, and includes scheduling details. You can view, create, and edit sessions using either the [calendar display](marketing-calendar.md) or the table.
- Only live sessions and tracks are shown on the event website. When you're ready to go live with a session or track, open the relevant record and go live as described in [Publish events, sessions, tracks, and related records to the website](set-up-event-portal.md#publish-event).
- For each track, you can assign an audience and a few other descriptive details and then add member sessions, one at a time. All sessions in a track must be from the same event.

<a name="speakers"></a>

### Set up and assign session speakers

Use the following pages to manage your speakers and speaker engagements:

- **Events** > **Participants** > **Speakers**: Lists all speakers who are available for previous, current, or future events, and lets you set up new speakers.
- **Events** > **Event** > **Events**: Work on the **Agenda** tab of the appropriate event record to set up speaker engagements for that event. You can also create new speaker records here if needed while setting up speaker engagements.

Each speaker record can include a photo, contact details, and biographical details that you can eventually publish to the event website for attendees to review. It also includes a record of all speaking engagements and sessions where the speaker has presented or will present. You can choose to link a speaker to a contact record, but it's not required. The contact, photo, and biographical information in the speaker record is independent from the contact record, so you can safely keep private contact information (possibly stored in the contact record) away from the public speaker information (stored in the speaker record) that will be published to your event website. More information: [Set up the event website](set-up-event-portal.md)

When setting up a speaker engagement, you map a speaker to a specific session for the event record you are working with. To set up a speaker engagement:

- A speaker record must exist.
- If you're assigning a session, a session record must exist. (For single-session events, you might not have a session record and instead will treat the event itself as a session.)

<a name="event-passes"></a>

## Set up event passes

Event passes are essentially tickets that you can sell or give away to grant access to your event and/or its various sessions and tracks. Passes are optional, but if you want to use them, you'll start by setting up the basic types of passes that you need for an event and adding the applicable sessions to each of them. Later, you'll assign a pass of the appropriate type to each attendee by mapping each event registration to one or more pass types. Passes can also be shown on the event website, so attendees can register for the passes they want while registering for the event itself; in this case, the registration/pass mapping is made automatically. For each assigned pass, Dynamics 365 Marketing generates a unique QR code, which you can print onto a physical badge that event personnel can quickly scan on entrance to confirm eligibility and record attendance.

For each pass type, you'll set the event where it applies and then assign a category (attendee, speaker, sponsor, journalist, and so on), a price, an allocation (the number available), and other details. You can also assign a collection of one or more sessions for the pass, which grants access to all the sessions in that track, but not necessarily to all sessions at the event. 

For a simple event, you might set up just one pass type, which grants access to all sessions for all types of attendees. For a complex event, you might have passes for each of several session tracks, and might require specific pass types for accessing certain areas of the venue (such as a lounge just for journalists). Passes only make sense for physical attendees—you wouldn't set up passes for webinar-only attendees, events, or sessions.

To view and create passes for an event, open the appropriate event record and go to its **Registration & Attendance** tab. You can view, edit, and create passes by working in the **Passes** area here. To add sessions to a pass, first create and save it here, then open it for editing and use its **Eligible sessions** tab to add sessions to it.

> [!NOTE]
> You can add sessions to a pass individually or add an entire track at once. If you choose to add a track, all of the sessions that currently belong to that track will be added to your pass. However, when you add by track, you won't create a link to the track itself; instead, you just add all the sessions that currently belong to that track to the current pass. Future edits to the track won't affect the pass, so you must edit each existing pass specifically if you need to change the sessions that belong to it.

When setting up a pass, pay attention to the **Passes Allocated** field, where you set the number of passes available, and its related fields: **Passes Sold** and **Passes Remaining**. Each time a pass is granted to an attendee, the **Passes Sold** number automatically increases and the **Passes Remaining** number decreases. When **Passes Remaining** reaches zero, that pass will be shown on the event website as "sold out" and will no longer be available for purchase by further attendees. If you set **Passes Allocated** to zero, that pass won't be shown on the website at all; you might do this for VIP passes, or to keep a pass as a draft until you're ready to publish it by setting **Passes Allocated** to a positive value.

<a name="venues"></a>

## Set up the event venue

A venue is any physical location where you hold an event or session. It might be a single building with just one room, or one of several rooms in a building. For each venue, you can register many types of important details, including name, location, facilities, capacity, layout, events that will or have occurred there, and more. After you've set up a venue, you can assign events and sessions to it as needed.

Use the various types of venue entities in the **Events** > **Venue Management** area to construct a hierarchical model of your event location. Later, you'll be able to assign events and sessions to each venue space from your model. You only need to include as much detail as you need, so a simple building with just one room doesn't need to have any rooms defined for it, and a simple room with just one layout doesn't need to have any layouts defined for it. But you can't set up a room without a building or a layout without a room.

Use the following entities to model your venues:

- **Events** > **Venue Management** > **Buildings**: Buildings represent free-standing structures that might or might not be divided into rooms.
- **Events** > **Venue Management** > **Rooms**: Rooms represent subdivisions of buildings, and each must be assigned to a building record also stored in the system.
- **Events** > **Venue Management** > **Layouts**: During an event, you might use a single room to host several types of sessions, each of which might require a different arrangement of chairs and other facilities. The room layout might have practical consequences that affect, for example, seating capacity. Each layout must be associated with a particular room, but you can set up any number of layouts for each room.
