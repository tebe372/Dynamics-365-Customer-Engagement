---
title: Learn the basics of the Customer Service Hub in Dynamics 365 | Microsoft Docs
description: Learn the basics of the Customer Service Hub for Customer Service in Microsoft Dynamics 365
keywords: Basics of the Customer Service Hub; Customer Service;  Microsoft Dynamics 365
author: anjgupta
applies_to: Dynamics 365 (online) 
ms.author: anjgup
manager: sakudes
ms.date: 09/30/2017
ms.topic: article
ms.service: crm-online
ms.assetid: f7241c02-a8ea-4b67-9d7b-428f91071090
---

# Learn the basics of the Customer Service Hub

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

<a name="bkmk_Basics"></a> 
  
 The Customer Service Hub’s intuitive interface unifies vital information in one place, and lets you focus on things that require your attention.  

  
<a name="bkmk_support"></a>   

## Customer Service Hub application requirements  
 Here’s a list of operating systems and browsers that are supported by the Customer Service Hub:  
  
- **Operating systems**  
    - Windows 10 (for Knowledge management on Unified Interface)
  
- **Browsers** 
    - Google Chrome
    - Internet Explorer 11
    - Microsoft Edge (supported on Windows 10) 

- **Mobile**
    - iOS 10 - Tablet & Phone
    - Android - Tablet + Phone (Android 6 and 7)
    - Windows 10 - Tablet Only

<a name="bkmk_Access"></a>

## Open the Customer Service Hub
The Customer Service Hub app is available to use on both, a desktop browser and a mobile device.  Here are some ways you can open the Customer Service Hub:  

> [!NOTE]
>  This option is available only to users with the Customer Service app access role , System Administrator, or System Customizer role. 

**Desktop browser**
  
-   In the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application, go to **Settings** > **Application** > **My Apps** >  **Customer Service Hub**.   

     ![open-csh](media/open-csh.png)
 
  
-    In the Dynamics 365 sitemap, navigate through the app switcher and click **Customer Service Hub**.

     ![open-csh-sitemap](media/open-csh-sitemap.png)
  
**Mobile device**

On a mobile device, to access the Customer Service Hub app:

- Install the Dynamics 365 mobile app. 
  
  To know how to install the Dynamics 365 mobile app, see [Install Dynamics 365 for phones and tablets](../mobile-app/install-dynamics-365-for-phones-and-tablets.md)
- From the MyApps page, choose Customer Service Hub.

   ![choose-on-mobile](media/ChooseAnApp_1.png)

  
<a name="bkmk_supportedEntities"></a>   

## Manage different record types  
 In the Customer Service Hub, work with record types that help you easily manage your customer service:  
  
-  Dashboards  
-  Activities: Email (read-only), Task, Appointment, Phone Call, Social Activity  
-  Accounts  
-  Contacts 
-  Social Profiles 
-  Cases 
-  Queues  
-  Knowledge Articles

