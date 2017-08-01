---
title: "System Settings dialog box - General tab for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 5e5cc5ae-b4c9-4800-be83-824af6aa4bb5
caps.latest.revision: 74
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# System Settings dialog box - General tab
Use the settings on this page to change general system-level settings like preferences for saving, decimal and currency precision, and other default settings for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Open the System Settings dialog box (if it isn’t already open)  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
3.  Click the **System Settings** > **General** tab.  
  
|Settings|Description|  
|--------------|-----------------|  
|**Select the default save option for forms**||  
|Enable auto save on all forms|If Yes, which is the default, after a record is created (initially saved), any changes made to a form will automatically be saved thirty seconds after the change is made. The 30-second period starts again after a change is made. If no changes are made, the automatic save doesn’t happen.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage auto-save](https://technet.microsoft.com/library/dn531073.aspx)|  
|**Set the IM presence option**||  
|Enable presence for the system|If Yes, which is the default, instant messaging will display the current status for users, contacts, opportunities, or leads. This only applies to lists and sub-lists for entities with an updated user interface.|  
|**Set the full-name format**||  
|Name Format|Select the order in which you want customer and user names to be displayed. The default is First Name Last Name.|  
|**Set the currency precision that is used for pricing throughout the system**||  
|Pricing Decimal Precision|Select how many decimal points to use for a currency. The default is 2.|  
|**Set whether reassigned records are shared with the original owner**||  
|Share reassigned records with original owner|Select whether a record is shared with the original owner of the record, or completely reassigned to another user. The default is No.|  
|**Set blocked file extensions for attachments**|Prevent users from attaching files with specific file name extensions.|  
|**Set the currency display option**||  
|Display currencies by using|Set how to display currencies, either by a currency symbol, which is the default setting, or by currency code. For example, a currency symbol could be $, and the currency code could be USD.|  
|**Set up search**||  
|Enable Relevance search|If enabled, you can use Relevance search to find  records across multiple entities, sorted by relevance.|  
|Enable Quick Find record limits|If Yes, which is the default, if more than 10,000 records are found, a message will be displayed that suggests a more selective search.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Relevance search for the organization](https://technet.microsoft.com/library/mt723654.aspx)|  
|Select entities for Categorized search|Click **Select** to choose the entities to include when users do a search in [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)].|  
|**Enable Bing Maps**||  
|Show [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)] on forms|If Yes, which is the default, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on-premises users will need to enter a [!INCLUDE[pn_bing](../includes/pn-bing.md)] Maps key. [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users don’t need to enter a key.|  
|Please enter [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)] key (on-premises)|On-premises users can obtain a [!INCLUDE[pn_bing](../includes/pn-bing.md)] Maps key from: [Bing Maps Dev Center](https://www.bingmapsportal.com/)|  
|**Set the default country/region code**||  
|Enable country/region code prefixing|If enabled, which is the default, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] will prefix the country/region code to numbers that users are trying to call.|  
|Country/Region Code Prefix|The default is+1, which is the country/region calling code for North America.|  
|**Set the telephony provider**||  
|Select provider for Click to call|Choose which provider to enable outbound calls from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. This setting doesn’t apply to [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] or [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)].|  
|**Set whether users see Dynamics 365 message**||  
|Users see app download message|If Yes, which is the default, users will see a message regarding downloading the [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] app.|  
|**Set custom Help URL**||  
|Use custom Help for customizable entities|If you want to replace the default Help content with custom Help designed for your users, click **Yes**. After you enable custom Help, you can enter a **Global Custom Help URL**.<br /><br /> |  
|Global custom Help URL|To replace the default Help with a single URL for all customizable record types (entities), enter the URL here. You also have the option of entering override URLs for each record type (entity) for customizable record types. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customize the Help experience](https://technet.microsoft.com/library/dn832079.aspx)|  
|Append parameters to URL|If you click **Yes** to append parameters to the URL, you can make your Help content more dynamic. For example, you can access parameters for User Language Code, Entity Name, Entry Point, and Form ID. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customize the Help experience](https://technet.microsoft.com/library/dn832079.aspx)|  
|Enable Learning Path|Changes access to Learning Path for an entire organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [On/off switch for Learning Path (guided help)](https://go.microsoft.com/fwlink/P/?linkid=832758).|  
|Enable Learning Path Authoring|Defaults to No. Set to Yes if you want  enable users to author Learning Path content.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create your own guided help (Learning Path) for your customers](../customize/create-your-own-guided-help-learning-path-for-your-customers.md)|  
|**Disable Social Engagement**||  
|Prevent feature from receiving social data in Dynamics 365|Defaults  to No. If you don’t want to receive social data in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], select **Yes**. If you disable social engagement, your organization will not be able to receive social data in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Users can continue to work with existing social data, however.|  
|**Set whether users see welcome screen**||  
|Display welcome screen to users when they sign in|When users start [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], they’re presented with a welcome screen (navigation tour) that provides a quick overview of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Click **No** to disable this tour for all users in your organization.<br /><br /> |  
|**Use legacy form rendering**||  
|For compatibility, use the legacy form rendering engine. Note that performance may be adversely affected.|In [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)] and [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] on-premises, we made enhancements to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] forms so that they load faster.<br /><br /> However, if you have forms that include unsupported customizations, these enhancements can cause compatibility problems. To avoid this, you can temporarily turn the form enhancements off by choosing **Yes**. We recommend that you reset this setting to **No** after addressing scripting problems so you can take advantage of optimized forms. **Note:**  When a form that includes unsupported customizations is used, such as unsupported [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)], the form may fail to load or the user will receive an error message. <ul><li>If the form just fails, set the **Use legacy form rendering** option to **Yes**. If the form loads after you select this option, you may have unsupported customizations.</li><li>If the user receives an error, click "View the data that will be sent to Microsoft" and see the details in the \<CrmScriptErrorReport> tags. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What kind of customizations aren’t supported?](https://technet.microsoft.com/library/dn531193.aspx#BKMK_Unsupported)</li></ul>|  
|**Set options for the default app: Dynamics 365 – custom**||  
|Show default app on landing page and in app switch|Default is Yes. Change to No to prevent the default app from appearing on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] home page and in the app selector menu.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [For admins and end users: Introducing the Dynamics 365 home page](https://technet.microsoft.com/library/mt712018.aspx)|  
|Default app name|Enter the label to use for the default app. This appears on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] home page.   The default label is Dynamics 365 - custom.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [For admins and end users: Introducing the Dynamics 365 home page](https://technet.microsoft.com/library/mt712018.aspx)|  
  
### See also  
 [Manage auto-save](https://technet.microsoft.com/library/dn531073.aspx)   
 [Customize the Help experience](https://technet.microsoft.com/library/dn832079.aspx)   
 [What kind of customizations aren’t supported?](https://technet.microsoft.com/library/dn531193.aspx#BKMK_Unsupported)