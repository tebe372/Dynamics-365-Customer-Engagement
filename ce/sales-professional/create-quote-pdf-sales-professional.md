---
title: "Create a quote PDF (Dynamics 365 for Sales Professional) | MicrosoftDocs"
description: "Create and share a professional-looking quote PDF with your customers."
keywords: "Quote, proposal, create PDF, email PDF, PDF"
ms.date: 05/23/2019
ms.service: dynamics-365-sales
ms.topic: article
applies_to: Dynamics 365 for Customer Engagement
ms.assetid: d663fd4a-b638-4810-a3ad-99789b5173fa
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.custom: dyn365-sales
---

# Generate a PDF document from a quote record

Create and share a professional-looking quote by generating a PDF document from a quote record using a standard template from your organization.

> [!IMPORTANT]
> The capability to create quote PDF is introduced in version 9.1.1904.1025. The **Create PDF** and **Email as PDF** options are available only if your system administrator has enabled the PDF-generation capability for your organization. If you do not see these options, please talk to your system administrator.



1.	Open a quote record.

2.	On the command bar, select **Create PDF**, and then select the quote template. 

    ![A quote form showing the Create PDF button on the command bar](media/create-pdf-sales-professional.png "A quote form showing the Create PDF button on the command bar")
    
     A PDF using the selected template is downloaded to your computer. You can add this document to a note or send it as an attachment in email.

    > [!TIP]
    > To learn more about using Word templates, see [Use Word templates to create standardized documents](../admin/using-word-templates-dynamics-365.md). 


## Email as a PDF document

You can also generate a PDF document and directly email it to a customer.

1.	Open the quote record.

2.	On the command bar, select **Email as PDF**, and then select the quote template.

    ![A quote form showing the Email as PDF button on the command bar](media/email-as-pdf-sales-professional.png "A quote form showing the Email as PDF button on the command bar")
    
    An email form opens. 
    
    The following information is automatically populated.

    |Field             |	Populated with                                 |
    |------------------|-------------------------------------------------| 
    |**To**                |	Potential customer of the quote                |
    |**From**	             |  Current user                                   |
    |**Attachments**       |	The generated PDF, added as an attachment         |
    |**Regarding**	       |  Quote record from which the email was triggered| 
    |**Subject**	         |  Quote title                                    |

3.	Verify and change any details in the email form, and select **Send**.


> [!IMPORTANT]
> The time taken to generate the PDF document and download or send email is dependent on the size of the file. You'll see optimum performance when the file size is less than 2 MB. Larger files can require considerably more response time.

### See also

[Enable PDF generation from quotes](enable-pdf-generation-quote-sales-professional.md)  
[Create or edit a quote](create-quotes-sales-professional.md)
