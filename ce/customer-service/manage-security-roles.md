---
title: Manage security roles in Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to manage security roles in service scheduling in Dynamics 365 for Customer Service
keywords: Resources; Service scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS)
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 82eeeb62-3206-46d0-86ea-da16aa5792cc
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---


# Manage security roles in service scheduling

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

A user in [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] is a member of your organization who will use a [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] license. Security roles define which entities a user can view as well as how they can interact with those entities. Field security profiles define which fields a user can see. As an example, a user may have permission to see accounts but not to see specific fields for an account. [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] comes with four predefined security roles and field security profiles:  
  
- **Field Service Administrator:** Generally assigned to key people within the organization who need access to the **Administration** tile. Global access to all Field Service entities.  
  
- **Field Service Dispatcher:** Generally people in the organization who are responsible for scheduling and need to manage resources and work orders.  
  
- **Field Service Resource:** Generally people within the organization who will access [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] from a mobile device.  
  
- **Field Service Inventory Purchase:** Generally people within the organization who are responsible for inventory, purchase orders, RMAs, and RTVs.  
  
### To view or enter information for an existing user account  
  
- Go  to **Microsoft Dynamics 365 > Settings > Security > Users**.  
  
  The following table describes the fields.  
  
|                              |                                                                                                                                                                                                                                                                                                                                  |
|------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|           **Item**           |                                                                                                                                                         **Description**                                                                                                                                                          |
|   **Account Information**    |               User Name: Validates the user record against [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. Users must be created in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] before being added to [!INCLUDE[pn_field_service](../includes/pn-field-service.md)].                |
|     **User Information**     |                                                                                                                                 Enter the user’s name, title, email address, and phone numbers.                                                                                                                                  |
| **Organization Information** | Enter the user’s site, territory, business unit, and manager. Territory on a user record is a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] entity and will not add the associated resource record to the territory.  You must do this  in the **Resources** section of the **Field Service Administration** tile. |
|     **Mailing Address**      |            Enter the user’s address. This information can be used by the routing engine and scheduling assistant to calculate travel times and mileage. If the user is going to be a bookable resource, make sure to geocode the address. On the command bar at the top, click **More**, and then click **Geo Code**.            |
  
### See also  

[Service Scheduling overview](basics-service-service-scheduling.md)
