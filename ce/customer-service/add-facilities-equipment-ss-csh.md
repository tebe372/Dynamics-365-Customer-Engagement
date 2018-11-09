---
title: Add facilities and equipment for Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to add facilities and equipment for service scheduling in Dynamics 365 for Customer Service
keywords: Dynamics 365; Customer Service; Service scheduling; Facilities and equipment
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
ms.assetid: f50d894b-1d7f-4305-9924-5957e78eed6c
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Add facilities and equipment to schedule service

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Facilities and equipment are resources you use to perform services for your customers. Facilities could be physical spaces like service bays or conference rooms and equipment could be tools or other assets. Add these resources to [!INCLUDE[pn_dynamics-crm](../includes/pn-dynamics-crm.md)] to ensure optimal services for your customers.  

  
## Create a new facility or equipment record

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)
  
1. In the Customer Service Hub sitemap, go to **Scheduling**.
2. From the list of entity records, select **Scheduling > Facilities/Equipment**.
   - The **Local Facility/Equipment** view is displayed. You can switch between various system views using the drop-down list.
   

3. On the command bar, select **New** to create a new record. 
  
5.  In the **General** section, fill in the information as required:  
  
    - **Name**. Enter the name of the facility or equipment you want to add for service scheduling.  
  
    - **Business Unit ID**. Enter a business unit ID. To choose an ID, select the **Lookup** button and then select from the list. You can also create a new business unit ID.
  
    - **Organizational Unit**. Select the location where the facility or equipment is located.
  
    - **Primary Email**. Enter the email address of the site manager or equipment manager. If there are any updates or cancellations related to the schedule, facilities, or equipment, notifications are sent to this email address.  
  
    - **Time Zone**. Select the appropriate time zone to determine availability for the facility or equipment. By default, this is set to the time zone you’ve selected in the **General** tab of the **Set Personal Options** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set personal options](../basics/set-personal-options.md)  
  
    - **Description**. Add details about the facility or equipment, such as the numbers, size, make, or model.  
  
6.  When you’re done, select **Save** or **Save and Close**.  

    ![facility and equipment](media/facility-equipment-csh-ss.png)


### See also

[Service Scheduling overview](basics-service-service-scheduling.md)