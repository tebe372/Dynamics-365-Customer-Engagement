---
title: "Capture Work Order resolution details | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 02/01/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
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

# Capture Work Order resolution details


// https://msit.microsoftstream.com/video/8930a1ff-0400-9887-cc7d-f1eb56bda718?channelId=0bf6f71a-b361-4d7b-9668-62ff5207b60d

record how work order was resolved

features details
- tag resolutions to work orders
- relate resolutions to specific work order incident types to correlate isses with resolutions
- more organized than note fields

business value
- improve first time fix rate
- manage resolutions better
- good for training




## Create resolutions

From the Field Service app go to Settings > Resolutions.

Create resolution records based on your business needs. As an example, if "reinstall firmware" is a common way to resolve a work order issue then create a resolution record with "reinstall firmware" as the title. The description should be additional information on why or how to reinstall firmware. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/resolutions-list-settings.jpg)

At this time a resolution is simply a name and a text description. 

## Specify resolutions to work orders

Technicians in the field will then update the work order with the resolution by selecting a resolution from the lookup in the **Primary Resolution** field. Techncicians will do this on the mobile app. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/primary-resolution-wo.jpg)

Dispatchers in the back office can also update the primary resolution on the work order from the web browser. 

Regardless of who adds a resolution, doing so creates a new Work Order Resolution record.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/wo-resolutions-associated-wo.jpg)

## Associate resolutions to incident types (optional)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/wo-resolution-form.jpg)

## Configuration considerations

- primary resolution gets related to primary work order incident 
- can add reoslutions even without incidents
- can add multiple resolutions to work order


## Additional Notes














