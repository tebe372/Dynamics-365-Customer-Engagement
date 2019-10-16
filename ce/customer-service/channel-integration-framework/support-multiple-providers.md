---
title: "Support multiple providers with Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
keywords: ""
ms.date: 09/30/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 6A4DF7FD-9C4A-4765-91DF-A0C805523887
author: susikka
ms.author: susikka
manager: shujoshi
---

# Preview: Support for multiple providers

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

With Channel Integration Framework version 2.0, organizations can configure multiple providers in the Omnichannel for Customer Service app. This enables agents to simultaneously work on multiple sessions catering to different customers on different channels (for example, live chat and telephony), where each of these sessions belongs to different providers. Agents can switch across these sessions as needed. Omnichannel for Customer Service brings one pre-provisioned channel provider configuration. You can add other channel provider records and configure them as explained above. Below are the salient features of this capability:

-   Sessions started using Channel Integration Framework version 2.0 APIs, are associated with the provider. Providers are notified about events on the session that only they have started.

-   Providers can open new tabs only in the sessions they have started.

-   Providers cannot programmatically switch sessions or close sessions. Agents can manually switch and close sessions.

-   However, if a provider session is not in focus, and there is a new event in that session (for example, a new unread message from customer), you can use the ***requestFocusSession*** API to display the agent that the session not in focus requires attention.

-   As a best practice, it is recommended that sessions are started after taking agent consent using a toast notification.

### See also

[What's new in Channel Integration Framework](whats-new-channel-integration-framework.md)