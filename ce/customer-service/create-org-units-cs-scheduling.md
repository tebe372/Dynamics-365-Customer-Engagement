---
title: Create organizational units in Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create organizational units in service scheduling in Dynamics 365 for Customer Service
keywords: Service scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS); Organizational units
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
ms.assetid: 960b1af3-d5fe-433f-9540-815b290c4baa
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create and manage organizational units  

Create organizational units to organize and maintain a company's business by geography, function, or other areas. You can create multiple organizational units in Service Scheduling to categorize your business by various areas.

## Create a new organizational unit

Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. In the Customer Service Hub sitemap, go to **Service Scheduling**.

2. From the list of entity records, select **Settings > Organizational Units**.
   - The **Active Organizational Units** view is displayed. You can switch between various system views using the drop-down.
   - Select any existing organizational unit to see additional options in the command bar

3. On the command bar, select **New** to create a new organizational unit.

4. In the **General** section:

   - Type a **Name** for the organizational unit.

5. In the **Scheduling** section:

   - Provide **Latitude** and **Longitude** for the organizational unit.

6. In the **Core Services Scheduling** section:

   -  Fill in other contacts details for the unit like phone number and address.

7. Select **Save** to save the new organizational unit. The new record is saved and activated by default.

   Active organizational units can be edited, assigned, shared, or viewed from the **Active Organizational Units** system view.

   ![create organizational unit](media/create-org-unit.png)

### See also

[Service Scheduling overview](basics-service-service-scheduling.md)