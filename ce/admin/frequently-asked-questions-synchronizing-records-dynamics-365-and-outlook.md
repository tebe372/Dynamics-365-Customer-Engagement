---
title: "Frequently asked questions about synchronizing records between Microsoft Dynamics 365 Customer Engagement and Outlook | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a6b483be-88ff-4264-b834-92a536deb45e
caps.latest.revision: 50
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Frequently asked questions about synchronizing records between Microsoft Dynamics 365 and Microsoft Outlook

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

## What's the best way to use Outlook and Microsoft Dynamics 365 together?  
 There are three ways to use [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)] and [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] together:  
  
- [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)]  
  
- [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] (legacy add-in)  
  
- [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] folder tracking  
  
 [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] is deprecated with [!INCLUDE[pn_crm_9_0_0_online](../includes/pn-crm-9-0-0-online.md)] and will be removed in a future major release. Use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] paired with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] to view [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)] data in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] and track [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] records in [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)]. You can use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] together with [!INCLUDE[pn_microsoft_outlook_web_app](../includes/pn-microsoft-outlook-web-app.md)],  the [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] desktop application, or with [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] mobile. With [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] information appears next to a user’s [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email messages or appointments. For example, people can preview information about contacts and leads stored in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and add [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] contacts directly from an email message. They can also link email, appointment, and contact records  to new or existing [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records, such as  opportunity, account, or case records. To use [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], you must synchronize email with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate your email system with Dynamics 365](../admin/integrate-synchronize-your-email-system.md)  
  
## How often are records synchronized through server-side sync?  
 If you synchronize records with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)], the process is dynamic and unique for each user’s mailbox. The synchronization algorithm ensures that mailboxes are synced according to dynamic parameters such as the number of email messages and the activity within the mailbox. Normally, email synchronization occurs every 5 minutes. When a mailbox has many email messages, the interval can be reduced dynamically to 2 minutes. If the mailbox is less active, the interval can be increased up to 12 minutes. Generally speaking, you can assume that a mailbox will be synced at least once every 12 minutes. Note that you can’t manually synchronize records through [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] but when you track or link (set the regarding record) for email, appointments, or tasks, synchronization happens immediately.  
  
## Where can I find information on troubleshooting server-side synchronization issues?  
 You can find information on troubleshooting and known issues here: [Troubleshooting and things to know about server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md).  
  
## Do security permissions affect synchronization?  
 Yes. If a system administrator has implemented security for particular fields or records, it can affect the data that’s synchronized.  
  
## Privacy notices  
[!INCLUDE[cc_privacy_crm_server_side_sync](../includes/cc-privacy-crm-server-side-sync.md)]
  
 [!INCLUDE[cc_privacy_crm_sync_to_outlook](../includes/cc-privacy-crm-sync-to-outlook.md)]
  
 [!INCLUDE[cc_privacy_crm_outlook1](../includes/cc-privacy-crm-outlook1.md)]
  
### See also  
 [Integrate your email system with Dynamics 365](../admin/integrate-synchronize-your-email-system.md)   
 [Dynamics 365 App for Outlook User's Guide](../outlook-app/dynamics-365-app-outlook-user-s-guide.md)   
 [Track Outlook email by moving it to a tracked Exchange folder](track-outlook-email-by-moving-it-tracked-exchange-folder.md)   
 [Set personal options that affect tracking and synchronization between Dynamics 365 and Outlook or Exchange](set-personal-options-affect-tracking-synchronization-between-dynamics-365-outlook-exchange.md)
