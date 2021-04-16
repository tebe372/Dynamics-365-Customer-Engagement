---
title: "Track your Outlook contacts using App for Outlook (Dynamics 365 apps) | MicrosoftDocs"
description: Track your Outlook contacts using App for Outlook.
ms.custom: 
ms.date: 04/15/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
caps.latest.revision: 1
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

# Track contacts

Access your Outlook contacts and Dynamics 365 contacts and see which contacts are tracked. You can also link a Outlook contact to an account in your Dynamics 365 app.

To use this add-in option your admin must enable your Dynamics 365 mailbox for appointments, contacts, and tasks.


   > [!div class="mx-imgBorder"] 
   > ![Select add-in](../media/all-contacts.png)  
 
Legend
1. **Outlook Contacts**: View all your Outlook contacts. The same contacts are displayed in the default contacts view in Dynamics 365.
2. **Dynamics 365 Contacts**: View all your Dynamics 365 contacts.
3. **Tracked**: See whether a contact is tracked or not, or whether tracking status is pending.
4. **Company**: Select to open a Dynamics 365 account record.
5. **Business Phone**: Select the number to dial the number.
6. **Email**: Select to view detail about the email address and compose a new email.

## Access contacts

To access your contacts, from the Outlook navigation pane, select More ![Outlook navigation options](../media/outlook-nav-options.png) and then select **Add-ins**.

   > [!div class="mx-imgBorder"] 
   > ![Select add-in](../media/access-add-in.png)  


### View contact card

In the contacts list, select **Dynamics 365 Contacts** and then select the checkbox next to a contact's name. The contact details appear on the right side of the screen.

   > [!div class="mx-imgBorder"] 
   > ![View contact details](../media/view-contact-details.png)  


## Track Outlook contacts 

Depending on the [server-side synchronization filters](/power-platform/admin/choose-records-synchronize-dynamics-365-outlook-exchange.md), the active contacts that the user owns in your app should be synchronized to Outlook after the mailbox is configured. A user can track a single or multiple contacts from Outlook to your Dynamics 365 app. 

   > [!div class="mx-imgBorder"] 
   > ![Demo of how to link a Outlook contact to a row in your app.](../media/link-outlook-contact-3.gif) 


Follow the steps below to link and track your Outlook contacts to a row in your app.

1. From **Outlook Contacts**, select a contact(s) that is not already tracked.
3. On the command bar, select **Link**.
 
   > [!div class="mx-imgBorder"] 
   > ![Link an Outlook contact](../media/link-outlook-contact.png) 
 
5. Chose the row that you want to link the contact(s) with and then select elect **Link**.

   > [!div class="mx-imgBorder"] 
   > ![Choose a contact in your app to link to](../media/link-outlook-contact-2.png) 




