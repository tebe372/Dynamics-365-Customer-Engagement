---
title: Overview of Service Scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know the basics of service and service scheduling in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 06/17/2019
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Service Scheduling Guide

Avoid disruptions in service by making sure that your resources are scheduled optimally and efficiently. Using Scheduling in Customer Service Hub, you can plan and schedule service activities for your customers by bringing together all your resources.

## Understand the new scheduling experience

Scheduling, now built atop **Universal Resource Scheduling (URS)**, provides an efficient way to schedule resources for service activity. It considers the availability of employees, facilities, and equipment to plan schedules accordingly. It also helps customer service organizations with improved service quality by preventing over-scheduling.

With the latest release of Dynamics 365 Customer Service app, the new scheduling experience can be enabled from the Customer Service Hub sitemap.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up the new scheduling experience](#set-up-the-new-service-scheduling-experience)

The new experience lists the entities as follows, as compared to the legacy experience:

|Legacy Scheduling    |New Scheduling    |
|---------|---------|
|Facilities/Equipment     | Facilities/Equipment, Resources      |
|Service     |   Service,  Requirement Groups    |
|Resource Groups     |      Resource Categories      |
|Sites     |      Organizational Units   |
|Business Closure     |      Business Closure    |
|Service Calendar    |      Schedule Board       |
|Service Activity     |     Service Activity     |
|   |           |


### Scheduling scenario

The following scenario helps to understand how the new scheduling experience lets you manage your service activities seamlessly: 

Contoso bike repair schedules repair services for their customers. To facilitate this process, Contoso needs to bring together the following information:

- Geographical locations where they need to offer their services.
- The personnel and equipment they need to perform those services. 
- The types of bike repair services they offer. 
- Work hours during which they perform their services. 
- Capacity and expert level for all personnel.

Contoso can benefit from the scheduling feature by quickly catering to their customers with their repair services. With the various scheduling entities, they can plan service activities for their customers by considering the availability of resources, facilities, and equipment. 

Let's see how Contoso accomplishes the task:

**Step 1: Create organizational units**  </br>
   Organizational units are the locations where Contoso provides service to their customers. 

   > [!NOTE]
   > In the legacy experience the locations are referred as Sites, while in the new experience they are called Organizational units.

   In this example, Contoso bike repair is the site for service.

   |Legacy Scheduling  |New Scheduling  |
   |---------|---------|
   |![sites](media/sites-cs.png)  |  ![organizational units](media/org-unit-csh.png)   |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use sites to manage your service locations (Customer Service app)](use-sites-manage-service-locations.md)     |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage organizational units](create-org-units-cs-scheduling.md) |
   |   |         | 


**Step 2: Create resources**</br>
  Contoso lists the resources required to perform the services. 

  > [!NOTE]
  > Unlike in the legacy experience, you can create all resource types from the resource entity in the new experience.

  In this example, two resources (contacts) Bert Hair and Gilda Moss are created. Similarly, two more resources (facility/equipment) are created as Bike repair workbench - 1 and Bike repair workbench - 2, which are required to perform the service.

  |Legacy Scheduling  |New Scheduling  |
  |---------|---------|
  |![resources-cs](media/resources-cs.png)   |   ![resouces-csh](media/resources-csh.png)      |
  |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a resource group (Customer Service app)](create-edit-resource-group.md)     | [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and set up bookable resources](resources-service-scheduling.md)  </br> |
  |   |         |


**Step 3: Set work hours for the resource, resource group or facility/equipment** </br>
   The availability of the resources is defined in the work hours section. 

   |Scheduling  |
   |---------|---------|
   |   ![set-work-hours](media\set-work-hours-csh-1a.png)     |
   | [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set work hours for the resources](resources-service-scheduling.md#set-work-hours-for-the-resources)|
   |   |         |
  
**Step 4: Create resource groups** </br>
   The resources are aligned in resource groups. 

   > [!NOTE]
   > Resource Groups are referred as Resource Categories in the new experience.

   In the example, Bert Hair and Gilda Moss are grouped as Technicians and Bike repair workbench - 1 and Bike repair workbench - 2 are grouped as Workbenches.

   |Legacy Scheduling  |New Scheduling  |
   |---------|---------|
   |![resource-groups](media/res-group-cs.png)  |   ![resource group](media/res-groups-csh.png)     |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or change a resource group (Customer Service app)](create-edit-resource-group.md)     |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage resource categories](resource-categories-service-scheduling.md)|
   |   |         |


