---
title: "Set expiration dates on email messages (Dynamics 365 Marketing) | Microsoft Docs"
description: "Prevent customer journeys from delivering out-of-date information by assigning an expiration date for email tiles."
ms.date: 02/03/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Set expiration dates for selected email tiles in a customer journey

> [!IMPORTANT]
> This is an early access feature, which means that it's currently available only on opted-in instances. You can opt in for early access on any instance, but we recommend that you do so only on trial, test, or sandbox instances, which will give you a chance to learn the new functionality before it shows up on your production instances later this year.
>
> For instructions on how to opt in and enable early access, see [Opt in to early access updates](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates). For more information about the 2020 release wave 1 schedule, and for answers to frequently asked questions about the early access program, see [2020 release wave 1 features available for early access](https://docs.microsoft.com/dynamics365-release-plan/2020wave1/features-ready-early-access).
>
>We encourage all customers to provide feedback related to early access features on the [Dynamics 365 Marketing Forum](https://community.dynamics.com/365/marketing/f/dynamics-365-for-marketing-forum), your Microsoft contact or partner, and/or through [Microsoft Support](https://docs.microsoft.com/power-platform/admin/get-help-support).

> [!NOTE]
> This functionality was previously available in December as a preview feature for commercial emails only. With the February 2020 early access release, you can set expiration dates for both commercial and transactional emails. Additionally, with improved reliability, messages won’t be delivered after the expiry date (previously, in certain situations, messages could still be delivered up to six days after the expiry date due to delays and retries built into the system).

Some of your customer journeys may include email messages with time-sensitive content. Time-sensitive emails could include time-limited offers, holiday promotions, or a two-week reminder for an upcoming event. Because contacts might join the journey at any time, you can now prevent delivering outdated information by setting an expiration date for one or more selected email messages. Any contact who enters an email tile after its expiration date has passed will pass through the tile without being sent the message.

## Set an expiration date for an email message

1. Select the email tile in your customer journey.

2. Switch the **Email expiration** toggle within **Email properties** to **On**.

3. Set your static **Expiration date and time** (for example, March 31, 2020 at 22:00). Specified expiry times use the customer journey’s time zone.

    ![Journey email-tile expiration date and time](./media/email-expire-date-time.png "Journey email-tile expiration date and time")

4. Once a journey is live, the expiration date is shown above the email tile:

    ![Journey expiration date and time above tile](./media/email-expire-tile.png "Journey expiration date and time above tile")

## Identify expired-message results in insights

Each time a customer journey skips sending an expired message, the event is noted in the following insights:

- The message is counted as sent, but blocked (because of the expiration date).
- In accumulated KPIs and charts, expired messages are counted as blocked.
- In detailed insights, expired messages are listed under **Blocked** > **Other reasons**.