---
title: "Use deep links with the Field Service (Dynamics 365) mobile app | Microsoft Docs"
description: Learn about how to configure deep links for the Field Service (Dynamics 365) mobile app
ms.custom:
- dyn365-fieldservice
ms.date: 06/09/2021
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

# Use deep links with the Field Service (Dynamics 365) mobile app

Deep links let users move from one application to another on computers and mobile devices. Simple examples include a mobile app deep-linking to Facebook to sign in, an email address deep-linking to a mail app to compose a message, or a website deep-linking to an app store to download a related mobile app. Because multiple apps might be needed to complete onsite work, an organization can allow technicians to create deep links from Field Service (Dynamics 365) app to other apps and vice versa.

## Open an entity record or entity list view in the Field Service (Dynamics 365) mobile app

You can open an `entityrecord` or an `entitylist` view in the Field Service (Dynamics 365) app by using deep-link URLs from other apps. When you follow the link from an external app, the target element opens in the Field Service (Dynamics 365) app for phones or tablets.

If you're already signed in to your instance in the app, the target record is displayed when you follow the link from an external app. Otherwise, you're prompted to sign in to your instance in the mobile app; after you're signed in, the target element is displayed. You must have the Field Service (Dynamics 365) app for phones or tablets installed on your mobile device to use this feature.

## Query string parameters for the URL

Use the following application handler and query string parameters to compose the URL.

Deep links for Field Service should start with the following:

```ms-apps-fs://<org-url>_<app-id>?tenantId=<tenant-id>&isShortcut=true&appType=AppModule&openApp=true&restartApp=true&forceOfflineDataSync=true```

| **Parameter**        | **Description**                                                              |
|----------------------|------------------------------------------------------------------------------|
| &lt;org-url&gt;      | Connects to the correct org URL                                              |
| &lt;app-id&gt;       | Opens the correct app module                                                 |
| tenantId             | Connects to the correct tenant                                               |
| forceOfflineDataSync | Ensures that data sync is triggered so that all the latest data is available |

If opening an `entityrecord` form or creating a new `entityrecord`, use the following parameters.

| **Parameter**                       | **Description**                                                                                            |
|---------------------------------|--------------------------------------------------------------------------------------------------------|
| etn=&lt;entity-logical-name&gt; | Designates which entity to go to                                                                 |
| pagetype=entityrecord           | Indicates that the target is a form    |
| extraqs=&lt;form-id&gt;         | Designates which form to open for the `entityrecord`; if not specified, the default form will open. The `extraqs` parameter can also be used to default field values.        |
| id=&lt;record-id&gt;            | Designates which specific record to go to; if left blank, the create form for the entity will open |

If the link goes to an `entitylist` view, add the following parameters.

| **Parameter**                                                | **Description**                                                     |
|--------------------------------------------------------------|---------------------------------------------------------------------|
| etn=&lt;entity-logical-name&gt;                              | Designates which entity to go to                              |
| pagetype=entitylist                                          | Indicates that we're going to a view                               |
| viewid=&lt;view-id&gt;                                       | Designates which view to open                                       |
| Viewtype= &lt;1039 if system view, 4230 if personal view&gt; | Designates whether we're going to a system view or a personal view |

### Example URLs

| **Action**                                       | **Example of a deep-link URL**                                                                                                                                                                                                  |
|--------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Open a create form for Bookable resource booking | ms-apps-fs:// &lt;org-url&gt;\_&lt;app-id&gt;?tenantId=&lt;tenant-id&gt;&isShortcut=true&appType=AppModule&openApp=true&restartApp=true&forceOfflineDataSync=true&etn=bookableresourcebooking&pagetype=entityrecord&id=    |
| Open a Bookable resource booking with id=xyz     | ms-apps-fs:// &lt;org-url&gt;\_&lt;app-id&gt;?tenantId=&lt;tenant-id&gt;&isShortcut=true&appType=AppModule&openApp=true&restartApp=true&forceOfflineDataSync=true&etn=bookableresourcebooking&pagetype=entityrecord&id=xyz |
