---
title: "Track playbook activities (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Carry out the playbook activities to ensure every event or scenario is dealt with consistently."
keywords: "playbook, activities, track, progress"
ms.date: 02/21/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1"
ms.assetid: 7727c370-1c75-40e9-9319-250994f61bec
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

# Track playbook activities

When a playbook is launched, its related activities are created and associated with the record the playbook is launched from (also called the calling record). You must complete these activities to ensure every event is dealt with consistently.

If the playbook template used for the playbook has its **Track progress** field set to **Yes**, the activities are created under a playbook record that is under the calling record. If the **Track progress** field is set to **No**, the activities are created directly under the calling record.


To see the activities created by the playbook when the **Track progress** field in the playbook template is set to **Yes**:

1.  Go to the record you launched the playbook from. For example, if you launched the playbook from an opportunity record, go to the opportunity record.

2.  Select the **Related** tab, and then select **Playbooks**.

     ![playbooks option in related tab on opportunity record](media/playbooks-option-related-tab-opportunity-record.png "Playbooks option in Related tab on opportunity record")  

3.  In **Playbook Associated View**, the playbook launched from the record is listed.

    ![playbooks tab on opportunity record](media/playbooks-tab-opportunity-record.png "Playbooks tab on opportunity record")  

4.  Select the playbook.

    The playbook record shows all the details about the playbook and its associated activities.

    ![playbook record with associated playbook activities](media/playbook-record-with-associated-activities.png "Playbook record with associated playbook activities")  

    For example, it shows when the playbook was launched, how many total activities it has, how many of the activities are completed, and the estimated close date. It also shows all the related playbook activities in the **Playbook activities** section. After you are done working on these activities, mark them as completed.

    To see the activities if the **Track progress** field of the playbook template is set to **No**, in the calling record, see the **Timeline** section.

    Alternately, in the calling record, select the **Related** tab, and then select **Activities**.

    ![activities tab on the opportunity record](media/activities-tab-opportunity-record.png "Activities tab on the Opportunity record")  
 <!--Editing comment:  The info in paragraph below is unclear to me. Suggested changes: 1st sentence: Delete "when" and replace with "since"? "The Open Activity Associated View lists all the activities for the calling record along with the activities created since the playbook was launched."
Change 2nd sentence, if this is accurate, to: "However, this view doesn't show the total number of activities that have been created in the context of a playbook.-->  
 
   This view shows all the activities for the calling record along with the activities created when a playbook was launched. However, it doesn’t show how many are created in the context of a playbook.


## Preview: View or download documents associated with an activity

[This section is a prerelease documentation and is subject to change.]

> [!NOTE]

> - [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)] 

If a sales manager has added sales brochures or training docs to a playbook activity, as a sales rep you can refer to these docs while you are working on the activity to ensure you can quickly access any details you need.

> [!NOTE]

> Documents are available only for task and appointment activities associated with a playbook activity. 

To view or download a document, in the activity form, select the **Related** tab, and then select **Documents**.

To download a document: 
* In the **Documents** list, select a row and select **Download**.

To view a document:
* in the **Documents** list, select the document name.


### See also
[Launch a playbook to carry out activities consistently](launch-playbook.md)  
[Enforce best practices with playbooks](enforce-best-practices-playbooks.md)  
[Mark playbook as completed](mark-playbook-completed.md)
