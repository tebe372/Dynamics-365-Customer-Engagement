---
title: "Dynamics 365 Field Service version history | MicrosoftDocs"
description: Version history for Dynamics 365 Field Service
ms.date: 08/02/2023
ms.topic: article
author: jshotts
ms.author: jasonshotts
---

# Dynamics 365 Field Service version history

## Release schedule

When a new version of Dynamics 365 Field Service releases, it becomes available in different geographic regions at different times. Use the table below to see when the next release will become available in the region of your environment.

For information about other updates to Field Service, visit the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](version-history-archive.md#field-service).

| Station | Region | Current version | Next version | Scheduled date |
| ------- | ------ | --------------  | -----------  | -------------  |
|**Station 1** |  *First Release*| [8.8.102.29](/dynamics365/field-service/version-history#8810229)  | TBD |10/13/2023 |
|**Station 2** |  *South America, Canada, India, France, South Africa, Germany, Switzerland, Norway, Korea*| [8.8.102.29](/dynamics365/field-service/version-history#8810229)  | TBD |10/20/2023 |
|**Station 3** | *United Arab Emirates, Japan, Asia Pacific, United Kingdom, Oceania* | [8.8.102.29](/dynamics365/field-service/version-history#8810229)  | TBD |10/27/2023 |
| | *USG* |[8.8.102.29](/dynamics365/field-service/version-history#8810229)  | TBD |10/20/2023 |
|**Station 4** |*Europe* |  [8.8.99.10](/dynamics365/field-service/version-history#889910) |  [8.8.102.29](/dynamics365/field-service/version-history#8810229)  | 10/13/2023 |
|**Station 5** | *North America*|[8.8.98.36](/dynamics365/field-service/version-history#889836)  | [8.8.99.10](/dynamics365/field-service/version-history#889910)  | 10/13/2023 |
|**Station 6** |*Government Community Cloud, DoD, China*  |[8.8.98.36](/dynamics365/field-service/version-history#889836)  | [8.8.99.10](/dynamics365/field-service/version-history#889910)  | 10/13/2023 |
| | *Dedicated Scale Groups* | [8.8.98.36](/dynamics365/field-service/version-history#889836)  | [8.8.99.10](/dynamics365/field-service/version-history#889910)  | 10/20/2023 |
>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC), USG, and China indicate the timing of the next automatic update. Dates in GCC, USG, and China indicate version availability; at this time, there is no automatic update for the GCC, USG, and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 8.8.102.29
(Includes Universal Resource Scheduling version [3.12.117.31](/dynamics365/field-service/field-service-version-history-resource-scheduling#31211731) and Resource Scheduling controls version 1.2.56.23269).

- **New and improved work order experience:** Our new work order enhancements are designed to make your life easier. With reduced time and effort required to understand the current state of work orders, you can provide quick updates to customers, ensure that frontline workers have the information they need for on-site service, and easily track high-priority work. The dynamic card feature allows you to take action and move work orders through each stage seamlessly, while our redesigned tasks experience and reference tab streamline the knowledge-sharing process for everyone involved.
- **AI-powered work order recap:** Copilot in Field Service helps your workforce save time and work more efficiently by bringing disparate pieces of information together, providing a concise summary of a work order. This feature works across all experiences: desktop application, web, and mobile.
- **Maintain customer facilities with enhanced capabilities:** [New location types](functional-locations.md#create-and-assign-functional-location-types-preview) allow organizations to better manage complex buildings, campuses, and factories and location properties enable service providers to capture and organize critical location information.
- **Expedite service delivery with extended customer details:** [Capture manufacturer warranties, tag assets](warranties.md), and note location contact information to give frontline workers a comprehensive view of the asset they need to service, including where it is, if it's covered under warranty, and contacts where it's located.
- **Manage frontline worker certifications:** [Organizations can track insurance](insurance.md), licenses, and certifications for frontline workers via the new insurance table, and [enhanced characteristics](set-up-characteristics.md#enhanced-characteristics-preview) to ensure they can complete work at the quality customers expect and in compliance with legislation.
- Booking end times no longer get updated to the current time upon booking completion.


## 8.8.99.10
(Includes Universal Resource Scheduling version [3.12.112.5](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121125) and Resource Scheduling controls version 1.2.52.232511).

- Fixed a problem causing IoT properties to be converted from a string to a date value if a 4 digit number is entered.
- Dynamics 365 Field Service mobile: Fixed a race condition in inspections which could result in an error if work order service task is marked as complete quickly after the inspection is completed.
- Updated inspections to prevent inspection response from being created in some unexpected scenarios.


## 8.8.101.95 (2023 Wave 2 early access, update2)

(Includes Universal Resource Scheduling version [3.12.116.5](/dynamics365/field-service/field-service-version-history-resource-scheduling#312116.5---2023-wave-2-early-access-update2
) and Resource Scheduling controls version 1.2.55.232482).

Fixed 38 bugs across the new work order experience, insurance views on accounts, and locations categories forms. Some of the critical fixes included:
-	Fixed a problem causing inline edits to quantities to not affect quantities to bill on work order products.
-	Fixed a problem hiding service account contact details and preventing adding details in the contact sub grid on new work order. 
-	Fixed a problem hiding service tasks from the new work order form related menu.
-	Fixed a problem preventing estimated subtotal price from showing when the estimate is 0.
-	Fixed a problem where nothing would happen when trying to expand timeline notes from the work order side pane.

- Dynamics 365 Field Service mobile app: [Work Order Recap](work-order-recap.md) preview for bookings and work orders on mobile.

## 8.8.98.36
(Includes Universal Resource Scheduling version [3.12.111.36](/dynamics365/field-service/field-service-version-history-resource-scheduling#31211018) and Resource Scheduling controls version 1.2.51.232411).

- Fixed a bug that caused errors when navigating to Field Service settings.
-	Job status on Field Service System Jobs is no longer required and will not be set to pending.
- Dynamics 365 Field Service mobile app: Fixed an accessibility bug by showing a string that informs the user when a required date field is not filled. 
- Dynamics 365 Field Service mobile app: Fixed a crash in the Inspections control that could happen when the user interacts with date fields. 
 
## 8.8.97.44
(Includes Universal Resource Scheduling version [3.12.110.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#31211018) and Resource Scheduling controls version 1.2.50.232152).

- Dynamics 365 Field Service mobile app: Fixed a bug to prevent a JavaScript error when accessing a Bookable Resource Booking with Offline Classic mode enabled. 
- Dynamics 365 Field Service mobile app: Significantly improved reliability of the application when multiple images are uploaded within an Inspection.
- Dynamics 365 Field Service mobile app: Improved error messages to be more actionable when missing customer voice survey responses in Inspections.
- Dynamics 365 Field Service mobile app: Fixed a visibility issue that occurs when exporting to PDF the Inspections questions in a survey that contains logic.

## 8.8.101.57 (2023 Wave 2 early access, update1)

(Includes Universal Resource Scheduling version [3.12.114.11](/dynamics365/field-service/field-service-version-history-resource-scheduling#312114.11---2023-wave-2-early-access-update1) and Resource Scheduling controls version 1.2.54.232001).

**New and improved work order experience**: Our new work order enhancements are designed to make your life easier. With reduced time and effort required to understand the current state of work orders, you can provide quick updates to customers, ensure that frontline workers have the information they need for on-site service, and easily track high-priority work. The dynamic card feature allows you to take action and move work orders through each stage seamlessly, while our redesigned tasks experience and reference tab streamline the knowledge-sharing process for everyone involved.

**AI-powered work order recap**: Copilot in Field Service helps your workforce save time and work more efficiently by bringing disparate pieces of information together, providing a concise summary of a work order. This feature works across all experiences: desktop application, web, and mobile.


## 8.8.101.48  (2023 Wave 2 early access)

(Includes Universal Resource Scheduling version [3.12.115.1](/dynamics365/field-service/field-service-version-history-resource-scheduling#312115.1---2023-wave-2-early-access-ea-release) and Resource Scheduling controls version 1.2.54.232001).

- **Maintain customer facilities with enhanced capabilities**: [New location types](functional-locations.md#create-and-assign-functional-location-types-preview) allow organizations to better manage complex buildings, campuses, and factories and location properties enable service providers to capture and organize critical location information.

- **Expedite service delivery with extended customer details**: [Capture manufacturer warranties, tag assets](warranties.md), and note location contact information to give frontline workers a comprehensive view of the asset they need to service, including where it is, if it's covered under warranty, and contacts where it's located.

- **Manage frontline worker certifications**: [Organizations can track insurance](insurance.md), licenses, and certifications for frontline workers via the new insurance table, and [enhanced characteristics](set-up-characteristics.md#enhanced-characteristics-preview) to ensure they can complete work at the quality customers expect and in compliance with legislation.

- Booking end times no longer get updated to the current time upon booking completion.

## 8.8.96.23
(Includes Universal Resource Scheduling version [3.12.109.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121092) and Resource Scheduling controls version 1.2.49.231861).

- Dynamics 365 Field Service mobile app: Fixed an accessibility bug so users can modify product quantity with a keyboard from the Service Tasks sub-grid control.
  
## 8.8.95.25
(Includes Universal Resource Scheduling version [3.12.108.5](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121085) and Resource Scheduling controls version 1.2.48.231771).

- Fixed a bug causing IoT Alert statuses to change when no change to the Work Order system status has occurred.
- Fixed a bug in Dynamics 365 Field Service mobile app that prevented updating status of a work order product when the record is created from within the mobile application.
- Fixed an accessibility bug in the inspection designer to correctly reflow the interface under different resolutions.
- Fixed an accessibility bug in the inspection designer to make “move” and “delete” buttons accessible via keyboard.
- Fixed an accessibility bug in the inspection designer so Narrator announces when a field is marked as required. 

## 8.8.94.28
(Includes Universal Resource Scheduling version [3.12.107.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121072) and Resource Scheduling controls version 1.2.47.231641).

- Fixed an issue that duplicated the *Confirm invoice* button in non-Field Service entities.
- Dynamics 365 Field Service mobile app: Fixed a bug in the Inspections Template Designer where the template was not accessible after changing device orientation from landscape to portrait.
- Dynamics 365 Field Service mobile app: Enabled Windows app button *Update Geo Location* on customer asset entity.

## 8.8.93.28
(Includes Universal Resource Scheduling version [3.12.106.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121067) and Resource Scheduling controls version 1.2.46.231371).

- Added graceful handling of addresses that are too long to be converted to latitude and longitude values.
- Fixed a bug preventing time entry approval when a resource has a null hourly rate and the work pay type has a non-zero hourly markup.
- Inspections: Fixed a bug where the incorrect UTC time offset was applied when writing Date Time inspection response data to Dataverse. Note this may have the side effect of surfacing in the UI the values that were previously incorrectly written.
- Dynamics 365 Field Service mobile app: Updated the Quick Notes control to have verbose save failures in instances when the control is misconfigured and/or duplicate copies of the control is added to a single form. 

## 8.8.92.27
(Includes Universal Resource Scheduling version [3.12.105.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210525) and Resource Scheduling controls version 1.2.45.231281).

-	Fixed a problem preventing IoT device visualization from initializing.
-	Command lookup on the IoT Command form now correctly appears as optional.
-	Fixed a problem with console errors when a user interacts with a work order that has a service or billing account that they do not have read permissions for.
- Fixed a bug in the inspections designer which prevented access to all attributes when an entity lookup contained more than 50 items. 
- Dynamics 365 Field Service mobile app: Updated PowerApps Component Framework controls to adopt recent API changes related to nested linked entities.


## 8.8.91.36
(Includes Universal Resource Scheduling version [3.12.104.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210414) and Resource Scheduling controls version 1.2.44.231111).

- Improved performance of booking creation.
- Dynamics 365 Field Service mobile app: Updated solution package to ship standard forms for msdyn_bookableresourcebookingquicknote.

## 8.8.89.38
This release is a hotfix on Field Service version [8.8.89.34](/dynamics365/field-service/version-history#888934).

(Includes Universal Resource Scheduling version [3.12.103.21](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210321)).

- Fixed a bug that prevented saving records after an address change when Auto Geocode Address and Enable Address Suggestions are enabled in Field Service settings.

## 8.8.89.34
(Includes Universal Resource Scheduling version [3.12.103.12](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210312) and Resource Scheduling controls version 1.2.43.230971).

- Fixed a bug preventing work orders created from an asset to have their location set to the asset’s functional location.
- NVDA/Narrator now announces status message “Match found” when searching a keyword in the assets and location tab on accounts, assets, and locations.

## 8.8.88.62
This release is a hotfix on Field Service version [8.8.88.56](/dynamics365/field-service/version-history#888856).

(Includes Universal Resource Scheduling version [3.12.102.24](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210324)).

- Fixed a bug that prevented saving records after an address change when Auto Geocode Address and Enable Address Suggestions are enabled in Field Service settings.

## 8.8.88.56
This release is a hotfix on Field Service version [8.8.88.54](/dynamics365/field-service/version-history#888854).

- Fixed a bug preventing some EA customers using the NTE control from being able to upgrade to GA.
- Fixed a bug preventing the asset and functional location trees from loading when tens of thousands of assets exist in the system.

## 8.8.88.54 (2023 wave 1 release)
(Includes Universal Resource Scheduling version [3.12.102.17](/dynamics365/field-service/field-service-version-history-resource-scheduling#31210217---2023-wave-1-release) and Resource Scheduling controls version 1.2.42.230871).

-	Use the [Not-to-exceed feature](/dynamics365/field-service/work-order-not-to-exceed) to ensure cost and price expectations on work orders are met every time.
-	[Organize your provided services based on trades](/dynamics365/field-service/trades#configure-trade-coverages), and set up trade coverages based on which services you provide to groups of customers.
- Use global search to quickly search for and navigate to bookings.
- New price and cost summaries have been added to work orders to track financials. Enable or disable cost tracking in field service settings. Cost information and cost amount cards on work order products and services are now controlled by the Calculate Cost toggle in Field Service settings. Organizations that disabled the Calculate Price toggle will have these sections appear on work order products and services unless they turn off the Calculate Cost toggle.
- Dynamics 365 Field Service mobile app: [AsyncOnSave](/power-apps/developer/model-driven-apps/clientapi/reference/events/form-onsave#asynchronous-event-handler-support) is enabled for the Field Service Mobile app module.
- Dynamics 365 Field Service mobile app: Booking agenda has options for week & month view on iOS and Android tablets and the Windows application.
- Dynamics 365 Field Service mobile app: Updated survey creator control to exclude survey meta data from telemetry.

## 8.8.87.35 (2023 Wave 1 early access, update1)

(Includes Universal Resource Scheduling version [3.12.101.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121013---2023-wave-1-early-access-update-1) and Resource Scheduling controls version 1.2.41.230631).

This release is an update to Field Service 2023 Wave 1 early access version [8.8.87.7](/dynamics365/field-service/version-history#88877).

- Use the [Not-to-exceed feature](/dynamics365/field-service/work-order-not-to-exceed) to ensure cost and price expectations on work orders are met every time.
- [Organize your provided services based on trades](/dynamics365/field-service/trades#configure-trade-coveragess), and set up trade coverages based on which services you provide to groups of customers.

- Use global search to quickly search for and navigate to bookings.
- New price and cost summaries have been added to work orders to track financials. Enable or disable cost tracking in settings.
- Dynamics 365 Field Service mobile app: Replaced [deprecated Input Number](/power-platform/important-changes-coming#model-driven-app-controls-deprecation) control with standard text input field.

Note: There is a known issue where an incident type's trade is applied to work orders when trade is disabled. 

## 8.8.84.16

This release is a hotfix on Field Service version [8.8.84.13](/dynamics365/field-service/version-history#888413).

-  Dynamics 365 Field Service mobile app: Updated survey creator control to exclude survey meta data from telemetry.

## 8.8.84.13
(Includes Universal Resource Scheduling version [3.12.98.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#312987) and Resource Scheduling controls version 1.2.38.230543).

-  No updates were made to Dynamics 365 Field Service in this release.

## 8.8.83.23

This release is a hotfix on Field Service version [8.8.83.21](/dynamics365/field-service/version-history#888321).

-  Dynamics 365 Field Service mobile app: Updated survey creator control to exclude survey meta data from telemetry.

## 8.8.83.21

This release is a hotfix on Field Service version [8.8.83.19](/dynamics365/field-service/version-history#888319).

(Includes Universal Resource Scheduling version [3.12.97.18](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129718) and Resource Scheduling controls version 1.2.37.230406).

-  No updates were made to Dynamics 365 Field Service in this release.

## 8.8.83.19
(Includes Universal Resource Scheduling version [3.12.97.9](/dynamics365/field-service/field-service-version-history-resource-scheduling#312979) and Resource Scheduling controls version 1.2.37.230406).

- Fixed a bug that prevented opportunities to be converted to work orders when the account is indirectly linked through the opportunity contact.
- Fixed a bug preventing work order Completed On time from being set when the work order status changed to posted and at least one open booking is cancelled.
- Dynamics 365 Field Service mobile app: Android app now supports image multi-select when uploading to inspections.
- Dynamics 365 Field Service mobile app: Fixed a bug which was preventing export of inspection response to PDF when the inspection template included a question with date/time format.
- Dynamics 365 Field Service mobile app: Fixed a bug on the Windows application where in some locales the “get directions” link did not pass the supported lat/long format for local version of Bing Maps.
- Dynamics 365 Field Service mobile app: Fixed a bug to delay work order form save if Duration is updated without corresponding Duration to Bill field update.


## 8.8.87.7 (2023 Wave 1 early access)

(Includes Universal Resource Scheduling version [3.12.100.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#3121002---2023-wave-1-early-access) and Resource Scheduling controls version 1.2.40.230251).

The release is only applied when an environment is opted into Early Access and introduces the Field Service 2023 Wave 1 features.

- The asset and functional location tree view control will better support having assets with children located elsewhere. Assets at a different functional location than their parent asset will now show as both a child asset and as a child of the functional location with info icons calling out the nuances.

## 8.8.82.52
This release is a hotfix on Field Service version [8.8.82.35](/dynamics365/field-service/version-history#888235).

(Includes Universal Resource Scheduling version [3.12.96.38](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129638)).

 - No updates were made to Dynamics 365 Field Service in this release.



## 8.8.82.35
(Includes Universal Resource Scheduling version [3.12.96.25](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129625)) and Resource Scheduling controls version 1.2.36.230171).

- Greatly improved the performance of the asset and functional location tree control for large hierarchies.

## 8.8.81.89

This release is a hotfix on Field Service version [8.8.81.81](/dynamics365/field-service/version-history#888181).

- Fixed an issue where the functional location and asset tree control would sometimes display the wrong hierarchy.

## 8.8.81.81

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214)) and Resource Scheduling controls version 1.2.35.223541).

- Significant performance improvements of the asset and functional location tree control to support large hierarchies.
- Fixed a bug causing work orders to be left in a partially deleted state when deletion failed.
- Dynamics 365 Field Service mobile app: AsyncOnSave has been enabled for Work Order validations.
- Dynamics 365 Field Service mobile app: Fixed a bug where an unexpected error could occur in the mobile app if msdyn_incidedenttyperesolution table is removed from the mobile offline profile.
- Dynamics 365 Field Service mobile app: Fixed a bug in read-only inspections that a multi-line text box expands correctly.

## 8.8.80.48

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214)) and Resource Scheduling controls version 1.2.34.223411).

- Fixed a bug causing RTV substates to be lost after editing.
- Fixed a problem preventing inventory transfer search from filtering results.

## 8.8.79.32

This release is a hotfix on Field Service version [8.8.79.18](/dynamics365/field-service/version-history#887918).

- Dynamics 365 Field Service mobile app: Fixed keyboard visibility when interacting with entity lookup within an inspections question. 
 
## 8.8.79.18

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214) and Includes Resource Scheduling controls version 1.2.32.222981).

- Dynamics 365 Field Service mobile app: When exporting a PDF of inspections responses, images which were uploaded as part of the inspection will be sized to fit the page and maintain their original aspect ratio.
- Fixed a bug preventing the deletion of work order service tasks with the deletion of work orders
- Fixed a bug showing inactive functional locations on work order location lookups.

## 8.8.78.41

This release is a hotfix on Field Service version [8.8.78.23](/dynamics365/field-service/version-history#887823).

Dynamics 365 Field Service mobile app:  fixed a bug impacting Field Service **<8.8.78.23>** which intermittently resulted in an error when accessing the Booking Status control.

## 8.8.78.23

(Includes Universal Resource Scheduling version [3.12.92.14](/dynamics365/field-service/field-service-version-history-resource-scheduling#3129214)).

- Fixed a bug that prevented showing the **View all** button during reflow of frontline worker setup.
- Fixed a bug that prevented accessing the **Play** button via keyboard on Getting Started.
- Sales Tax Code now shows quick create of taxable work orders.
- Dynamics 365 Field Service mobile app: Added support for advanced filtering of date/time on the calendar control.

## 8.8.77.41

(Includes Universal Resource Scheduling version [3.12.91.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312912)).

   - Fixed a bug causing an error when loading an existing knowledge article from work order or product forms.
   - Dynamics 365 Field Service mobile app: When an Offline enabled mobile application has network access, it will now fetch data from the server if the record is not found in the mobile offline profile. If network access is not available to the device requesting a record not found in the offline profile, a more specific error message will be shown to the user informing them of the missing table.
   - Dynamics 365 Field Service mobile app: Improvements to device memory management while using the mobile application.
   - Dynamics 365 Field Service mobile app: Fixed a bug which was preventing the agenda view from being available on certain tablet models.
   - Dynamics 365 Field Service mobile app: Improved an error message that was shown when trying to mark a product as used from the service task sub-grid while the product is inactive.
   - Dynamics 365 Field Service mobile app: Fixed a bug which was preventing Inspections - File Type question from selecting multiple files.

   
## 8.8.76.55

This release is a hotfix on Field Service version [8.8.76.42](/dynamics365/field-service/version-history#887642).

(Includes Universal Resource Scheduling version [3.12.90.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312902)).

(Includes Resource Scheduling controls version 1.2.30.222771).

No updates were made to the Dynamics 365 Field Service mobile app in this release.

## 8.8.76.42

(Includes Universal Resource Scheduling version [3.12.90.2](/dynamics365/field-service/field-service-version-history-resource-scheduling#312902)).

-	Fixed a bug in which the duration field is not copied from a requirement group template associated with an incident type to the work order.
- Dynamics 365 Field Service mobile app: Tabs will persist on screen while scrolling down within a form, allowing a user to navigate to a new tab without scrolling to the top of the form. This feature is enabled by default for the Field Service Mobile app module and needs to be [enabled via App Settings for custom app modules](mobile-power-app-faq.yml).
- Dynamics 365 Field Service mobile app: When exporting inspections response to PDF, questions marked as not visible will not be exported and visible in the PDF. 

## 8.8.75.142(2022 Wave 2 early access, update2)

This release is an update to Field Service 2022 Wave 2 early access version [8.8.75.59](/dynamics365/field-service/version-history#887559).

(Includes Universal Resource Scheduling version [3.12.88.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312883---2022-wave-2-early-access-update-2)).

## 8.8.74.34

(Includes Universal Resource Scheduling version [3.12.85.11](/dynamics365/field-service/field-service-version-history-resource-scheduling#3128511)).

- Fixed a bug preventing setting visibility of a question through two rules in Inspection logic.
- Fixed a bug preventing the create new button from appearing on Time Entry Screen when Offline Profile is enabled.
- Dynamics 365 Field Service mobile app: Improved device memory usage when accessing the Work Order Service Task Inspection control.
- Dynamics 365 Field Service mobile app: Fixed a bug so form validation won't run when the form is clean. This will reduce error “Validations have been restarted in the background because of inconsistent validation data.”

## 8.8.73.63

(Includes Universal Resource Scheduling version [3.12.84.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312843)).

- Fixed a bug that showed a null exception when the EstimatedDuration field wasn't on work order incident form.
- Fixed an accessibility issue with high contrast mode on Connected Field Service device readings that prevented the show/hide controls from being displayed.
- Fixed a bug preventing device IDs from being set on Connected Field Service devices during a form refresh.
- Fixed a bug that prevented setting Lat/Lon when a functional location’s address is partially updated.
- Fixed a bug on inventory adjustment product form that created errors when the inventory transfer field is removed through customization.
- Bing maps will now be enabled by default for non-EU regions, and resource scheduling will connect to maps by default.
- Dynamics 365 Field Service mobile app: Added an app setting to enable 2022 Wave 2 changes to the mobile command bar. Changes include removing commands (Delete & Process) when not applicable to the user role, moving some underused commands to the end of the command list, and moving the command bar to top of the screen on tablet devices.

## 8.8.75.59 (2022 Wave 2 early access, update1)

This release is an update to Field Service 2022 Wave 2 early access version [8.8.75.36](/dynamics365/field-service/version-history#887536).

(Includes Universal Resource Scheduling version [3.12.87.3](/dynamics365/field-service/field-service-version-history-resource-scheduling#312873---2022-wave-2-early-access-update-1)).

- Fixed a bug in reflowing the connected field service tree control that prevented the ‘more options’ button and ‘show assets’ checkbox from being visible.

## 8.8.72.55

This release is a hotfix on Field Service version [8.8.72.27](/dynamics365/field-service/version-history#887227).

- A bug in inspection flows prevented service tasks from being marked completed.

## 8.8.72.27

(Includes Universal Resource Scheduling version [3.12.83.6](/dynamics365/field-service/field-service-version-history-resource-scheduling#312836)).

- Fixed a bug that showed inactive location records in the asset & location tree view.
- Fixed a bug on work order form load that prompted users with insufficient permissions to read service account details.
- Fixed a bug that prevented units from being populated on a new inventory adjustment through the quick create form.
- Fixed a bug in the initialization of work order functional location entity references that caused dependent customizations to fail.

## 8.8.75.36 (2022 Wave 2 early access)

(Includes Universal Resource Scheduling version [3.12.86.7](/dynamics365/field-service/field-service-version-history-resource-scheduling#312867---2022-wave-2-early-access)).

The release is only applied when an environment is opted into Early Access and introduces the [Field Service 2022 Wave 2](/dynamics365-release-plan/2022wave2/service/dynamics365-field-service/planned-features) new and updated features as outlined in the release notes.

In addition, this release also includes the following changes:

- Fixed a bug where estimated duration wasn't set on work order services created from agreements.
- Fixed a bug where resource pay type wasn't reflected in actuals when Time Cost Actuals Source is set to 'Work Order Time Entry Approval'.
