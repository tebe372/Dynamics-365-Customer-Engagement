---
title: "Preview feature: Relationship assistant for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: cf444ca7-3ec1-4939-8710-655190701484
caps.latest.revision: 22
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Preview feature: Use relationship assistant to guide customer communications

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

The relationship assistant is part of the new *Relationship Insights* suite of features. The assistant keeps an eye on your daily actions and communications, and generates a collection of *action cards* that are displayed prominently throughout the application to provide tailored, actionable insights. The assistant reminds you of upcoming activities; it evaluates your communications and suggests when it might be time to reach out to a contact that’s been inactive for a while; it identifies email messages that may be waiting for a reply from you; it alerts you when an opportunity is nearing its close date; and much more.  
  
[Watch a short video (2:25) about the Dynamics 365 Relationship Assistant](https://go.microsoft.com/fwlink/p/?linkid=839677).  

The relationship assistant is provided as a preview feature in the [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] and is only available in North American sites that use US English (en-us). Some basic features of the relationship assistant are also available in the [!INCLUDE[pn_crm_8_2_0_op](../includes/pn-crm-8-2-0-op.md)]. Additional restrictions apply, depending on which versions of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] you are running.  For complete details about how to enable this preview feature, plus version requirements, prerequisites, and any known issues, see [Preview feature: Configure Relationship Insights features](../admin/configure-relationship-insights-features.md).  
  
A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.  
  
> [!IMPORTANT]
>  Microsoft doesn't provide support for this preview feature. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] technical support won’t be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use for preview features](http://go.microsoft.com/fwlink/p/?LinkId=511446).  
  
The relationship assistant is part of the new *Relationship Insights* suite of features, all of which are currently in preview. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Preview feature: Relationship Insights overview](../admin/relationship-insights-overview.md)  
  
<a name="GettingStarted"></a>   

## Getting started  
 The administrator must enable the relationship assistant before you can try it out. For complete details about prerequisites, how to enable the feature, and how to set it up, see [Configure Relationship Insights features](../admin/configure-relationship-insights-features.md).  
  
 Before using relationship assistant, you must first activate it. Browse to a dashboard that supports relationship assistance such as the Sales Activity Social dashboard and click **Let's Go!**  
  
 ![Click Relationship assistant Let's Go&#33; to activate relationship assistant](../admin/media/relationship-assistant-lets-go.png "Click Relationship assistant Let's Go! to activate relationship assistant")  
  
 Wait for relationship assistant to collect your action cards.  
  
 ![Wait for relationship assistant to collect your action cards](../admin/media/relationship-assistant-awesome.png "Wait for relationship assistant to collect your action cards")  
  
 Cards will appear when activation is complete.  
  
  ![](media/ActionCard_PhoneCallDueToday.png "Action card for phone call due today")  
  
<a name="HowAndWhere"></a>   

## How and where the relationship assistant can help you  
 The relationship assistant is designed to deliver the most important and relevant information in relation to what you are doing *right now*. The assistant works by analyzing all of the data at its disposal and generating a collection of action cards, each of which includes a message summarizing what the card is about, plus a set of links for taking action. The assistant sorts the cards by priority and filters them for your current context.  
  
 When you start your day by signing in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], the assistant draws your attention to your most important items and tasks, drawn from all areas of the application.  
  
 ![Relationship assistant carousel on a dashboard](../admin/media/relationship-assistant-carousel-on-dashboard.png "Relationship assistant carousel on a dashboard")  
  
 The figure shows a typical dashboard that includes the relationship assistant carousel. It highlights the following elements:  
  
1. **Action card carousel**: The relationship assistant shows pending action cards here. The most important card is shown on the left, and additional cards may be visible depending on your screen resolution and which view you are using. As you work, dismissing and snoozing cards, additional cards slide in from the right. The figure shows a top-level dashboard, so these cards are drawn from all areas of the site; carousels are also available on individual record views, where the cards are filtered for your specific context.  
  
2. **Action card**: This is a single action card.  
  
3. **Assistant column button**: Click here to view all available action cards in a vertical, scrollable column. The carousel is hidden when you choose this view.  
  
4. **Feedback and customization buttons**: These are shown in the upper-right corner of both the carousel and the column views. Use the button on the left to provide feedback about the assistant to Microsoft. Use the button on the right to open your relationship assistant preferences, where you can choose which types of cards you want to see and set options for some of them.  
  
As you drill down into specific records, such as an opportunity or contact, the assistant displays only those cards that are related to the record you are working with. As on the front-page dashboard, the assistant typically opens by showing a carousel, and includes an **Assistant** tab in the center column, which you can open to scroll through all the available cards for the current record.  
  
![Action card example](../admin/media/action-card-example.png "Action card example")  
  
Action cards are made up of the following elements, as labeled in the figure:  
  
1. **Main content area**: Shows the title of the record the card refers to, its summary, the card type, and other basic information. Click anywhere in this area (except for on the two buttons) to open the related item, which might be a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record or an email message .  
  
2. **Actions area**: Provides convenient links that will help you complete whatever type of action the card is recommending. The number (up to two) and types of links provided here vary by card type. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action cards reference](../admin/action-cards-reference.md)  
  
3. **Snooze button**: Click here to hide the card temporarily. Snooze time varies by card type. Once the snooze time expires the card will again be visible.  
  
4. **Dismiss button**: Click here to dismiss the card permanently, regardless of whether you have completed the action it recommends.  
  
<a name="Configure"></a>   
## Enable and configure the action cards that are most helpful for you  
 You can customize the relationship assistant by choosing which types of action cards you'd like to see and, for some types of cards, by setting configuration options. To configure the relationship assistant:  
  
1.  Open the relationship assistant settings by doing *one* of the following:  
  
    -   Go to any page in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] where you can see action cards, and then click the **Customize** button ![Customize cards button in the relationship assistant](../admin/media/customize-cards-shown-relationship-assistant.png "Customize cards button in the relationship assistant") in the upper-right corner of the card container.  
  
    -   Click the **Settings** button ![Settings button on the nav bar](../admin/media/settings--button-the-nav-bar.png "Settings button on the nav bar") on the nav bar, and then choose **Options** from the drop-down list. The **Set Personal Options** dialog opens, with its **General** tab active. Scroll to the bottom of the **General** tab, and then click on **Manage personal relationship assistant settings** link.  
  
2.  The **Relationship Assistant** settings pop-up window opens, showing a list of all the types of action cards that your administrator has made available on your site.  
  
 ![Relationship assistant settings window](../admin/media/relationship-assistant-settings-window.png "Relationship assistant settings window")  
  
     Work with these settings as follows:  
  
    -   The cards are organized by category, each with its own section on the page. Expand or collapse each section to show or hide the list of card types for each category.  
  
    -   Select the check box for each type of action card that you'd like to see. Clear the check box for card types that you don't want to see.  
  
    -   Some types of cards include additional settings, which are shown in to the right of the check box when available.  
  
    -   If you are not sure what a listed card or its options do, then try hovering your mouse cursor over the preview button ![Action card preview button](../admin/media/action-card-preview-icon.png "Action card preview button") next to the card name see a short description of the card.  
  
     For a complete description of all card types, including configuration settings where available, see [Action cards reference](../admin/action-cards-reference.md)  
  
3.  Click **Save** to save your settings and close the window.  
  
<a name="BKMK_Privacy"></a>   
## Privacy notice  
[!INCLUDE[cc_privacy_relationship_insights_relationship_assistant](../includes/cc-privacy-relationship-insights-relationship-assistant.md)]
  
### See also  
