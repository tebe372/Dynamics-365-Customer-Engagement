---
title: " Configure mobile offline synchronization in Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: 
ms.date: 04/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement apps Version 9.x
author: mduelae
ms.assetid: 7f992770-8c7b-48ba-806a-63a3634d209c
caps.latest.revision: 7
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---
# Preview Feature: Set-up mobile offline synchronization to allow users to work in offline mode on their mobile device 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Mobile offline allows Dynamics 365 for phones app users to interact with their data on a mobile device, even when they are not connected to the internet. The Dynamics 365 for phones app provides a rich offline experience and helps you stay productive. You can use basic commands such as create, read, update, and delete when you are offline. Once you are back online, your changes are automatically synchronized with your Dynamics 365 for phones app. 

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)] 
> - Mobile offline feature is not available in a trial account.

To allows users to use this feature, a Dynamics 365 administrator will need to set-up mobile offline for their organization. 
  
This offline experience uses [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] services to periodically synchronize entities with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for phones and tablets apps so synchronized records are available when users’ mobile devices are disconnected. To enable mobile offline synchronization, follow the steps below.
 
 
## Step 1: Enable entities for mobile offline synchronization 
 
One of the first things that you need to do is enable entities that will be available to mobile users when they're using the mobile app in offline mode. 
  
•	The following entities are available in offline mode:  
  
- Account  

- Activity Pointer
  
- Appointment  
  
- Attachment 

- Case
  
- Competitor  
  
- Competitor Address  

- Connection

- Connection Role
  
- Contact  

- Currency

- Custom Entity
  
- Email  
  
- Lead    
  
- Opportunity  
  
- Opportunity Product  

- Phone Call

- Position
  
- Product  
  
- Task 

- Team  
  
- User  

  > [!NOTE] 
  > -   You can disable any of these above entities for offline or enable any entity from supported list for offline. Follow the steps below to enable or disable an entity. 

To enable more entities for offline, follow the steps below.
  
  
1.  In the **Dynamics 365 for Customer Engagement apps - custom** app, go to **Settings > Customizations**.  
  
2.  Select **Customize the System**.  
  
3.  Expand **Entities** in the left pane.  
  
4.  Select the entity you want to enable for mobile offline (for example, **Account**).  
  
5.  Under **Outlook & Mobile**, select **Enable for mobile offline**.  
 
6.  Select **Organization data download filter** to filter the data and set the freshness of the data you want to make available offline. You can set up to three criteria when you define a filter. Select the field to filter by, select an operator, then set a value. 
  
The entities that are enabled for mobile offline by default have **Modified On** set for **Last X Days** = 10, so the data modified or created in the last 10 days will be available for downloading to mobile devices.  
  
7.  Select **Save**.  
  
8.  When you’re done enabling entities for mobile offline, select **Publish** so your changes take effect.  

> [!WARNING]
>  Keep in mind that the amount of data you make available to users while they’re offline can affect the data usage rates for devices on cellular networks. The amount of data depends on:  
>   
> -   The number of entities you enable for mobile offline  
> -   The number of days you specify since records were last modified  
> -   The filters you set while creating mobile offline profiles  
 
## Step 2: Create a mobile offline profile to determine what data will be available while offline
 
You need to create mobile offline profiles for users to configure filters that determine how much of an entity's data (and related entities' data) will be available to the user while offline.  

> [!NOTE] 
> -  A user must have a security role that has Read permissions on the mobile offline profile to be able to use their mobile device in offline mode.
  
1.  Go to Power Platform Admin Center by going to **Environments** > [select an environment] > **Settings** > **Mobile configuration**.  
 ![Mobile configuration setting screen](media/MobileConfig.png "Mobile configuration setting screen")
  
2.  Select **Mobile Offline Profiles**.  

 ![Mobile Offline Profile screen](media/mobileofflineprofile.png "Mobile Offline Profile screen")

3.  Select **New** to create a new mobile offline profile. If you already have one that you want to edit, select it from the list.  
  
4.  Enter a name and description for your mobile offline profile.  

 ![Name your Mobile Offline Profile](media/namemobileofflineprofile.png "Name your Mobile Offline Profile")
  
5.  Select **Save** to create the mobile offline profile so you can continue editing it.  
  
6.  In the **Mobile Offline Profile Item Details** area, select **+** to create a new mobile offline profile item. You need to create a mobile offline profile item for each entity you want to make available for this mobile offline profile.  

 ![Enter Mobile Offline Profile Item Details](media/itemdetails.png "[Enter Mobile Offline Profile Item Details")
  
