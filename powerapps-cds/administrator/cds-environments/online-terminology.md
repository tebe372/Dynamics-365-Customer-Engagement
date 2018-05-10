---
title:  Terminology used in the product and documentation  | Microsoft Docs
description: In this quickstart, you learn how to download a list of apps created in your environments
services: 'powerapps'
suite: powerapps
documentationcenter: na
author: jimholtz
manager: kfile
editor: ''
tags: ''

ms.service: powerapps
ms.devlang: na
ms.topic: article
ms.tgt_pltfrm: na
ms.workload: na
ms.date: 03/21/2018
ms.author: jimholtz

---
# Terminology used in the product and documentation

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_update_8_2_0](../../includes/cc_applies_to_update_8_2_0.md)]

Changes:
1. instances = environments
2. DLP policy
3. PA
4. CDS
5. data groups
6. database
7. GDPR
8. DSR
9. clone









The following are terms used throughout the [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] product and documentation.  
  
<a name="BKMK_Terminology"></a>  
  
|Term|Definition|  
|----------|----------------|  
|Tenant|For [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], a tenant is the account you create in the [!INCLUDE[pn_ms_online_services_environment](../../includes/pn-ms-online-services-environment.md)] when you sign up for a [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] subscription. A tenant contains uniquely identified domains, users, security groups, and subscriptions and can contain multiple [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] instances.<br /><br /> The tenant created for you has a domain name of \<account>.onmicrosoft.com. For example, contoso.onmicrosoft.com.|  
|Instance|When you sign up for a trial or purchase a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] subscription, a [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] production instance is created. Each additional production or non-production (Sandbox) [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] instance you add creates a separate and isolated [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] organization on the same tenant.<br /><br /> An instance has the URL format: https://\<URL name>.crm.dynamics.com. For example, https://contososales.crm.dynamics.com.|  
|Multiregional instance|An instance in a different region than where your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] tenant resides. Local instances can provide quicker data access for users in that region. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Add and edit multiregional instances](add-edit-multiregional-instances.md)|  
|Subscription|A subscription consists of the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] licenses and add-ons included with the trial or paid service you signed up for in your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] account. [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] subscriptions can vary in license type, price, and end date.<br /><br /> For example, a subscription might be 100 licenses of [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] Professional and 10 licenses of [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] Enterprise.|  
|Identity|The user account used to sign in to [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)]. You can also use this identity to access other Microsoft Online services, such as [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] or [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)]. Administrators can decide if they want to federate user identity management between [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] and on-premises [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)].|  
|User account|A user account assigned by an organization (work, school, non-profit) to one of their constituents (an employee, student, customer) that provides sign-in access to one or more of the organization’s Microsoft cloud service subscriptions, such as [!INCLUDE[pn_Exchange_Online](../../includes/pn-exchange-online.md)] or [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)]. Access to an online service is controlled by the license assigned to the user account.<br /><br /> User accounts are stored in an organization’s cloud directory within [!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)], and are typically deleted when the user leaves the organization. Organizational accounts differ from Microsoft accounts in that they are created and managed by admins in the organization, not by the user.|  
|Security group|If your company has multiple [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] instances, you can use instance security groups to control which licensed users can access a particular instance. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Control user access to instances: security groups and licenses](add-instance-subscription.md#BKMK_man_sec_group)|  
  
### See also  
 [Manage Microsoft Dynamics 365 (online) instances](manage-online-instances.md)
