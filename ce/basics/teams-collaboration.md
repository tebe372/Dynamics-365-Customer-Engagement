---
title: "Collaborate with Teams| MicrosoftDocs"
ms.custom: ""
description: "Collaborate with team members using the Dynamics 365 for Customer Engagement app for Teams."
ms.date: 11/06/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 17
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Collaborate with Teams

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Once installed, the Dynamics 365 for Customer Engagement app for Teams enables collaborating with others through Dynamics 365 for Customer Engagement (online) record connections made in teams and channels in Microsoft Teams.

## Connect a Dynamics 365 for Customer Engagement (online) record to a team channel

From a team channel, you can connect a Dynamics 365 for Customer Engagement (online) record to collaborate on a customer account, an opportunity, and so on as follows.

1. Open a team channel and select the **Add** button (![Add button](media/plus-2.png "Add button")).

   > [!div class="mx-imgBorder"]
   > ![Select Add button](media/teams-add-tab.png "Select Add button")

2. Select the **Dynamics 365 for Customer Engagement** icon to pin a Dynamics 365 for Customer Engagement (online) record to a channel.

   > [!div class="mx-imgBorder"]
   > ![Add Dynamics 365 for Customer Engagement Team channel](media/teams-add-channel.png "Add Dynamics 365 for Customer Engagement Team channel")

3. Search for an entity to connect. You can pick a recently viewed record or use search to find records. You can use **Filter by** to narrow the search to an entity type. Once you've picked a record, select **Save**.

   > [!div class="mx-imgBorder"] 
   > ![Search for entity](media/teams-add-channel-pin-record2.png "Search for entity")

   In the above page, if you have multiple organizations or app modules, you can change the org and app module by selecting **Edit** (![Edit](media/edit-icon.png "Edit")) to specify which org or app module to use in Teams.
 
   > [!div class="mx-imgBorder"] 
   > ![Specify org and app](media/teams-change-org-app.png "Specify org and app")

   You can enable **Remember this preference** to set the org and app selections to be the default personal dashboard that appears when you select **My Dashboard**.

   You can return to these settings any time by selecting the **Settings** tab.

Once you complete the above steps, you'll see a notification of a successful connection and the Dynamics 365 for Customer Engagement (online) record appears in the menu bar. You can interact with the record as if you were using the Dynamics 365 for Customer Engagement web app. Those with Write permissions can edit the record. Changes will be synchronized with the Dynamics 365 for Customer Engagement web app.

> [!div class="mx-imgBorder"] 
> ![Record successfully connected and pinned](media/teams-pinned-record.png "Record successfully connected and pinned")

The following section provides information about connections between Dynamics 365 for Customer Engagement (online) and Microsoft Teams.

### Two connection states

There are two connection states possible when connecting Dynamics 365 for Customer Engagement (online) and Microsoft Teams: successful and failed. 

The successful connection state indicates that the connection was successfully saved in Dynamics 365 for Customer Engagement (online) so that the link to the connected Microsoft Teams channel appears on the Dynamics 365 for Customer Engagement (online) page and the files used on this channel also appear on the **Documents** tab in Dynamics 365 for Customer Engagement (online). 

A failed connection means the connection was not successfully saved. When seeing this message, you should remove and connect the record again. See: [Error: This record is not connected to Dynamics 365 for Customer Engagement. Repin the tab and try again.](teams-troubleshoot.md#error-this-record-is-not-connected-to-dynamics-365-repin-the-tab-and-try-again)


### View and associate files

> [!NOTE]
> This feature is currently only available for organizations in the North American region.

Select the  **Files** tab in the connected Teams channel to associate files with a Dynamics 365 for Customer Engagement (online) record. Files added here will appear in Dynamics 365 for Customer Engagement (online) under **Documents** for the linked record. Likewise, when you add a document to a record in Dynamics 365 for Customer Engagement (online), that document will appear in Teams under the **Files** tab.

> [!div class="mx-imgBorder"] 
> ![Files tab in Teams app](media/teams-files-tab.png "Files tab in Teams app")

### Open a record in Dynamics 365 for Customer Engagement (online)

It's easy to use Teams to open a record in Dynamics 365 for Customer Engagement (online). From a record pinned in a Teams channel, select the **Go to website** button to open the record in Dynamics 365 for Customer Engagement (online).

> [!div class="mx-imgBorder"] 
> ![Open a record in Dynamics 365 for Customer Engagement (online)](media/teams-open-record-d365.png "Open a record in Dynamics 365 for Customer Engagement (online)")

### Have a conversation
You can chat with your team members side-by-side with the Dynamics 365 for Customer Engagement record page. From a record pinned in a Teams channel, select the **Show tab converation** button to open the conversation tab.

> [!div class="mx-imgBorder"] 
> ![Start a conversation](media/teams-start-conversation.png "Start a conversation")

## Teams integration in Dynamics 365 for Customer Engagement (online)

> [!NOTE]
> This feature is currently only available for organizations in the North American region.

In Dynamics 365 for Customer Engagement (online), you can see the connected Microsoft Teams channel and files from the Microsoft Teams channel.

In Dynamics 365 for Customer Engagement (online) records, select **Collaborate** to display a list of all the connected team channels. Then, select a team channel to go to the relevant channel conversation in Teams.

> [!div class="mx-imgBorder"] 
> ![From Dynamics 365 for Customer Engagement, open a conversation in Teams](media/teams-select-collaborate.png "From Dynamics 365 for Customer Engagement, open a conversation in Teams")

In addition, document management actions in Dynamics 365 for Customer Engagement (online) are integrated with Teams. You can see the channel file library in Dynamics 365 for Customer Engagement (online) and directly upload files; uploaded files will appear in the Teams channel file library under the **Files** tab. Files uploaded in the Teams app will appear in the **Documents** tab in Dynamics 365 for Customer Engagement (online).

> [!div class="mx-imgBorder"] 
> ![Dynamics 365 for Customer Engagement document management in Teams](media/teams-documents-d365.png "Dynamics 365 for Customer Engagement document management in Teams")

### If you see this message: Shared files exist in multiple locations. Select "Document Location" to see files in other locations.

> [!div class="mx-imgBorder"] 
> ![Shared files in multiple locations](media/teams-error-multiple-locations.png "Shared files in multiple locations")

When there is more than one Microsoft Teams channel connected to a Dynamics 365 for Customer Engagement (online) record, each of the channels appears as a separate document location in Dynamics. You can switch to a different location by selecting **Document Location** to specify the location of the file.

> [!div class="mx-imgBorder"] 
> ![Change document location](media/teams-change-document-location.png "Change document location")

### Record types supporting Collaborate    

Currently, the following record types support using **Collaborate**. The **Collaborate** button will only appear for record types listed below.

- account
- annotation
- appointment
- businessunit
- campaign
- category
- competitor
- contact
- email
- incident
- kbarticle
- knowledgearticle
- lead
- opportunity
- opportunityproduct
- product
- quote
- salesorder
- task
- team

### See also  
 [Install the app and set up the Teams tab](teams-install-app.md#install-the-app-and-set-up-the-teams-tab)

