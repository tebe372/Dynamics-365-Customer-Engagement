---
title: "Personalize text messages through templates"
description: "Personalize the text messages (SMS) by inserting placeholders in your template for the specific information that will be different for each recipient."
ms.date: 02/10/2023
ms.topic: how to
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Personalize text messages through templates

Personalize the text messages (SMS) by inserting placeholders in your template for the specific information that will be different for each recipient. The placeholders will then dynamically populate values such as customer name, appointment time, location, or any other unique data.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br> More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## Example

For example, you have a template that says:

Hi {{ContactFirstName1}},  
Happy to connect with you on a phone call at {{UserUTCConversionTimeZoneCode}} regarding 3D printer.  
Best regards,  
{{UserFirstName}}

You can use this template to send personalized messages to each of your customers by dynamically filling the placeholders such as, {{ContactFirstName1}} and {{UserFirstName}} with appropriate information for each recipient.


## To create a message template

1.	Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **Personal settings** > **Text message templates**.

2.	From the tool bar, select **New**.

3.	On the **Create a text message template** dialog box, enter the following information: 

    -	**Template name**: Enter a name for the template.

    -	**Category**: Select a category (entity) from which you want to use the placeholders that are used in the template. The entities that are supported are – Account, Contact, Lead, and Opportunity. When you select an entity, its corresponding related entities are also displayed while adding the placeholders.

    -	**Language**: Display installed language packs. Language also helps to categorize your templates.

4.	Select **Create**.

    The template editor opens.

5.	On the **Text message template** page, in the **Message** section, enter the message including placeholders for dynamic content. More information on dynamic content, see [Insert dynamic content](#insert-dynamic-content).

6.	Save and close.

    The template is created and added to the list of text message templates.

## Insert dynamic content

Dynamic text replaces a placeholder entity with the value of the entity when you send the email. For example, your email template might contain "Dear {!User:First Name;}" but your customer sees “Dear Kenny.”

1.	In the **Message** section from the **Text message template** page, select the **Personalization** icon.

    Brackets are inserted as placeholders and the **Personalization** dialog box opens to choose the field to insert.

2.	Select **Choose an attribute** and then select the required field from the entity.

3.	(Optional) In the **Display name** field, enter a display name for the placeholder. By default, the name is displayed as entity type field name. For example, when you select the Account Name field from the Account entity, the display name is **AccountAccountName**.

4.	(Optional) In the **Default value** field, enter a default value. When there is no value available for the placeholder field, the default value is added to the message.

5.	Select **Save**.

To add more placeholders for dynamic content, repeat steps 1 to 5.


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Send a text message](steps-sequence.md#send-a-text-message)   
[Send an automated text message](steps-sequence.md#send-an-automated-text-message)   
[Send a text message to customers](connect-with-customers.md#send-a-text-message-to-customers)    
[Manage text message communications](manage-text-message-communications.md)