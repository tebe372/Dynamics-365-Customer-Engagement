---
title: Enhanced case management in multisession apps
description: Learn about the enhanced case management in Customer Service multisession apps
author: gandhamm 
ms.author: mgandham 
ms.reviewer: neeranelli
ms.topic: conceptual
ms.date: 04/03/2023 
ms.custom: bap-template 
---


# Case management in multisession apps

The enhanced case management experience in Customer Service workspace allows agents to verify and edit customer details without switching tabs, add updates to existing cases without interrupting the case creation flow, and avoids case duplication.

## Create cases using quick create

A quick create form allows you to create a related record within a form for another table. You can use the quick create form to create a new case from within a form without navigating to a different page.

For example, if you select **New Case** in the **Customer Service Agent Dashboard**, a quick create form for a new case appears as a flyout.

Depending on whether your administrator has enabled the **Quick case form** in Customer Service admin center, you'll see one of the following layouts.

   ### [Enhanced Quick case form](#tab/enhancedquickcreateform)

   If your administrator has enabled the **Quick case form** and set **Choose Form** to **Enhanced quick case form**, the enhanced quick case form appears. A few scenarios where the enhanced quick case form appears is when you select **New Case** in the following:

- Customer Service Agent Dashboard.
- AI-generated summary of a customer conversation.
- contact or account form 
- Active conversation form
-  **Child cases** subgrid on an existing case.

 You can perform the following actions when the quick case form is open:

   - Access, copy, or edit the information in the background form or view. You can also paste information from the background to the case form.
   - On **New Case**, you can specify data in the following tabs:
      - **Details**:
           - Required fields such as **Customer** and **Title** of the case.
           - **Description**: Add information related to the case. The rich text editor toolbar helps you format text, add images and links to this field. You can also drag and drop files on to the description section.
           - Color coded **Case Status** fields and **Priority** icons.
      - **Case notes**: You can add relevant information such as the steps tried to resolve the issue or important details that have to be included as notes without having to save the case. The rich text editor toolbar helps you format text, add images and links in this field. You can use either the attachment icon to upload attachments or drag and drop files.
      - **Attachments**: Select **Add Attachment** to upload multiple attachments at once.
   - If you’d like to provide additional information, you can switch to the main case form.  All the details you've added to the case are added automatically when you switch to the main form.
    
   :::image type="content" source="media/quick-case-contact-mini.png" alt-text="Enhanced quick case form" lightbox="media/quick-case-contact.png":::

   ### [Default Quick create form: case](#tab/quickcreateform)
    
   If your administrator hasn't enabled the **Quick case form** in Customer Service admin center, the default **Quick Create: Case** form appears when you create a case using the quick create option.

   :::image type="content" source="media/quick-case-default-mini.png" alt-text="Default quick case form" lightbox="media/quick-case-default.png":::

   ---

## Create a case from the main case form

You can create a new case from the main case form. Depending on whether your administrator has enabled the enhanced **Full case form** in **Customer Service admin center**, you'll see one of the following layouts.

   ### [Enhanced full case form](#tab/enhancedfullcaseform)

   On the enhanced full case form, you can perform the following actions:
   - Specify the customer to display the relevant customer details and recent cases on **Customer Card** and  **Recent cases**.
   - Use **Case Notes** and **Description** to record notes and information related to the case. The rich text editor toolbar helps you format text, add images and links to these field. You can also drag and drop files on to the description section.
   - **Attachments**: Select **+ Add Attachment** to upload multiple attachments at once.
   -  View color coded **Case Status** fields and **Priority** icons.
   - **Save and Resolve**: The form has an additional option to save the case and initiate the case resolution process.
    
   :::image type="content" source="media/enh-case-newcase-mini.png" alt-text="Enhanced main case form" lightbox="media/enh-case-newcase.png":::

   ### [Default main case form: Case](#tab/fullcaseform)
    
   If your administrator hasn't enabled the **Full case form** in Customer Service admin center, you'll see the default main case form.

   :::image type="content" source="media/def-case-maincas-mini.png" alt-text="Default main case form" lightbox="media/def-case-maincase.png":::

   ---

## View an existing case using enhanced Full case form

If your administrator has enabled the **Full case form** and you save the case using **Enhanced Full case form**, you'll see the following: 
   - An SLA timer that displays the time within which the agents must first respond to a customer and the time by which they must resolve the case.
   - Links with the activities associated to the case that are either due that day or past their due date. You can select the link to view the open activities associated with the case on a tab your administrator has configured. By default, it displays open activities in the Activities tab. More information: [Specify tab to redirect users to view the open activities for a case](case-enh-config.md)
   - Related customer and recent case information on the **Customer details** side panel.  
   -  The **Queue item details** displays the current queue the case belongs to and the **Worked by** field.
   - View details of the relevant records associated to a case on **Case associations**.  
   -  Timeline to view information related to the events that happened on the case.
   - Upload and view attachments linked to the case on the **Attachment** tab. You can also:
      - See the source of the attachment such as direct upload, attachments uploaded through notes or shared through conversation and the user who uploaded the attachments.
      - Use the dropdown list to switch between grid and tile views.
      - Search for attachments
      - Sort and filter attachments based on **Name**, **Size**, **Uploaded on**, **Uploaded by**, and **Source**.
      - Select the attachment to preview the content of the attachment. This is only supported for pdf and image files.
      - Download and delete multiple attachments at once.

   > [!NOTE]
   > - You can only delete attachments with the **Source** set to **Direct Upload**.
   > - For an attachment shared over a conversation, **Uploaded By** is set to **Omnichannel User** and the **Uploaded on** is the time when the conversation ended.
   > - You'll see the enhanced full case form when you open an existing case only if your administrator has set enhanced **Full case form** as the default form.

:::image type="content" source="media/edit-full-case-form.png" alt-text="Edit enhanced main case form":::

## Customer Details and Recent Cases

If your administrator has enabled the **Enhanced case experience**, when you create a new case and specify **Customer** or **Account**, or open a case after saving it, the application displays the following:
- **Customer Details**: Displays the customer details configured by your administrator. You can edit the information inline, copy the information and initiate activities such as email or phone call. The activities open as a new quick create form on the main page. The information displayed is based on your administrator's configuration.
- **Recent Cases**: Displays the recent cases linked to customer or account. The information displayed is based on your administrator's configuration. More information: [Configure components to display customer details and recent records](add-display-components-to-case-form.md).


### See also

[Enable enhanced case forms for multisession apps](case-enh-config.md)<br>
[Get started with Customer Service workspace](csw-overview.md)<br>
[View Active conversation to get available information about customers](oc-customer-summary.md)
