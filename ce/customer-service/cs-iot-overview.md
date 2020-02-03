---
title: "Connected Customer Service - Overview| MicrosoftDocs"
description: "Overview of Connected Customer Service."
author: lalexms
ms.author: lalexms
manager: shujoshi
ms.date: 02/03/2020
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
ms.custom: 
  - ""
applies_to: 
  - ""
---


# Connected Customer Service - Overview

[!INCLUDE[cc-early-access-2020w1](../includes/cc-early-access-2020w1.md)]

Connected Customer Service enables organizations to transform their service model into a proactive and predictive service model with the availability of IoT diagnostics, IoT device update, and case management on one platform. Agents using Customer Service Hub can diagnose and fix issues remotely, which leads to cost savings and improved customer satisfaction. 

Key benefits of Connected Customer Service:

- Reduce downtime by connecting to IoT devices to diagnose problems before customers are aware of an issue
- Address issues faster by remotely monitoring and updating devices and keeping customers in the loop

There are two ways you can connect IoT-enabled devices to the Customer Service solution:

-	Connected Customer Service for [Azure IoT Central](https://azure.microsoft.com/services/iot-central/)
-	Connected Customer Service for [Azure IoT Hub](https://azure.microsoft.com/services/iot-hub/)

The following sections describe the differences between these solutions.

## Connected Customer Service for Azure IoT Central

Connected Customer Service for IoT Central provides a direct integration of Dynamics 365 Customer Service with Microsoft Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution.

Microsoft Azure IoT Central enables builders to configure rules and actions. Based on those actions, IoT alerts will be created in Connected Customer Service. Also, based on service activities in Connected Customer Service, information can be sent back to IoT Central. This is accomplished by using Power Automate, a SaaS offering for automating workflows across applications and services. 

> [!div class="mx-imgBorder"]
> ![Diagram representing the relationship between Azure IoT Central, Power Automate, and Connected Customer Service](media/cs-iot-overview.png)
 
The below end-to-end integration processes can be easily implemented based on a pure configuration experience:

- Azure IoT Central can send information about device anomalies to Connected Customer Service (as an IoT Alert) for diagnosis
- Connected Customer Service can create cases or work orders triggered from device anomalies

Azure IoT Central requires no extensive cloud development or coding skills to get an IoT solution up and running.  

With [Power Automate templates](https://preview.flow.microsoft.com/templates/), users can connect their accounts, take advantage of our pre-built templates, and customize their own flows in an easy visual designer without the need for coding experience.

Check out our [Connected Customer Service for IoT Central tutorial](https://docs.microsoft.com/dynamics365/field-service/cs-iot-tutorial-overview) to get started.

## Connected Customer Service for Azure IoT Hub

Connected Customer Service for Azure IoT Hub is an add-on solution that brings Azure IoT platform-as-a-service (PaaS) offering into Dynamics365 for Customer Service. With this offering, you can run a deployment app to put all of the Azure IoT services and Dynamics puzzles together.
All Azure IoT services run in your own Azure cloud subscription. Additionally, we provide an enterprise-ready template that you can customize for each Azure IoT service.

## Privacy details for Connected Customer Service

By installing Connected Customer Service for Dynamics 365, when you provide your Azure subscription information, the required Azure resources (listed below) are deployed and your Dynamics 365 for Customer Engagement instance will send data (such as commands) to Azure to enable IoT–enabled scenarios that register devices and then send and receive commands to the registered devices. An administrator can uninstall Connected Customer Service to remove the functionality and then navigate to the Azure portal to manage any related Azure services that are no longer needed.

Azure components and services that are involved with Connected Customer Service functionality are detailed in the following sections.

> [!NOTE]
> For more information about additional Azure service offerings, see the [Microsoft Azure Trust Center](https://azure.microsoft.com/support/trust-center/).

[Service bus queue](https://azure.microsoft.com/documentation/articles/service-bus-dotnet-get-started-with-queues/)

This provides a queue for both inbound and outbound messages (commands) flowing between Dynamics 365 for Customer Engagement and Azure. When an IoT alert is sent to Dynamics 365 for Customer Engagement, or a command is sent from Dynamics 365 for Customer Engagement to the IoT hub, it will be queued here.

[Logic Apps](https://azure.microsoft.com/services/logic-apps/)

This provides an orchestration service that uses a Dynamics 365 for Customer Engagement connector and a Queue connector. Dynamics 365 for Customer Engagement connectors are used to construct entities that are specific to Dynamics 365 for Customer Engagement and Queue connectors are used for polling the queue.

[Stream analytics](https://azure.microsoft.com/services/stream-analytics/)

This provides a fully managed, real-time event processing engine that helps to unlock deep insights from data. Stream Analytics makes it easy to set up real-time analytic computations on data streaming from devices, sensors, web sites, social media, applications, infrastructure systems, and more. It is functioning as a funnel to send selective IoT alerts to Dynamics 365 for Customer Engagement.

[IoT Hub](https://azure.microsoft.com/services/iot-hub/)

Connected Customer Services uses the IoT Hub to manage the state of registered devices. In addition, the IoT Hub sends commands and notifications to connected devices—and tracks message delivery with acknowledgement receipts. Device messages are sent in a durable way to accommodate intermittently connected devices.

**Simulator**

This is a test web app for emulating the device that is sending commands or receiving commands from the IoT hub.

[Azure SQL Database](https://azure.microsoft.com/services/sql-database/}

Connected Customer Service uses SQL Azure to store device heartbeat messages for later use by PowerBI to show the status of devices in Dynamics 365 for Customer Engagement.

[Azure Blob Storage](https://azure.microsoft.com/services/storage/)

Queries that Stream Analytics uses are stored to Azure Blob storage.

- [Connected Customer Service Device Readings (Preview)](https://docs.microsoft.com/dynamics365/field-service/cfs-visualizations-iot-hub) uses [Azure Time Series Insight (Preview)](https://docs.microsoft.com/azure/time-series-insights/) to store, process, and query IoT devices measurements from IoT Hub.