**Step 5: Create a service record**  </br>
   Contoso now collates all the above inputs to create a bike repair service record for the customer. They also specify the resources/resource groups they will need for the service.

   |Legacy Scheduling  |New Scheduling  |
   |---------|---------|
   |![service-cs](media/service-cs.png)  |  ![service-csh](media/service-csh.png)   |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a service (Customer Service app)](create-edit-service-cs-app.md)    |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a service in Service Scheduling](create-edit-service-csh.md) |
   |   |         | 
 
**Step 6: Create a service activity**  </br>
   A service activity is defined to look for the next available time slot to schedule the service and align resources as per requirement. 

   > [!NOTE]
   > In the service activity: </br> - In the new experience, select **Book** to access schedule board. </br> - In the legacy experience, select **Schedule** to access schedule board.


   |Legacy Scheduling  |New Scheduling  |
   |---------|---------|
   |![service-activity-cs](media/service-activity-cs.png)  |  ![service-activity](media/service-activity-csh.png)  |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity (Customer Service app)](schedule-service-activity-cs-app.md)  |  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity](schedule-service-activity-csh.md)|
   |   |         | 


**Step 7: Book the service in the schedule board**  </br>
  The schedule board displays all the service configurations at one place to quickly schedule a service.

   |Legacy Scheduling  |New Scheduling  |
   |---------|---------|
   |![service-calendar](media/service-calendar-cs.png) | ![schedule-board](media/schedule-board-csh.png)  |
   |[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigate the service calendar (Customer Service app)](navigate-service-calendar-cs-app.md)   |    </br>    [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the schedule board to configure service activity](use-schedule-board-configure-service-activity.md)  |
   |   |         | 

## Set up the new Service Scheduling experience

The set up experience is different based on the following scenarios:

