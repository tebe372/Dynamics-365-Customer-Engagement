---
title: Configure and manage presence and custom presence | MicrosoftDocs
description: See how you can configure and manage presence and custom presence in Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/16/2019
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
---
# Configure and manage custom presence

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Presence status indicates an agent's availability.

A presence status consists of two elements:

- **Base status**: The base presence status that indicates an agent's status. The work distribution system distributes work items to agents according to the base statuses that you can select as allowed presences at the time of creating a work stream. The base statuses are as follows:
  - Available
  - Busy
  - Busy-DND
  - Away
  - Offline

  Only the base statuses are available for selection in **Allowed Presences** while creating a [work stream](work-streams-introduction.md).

- **Presence text**: The text that is associated with a specific base status. This is the text that is visible to agents.

## Out-of-the-box presence statuses

Omnichannel for Customer Service provides the following presence statuses out of the box:

- Available
- Away
- Busy
- Busy - DND
- Inactive
- Offline

The inactive presence is not available for manual selection by the agents; if the missed notifications feature (preview) is enabled, the agent status will be changed to inactive when agents do not respond to the incoming conversation request notification.

> [!div class=mx-imgBorder]
> ![Presence view](../media/oc-presence-view.png)

> [!NOTE]
> You cannot edit or delete the out-of-the-box presence or base statuses.

## Create custom presence status

In addition to the out-of-box presence statuses, admins can configure custom presence statuses for agents. For example, if the agents on your team want to attend a training, you can create a custom **Away – In Training** presence status.

Perform the following steps to create a presence record:

1. In the Omnichannel site map, go to **Agent Experience** > **Custom Presence**. The **Active Presences** view is shown.

2. On the command bar, select **New** to create a presence record.
3. On the **Summary** tab, provide the following information:

    1. **Name**: Enter a name for the custom presence status.
    2. **Presence Text**: Enter presence text that should be associated with the new custom entity.
    3. **Base Status**: Select the most applicable base status in the list.
    4. **Description**: Enter a brief description of the custom presence record.

4. Select **Save**.

> [!div class=mx-imgBorder]
> ![custom presence](../media/oc-custom-presence-example.png)

### See also

[Understand and create work streams](work-streams-introduction.md)  
[Understand unified routing and work distribution](unified-routing-work-distribution.md)  
