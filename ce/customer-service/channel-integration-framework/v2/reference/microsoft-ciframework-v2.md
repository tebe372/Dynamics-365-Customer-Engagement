---
title: "Microsoft.CIFramework (JavaScript API Reference) for Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information about the Microsoft.CIFramework JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 03/11/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Microsoft.CIFramework methods (Dynamics 365 Channel Integration Framework 2.0 JavaScript API reference)

Microsoft CIFramework provides methods to use JavaScript API to manage the communication panel (widget), notification, application tab, sessions, records, and forms in the Dynamics 365 model-driven app.

> [!Important]
> - The [CIFInitDone event handler](events/cifinitdone.md) must be invoked before calling the other APIs.
> - The time-out limit for the APIs is 10 seconds. If the APIs don't run within 10 seconds, they must be run again with changed parameters or scope.

## Communication panel management APIs

The communication panel is where you as an agent interact with the customer. Partner widgets built using Channel Integration Framework 2.0 are loaded in this panel. The widget in this version is displayed to the left of the session panel and supports Docked, Minimized, and Hidden modes.

Use the following APIs to manage the state of the communication panel (widget).

| Methods | Description |
|---------|-------------|
| [setWidth](microsoft-ciframework/setWidth.md) | [!INCLUDE[setWidth-description](microsoft-ciframework/includes/setWidth-description.md)] |
| [getWidth](microsoft-ciframework/getWidth.md) | [!INCLUDE[getWidth-description](microsoft-ciframework/includes/getWidth-description.md)] |
| [setMode](microsoft-ciframework/setMode.md) | [!INCLUDE[setMode-description](microsoft-ciframework/includes/setMode-description.md)] |
| [getMode](microsoft-ciframework/getMode.md) | [!INCLUDE[getMode-description](microsoft-ciframework/includes/setMode-description.md)] |

## CRUD operations APIs

Use the following APIs to perform CRUD operations on entity records.

| Methods | Description |
|---------|-------------|
| [createRecord](microsoft-ciframework/createRecord.md)| [!INCLUDE[createRecord-description](microsoft-ciframework/includes/createRecord-description.md)] |
| [retrieveRecord](microsoft-ciframework/retrieveRecord.md) | [!INCLUDE[retrieveRecord-description](microsoft-ciframework/includes/retrieveRecord-description.md)] |
| [updateRecord](microsoft-ciframework/updateRecord.md) | [!INCLUDE[updateRecord-description](microsoft-ciframework/includes/updateRecord-description.md)] |
| [deleteRecord](microsoft-ciframework/deleteRecord.md) | [!INCLUDE[deleteRecord-description](microsoft-ciframework/includes/deleteRecord-description.md)] |

## Notification management APIs

| Methods | Description |
|---------|-------------|
| [notifyEvent](microsoft-ciframework/notifyEvent.md)| Displays a notification that can be used to inform agent about an incoming conversation. |

## Application tab management APIs

These APIs enable you to create and manage the state of an application tab.

| Methods | Description |
|---------|-------------|
| [createTab](microsoft-ciframework/createtab.md) | Creates a tab in a focused session and returns the unique identifier of the created tab. |
| [getTabs](microsoft-ciframework/gettabs.md) | Returns an array of tab Ids associated with template name or template tags for tabs in the session in focus, if the session belongs to the channel provider.|
| [focusTab](microsoft-ciframework/focustab.md) | Sets the focus on a tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.|
| [getFocusedTab](microsoft-ciframework/getfocusedtab.md) | Returns the focused tab's tabId in focused session, if the session belongs to the provider.|
| [refreshTab](microsoft-ciframework/refreshtab.md) | Refreshes the tab. |
| [setTabTitle](microsoft-ciframework/settabtitle.md) | Sets the title of the tab, if the focused session belongs to the channel provider and if the tab belongs to the session in focus.|

## Session management APIs

These APIs allow you to manage sessions in a multisession provider environment.

| Methods | Description |
|---------|-------------|
| [canCreateSession](microsoft-ciframework/cancreatesession.md) | Allows you to check if a new session can be created. |
| [createSession](microsoft-ciframework/createsession.md) | Creates a session based on the session template defined as part of the template and returns the unique identifier of the session (Id) that was created. |
| [getSession](microsoft-ciframework/getsession.md) | Returns an object containing the unique identifier of the session, context and the value of isFocused parameter, in case the session belongs to the channel provider. |
| [getFocusedSession](microsoft-ciframework/getfocusedsession.md) | Returns the unique identifier of the session that is in focus, if it belongs to the channel provider else returns null. |
| [getAllSession](microsoft-ciframework/getallsessions.md) | Returns the array of Session Ids for a given provider. |
| [setSessionTitle](microsoft-ciframework/setsessiontitle.md) | Sets the session title, if the session belongs to the channel provider. |
| [requestFocusSession](microsoft-ciframework/requestFocusSession.md) | Sets the focus on the session whose Session Id is passed as a parameter, if the session belongs to the channel provider. |

## Channel analytics APIs

Channel Analytics APIs enable you to track event analytics.

| Methods | Description |
|---------|-------------|
| [initLogAnalytics](/dynamics365/customer-service/channel-integration-framework/v2/reference/updateConversation) | Invoke this method on an incoming conversation to log analytics.|
| [logAnalyticsEvent](microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events.|

## Session indicator APIs

Session indicator APIs indicate a KPI breach and can be used to update the number of new activities in a particular session.

| Methods | Description |
|---------|-------------|
| [notifyKpiBreach](microsoft-ciframework/notifyKPIBreach.md) | This method is used to indicate a KPI breach. When this KPI is used, a red circle appears on the display image of the contact when a KPI breach has occurred.|
| [notifyNewActivity](microsoft-ciframework/notifyNewActivity.md) | This method is used to update the number of new activities in a particular session.|

## Miscellaneous methods

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
| [updateContext](microsoft-ciframework/updateContext.md) | This method allows you to set the automation dictionary. |

### See also

[What's new in Dynamics 365 Channel Integration Framework](../../whats-new-channel-integration-framework.md)  
[System requirements of Dynamics 365 Channel Integration Framework](../../system-requirements-channel-integration-framework.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
