---
title: "Overview of templates in the Channel Integration Framework app | Microsoft Docs"
description: "Learn about templates in the Omnichannel Administrator app"
keywords: ""
ms.date: 10/15/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: article
ms.assetid: 7A99074E-9C3E-4DF0-98B4-AB7546C892C1
author: kabala123
ms.author: kabala
manager: shujoshi
---

# Preview: Overview of templates

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

When you (agents) get an incoming conversation request, the Channel Integration Framework version 2.0 allows channel providers to search and open records on an incoming call. However, your organization might have different requirements and want to use different custom entities and correlate to a conversation.

Also, the **Omnichannel for Customer Service app** allows you to open third-party web applications in the application tabs. Your organization may have different line-of-business applications, and while starting a session, you want to load the line-of-business applications for a specific conversation type.

For example, when an agent gets an incoming chat conversation notification, and he/she accepts the notification, a session starts. For every chat session, when the omnichannel application identifies the customer, you want to open a contact record, related case page, SharePoint site, and the line-of-business application.

To choose the applications you want to open for every session, according to your organization requirements, session templates are introduced.

- [Session templates](session-templates-cif.md)
- [Application tab templates](application-tab-templates-cif.md)
- [Notification templates](notification-templates-cif.md)

> [!WARNING]
> It is recommended that you don’t edit the out-of-the-box-sample templates present in the package as it affects the functionality.

## See also

- [Associate templates with scenarios](associate-templates-cif.md)