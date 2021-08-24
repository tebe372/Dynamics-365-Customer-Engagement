---
title: Enable knowledge article search filters | MicrosoftDocs
description: Learn how to enable knowledge article search filters in Dynamics 365 Customer Service
ms.date: 24/08/2021
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Enable knowledge article search filters

## Introduction

For the knowledge search results, you can configure standard and custom fields as filters to help your agents find the content and improve their productivity.

You can set up the customization of knowledge article search filters by first enabling the feature, and then setting the filter configurations. The fields that are present on the knowledge article entity are the fields that are available as filters. Additionally, filters can be defined on fields that have the following data types:

- Options set
- Multiselect options set
- Lookup
- Two choices
- Date and time


 Any filter configurations that you set will be available wherever the knowledge search experience is configured, such as, the form-based knowledge control, knowledge search page, productivity pane-based knowledge search control, embedded search control in Unified Service Desk, and the application tab search experience in Omnichannel for Customer Service.

If you enable the customization of the knowledge search filters, the web client and maker experience knowledge management filter experience are deactivated.
In full text search, the archived and discarded status filters are not supported.

## Enable search filters for knowledge articles

1. Open the **Customer Service Hub** app and select **Change area** > **Service Management**.
2. In the **Knowledge Base Management** section, select **Settings**.
3. On the **Settings** page, go to **Knowledge articles search filters**, set **Enable search filters** to **Yes**, and then select **Save**.
1. To enable agents to personalize knowledge article search filters in Customer Service Hub, Customer Service workspace, and Omnichannel for Customer Service, set the **Allow agents to personalize the knowledge articles search filters** option to **Yes**.
   
    > [!div class=mx-imgBorder]
    > ![Enable search filters.](media/enable-search-filters.png "Enable search filters.")

5. In the **Knowledge Base Management** section, select **Filters**.
6. On the **Filters** page, select the filters you want to make available for knowledge search. 
7. To set predetermined values that will appear for agents by default, select the ellipsis in the top-right corner of a filter area, and then select **Preselects**.
    > [!div class=mx-imgBorder]
    > ![Select filter preselects.](media/select-filter-preselects.png "Select filter preselects.")
8. To make a filter value available by default, turn on  the **Set as preselected filter** toggle, so that  **Preselected** appears next to the filter name, and then select **Done**.
   Values that are set as preselected automatically participate in the filtering without requiring the agent to manually select them. Only values made visible can be preselected.
    > [!div class=mx-imgBorder]
    > ![Toggle filter to show as Preselected.](media/set-filter-preselects.png "Toggle filter to show as Preselected.")
   

10. If you want to set the filters which must be shown to the agent, select the ellipsis in the top-right corner of a filter area, and then select **Visibility**.
   
11. Select the values you want to show the agent, and then select **Done**.
12.	When you're finished with configuring the values you want, select **Save**.

## Additional configuration settings

* If you want to configure custom fields as filters, you must add the fields to the Quick Find view columns. To add a field to the Quick Find view column, see [Configure searchable fields for Relevance Search](/power-platform/admin/configure-relevance-search-organization#configure-searchable-fields-for-relevance-search).

* If Relevance Search is enabled and if you have selected the **Archived**, **Discarded**, or **Expired** values for the Status filter, you must modify the Quick Find Knowledge Article view to display articles with these values.

 * To view these articles in your Relevance Search results, you must delete the **Archived**, **Discarded**, **Expired**, and **Is Latest Version** filters in the **Quick Find Knowledge Article > Edit Filter Criteria** dialog.

> [!NOTE] These filters will work only if you have Relevance Search enabled.

## Add a default filter configuration
The following steps apply to these data types:
- Options set
- Multiselect options set
- Two choices
- Date and time
1. In the **Customer Service Hub** app, under the **Knowledge Base Management** section, select **Filters**. 
   The **Filters** page is displayed.
2. Scroll to the bottom of the page, choose the filter type you want from the dropdown menu, and then select **Add**. The filter is added to the page.

    > [!div class=mx-imgBorder]
    > ![Add a default filter.](media/default-filter-config.png "Add a default filter.")
    
3. Customize the filter according to your needs by selecting or deselecting the values displayed and then turn on the **Set as a preselected filter** option if you want the filter to be shown to the agent by default.
4. Select **Save**.

## Configure fields with data type as lookup as filters

Some configurable filter values may include lookup types, where there are numerous value options that can be set. Some examples of these filters are Created by, Modified by, and Owner. For these types of values, when you add the filter, you can manually search for and select the records you want to use.

To configure a lookup type filter:
1. In the **Customer Service Hub** app, under the **Knowledge Base Management** section, select **Filters**.
   The Filters page is displayed.
2. Scroll to the bottom of the page, choose the filter type you want from the dropdown menu, and then select **Add**. 
   A **Lookup Records** field is displayed on the right-hand side of the page.
   
   > [!div class=mx-imgBorder]
   > ![Lookup Records field.](media/lookup-records.png "Lookup Records field.")

3. To find the values you want, either enter the value details in the field or select the magnifying glass icon to list available records.
4. Select the records you want in the results, and then select **Add**.
5. If you want to set the values as defaults, turn on the preset next to the filter to the right so that **Preselected** appears next to the filter name.
6. Select **Save**.

## Deactivate or reactivate a filter configuration
There may be times when you want to temporarily suspend a filter configuration but don’t want to lose the configuration settings. You can deactivate a filter configuration and then reactivate it later on.

   > [!NOTE]
   > If you deactivate or delete all of the filters, then agents will see the following message on the personalization page: "No filters have been configured. Contact your administrator."

Keep in mind the following:
- If you delete a knowledge article field for which a filter has been created, your agents won't see the filter and they won't be notified about the change in the UI. You, as the administrator, will see the filter with a message indicating that it has been deleted.

- If you deactivate the filter, it will show as deactivated to you as the administrator, but your agents won't see the filter on the knowledge control. When the filter is activated again, the filter configuration will remain it was previously configured.

- If an agent doesn’t have permission to see a specific field because of field-level security, then a filter created on that field won't be visible to the agent.

- Filters that are available in the default, out-of-box configuration cannot be deleted.

- If an agent sets default values, those values will persist and cannot be overwritten by changes made by an administrator.
   
1. In the **Customer Service Hub** app, under the **Knowledge Base Management** section, select **Filters**. 
   The **Filters** page is displayed.
2. Select the ellipsis in the top-right corner for the filter you want to deactivate, and then select **Deactivate**.
3. Select **Done** > **Save**.
4. When you are ready to reactivate the filter, go to the **Filters** page, select the ellipsis next to the value you want to reactivate, and then select **Activate**. 
   All of the previous configurations will be reinstated.

## Allow agents to personalize their knowledge article search filters

You may have scenarios within your organization where agents are working on different areas and don’t all need the same filter settings. For example, an organization may have agents working on different product areas. One agent might need to see knowledge articles for Product A, while another agent might only want knowledge articles for Product B, and so forth. You can allow your agents to personalize the knowledge article search filters for their areas.

1. Open the **Customer Service Hub** app and select **Change area** > **Service Management**.

2. Under the **Knowledge Base Management** section, select **Settings**.
   > [!NOTE]
   > This option will be available only if **Enable custom filters** is set to **Yes**.

3. Customize the filter according to your needs by selecting or deselecting the values displayed and then turn on the **Set as a preselected filter** toggle if you want the filter shown to the agent by default.
4. Select **Save**.

