---
title: "Control field synchronization between Dynamics 365 and Dynamics 365 for Outlook | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-28"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d570e1f0-d319-46c6-a247-00c32c78df3b
caps.latest.revision: 20
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Control field synchronization between Dynamics 365 and Dynamics 365 for Outlook
With field synchronization, admins can set the sync direction between [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] fields. You can control synchronization when using either [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] synchronization or server-side synchronization ([!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)]).  
  
 For example, a salesperson may want to take personal notes about a contact and not want the notes to synchronize with [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] data available to all users. You can set the Personal Notes field for contacts in Outlook to not [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] so the salesperson’s notes will remain private.  
  
> [!TIP]
>  ![Video symbol](../media/video-thumbnail-4-crm.png "Video symbol") Check out the following video: [Configurability in Synchronizing Data with Outlook or Exchange in Microsoft Dynamics CRM 2015](http://youtu.be/BMZsVUuaklo?list=PLC3591A8FE4ADBE07)  
  
### Set field synchronization between Dynamics 365 and Dynamics 365 for Outlook  
  
1.  In Dynamics 365,  [!INCLUDE[proc_settings_email_config](../../includes/proc-settings-email-config.md)]  
  
2.  Choose **Email Configuration Settings**.  
  
3.  Choose the **Synchronization** tab > **synchronized fields**  
  
4.  For the fields you want to change synchronization, choose the arrows in the Sync Direction column. Each choice will change the direction.  
  
     ![Appointment fields for synchronization](../media/crm-itpro-appointmentfieldsync.png "Appointment fields for synchronization")  
  
    > [!TIP]
    >  Hover over a field name to see the fields mapped to it.  
  
5.  Choose **OK** > **OK** to close the open dialog boxes.  
  
 Let your users know they can view (not change) the synchronization settings. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)][What fields can be synchronized between Dynamics 365 and Dynamics 365 for Outlook?](523462c5-8d29-49a6-9e05-e8b484f854dd.md)  
  
## Performance and synchronization  
 Configuring synchronization might have an impact on the time it takes to sync between [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] and [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. You should test your configuration before deploying to ensure satisfactory sync times.  
  
## Permissions and synchronization  
 Role-based security controls access to a specific entity type, record-based security controls access to individual records, and field-level security controls access to specific fields. All these can impact what is synchronized between [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)].  
  
 Best practice is to review the security settings for these security methods to ensure field synchronization is processes as desired. For more information see:  
  
-   Securing roles: [Create or edit a security role](../Topic/Create%20or%20edit%20a%20security%20role.md)  
  
-   Securing fields: [Help & Training: Add or remove security from a field](http://go.microsoft.com/fwlink/p/?LinkID=512921)  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [How field security affects synchronization between Dynamics 365 and Dynamics 365 for Outlook](5df0b13a-846a-4822-83cc-8efaaf3395fb.md) and [Security concepts for Microsoft Dynamics 365](../Topic/Security%20concepts%20for%20Microsoft%20Dynamics%20365.md)  
  
## See Also  
 [Set up Dynamics 365 for Outlook](set-up-dynamics-365-outlook.md)