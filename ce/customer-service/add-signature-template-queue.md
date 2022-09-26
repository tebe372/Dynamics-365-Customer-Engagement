---
title: Add a default signature template to a queue | MicrosoftDocs
description: "Learn how to set up email signature templates for queues."
ms.date: 09/26/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
searchScope: 
  - D365-App-customerservicehub
  - D365-Entity-queueitem
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Customer Service
---

# Configure a default signature template for a queue

You can add a default signature template for a queue to ensure that emails sent with the queue as the sender have consistent email signatures. When you send an email with the queue as the sender or reply to messages received by the queue, the default signature is added to the body of email. If you don't specify a default signature template for a queue, the application defaults the signature associated with the owner of the queue.

More information: [Add an email signature](#add-an-email-signature)

You can set up a default email signature for a queue as follows:

1. Go to one of the admin apps, and perform the following steps:
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
        
    1. In the site map, select **Queues** in **Customer support**.
    
    1. On the **Queues** page, select **Manage** for **Basic queues**.

   ### [Customer Service Hub](#tab/customerservicehub)

    1. Go to **Service Management**, and then select **Queues** in **Case Settings**.
  
2. To create a queue, select **New**. To edit a queue, select the queue in the list of queues, and then select **Edit** on the command bar.  
1. In the **EMAIL SETTINGS** section, specify the signature template in  **Email Signature**.

 ![Add a default signature template.](media\email-sig-temp-queue.png "Add a default signature template to a queue")

### See also  

[Create a signature for emails](/power-apps/user/email-signature)  