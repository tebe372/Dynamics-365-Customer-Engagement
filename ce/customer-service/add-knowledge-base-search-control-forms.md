---
title: Add the Knowledge Base Search control to Dynamics 365 Customer Service forms | Microsoft Docs
description: Know how to add the Knowledge Base Search control to Dynamics 365 Customer Service forms.
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 06/01/2018
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Add the Knowledge Base Search control to forms

Add a **Knowledge Base Search** control to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] forms to make it easy for users in your organization to find knowledge articles so they can answer common customer questions and resolve their issues right from the records, without having to switch to a different application.  
  
 You can configure the Knowledge Base Search control to:  
  
- Show automatic suggestions in search results based on certain fields, or based on text analytics. The text analytics feature in only available for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
- Define filters that users can use on search results.  
  
- Choose from a set of predefined contextual actions the users can take on an article.  
  
- Add the control on any section of any entity that is enabled for knowledge management, including the timeline, and custom entities. The control is enabled in the case entity out of the box, and is added to the following forms:
   - Case main form -  In the **Activity wall** section 
   - Case for interactive experience main form – In the **Related** section 
  
  > [!NOTE]
  >  The Knowledge Base Search control can be used on Microsoft Dynamics 365 for tablets and phones. However, some actions like Pop Out, Email Link, and Email Content aren't supported.  

Microsoft Dynamics 365 Customer Service supports the native knowledge management, and this option is available for the Dynamics 365 Customer Service app users.
  
## Prerequisites  
 Before you add the Knowledge Base Search control, make sure to:  
  
- Set up knowledge management in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md)
  
- Select the entity you want to enable knowledge management on while setting up knowledge management.  

> [!NOTE]
> All customization tasks for the Customer Service Hub must be done in the Common Data Service platform.
  
## Add the Knowledge Base Search control to Main forms  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3. Choose **Customize the System**.  
  
4. In the solution explorer, choose the entity you want to add the search control to, and under **Communication & Collaboration**, make sure the **Knowledge Management** check box is selected.  
  
   ![Setting to enable knowledge management](media/check-knowledge-management.png "Setting to enable knowledge management")

   Select **Save** icon to save the setting for the entity.
  
5. Expand the entity you’re adding the search control to, and select **Forms**.  
  
6. Choose the entity form of type **Main**.  
  
   ![Choose form type](media/choose-form-type-km.png "Choose form type")
  
7. Select the area where you want to place the search control, and on the **Insert** tab, select **Knowledge Base Search**.  
  
    If the option to add Knowledge Base Search is disabled, it could be because knowledge management isn’t set up or isn’t enabled for the entity you’re adding the search control to.  
  
8. In the **Set Properties** dialog box, on the **Display** tab, specify fields as given in the table below:
  
   ![Set properties for Knowledge Base Search control](media/km-search-control-tab.png "Set properties for Knowledge Base Search control") 

9. Select **Set** to apply the settings.   
    
