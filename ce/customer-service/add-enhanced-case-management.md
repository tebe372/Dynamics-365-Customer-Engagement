---
title: Customize the case resolution experience | MicrosoftDocs
description: Use this article to learn how to configure enhanced case management.
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 02/06/2023 
ms.custom: bap-template 
---

# Customize the case resolution experience

> [!IMPORTANT]
> [!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

Customize the case resolution experience in Power apps as follows:

- When agents try to close a case with open activities, the application displays a warning message with a redirect link. You can configure the tab agents view when they select this link.
- Choose to display the legacy **Resolve case** dialog instead of the default minimal **Resolve case** dialog when an agent closes a case with open activities.

## Specify tab to redirect users to close the open activities for a case

You can configure the tab users must be redirected to when they select the open activities link on the  **Resolve Case** dialog. You can set this at an environment level or for a specific app.

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the solution in which you want to configure the tab users must be redirected to when they select the open activities link on the **Resolve Case** dialog.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Redirect user to the specified tab to close open activities** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Redirect user to the specified tab to close open activities** option to your solution.
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Redirect user to the specified tab to close open activities** option. The **Redirect user to the specified tab to close open activities** pane appears.
1. Set the **Setting environment value** option to the required tab. You can find the tab's name in the **Display options** > **Name** field of the corresponding form. 
1. In the **Setting app value** section, the Customer Service Hub and Customer Service workspace apps are displayed. 
1. Select **New app value** for the app, and specify the activity tab that the user must be redirected to for the respective apps. This step is optional. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.

  :::image type="content" source="media/powerapps-redirect-user-tab.png" alt-text="Redirect link to tab" lightbox="media/powerapps-redirect-user-tab.png":::


## Disable the minimal case resolution dialog

You can choose to display the legacy case resolution dialog box that appears when an agent selects **Resolve case**.

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the solution in which you want to turn off the minimal case resolution dialog.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Enable minimal case resolution dialog** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Enable minimal case resolution dialog** option to your solution. 
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Enable minimal case resolution dialog** option. The **Enable minimal case resolution dialog** pane appears.
1. Set the **Setting environment value** option to **Yes**.
1. In the **Setting app value** section, the Customer Service Hub and Customer Service workspace apps are displayed.
1. Select **New app value** for the app, and set the value to **Yes** for the respective apps. This step is optional. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.

  :::image type="content" source="media/powerapps-minimal-case.png" alt-text="disable the minimal case resolution dialog" lightbox="media/powerapps-minimal-case.png":::

### See also

[Work with cases](customer-service-hub-user-guide-create-a-case.md)  
[Work with queues](work-with-queues.md) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
