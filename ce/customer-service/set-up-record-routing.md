---
title: "Set up unified routing for records | MicrosoftDocs"
description: "Learn how to set up record routing in Customer Service."
ms.date: 02/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Set up unified routing for records

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

You can configure routing for records in Customer Service admin center (preview), Customer Service Hub, or Omnichannel admin center. However, unified routing can be configured only in Customer Service Hub or Omnichannel admin center.

If you have only Dynamics 365 Customer Service, the options to configure unified routing is available only after you enable unified routing in service configuration settings.

> [!IMPORTANT]
> 
> - After you enable the unified routing feature in **Service Configuration Settings**, you can't disable it. You'll need to contact Microsoft Support to disable the feature.
> - Provisioning unified routing might impact runtime operations on account of solution import that can impact SQL load.
> - If you are upgrading your environment and Omnichannel for Customer Service is also installed, you might have existing workstreams for record routing. We recommend that you provision unified routing only after recreating those workstreams for record routing in Omnichannel admin center.
> - If you are an existing customer, we recommend that you configure and test unified routing in a test or development environment before configuring it in your production environment.

## Prerequisites

The following prerequisites are applicable:

- To set up record routing for Customer Service, unified routing must be enabled in your environment. More information: [Provision unified routing for Customer Service](provision-unified-routing.md).
- To route records, you must enable the record for routing using records channel configuration. More information: [Records routing](enable-entities-for-queues.md).
- You must have the System Administrator role to configure record routing.
- You must have users configured as bookable resource. More information: [Set up the user as a bookable resource](users-user-profiles.md#manage-a-user-in-omnichannel-for-customer-service)

## Configure unified routing for records

**To configure record routing**

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)
     
     > [!IMPORTANT]
     > The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

    1. In the site map, select **Routing** in **Customer support**. The **Routing** page appears.

    1. Select **Manage** for **Record routing**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Record routing** in **General settings**.

   ### [Customer Service Hub](#tab/customerservicehub)
    
    - Go to **Service Management**, and in the site map, select **Record routing** in **Unified Routing**. 

1. On the **Record routing** page, select **Add**.

1. In the **Add a record type** dialog box, select a record from the **Record type** list, and select **Add**. The record is added and listed on the **Record routing** page.

1. Configure the following:
   1. Workstreams.
   1. Intake rules.

### Create workstreams for record routing

To configure a workstream for the record, do the following:

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

   1. In the site map, select **Workstreams** in **Customer support**.
   
   1. Select **New workstream**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **Workstreams** in **General settings**, and then select **New workstream**.

   ### [Customer Service Hub](#tab/customerservicehub)

    - In the **Service Management** site map, select **Workstream** in **Unified Routing**, and then select **New workstream**.
   

1. In the **Create a workstream** dialog, enter the following details:
    - **Name**: Enter an intuitive name, such as **Contoso case workstream**.
    - **Work distribution mode**: Select **Push** or **Pick**.
    - **Type**: Select **Record**.
    - **Record type**: Select a record from the list.

1. Select **Create**. The workstream is created.

### Configure intake rules

Intake rules for a record help determine the workstream to be picked up to assign an incoming work item.

You can create intake rules independently and map them to basic routing rulesets also. However, on any workstream details page, only those intake rules will be displayed that are mapped to the workstream. Therefore, if you want to prioritize the runtime evaluation of the intake rules, you'll need to select **See more** on the workstream details page, and reorder the rules in the **Decision list**.

Perform the following steps to configure the intake rules:

1. Select the workstream that you configured for routing records, such as the case.

2. In the **Intake rules** area, select **Create rule**.

3. In the **Create intake rule** dialog, enter a name and define the conditions for the rule. By default, the root record is selected and displayed at the top of the condition builder for ease of reference and visibility of the record for which you are creating the rule. You can define conditions for up to two levels of the related records and attributes.

  :::image type="content" source="media/ur-intake-rule.png" alt-text="Define conditions for an intake rule.":::

4. Select **Create**.

The following screenshot shows a workstream with the required intake rule and route to queues.

![Workstream for a case record.](media/ur-record-routing-workstream.png "Workstream for a case record")

You can reorder the rules and create copies to meet your business requirements.

:::image type="content" source="media/manage-intake-rules.png" alt-text="Manage your intake rules.":::


### Configure routing rules

Routing rules for a workstream consists of work classification rules and route-to-queue rules. For the steps to configure routing rules, see the following:

- [Configure work classification rules](configure-work-classification.md#create-work-classification-rulesets)  
- [Configure route to queues](configure-work-classification.md#configure-route-to-queues-rulesets-and-rules)

### Configure work distribution and advanced settings

1. In the **Work distribution** area, you can either accept the default settings or select **See more**, and update the following options:

   - **Capacity**: Select one of the following options:
     - **Unit based**: Enter value if your organization has configured unit-based capacity.
     - **Profile based**: Specify a profile in the list if your organization has configured profile-based capacity. More information: [Create and manage capacity profiles](capacity-profiles.md) 

   - **Allowed presences**: Select the presences in which agents will be assigned. If you want to route records in Customer Service Hub, make sure that you add all the required presences to be able to route work items as required.

   - **Default skill matching algorithm**: Select **Exact Match** or **Closest Match**.

2. Expand **Advanced settings** to configure the following options:
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)

   > [!NOTE]
   > The agent notifications that you configure for routing of records based on unified routing will be displayed only in the Customer Service workspace and Omnichannel for Customer Service apps.

### Next steps

![Next step.](media/right-arrow.png "Next step") [Enable routing diagnostics](unified-routing-diagnostics.md#enable-routing-diagnostics)  
![Home.](media/home-button.png "Home") [Process for setting up unified routing](set-up-routing-process.md)  

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Create workstreams](create-workstreams.md)  
[Create multiple work streams for records routing](multiple-ws-entity-record-routing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
