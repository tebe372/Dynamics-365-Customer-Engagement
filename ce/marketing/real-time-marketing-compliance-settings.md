---
title: "Manage user compliance settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to manage real-time marketing compliance settings in Dynamics 365 Marketing."
ms.date: 04/01/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Manage user compliance settings

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

## Compliance terms and definitions

- **Consent center** (under the **Settings** tab): The location where you can check and manage your customers’ preferences and export consent audit reports.
- **Compliance** (under the **Settings** tab): The location where an administrator sets up the compliance system, defining the consent model and the descriptions for the end user’s preference center page.
- **Consent model**: The model that is applied throughout the system. In the private preview, there are only two options to select from: Restrictive and Non-Restrictive (see details below).
- **Preference page**: A web page for your customers where they can change their consent settings for receiving emails and text messages, as well as for tracking.

## Compliance setup

At the time of setup or later, the administrator or power user needs to go to **Settings** > **Compliance**  and define the consent model, the company address, and customize the preference center page for your end users.

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/compliance2.png)

First, the administrator must select which consent model your system will use. The consent model selection is made once and can’t be changed afterwards.

There are two options to select from in Private Preview. With the **Restrictive** model, your customers’ opt-ins will be required for sending marketing emails and text messages, and for behavior tracking. Default values for these fields are the following:

| Allow Email  | Allow SMS    | Allow Tracking   |
|--------------|--------------|------------------|
| FALSE        | FALSE        | FALSE            | 

With the **Non-restrictive** model, your customers’ initial opt-ins will NOT be required for sending marketing emails and for behavior tracking. In compliance with the [United State Telephone Consumer Protection Act (TCPA)](https://www.fcc.gov/sites/default/files/tcpa-rules.pdf), sending text messages will still require customers to opt-in first. Default values for these fields are the following:

| Allow Email  | Allow SMS    | Allow Tracking   |
|--------------|--------------|------------------|
| TRUE         | FALSE        | TRUE             | 

You also need to enter a valid physical postal address for your organization. The address will be included in the content of all marketing emails. If the field is empty or contains the default value ("TestAddress"), marketing emails will be blocked in the customer journey.

## Preference page

The second step setting up the compliance center is defining the content for the Preference page – the public web page that your customers can access to review and change their preferences.

> [!div class="mx-imgBorder"]
> ![compliance settings](../media/preference-page.png)

> [!NOTE]
> The following Preference page examples are not recommendations or advice on what you are legally required to have in your compliance Preference page. It is your sole responsibility to ensure that you comply with all applicable laws, including obtaining valid consents from your end users.

The Preference page includes the following content: 

- **Page title**: The title of the page 
- **Description**: A description that clarifies the purpose of this page 
- Names and descriptions of all three consent dimensions 
    - **Allow email**
    - **Allow SMS**
    - **Allow tracking**
- **Legal text**: Usually contains hyperlinks to your Terms of Service and Privacy Policy, which are displayed at the bottom of the page 
- **Consent change reason label**: Text for the "Consent change reason” dropdown 
- **Submit button label**: Text for the “Submit” button
- **Thank you page**: Text for the confirmation or “thank you” page (in case of success)
- **Error page**: Text for the error page (in case of error in submitting)

After configuring the **Compliance** and **Preference page** tabs, select the **Save** button.