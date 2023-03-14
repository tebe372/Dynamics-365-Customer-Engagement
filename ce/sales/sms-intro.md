---
title: "Engage with customers through text messages"
description: "Enable your sellers to send text messages (SMS) to customers and refer previous communications in context without leaving the application or losing view of customers' details."
ms.date: 02/10/2023
ms.topic: overview
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Engage with customers through text messages

Sending and receiving text messages through SMS is an effective way for sellers to reach out to potential customers as it is fast, convenient, and allows for quick responses. Sellers use SMS to stay in touch with their customers, by responding to questions or concerns, and providing updates and information on products/services.  
Dynamics 365 Sales enables your sellers to send and receive SMS from customers through the text message feature. Also, sellers can refer to their past communication in context without leaving the application or losing their view of their customers' details.   

In the sequences, SMS can be included as a step to send reminders or updates about key events. 

>[!NOTE]
>The text message feature is being rolled out in a phased manner across different geographic regions. To verify whether the feature is available in your region, look for version 9.0.23023.10002 in the [Latest version availability](/dynamics365/released-versions/dynamics365salesinsights) section.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br> More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## How can I use the text message feature?

Depending on your role, you can use the text message feature as described in the list:

-	System administrator or similar role:
    -	Configure the SMS provider in your organization for sellers to use. More information: [Configure SMS provider](configure-sms-provider.md)
    -	Assign or remove phone numbers of users. More information: [Edit phone numbers](edit-phone-numbers.md)
    -   Add the text message option to custom forms. More information: [Add text message option to custom forms](add-sms-option-custom-forms.md)      
- 	Sales manager, seller, or any other similar role: 
    -	Choose a service provider to send and receive SMS. More information: [Understand the conversation pane](manage-text-message-communications.md#understand-the-conversation-pane)
    -	Add text message and automated text message as steps in a sequence. More information: [Send a text message](steps-sequence.md#send-a-text-message) and [Send an automated text message](steps-sequence.md#send-an-automated-text-message)
    -	Create and add SMS templates. More information: [Personalize text messages through templates](create-text-message-templates.md)
    -	Send SMS from the Sales accelerator workspace or the Up next widget. More information: [Send a text message to customers](connect-with-customers.md#send-a-text-message-to-customers)
    -	Access past SMS interactions in context with relevant sales records such as, lead and opportunity. More information: [Manage text message communication](manage-text-message-communications.md)

## Permissions required 

Verify that the users who need to use the text message feature have the following permissions.

>[!NOTE]
>If you’ve already enabled Sales accelerator and provided access to the required security roles, no additional permissions are required for the SMS feature. To provide permissions in Sales accelerator, see [Sales accelerator first-run setup](enable-configure-sales-accelerator.md#first-run-setup) 

**For Salesperson or similar role**:<a name="salesperson-roles-sms-feature"></a>

| Tab name | Entity name | Access level | Privileges required |
|----------|-------------|--------------|---------------------|  
| Core Records | - Activity<br>- Note | User | - Create<br>- Write<br>- Delete<br>- Append |
| Core Records | - Activity<br>- Note | Business Unit | Read | 
| Custom Entities | Channel Instance | User | Append To |
| Custom Entities | - Channel Instance<br>- Channel Instance Account<br>- Consuming Application<br>- Channel Definition<br>- SalesOmnichannel Message<br>- Transcript | Business Unit | Read |
| Custom Entities | SalesOmnichannel Message | User | - Create<br>- Write<br>- Delete<br>- Append<br>- Assign |
| Custom Entities | Text message template | Business Unit | - Create<br>- Write<br>- Read<br>- Delete |
| Custom Entities | Transcript | User | - Create<br>- Write<br>- Delete<br>- Append<br>- Append To |

**For Sales Manager, Sequence Manager, or similar role**:

The following roles are required along with the roles defined in the [Salesperson section](#salesperson-roles-sms-feature):

| Tab name | Entity name | Access level | Privileges required |
|----------|-------------|--------------|---------------------|  
| Custom Entities | Channel Instance | Business Unit | - Assign<br>- Write |
| Custom Entities | - Channel Definition locale<br>- Telesign channel instance account<br>- Twilio channel instance account | Business Unit | Read |
| Custom Entities | - TeleSign channel instance<br>- Twilio channel instance | Business Unit | - Read<br>- Write<br>- Assign |


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Configure SMS provider](configure-sms-provider.md)    
[Edit phone numbers](edit-phone-numbers.md)  

