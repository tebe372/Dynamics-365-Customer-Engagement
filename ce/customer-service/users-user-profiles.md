---
title: "Create and manage users and user profiles | MicrosoftDocs"
description: "This topic provides steps that you can perform to manage users in Omnichannel for Customer Service."
ms.date: 02/11/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Manage users in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

All users who are assigned the **Omnichannel administrator**, **Omnichannel supervisor**, or **Omnichannel agent** security role are enabled to use Omnichannel for Customer Service.

For more information on how to create users and assign security roles, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).


## Manage a user in Omnichannel for Customer Service

Users should be configured as a bookable resource so that they can be assigned work items by using unified routing.

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)
     
     > [!IMPORTANT]
     > The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
   
    1. In the site map, select **User management** in **Customer support**.
    
    1. On the **User management** page, select **Manage** for **Users**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Users** in **General settings**.

   ### [Customer Service Hub](#tab/customerservicehub)

    - Go to the **Service Management** site map, and in **Unified Routing**, select **Users**.

2. On the **Omnichannel Users** page, double-click a user in the list.

3. Select the **Omnichannel** tab.

4. Specify the following in the user page.

    | Section | Field | Description | Example value |
    |---------------|---------------------|---------------------|-------------------------------------------------|
    | User Details | Capacity | If capacity units is configured, allocate a value that indicates the capacity of the agent. For information: [Capacity](#capacity). | 100 |
    | User Details | Default Presence | Assign a default presence status for agent. This is the status that the agent is logged in with, in the Omnichannel for Customer Service app. |

5. Select **New Bookable Resource** under the **Skills Configuration** section. The **New Bookable Resource** page appears.

6. Do the following:
   1. Specify the name of agent in the **Name** field.

   2. Select **Save**. The **Work Hours** tab is enabled.
 
    > [!IMPORTANT]
    > To add the work hours for a bookable resource, universal resource scheduling must be available in your organization. Universal resource scheduling is available with Dynamics 365 Field Service, Dynamics 365 Project Service, or Dynamics 365 Service Scheduling. More information: [Overview of Service Scheduling](/dynamics365/customer-service/basics-service-service-scheduling)

   3. You can update the existing work hours or create work hours for the user.

   4. On the **Omnichannel** tab of the **Bookable Resource** page for the user, select **New Bookable Resource Characteristic**.
   
   5. In **Skill Name**, search for and select a skill.
   
   6. In **Rating Value**, select the rating value that the user has on the skill.
   
   7. Save and close to return to the **Omnichannel** tab of the **User** page.

7. If capacity profile is configured, in the **Capacity** area, select **Add Existing Capacity Profile**, and select a profile in the list.

   > [!div class=mx-imgBorder]
   > ![Default presence.](media/oc-user-omni-tab.png)

8. To use the user schedule for assignment, set up the bookable resource calendar. More information: [Apply a calendar to a resource](../field-service/calendar-resource.md)

9. Add the user to the required queue that's configured for unified routing. More information: [Configure queues for unified routing](queues-omnichannel.md)

### Capacity

Capacity is the arbitrary scale that you choose and set for each of the work streams corresponding to the channels. The capacity assigned to the agent must be a multiplier of the capacity unit that you have defined for the associated workstream. Check the capacity unit defined for the workstreams to determine the value that must be assigned to your agents. For example, if the capacity unit is 1 for a workstream and you want an agent to be able to take up to 3 conversations simultaneously, the capacity that you assign to the agent should be 3 units. Similarly, if your capacity unit is 5 for the work stream and you want the agent to be able to take up to 3 conversations simultaneously, you should assign 15 units as the capacity for the agent. You can also define capacity profiles. However, we recommend that you use either capacity units or capacity profiles in your environment, and not both. More information: [Create and manage capacity profiles](capacity-profiles.md).

### See also

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)  
[Configure and manage presence status](presence-custom-presence.md)  
[Role personas for unified routing](role-persona-mapping.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
