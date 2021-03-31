---
title: "Document management in Microsoft Teams integration| MicrosoftDocs"
ms.custom: 
description: "How file and document works with Microsoft Teams integration and SharePoint "
ms.date: 02/18/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Document management in Microsoft Teams integration

Document management with SharePoint lets you manage common document types, such as Word, Excel, PowerPoint, and OneNote. You can also create folders to save and manage those documents in customer engagement apps (such as Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation), that are stored in SharePoint.

With Microsoft Teams integration with Dynamics 365, you can use document management with Microsoft Teams. It allows a user to co-author documents and automatically sync documents to customer engagement apps using SharePoint. For each tenant, there is a single SharePoint instance. Documents in Dynamics 365 and files in Teams are all on the same SharePoint site. The subsites may be different but the root site is the same.

There isn't an automatic relationship between SharePoint permissions and permissions to customer engagement apps. To access documents between Microsoft Teams and customer engagement apps, you need explicit permission to use document management for customer engagement apps and SharePoint. For information: [Permissions required for document management tasks](../customerengagement/on-premises/admin/permissions-required-document-management-tasks.md)

Use the **Files** tab in Teams or the **Documents** tab in your customer engagement apps, to store and manage documents in the context of a record on a SharePoint Server. Documents are stored on a SharePoint Server that allows a user on Microsoft Teams to access the documents on the SharePoint Server &ndash; as long as the user has appropriate permissions.

A user's access to files in Microsoft Teams or customer engagement apps depends on their access to the SharePoint site the file is stored in.

> [!NOTE]
> - A guest user in Microsoft Teams will get error message when they try to access a pinned customer engagemnt app record. 
> - A user who is part of Microsoft Teams channel or team that does have access to customer engagementapps won't have access to the record in Microsoft Teams.
> 

## FAQs 


#### 1. Will guest users in Teams have access to Dynamics 365 app records? 
No, they will see an error message when they try to access a pinned record.

#### 2. Will participants of Microsoft Teams chats and channels be able to see the pinned Dynamics 365 app record if they don't have a Dynamics 365 license?
No, they will see an error message when trying to access a pinned record.

#### 3. Can I add a document to my record if it isn't pinned to a Microsoft Teams channel?
It depends on whether your Dynamics 365 tenant has SharePoint integration set up. If you have SharePoint integration enabled, then you can add a document.

If you do not have SharePoint integration enabled, you need to have pinned the record to a Microsoft Teams channel, otherwise you will not be able to add a document to the record.

#### 4. What happens when I add documents to a Teams channel connected to a Dynamics 365 app record and then remove a member from the channel?
It depends if the user has permissions to access the Dynamics 365 app record.

If they has permissions to access the app record, then the user can edit the record in Dynamics 365, but can't acces the files from Dynamics 365, SharePoint, or Microsoft Teams.

If they don't have permission to access the Dynamics 365 app record, then the user will get an error and they won't have access to the file from Dynamics 365 , SharePoint, or Microsoft Teams

#### 5. What permissions does a user get when I add them to a Teams channel that has pinned records and documents added to the files tab?
It depends if the user has permissions to access the Dynamics 365 app record.

If they have permission to access the Dynamics 365 app record, then the user will able to edit the record in Dynamics 365 and Microsoft Teams. They will also have read, write. delete files from Dynamics 365, SharePoint, and Microsoft Teams.

If they don't have permission to access to your Dynamics 365 app record, then they will get an error, but they'll have read, write, delete permission when they access the file from Dynamics 365, SharePoint, and Microsoft Teams.

#### 6. What is the SharePoint location of the Microsoft Teams files tab versus the associated Dynamics 365 record's documents tab? &lt;THE BELOW APPLIES WHEN SHAREPOINT INTEGRATION IS NOT ALREADY ESTABLISHED ON DYNAMICS ENTITY&gt;

When adding a file via a Dynamics record that is linked to a Teams channel, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in both the Teams channel's Files tab and the Dynamics record's Document Associated Grid/

Adding a file via a Dynamics record that is not linked to a Teams channel is not possible, since SharePoint integration has not yet been set up.

When adding a file via a Teams channel that is linked to a Dynamics record, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in both the Teams channel's Files tab and the Dynamics record's Document Associated Grid.

When adding a file via a Teams channel that is not linked to a Dynamics record, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in the Teams channel's Files tab.

When a Teams channel has multiple Dynamics records associated with it, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in the Teams channel's Files tab and the Document Associated Grid for all Dynamics records associated with the channel.

When a Dynamics record is linked to a Teams channel, files already added to that Teams channel show up in the Document Associated Grid for that Dynamics record.

If a Dynamics record has been previously associated with a Teams channel, and a user decides to associate it with a new Teams channel, another Document Location is added in Dynamics for the new Teams channel associated with the record. Users can switch back and for the between the document locations.

#### 7. What is the SharePoint location of the Teams files tab vs the associated Dynamics record's documents tab? &lt;THE BELOW APPLIES WHEN SHAREPOINT INTEGRATION IS ALREADY ESTABLISHED ON DYNAMICS ENTITY&gt;

When adding a file to a Dynamics record that is linked to a Teams channel via the Document Location for the Teams channel, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in both the Teams channel's Files tab and the Dynamics record's Document Associated Grid in the Document Location for the Teams channel.

When adding a file to a Dynamics record that is linked to a Teams channel via the Document Location for the Default Site, the document is stored in the default Sharepoint site that was set up with the Dynamics environment. The document does not show up in the Teams Files tab for the channel associated with the record.

When adding a file via a Dynamics record that is not linked to a Teams channel the document is stored in the default Sharepoint site that was set up with the Dynamics environment.

When adding a file via a Teams channel that is linked to a Dynamics record, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in both the Teams channel's Files tab and the Dynamics record's Document Associated Grid in the Document Location for the Teams channel.

When adding a file via a Teams channel that is not linked to a Dynamics record, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in the Teams channel's Files tab.

When a Teams channel has multiple Dynamics records associated with it, the document is stored in a Sharepoint folder with the file path \[Team Name\] &gt; Documents &gt; \[Channel Name\] &gt; \[FileName\]. The file is visible in the Teams channel's Files tab and the Document Associated Grid in the Document Location for the Teams channel for all Dynamics records associated with the channel.

When a Dynamics record is linked to a Teams channel, files already added to that Teams channel show up in the Document Associated Grid for that Dynamics record in the Document Location for the Teams channel.

When a Dynamics record is linked to a Teams channel, files already added to that Dynamics record (on the default Sharepoint site that was set up with the Dynamics environment), the files are not visible in the Teams channel's Files tab and they remain on the default Sharepoint site that was set up with the Dynamics environment.

If a Dynamics record has been previously associated with a Teams channel, and a user decides to associate it with a new Teams channel, another Document Location is added in Dynamics for the new Teams channel associated with the record. Users can switch back and for the between the document locations.

#### 8. Who can see which location?
Permission to see the location depends on the user permission to the folder in Sharepoint. If the Sharepoint folder was created in a Teams channel, then the user will have read/write permission.

#### 9. I have removed a user from the Teams channel, but they still have access to the associated record via Dynamics. How can I restrict their ability to open/edit/delete the document from Dynamics?
Access to the files depends on a user's permissions in SharePoint. To restrict a user from accessing these files, remove them from the SharePoint site.

#### 10. What happens when I delete the Teams team/account?
The files are removed from Dynamics 365 and SharePoint.