7.  Enter a name and select an entity. Only entities that you enabled (in **Step 1**) for mobile offline appear in this list.  

 ![Enter Mobile Offline Profile Item Name](media/profileitemname.png "Enter Profile Item name")
 

 
   Select a data download filter based on the ownership type for the entity.
  
   **User or Team**  
  
    - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
    - **All records**. Make all records for this entity available offline.  
  
    - **Other data filter**. Make only the specified records for this entity available offline.  
  
     If you select **Other records**, you can choose from the following:  
  
    - **Download my records**. Make only your records available offline.  
  
    - **Download my team’s records**. Make your team’s records available offline.  
  
    - **Download my business unit’s records**. Make your business unit’s records available offline.  
  
 **Organization**  
  
    - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
    - **All records**. Make all records for this entity available offline.  
  
 **Business**  
  
    - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
    - **All records**. Make all records for this entity available offline.  
  
    - **Other records**. Make only the specified records for this entity available offline.  
  
     If you select **Other records**, you can choose from the following:  
  
    - **Download my business unit’s records**. Make your business unit’s records available offline.  
  
 **None**  
  
    - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
    
Admins can define a custom filter based on the following rules. You can create filters up to three levels.  
    

 |  |
 |---------|
 |equal     |
 |not equal     |
 |gt – greater than|  
 |ge – greater than or equal to|  
 |le – less than or equal to|  
 |lt – less than|  
 |like|  
 |not-like|  
 |in|  
 |not-in|  
 |null|  
 |not-null|  
 |eq-userid|  
 |ne-userid|  
 |eq-userteams|  
 |eq-useroruserteams|  
 |eq-useroruserhierarchy|  
 |eq-useroruserhierarchyandteams|  
 |eq-businessid|  
 |ne-businessid|  
 |eq-userlanguage|  
 |begins-with|  
 |not-begin-with|  
 |ends-with|  
 |not-end-with|
  
9. Select **Save** to create the mobile offline profile item so you can continue editing it.  
  
10. In the **Mobile Offline Profile Item Association Details** area, select **+** to create a new mobile offline profile item association. You need to create a mobile offline profile item association for each related record you want to make available offline. In addition, you need to include any related entities in this mobile offline profile.  
  
     For example, if you create a mobile offline profile item association from the Lead entity, you need to add the Lead entity to this mobile offline profile.  
     
      ![Add Lead entity to offline profile](media/addleadentity.png "Add Lead entity to offline profile")
  
11. Enter a name for the mobile offline profile item association, select a relationship, and then select **Save**.  
  
    When you’re done adding mobile offline profile item associations to the mobile offline profile item, select **Save & Close** at the top of the **Mobile Offline Profile Item** screen.  
  
13. When you’re done adding mobile offline profile item details to the mobile offline profile item, select the **Save** button at the bottom right corner of the **Mobile Offline Profile Item** window.  
 
### Step 2.1: Add users to a mobile offline profile 

Once you have created a mobile offline profile, you can start adding users to the profile.  
  
> [!NOTE]
>  You can add a user to only one mobile offline profile.  
  
1.  If it’s not already open, open the mobile offline profile you want to add users to.  
  
2.  In the **Users** area, select **+** to add a new user.  

  ![Add a user](media/adduser.png "add a user")
  
3.  Select the lookup field that appears and select a user to add to this mobile offline profile.  
  
4.  When you’re done adding users, choose the **Save** button in the bottom right corner of the **Mobile Offline Profile** window.  

### Step 2.2: Publish a mobile offline profile

To make a mobile offline profile available to users so they can get the mobile offline experience you've defined for them, you need to publish the profile.  
  
1.  If it’s not already open, open the mobile offline profile you want to publish.  
  
2.  When you’re done adding users and making any other changes to the mobile offline profile, select **Publish** so the data you specified can start syncing with your users’ mobile devices.  

 ![Publish offline profile](media/publishprofile.png "Publish offline profile")
  
> [!TIP]
> **Solution export and import**  
>   
>  When exporting a solution that includes mobile offline profile, always select the **Include entity metadata** check box for each entity you export.  
>   
>  After importing the solution into the target organization, publish all mobile offline profiles.  

### Step 2.3: Set conflict detection for mobile offline  

- To configure conflict resolution behavior, select **Mobile Offline Settings**.

When there is a mismatch of data between client and server, conflict errors occur. To resolve those, you can choose one of the following settings:

- Select **No** - Conflict detection for mobile offline is turned off - so whatever changes are made by a user in offline mode are automatically synced to the server when the user is back online, and client wins over server.

- Select **Yes** - Server wins over client.

 ![Set conflict detection for mobile offline](media/detectconflict.png "Set conflict detection for mobile offline  ")

## Step 3: Enable the App Module for offline

Enable mobile offline for a specific app from MyApps page.

1. In the **Dynamics 365 for Customer Engagement apps- custom** app, go to **Settings** > **My Apps**.

2. From the list of published apps, select an app you want to enable for mobile offline.  

3. On the selected app, choose **More Options** (**...**).

4. Choose **OPEN IN APP DESIGNER**.

5. On the **Properties** tab, scroll down and select **Enable Mobile Offline** and then choose a profile.

   ![Enable mobile offline for the App](media/EnableMobileOffline.png "Enable mobile offline for the App")
   
   > [!NOTE] 
   > -   You can add more than one profile for an app module.