The Customer Service Hub comes with a new and enhanced sitemap to enable easy navigation of the interface. To know more about the new sitemap, see [Understand the sitemap navigation](#understand-the-sitemap-navigation).
  
Any record types that are enabled for mobile are also available for use in the Customer Service Hub. However, these records are read-only.  
  
> [!NOTE]
> -   The navigation bar for the Customer Service Hub is different from the navigation bar in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application.   

  
<a name="bkmk_understandsitemapnavigation"></a>   

## Understand the sitemap navigation
  
1.  On the sitemap, click **Service**, and then click an entity.  
  
    ![navigate recods](media/v9-navigate-records.png)
  
    When you click an entity, you’ll see the list of records in the respective entity grid. You can also click the down-arrow given next to each entity to view the recently opened records.

    Here is what each entity encapsulates:

    - **Dashboards** collect all your most important data in one place. You can select from multiple dashboards as per your role.
    - **Activities** help you keep track of tasks, Email messages, appointments, phone calls and much more
    - **Accounts** are the companies you do business with
    - **Contacts** helps you manage and store information about the customer you work with
    - **Social Profiles** let you track a contact's presence in social media
    - **Cases** help you create and track your customer requests and issues
    - **Queues** keep a track of cases waiting for you to work on
    - **Knowledge Articles** are your customer’s questions, issues, feedback, and resolutions, so that other service reps can benefit from them

2. Click **Training** to go to **Help Center** and **Learning Path Content Library**. 
3. Click **Favorites and Recent** button ![recent-button](media/fav-and-recent.png)  to see recently viewed records, or to see views that are pinned as favorites.

For a mobile device, the sitemap is displayed as below:

![mobile-sitemap](media/mobile-sitemap.png)
  
<a name="bkmk_SwitchToDashboard"></a>   

## Switch to the record type dashboard from the list of records  
 When you’re in the list of records of a specific record type, use the option **Open Dashboards** in the command bar to switch to the default dashboard for that entity.  

To return back, click **Open Views** from the command bar.
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use interactive dashboards to effectively manage service cases](customer-service-hub-user-guide-dashboard.md#bkmk_UseDashboards)
  
<a name="bkmk_NextPreviousRecords"></a>  
 
## Navigate through records and pages  
  
-   When you’re in a record, click and expand **Open Record Set** to navigate to other records. A side panel opens where you can view other records. You can directly click on the records from the panel and view the details of the  record.
 
      ![record-set](media/v9-record-set.png)

> [!NOTE]
> The option Open Record Set will not be available on devices with comparatively smaller screen sizes.
  
-   To go the previous page in the Customer Service Hub, click the browser’s **Back** button. 
   
  
<a name="bkmk_CreateOrFindRecords"></a>
   
## Quickly create new records
  
- To create records quickly by filling in only the most basic information, click the **New** button ![Create button](../customer-service/media/quick-create-button.png "Create button") given on the nav bar.

  > [!TIP]
  > On a mobile device, from the nav bar, tap ![ellipsis](media/ellipsis.png) and choose **Quick Create Menu**.

  
<a name="bkmk_EmailLink"></a>   

## Email a link  
You can Email links to records so your colleagues can quickly find these records by clicking the links. To Email links to records, select one or more records in the list, and then on the command bar, click **Email a link**. The default Email client opens with the links to these records. The recipients will see all content in the records for which they have permission.  

  
<a name="bkmk_NewForms"></a>   

## Know your forms  
 See how the different components of the form help you quickly handle all your important tasks and actions from a single place.  
  
### **Business processes**  
 In the Customer Service Hub, the case and knowledge article forms have a process bar called Business Process flow, that appears when you save the record for the first time. 
 
When you click a process stage, you'll see relevant steps for that stage. A flag on a stage indicates the stage you’re currently on. When you click an active stage, you can see the **Next Stage** button move to the next stage in the process.  

The stages in the business process flow can  be displayed in floating mode, along with docked mode. Stages can  be aligned in a vertical layout, instead of horizontal, which makes it easier to see what steps are required to be completed before moving forward. You can also choose to include an optional step in the business process flow and define criteria to trigger it.

![business-process-flow](media/business-process-flow.png)
  
If there is more than one process to use, you can switch between the processes by clicking **Process** > **Switch Process** on the command bar, and then selecting the process you want to use.  You can choose to abandon the process.
  
 When a business process flow that’s based on multiple entities is applied to a case or a knowledge article, the experience will be as follows:  
  
-   The business process flow that's based on  multiple entities won't be displayed on the form.  
  
-   The **Switch Process** option will only show the business process flows that are based on a single entity.  
  
-   If there are only multi-entity business process flows for an entity, the **Switch Process** option won't be available.  
  
<a name="bkmk_Tabs"></a>

### **Tabs**  
 A tab is a group of sections on a page. Each Main form is composed of one or more tabs. By default, the **Summary** tab shows information about the customer, interactions with the customer, and other related records. You can click the different tabs to enter or see other miscellaneous details of a record.  
  
For example, here’s a view of how the tabs appear on the case form:
  
![case-form-tabs](media/v9-case-form-tabs.png)
  
 This table lists the default tabs for each record type and the information that they show for a particular record.  
  
|Record type|Default tabs|  
|-----------------|------------------|  
|Case|-   Summary. Includes the customer card, Timeline, and the Related section.<br />-   Details. Tracks Case details, additional details, and social response details of the case. <br />-   Case Relationships. Shows a Merged Cases and Child Cases list. You can add a new child case to the current case from the Child Cases list. It also shows a list of knowledge articles associated with the case.<br />-   SLA. Shows the related SLA KPI Instance records that are created for each SLA KPI that is tracked for the case. <br /> - Related. Shows related entities like Knowledge Base records and Connections.|
|Account|-   Summary. Includes the customer card, Timeline, and the Related section.<br />-   Details. Tracks additional details like company profile, marketing details, contact preferences, and billing and shipping.<br /> - Related. Shows related common entities.| 
|Contact|-   Summary. Includes the customer card, Timeline, and the Related section.<br />-   Details. Tracks additional details like personal information, marketing details, contact preferences, and billing and shipping. <br /> - Related. Shows related common entities.| 
|Activities|Activity forms shows a tab called Task for the respective activity and a Related tab for common entities. |  
|Knowledge Articles|-   Content. Lets you write and edit the content for the article.<br />-   Summary. Tracks basic settings, Timeline, publishing settings, and related information.<br />-   Analytics. Shows the number of views, feedback, and a list of cases using the article.<br /> - Related. Shows related common entities.|  
|Social Profiles|- Social Profile. Captures general information, and social profile details along with related social profiles.<br /> - Related. Shows related common entities.|  
  
<a name="bkmk_ContactCard"></a> 

### **Contact card**  
 See a complete view of your customer’s touch points in the Contact card. This card is available in the **General Information** section of the **Summary** tab.  
  
![contact-card](media/contact-card.png)

 You can add a picture to the account or contact record in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application, and it will appear on this card. You can make calls to customers from the Contact card using Skype for Business – IP telephony.
  
 For account records, the card shows contact details for the primary contact. For contact records, the card appears if the contact is the customer value on the case form.  
  
<a name="bkmk_Timeline"></a>  

### **Timeline**  
 See a combined view of your customer’s interactions across various channels,such as phone, Email, or even social activities in the Timeline. It also shows any related notes or system posts.  

The Customer Service Hub comes with an enhanced and updated Timeline that lets you view all user interaction, arranged in a single stream. You can create, update, and manage notes, posts and other interactions from the Timeline itself. 

With the help of extensive text and visual filters, you can filter various activity types in the Timeline. You can also keep a check of what you have missed from the previous day or week, using the **What’s new** section. This section gives you a view of new notes, unread Emails, and new activities created while you have been away.

Collaboration with other users with the help of Activity feed becomes a lot easier with the new Timeline.

  
The Timeline is available on the **Summary** tab of account, contact, case records, and knowledge articles.
  
 ![Timeline shows customer activities across channels](../customer-service/media/v9-case-form-timeline.png "Timeline shows customer activities across channels")  
  
 Here are a few things you can do in the Timeline: 
 
  
-   Enter a note by clicking the **Enter a note** box. You can also add attachments to your notes.
- Quickly create a new interaction with the customer by clicking **+** in the Timeline. 
- Filter the timeline for a specific activity type or by date. 
  
     You can filter on the basis of Activity status or record type. Click  the ellipsis and then click  Open filter pane to explore the filters

     ![timeline-ellipsis](media/timeline-ellipsis.png)
  
-   Refresh the timeline so you can see the updated list of activities.  
  
-   Click the title of an activity to open the activity record.  
  
-   Take quick actions on an activity from the timeline, such as marking an activity complete, assigning it to others, adding it to a queue, converting it to a case, or deleting it.   
- Sort the entries on the basis of latest or oldest entry.
  
<a name="bkmk_RelatedPane"></a>   

### **Related section**  
 In the **Related** section, use the vertical tabs to see related records for the current record or search for knowledge articles. This section is enabled by default for account, contact, case, and knowledge article records. Your customizer can add this section for custom entities that are enabled for the interactive experience.  
  
 By default, the first part in the Related section of a case record shows the recent cases and entitlements for the current case record you’re working on. When you open a record from the list, it appears in a horizontal tab in the **Related** section.  

![case-related](media/v9-case-form-related-records.png)
  
> [!NOTE]
>  For account and contact records, the **Related** section shows recent opportunities, recent cases, and active entitlements. Your system administrator or customizer can choose what related data to show in this section for each form.  
  
 The second part in the **Related** section is the **Knowledge Base search**. Knowledge Base search lets you search for the knowledge article related to a specific record. It also lets you view automatic suggestions. You can filter the search results on the basis of articles that are Published, Draft or Approved.

When you open a record from the list, it appears in a horizontal tab in the **Related** section.  
  
![case-form-search](media/v9-case-form-search-kb-records.png)
 

<a name="bkmk_activities"></a>   

## Understand Activities

Activities are the tasks that you or your team perform, while contacting customers. An activity is any action which can be entered on a calendar and has time dimensions (start time, stop time, due date, and duration) that help determine when the action occurred or is to occur.

For example, you can make a record of a phone call that you have with a customer, or list an appointment that you need to attend to, with a customer to discuss a certain issue. You can create activities for yourself can assign them to someone else, or can share them with other reps.

In Dynamics 365, the following activities are supported:
- Email (read-only)
- Task
- Appointment
- Phone Call
- Social Activity

> [!NOTE]
> Email is read-only in the Customer Service Hub

#### Open Activities view
In the Customer Service Hub sitemap, click **Service** > **Activities**. The **My Activities** view is displayed. 

![activities](media/activities-csh.png)

- Click the **My Activities** drop-down to switch between various activity views.

- Click the  **Due** drop-down to see the list of activities that are due in coming time or are already overdue.
- Explore the various command bar options, to create a new activity, show chart, or directly open activity dashboard. 
- Click ![quick-create-activity](media/quick-create-button.png) in the nav bar and go to **Activities** to quickly create a new activity.

<a name="bkmk_queues"></a>   

## Manage Queues

Use queues to organize, prioritize, and monitor the progress of your work. In Microsoft Dynamics 365, queues are containers used to store anything that needs to be completed or requires an action, for example completing a task or closing a case.

**Open Queues view**

In the Customer Service Hub sitemap, click **Service** > **Queues**. The queues view is displayed.

![queues-view](media/queues-view.png)

- Use the drop-down lists to switch between various queues view and various queues.
- Select a record in the queues view to:
    - **Edit** the record
    - **Route** the record
    - **Pick** the record. It will be assigned to you and will be moved to your queue.
    - **Release** the record. It will be assigned back to the queue owner for other's to pick up.

To know how to add a case to a queues, see [Add a case to a queue](customer-service-hub-user-guide-case-sla.md#add-a-case-to-a-queue).


### See also

[Track your cases efficiently and act on them quickly](customer-service-hub-user-guide-case-sla.md)