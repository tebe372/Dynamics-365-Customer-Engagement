---
title: "Microsoft.CIFramework (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# Microsoft.CIFramework methods (CIF JavaScript API reference)

Provides methods to use JavaScript API to manage the channel (widget), notifications, application tab, records, and forms in the Dynamics 365.

## Communication Panel Management APIs

The Communication Panel is where you, as an agent, interact with the customer. Partner widgets built using Channel Integration Framework version 2.0 are loaded in this panel. The communication widget in this experience has following key differences as compared to version 1.0 based widgets.

| Version 2.0 | Version 1.0 |
|---------|---------|
| Communication panel is displayed to the left of the session panel. | Communication panel is displayed to the right of the screen. |
| Communication panel supports Docked, Minimized and Hidden modes | Communication panel supports Docked and Minimized modes |

You can use the APIs mentioned below to manage the state of the communication panel(widget).

| Methods | Description |
|---------|-------------|
| [setWidth](microsoft-ciframework/setWidth.md) | [!INCLUDE[setWidth-description](microsoft-ciframework/includes/setWidth-description.md)] |
| [getWidth](microsoft-ciframework/getWidth.md) | [!INCLUDE[getWidth-description](microsoft-ciframework/includes/getWidth-description.md)] |
| [setMode](microsoft-ciframework/setMode.md) | [!INCLUDE[setMode-description](microsoft-ciframework/includes/setMode-description.md)] |
| [getMode](microsoft-ciframework/getMode.md) | [!INCLUDE[getMode-description](microsoft-ciframework/includes/setMode-description.md)] |

## CRUD Operations APIs

These APIs enable you to perform CRUD operations on entity records.

| Methods | Description |
|---------|-------------|
| [createRecord](microsoft-ciframework/createRecord.md)| [!INCLUDE[createRecord-description](microsoft-ciframework/includes/createRecord-description.md)] |
| [retrieveRecord](microsoft-ciframework/retrieveRecord.md) | [!INCLUDE[retrieveRecord-description](microsoft-ciframework/includes/retrieveRecord-description.md)] |
| [updateRecord](microsoft-ciframework/updateRecord.md) | [!INCLUDE[updateRecord-description](microsoft-ciframework/includes/updateRecord-description.md)] |
| [deleteRecord](microsoft-ciframework/deleteRecord.md) | [!INCLUDE[deleteRecord-description](microsoft-ciframework/includes/deleteRecord-description.md)] |

## Notification Management APIs

| Methods | Description |
|---------|-------------|
| [notifyEvent](microsoft-ciframework/notifyEvent.md)| Displays a notification that can be used to inform agent about an incoming conversation. |

## Application Tab Management APIs

These APIs enable you to create and manage the state of an application tab.

| Methods | Description |
|---------|-------------|
| [createTab](microsoft-ciframework/createtab.md) | Creates a tab in a focused session and returns the unique identifier of the created tab. |
| [getTabs](microsoft-ciframework/gettabs.md) | Returns an array of tab Ids associated with template name or template tags for tabs in the session in focus, if the session belongs to the channel provider.|
| [focusTab](microsoft-ciframework/focustab.md) | Sets the focus on a tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.|
| [getFocusedTab](microsoft-ciframework/getfocusedtab.md) | Returns the focused tab's tabId in focused session, if the session belongs to the provider.|
| [refreshTab](microsoft-ciframework/refreshtab.md) | Refreshes the tab. |
| [setTabTitle](microsoft-ciframework/settabtitle.md) | Sets the title of the tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.|

## Session Management APIs

These APIs allow you to manage sessions in a multi-session provider environment.

| Methods | Description |
|---------|-------------|
| [canCreateSession](microsoft-ciframework/cancreatesession.md) | Allows you to check if a new session can be created. |
| [createSession](microsoft-ciframework/createsession.md) | Creates a session based on the session template defined as part of the template and returns the unique identifier of the session (Id) that was created. |
| [getSession](microsoft-ciframework/getsession.md) | Returns an object containing the unique identifier of the session, context and the value of isFocused parameter, in case the session belongs to the channel provider. |
| [getFocusedSession](microsoft-ciframework/getfocusedsession.md) | Returns the unique identifier of the session that is in focus, if it belongs to the channel provider else returns null. |
| [getAllSession](microsoft-ciframework/getallsessions.md) | Returns the array of Session Ids for a given provider. |
| [setSessionTitle](microsoft-ciframework/setsessiontitle.md) | Sets the session title, if the session belongs to the channel provider. |
| [requestFocusSession](microsoft-ciframework/requestFocusSession.md) | Sets the focus on the session whose Session Id is passed as a parameter, if the session belongs to the channel provider. |

## Channel Analytics APIs

Channel Analytics APIs enable you to track event analytics.

| Methods | Description |
|---------|-------------|
| [initLogAnalytics](microsoft-ciframework/initLogAnalytics.md) | Invoke this method on an incoming conversation to log analytics.|
| [logAnalyticsEvent](microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events.|

## Miscellaneous Methods

| Methods | Description |
|---------|-------------|
| [getEntityMetadata](microsoft-ciframework/getEntityMetadata.md) | [!INCLUDE[getEntityMetadata-description](microsoft-ciframework/includes/getEntityMetadata-description.md)] |
| [setClickToAct](microsoft-ciframework/setClickToAct.md) | [!INCLUDE[setClickToAct-description](microsoft-ciframework/includes/setClickToAct-description.md)] |
| [getClickToAct](microsoft-ciframework/getClickToAct.md) | [!INCLUDE[getClickToAct-description](microsoft-ciframework/includes/getClickToAct-description.md)] |
| [searchAndOpenRecords](microsoft-ciframework/searchAndOpenRecords.md) | [!INCLUDE[searchAndOpenRecords-description](microsoft-ciframework/includes/searchAndOpenRecords-description.md)] |
| [getEnvironment](microsoft-ciframework/getEnvironment.md) | [!INCLUDE[getEnvironment-description](microsoft-ciframework/includes/getEnvironment-description.md)] |
| [openForm](microsoft-ciframework/openForm.md) | [!INCLUDE[openForm-description](microsoft-ciframework/includes/openForm-description.md)] |
| [renderSearchPage](microsoft-ciframework/renderSearchPage.md)| [!INCLUDE[openForm-description](microsoft-ciframework/includes/renderSearchPage-description.md)] |
| [addHandler](microsoft-ciframework/addHandler.md) | [!INCLUDE[addHandler-description](microsoft-ciframework/includes/addHandler-description.md)] |
| [removeHandler](microsoft-ciframework/removeHandler.md) | [!INCLUDE[removeHandler-description](microsoft-ciframework/includes/removeHandler-description.md)] |
| [updateContext](microsoft-ciframework/updateContext.md) | This method allows you to set automation dictionary. |

## See also

[What's new in Channel Integration Framework](../whats-new-channel-integration-framework.md)<br />
[System requirements for Channel Integration Framework](../system-requirements-channel-integration-framework.md)