|Tab  |Property  |Description|
|---------|---------|---------|
|**Display**     |    Name     |       **Required**: The unique name for the tab that is used when referencing it in scripts. The name can contain only alphanumeric characters and underscores.   |
|    |  Label        |     **Required**: The localizable label for the tab visible to users.    |
|     |      Filter Search results by   |   In the **Filter search results by** drop-down list, select the set of article states that you want Dynamics 365 Customer Service to search in: <br><ul><li> In the native Dynamics 365 Customer Service knowledge solution, you can choose from all draft articles, all approved articles, or all published articles.</li><li>To let user’s select a different filter on search results so they can see other types of articles, select the **Users can change filters** check box. Only when you enable this option will users see an option to change the filter in the Search pane in a record.</li></ul> While searching for a  knowledge article in the Related section (Reference panel), the following fields of a knowledge article are searched for the keywords that you type: **Title**,**Content**, **Keywords**, **Description**, and **Article Public Number**. For more information, see [Search for knowledge articles](search-knowledge-articles-csh.md). |
|     |  Set Default Language |     If you want users to see search results only for articles in a specific language, in the **Set Default Language** drop-down list, select a language. By default, User’s Default Language is selected: <br><ul><li>If you select User's Default Language, search results will be filtered based on the signed-in user's default language. </li> <li> If the language you select isn't an active language, the search results will be filtered using the signed in user's default language. </li> <li> If you select User's Default Language, and if the user's default language isn't an active language, the first active language available alphabetically is used as the default filter. </li> <li>	To let user’s select a different language filter on search results so they can see other articles in other languages, select the **Users can change Language Filter** check box. Only when you enable this option will users see an option to change the filter in the Search pane in a record. </li> </ul> |
|  |     Additional Options    |      If you want Dynamics 365 Customer Service to suggest articles automatically based on the value in certain fields of the entity, select **Turn on automatic suggestions**. <br> </br>If you’ve enabled automatic suggestion, select the field for the entity that Dynamics 365 Customer Service will use to suggest article results in the **Give knowledge base (KB) suggestions** using drop-down list.  <br> </br>For example, if you’re adding the search control to the Account entity, and want Dynamics 365 Customer Service to automatically show search results that contain the account name, select Account Name in the drop-down list. **Note**:  This drop-down list can include all fields that are text, multi-line text, or lookup type fields. <br> </br>If you are a Dynamics 365 Customer Service user and your organization is using native Dynamics 365 Customer Service knowledge management as the knowledge solution, you can also use text analytics to show suggested articles. To do this, select **Text Analytics** from the **Give knowledge base (KB) suggestions** using drop-down list.  <br> </br>If you want the article rating to appear for each article in the search results, select the **Enable ratings on KB article search results based on the specified field** check box, and then select the field from the drop-down list. |
|   |  Select Primary customer       |     In Select primary customer, select who the email will be sent to when a customer service rep sends the article link in email. This drop-down list includes all fields for the entity that are enabled for email, for example Customer, Contact, or Responsible contact. <br> </br> When the customer service rep chooses to send a link to the article to the customer, the **To** field is automatically populated with the value of the field that you select here.     |
|  |   Number of results      |      Select how many articles to show in the search results at first.    |
|    |  Actions       |   Select whether you want to make all the default actions available to reps or only selected ones. If you choose Show Selected Actions, select the actions you want to show. <br> The following actions are available: <ul> <li>**Link the KB article**. Let’s users link the knowledge article to the record they're viewing the knowledge article search results in. </li> <li>	**Unlink**. Let’s users unlink the knowledge article from the primary record. </li> <li> **Copy link**. Let’s users copy the external URL of the article, so they can share it over channels like chat or email. In the native Dynamics 365 Customer Service knowledge management solution, the Copy Link option is available only for published articles.</li> <li> **Link KB article and email link**. Let’s users associate an article with the primary record and share the article link with the customer through email. |
|**Formatting**     |      Layout   |    Choose the type of layout to determine the number of columns the control should occupy.     |
|    |    Row Layout  |  Select the maximum number of rows per page.|


## Configure automatic filtering

Improve knowledge article suggestions and search results by enabling automatic filtering. Automatic filtering ensures your customer service agents receive only the most relevant knowledge articles. As an administrator, you can configure Knowledge Base Search control to automatically filter knowledge articles based on case data without any manual input from the agents.

For example, if you set up automatic filtering of knowledge articles on the subject of the case, the knowledge articles that have the same subject as the case will be filtered in and will be shown to the agents. Other articles will be filtered out automatically. 

This feature can be extended to automatically filter knowledge articles on any lookup field that is present on both Case and Knowledge Article entity. Agents also have an option to turn off automatic filtering and search the entire knowledge base. Administrators can configure this option in the Knowledge Base Search control.

Open the **Knowledge Base Search** control and edit its properties to configure automatic filtering. In the **Set Properties** dialog box, on the **Display** tab, specify the following fields in the **Configure Automatic Filtering** section.

1. Select **Enable Automatic Filtering** check box to enable automatic filtering.
2. Select **Users can turn off automatic filtering** check box if you want to provide your agents the option to turn off automatic filtering and search the entire knowledge base. This enables **Auto filter results** option for agents on knowledge search control.
3. Select **Add Filter** to define filtering of knowledge articles on case subject or any other lookup field.
4. Select **Set** to save the properties.

    > [!NOTE]
    > Ensure that Relevance search is enabled for automatic filtering to work. The Knowledge Article attribute must be added to the Knowledge Article Quick Find View. Ensure Source Entity Attribute is present on the form.

   ![Configure auto filtering](media/ka-config-auto-filtering.png "Configure auto filtering")

To learn more about how to use the automatic filtering option, see [View filtered articles in the Related section](search-knowledge-articles-csh.md#view-auto-filtered-results)

### See also  

[Reduce call handling times with Knowledge articles in the Customer Service Hub](customer-service-hub-user-guide-knowledge-article.md)

[Set up knowledge management using embedded knowledge search](set-up-knowledge-management-embedded-knowledge-search.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)
