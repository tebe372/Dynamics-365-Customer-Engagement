---
title: Deprecations in Dynamics 365 Customer Service | MicrosoftDocs
description: "Use this topic to get information about features that are deprecated in Dynamics 365 Customer Service."
ms.date: 09/15/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Deprecations in Customer Service

The features that have been deprecated in Customer Service are listed in this article.

Administrators and IT professionals can use this information to prepare for future releases.

> [!Important]
>
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and will be fully supported until it is officially removed. This deprecation notification might span a few years. After removal, the feature or capability will no longer work. We are notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.

## Omnichannel Administration app is deprecated

Support for the Omnichannel Administration app ended on April 30, 2022. We recommend that you use the Omnichannel admin center or Customer Service admin center app to configure the latest features, such as unified routing and voice channel. More information: [Get started with Omnichannel admin center](oc-admin-center.md)

## setContextProvider method deprecated for authenticated chat

The setContextProvider method for authenticated chat has been deprecated and will not be supported after October 01, 2021. Microsoft recommends that you use the JWT token for authenticated chat. More information: [Send authentication tokens](send-auth-token-starting-chat.md).

## Support for some knowledge management entities is deprecated <a name="deprecatedkmentities"></a>

The KbArticle, KbArticleComment, and KbArticleTemplate knowledge management entities that were deprecated earlier will not be supported after October 01, 2021. We recommend that you use the newer KnowledgeArticle entity (introduced in CRM Online 2016 Update and Dynamics 365) for knowledge management in Dynamics 365. More information: [Work with knowledge articles](work-knowledge-articles.md).

## Internet Explorer 11 support for Dynamics 365 and Microsoft Power Platform is deprecated <a name="internetexplorer11"></a>

Effective December 2020, Microsoft Internet Explorer 11 support for Microsoft Dynamics 365 and Microsoft Power Platform is deprecated, and Internet Explorer 11 won’t be supported after August, 2021.

This will impact customers who use Dynamics 365 and Microsoft Power Platform products that are designed to be used through an Internet Explorer 11 interface. After August 2021, Internet Explorer 11 won't be supported for such Dynamics 365 and Microsoft Power Platform products. We recommend that customers transition to Microsoft Edge.

If you have more questions, contact your Microsoft Customer Service representative or Microsoft Partner.

## Automatic record creation rules in web client are deprecated

Effective October 01, 2020, the automatic record creation and update rules are deprecated in the web client. You are encouraged to migrate your automatic record creation rules that were created in the web client to the new Unified Interface experience. For information on how to migrate the rules, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md). Microsoft will continue to provide support and critical security updates for these features in the web client until end of life, April 01, 2023.

> [!NOTE]
> The deprecation and end of life are not applicable to the feature in Dynamics 365 Customer Engagement (on-premises).

## SLAs in web client are deprecated

Effective October 01, 2020, the service-level agreements (SLAs) are deprecated in the web client. You are encouraged to migrate your SLAs that were created in the web client to the new Unified Interface experience. For information on how to migrate the items, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md). Microsoft will continue to provide support and critical security updates for these features in the web client until end of life, April 01, 2023.

> [!NOTE]
> The deprecation and end of life are not applicable to the feature in Dynamics 365 Customer Engagement (on-premises).

## Service scheduling in Dynamics 365 Customer Service is deprecated

The existing service scheduling functionality is deprecated, and will no longer be available on December 1, 2020. The new scheduling experience, built on Universal Resource Scheduling, is now available in Unified Interface.

Existing service scheduling users will be provided advance notice for a time bound migration to the new scheduling capabilities.

There are two approaches to migrate to the scheduling experience:

Follow the guidance in the [Service Scheduling Guide](basics-service-service-scheduling.md) to set up the new scheduling experience for an existing Dynamics 365 Customer Service organization.

If your organization requires features that rely on legacy APIs, the product team is offering an incremental migration option and will update your organization to the Unified Interface experience while continuing to allow the use of the legacy APIs. This approach is available in 2020 release wave 2 with Early Access in August, 2020.

## Contracts, Contract Line Items, and Contract Templates entities are deprecated

The Contracts, Contract Line Items, and Contract Templates entities are deprecated and will not be supported from April 1, 2022. They will be removed in a future major release of Dynamics 365. This functionality has been replaced by [entitlements](create-entitlement-define-support-terms-customer.md) in Unified Interface. The [web client](/power-platform/important-changes-coming#legacy-web-client-is-deprecated) will not be available after Tuesday, December 01, 2020, and you must migrate to Unified Interface by this date. We recommend that you migrate your contracts to entitlements at the earliest to avoid any loss in functionality. For information on the migration strategy, see [Strategy for migrating from contracts to entitlements](contract-to-entitlement-migration.md).

## Standard SLAs in Dynamics 365 Customer Service are deprecated

Standard service level agreements (SLA Type field is set to Standard) are deprecated and will be removed in a future major release. Standard SLAs are replaced by enhanced SLAs. More information: [Enhanced service level agreements](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn887187(v=crm.8)).

## Customer Service Insights standalone app to be deprecated

The Customer Service Insights standalone app is planned for deprecation later this year. If you are a customer who uses this app, your current working environments will be terminated and inaccessible by December 8, 2021. You won't be able to use the standalone service after this date, but the embedded Customer Service Insights features in the core applications will continue to be available and supported. For users with Customer Service Enterprise licenses, you won't be able to create new workspaces, but you'll retain access to existing ones. We recommend that you migrate to the [embedded experience](introduction-customer-service-analytics.md) within the core Dynamics 365 Customer Service applications. In the interim, the [standalone app guide](/dynamics365/ai/customer-service-insights/quickstart) contains documentation for the standalone web application.


### See also

[Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)  
[Define service-level agreements](define-service-level-agreements.md)  
[Important changes (deprecations) coming in Power Apps, Power Automate](/power-platform/important-changes-coming)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
