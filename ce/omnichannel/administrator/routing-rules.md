---
title: Create and manage routing rules in Omnichannel for Customer Service | MicrosoftDocs
description: Understand how to create and manage routing rules in Omnichannel for Customer Service
author: anjgupta
ms.author: anjgup
manager: shujoshi
ms.date: 07/01/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Create and manage routing rules

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Routing rules define how conversations are routed to different queues. Each routing rule has a condition and a destination queue. If the rule condition is evaluated as **True**, then the conversation is routed to the destination queue.

 > [!Important]
 > Routing rules for entity records are defined at the entity record channel level. To learn more, see [Entity records routing](entity-channel.md).

A single work stream can have multiple routing rules, and these are evaluated in the order of definition. For example, if a work stream called **Chat** contains 5 routing rules, an incoming chat conversation will be evaluated against all the 5 routing rules in the defined order. 

> [!div class=mx-imgBorder] 
> ![Routing rules](../media/oc-routing-rules.png)

Routing rules are evaluated from top to bottom. If a rule condition is evaluated as **True**, the chat gets routed to the destination queue and skips further evaluation. If a rule condition is evaluated as **False**, further rules are evaluated. 

Routing rule conditions could be based on channel context, pre-chat context, and contact, account, or case context. For example, you can define a routing rule so that chats from high priority customers who have specific queries about investments can be routed to a specific queue.

> [!IMPORTANT]
> If all the rule conditions are evaluated as False for a conversation, it goes to the **Default** queue. For more information, see [Default queue](queues-omnichannel.md#default-queue).

## Create a routing rule
To create a routing rule, select a work stream by navigating to **Work Distribution Management** > **Work Streams**, and define a new rule in the **Routing Rule Items** tab.

1. Select **Add** to add a new routing rule item.  
    - In the **General information** section of the **General** tab, provide the following information: </br>
    a. **Name**. Name of the rule item </br>
    b. **Work Stream** is auto populated </br>
    c. **Queue**. Look up a queue or select **New** to add a new queue. For more information, see [Create a new Omnichannel queue](queues-omnichannel.md#create-a-new-queue) </br>
    d. **Description**. A brief description of the rule item.
              
    - In the **Condition** section, provide the conditions for Omnichannel rule. Based on the conditions defined, the conversations are routed to the correct queues. When you define conditions for the Omnichannel routing rules, you can choose from:
        - Entity
        - Attribute
        - Operator
        - Value

       So, for an entity, you can choose from a set of attributes, operators, and values related to the entity. 

       > [!div class=mx-imgBorder]
       > ![Configured rule](../media/configured-rule.png)

2. Select **Save** to save the rule. 

### See also

[Understand and create work streams](work-streams-introduction.md)

[Understand unified routing and work distribution](unified-routing-work-distribution.md)
