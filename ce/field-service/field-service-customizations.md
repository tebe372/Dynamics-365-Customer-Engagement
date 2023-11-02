---
title: "Customize Dynamics 365 Field Service for your unique business needs | MicrosoftDocs"
description: Learn how to customize Field Service for your business needs.
ms.custom:
- dyn365-fieldservice
ms.date: 05/10/2023
ms.topic: article
author: lmasieri
ms.author: lmasieri
---

# Configure Dynamics 365 Field Service for your unique business needs

Administrators can configure Field Service to accommodate their unique business needs.

Find documentation to perform common configurations in the following table:

| Area | Documentation |
| --- | --- |
| Forms  | [Create, edit, or configure forms using the form designer](/powerapps/maker/model-driven-apps/create-and-edit-forms) |
|  Work orders | [Work order user interface settings](/dynamics365/field-service/create-work-order#work-order-user-interface-settings)  |
| Scheduling  | [Enabled scheduling for an entity](/dynamics365/field-service/schedule-new-entity)  |
| Scheduling  | [Customize Resource matching logic with custom fields](/dynamics365/common-scheduler/developer/understanding-and-customizing-resource-matching-in-urs)  |
|  Schedule board |  [Set up booking rules for customers to extend business logic](/dynamics365/field-service/set-up-booking-rules) |
| Scheduling  | [Resource availability API](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/21/retrieve-resource-availability-with-universal-resource-scheduling-api/) & [Sample code](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/15/how-to-use-resource-schedulings-search-resource-availability-api/)  |
| Scheduling  |  [Resource workhours extensibility](/dynamics365/field-service/field-service-work-hours-calendar-api) |
| Scheduling  |  [Use your preferred GPS provider](/dynamics365/common-scheduler/developer/use-preferred-geospatial-data-provider) |
| Mobile app  |  [Customize the Field Service mobile app](/dynamics365/field-service/mobile-power-app-configure) |
| Mobile app  | [Add a custom app module to the mobile app](/dynamics365/field-service/mobile-powerapp-copy-app-module)  |
| Mobile app  |  [Mobile workflows and JavaScript](/dynamics365/field-service/mobile-power-app-workflows) |
| Mobile app  |  [Use Microsoft Power Platform to configure the Field Service mobile app](/dynamics365/field-service/mobile-power-utilize-platform) |
| Scheduling  | [Edit work hour calendars by using APIs](/dynamics365/field-service/field-service-work-hours-calendar-api) |

## Undocumented custom controls

Field Service introduces controls that are only intended to be used as-is on the forms that use them by default.

Refrain from using the following controls in customization scenarios:

- MultiselectLookupControl
- msdyn_postponegenerationuntil
- It's intended for internal use only. Manipulating values in this field or taking dependencies on it is not supported and can lead to unexpected system behavior. This field is found in the following entities:
  - Agreement Booking Setup (msdyn_agreementbookingsetup)
  - Agreement Booking Date (msdyn_agreementbookingdate)
  - Agreement Invoice Setup (msdyn_agreementinvoicesetup)
  - Agreement Invoice Date (msdyn_agreementinvoicedate)
  - Order Invoicing Setup (msdyn_orderinvoicingsetup)
  - Order Invoicing Setup Date (msdyn_orderinvoicingsetupdate)
  - Order Invoicing Date (msdyn_orderinvoicingdate)
  - Incident Types Setup (msdyn_incidenttypessetup)
  - Quote Booking Setup (msdyn_quotebookingsetup)
