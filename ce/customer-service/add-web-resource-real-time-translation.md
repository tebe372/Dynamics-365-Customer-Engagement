---
title: "Add a web resource for real-time translation of messages | MicrosoftDocs"
description: "Learn how to add a web resource to implement the logic for enabling real-time translation of messages exchanged between your customers and agents."
ms.date: 02/25/2022
ms.topic: reference
author: neeranelli
ms.author: nenellim
manager: shujoshi
---
# Add a web resource for real-time translation

## Introduction

You can use a web resource to implement the logic for enabling real-time translation of messages exchanged in conversations between the customer and the agent.

To add a web resource:

1. Download the [sample web resource](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/real-time-translation) (webResourceV2.js) file that you can use to implement the logic for enabling real-time translation of the conversation message, which are exchanged between the customer and the agent. More information: [Web resources in model-driven apps](/powerapps/developer/model-driven-apps/web-resources).

2. Customize the settings, such as define the translation provider, language of the agent, when to turn on translation, and when to turn it off. More information: [initializeNewConversation](developer/reference/methods/initializeNewConversation.md) method and [translateMessage](developer/reference/methods/translateMessage.md) method.

3. Upload the web resource file in your environment.

## Upload the web resource file

Perform the following steps to upload the web resource file for real-time translation:

1. In Dynamics 365, select **Settings**, and select **Advanced Settings**.

2. On the page that appears on a new tab, select **Settings**, and then select **Solutions**.

3. In **All Solutions**, select **New**, and do the following:
   1. In the General section of the **Solution: New Solution** page, enter the details for the mandatory fields.
   2. Save the solution and close the form.

4. For the added solution, in the left pane, select **Web Resources** under **Components**.

5. Select **New**, and perform the following steps:
   1. In the **General** section, enter a name for the web resource.
   2. In the **Content** section, select Script (JScript) for **Type**.
   3. For **Upload File**, select **Choose File** to upload the JavaScript file that you customized.
   4. Save the form, select the option to publish all customizations.
   5. Copy the link in the **URL** field. You'll provide this link in the administrator settings in [Customer Service admin center (preview)](cs-admin-center.md) or Omnichannel admin center app for configuring real-time translation.
   6. Select the option to publish all customizations on the **Solution** page, and close the form.

6. In the site map of Customer Service admin center (preview) app, select **Productivity** under Agent experience, then select **Manage** next to **Real-time translation**.

    If you're using Omnichannel admin center, then in the site map, select **Agent experience** under **Advanced settings**, and then select **Manage** next to **Real-time translation**.

7. In the **Web resource URL** field, paste the link that you had copied, and save the changes.

   ![Add a web resource.](media/real-time-translation-web-resource.png "Add a web resource")
8. Select **Save**.

### See also

[Enable real-time translation of conversations](enable-real-time-translation.md)  
[Real-time translation of conversations](oc-real-time-translation.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
