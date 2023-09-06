---
title: Manage your accounts and contacts
description: Learn how to create and use accounts and contacts in Dynamics 365 Sales to store information about companies and people you work with.
ms.date: 09/06/2023
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:08/30/2023
 - bap-template
---


# Manage your accounts and contacts

In Dynamics 365 Sales, you use [accounts](#work-with-accounts) to store information about the companies you do business with. Use [contacts](#work-with-contacts) to store information about the people you work with at those companies. You can add multiple contacts to an account, but you can associate only one account with a contact. You can create accounts and contacts manually or import them from a spreadsheet or other supported files.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional<br/>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br/> More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## Work with accounts

- [Create an account](#create-an-account)
- [Add contacts to an account](#add-contacts-to-an-account)
- [View opportunities associated with an account](#view-opportunities-associated-with-an-account)
- [View relationship analytics and KPIs for an account](relationship-analytics.md)

### Create an account

1. In the sitemap of your sales app, select **Accounts**.

1. In the command bar, select **New**.

1. On the **Summary** tab, enter the information you have about the company. Only the **Account Name** is required. All other details are optional.

1. Optionally, [add contacts to the account](#add-contacts-to-an-account).

1. Select **Save & Close**.

### Fill in the address from suggestions

**(Applicable for Sales Enterprise and Sales Premium only)**

If your administrator has [turned on address suggestions](enable-address-suggestion.md), Bing Maps can fill in the account's address details so that you don't have to. Address suggestion works with contacts, accounts, and leads.

1. Open an account, contact, or lead.

1. On the **Summary** tab, scroll down to the **Address** box and start typing the street address.
    :::image type="content" source="media/address-suggestion-field.png" alt-text="Screenshot of the new address field in a form" lightbox="media/address-suggestion-field.png":::

1. Select an address from the list of suggestions provided by Bing Maps.

### View opportunities associated with an account

1. In the sitemap of your sales app, select **Accounts**.

1. Select an account in the list.

1. Select the **Related** tab. Scroll down to the **Related - Sales** group, and then select **Opportunities**.

### View invoices associated with an account

1. In the sitemap of your sales app, select **Accounts**.

1. Select an account in the list.

1. Select the **Related** tab. Scroll down to the **Related - Sales** group, and then select **Invoices**.

## Work with contacts

- [Create a contact](#create-a-contact)
- [Add contacts to an account](#add-contacts-to-an-account)
- [View opportunities associated with a contact](#view-opportunities-associated-with-a-contact)
- [View invoices associated with a contact](#view-invoices-associated-with-a-contact)
- [Get introduced to a contact](who-knows-whom.md)
- [View relationship analytics and KPIs for a contact](relationship-analytics.md)

### Create a contact

1. In the sitemap of your sales app, select **Contacts**.

1. In the command bar, select **New**.

1. On the **Summary** tab, enter the information you have about the company. Only the **First Name** and **Last Name** are required. All other details are optional.

    Bing Maps can [fill in the contact's address details](#fill-in-the-address-from-suggestions) for you if your administrator has turned on address suggestions.

1. Optionally, associate the contact with an account. Scroll down to **Company** and select an account from the list.

    A contact can be associated with only one account at a time.

1. Select **Save & Close**.

### Add contacts to an account

1. In the sitemap of your sales app, select **Accounts**.

1. Select an account.

1. On the **Summary** tab, scroll down to the **Contacts** section.

1. Associate a contact:

    - To [create a contact](#create-a-contact) and associate it with the account at the same time, select **New Contact**.
    - To associate an existing contact, select **More commands** (**&vellip;**) > **Add Existing Contact**. Search for and select one or more contacts, and then select **Add**.

    You can associate a contact with only one account. If you select a contact who is already associated with a different account, you get an error message.

1. Select **Save & Close**.

### View opportunities associated with a contact

1. In the sitemap of your sales app, select **Contacts**.

1. Select a contact in the list.

1. On the **Summary** tab, scroll down to the **Opportunities** section.

    Or, select the **Related** tab. Scroll down to the **Related - Sales** group, and then select **Opportunities**.


## Import accounts or contacts from Excel, CSV, and XML Files

You can add accounts and contacts by importing them from a Microsoft Excel, CSV, or XML file or from Microsoft Exchange. [Learn how to import data into Dynamics 365 Sales](import-data.md)
