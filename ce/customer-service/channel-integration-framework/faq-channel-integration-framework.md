---
title: "FAQs for Dynamics 365 Channel Integration Framework | MicrosoftDocs"
description: "Frequently asked questions about the Dynamics 365 Channel Integration Framework and its APIs for Dynamics 365."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 02/03/2020
ms.topic: reference
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Frequently asked questions (FAQs) for Dynamics 365 Channel Integration Framework


## General FAQs

### What is Dynamics 365 Channel Integration Framework?
Dynamics 365 Channel Integration Framework is a cloud-to-cloud extensible framework to integrate third-party channel providers with Dynamics 365 Unified Interface apps using a browser-based JavaScript API library.

### Can I integrate a two-way communication channel?
Yes, you can integrate two-way communication that enables you to set the context of inbound and/or outbound according to your business and process workflows.

### Does Dynamics 365 Channel Integration Framework work with Unified Interface apps?
Dynamics 365 Channel Integration Framework works only with Unified Interface apps. As of now, Dynamics 365 Channel Integration Framework does not support the legacy web client.

### Is Dynamics 365 Channel Integration Framework a softphone?
No, Dynamics 365 Channel Integration Framework provides an extensible framework to integrate third-party channel providers (softphones, chat, and SMS) with Dynamics 365 Unified Interface apps.

### Does Dynamics 365 Channel Integration Framework make calls or send messages?
No, Dynamics 365 Channel Integration Framework provides an extensible framework to configure the channel provider to make inbound or outbound calls or messages.

### Is Dynamics 365 Channel Integration Framework a server-side API?
No, Dynamics 365 Channel Integration Framework provides a JavaScript library that exposes APIs that you can use to perform the following operations:
- Create, retrieve, update, and delete entity records.
- Get and set Click-to-Act functionality.
- Search among records of a particular entity type.
- Get and set the panel width and so on.

More information: [Microsoft.CIFramework methods (CIF JavaScript API reference)](reference/microsoft-ciframework.md)

### Does Dynamics 365 Channel Integration Framework manage call or chat sessions?
No, Dynamics 365 Channel Integration Framework does not manage call or chat sessions.

### Is Dynamics 365 Channel Integration Framework dependent on operating systems and browsers?
No, Dynamics 365 Channel Integration Framework is operating system- and web browser-agnostic and lets you integrate the cloud-based channels of your choice that are best for your organization's requirements.

### Which web browsers does Dynamics 365 Channel Integration Framework support?

Microsoft Edge and Google Chrome support Dynamics 365 Channel Integration Framework.

> [!NOTE]
> The widget domain needs to be accorded permission to use appropriate media like pop-ups and microphone as required. For Microsoft Edge to permanently accord the required permissions, the required domain needs to be accessed via a regular window; permanent exception cannot be granted when the domain is accessed in private mode.

### Are there any browsers that Dynamics 365 Channel Integration Framework does not support?
Dynamics 365 Channel Integration Framework does not support Internet Explorer and Firefox browsers.

### Can partners package solutions that have a dependency on the Dynamics 365 Channel Integration Framework solution, together with the Dynamics 365 Channel Integration Framework solution?
No, the Dynamics 365 Channel Integration Framework solution should not be bundled with another solution. Partners can create solutions that add a check to their package looking for the Dynamics 365 Channel Integration Framework solution (also mentioning the minimum supported version), which causes installation to fail in case the Dynamics 365 Channel Integration Framework solution is not present.

Also, you can add Configuration Experience to the acquire flow that will allow the solution to detect the state of the target instance, and decide how to install. This will also let the solution do any additional setup or license acquisition remotely before installing.

### What happens when you select a role from under Select roles for the Channel?

When you select a particular security role for the channel provider from under the **Select roles for the Channel** drop-down list, the security role provides certain access rights to the channel provider. In case no role is selected, the channel provider can only be accessed by system administrators and customizers.

> [!IMPORTANT]
> When you select a role in the **Select roles for the Channel** list, it does not filter out users with just the System Administrator role. The System Administrator and Customizer roles will always have access to the channel provider. When you assign a System Administrator role to a user, the other users who have been assigned the System Administrator role earlier will not lose access unless you explicitly revoke system administrator rights from a user.

### Can I load the Dynamics 365 Channel Integration Framework version 1.0 communication widget in Omnichannel for Customer Service?

No, that is not supported.

## Dynamics 365 Channel Integration Framework version 2.0 FAQs

### Will my existing communication widget, built using Dynamics 365 Channel Integration Framework version 1.0 APIs, continue to work with the version 2.0 app?

Yes. Dynamics 365 Channel Integration Framework version 1.0 APIs will continue to be available and supported for the single-session Unified Interface apps like Customer Service Hub and Sales Hub. Even with the Dynamics 365 Channel Integration Framework version 2.0 app, they will continue to work.

### I want to use the multi-session experiences for my contact center with a third-party provider's communication widget built using the Dynamics 365 Channel Integration Framework version 2.0 APIs. What licenses do I need to purchase for that?

Dynamics 365 Channel Integration Framework version 2.0 works only with multi-session app (Omnichannel for Customer Service). You can integrate any third-party telephony provider with Omnichannel for Customer Service using the Channel Integration Framework 2.0 APIs. 

To learn more, see [Choose between version 1.0 and version 2.0](choose-between-versions.md).

For information on license, see the [Dynamics 365 Customer Service pricing overview](https://dynamics.microsoft.com/en-us/customer-service/overview/#pricing) and [Dynamics 365 Customer Service pricing plan](https://dynamics.microsoft.com/en-us/pricing/customer-service/#plans) pages.

## See also

[Overview of Dynamics 365 Channel Integration Framework](overview-channel-integration-framework.md)<br />
[What's new in Dynamics 365 Channel Integration Framework](whats-new-channel-integration-framework.md)<br />
[System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)<br />
[Known issues of Dynamics 365 Channel Integration Framework](known-issues.md)