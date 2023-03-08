---
title: Enable personal quick replies in Omnichannel for Customer Service
description: Learn how to enable personal quick replies in the agent experience for Omnichannel for Customer Service.
ms.date: 03/08/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---
 
# Enable personal quick replies for agents

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can allow agents to create their own personal quick replies that are stored in the agent's context and which the agent can invoke by using the associated tags during a session with a customer. Agents can use personal quick replies to respond to customer queries efficiently with minimal turnaround time.

As an administrator, you can use a Power Automate utility to delete unused tags.

## Enable personal quick replies

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, in **Agent experience**, select **Productivity**.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter) 

     - In the site map, in **Advanced settings**, select **Agent experience**.

1. For **Personal quick replies**, select **Manage**.

1. On the **Personal quick replies** tab, set the **Allow agents to create personal quick replies** toggle to **Yes**.

The settings for creating personal quick replies is made available for agents.

> [!NOTE]
>
> - It can take up to 15 minutes for the setting to take effect.
> - We recommend that you do not assign the System administrator role to agents or supervisors to avoid enabling access to other users personal quick replies on the **Quick replies** panel of a conversation.

### See also

[Create quick replies](create-quick-replies.md)  
[Create personal quick replies](create-personal-quick-replies.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
