---
title: "Manage session templates in Omnichannel Administration app | MicrosoftDocs"
description: "Learn about managing session templates in Omnichannel Administration app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/22/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Manage session templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

A session template in the Omnichannel Administration app is a combination of attributes and application tab information that can be reused.

When an agent accepts an incoming conversation request from a customer, a session is started. The system opens the **Customer Summary** application that you (an administrator) defined as an **Anchor Tab** in the application tab panel. The **Anchor Tab** can't be closed. Simultaneously, the system expands the communication panel for you to exchange messages with the customer.  

Session templates are used to define the aforementioned session experience such as:

- which application must be opened as an anchor tab in the application tab panel;
- what are the additional application tabs that must be opened when a session is started;
- what must be the default mode of the communication panel when a session is started.

You can create session templates in the Omnichannel Administration app or use the out-of-the-box templates. In your environment, as an administrator, you can create multiple session templates.

  > [!Note]
  > We recommend that you use copies of the out-of-the-box session templates for your customizations to avoid losing them during solution upgrades.


The out-of-the-box session templates are as follows:

- Chat - Default session
- SMS - Default session
- Entity routing - Default session
- Custom Messaging - Default session
- Facebook - Default session
- LINE - Default session
- Teams - Default session
- Twitter - Default session
- WeChat - Default session
- WhatsApp - Default session
  
## Create a session template

To create a session template, follow these steps:

1. Sign in to the Omnichannel Administration app.

2. Select **Sessions** under **Agent Experience** in the sitemap.

3. Select **New** on the **Active Session Templates** page.

4. Specify the following on the **New Session Templates** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the session. This name won't be visible to the agents at the runtime. | Chat session |
    | General | Title | Provide the title of the session that you want agents to see at the runtime. | {customerName} |
    | General | Communication panel mode | Select the default mode of the panel when a session is started. Choose one of the following: <br> <ul><li> **Docked**: The panel will be in expanded mode. </li> <li> **Minimized**: The panel will be in minimized mode. <li> **Hidden**: The panel will be hidden. </ul> <br> **Note**: For an entity routing session—that is, for a case session—the communication panel mode is hidden. | Docked |
    | General | Description | Provide a description for your reference. | The session template is used for a conversation request from Chat channel. |
    | General | Anchor tab | Select an application from the list. The application is opened by default when the session starts; this application is not closable. | Customer summary |

5. Select **Save**. After you save, the **Additional tabs** option appears on the page.

6. Select **Add Existing Application Tab Template** to add additional application tabs that you want to be opened when a session is started. Agents can't close this application tab. The **Lookup Records** pane appears.

7. Type the application tab names in the search box and select the search icon. A list of records appears. Select the application tab and select **Add**. The application tab is added to the session.

8. Select the **Agent scripts** tab, and set the **Enable build expression** toggle to **Yes** to define the expression to set an agent script as default for a particular session template.

9. Build the expression, and then select **Save and close**. To learn more, see [Set default agent script for agents](agent-scripts.md#set-default-agent-script-for-agents).

  > [!Note]
  > Step 8 and 9 are optional, and applicable only when you've configured agent scripts and enabled the productivity pane. To learn more, see [Agent scripts](agent-scripts.md) and [Enable the productivity pane to provide guidance to agents](productivity-pane.md).

10. Select **Save** to save the changes.

   > [!div class=mx-imgBorder]
   > ![Session template](../media/session-template1.png "Session template")

The session template is configured. Now, you must associate the session template with a work stream. To learn more, see [Associate templates with work streams](associate-templates.md).

### See also

[Manage application tab templates](application-tab-templates.md)  
[Manage notification templates](notification-templates.md)  
[Associate templates with work streams](associate-templates.md)  
