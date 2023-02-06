---
title: Field Service (Dynamics 365) mobile app overview (contains video)
description: Learn about the Field Service (Dynamics 365) mobile app, key features, and system requirements with this general overview.
ms.date: 02/06/2023
ms.topic: overview
ms.subservice: field-service-mobile
author: JonBaker007
ms.author: jobaker
search.app: 
  - D365CE
  - D365FS
---

# Field Service (Dynamics 365) mobile app overview

The Field Service (Dynamics 365) mobile app enables technicians to view and update work orders, customer assets, accounts, and more on the go. The app is available for Windows 10+, Apple iOS, and Google Android devices at no extra charge.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWN1Bb]

The mobile app is built on Microsoft Power Platform as a [model-driven app](/powerapps/maker/model-driven-apps/model-driven-app-overview), which makes it customizable to your business needs. It's included in your Field Service license.

## Features in the Field Service (Dynamics 365) mobile app

| Feature | Category | Field Service (Dynamics 365) mobile app |  Details |
| --- | --- | --- |  --- |
| [Camera capture (photo + video)](mobile-power-app-use.md#take-notes-with-attached-pictures-videos-and-files)) | Technician | Yes |  Use the device camera to capture images and video |
| [Barcode scanning](mobile-power-app-use.md#barcode-scanning) | Technician | Yes |  Scan bar code from global search or at a field level |
| [Offline data](mobile-power-app-use.md#work-offline-and-update-offline-data) | Technician | Yes |  Offline enabled application allows you to access your data regardless of internet connectivity. |
| [Calendar view](mobile-power-app-use.md#view-scheduled-work-orders) | Technician | Yes |   Customize your calendar with data relevant for your organization. |
| [Driving directions](mobile-power-app-use.md#travel-to-job-location) | Technician | Yes | Use your favorite in app map application for turn by turn directions |
| Speech to text | Technician | Yes | Insert notes with native device speech-to-text capabilities. |
| [Microsoft Intune](mobile-power-app-intune.md)  | Integration | Yes | Provide an extra layer of device and data protection with Microsoft Intune. |
| [Time entry](mobile-power-app-use.md#time-entry)  | Technician | Yes | In application Time Entry enabled by default |
| [Connected Field Service and IoT alerts](mobile-power-app-use.md#iot) | Technician | Yes |  Receive iOT signals and send commands directly from your mobile app. |
| [Inspections](inspections.md) | Technician | Yes | A Field Service technician can find and capture inspections associated with a work order. |
| [Dynamics 365 Remote Assist](/dynamics365/mixed-reality/remote-assist/overview-hololens) | Integration | Yes** | You can get help from remote collaborators with integrated Dynamics 365 Remote Assist. |
| [Push notifications](mobile-power-app-push-notifications.md) | Technician | Yes |  You can send user notifications, such as a new booking appointment and other out-of-the-box triggers. |
| [Geofencing](mobile-powerapp-geofence.md) | Technician | Yes* | You can automatically set booking status as a technician arrives or leaves a location. |
| [Reporting](mobile-powerapp-reporting.md) | Technician | Yes | You can generate customer service reports with a signature, with the option to email a PDF. |
| [Scan to find asset (Global search)](mobile-power-app-system-barcode-scanning.md) | Technician | Yes |  Not applicable |
| [Location sharing and auditing](mobile-powerapp-location-auditing.md) | Admin | Yes* | You can enable real-time sharing of the technician's location with the back office. |
| [Enhanced offline sync filters](mobile-power-app-system-offline.md) | Admin | Yes |  Data available offline by default and the data available offline can be customized. For example, offline data available by location or by accounts for scheduled bookings. |
| [Offline by default](mobile-power-app-system-offline.md#understanding-offline-vs-online-capabilities) | Technician | Yes |  The app is offline by default, so the technician is always ready. |
| [Allow technician to force data sync](mobile-power-app-use.md#work-offline-and-update-offline-data) | Technician | Yes |  The technician can manually force data sync. |
| Bulk-add users  | Admin | Yes|  You can quickly assign an offline data sync profile to users. |
| Checklist for service tasks  | Technician | Yes |  Use a checklist to quickly mark a task as complete. |

*coming soon to Windows

**not available on Windows

For information about planned features, refer to [Dynamics 365 Field Service release plans](/dynamics365/release-plans/).

## System requirements

The mobile app is available after [upgrading your environment](upgrade-field-service.md) to at least Field Service solution version 8.8.22+.

### Supported mobile devices

Field Service (Dynamics 365) mobile app is available for iOS, Android, and Windows platforms.

:::image type="content" source="media/mobile-2020-app-store-compare2.png" alt-text="Screenshot of the Field Service (Dynamics 365) mobile app in a mobile app store.":::

To provide the best experience for mobile app users, we recommend using modern devices with high [CPU Benchmark scores on Geekbench](https://browser.geekbench.com/v5/cpu/singlecore).

The required storage size depends on the [mobile offline profile](mobile-power-app-system-offline.md). It specifies the amount of data that your organization needs to download for when there's no internet access.

### iOS

[Get the iOS app.](https://aka.ms/fsmobile-apple)

|   |OS Version |CPU Benchmark Score| Storage|
| --- | --- |--- | --- |
| Minimum |	14 or later |	400+ |	64 GB	| 
| Recommended| 15 or later |	1000+	| 64+ GB	|

### Android

[Get the Android app.](https://aka.ms/fsmobile-google)

|   | OS Version  | CPU Benchmark Score   | RAM   | Storage   |
| ------------ | ------------ | ------------ | ------------ | ------------ |
| Minimum  | 9 or later   | 400+   | 4 GB   | 64 GB|
| Recommended  | 10 or later   | 900+   | 8 GB   | 64+ GB|

### Windows

[Get the Windows app.](https://aka.ms/fsmobile-win)

|   |OS Version |RAM| Storage|
| --- | --- |--- | --- |
| Minimum |	10 17763.0 or later |	6 GB |	64 GB	| 
| Recommended| 10 19042.1348 or later |	8 GB	| 128 GB	|

> [!NOTE]
> An important consideration before deploying the Field Service (Dynamics 365) mobile app is the hardware specification of the device used, such as memory and processor. Modifying the app with enhancements such as custom configurations and offline javascript may place additional requirements on system memory and processor. External factors, like other applications running on the device may also affect app performance.

## Next steps

- [Install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md)
- [Set up offline data and sync filters](mobile-power-app-system-offline.md)
- [Field Service (Dynamics 365) app for Windows 10+ devices](mobile-powerapp-windows.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
