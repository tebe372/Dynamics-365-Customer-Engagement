---
title: Create and manage users and user profiles | MicrosoftDocs
description: Know how to create and manage users and user profiles in the Omnichannel for Customer Service
author: kabala
ms.author: kabala123
manager: shujoshi
ms.date: 10/15/2019
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
---

# Manage users in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

All users who are assigned the **Omnichannel Administration**, **Omnichannel supervisor**, or **Omnichannel agent** security role are enabled for Omnichannel and become Omnichannel users.

For more information on how to create users and assign security roles, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).

Navigate to **Queues & Users > Users** to view the list of Omnichannel users in the **Omnichannel Users** view.

> [!div class=mx-imgBorder] 
> ![Omnichannel users](../media/omni-channel-users.png)

## Manage a user in Omnichannel

1. Sign in to the Omnichannel Administration app.

2. Select **Users** under **Queues & Users**.

3. Double-click on a user from the list. For example, **Kenny Smith**is the user (agent).

4. Select the **Omnichannel** tab.

5. Specify the following in the user page.

    | Section | Field | Description | Example value |
    |---------------|---------------------|---------------------|-------------------------------------------------|
    | User Details | Capacity | Allocate capacity to agent. | 100 |
    | User Details | Default Presence | Assign a default presence status for agent. This is the status that the agent is logged in with, in the Omnichannel app. | 

6. Select **+ New Bookable Resource** under the **Skills Configuration** section. The **New Bookable Resource** page appears.

7. Specify the name of agent in the **Name** field.

8. Select **Save**.

> [!div class=mx-imgBorder]
> ![Default presence](../media/oc-user-omni-tab.png)

### See also

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)

[Configure and manage presence status](presence-custom-presence.md)
