---
title: "Create and manage data masking rules | MicrosoftDocs"
description: "Instructions on how to create and manage data masking rules in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 03/06/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: EE5A853F-F531-4EA6-9E64-B5CA9B021AFE
ms.custom: 
---

# Create and manage data masking rules

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Data masking allows you to block sensitive data such as credit card information, social security numbers (SSN), or even profanity in a conversation. You can create a masking rule and define a regular expression in it to identify the sensitive information and replace it with the masking character. The masking rule applies to every message sent by a customer through a chat or an SMS channel. If an agent sends any sensitive data to a customer, it will not be masked. 

The following masking rules are provided out of the box:

- **Credit Card**: Masks the credit card number, if provided in a message.
- **Email**: Masks the email address, if provided in a message.
- **SSN**: Masks the social security number, if provided in a message.

As an administrator, you can delete or modify out-of-the-box masking rules and create new masking rules.

> [!NOTE]
> Only an administrator can access data masking rules.

## Create a data masking rule

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Data Masking**.

3.	Select **New** to add a data masking rule.

4.	On the **New Masking Rule** page, provide the following information:

    - **Name**: Name of the masking rule.

    - **Description**: Optional description of the masking rule.

    - **Regular expression**: Regular expression to identify the data to be masked.

        > [!NOTE]
        > By default, the \# symbol is used to mask the sensitive data.
        
5. To test the data masking as per the specified regular expression, enter a value in the **Enter test data** field. The masked value is displayed in the **Masked test data** field.

    > [!div class=mx-imgBorder]
    > ![Data masking rule](../media/masking-rule.png "Data masking rule")

6. Select **Save**.

## Manage data masking rules

Once a masking rule is created, you can activate a rule, deactivate a rule, or delete it permanently.

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Data Masking**.

3. Open the masking rule to be managed.

4. To activate a masking rule, select **Activate** from the toolbar at the top of the screen.

5. To deactivate a masking rule, select **Deactivate** from the toolbar at the top of the screen.

6. To delete a masking rule, select **Delete** from the toolbar at the top of the screen.
