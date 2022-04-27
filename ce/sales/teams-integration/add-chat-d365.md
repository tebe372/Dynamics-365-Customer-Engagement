---
title: Add chat messages to Dynamics 365 as notes or tasks
description: Learn how to add chat messages to Dynamics 365 as notes or tasks
ms.date: 04/27/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Add chat messages to Dynamics 365 as notes or tasks (production-ready preview)

While you're in a conversation about a particular record, you might discuss certain action items, or important points that you want to capture in Dynamics 365. The app makes it easy for you to add such messages as notes or tasks to the corresponding record.

**To add a chat message to a Dynamics 365 record:**

1.  Hover over the message that you want to add as a note or task, and then select **More options** (**…**).

2.  In the context menu, select **More actions** &gt; **Add to Dynamics 365**.

    ![Add a chat message to Dynamics 365](media/me-add-to-d365.png "Add a chat message to Dynamics 365")

3.  In the **Regarding** field, select the record to which you want to add the message as a note or task.

4.  In the **Title** field, enter a title for the note or task.

    ![Add a chat message as note](media/me-add-note.png "Add a chat message as note")

    By default, the message is added as a note. If you want to add the message as a task, select **Add as Task** in the upper-right corner of the window. The values from the **Regarding** and **Title** fields are populated in the task accordingly.

    > [!NOTE]
    > The message is added to the description field of the note or task. Rich text format is not supported for tasks. So, if you try to add rich text messages, you'll only see the chat URL in the description for tasks. You can manually copy and paste the chat message in such cases.

5.  Select **Save**.

    The note or task is added to the timeline of the record.

    By default, the note or task card is sent to the conversation. If you don't want to send the note or task card to the conversation, clear **Send note card to conversation** or **Send task card to conversation**.

6.  Select **Done**.

    ![Chat added as a note](media/me-note-added.png "Chat added as a note")

    The note or task is added to the record's timeline. A **View Chat** link is added to the note or task. Selecting the **View Chat** link opens the conversation in Teams.

    ![Note added to the record](media/me-notes-timeline.png "Note added to the record")


### See also

[Share and update Dynamics 365 records within Microsoft Teams conversations](share-d365-record-overview.md)   
[Access the Dynamics 365 app through messaging extensions](access-d365-app.md)   
[Edit settings of the Dynamics 365 app](edit-d365-app.md)    
[Share feedback](share-feedback-d365-app.md)    
[Share Dynamics 365 records within Microsoft Teams conversations](share-dynamics-records-in-teams.md)   
[View and update record details](view-update-dynamics-records.md)   
