---
title: "Configure a bot | MicrosoftDocs"
description: "Instructions to configure a bot in Omnichannel for Customer Service."
keywords: ""
author: sbmjais
ms.author: ktaylor
manager: shujoshi
applies_to: 
ms.date: 11/04/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: e5c82c7b-bd48-4eca-a157-e4b349e3baf8
ms.custom: 
---

# Preview: Integrate a Power Virtual Agents bot

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

Microsoft Power Virtual Agents allows organizations to automate routine conversations, letting agents focus on high-value interactions. When a conversation is escalated from a bot to a human agent, agents can see the full transcript of bot conversations and have complete context while engaging with customers.

Once you have created your bot and connected it to an Omnichannel for Customer Service environment, you can go to the Omnichannel configuration in order to add your bot to queues and configure context variables to route chat sessions to queues. 

## Prerequisites
* Product license - You need a product license for both Power Virtual Agents ([start a trial](https://go.microsoft.com/fwlink/p/?LinkId=2092080&clcid=0x409)) and Omnichannel for Customer service ([learn more](https://docs.microsoft.com/dynamics365/customer-engagement/omnichannel/try-chat-for-dynamics365))
* Role - In order to successfully complete these steps, the signed-in user must be a Omnichannel Administrator in Omnichannel. [Learn more about managing and assigning user roles in Omnichannel](https://docs.microsoft.com/dynamics365/customer-engagement/omnichannel/administrator/add-users-assign-roles).
* Azure Application ID - You will need an application registered in Azure prior to connecting to Omnichannel. [Learn more](https://docs.microsoft.com/azure/active-directory/develop/howto-create-service-principal-portal#create-an-azure-active-directory-application)
* Bot - You must have a preconfigured bot that can integrate with Omnichannel for Customer Service. For more information, see [Omnichannel setup & configure](/dynamics365/ai/customer-service-virtual-agent/configuration-hand-off-omnichannel).
<!--note from editor: This link is broken. It looks like an internal link per the "pawant-ms-handoff" section. Please replace with valid external or referential link. -->

## Configure your Power Virtual Agents bot in Omnichannel
Once the Power Virtual Agents bot is created and configured to work with Omnichannel, you can configure it to hand off conversations to queues in Omnichannel. To receive incoming messages, you must add the bot to at least one queue. The bot will use the routing rules that were created at setup. You can change them in the **Work Streams** section of Omnichannel.

**Set up your Power Virtual Agents bot**
1. Connect the bot to Omnichannel and go to the Omnichannel configuration. For more information, see [Omnichannel setup & configure](/dynamics365/ai/customer-service-virtual-agent/configuration-hand-off-omnichannel).
<!--note from editor: This link is broken. It looks like an internal link per the "pawant-ms-handoff" section. Please replace with valid external or referential link. -->

    ![Virtual Agent bot settings](../media/virtual-agent-bot-settings.png)
    
    The bot will be auto-created in Omnichannel, and you just need to finish setting it up.
    <!--note from editor: Does Omnichannel auto-create the bot? If so, or if you know what does the auto-creation, revise the sentence to remove the passive voice. -->


2. Assign the bot to an existing queue.
    
    ![Virtual Agent bot select queue](../media/virtual-agent-bot-select-queues.png)

3. Click **Done**. Now you're on the bot profile page and you can see that your bot is connected. 
    
    ![Virtual Agent bot profile page](../media/virtual-agent-bot-profile.png)
    
    Your bot is ready to accept and respond to customer-initiated conversations.
    
 4. Set escalation rules so the bot can route the queries to the appropriate agent. You can set up escalation rules in one of two ways:
 
    - **Add the bot to an existing human agent queue:**	If you add the bot to an existing human agent queue, you don’t need to change your existing routing rule. Existing routing rules will send incoming messages to the Power Virtual Agents. When a handoff is triggered, customers will be transferred from the Power Virtual Agents to the human agent according to the escalation routing rules.
    
    - **Create a bot queue and a human agent queue:** If you create two queues, you must create work streams that contain context variables and appropriate routing rules to route the customer queries.

For information about working with queues, see [Work with queues in Omnichannel for Customer Service](queues-omnichannel.md).

> [!NOTE]
> If you have only one queue with a bot and agents, and you didn't create a routing rule, the customer query is redirected to the same queue in case of escalation and picked up by an agent.
<!--note from editor: Does Omnichannel do the redirection? If possible, revise the sentence to remove the passive voice. -->

### Create a bot queue and a human agent queue

1. Select or create a work stream. For more information about work streams, see [Understand and create work streams](work-streams-introduction.md).

![Virtual Agent work streams](../media/virtual-agent-work-streams.png)
    
2. Create context variables.

You must use the context variables that were created during setup for the bot to handle the customer queries appropriately. The context variable is used in routing the incoming customer queries to the appropriate bots and agents. For information about context variables, see [Contextual variables available upon hand-off](/dynamics365/ai/customer-service-virtual-agent/configuration-hand-off-omnichannel#contextual-variables-available-upon-hand-off).
<!--note from editor: This link is broken. It looks like an internal link per the "pawant-ms-handoff" section. Please replace with valid external or referential link. -->

   > [!div class=mx-imgBorder]
   > ![Virtual Agent work stream context variable](../media/virtual-agent-work-stream-context-variables.png "Virtual Agent work stream context variable")

3. Create a routing rule for the human agent and add it to the work stream.

    > [!div class=mx-imgBorder]
    > ![Virtual Agent work stream routing rules](../media/virtual-agent-work-stream-routing-rule.png "Virtual Agent work stream routing rules")

4.  Create a routing rule for the virtual agent and add it to the work stream.

    > [!div class=mx-imgBorder]
    > ![Virtual Agent work stream bot routing rules](../media/virtual-agent-work-stream-routing-rule-bot.png "Virtual Agent work stream bot routing rules")

Routing rules route the incoming customer queries to their respective queues. Each routing rule has a condition and a destination queue. If the condition is evaluated as true, the customer query is routed to the destination queue. For bots, the condition is built by using the context variable.

Bots are developed to receive customer queries first, gain information of the query, and then pass the query to a human agent, if required. To achieve this behavior, you must add a bot user to the queue and configure routing rules in a way that the incoming customer queries are routed to the queue with bot user.

Ensure to map the routing rules to the correct queues so that the queries are routed appropriately. For information about routing rules, see [Create and manage routing rules](routing-rules.md).

[!INCLUDE [handoff-known-limitations](/dynamics365/ai/customer-service-virtual-agent/includes/handoff-known-limitations)]
<!--note from editor: That URL is not going to the media folder. It's going to Iaan's branch, which is breaking the build. Please fix. -->


## Privacy notice

If you use Power Virtual Agents, your data may flow outside your organization’s compliance and geo boundaries. This includes Government Cloud environments. Learn more [here](https://<link needed>) and in the [Microsoft Privacy Statement](https://privacy.microsoft.com/en-us/privacystatement).

You understand that your data may be transmitted and shared with external systems and that your data may flow outside of your organization's compliance boundary (even if your organization is in a Government Cloud environment). For example, your messages will be shared with the bot which could be interacting with a third-party system based on the integration done by you. For more information on how we process your data, please refer to the [Microsoft Privacy Statement](https://privacy.microsoft.com/en-us/privacystatement).

### See also

[Understand and create work streams](work-streams-introduction.md)<br>
[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)<br>
[Create and manage routing rules](routing-rules.md)<br>
[Add a chat widget](add-chat-widget.md)<br>
[Enable a bot to escalate and end conversation](../developer/bot-escalate-end-conversation.md)
