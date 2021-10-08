---
title: Prerequisites for the Dynamics 365 Sales mobile app
description: Learn about the prerequisites for the Dynamics 365 Sales mobile app
ms.date: 09/29/2021
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---
# Prerequisites for the Dynamics 365 Sales mobile app 

## Requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||


The Dynamics 365 Sales mobile app is an intuitive mobile experience that offers quick access to customer information and makes it easy to keep this information current. This simplifies customer relationship management and helps sellers focus on selling. 

Field sellers spend a lot of time on the road, traveling to meet customers. "On-the-go" time can become productive time with this mobile app, which is available on iOS and Android.

Before field sellers can use the Dynamics 365 Sales mobile app, you must ensure that the following prerequisites are met:

- To get the optimal mobile experience:
    - It is recommended to enable relevance search for the environment. More information: [Configure relevance search to improve search results and performance](/power-platform/admin/configure-relevance-search-organization)
    - It is recommended to have Exchange Online.
- To set a regarding record for a meeting, you must:
    - Enable server-side synchronization in your environment. More information: [Server-side synchronization](/power-platform/admin/server-side-synchronization).
    - Approve the email address. More information: [Approve mailboxes](/power-platform/admin/connect-exchange-online#approve-mailboxes)
-	The mobile app users must have the following permissions:   
    -	Read permission for [Organization table](../../customerengagement/on-premises/developer/entities/organization.md).
    -	Read permission for [Mailbox table](/dynamics365/customer-engagement/web-api/mailbox?view=dynamics-ce-odata-9&preserve-view=true).
    -	[**Dynamics 365 for mobile**](../../mobile-app/set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets.md#required-privileges) privilege.

> [!NOTE]
> - If the Dynamics 365 Sales mobile app is launched by a user having [mobile offline profile](../../mobile-app/setup-mobile-offline.md) defined, the app's user interface is displayed using Unified Interface (same as in Dynamics 365 for phones).
> - If the Dynamics 365 Sales mobile app is launched on a tablet device, the app's user interface is displayed using Unified Interface (same as in Dynamics 365 for tablets).

## What's next

After all the prerequisites are met for the Dynamics 365 Sales mobile app, field sellers can install it on their [iOS](install-ios-app.md) and [Android](install-android-app.md) devices. 

### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Learn the basics](learn-basics-mobile-app.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
