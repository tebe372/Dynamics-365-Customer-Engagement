---
title: Set up resource categories for Service Scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and set up resource categories for service scheduling in Dynamics 365 Customer Service
ms.date: 11/20/2018
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Create and manage resource categories 

With bookable resource categories, you can group your bookable resources by type. For example, you can create categories like technician, supervisor, subcontractor, vehicle, or equipment.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]: [Multi-resource scheduling with requirement groups](/dynamics365/customer-engagement/common-scheduler/multi-resource-scheduling-requirement-groups)

## Create a new resource category

Make sure that you have the required security role or equivalent permissions. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage security roles in service scheduling](manage-security-roles.md)

1. Navigate to either the Customer Service Hub or Customer Service admin center (preview) app. Depending on your app, perform the following steps:

   ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

   > [!IMPORTANT]
   > The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

    1. On the Customer Service admin center (preview) site map, select **Operations > Service Scheduling**.
    2.  In the **Resource categories** section, select **Manage**.
        
        The **Active Resource Categories** view is displayed. You can switch between various system views using the drop-down list.  

   ### [Customer Service Hub](#tab/customerservicehub)

    1. On the Customer Service Hub site map, go to **Scheduling**.
    2. From the list of entity records, select **Scheduling > Resource categories**.
       
       The **Active Resource Categories** view is displayed. You can switch between various system views using the drop-down list.

2. On the command bar, select **New** to create a new bookable resource category. 
3. In the **General** section:
 
   - Enter a **Name** and a **Description** for the resource category

4. Select **Save**. A new resource category is created and is activated by default. 

5. In the **Related** section, you can view and manage various resource category associations.

   ![resource categories.](media/resource_category_csh.png)

Similarly, you can create a new requirement resource category for requirements.

## Add resources to a resource category

To assign resources to a resource category:

1. In the **Related** section, go to **Resource Category Associations**.

2. Select **Add New Bookable Resource Category Association**. A resource category is populated. 

3. Add a resource to this resource category by selecting a resource in the **Resource** box. You can either lookup for an existing resource or create a new one.

### See also 
[Service Scheduling overview](basics-service-service-scheduling.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
