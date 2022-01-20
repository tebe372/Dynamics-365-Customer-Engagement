---
title: "System requirements to use the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn about system requirements for the Field Service (Dynamics 365) mobile app.
ms.date: 03/23/2021
ms.reviewer: krbjoran
ms.topic: article
ms.service: dynamics-365-field-service
ms.subservice: field-service-mobile
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# System requirements for the Field Service (Dynamics 365) mobile app

## Field Service requirements

**Field Service version 8.8.22+**

After installing or upgrading to **Field Service v8.8.22+**, the "Field Service" and "Field Service Mobile" apps will appear in the list of apps when you sign in. You can find these apps by going to:

```https://[your-environment-name].crm.dynamics.com/apps```
   
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service apps.](media/admin-apps.png)

## Mobile device - supported platforms

Currently, the Field Service (Dynamics 365) mobile app is supported on the following mobile platforms.



|  |	Minimum	 |    |	 |	Recommended	| |  |
| --- | --- |	--- | --- | --- | --- | --- |
| Platform |	Version |	RAM	| Storage*	| Version	| RAM	| Storage* |
| iOS |	12.4.9 or later |	3 GB |	64 GB	| 13 or later	| 4 GB	| 128 GB |
| Android	| 7.1.1 or later |	3 GB	| 64 GB	| 10 or later |	6 GB	| 128 GB | 


*The number of GBs of storage needed is dependent on how much data your organization needs to download onto the device when there is no internet access. This is controlled by the [mobile offline profile](mobile-power-app-system-offline.md).



> [!NOTE]
> An important consideration before deploying the Field Service (Dynamics 365) mobile app is the hardware specification of the device used, such as memory and processor. Modifying the app with enhancements such as custom configurations and offline javascript may place additional requirements on system memory and processor. Other factors, such as the amount of applications running on the device may also affect app performance.


>[!TIP] 
> For the best performance, make sure your team has 1) newer devices that 2) run the latest operating system versions, in that order.

### See also

[What's supported Dynamics 365 phones and tablets](../mobile-app/support-phones-tablets.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
