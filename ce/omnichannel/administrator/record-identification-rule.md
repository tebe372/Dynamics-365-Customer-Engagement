---
title: Automatically identify customers using pre-chat responses | MicrosoftDocs
description: See how you can Automatically identify customers using pre-chat responses in the Omnichannel for Customer Service
author: kabala
ms.author: kabala123
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
---

# Automatically identify customers using pre-chat responses

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Identify and assist customers better by showing their details on the **Customer summary** page. To automatically identify and load customer and case details for an incoming conversation, you need to set up pre-chat questions in the relevant chat widgets. Customer responses are used to search for details in the records and display the results. For an Account or Contact, the search is performed on **Name**, **Email**, or **Phone Number** field. For Cases, the search is performed on **Case Number** field.

When an incoming conversation request is received, a notification appears that includes contextual information for the request, including customer details  if available. When an agent accepts the incoming notification, the **Customer summary** page opens, and shows the details of the identified customer and case. 

For more information, see [View Customer summary for an incoming engagement request](../agent/agent-oc/oc-view-customer-summary-incoming-conversation-request.md).

> [!NOTE]
> To know how to create pre-chat questions and use them in a pre-chat survey, see [Configure a pre-chat survey](configure-pre-chat-survey.md). 

Use the below question names to create pre-chat questions for an **Unauthenticated chat**.

|Question name   |Answer type |
|---------|---------|---------|
|CaseNumber     |    Single line |  
|Name      | Single line         |   
|Email      |    Single line      |  
|Phone      |  Single line       |   
|    |         |         |

For **Authenticated chat**, the logged in user details will be used to search and load contact information in the **Customer summary** page. You can add pre-chat question for **Case Number** to allow identification of the relevant case for the current conversation.

|Question name  |Answer type  |
|---------|---------|---------|
|CaseNumber    |     Single line    |  |    
|         |         |


### See also

[Understand and create work streams](work-streams-introduction.md)
