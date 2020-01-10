---
title: "Create segments and lists to establish target markets (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to create segments and lists that you can use to target customer journeys and manage subscriptions in Dynamics 365 Marketing"
ms.date: 10/04/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 2ff81085-af7a-455b-857a-0aa0ade61416
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

# Working with segments

Use segments to establish groups of related contacts that you can target with your customer journeys. You'll create them using the segmentation designer, which enables you to query across multiple related entities, including contacts, leads, accounts, events, marketing lists, and more. It also enables you to query the marketing-insights service to find contacts that have shown engagement with your marketing initiatives, or contacts that you may be failing to reach (due to issues such as email bounces).

The segment designer resemble other querying tools found in Dynamics 365 (such as the advanced-find feature), but is often more flexible and more powerful. It's also the only tool that lets you query interaction records from the marketing-insights service.

> [!NOTE]
> *Marketing segments* are different than *marketing lists*. More information: [Marketing segments vs. marketing lists](segments-vs-lists.md)

## Segments in Dynamics 365 Marketing

A market segment is the collection of contacts that you target with a customer journey. In some cases, you'll simply target all the contacts you have, but in most cases, you'll choose who you want to target based on demographic or firmographic data and other considerations. For example, if you're opening a new store in San Francisco, you'll probably promote the opening-day event at that store only to contacts who live near San Francisco. Or if you're running a sale on dresses, you might only send related marketing email messages to your contacts who are female. Decisions like these will typically also affect the way you communicate with the segment in terms of which channels you'll choose, what kind of graphics you'll pick, which kinds of arguments you make, and more.

Dynamics 365 Marketing uses segments to target customer journeys. Most customer journeys start with a segment tile, which establishes the collection of contacts who will experience that journey. You can combine multiple segments here.

<a name="segment-types"></a>

### Types of segments

Segments can be dynamic, static, or compound.

- *Dynamic segments* are set up by using logical expressions, such as "all contacts from New York" or "all contacts who like The Mets." Membership in dynamic segments changes constantly to reflect new or removed contacts and updated contact information. Both demographic and firmographic segments are examples of dynamic segments.
- *Static segments* establish a static list of contacts who are selected on a per-contact basis rather than created logically based on field values. Marketers and salespeople might create and populate a static list based on private knowledge or offline interactions.
- *Compound segments* combine existing (live) segments using logical operators.

Segments can also be based either on profiles or interactions.

- *Profile segments* query the _profile_ records stored in the marketing-insights service. Profiles records are synced between your Dynamics 365 organizational database and the marketing-insights service, and include the entities you normally work with in the Dynamics 365 UI, such as contacts, accounts, leads, and any other entities that you [choose to sync](mkt-settings-sync.md).
- *Behavioral segments* query the _interaction_ records stored in the marketing-insights service. Each of these records is generated automatically and related to a specific contact record. Interaction records are accessed to generate various insights displays in the Dynamics 365 Marketing UI, but they _aren't_ synced to the Dynamics 365 organizational database. They are generated in response to contact interactions such as opening an email, clicking an email link, submitting a form, or registering for an event.

### Segments are synced with the marketing-insights service

Dynamics 365 Marketing works together with the marketing-insights service, which operates using its own marketing-insights database to provide advanced segment definitions and customer analytics. The integration is seamless and results in powerful combined functionality when the two systems work together. Your contact records and marketing lists are continuously synchronized between the two systems, which lets the marketing-insights service apply its powerful data processing and analytical tools to your contacts, and combine these with information from other types of Dynamics 365 records.

