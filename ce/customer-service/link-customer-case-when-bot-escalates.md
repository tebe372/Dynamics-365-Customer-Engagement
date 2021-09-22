---
title: "Link customer, case to conversation when bot escalates or ends conversations | MicrosoftDocs"
description: "How to link customer and case to conversation when bot escalates to human agent."
ms.date: 09/23/2021
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Link customer and case to conversations when bot escalates or ends conversations

When the bot escalates a conversation to a human agent or ends the conversation with the customer, the customer and case can be linked to the conversation so that the human agents can see the related customer and case information in the customer summary section when they start interacting with the customers. 

> [!Note]
> The bot can create the case number or obtain it from the customer. When the conversation ends, the case number is attached to the conversation based on the customer name, email address, and telephone number.

To link the customer or case, set the values for the associated attributes, such as the name and phone number. These attributes will be searched for in Dynamics 365 in the corresponding entities, such as customer and case, and the result will be linked to the conversation if a single record is found to be matched. The bot will need to set context parameters for the following that are also set in [automatically identify a customer](record-identification-rule.md).

| Entity to be linked | Variable name to be set by bot | Attribute for Dynamics 365 entity to match with corresponding variable name in bot |
|------------|----------------|----------------------|
|Account|<ul><li> Name</li><li> Email </li><li> Phone</li></ul> |<ul><li> name</li><li>emailaddress1</li><li>telephone1</li></ul> |
|Contact|<ul><li> Name</li><li> Email </li><li> Phone</li></ul>|<ul><li> name</li><li>emailaddress1</li><li>telephone1</li></ul>|
|Case|CaseNumber|ticketnumber|
||||

To create context variables for Azure bot and set the values to "string", see [Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md). 

To create context variables for bots in Power Virtual Agents, and set the values to "User's entire response", see [Configure context variables for the bot](configure-bot-virtual-agent.md#configure-context-variables-for-the-bot).

The following sample screenshot outlines how the variables need to be set in Power Virtual Agents.

> [!Note]
> You don't need to select the **External sources can set values** checkbox in the variable properties.

![Set context variables for Power Virtual Agents bot.](media/set-context-variables-pva.png "Set context variables for Power Virtual Agents bot")

### See also

[Configure a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Configure Azure bot](configure-bot.md)  
[Context variables for bots](context-variables-for-bot.md)  
