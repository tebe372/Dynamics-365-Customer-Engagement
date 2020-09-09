---
title: "Set up delegate access for Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 02/26/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---

<!--from editor: Although I don't find it in the style guide, a search suggests that "Dynamics 365 App for Outlook" is correct, so I'm changing "Outlook App."  
The two paragraphs in the first section seem to say much the same thing. I recommend deleting the first one. 
The term "whitelisted" is discouraged by the Msft style guide. Can we substitute something like "approved" or "marked as safe"? 
-->


# Set up delegate access 

Set up delegate access to allow someone to track Common Data Service information using the Dynamics 365 App for Outlook.

Set up delegate access in Outlook to give someone permission to act on your behalf. For example, you might want an assistant to create and respond to email or meeting requests for you and then track the information in Common Data Service using the Dynamics 365 App for Outlook.

## Prerequisites

- Exchange Online and Microsoft Outlook C2R (Click-to-Run) build 16.0.12130.20272 or later. To check which channel you need to be on for this version, see [Update history for Office 365 ProPlus](https://docs.microsoft.com/officeupdates/update-history-office365-proplus-by-date). 
- Configure delegate access in Microsoft Outlook. At a minimum, a delegated user must have at least **Editor** permission on the delegated mailbox.  For more information, see [Allow someone else to manage your mail and calendar](https://support.office.com/article/allow-someone-else-to-manage-your-mail-and-calendar-41c40c04-3bd1-4d22-963a-28eafec25926).
- Both manager and delegate user must have Dynamics 365 App for Outlook. For more information, see [Deploy Dynamics 365 App for Outlook](deploy-dynamics-365-app-for-outlook.md). 
- Make sure this Skype URL is whitelisted: [https://config.edge.skype.com](https://config.edge.skype.com/). Otherwise, Outlook C2R will not allow delegate access to work with shared calendars. For more information, see [Office 365 URLs and IP address ranges](https://docs.microsoft.com/office365/enterprise/urls-and-ip-address-ranges#skype-for-business-online-and-microsoft-teams). 

## Enable delegate access


<!--from editor: Is it OrgDBOrgSetting or OrgDBOrgSettings (with s on the end)? Or are they different? -->


To enable delegate access, you need to enable the **OrgDBOrgSetting** in your organization. Common Data Service apps provide the **OrgDBOrgSettings** tool that gives administrators the ability to implement specific updates that were previously reserved for registry implementations.

Follow the instructions in this [Microsoft Support article](https://support.microsoft.com/en-us/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm) for steps to extract the tool. After extracting the tool, enable **OrgDBOrgSettings TrackAppointmentsFromNonOrganizer** and **DelegateAccessEnabled**.

You can also use [this tool](https://github.com/seanmcne/OrgDbOrgSettings/releases/) to edit **OrgDBOrgSettings TrackAppointmentsFromNonOrganizer** and **DelegateAccessEnabled**.

1.	Sign in as an admin to Dynamics 365 at [https://home.dynamics.com](https://home.dynamics.com).
2.	On the home page, go to [**Settings** > **Advanced Settings**](https://docs.microsoft.com/power-platform/admin/admin-settings#app-settings).

    > [!div class="mx-imgBorder"] 
    > ![](media/step1.png) 

3. From the main menu, go to **Settings** > **Customizations** and then select **Solutions**.

    > [!div class="mx-imgBorder"] 
    > ![](media/step2.png) 
    
4. On the **All Solutions** screen, select **Organization Settings Editor (Dynamics 365)**.

    > [!div class="mx-imgBorder"] 
    > ![](media/step3.png) 
    
5. On the **Solution Organization Settings Editor** screen, find the **TrackAppointmentsFromNonOrganizer** and **DelegateAccessEnabled** settings and set both to **True** (if not already set to True) and then select **Update**.
  
    > [!div class="mx-imgBorder"] 
    > ![](media/step4.png) 
    

> [!IMPORTANT]
> Things to verify before enabling delegate access in App for Outlook:
> - Delegate access is set up correctly in Outlook.
> - The delegated user has at least **Editor** permissions on the delegated mailbox.
> - The Skype URL (https://config.edge.skype.com/) is whitelisted.
> - The delegated user has the correct Outlook version.
> - The organization settings are configured properly.
> - After the organization settings are configured, App for Outlook is redeployed for all users.

## Frequently asked questions

### Are shared folders supported as part of the delegate access feature?

No, to understand the difference between shared folders and delegate access, see [Manage another person's mail and calendar items](https://support.office.com/article/Manage-another-person-s-mail-and-calendar-items-AFB79D6B-2967-43B9-A944-A6B953190AF5).
 
### Is delegate access supported using the MSI version of Outlook?

No, it is only available for the supported version of Outlook C2R. For more information, see  [Update history for Office 365 ProPlus](https://docs.microsoft.com/officeupdates/update-history-office365-proplus-by-date).


### See also  
[Use delegate access](dynamics-365-app-outlook-user-s-guide.md#use-delegate-access)<br/>