6. At the top choose **Save** and then **Publish**.

## Tips

Here are a few things to keep in mind about mobile offline synchronization:  
  
- Mobile offline synchronization with mobile devices occurs periodically. A synchronization cycle could last for several minutes, depending on Azure network latency, the volume of data that’s set for synchronization, and mobile network speed. Users can still use the mobile apps during synchronization.  
  
- The time for initial metadata download is determined by the number of total entities in offline enabled app modules. Make sure to enable only those entities and app modules for offline that are necessary to optimize experience for end users. 
  
- Ensure that any view that you want to work in offline doesn’t reference the entities that are not offline enabled, for example, assuming Account is in the offline profile then an Account view that references the primary contact when Contact is not in the profile will not be available.

- Changes to a user’s security privileges are updated during the next synchronization cycle. Until that time, users can still continue accessing data according to their previous security privileges, but any changes they make will be validated during the synchronization to the Customer Engagement server. If they no longer have privileges to make changes for a record, they will receive an error and the record won’t be created, updated, or deleted.

- Any changes to a user’s privilege to view a record won’t take effect on the mobile device until the next synchronization cycle.
  
  
## Limitations and recommendations 

### Organization data filter 
It is recommended to have at least one rule defined for all mobile offline enabled entity for org filters, if you are using the entities across profiles.  By default, this value is set to last 10 days for most of the offline enabled entities.

 ![Edit org data filter](media/datafilter_1.png "Edit org data filter")


### Profile Filters 

**Profile Limitations**

|Profile Details |Limitation|  
|-------------|---------|  
|User in profile|	1000|
|Relationship defined for each entity|Maximum of 10 relationships. And Maximum of 3 many to many M:M or one to many 1:M relationship with in those 10 relationships. If any custom entities demand this scenario then revisit the data model. No Circular references or self-references is supported.|


### Profile Filter Rules Recommendation 

Ensure that you have configured at least one of the Profile rules for each entity to download its data. 
  
|Customization |Recommendation|  
|-------------|---------|  
|All Records|	If you are selecting this filter you cannot define any other filter rule.|
|Download Related Data only|If you are selecting this filter you cannot define any other filter rule. Ensure that the entity has been define as a Profile Item Association entity also.|
|Other Data Filter - if selected, then select at least one of these options: **Download my Records**, **Download my team records**, or **Download my business unit**  |	If you want to define this filter you have to pick at least one of the given options. It is highly recommended to not have Business Unit level filter for an entity unless there is a strong justification. It recommended for a master data scenario with small data set like Country codes. |
|Custom Data Filter |<=3 filters can be defined in the custom data filter |


### Data Volume recommendation 

The recommended data volume should be <= 10k records per user subscription.

## Known Issues

**Business Process Flows**: Business Process Flows are not supported for offline. When offline, Business Process Flow grids and views will not be available for use, and BPFs will not be rendered on records opened in mobile offline. If a record containing a BPF was loaded prior to going offline, BPF functions (such as move next/move previous, etc.) will not work, branching conditions will not be evaluated and recommendations on steps will not be displayed 

**Qualify a lead**:

- Users cannot see the qualify button after selecting a lead from the grid. As a workaround they can open the lead record to qualify. 

- Qualify button does show up on the lead form, if any custom status codes are added against the qualify state of the lead. 

- When a lead created in mobile offline is qualified and when the user goes online, the business process stage will still show the  qualify stage. User will have to manually click “Next stage” to move to the next stage.

**Disqualify a lead**: Users will not be able to disqualify a lead in mobile offline. Clicking on disqualify button from lead’s grid or from the lead form gives an error.

**Close opportunity**: Users cannot close an opportunity as won or lost from mobile offline. When users click on “Close as won “or “Close as lost”, the close dialog will open but ok and cancel buttons are disabled. 

**Views** are not supported for the following entities in offline mode: 

- Email

- Task

- Appointment

- Fax

- Phonecall

- Letter

- Serviceappointment

- Campaignresponse

- Campaignactivity

- Recurringappointmentmaster

- Socialactivity

Any views which have linked - entities (related entity) which are not available offline are also not supported. 

## Provide Feedback

We would love to hear from you. If you have any concerns, questions or feedback.

To provide feedback through the Dynamics insider preview portal: 

1. Sign in to the Dynamics insider portal using your organization account.

2. Once signed in, select **Insider programs** and select **Dynamics 365 mobile offline Preview Program**.

Once you are a part of the program, you will easily be able to add feedback and chat with the experts. You will also have access to feature guide which you can access through **Program downloads**.

3. Select **View feedback**, then select **Add feedback to add any comments**. 

The feedback will be continuously monitored by us and we will respond to you as soon as possible.  


   ![Provide feedback](media/feedback.png "Provide feedback")


