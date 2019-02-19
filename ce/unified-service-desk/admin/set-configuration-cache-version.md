---
title: "Set Configuration Cache Version in the configuration of Unified Service Desk for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
description: "Learn how set Configuration Cache Version in the configuration of Unified Service Desk for Dynamics 365 for Customer Engagement apps."
ms.custom: 
  - dyn365-USD, dyn365-admin
ms.date: 03/01/2019
ms.service: dynamics-365-customerservice
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: A988412D-5A59-42BC-B608-0FB4E7CA7E17
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---

# Preview: Set Configuration Cache Version

The **Configuration Cache Version** option causes the client caching feature to retrieve the configuration that has undergone change from the Dynamics 365 for Customer Engagement server to the agent’s desktop. This helps to improve the startup performance of Unified Service Desk.

> [!div class=mx-imgBorder]
> ![Configuration Cache Version option in new configuration page with an example value](../media/configuration-cache-version.PNG "Configuration Cache Version option with an example value")

## Overview of Configuration Cache Version

Your organization has multiple configurations, and you’ve added agents to those configurations. Now, you make certain changes to any one configuration and update the **ClientCacheVersionNumber** in the Dynamics 365 for Customer Engagement server.

The next time the agent signs in to the Unified Service Desk client application, the client caching feature retrieves the configuration data from the Customer Engagement server for all the configurations even though you made the change to only one configuration. Retrieving multiple configurations can cause an increase in startup time, which in turn might degrade the startup performance.

To avoid retrieving all configurations from the Customer Engagement server when it’s not needed for every configuration, use the **Configuration Cache Version** option.

## What is Configuration Cache Version

**Configuration Cache Version** is an option on the **Configuration** page in the Unified Service Desk Customer Engagement server settings. Every configuration in the Unified Service Desk in the Customer Engagement server has the **Configuration Cache Version** option and takes an alphanumeric value as the cache key.

## How does Configuration Cache Version work
The following scenario example explains how Configuration Cache Version works.

> [!div class=mx-imgBorder]
> ![1 update configuration x, 2 agent signs in to Unified Service Desk, 3 client caching verifies the key, and 4. downloads the configuration x from server to agent desktop](../media/ccv-working.GIF "Configuration Cache version working")

Your organization uses **X**, **Y**, and **Z** configurations for chat, message, and voice support, respectively. You make a change to configuration X and update the **Configuration Cache Version** value in the Dynamics 365 for Customer Engagement server. When an agent assigned to configuration **X** (chat) signs in to the Unified Service Desk client application, the client caching feature checks for the local cache store and determines the cache version key. Because you updated the cache version key for the **Configuration Cache Version** option, the client caching feature retrieves the updated configuration **X** from the server to the agent’s desktop.

## Enable the Configuration Cache Version option

> [!div class=mx-imgBorder]
> ![In the new option page, add EnableConfigurationCaching for name and enter value as true](../media/configuration-cache-version.GIF "EnableConfigurationCaching UII option with value as true")

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.  

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  

3. Choose **Options**.  

4. On the **Active UII Options** page, select **New**.

5. On the **New Option** page, select **Others** for **Global Option**, enter **EnableConfigurationCaching** in the Name box, and enter **true** in the value box.

6. Select **Save**.

Unified Service Desk activates the client caching for configurations.

## Specify value for the Configuration Cache Version option

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps.  

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  

3. Choose **Configuration**. 

4. Select an existing configuration from the list or create a new configuration.

5. On the **Configuration** page, in the text box of the **Configuration Cache Version** field, enter an alphanumeric value as the cache key. For example, the alphanumeric value can be updated as **XY12**.

6. Select **Save**.

## Client caching store location
When enabled, client caching stores its files in a compressed and encrypted format in the user’s roaming directory: `%appData%\Microsoft\USD`

For example, for a user called agent1 running the Unified Service Desk client application on Windows 8, the client caching files are available at `c:\Users\agent1\AppData\Roaming\Microsoft\USD`.


## See also

[Configure client caching in Unified Service Desk](configure-client-caching-unified-service-desk.md)

[Manage access using Unified Service Desk configuration](manage-access-using-unified-service-desk-configuration.md)
