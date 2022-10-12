---
title: Enable email validation (preview)
description: Enable lead email validation in Microsoft Dynamics 365 Sales to help your sellers keep their leads clean.
ms.date: 10/12/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Enable email validation (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Enable email validation in Dynamics 365 Sales to remove invalid email addresses from your lead records. You'll reduce email bounce rates, improve engagement, and get a better return on your sellers' time.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

Before you enable the email validation feature, ensure that the AI builder is enabled in your organization. More information: [How do I enable a Preview feature?](/power-platform/admin/what-are-preview-features-how-do-i-enable-them#how-do-i-enable-a-preview-feature)

## In which regions is email validation available?

Email validation is available in the following regions:

- Asia Pacific (APAC)
- Canada (CAN)
- Europe (EUR)
- France (FRA)
- Great Britain (GBR)
- India (IND)
- Japan (JPN)
- North America (NAM)
- Oceania (OCE)
- South America (SAM)
- Switzerland (CHE)
- United Arab Emirates (UAE)

## What is email validation?

Email validation analyzes the primary email address in lead records to identify the ones that can't receive email. You must enable the feature. It's turned off by default.

Email address validation looks for the following issues:

- **Incorrect syntax**: An address that doesn't contain both a username and an email domain
- **Disposable domain**: An address that contains a known disposable or temporary email domain
- **Test or spam email addresses**: An address that contains known indicators of a test or spam address in the email header or metadata, IP address, HTML code of the email, and email content and formatting
- **Expired email addresses**: An email account that has expired and can no longer receive or send email
- **Emails that bounce back**: An address that can't receive a message for any reason

Sellers can view invalid email addresses on record forms, work list items, and the **Up next** widget in sales accelerator. More information: [Work with invalid email addresses](work-invalid-email-addresses.md)

## Limitations of email validation

- Email validation works only for lead records.
- It's not available in custom apps.
- It checks only the primary email address in a lead record.
- Leads that are older than 180 days aren't validated.

## Enable email address validation

1. In the Sales Hub site map, select **Change area** > **App settings**.
1. Select **Data improvement** > **Email validation**.

    :::image type="content" source="media/lead-enable-email-validation-page.png" alt-text="Screenshot of the email validation page.":::

1. Turn on email validation.

    :::image type="content" source="media/lead-email-feature-enabled.png" alt-text="Screenshot illustrating the email validation feature is enabled.":::

Email validation runs immediately on the primary email address in lead records that are less than 180 days old. A red envelope icon indicates an invalid email address. New primary email addresses added later are checked automatically.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Work with invalid email addresses](work-invalid-email-addresses.md)