- For a new Dynamics 365 Customer Service environment, by default, the **Core Service Scheduling** solutions will be installed. You can access scheduling from Customer service hub app site map. To learn more, see [Access scheduling in the Customer Service Hub](#access-scheduling-in-the-customer-service-hub).

- For an existing Dynamics 365 Customer Service organization, you must install the service scheduling solutions from the Microsoft 365 admin center. To learn more, see [Install the Scheduling solutions](#install-the-scheduling-solutions).

> [!IMPORTANT]
> Once you have the new service scheduling available in your org, the legacy scheduling experience in Customer Service app (based on web application) and the new scheduling experience (built atop URS) in Customer Service Hub co-exist. However, the following limitations apply: </br> - Bookings data and configurations in these experiences do not sync with each other. For example, a service created in legacy experience can be scheduled in legacy scheduling experience only while a service created in the new experience can be scheduled in URS based scheduling experience only.  </br> - You can edit bookings data and configurations in the experience it is originally created in. </br> </br> Bookings created in the legacy experience don’t reflect in the new experience and vice versa is also true.

### Prerequisites

- Make sure that you have the required security role or equivalent permissions. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

- For the new scheduling experience, ensure your organization has Universal Resource Scheduling 3.2.0.405 or a higher version. If your organization has a version lesser than 3.2.0.405, then Universal Resource Scheduling installation fails. To check the Unified Resource Scheduling version on your instance, go to **Settings** > **Solutions**.

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule anything with Universal Resource Scheduling (Sales, Customer Service, Field Service, Project Service Automation)](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

   > [!NOTE]
   > - For the new scheduling experience, if your organization doesn't have Universal Resource Scheduling, the **Core Service Scheduling** solution installs the latest version of Universal Resource Scheduling.
   >
   > - If Field Service or Project Service is already installed on your org with Universal Resource Scheduling 3.2.0.405 or a higher version, then Universal Resource Scheduling will also be upgraded to the latest version. Otherwise, the installation fails.
   >
   > - The latest version of Universal Resource Scheduling might not be compatible with the older versions of Field Service or Project Service.

- Ensure your organization has Customer Service Hub application.

### Install the Scheduling solutions

1. Go to [Microsoft 365 Admin center](https://admin.microsoft.com/AdminPortal/Home).

2. Select **... Show all** > **Admin centers** > **Dynamics 365**. Dynamics 365 opens in a new tab.

   > [!div class=mx-imgBorder]
   > ![Go to Dynamics 365 in the Microsoft 365 admin center](media/microsoft-365-admin-center-dynamics-csh.png)

3. In the **Dynamics 365 Administration Center**, under the **Instances** tab, select an instance type from the drop-down. 

4. select the edit icon next to solutions. Manage your solutions page appears.

   > [!div class=mx-imgBorder]
   > ![Edit the solutions](media/dynamics-365-admin-instance-edit-csh.png)

5. In the **Manage your solutions** page, select **Core Service Scheduling**. The status column shows **Not installed**.

6. Select the install icon next on the **Core Service Scheduling** card. The **Terms of service** page appears.

   > [!div class=mx-imgBorder]
   > ![Install the solutions](media/core-service-scheduling-install-csh.png)

7. In the **Terms of service** page, read the terms and conditions and then select **install**. The installation may take few minutes.

After successful installation, you can access scheduling in the Customer Service Hub sitemap.

## Access scheduling in the Customer Service Hub
With the latest release of Dynamics 365 Customer Service app, Scheduling is powered by Universal Resource Scheduling (URS), and is available from the Customer Service Hub sitemap.

- Select ![change area](media/change-area-icon.png) to go to **Scheduling** and access the entity record types.

  > [!div class=mx-imgBorder]
  > ![access-service-scheduling](media/access-service-scheduling-csh.png)

## Configure entity records in the new scheduling experience

Configure all your entity records in the new experience manually from the user interface. 

Make sure that you have the correct security role or equivalent permissions. Know more about security roles: [Manage security roles in service scheduling](manage-security-roles.md).

> [!IMPORTANT]
> The admin must follow the order as given in the [Scheduling scenario](#scheduling-scenario) while configuring entity records in the new scheduling experience.

> [!NOTE]
> If you have been using the legacy scheduling, you would still need to configure entity records in the new experience. </br> All entity records can be configured from the user interface except Service Activity.

## Understand scheduling entities

Scheduling entities are grouped under the following logical groups:

**Scheduling**

- **Resources** </br>
   Anything that needs to be scheduled can be termed as **Resources**. This can be personnel, crews, service centers, company assets (equipment), accounts, or contacts. 

  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and set up bookable resources](resources-service-scheduling.md)

- **Facilities/Equipment**  </br>
   Facilities and equipment are resources you’d use to perform services for your customers. Facilities can be physical spaces like service bays or conference rooms and equipment could be tools or other assets. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add facilities and equipments to schedule service](add-facilities-equipment-ss-csh.md)

- **Resource Categories** </br>
   With Resource categories,  you can group your bookable resources by type. For example, you can create categories like technician, supervisor, subcontractor, vehicle, or equipment. 
 
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage resource categories](resource-categories-service-scheduling.md)

- **Services**  </br>
   To make scheduling services quick and easy, it’s helpful to predefine the specifics of the services you’d provide to customers. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit a service](create-edit-service-csh.md)

- **Service Activities** </br>
   Create a service activity by finding the next time resources are available for a service. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule a service activity](schedule-service-activity-csh.md)

- **Fulfillment Preferences** </br>
    Choose and customize how to display schedule assistant results, like with neat hourly appointments or morning and afternoon time windows.

    [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Fulfillment preferences](../common-scheduler/fulfillment-preferences.md)

**Tools**

- **Schedule Board** </br>
   The Dynamics 365 Customer Service schedule board provides an overview of resource availability and bookings you can make. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the schedule board to configure service activity](use-schedule-board-configure-service-activity.md)

**Settings**

- **Organizational Units** </br>
   Your company organizes its business by geography, function, or other areas. You can create organizational units that reflect your business. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and manage organizational units](create-org-units-cs-scheduling.md)

- **Business Closure** </br>
   Prevent scheduling resources on holidays and other non-working days by defining business closures. 

   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set when your business is closed](set-when-business-closed-csh.md)


### See also    
    
[Service Scheduling FAQ](service-scheduling-faq.md) 