> [!IMPORTANT]
> The marketing-insights service processes changes to segment membership asynchronously, which means you can't predict the order in which changes are processed. In some cases, such as when processing very large databases, it can take up to six hours for a given segment to get updated. You therefore can't rely on any one segment being processed before or after a specific other segment, so be careful when orchestrating related campaigns and/or using  [suppression segments](customer-journeys-create-automated-campaigns.md#suppression-segment).

### Segments must be live before you can use them

When you first create a new segment, it is in a _draft_ state, which means that it is unlocked, so you can work with its definition and other settings, but you won't be able to use it in customer journeys or compound segments. When you are ready to use your segment, you must open it and select **Go Live** from the command bar, which enables it and moves to the _live_ state.

> [!IMPORTANT]
> While you are designing your segment, you can select the **Get estimated segment size** link to get an *estimate* for the number of contacts that will be included in the segment. Usually the estimate will be exact, but sometimes the final size may vary slightly (you must go live with the segment to view its exact size and membership).

If you need to edit a segment after it has gone live, open it and then select **Stop** from the command bar to put it back into the draft state.

More information: [Go live with publishable entities and track their status](go-live.md)

## View and manage your segments

To work with your segments, go to **Marketing** > **Customers** > **Segments**. This opens a standard list view, which you can use to search, sort, filter, create, and delete your segments. Open any segment to view its details, or select **New** to create a new one.

<a name="create-segment"></a>

## Create and go live with a new segment

Read this section to get a basic overview of how to create a segment and start it running so you can see its members and use it to target a customer journey.

1. Go to **Marketing** >**Customers** > **Segments** to open a list of current segments.

1. Select **New** to start creating your new segment.

1. The **Segment template** dialog box opens, showing a list of available [templates](segments-templates.md). Each template provides a fully or partially defined query designed for a particular purpose, as indicated by the template name. Select any template to read more information about it in the information panel. **Filter** and **Search** features are provided to help you find the template you're looking for. Select a listed template and then choose **Select** to load the that template, or choose **Cancel** to start building a new segment from scratch.

    ![Choose a segment template](media/segment-choose-template.png "Choose a segment template")

1. If you selected a template, then your template loads and you skip this step. If you selected **Cancel** on the **Segment template** dialog, the designer now  asks you to choose which type of segment you want to create. This selection will establish the initial structure of your segment and also affects the user interface you'll see for working with it. Read the names and descriptions shown, and choose one of the following to get started:

    - **Demographic**: Creates a dynamic profile segment prepared to query contact records directly, but you can still add relations as needed to create a query of arbitrary complexity. For details about how to work with this kind of segment, see [Design a demographic or firmographic segment](segments-profile.md)
    - **Firmographic**: Creates a dynamic profile segment prepared with a relation to the accounts entity already in place. Other than this, this is the same as selecting **Demographic**. For details about how to work with this kind of segment, see [Design a demographic or firmographic segment](segments-profile.md)
    - **Behavioral**: Creates a behavioral segment, which queries interaction records from the marketing-insights service to find contacts that have interacted in specific ways with your marketing initiatives, such as by opening an email, clicking a link, or visiting a web page. For details about how to work with this kind of segment, see [Design behavioral segments](segments-interaction.md)
    - **Static**: Creates a segment where you manually select each member rather than creating a logical query. For details about how to work with this kind of segment, see [Design static segments](segments-static.md)
    - **Combined audiences**: Creates a compound segment, which combines any number of existing segments union, exclude, and/or intersect operators. For details about how to work with this kind of segment, see [Combine segments into a compound segment (combined audiences)](segments-compound.md)
    - **Segment template**: If you'd like to load a template after all, then choose the **Select item** button ![Name your segment](media/select-item-button.png "Name your segment") here to open the **Segment templates** dialog box, which is described in the previous step.

    ![Choose a segment type](media/segment-hub.png "Choose a segment type")

1. The segment designer opens, showing settings and tools that are appropriate for your selection or template. Start by naming your segment. Select the expansion button at the side of the header area to expand a drop-down dialog where you can make a few key settings. Use it to enter a **Name** for your new segment.

    ![Name your segment](media/segment-enter-name.png "Name your segment")

1. Select **Save** on the toolbar to save your segment.

1. Use the tools provided by the designer to establish your segment membership criteria, as described elsewhere in this topic, for your selected segment type.

1. When you're done designing the segment, select **Go live** on the toolbar to start running the segment, find all of its members (as needed), and make it available for use with your customer journeys. Once your segment is live, it will include a **Members** tab, where you can go to see exactly which contacts are part of the segment.

## Tabs and settings for segments

After you have created a new segment and selected its initial type (as Described in the previous section), you'll also see any time you edit an existing segment. It provides several tabs for describing, defining, and reviewing the segment. Tabs are shown as a set of headings under the header, which shows the name of the segment. Select any of these headings to go to the relevant tab. Each tab is described briefly in the following subsections.

### The Definition tab

Use the **Definition** tab to establish membership of the segment. For dynamic segments, you'll get a query builder here. For static segments, you'll select specific contacts one at a time. For compound segments, you'll create logic for combining existing segments here. For more information about how to build your segment definition using this tab, see the following topics:

- [Design dynamic demographic or firmographic segments](segments-profile.md)
- [Design behavioral segments](segments-interaction.md)
- [Define a static segment](segments-static.md)
- [Combine segments into a compound segment](segments-compound.md)

### The General tab

The **General** tab provides a few basic settings and general information about the segment. Many of the values here are established when you first create the segment and then become read only. Some fields are only present if your application is configured to use them. All fields are read-only when the segment is live. The fields you see may include some or all of the following:

- **Name**: The name of the segment as it appears in the segment list and when selecting segments for a customer journey.
- **Created on**: The date the segment was created.
- **Segment Type**: Shows the [segment type](#segment-types) (dynamic, static, or compound). This is permanently established when you first [create the segment](#create-segment).
- **External source**: For segments that are synced from an external source, such as Dynamics 365 Customer Insights, information about the external source is shown here.
- **External segment URL**:  For segments that are synced from an external source, such as Dynamics 365 Customer Insights, the URL of the external source is shown here.
- **Query type**: Shows the [query type](#segment-types) (profile or interaction). This is permanently established when you first [create the segment](#create-segment).
- **Activation status**: Shows whether the segment is draft or live. Only live segments are available for use in customer journeys and compound segments. (This is also referred to as the **Status reason**.)
- **Owner**: Shows the name of the user who owns the segment.
- **Scope**: This setting only appears when business-unit scopes are enabled for your instance. When scopes are enabled, this can have a setting of **Business unit** or **Organization**, but only privileged users (such as managers or admins) will be able to change it.  When set to **Business unit**, the segment will only contain contacts that belong to the same business unit as the segment owner, even when the query would normally find more contacts than this. When set to **Organization**, the segment will contain all contacts that match the query, regardless of who owns the contacts or the journey. When this feature is disabled, the segment behaves as though it were set to **Organization**. More information: [Use business units to control access to Marketing records](business-units.md)
- **Description**: A description of the segment.
- **Members**: The number of contacts that are currently included in the segment.

### The Members tab

The **Members** tab is only shown after you segment has gone live at least once. Use it to see which contacts are part of the segment. It typically takes a few minutes for the **Members** tab to populate after you go live with a segment.

### The Insights tab

Many types of entities, including segments, show a tab labelled **Insights**  after a record has gone live at least once. This tab shows results, analytics, KPIs and other information about how that record has been used and how contacts have interacted with it. More information: [Analyze results to gain insights from your marketing activities](insights.md)

### The Related tab

Almost all types of entities in Dynamics 365 Marketing include a **Related** tab. Use it to find records that are related to the currently open record. This "tab" is really just a drop-down list where you can select the type of related records you'd like to see. On selecting a record type (entity), a new tab named for that entity is added to the page, where you can see a list of the related records of the selected type. When you select a new entity from the **Related** tab, it replaces the one currently shown.

> [!NOTE]
> The **Related** tab for segments sometimes includes an entry for **Customer journeys**, but this entry only finds journeys where the current segment is a *suppression segment*. It doesn't find journeys that use the current segment as a target segment. The reason for this is that suppression segments are related directly to the customer journey entity, while target segments are linked to journeys less directly, through a tile configuration, and therefore aren't resolved in the **Related** tab.

### See also

[Work with segment templates](segments-templates.md)  
[Create a segment](create-segment.md)  
[Set up subscription lists and subscription centers](set-up-subscription-center.md)  
[Go live with publishable entities and track their status](go-live.md)
