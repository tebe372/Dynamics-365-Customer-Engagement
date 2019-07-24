---
title: "Dynamics 365 US Government - Feature availability | MicrosoftDocs"
ms.custom: 
ms.date: 05/08/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 5cf2c742-d2d7-46cd-9a97-67befd696820
caps.latest.revision: 16
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Dynamics 365 US Government - Feature availability 

*NA* (through May, 2019)

Microsoft strives to maintain functional parity between our commercially available service and that which is servicing the Dynamics 365 for Customer Engagement for U.S. Government - referred to as Dynamics 365 GCC and GCC High. However, there are notable exceptions to this affected by dependent service or partner-solution availability, market priorities, or compliance regulations.

At this time, preview features in the commercial offering are not available to Dynamics 365 US Government Community Cloud (GCC) and GCC High customers. This is intentional, as the GCC and GCC High deployment enable a community leveraging our generally available services, further protected with heightened compliance demands of the U.S. Government and Government community customers.

Dynamics 365 GCC currently supports the following versions:

- Dynamics 365 for Customer Engagement, version 9.x
- Dynamics 365 for Customer Engagement, version 8.2.x (through May, 2019)
- Microsoft Dynamics CRM Online 2016, Update 1 (through May, 2019)

Dynamics 365 GCC High currently supports the following versions:

- Dynamics 365 for Customer Engagement, version 9.x

There are certain experiences that are currently not available with Dynamics 365 GCC and GCC High.  We continue to evaluate these for incorporation into future releases. The following generally available features are not currently available:

- [Activity Logging](https://docs.microsoft.com/dynamics365/customer-engagement/admin/enable-use-comprehensive-auditing)
- [AppSource](https://appsource.microsoft.com/?product=dynamics-365-business-central%3Bdynamics-365-for-customer-services%3Bdynamics-365-for-field-services%3Bdynamics-365-for-finance-and-operations%3Bdynamics-365-for-project-service-automation%3Bdynamics-365-for-sales) (that is, the ability to install Applications directly from AppSource)
- [Organization Insights](https://appsource.microsoft.com/product/dynamics-365/mscrm.04931187-431c-415d-8777-f7f482ba8095)
- [CAFEx Integration](https://appsource.microsoft.com/product/dynamics-365/cafexliveassistfor365.27ac7522-68b2-44a2-9f36-da66a47e2b19)
- [Channel Integration Framework](../../developer/channel-integration-framework/channel-integration-framework.md) 
- [Connected Field Service](https://msdn.microsoft.com/library/mt744253.aspx)
- [Data Export Service](https://appsource.microsoft.com/product/dynamics-365/mscrm.44f192ec-e387-436c-886c-879923d8a448)
- [Gamification](https://docs.microsoft.com/dynamics365/customer-engagement/gamification/manage-gamification-in-dynamics-365-online)
- [Home.Dynamics.com](http://home.dynamics.com/)
- [Insights, powered by InsideView](https://appsource.microsoft.com/product/dynamics-365/insideviewinc.b5386882-4312-4d69-879a-23081897c012)
- [Mobile offline](https://docs.microsoft.com/dynamics365/customer-engagement/mobile-app/configure-mobile-offline-synchronization-dynamics-365-phones-tablets)
- [PowerBI “embedded” user dashboard experience](https://docs.microsoft.com/power-bi/service-connect-to-microsoft-dynamics-crm)
- [Relevance Search](https://docs.microsoft.com/dynamics365/customer-engagement/basics/relevance-search-results)
- [Resource Scheduling Optimization](https://docs.microsoft.com/dynamics365/customer-engagement/common-scheduler/resource-scheduling-optimization)
- [Versium Predict](https://docs.microsoft.com/dynamics365/customer-engagement/versium-predict/versium-predict)
- [Forms Professional (Preview)](https://docs.microsoft.com/business-applications-release-notes/April19/forms-pro/)
- [Microsoft Dynamics Portals](https://docs.microsoft.com/dynamics365/customer-engagement/portals/administer-manage-portal-dynamics-365) (Currently available in GCC; GCC High availability in May, 2019)
- [Power Platform Admin center](https://docs.microsoft.com/power-platform/admin/admin-guide): The admin center can be used to open support tickets, but other functionality is currently not available in US Government tenants.
- [Teams Integration](../../basics/teams-integration.md)

There are a number of other business application apps and services that are not currently available as a service operating within the GCC or GCC High at this time. They include:

- [Microsoft Dynamics 365 for Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/overview)
- [Microsoft Dynamics 365 for Talent](https://docs.microsoft.com/dynamics365/unified-operations/talent/)
- [Microsoft Dynamics Social Engagement](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/get-started) – This is a feature that cannot be used by Government customers, worldwide.
- [Microsoft Business Central](https://docs.microsoft.com/dynamics365/business-central/index)
- [Microsoft Dynamics 365 for Customer Insights](https://docs.microsoft.com/dynamics365/ai/customer-insights/overview)
- [Microsoft Dynamics 365 AI for Customer Service Insights](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/overview)
- [Microsoft Dynamics 365 AI for Market Insights](https://docs.microsoft.com/dynamics365/ai/market-insights/overview)
- [Microsoft Dynamics 365 AI for Sales](https://docs.microsoft.com/dynamics365/ai/sales/overview)
- [Microsoft Dynamics Social Engagement](https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/get-started) – This is a feature that cannot be used by Government customers, worldwide.
- [Microsoft Dynamics Voice of the Customer](https://docs.microsoft.com/dynamics365/customer-engagement/voice-of-customer/get-feedback-surveys) – Please note that while this is not available in GCC, it is available to install into a customer’s Instance(s) running GCC services; all integration points will work as they do in our non-GCC environments. 
- [Microsoft Dynamics 365 for Finance and Operations](https://docs.microsoft.com/dynamics365/unified-operations/fin-and-ops/) - Please note that while this is not available in GCC, it is available to purchase and associate to a customer’s tenant running GCC services. This option is not available for GCC High customers.
- [Microsoft Dynamics 365 for Retail](https://docs.microsoft.com/dynamics365/unified-operations/retail/) - Please note that while this is not available in GCC, it is available to purchase and associate to a customer’s tenant running GCC services. This option is not available for GCC High customers.

<a name="BKMK_NetworkPorts"></a>   

## Network ports for [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)]  
 The following ports are open for outbound connections between [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)] and internet services.  

- 80 HTTP  
- 443 HTTPS  
- 465 Secure SMTP  
- 587 Secure SMTP
- 995 Secure POP3  

Customizations or email configurations in Dynamics 365 GCC and GCC High can only use these ports.

### See also  
 [Microsoft Dynamics 365 US Government](microsoft-dynamics-365-government.md)<br/>
 [Important changes coming in Dynamics 365 for Customer Engagement](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming)<br/>
 [Dynamics 365 for Customer Engagement apps IP Address Ranges (prior to v9.x)](https://support.microsoft.com/help/2728473/microsoft-dynamics-crm-online-ip-address-ranges)<br/>
 [Dynamics 365 for Customer Engagement apps IP Address Ranges (v9.x)](https://www.microsoft.com/download/confirmation.aspx?id=57063) Focus only on AzureCloud.usgovtexas and AzureCloud.usgovvirginia <br/>
 [PowerBI for US Government Customers](https://docs.microsoft.com/power-bi/service-govus-overview)<br/>
 [Compliance Offerings for Dynamics 365 for Customer Engagement](https://www.microsoft.com/trustcenter/compliance/complianceofferings?product=Dynamics365)
