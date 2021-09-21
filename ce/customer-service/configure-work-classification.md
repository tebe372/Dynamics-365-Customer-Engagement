---
title: "Configure work classification rulesets | MicrosoftDocs"
description: "Learn about how to configure work classification rulesets for unified routing."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---
# Configure work classification rulesets for unified routing

## Introduction

Use the CSR Manager or Omnichannel administrator role to configure the work classification rules for a workstream.

You will do the tasks listed in this article in the Omnichannel admin center or Customer Service Hub app.

In unified routing, work classification lets you define rules to add detailed information to incoming work items that can be used to route and assign the work items optimally.


> [!IMPORTANT]
> You can create 10 rulesets per workstream, and for each ruleset, you can create up to 100 rule items.

## How classification rulesets work

A classification ruleset is an ordered list of multiple work classification rulesets and route-to-queue ruleset. During evaluation, the work classification rulesets are run first, followed by route-to-queue ruleset.

The work classification rulesets will be run in the order they are listed. Within a ruleset, rule items will be run in the order they are listed. As soon as one of the rule item conditions matches the output section of the rule item is run, and the system evaluates the rules in the next ruleset if it is configured.

After all the work classification rulesets have been run, the system evaluates the route-to-queue ruleset in which all the rule items will be run in the order they are listed. This is unlike the classification rules, where control passes to the next ruleset when one of the rule items in a ruleset condition matches.

In work classification rulesets, the values set in one of the rule items of a ruleset can be used in the next rulesets' rule items. For example: If in output section of one of the rule items of ruleset 1, priority is set to High; then any next ruleset rule item can use the priority variable and corresponding value "High" to set value for another attribute, such as, "If Priority equals High, set severity to critical".

For a rule item, you can set the output values for up to five attributes.

## Create work classification rulesets

Routing rules are written as rulesets that consist of rule items.

To create a manual work classification ruleset, do the following steps:

1. In Omnichannel admin center or Customer Service Hub, select a workstream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset**.

2. On the **Work classification** page, select **Create new**, and in the **Create work classification ruleset** dialog, select **Rule Type** as **Manual**, and enter a name and description.

3. In the **Decision list** area, select **Create Rule**, and on the **Create demand rule** dialog, enter a name.

4. In the **Conditions** area, define the conditions according to your business needs.

5. In the **Output** area, select the attribute for which value needs to be set if the conditions are met.

   ![Define rule conditions for demand rule.](media/ur-demand-rule.png "Define rule conditions for demand rule")

6. Repeat steps 3 through 5 to create the demand rules.

   ![Decision list for manual ruleset.](media/ur-decision-list-manual.png "Decision list for manual ruleset")

## Create manual skill classification rulesets

Follow these steps to create a manual skill classification ruleset:

1. In Omnichannel admin center or Customer Service Hub, select a workstream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset**.

2. On the **Work classification** page, select **Create new**.

3. In the **Create work classification ruleset** dialog, select  **Rule Type** as **Manual**, and enter a name and description.

4. Select **Create Rule**, and on the **Create demand rule** dialog, enter a name.

5. In the **Conditions** area, define the conditions according to your business needs.

6. In the **Output** area, select the attribute whose value will be set if the conditions are met.

7. If you want to manually set up the skill attribute, in the **Conditions** area, define the conditions, and select the required value in the **Output** area for the skill that needs to be set.

## Create classification rulesets based on capacity profiles

Create work classification rulesets that are based on capacity profiles to route work items to agents based on capacity.

1. Perform the steps 1 through 5 in [Create manual skill classification rulesets](#create-manual-skill-classification-rulesets).
2. In the **Output** area, select **Capacity profile**, and choose a capacity profile whose value should be set if the conditions are met.

   > ![Capacity profile-based work classification rule.](media/capacity-profile-based-rule.png "Capacity profile-based work classification rule.")

## Create machine learning-based skill classification rulesets

To configure a skill classification ruleset by using the machine learning option, you must have configured the intelligent skill finder models. More information: [Set up intelligent skill finder model](set-up-skill-based-routing.md#set-up-intelligent-skill-finder-model)

Do the following to configure a machine learning-based ruleset:

1. In Omnichannel admin center or Customer Service Hub, select a workstream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset** or **See more**.

2. On the **Work classification** page, select **Create new**.

3. In the **Create work classification ruleset** dialog, select **Rule Type** as **Machine learning model**, and enter a name and description.

4. Select a model in the **Select skill identification model** list, and select **Create**.

   ![Machine learning skill ruleset.](media/ur-ml-skill-ruleset.png "Machine learning skill ruleset")

5. On the page that appears, in the **Input attributes** area, select **Add attribute**, and select the attributes from the **Attributes** or **Related Entities** category. For an incoming work item, these attribute values will be concatenated and sent to the machine learning model for skill prediction.

    > [!NOTE]
    > Skill is the default selection for output attributes and can't be edited or deleted.

    ![Machine learning rule type.](media/ur-ml-rule-type.png "Machine learning rule type")

## Preview: Create rulesets based on sentiment prediction model

> [!IMPORTANT]
> This section is pre-release documentation and is subject to change.

You can create rules that are based on the sentiment prediction model to classify work items. More information: [Use sentiment prediction](use-sentiment-prediction-for-routing.md).


## Configure route-to-queues rulesets and rules

After you configure the route-to-queues rulesets and rules, during runtime, to assign a work item to a queue, the system matches the rule conditions and operating hours of the corresponding queue. If more than one rule matches the required condition and the corresponding queues also match the operating hours, then, the queue corresponding to the first rule in the list is selected for assignment. If none of the queues corresponding to the rules meet the operating hours, the work item is assigned to the queue that will be operational at the earliest.

When no rule condition is matched or no rule is defined, the work item is assigned to the default queue.

1. In Omnichannel admin center or Customer Service Hub, select a workstream, and in the **Routing rules** section, select **Create ruleset** next to **Route to queues**, and then select **Create Rule** in **Decision list**.

2. In the **Create route to queue rule** dialog, enter a name in **Rule Name**.

3. In **Conditions**, define the set of conditions.

4. In **Route to queues**, select the queue to which the work items will be routed if the conditions are met.
   > [!NOTE]
   > Make sure that you don't select the **Default messaging queue** or **Default entity queue** in the list. More information: [Default queues in Omnichannel for Customer Service](queues-omnichannel.md#default-queues)

   ![Configure route to queue decision rules.](media/ur-route-to-queue-decision.png "Configure route to queue decision rules")

5. Repeat steps 2 through 4 to define the rules to cater to your business needs.

6. Optionally, after you create the required rules, you can reorder them in the ruleset by selecting the arrows in the **Order** column on the **Decision list** page.

## Options available for rulesets

After you create the rules, you can change the order in which the rules should be evaluated, search for rules, and view the condition that's been used for each rule by hovering the mouse over the condition. You can also create copies of the rules and update only the necessary information to avoid writing the conditions from scratch.

### See also

[Create a workstream for unified routing](create-workstreams.md)  
[Set up record routing](set-up-record-routing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
