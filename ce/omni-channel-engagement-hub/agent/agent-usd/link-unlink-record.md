---
title: "Link and unlink a record in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn on how to Search for records in Omni-channel Engagement Hub and link the record to a conversation."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 03/07/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 905AB9D1-B18E-4E4B-98F3-2BEBE4EE61B6
ms.custom: 
---

# Link and unlink a record to the conversation

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The topic explains how to link and unlink a record to the conversation.

## Link a record to the conversation when doing inline search

> [!div class=mx-imgBorder]
> ![Customer profile and Issue snapshot are blank when there are no records](../../media/agent-inline-search-no-record.PNG "Customer profile and Issue snapshot are blank when there are no records")

During inline search, the search results are displayed, and you can select a record to link the conversation to the selected record. After you link the record, the **Customer summary** form loads with the details.

> [!div class=mx-imgBorder]
> ![Cusomter summary is loaded with details after linking](../../media/agent-inline-search-link.PNG "Cusomter summary is loaded with details after linking")

## Link a record by doing advanced search

You can link a record in the list of search results to a conversation. You can link only one record to a conversation.

1. Select the ![omni-channel select icon](../../media/select-icon.png "omni-channel select icon") icon to view the selection list.

 > [!div class=mx-imgBorder]
 > ![omni-channel select records](../../media/agent-select-records-link.png "omni-channel select records")

2. Select the check box next to the record you want to link.

 > [!div class=mx-imgBorder]
 > ![omni-channel select checbox](../../media/agent-select-record-checkbox.png "omni-channel select checkbox")

3. Select the link button at the top.

 > [!div class=mx-imgBorder]
 > ![omni-channel send link](../../media/agent-select-link-button.png "omni-channel send link")

After you link the record to the conversation, the Customer summary form is refreshed and reflects the details. Similarly, you can link other record types.

## Unlink a record from the conversation

You can unlink a record only when you are interacting with customer using the communication panel. That is, after you accept an incoming conversation request and view the **Customer summary** page, you can unlink the record from the conversation. 

![Select X button next the textbox to unlink](../../media/csh-oc-unlink-customer.PNG "Unlink a record")

To unlink a record, select the **X** button next to the customer name in the **Customer profile** form. After the record is removed, the **Customer profile** form is blank. 

![Blank customer profile form after unlinking the record](../../media/csh-oc-unlinked-form.PNG "Blank customer profile form after unlinking the record")

## See also

- [View call scripts, take notes, and search knowledge articles](right-control-panel.md)
- [View customer summary for an incoming conversation request](view-customer360-incoming-conversation-request.md)
- [Create a record](create-record.md)
- [Search for records](search-record.md)