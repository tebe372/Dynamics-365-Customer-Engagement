---
title: Create and manage capacity profiles | MicrosoftDocs
description: "Know how to create and manage capacity profiles in Customer Service"
ms.date: 01/21/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Create and manage capacity profiles

## Introduction

You can create capacity profiles and assign them to agents to define the types and amount of work they can take. Capacity profiles contain information, such as the amount of work, concurrent or daily capacity, and whether other channels are affected.

- Capacity management helps administrators create various capacity profiles and associate users with the matching profiles.
- The administrator can block the agent from being allocated extra work when they are working on certain channels, such as phone calls.
- The supervisor can override the agent's configured capacity and assign work to user manually.
- In the assignment rule, you can create a rule to find an agent whose capacity profile matches that of the work item.

Configure profile-based capacity if any of the following scenarios are applicable:

- Your agents are varied on experience and skill sets.
- Agents need upper limit on the amount of work assigned to them.
- Agents work items are of different complexity and assigned from different channels.
- Assignment on one channel impacts the assignments of another channel. For example, agents on phone calls shouldn't be assigned another work.

> [!IMPORTANT]
>
> - We recommend that you configure either capacity profiles or capacity units in your organization, but not both.
> - The capacity is not considered during consult or monitor.

## Create a capacity profile and assign to users

Create a capacity profile, and use it in a workstream that is used for routing work items.

For a capacity profile, you can add or remove users and edit any setting except reset frequency. If you no longer require the profile, you can delete it.

**To configure the capacity profile**

1. In Omnichannel admin center, select **User attributes** in **Advanced settings** in the site map. In Customer Service Hub, select **User attributes** in **Unified routing** in the site map.

2. On the **User attributes** page, select the **Manage** option for **Capacity profile**.

3. On the **Capacity profiles** page, select **Create new**.

4. On the **Details** tab of the **Create capacity profile** dialog box, enter the following details:
   - **Profile name**: Name for the capacity profile.
   -  **Work item limit**: Number of units of the work type that the agent can be assigned.
   -  **Reset frequency**: Period after which capacity consumption can be reset for agents. If you select **Immediate**, capacity will be reset immediately. If you select **End of day**, capacity will be reset after the agent's shift ends. Once configured, you'll have to recreate the capacity profile if you want to change the reset frequency.
   -  **Assignment blocking**: Set the toggle to **Yes**. When the agent reaches the work item limit of the capacity profile, any new work items won't be automatically assigned to the agent.

   :::image type="content" source="media/create-capacity-profile.png" alt-text="Create a capacity profile.":::

5. On the **Users** tab, select **Add user**, and in the **Users** list, select the users. Alternatively, use the **Search** option to search for and add the user.
   
   > [!IMPORTANT]
   > Users must be configured as a bookable resource to be assigned the capacity profile. More information: [Manage users](users-user-profiles.md).

6. Select **Add user**. The capacity profile is assigned to the user.


## Use capacity profiles

After you have created the capacity profiles, you can configure the following settings to assign work items to agents at runtime:

- Set the capacity profile in the work distribution settings. The profile will be applied to all the work items that are routed through the workstream. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution)
- Set the capacity profile in a classification ruleset for the workstream as a rule output. Append the new capacity profile to the work item. During assignment, unified routing will look for an agent who has available capacity in both the profiles, the default profile from the workstream and the appended profile from the classification. More information: [Create classification rulesets based on capacity profiles](configure-work-classification.md#create-classification-rulesets-based-on-capacity-profiles)

You need not define assignment rules specific to capacity profiles at queue level to find agents with matching capacity profiles. If capacity profile is attached to a work item, then the system will ensure that the assigned agent has the matching capacity profile.

### Escalation profiles

The escalation profile is used when a chat conversation is escalated to a voice or video call. This profile is available out of the box and can't be edited. When an agent escalates a chat to a voice or video call, a new session starts and an escalation profile is attached to the work item, so that the agent doesn’t receive a new chat or voice call until the current call with the customer is over. If the agent transfers the video or voice call to another agent, the escalation profile becomes applicable to the new agent.

   :::image type="content" source="media/escalation-profile.png" alt-text="Escalation profile settings.":::

### Multiple capacity profiles in a single workstream

Let us take a scenario where you want to route cases as follows:

- Agents can work on maximum two high priority cases per day.
- Agents can work on maximum four cases based on the normal capacity profile that's assigned.
- But the agent should never be assigned more than five cases per day.

**To achieve the scenario**

1. Create the following profiles:

   - **High-priority profile**: Two cases per day, reset at the end of day
   - **Normal-priority profile**: Four cases per day, reset at the end of day
   - **Total-capacity profile**:  Five cases per day, reset at the end of day

1. In the workstream, set the "Total-capacity profile" as the default profile.

1. Use the classification rules to set the capacity profiles for the work items as "High-priority profile" or "Normal-priority profile" according to the priority of the case.

1. Ensure that the agents have all the three profiles.

**Runtime behavior of multiple capacity profiles in a single workstream**

1. When the high priority work item comes, it'll be stamped with "Total-capacity profile" and "High-priority profile".
2. An agent who has capacity in both these profiles will be selected. When the work item is assigned, capacity will be consumed from both the profiles.
3. Similarly, for normal priority cases, the capacity will be consumed from both "Total-capacity profile" and "Normal-priority profile".


### See also

[Create workstreams](create-workstreams.md)  
[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Map role personas](role-persona-mapping.md)  
