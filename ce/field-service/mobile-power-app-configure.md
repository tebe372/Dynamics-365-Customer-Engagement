---
title: "Edit Sitemap entities (tables) on the home screen | MicrosoftDocs"
description: Learn about how to change the sitemap, forms, and views in the Field Service (Dynamics 365) mobile app.
ms.date: 11/09/2021
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

# Edit Sitemap entities (tables) on the home screen

Sign in to Dynamics 365 as a system administrator.

To see your list of apps, go to:

`https://[YOUR-ENVIRONMENT-NAME].crm.dynamics.com/main.aspx?forceUCI=1&pagetype=apps`

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
