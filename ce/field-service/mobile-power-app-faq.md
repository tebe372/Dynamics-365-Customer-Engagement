---
title: "Frequently asked questions for Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Find answers to commonly asked questions about the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/06/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: troubleshooting
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

# Frequently asked questions for the Field Service (Dynamics 365) mobile app

## Why does the app say "Contact your administrator for access to your organization's mobile apps"?


> [!div class="mx-imgBorder"]
> ![Screenshot of the "Contact your administrator" issue.](./media/mobile-2020-error-contact-administrator-show-nonproduction-apps.png)

If you are getting this message, try the following steps:

1. The list shows production apps by default and you may be using a trial or sandbox. Select the menu icon in the top left and toggle **Show non-production apps** to _Yes_. 
2. Make sure you have the correct security role (Field Service - Resource) and that the security role is assigned to the Field Service Mobile app.
3. Sign in again, pull down the screen to refresh and wait for at least a few minutes.
4. If completing steps 1 and 2 does not resolve the issue, [submit a support ticket](https://dynamics.microsoft.com/contact-us/).

## Can I only add and view Field Service entities on the Field Service (Dynamics 365) mobile app?

Because the Field Service (Dynamics 365) mobile app is a model-driven app on the Power Platform, any entity can be added; users can only see entities and records that they have the licenses and security to access, regardless of whether it's part of the Field Service app or not.

## Why is the app saying "You're almost there"?

> [!div class="mx-imgBorder"]
> ![Screenshot of the "you're almost there" issue.](./media/mobile-2020-youre-almost-there.png)

If you are getting the error "You're almost there" after signing in to the mobile app, try the following steps:

1. Make sure you have the correct security role (Field Service - Resource) and that the security role is assigned to the Field Service Mobile app.
2. Sign in again, pull down the screen to refresh and wait for at least a few minutes
3. If completing both steps 1 and 2 above do not resolve the issue, [submit a support ticket](https://dynamics.microsoft.com/contact-us/).

## Why doesn't the bookable resource booking form show work order details like **Customer**, **Service**, and **Notes**?

Sometimes you may not see the correct booking form. You may see the following result:

> [!div class="mx-imgBorder"]
> ![Screenshot of the wrong from issue.](./media/mobile-2020-faq-wrong-booking-form.png)

If you see something like the previous screenshot, you're viewing the booking form, and *not* the combined booking and work order form.

To solve this issue, make sure the user you're signed into the mobile app as has the **Field Service - Resource** security role. Also ensure that the right form (the mobile optimized Booking and Work Order form) is associated with the Booking entity in the app designer.

## I can't see the calendar or the wrong calendar is showing

To fix this issue, make sure the **Booking Calendar Control** is enabled for phones and tablets from the bookable resource booking entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of the mobile booking calendar control.](./media/mobile-2020-booking-calendar-control.png)

## Can I customize the default booking calendar control, such as by changing the booking cell content

Currently, customizations of the default booking calendar control are not supported.

## Is there a maximum number of records supported by the offline profile

There is no limitation to the number of records that can be downloaded in offline mode outside of the physical device limitations. Going beyond 2MB per record is not recommended. Keep in mind that the sync duration will depend on the number and size of records being synced, as well as the quality of the network that the mobile device is connected to. For a good user experience, it is recommended that the offline profile only include the data that is relevant to the user. The configuration of the out-of-the-box offline profile takes into account the common scenarios faced by field service technicians and mobile app users.

For further details, review the [platform documentation](https://docs.microsoft.com/dynamics365/mobile-app/mobile-offline-capabilities).