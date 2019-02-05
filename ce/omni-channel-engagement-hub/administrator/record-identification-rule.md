---
title: Set up pre-chat questions to automatically load customer details for work streams | MicrosoftDocs
description: See how you can Set up pre-chat questions to automatically load customer details for work streams in the Omni-channel Engagement Hub
keywords: set up pre-chat questions to automatically load customer details for work streams; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6da7ee5c-9e34-4f01-920c-6c381d2f4157
ms.custom: 
---

# Automatically identify customers using pre-chat responses

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Identify and assist customers better by showing their details on the **Customer summary** page. To automatically identify and load customer and case details for an incoming conversation, you need to set up pre-chat questions in the relevant chat widgets. Customer responses are used to search for details in the Dynamics 365 records and display the results. For an Account or Contact, the search is performed on **Name**, **Email**, or **Phone Number** field. For Cases, the search is performed on **Case Number** field.

When an incoming conversation request is received, a notification appears that includes contextual information for the request, including customer details  if available. When an agent accepts the incoming notification, the **Customer summary** page opens, and shows the details of the identified customer and case. 

For more information, see [View Customer summary for an incoming engagement request](../agent/agent-csh/csh-view-customer-360-incoming-conversation-request.md).

> [!NOTE]
> To know how to create pre-chat questions and use them in a pre-chat survey, see [Create a question library](create-question-library.md) and [Configure a pre-chat survey](configure-pre-chat-survey.md). 

Use the below question names to create pre-chat questions for an **Unauthenticated chat**.

|Question name   |Answer type |
|---------|---------|---------|
|CaseNumber     |    Single line |  
|Name      | Single line         |   
|Email      |    Single line      |  
|Phone      |  Single line       |   
|    |         |         |

For **Authenticated chat**, the details that a customer enters, are used to search and load customer information in the **Customer summary** page. However, you can create a pre-chat question for **Case Number** to allow identification of the relevant case for the current conversation.

|Question name  |Answer type  |
|---------|---------|---------|
|CaseNumber    |     Single line    |  |    
|         |         |


### See also

[Create and manage work streams](create-work-streams.md)
