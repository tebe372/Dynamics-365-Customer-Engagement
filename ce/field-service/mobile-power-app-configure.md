---
title: "Customize the Field Service (Dynamics 365) mobile app SiteMap, forms, and views | MicrosoftDocs"
description: Learn about how to change the sitemap, forms, and views in the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/01/2021
ms.reviewer: krbjoran
ms.topic: article
ms.service: dynamics-365-customerservice
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

# Customize the mobile app

Administrators can customize how the Field Service (Dynamics 365) mobile app looks and functions for technicians.

## Edit Sitemap entities on home screen

Sign in to Dynamics 365 as a system administrator.

To see your list of apps, go to:

```https://[YOUR-ENVIRONMENT-NAME].crm.dynamics.com/main.aspx?forceUCI=1&pagetype=apps```

Find the Field Service Mobile app and go to the **App Designer**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365, showing the list of apps and showing the option to open Field Service Mobile in the App Designer.](./media/mobile-2020-admin-app-designer.png)

Select the edit icon to edit the site map.

> [!div class="mx-imgBorder"]
> ![Screenshot of the App Designer in Power Apps, showing the Field Service Mobile site map option.](./media/mobile-2020-admin-sitemap1.png)

The groups  **My Work**, **Customers**, and **Other** correspond with the home screen of the Field Service (Dynamics 365) mobile app and you can rearrange, delete, or edit the display names.

Rearrange the entities displayed within each group with the drag and drop interface, or add new entities by adding new **Subareas**.


> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing the My Work, Customers, and Other groups on the Field Service Mobile App Designer.](./media/mobile-2020-admin-sitemap2.png)

You can even create entirely new groups with more subareas to display different entities.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing Field Service Mobile in the App Designer, and showing a simulated mobile device on the right with the corresponding changes.](./media/mobile-2020-admin-sitemap3.png)

> [!Note]
> For every entity you display in the sitemap, you can choose the views available on mobile in the App Designer.

## Edit the booking and work order form

You can add and delete fields displayed on the Field Service (Dynamics 365) mobile app; because the app is built with Power Apps, you can use the Power Apps Control Framework to display different field controls like toggle buttons and sliders.

Administrators who want to customize the booking and work order forms must know they are combined in the mobile app where work order forms are displayed within the booking form. That means when a technician views a booking form, they're also viewing the related work order form. In the following screenshot, the **General** section displays **Bookable Resource Booking** ("Booking") fields and the **Customer**, **Service**, and **Notes** sections display work order fields.


> [!div class="mx-imgBorder"]
> ![Simulated image showing a device with the Field Service (Dynamics 365) mobile app, showing a screenshot of a Bookable Resource Booking on the General tab.](./media/mobile-2020-work-order-form-all-sections.png)

To edit the work order portion of the form, go to **Settings** > **Customizations** > **Customize the System** and find the **Work Order** entity in the Power Apps admin console.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the list of entities.](./media/mobile-2020-admin-work-order-form.png)

In the **Form** section, there are three forms that correspond to the three sections of the combined Booking-Work Order form.

1. Work Order - Customer
2. Work Order - Service
3. Work Order - Notes

Edit each form as needed and publish. The changes will display in the Field Service (Dynamics 365) mobile app.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the work order form details.](./media/mobile-2020-admin-work-order-form-tabs.png)

To edit the **Booking** part of the form, go to the **Bookable Resource Booking** entity in the Power Apps admin console.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Bookable Resource Booking in the Power Apps list of entities.](./media/mobile-2020-admin-booking-form.png)

Find the **Booking and Work Order** form, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Bookable Resource Booking in Power Apps, showing the Booking and Work Order form.](./media/mobile-2020-admin-booking-form-combined.png)

Add and delete booking fields as needed.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the form editor for the Bookable Resource Booking.](./media/mobile-2020-admin-booking-form-combined-add-fields.png)

Another way you can add work order information to the booking form is to add a [quick view form](../customerengagement/on-premises/customize/create-edit-quick-view-forms.md) that displays work order fields. Quick view forms are read-only, but you can go to the related work order form from there.

>[!TIP] 
> The combined _Booking and Work Order_ form is made possible by a PCF control called "Form component control." For more information, see the article on
[editing related table records directly from another table’s main form](/powerapps/maker/model-driven-apps/form-component-control) for more details.

For more general information, see the article on [customizing entity forms](/powerapps/developer/model-driven-apps/customize-entity-forms).

## Edit views

- [Create and edit public or system model-driven app views](/powerapps/maker/model-driven-apps/create-edit-views-app-designer) 

- [Customize entity views](/powerapps/developer/model-driven-apps/customize-entity-views)

> [!Note]
> Currently, the booking calendar view is not editable. You cannot edit the fields displayed in the time slots on the calendar.

### See also

- [What are model-driven apps in Power Apps?](/powerapps/maker/model-driven-apps/model-driven-app-overview)
- [Model-driven apps developer documentation](/powerapps/developer/model-driven-apps/)
- [Enable entities for mobile offline synchronization](../mobile-app/setup-mobile-offline-for-admin.md#step-1-enable-entities-for-mobile-offline-synchronization)
- [Editing related table records directly from another table’s main form](/powerapps/maker/model-driven-apps/form-component-control)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
