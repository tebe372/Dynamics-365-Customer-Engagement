---
title: "Timeline Overview for Users | MicrosoftDocs"
description: "Timeline Overview for Users"
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 12/17/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
ms.reviewer: lalexms
---

# Use timeline

Timeline is a control that allows you to view information that is connected to an entity record and occurs over time in a single stream. Some information that can be logged into the timeline are notes and posts in addition to displaying activities such as emails, appointments, phone calls, and tasks.

Timeline allows you to:
- Access the command bar to perform common actions quickly.
- Filter and view important notes, posts, and activities using multiple filter options.
- View and manage email conversation threads with ease.

![Timeline Browser Overview](media\timeline-browser-view.png "Timeline Browser Overview")

## Timeline functionality

The timeline section on the entity form is intended to centralize access to information and streamline effort to accomplish actions. The following is an overview of how the timeline functionality works in each section on the entity form. 

When enabled by your system administrator, you can use the icons that are displayed on the top-right navigation in the timeline for quick access to do the following:

- [Create a timeline record](#create-a-timeline-record)
- [Work with Filters](#work-with-filters)
- [Work with Records](#work-with-records)
- [Explore more commands](#more-commands)
- [Search Records](#search-records-on-timeline)
- [Add attachments](#add-an-attachment-to-a-note-in-timeline)

## Create a timeline record

When enabled by your system administrator, you can use the **Create a timeline record** feature to quickly create appointments, tasks, send emails, as well as make notes and posts and associate them with other records. 

1. Select **Create a timeline record** icon.<BR><BR>
![Create a timeline record](media\timeline-create-a-record-icon1c.png "Create a timeline record") 

2. Select the type of record you want to create from the display options available. <BR><BR>
![Select type of timeline record](media\timeline-create-a-timeline-record-1f.png "Select the type of timeline record")

For information on timeline record configuration, see [Configure activity record types](customer-service-hub-user-guide-timeline-admin.md#configure-activity-record-types). 

## Work with filters

When enabled by your system administrator, the timeline **Filter** further streamlines your productivity by allowing you to customize your experience and view data relevant to you. 

![Timeline filter functionality](media\timeline-filter-12b.png "Timeline filter functionality")

Legend:
1. The Timeline **Filter** ![](media\timeline-filter-icon.png "Filter") icon is located in the top-right navigation on the timeline.
2. The filter pane displays when the **Filter** icon is selected.
3. Use the carats to expand or minimize selections.
4. When enabled by your system administrator, record and activity types are displayed in the filter pane. Record and activity types can be filtered by selecting the corresponding box next to the item.
5. The **Clear all filters** ![](media\timeline-clear-all-filters-icon.png "Clear all filters") icon removes and clears all filter selections from the filter pane.

### Filter records on timeline <a name="filter-records"></a>

Filters are valuable for sorting data. You can easily filter through records and activity types using multiple options to quickly see what matters to you. The filter is available for the activities, notes, posts, and custom entities that are present in timeline.

### Filter icon display

- When the **Filter** icon displays as transparent ![Clear Filter icon](media\timeline-filter-icon.png "Filter"), it means the filter pane is empty and nothing has been applied. 
- When the **Filter** icon displays as dark ![Dark Filter icon](media\timeline-filter-applied-1.png "Filter icon"), it means filters are applied. 

### Filter options

The following category and sub-category options are available on the filer menu:

| Category              | Sub-category   |
|-----------------------|----------------|
| Record type           |<li>Notes</li><li>Posts</li><li>Activities</li>|
|Activity type         |<li>Appointment</li><li>Campaign Activity</li><li>Campaign Response</li><li>Email</li><li>Fax</li><li>Case Resolution</li><li>Letter</li><li>Opportunity Case</li><li>Order Case</li><li>Phone Call</li><li>Quote Close</li><li>Recurring Appointment</li><li>Social Activity</li><li>Task</li><li>Project Service Approval</li><li>Booking Alert</li><li>Conversation</li><li>Session</li><li>Customer Voice survey invite</li><li>Customer Voice survey response</li><li>Custom activities (as configured by your system administrator)</li> |
|Activity status            |<li>Active</li><li>Overdue</li><li>Closed</li>|               
|Activity due date (active) |<li>Next 30 days</li><li>Next 7 days</li><li>Next 24 hours</li><li>Last 24 hours</li><li>Last 7 days</li><li>Last 30 days</li> |
|Posts by                   |<li>Auto post</li><li>Users</li> |
|Modified date              |<li>Last 24 hours</li><li>Last 7 days</li><li>Last 30 days</li> |

## Work with records  

When working with records, you can view key information at a glance or expand records to view more details. When you hover over a record, actions display you can use.

### Expand all records

When enabled by your system administrator, you can view timeline records quickly in a collapsed format or expand a record to see more details for ease of use.

![Expand all records functionality](media\timeline-expand-all-records-1d.png "Expand all records functionality")

Legend
1. The ![](media\timeline-expand-icon.png "Expand all records") icon is used to expand all records listed on the timeline.
2. Carats in the bottom right corner of records allow you to expand (^) or minimize (v) display views.
3. Each record has a list of commands relevant to their record type that displays in the top right corner for ease of use. 
4. Record backgrounds change to grey when you hover over it and becomes transparent again when you hover away.

## More commands

The **More commands** option contains refresh, sort, and email functionalities.

![More commands timeline functionality](media\timeline-more-commands-1.png "More commands timeline functionality")

Legend
1. The **More commands** ![](media\timeline-more-commands-icon.png "More commands") icon when expand provides additional functionality options.
2. The **Refresh timeline** command updates record details in the timeline.
3. The **Sort newer to older** or **Sort older to newer** command is used to sort records.
4. The **Always show email as conversations** or **Always show email as individual messages** command is used to enable or disables threaded email views.

## Threaded email views in timeline

Use the threaded email view option to save valuable space when you have emails with multiple replies. This view consolidates email threads when collapsed.

**Collapsed threaded email view**
![Collapsed threaded email view](media\timeline-threaded-email-views-1a.png "Collapsed threaded email view")

Legend
1. When enabled via the **Always show email as conversations** option under **More commands** ![](media\timeline-more-commands-icon.png "More commands icon"), emails with multiple responses are grouped together into threaded emails.
2. The **Show more** link appears in the bottom left corner of the last visible email in the thread to view the complete string of email responses. 

**Expanded threaded email view**

![Expanded threaded email view](media\timeline-threaded-email-views-2a.png "Expanded threaded email view")

Legend
1. When expanded, the most recent 10 email responses in the thread will display.  To display more, select **Show more** to expand the view again.
2. Emails in the same thread are displayed as being linked together.

### Enable threaded email views in timeline

Enabling the threaded email view is done via the timeline configuration in Power Apps. Threaded email views must be done in this setting for the specific entity, in the specific form, for each specific timeline.

Threaded email views can be enabled in timeline via two options:

**Option 1:**

You can enable the threaded email view using the **More Commands** feature ![](media\timeline-more-commands-icon.png "More commands") located in the right nav in timeline.

**Enable threaded email through the More Commands option**

Steps:
1. Use the **More commands** ![](media\timeline-more-commands-icon.png "More commands") icon on timeline which displays a flyout menu.
2. Select **Always show email as conversations** to  thread and group all emails in that specific timeline. 

![Enable threaded email view - option 1](media\timeline-threaded-email-views-4a.PNG "Enable threaded email view - option 1")

**Option 2:**

**Enable treaded email through Personal Options setting**

To enable threaded email via this option, go to the command bar and select **Settings**, then **Personalization Settings**. This will display the **Set Personal Options** dialog box so you can use  the following steps to enable threaded email view on timeline.

Steps:
1. Select the **Email** tab.
2. Select the **Show emails as conversation on Timeline** check box.
3. Select **OK**.

![Enable threaded email view - option 2](media\timeline-threaded-email-views-3a.PNG "Enable threaded email view - option 2")

> [!Note]
> The **emails as conversation view** is based on the user's preference. Personal setting are tied to the user and not the form, which means once you enable the threaded email view, the setting is applied to all your timeline views. 

## Search records on timeline

When enabled by your system administrator, you can easily search for records in the timeline. When you search for a phrase in the timeline, it searches in the title, subject of the record, body, or description fields of the record and displays the record for you.

![Enable threaded email timeline view - option 2](media\timeline-search-records-1a.png "Enable threaded email timeline view - option 2")

Legend
1. The **Search** bar allows you to quickly find records using keywords or phrases that the search feature will retrieve and display below the search bar.
2. Keywords that are used are highlighted.

## Work with notes and posts

Notes allow you to record richly formatted information and images for reference, summary, or investigation. You can easily add a mention to another user or a reference to a timeline record using Posts.  

### Add a note or post to a record on timeline

When enabled by your system administrator, you can either add a note or a post to a record on timeline. Each note has a maximum size limit of 100,000 characters.

You can also enter a note and add it to a record, but you can only add one attachment per note. If note is not enabled by your system administrator, you cannot add an attachment.

**Note display view**

When enabled by your system administrator, the **Note** field is displayed under the **Search** feature on timeline.

![Add a note to a record on timeline](media\timeline-add-a-note-to-a-record.png "Add a note to a record on timeline")

> [!NOTE] 
> You can only add an attachment in a note.

**Post display view**

When enabled by your system administrator, the **Post** field is also displayed under the **Search** feature on timeline.
![Add a post to a record on timeline](media\timeline-add-a-post-to-a-record-1.png "Add a post to a record on timeline")

> [!NOTE] 
> You cannot add an attachment in a post.

### Access the command bar to perform actions

When you hover your cursor on or expand an activity, post, or note, the command bar appears in the top-right corner of the record with the specific options that support that activity, such as assigning it to others, adding it to a queue, converting it to a case, liking or replying to a post, editing a note, or deleting an activity. However, not all records can perform the same actions. 

**Command actions by record**

![Command bar actions in timeline](media\timeline-access-command-bar-actions-1e.png "Command bar actions")

Legend
1. Only the actions associated with that record are displayed in the top-right command bar displayed in the record. 
2. Each record displays a different set of associated actions. Not all actions work on all records.


The following is an overview of the command bar icons and the actions they support: 

| Icon | Name | Description |
|-----|------|-------------|
| ![](media\email-assign-icon.png "Assign icon") |Assign | Lets you assign a task.|
|  ![](media\email-close-activity-icon.png "Close activity icon")|Close Activity| Lets you close the activity record.|
| ![](media\email-add-to-queue-icon.png "Add to queue icon") |Add to Queue| Lets you add a task to a queue.|
| ![](media\email-open-record-icon.png "Open record icon")|Open Record| Lets you open a record.|
| ![](media\email-delete-icon.png "Delete icon")|Delete| Lets you delete the record.|
| ![](media\email-reply-icon.png "Reply icon")|Reply| Lets you reply to an email. **Note**: This command is only available for Email.|
| ![](media\email-reply-all-icon.png "Replay all icon")|Reply All| Lets you reply to all for an email. **Note**: This command is only available on Email.|
| ![](media\email-forward-icon.png "Forward icon ")|Forward|Lets you forward an email. **Note**: This command is only available on Email.|
| ![](media\email-like-a-post-icon.png "Like a post icon")|Like this post| Lets you like a post. **Note**: This command is only available on Posts.|
| ![](media\email-edit-icon.png "Edit icon")|Edit this note|Lets you edit a note. **Note**: This command is only available on Notes.|

The following is an overview of the default command bars for frequently used activities, notes, and posts: 

| Activity | Command bar icons | Notes |
|-----|------|-------------|
| Email (draft) |Open Record, Delete | |
| Email | Reply, Reply All, Forward, Open Record | |
| Appointment | Assign, Close Activity, Add to Queue, Open Record, Delete | |
| Appointment (closed) | Assign, Add to Queue, Open Record, Delete | |
| Task | Assign, Close Activity, Add to Queue, Open Record, Delete | |
| Task (closed) | Assign, Add to Queue, Open Record, Delete | |
| Phone Call | Assign, Add to Queue, Open Record, Delete | |
| Note | Edit, Delete | |
| Post (user) | Like, Reply, Delete | Only the author of the post has the ability to delete it. The author always has the ability to delete regardless of user privilege. |
| Auto-post | Like, Reply, Delete | |

## Work with notes

The **Note** message box has a rich text editor that enables you to use rich text and create well-formatted content.

![Timeline notes rich text editor](media\timeline-take-a-note-2.png "Timeline notes rich text editor")

Legend
1. Note title field for adding headings and subjects.
2. Notes have a rich text editor so you can format and structure your messages.
3. The rich text editing tool expands to a full menu for quick access to formatting features.
4. The paperclip is used to attach files to your note.
5. Attached files are displayed at the bottom of the note.

> [!NOTE]
> - Only **Notes** have rich text capability, and it is only available in the timeline. 
> - You can only format the message body of a note, not the title.
> - The rich text editor is available only for Unified Interface.
> - If you create a rich text editor note in Unified Interface and then view the note in the web client, it will display in HTML syntax.

### Add an attachment to a note in timeline

When enabled by your system administrator, you can add an attachment, such as a file, to a note in timeline to share with users.

> [!NOTE]
> The list of allowed attachments is configured by your system administrator.

Select the paperclip ![](media\timelilne-paperclip-icon.png "paperclip icon") icon to attach a file to a note. 

![Attachment icon](media\timeline-add-a-note-to-a-record.png "Attachment icon")

### Edit Note

When you attach a file to your note, the **Edit note** screen displays, and attachments show at the bottom of the **Edit note** screen.

> [!IMPORTANT]
> You can only add one file attachment per note.

![Edit note screen](media\edit-note-timeline.png "Edit note screen")

## Use the rich text editor toolbar
The rich text editor toolbar provides features and functionality that allows you to work with rich text format in notes.

### Formatting options
The following table describes the different formatting features and functionality options that are available in the rich text editor that you can use in notes. For more information on the rich text configuration, see [customer-service-hub-user-guide-timeline-admin#notes-on-timeline](Configure notes on timeline.md).

> [!NOTE]
> You can access your browser's context menu by selecting **Ctrl + right-click**. This is useful if you need to use your browser's built-in spellchecker. Otherwise, you can right-click to provide contextual formatting for any element you are using.
  
|Icon | Name | Shortcut key | Description |
|----------------------|-------------------------|-----------------------------|-----------------------------|
|![Format Painter](../customer-service/media/format-painter.png "Format Painter")| Format Painter | Ctrl+Shift+C, Ctrl+Shift+V | Apply the look of a particular section to another section. |
|![Font](../customer-service/media/format-font.png "Font") | Font | Ctrl+Shift+F | Select a font of your choice. The default font is Segoe UI.<br /><br /> **Note**: When you select any formatted content, the font name for that content displays. If your selection contains multiple fonts, the topmost font name of your selection is displayed. |
|![Font Size](../customer-service/media/font-size.png "Font Size") | Font size | Ctrl+Shift+P | Change the size of your text. The default size is 9pt.<br /><br /> **Note**: When you select any formatted content, the font size for that content displays. If your selection contains multiple font sizes, the topmost font name of your selection is displayed.|
|![Bold](../customer-service/media/format-bold.png "Bold")| Bold | Ctrl+B | Make your text bold. |
|![Italic](../customer-service/media/format-italic.png "Italic")| Italic | Ctrl+I | Italicize your text. |
|![Underline](../customer-service/media/format-underline.png "Underline")| Underline | Ctrl+U | Underline your text. |
|![Text Highlight Color](../customer-service/media/text-highlight-color.png "Text Highlight Color")| Text Highlight Color |  | Make your text stand out by highlighting it in a bright color. |
|![Font Color](../customer-service/media/font-color.png "Font Color")| Font Color |  | Change the color of your text. |
|![Bullets](../customer-service/media/format-bullets.png "Bullets")| Bullets |  | Create a bulleted list. |
|![Numbering](../customer-service/media/format-numbering.png "Numbering")| Numbering |  | Create a numbered list. |
|![Decrease Indent](../customer-service/media/decrease-indent.png "Decrease Indent")| Decrease Indent |  | Move your paragraph closer to the margin. |
|![Increase Indent](../customer-service/media/increase-indent.png "Increase Indent")| Increase Indent |  | Move your paragraph farther away from the margin. |
|![Block Quote](../customer-service/media/block-quote.png "Block Quote")| Block Quote |  | Apply a block-level quotation format in your content. |
|![Align Left](../customer-service/media/align-left.png "Align Left")| Align Left | Ctrl+L | Align your content with the left margin. (Commonly used for body text to make it easier to read.) |
|![Align Center](../customer-service/media/align-center.png "Align Center")| Align Center | Ctrl+E | Center your content on the page. (Commonly used for a formal appearance.) |
|![Align Right](../customer-service/media/align-right.png "Align Right")| Align Right | Ctrl+R | Align  content to the right on the page. (Commonly used for a formal appearance.) |
|![Link](../customer-service/media/format-link.png "Link")| Link |  | Create a link in your document for quick access to web pages and files.<br /><br />Pasted or typed URL text is converted into a link. For example, "http://myexample.com" will become "<a href="http://myexample.com">http://myexample.com</a>".<br /><br /> In the **Link** dialog box, choose the type of link you'd like to insert.<br /><br />The **Link Info** tab allows you to choose the link type as well as set the link protocol and URL.<br /><br />The **Target** tab is only available for the URL link type. It specifies the location where the link will open after you select it. |
|![Remove Link](../customer-service/media/remove-link.png "Unlink")| Unlink |  | Delete a link in your email or document.<br /><br />When you place the cursor on a link, the **Unlink** button on the toolbar becomes active. Select the button to remove the link and make it plain text. |
|![Superscript](../customer-service/media/format-superscript.png "Superscript")| Superscript |  | Type small letters just above the line of text. |
|![Subscript](../customer-service/media/format-subscript.png "Subscript")| Subscript |  | Type  small letters just below the line of text. |
|![Strikethrough](../customer-service/media/format-strikethrough.png "Strikethrough")| Strikethrough |  | Cross out text by drawing a line through it. |
|![Insert Image](media\insert-picture.png "Insert Image")| Insert Image|	|You can insert an image by directly copying and pasting it inline in the editor, dragging and dropping it from your desktop or local folder directly into the editor, or by typing a URL. The following formats are supported: .PNG, .JPG., or .GIF.<br /><br />To insert an image inline in your article: <br />1. Drag and drop the image or copy and paste it directly into the article. <br />2. Drag any corner of the image to resize it.<br /><br />To insert an image using a URL or navigating to the local image:<br />1. Choose Insert Image.<br />2. In the **Image** property dialog, choose from the following options:<br /><ul><li>Select **Browse** to navigate to the image on your computer.</li><li>Or specify the web address of the image, and properties to define how the image will appear in the email or article.</li><br />**Note:**<ul><li>If the image is located on the external server, use the full absolute path. </li><li>If the image is located on a local server, you can use a relative path. </li><li>If you want the image to be linked to a target, add a URL for the image.</li><li>You can also specify if you want the targeted page to open in a new window, topmost window, same window, or parent window.</li></ul>
|![Left to Right](../customer-service/media/left-to-right.png "Left to Right")| Left to Right |  | Change the text to left-to-right for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. This is the default setting.|
|![Right to Left](../customer-service/media/right-to-left.png "Right to Left")| Right to Left |  | Change the text to right-to-left for content such as a paragraph, header, table, or list. Commonly used for bi-directional language content. The default setting is left-to-right. |
|![Undo Typing](../customer-service/media/undo-typing.png "Undo Typing")| Undo Typing |  | Undo changes you made to the content. |
|![Redo Typing](../customer-service/media/redo-typing.png "Redo Typing")| Redo Typing |  | Redo changes you made to the content. |
|![Clear All Formatting](../customer-service/media/clear-formatting.png "Clear All Formatting")| Clear All Formatting |  | Remove all formatting from a selection of text, leaving only the normal, unformatted text. |
|![Add a Table](../customer-service/media/add-table.png "Add a Table")| Add a Table |  | Add a table to your content. <br /><br />After adding a table, you can do any of the following:<br /><ul><li>Resize table columns by clicking and dragging your mouse to resize to the columns to the desired width.</li><li>Select one or several cells within a table and apply specific formatting, add links to the selection, or cut, copy, or paste entire rows or columns.</li><li>Right-click to access the properties. This supports features such as cell type, width and height, word wrapping, alignment, merging and splitting cells horizontally and vertically, inserting or deleting rows and columns, row and column span, and cell and border color.</li></ul>|
|![Expand Toolbar](../customer-service/media/show-more.png "Expand Toolbar")| Expand Toolbar |  | Appears when the toolbar is collapsed. Click to expand the toolbar and make all options visible. |

The rich text editor is enabled by default. Your system administrator can enable or disable the editor for you.

For more information, see [Enable rich-text editor for notes in timeline](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-or-disable-rich-text-editor-for-notes-in-timeline "Enable rich-text editor for notes in timeline").

## Work with posts

When enabled by your system administrator, you can either add a post to a record or mention to another user or timeline.

### Add a mention or reference a team member in a post

![Add a mention or reference to a team member in a post on timeline](media\timeline-add-a-mention-1.png "Add a mention or reference to a team member in a post on timeline")

Legend
1. Typing the @ sign in the **Post** field will display a flyout menu with a list of users that have been recently used.
2. If the user record is not displayed, typing the name after the @ sign refreshes the records in the flyout menu using the **Dynamics 365 Quick Find** search engine that's operating in the background.
3. Switch views using **Advanced** to display the **Lookup Records** pane. In the **Lookup Records** pane, you can switch between the **Recent records** and **All records** view to search records.

> [!NOTE]
> You can mention only a system user in a post.

### Add references in a post in timeline records

To add a reference such as links in a post to a timeline record, select the **Create a timeline record** ![](media\timeline-create-a-record-icon.png "Create a timeline record") icon and select **Post**, then follow the steps below:

![Add a link](media\timeline-add-link-12a.png "Add a link")

Legend
1. Links can be added to a record by typing **#** which will display a flyout menu with a list of records recently accessed. Type a keyword after the # tag and the display refreshes in the flyout menu via the **Dynamics 365 Quick Find** search engine that's operating in the background.
2. Records displayed can be of any record type, such as accounts, contacts or leads.
3. The icons beside the record names in the flyout menu indicate the record types, which helps you determine which record to select.  
4. **Advanced** provides more options when a record cannot be located by allowing the user to  switch to a different view or create a new record.  

### Look up records in posts in timeline

![Lookup Records pane](media\timeline-add-links-to-records-1c.png "Lookup Records pane")

Legend
1. The **Lookup Records** pane provides users with options to switch between the **Recent records** and **All records** view to find a record.  
2. **Change View** to see records from a different view.  
3. **New Record** allows you to create a new record if you can't find the record you need.

For more information on notes and post functionality and configuration, see:
- [Display options](customer-service-hub-user-guide-timeline-admin.md#display-options)
- [Record Settings](customer-service-hub-user-guide-timeline-admin.md#record-settings)
- [Notes on timeline](customer-service-hub-user-guide-timeline-admin.md#notes-on-timeline)

### See Also

[Configure Timeline](customer-service-hub-user-guide-timeline-admin.md)  
[Timeline FAQs](timeline-faqs.md)  
