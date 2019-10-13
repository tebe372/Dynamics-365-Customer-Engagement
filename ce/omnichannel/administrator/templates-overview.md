---
title: "Overview of templates | MicrosoftDocs"
description: "Learn about templates in the Omnichannel Administrator app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 54535BA9-DC5A-4304-81C8-916CAA0A76A2
ms.custom: 
---

# Preview: Overview of templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md). 

When you (agents) get an incoming conversation request, the Omnichannel system searches and opens the records. However, your organization might have different requirements and want to use different custom entities and correlate to a conversation. 

Also, the Omnichannel for Customer Service app allows you to open third-party web applications in the application tabs. Your organization may have different line-of-business applications, and while starting a session, you want to load the line-of-business applications for a specific conversation type.

For example, when an agent gets an incoming chat conversation notification, and the agent accepts the notification, a session starts. For every chat session, when the application identifies the customer, you want to open a contact record, related case page, SharePoint site, and the line-of-business application.
To choose the applications you want to open for every session, according to your organization requirements, session templates are introduced.

You can use the following templates in the Omnichannel Administrator app.

- [Session templates](session-templates.md)
- [Application tab templates](application-tab-templates.md)
- [Notification templates](notification-templates.md)
 
## See also

- [Associate templates with workstreams](associate-templates.md)
- [Understand and create workstream](work-streams-introduction.md)