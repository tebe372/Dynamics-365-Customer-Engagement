---
title: Overview of the Customer Service Workspace application for Dynamics 365 Customer Service | Microsoft Docs
description: Overview of the Customer Service Workspace application for Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article 
ms.service: 
  dynamics-365-customerservice
ms.custom: 
  dyn365-customerservice
search.audienceType: 
  admin
  customizer
  enduser
search.app: 
  D365CE
  D365CS
  
---

# Customer Service workspace

Welcome to the Customer Service workspace app module, where we're increasing agent productivity for core customer service with the ability to work on multiple sessions at a time in a single workspace experience. If you choose to expand your customer service offering to provide chat and channels, the Customer Service workspace seamlessly adjusts to support managing conversations as well.

If you've used Customer Service Hub or Omnichannel for Customer Service before, much of the behavior for managing cases and activities in the Customer Service workspace app module works the same way, with some exceptions to accommodate the multisession and conversation capabilities. This article walks you through the Customer Service workspace experience and explains how to navigate the app.

Before we begin, a quick note about administration of Customer Service workspace: Currently, there isn't a dedicated administrator experience for Customer Service workspace. As such, configuring and managing core customer service capabilities, such as queues and routing rules, is done in the Customer Service Hub > [Service Management](https://docs.microsoft.com/dynamics365/customer-service/service-manager-guide) experience. Channel configuration is done in [Omnichannel Administration](https://docs.microsoft.com/dynamics365/omnichannel/administrator/omnichannel-administrator). Because all of these apps are on the [Common Data Service (CDS)](https://docs.microsoft.com/powerapps/maker/common-data-service/data-platform-intro), the data created through these experiences is accessible.

## Introduction to Customer Service workspace

You can access Customer Service workspace through the app selector (where you find all of your other Dynamics 365 apps) by choosing the Customer Service workspace app tile. You can also access the app in the Dynamics 365 drop-down navigation in the upper-left corner of Dynamics 365.

:::image type="content" source="media/appSelectorAndNavigation.png" alt-text="Open Customer Service workspace" border="false":::

As an agent with the Customer Service Representative security role, when you open Customer Service workspace, you start on the Customer Service Agent Dashboard unless your administrator has changed the default view. This dashboard shows you your active cases, cases you can work in queues you are assigned to, and your open activities. You can open existing cases and activities or begin working new cases from the queues you are assigned to and create activities. 

Let's explore the elements of the Customer Service workspace and how to navigate between them:


:::image type="content" source="media/csw-overview.png" alt-text="Customer Service workspace overview" border="false":::


| Label | Description|
| ------------ | ------------- |
| 1 | The session pane lists all of the sessions you are actively working on. Select the tabs to navigate between sessions. |
| 2 | The Home session returns you to the Customer Service Agent Dashboard view.|
| 3 | Each session has a tab in the session panel. Select a tab to navigate to the session you want to work on. |
| 4 | Select Shift + mouse click to open a new session for a case. A single click on a case replaces your view with the case form. Select the back arrow in the upper-left corner of the form to get back to your previous view.|
| 5 | Select the drop-down selector to filter cases in queues you can choose to work on. |
| 6 | Select the tabs to navigate to your open activities, cases, forms and views. |
| 7 | Select the + icon to expand the menu to view a list of forms, views, and activities. Select the one you want to open in a new tab. |
| 8 | Select Shift + mouse click to open a new session for an activity. A single click replaces your view with the activity form. Select the back arrow in the upper-left corner of the form to go back to your previous view. |
|||

### Viewing and editing records

There are new navigation behaviors to be aware of in Customer Service workspace. All other basic model-driven app functionality behaves the same way as it does in the Customer Service Hub and Omnichannel for Customer Service apps.

- Select Shift + mouse click to open a new session tab for the record you want to open. 
- Selecting the record replaces your view with the form for the record you opened. 
- Select the back arrow in the upper-left corner of the form to get back to your previous view. 
- Select Ctrl + mouse click to open items in a new tab. 

### Work with cases

From the Customer Service Agent Dashboard in Customer Service workspace, you can:

:::image type="content" source="media/bulkEditCases.png" alt-text="Customer Service workspace bulk edit case" border="false":::

