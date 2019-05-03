---
title: "Enable LinkedIn Sales Navigator for Dynamics 365 | Microsoft Docs"
description: "Enable the LinkedIn Sales Navigator for Dynamics 365 capabilities"
keywords: "installation, setup, sales navigator"
ms.date: 04/17/2019
ms.service: crm-online
ms.topic: article
applies_to: 
  - "Dynamics 365 Version 9.x"
  - "Dynamics 365 (online)"
ms.assetid: 4b15aff2-3a7b-3488-260c-21611dee658a
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365LinkedIn
---

# Enable default LinkedIn Sales Navigator controls

## Prerequisites

- You have a System Administrator security role in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. 
- You have a [Microsoft Relationship Sales subscription](https://dynamics.microsoft.com/sales/relationship-sales/) for Dynamics 365   
--OR--   
You will need to sign your team up for [LinkedIn Sales Navigator Team](https://business.linkedin.com/sales-solutions) or [LinkedIn Sales Navigator Enterprise](https://business.linkedin.com/sales-solutions).    
  We recommend having a Sales Navigator Administrator + Team Member seat to complete the installation. However, you may use a Sales Navigator Administrator seat.
- You will need to enable JavaScript in your browser.
- You will need to disable your pop-up blocker for the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] domain.

> [!NOTE]
> In April 2019, we introduced changes to how the Sales Navigator controls are enabled. The out-of-the-box experience provides all features of V1 and V2 LinkedIn Sales Navigator integrations except the profile photo sync feature that comes as part of V2 when CRM Sync is enabled.   
>    
> Here are a few things to consider if you don't plan to enable the integration.    
> 1. Three solutions related to the LinkedIn integration appear in the **All Solutions** view in **Settings** > **Customizations** > **Solutions**. Although these solutions are pre-installed, the functionality and data transfer between the two systems will disabled unless you [enable the Sales Navigator controls](#enable-the-default-sales-navigator-controls). Additionally, **CRM Sync** needs to be explicitly enabled on the LinkedIn Sales Navigator Admin Settings.    
>    ![List of LinkedIn related solutions](media/solution-list.png)
> 2. System customizers will see the new LinkedIn controls in Account, Contact, Lead, and Opportunity form editors. However, their default visibility is turned OFF and end users will not be able to see these controls on the forms unless the feature is enabled by a system administrator. Customizers can remove these controls from the pages as they would remove any control in case they find it too distracting.    
>    ![Visibility settings in tab properties](media/visibility-settings.jpg)
> 3. While using **Advanced Find**, end users see the new entities introduced by these solutions (InMails, Messages, and PointDrive Presentation Viewed) even if the integration is not enabled. This is the intended behavior and users can ignore these entities if they are not actively using the LinkedIn Sales Navigator integration.

## Enable the default Sales Navigator controls

The following procedure guides administrators to enable default controls for LinkedIn Sales Navigator content. The Sales Navigator controls will appear on Account, Contact, Lead, and Opportunity pages by default. However, you can still customize other forms and entities to show Sales Navigator controls.

1. In Dynamics 365 for Sales, go to **Settings** > **Business Management**.
   ![Clickpath for Business Management settings](media/business-management-settings.png)
2. Select **LinkedIn Sales Navigator**.
3. Select the **Enable Sales Navigator Integration** checkbox.
   ![Enable the Sales Navigator integration](media/sales-navigator-dialog-box.png)
4. Select **Ok** to enable the integration.

## Disable the default Sales Navigator controls

Disabling the integration will stop showing the Sales Navigator controls. 

1. In Dynamics 365 for Sales, go to **Settings** > **Business Management**.
2. Select **LinkedIn Sales Navigator**.
3. Remove the check mark from the **Enable Sales Navigator Integration** checkbox.
4. Select **Ok** to disable the integration.

### See also

[Overview for LinkedIn Sales Navigator solutions](integrate-sales-navigator.md)     
[Customize forms to show Sales Navigator controls](add-sales-navigator-controls-forms.md)    
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)
