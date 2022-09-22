---
title: Overview of the Customer Service workspace application for Dynamics 365 Customer Service
description: Overview of the Customer Service workspace application for Dynamics 365 Customer Service.
ms.date: 07/05/2022
ms.topic: overview
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Get started with Customer Service workspace
The Dynamics 365 Customer Service workspace helps increase agent productivity with a browser-like tab experience that lets agents work on multiple cases and conversations using the same app. It's a modern, customizable, high-productivity application that allows agents to work on multiple sessions at a time in a single workspace. The application leverages artificial intelligence in productivity tools like Smart Assist to identify similar cases and relevant articles, thereby boosting agent velocity.
Features such as agent scripts and macros provide agents guidance and resources to automate repetitive tasks to achieve a great customer experience.

For more information about licensing and system requirements: [Customer Service workspace system requirements](customer-service-workspace-system-requirements.md)

**Engage in cases and conversation in the Customer Service workspace** 

You can set up your Customer Service workspace environment so that agents working on cases can also engage with customers via channels like Live Chat, voice, and SMS without leaving the app with he Omnichannel for Customer Service add-on [license](https://dynamics.microsoft.com/en-us/customer-service/overview/#pricing). For more information: [Set up Omnichannel for Customer Service channels in Customer Service workspace](csw-enable-channels.md)

## Access the Customer Service workspace layouts

Access Customer Service workspace through the app selector where you find other Dynamics 365 apps. Or, select it in the drop-down navigation in the upper-left corner of Dynamics 365.

By default, Customer Service workspace opens in the Customer Service Agent Dashboard view. The dashboard shows your active cases, cases you can work on in queues that you're assigned to, and your open activities. You can open existing cases and activities, work on new cases and activities, and create cases and activities.

The Customer Service workspace app currently supports two layouts:

- Default workspace
- Enhanced multisession workspace(recommended) 

You can switch to the enhanced layout with the following steps:

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press Enter: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultiSessionLayoutImprovements",true)`
1. Refresh the app page.

> [!NOTE]
> If you turn on the enhanced multisession workspace, the enhanced experience applies in both Customer Service workspace and Omnichannel for Customer Service.

The following table provides an overview of the layouts:

| Default workspace | Enhanced multisession workspace |
| ------------ | ------------- |
|  :::image type="content" source="media/csw-overview.png" alt-text="Screenshot of the default Customer Service workspace, with items labeled according to the legend in the table" lightbox="media/csw-overview.png"::: | :::image type="content" source="media/csw-overview-enhanced.png" alt-text="Screenshot of the enhanced multisession Customer Service workspace, with items labeled according to the legend in the table" lightbox="media/csw-overview-enhanced"::: |
| 1. Select the **Home** icon to return to the Customer Service Agent Dashboard view.<br>2.The session pane shows all the sessions you've opened. Select the icons to navigate between sessions.<br>3.Select the **+** icon in the tab bar to open more workspaces in a new tab. If you hold the Ctrl key while you select a case or an activity, the case or activity opens in a new tab, too. Select a tab to navigate between sessions.<br>4. Select the arrow to choose a different view.<br>5. Select a case or an activity to open a new session. The session replaces your current view with the case form.<br>6. Select the back arrow in the upper-left corner of the form to get back to your previous view. To open the case or activity in a new tab, hold the Ctrl key while you select it.<br>7. Select the arrow to view a different dashboard.  | 1. Select the icon to open the site map. <br>2. Select the **Home** tab to return to the Customer Service Agent Dashboard view.<br> 3. Select the [**Inbox**](#use-the-inbox) tab to view all the cases and conversations that are assigned to you. You'll only see the inbox if it's turned on for your profile. <br> 4. Each open session has a tab in the tab row. Select a tab to navigate between sessions.<br> 5. Select a case or an activity to open a new session. The session opens in a new tab in the workspace window. <br> 6. Select the arrow to choose a different view.<br> 7. Select the arrow to view a different dashboard. |

## Customer Service workspace sessions and tabs

Customer Service workspace allows agents to work on multiple sessions at a time in a single app while keeping the work organized.
When an agent opens a case from the Home session or when the agent accepts an incoming conversation, a new session will be launched. 
If the agent opens the customer record from a given session, a new tab will be launched in the same session. 

### Navigate sessions and tabs

The following table gives an overview of the navigation in both views :

| Column | Default | Enhanced multisession workspace |
| ------------ | ------------- | ------------- |
| Select a record from the Home session | Record opens in a new session | Record opens in a new session |
| Select a record from the Global search | Record opens in a new tab | Record opens in a new tab |
| Select a record from the retrieved search records | Record opens in a new tab | Record opens in a new tab |
| Create a record via Quick Create form | Record opens in a new tab | Record opens in a new session |
| Create a new record | Record opens in a new session | Record opens in a new session |
| Select a record from the timeline | Record opens in a new tab | Record opens in a new tab |
| Select a record from the timeline | Record opens in a new tab | Record opens in a new tab |
| Select an entity from the Sitemap | Record opens in a new tab | Record opens in a new tab |

The Enhanced multisession workspace also has improved in-app notification integration.

## Use the Inbox

 If your administrator has turned on the inbox for your profile, you can select the **Inbox** tab to view all the cases, conversations, and activities that are assigned to you. Use the inbox to work on high-velocity tasks. You can also promote inbox sessions to regular sessions when you need more time to resolve a case or complete a conversation.

The following asynchronous channels are available in the conversation inbox: SMS, persistent chat, Facebook, Twitter, WeChat, LINE, WhatsApp, and Teams.

The inbox conversation view looks as seen in the following screenshot.

:::image type="content" source="media/inbox-csw.png" alt-text="Screenshot of the Customer Service workspace inbox conversation view.":::

The inbox case view looks as seen in the following screenshot.

:::image type="content" source="media/inbox-case.png" alt-text="Screenshot of the Customer Service workspace inbox case view.":::

Learn how to [configure the inbox view](/../../dynamics-365-customer-engagement-pr/ce/app-profile-manager/app-profile-manager.md#configure-the-inbox-view).

## Use the productivity pane with Smart Assist

While you're working on a case, the productivity pane on the right side of the Customer Service workspace displays intelligence-driven suggestions to help you. The productivity pane uses Smart Assist to suggest related cases and knowledge articles that could be relevant. You'll also see agent scripts that guide you through a consistent series of steps with potentially automated actions through macros.

:::image type="content" source="media/productivity-pane-overview.png" alt-text="Screenshot of the productivity pane with Smart Assist suggestions.":::

Learn more about using the [productivity pane](csw-productivity-pane.md). 

## Key features

On the Customer Service Agent Dashboard, you can view cases and activities that are assigned to you. You can also view cases available to work on. You can perform various actions such as create, delete, and filter cases and activities from the workspace.

### Case

:::image type="content" source="media/bulkEditCases.png" alt-text="Screenshot that shows multiple cases selected and items labeled according to a table below the screenshot.":::

| Label | Description|
| ------------ | ------------ |
| 1 | Select the top check mark to select all cases in the view, or select individual check boxes to group cases for bulk editing. |
| 2 | Associate child cases with selected cases. |
| 3 | Merge selected cases. |
| 4 | Edit selected cases. |
| 5 | Delete selected cases. |
| 6 | Apply a routing rule to route selected cases to a queue. |
| 7 | Open the menu for more actions including Assign, Add to Queue, Run Report, Email a Link, Share, Follow, and Unfollow cases. |

For more information, see : [Work with cases](customer-service-hub-user-guide-create-a-case.md)

### Activities

:::image type="content" source="media/bulkEditActivities.png" alt-text="Screenshot that shows multiple activities selected and items labeled according to a table below the screenshot.":::

| Label | Description|
| ------------ | -------------|
| 1 | Select the top check mark to select all activities in the view, or select individual check boxes to group activities for bulk editing.|
| 2 | Edit selected activities. |
| 3 | Delete selected activities. |
| 4 | Open the menu for more actions including Mark Complete, Cancel, Set Regarding, Assign, Email a Link, Add to Queue, and Run Report. |

### Create and search knowledge articles

Expand the Customer Service workspace site map and select **Knowledge Articles** or **Knowledge Search**. Intelligent knowledge suggestions are displayed in the productivity pane while you're working on a case.

Learn more about how to [create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md).

### Use email templates and signatures

Expand the Customer Service workspace site map and select **Email Templates** or **Email Signatures**.

Learn more about how to create [email templates](/power-apps/user/email-template-create.md) and [email signatures](/power-apps/user/email-signature.md).

## Customize Customer Service workspace

You can use your browser's developer tools to customize some aspects of the Customer Service workspace.

### Turn off the close session dialog

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press Enter: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_SuppressSessionCloseWarning",true)`
1. Refresh the app page.

### Turn on legacy navigation (deprecated)

> [!NOTE]
> The legacy navigation is deprecated and will be removed in a future release.

1. With Customer Service workspace open, press the F12 key to open the developer tools window.
1. In the console window, type the following command and press Enter: `Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_MultisessionNavigationImprovements",false)`
1. Refresh the app page.




### See also

[Work with cases in Customer Service Hub](customer-service-hub-user-guide-create-a-case.md)  
[Work with activities in Customer Service Hub](customer-service-hub-user-guide-manage-timeline-activities.md)  
[Overview of the productivity pane](csw-productivity-pane.md)  
[Migrate from Unified Service Desk to Customer Service workspace](../unified-service-desk/admin/migrate-to-csw.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