|Label | Description|
|------------ | -------------|
| 1 | Select multiple cases to work with. Select the top check mark to select all cases, or select individual check boxes next to each case to select a specific group of cases.
| 2 | Associate child cases with selected cases. 
| 3 | Merge cases together. 
| 4 | Edit selected cases. 
| 5 | Delete selected cases. 
| 6 | Apply a routing rule to route cases to a queue. 
| 7 | Open the menu for additional actions including Assign, Add to Queue, Run Report, Email a Link, Share, Follow, or Unfollow cases. 


#### Editing case data

Let's explore the fields you can edit on the **Case Summary** tab:

:::image type="content" source="media/CaseSummary.png" alt-text="Customer Service workspace Case Summary" border="false":::

| Label | Description |
| ------------ | ------------- |
| 1 | In the Case Details, you can update the Case Title, Customer, Subject, Priority, Case Status, Product, and Description.
| 2 | These are attributes that are set when the case is created by the system including Case Number, Origin, and Created On Date that won't change. You can change the case owner here.
| 3 | Select the plus sign (+) on the timeline to expand the menu of timeline actions. 


Let's explore the fields you can edit on the **Case Additional Details** tab:

:::image type="content" source="media/CaseAddtlDetails.png" alt-text="Customer Service workspace Case Additional Details" border="false":::

| Label | Description |
| ------------ | ------------- |
| 1 | You can set Service Level Agreement (SLA) attributes on the case so that customer support managers can measure the overall success of the support organization against its goals of meeting customer Service Level Agreements.
| 2 | Associate a Parent Case, classify the Type of case, and apply a support Entitlement. 
| 3 | Sort and export the list of Associated Knowledge Articles.
| 4 | View and export the list of Similar Cases.
| 5 | View, add associations, and export Child Cases. 
| 6 | View and export the list of Merged Cases.


### Work with activities

From the Customer Service Agent Dashboard in Customer Service workspace, you can:

:::image type="content" source="media/bulkEditActivities.png" alt-text="Customer Service workspace bulk edit activities" border="false":::

| Label | Description|
------------ | -------------
| 1 | Select multiple activities to work with. Select the top check mark to choose all, or select individual check boxes next to each activity to select a specific group of activities.
| 2 | Edit selected activities. 
| 3 | Delete selected cases. 
| 4 | Open the menu for additional actions including Mark Complete, Cancel, Set Regarding, Assign, Email a Link, Add to Queue, Run Report. 
|

### Create and search knowledge articles

From the Customer Service Agent Dashboard in Customer Service workspace, you can access knowledge search and knowledge articles:

:::image type="content" source="media/knowledge-csw.png" alt-text="Customer Service workspace knowledge" border="false":::


|Label | Description|
|------------ | -------------|
| 1 | Select the plus sign (+) to expand the tab menu.|
| 2 | Select Knowledge Article or Knowledge Search. You can also create and manage knowledge articles in other ways. For more information, see [Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md).|


Intelligent knowledge suggestions are displayed in the productivity pane while working on a case. 

### Create email templates and signatures

From the Customer Service Agent Dashboard in Customer Service workspace, you can access email templates and signatures:

:::image type="content" source="media/email-csw.png" alt-text="Customer Service workspace email" border="false":::

| Label | Description
| ------------ | -------------
| 1 | Select the plus sign (+) to expand the tab menu. 
| 2 | Select Email Templates and Email Signatures.

### Productivity pane with Smart Assist

While working on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help agents better help customers. The productivity pane hosts Smart assist, which suggests related cases and knowledge articles that could be relevant to the current case, as well as agent scripts to guide agents through a consistent series of steps with potentially automated actions through macros. 

For more information, see [Productivity pane](csw-productivity-pane.md).

:::image type="content" source="media/productivity-pane-overview.png" alt-text="Productivity pane with Smart Assist" border="false":::

### See also

[Work with cases in Customer Service Hub](customer-service-hub-user-guide-create-a-case.md)
[Work with activities in Customer Service Hub](customer-service-hub-user-guide-manage-timeline-activities.md)
[Overview of the productivity pane](csw-productivity-pane.md)
