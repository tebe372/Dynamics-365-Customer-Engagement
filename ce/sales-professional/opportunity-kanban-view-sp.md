---
title: "Work with opportunities in the Kanban view (Dynamics 365 Sales Professional) | MicrosoftDocs"
description: "Use the opportunity Kanban view to effectively monitor the pipeline and see the opportunities in their different statuses or stages of business process flow."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Work with opportunities in the Kanban view (Sales Professional)

[!INCLUDE [cc-early-access-2020w1](../includes/cc-early-access-2020w1.md)]  

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Use the Kanban view to effectively keep tabs on the sales pipeline. 

The Kanban view shows opportunities as cards. The lanes in the Kanban view represent the default statuses or business process flow stages of opportunities. The opportunity cards within the swim lanes show where in the process the opportunities are. 

You can drag the opportunities to different lanes to move them from one status or stage to another.

## Open a Kanban view

A Kanban view is available when the Kanban control is added to the Opportunity entity. If you don't see the Kanban view, talk to your system customizer.

To open the Kanban view:

1. In the site map, select **Opportunities**.
2. On the command bar, select the **More commands** icon ![More commands icon](../sales-enterprise/media/more-commands-icon.png "More commands icon") and then select **Show As** > **Kanban**.

    > [!div class="mx-imgBorder"]  
    > ![More commands icon on the opportunity grid](../sales-enterprise//media/opportunity-grid-more-commands-icon.png "More commands icon on the opportunity grid") 

## Available Kanban views for opportunity records

The following two types of Kanban views are available for opportunities:

- Based on the business process flow stage (default view).
- Based on the Opportunity status.

You can switch between the views by selecting the Kanban type from the Kanban type drop-down list.

> [!div class="mx-imgBorder"]  
> ![Kanban type list](../sales-enterprise/media/kanban-type-list-kanban-view.png "Kanban type list")

In the status-based Kanban view, each swim lane represents a default opportunity status such as, Open, Won, or Lost.

> [!div class="mx-imgBorder"]  
> ![Status-based opportunity Kanban view](../sales-enterprise/media/status-based-opportunity-kanban-view.png "Status-based opportunity Kanban view")
 
In the Business process flow-based view, swim lanes represent the stages of opportunities in the **Opportunity sales process** business process flow. 

Currently, the Kanban view is only available for the **Opportunity sales process** business process flow.

> [!div class="mx-imgBorder"]  
> ![Business process flow-based opportunity Kanban view](../sales-enterprise/media/bpf-based-kanban-view.png "Business process flow-based opportunity Kanban view")


> [!NOTE]
> If your system administrator or customizer has customized the **Opportunity sales process** business process, such as changing the stages in the business process flow, the changes are reflected in the business process flow-based opportunity Kanban view. 
 
## Know your Kanban views

Here are some important things to know about your Kanban view:
-  At the top of each lane, the total estimated revenue for the opportunities in that lane is shown. 

    > [!div class="mx-imgBorder"]  
    > ![Sum of estimated revenue](../sales-enterprise/media/total-estimated-revenue.png "Sum of estimated revenue")

    It also shows a count of opportunity cards in that lane. At any given point, only the first 10 records or cards will be shown in any lane. If there are more than 10 opportunity cards in a lane—for example, 50—the count shows 10/50. To see more cards, scroll down in the lane. When you scroll down, the count changes to show 20/50, and so on.

-  Selecting the card title opens the opportunity Main form. The Main form also opens when you move cards across business process flow stages. When you close the Main form, the whole Kanban view is refreshed.

-  The card fields are editable inline. You can quickly change details for the three fields of an opportunity record right from the card.

    > [!div class="mx-imgBorder"]  
    > ![Editable fields on the opportunity card](../sales-enterprise/media/editable-fields-opportunity-card.png "Editable fields on the opportunity card")

-  When you select a different view, cards in the lanes are filtered based on the selected view. 

-  You can use the **Search** box to filter the records or cards in the swim lane based on the search criteria. For example, if you enter the keyword "Interested," it will refresh the Kanban view to only show the opportunity records where the title begins with "Interested".

    > [!div class="mx-imgBorder"]  
    > ![Use the Search box to filter records in the Kanban view](../sales-enterprise/media/search-in-kanban.png "Use the Search box to filter records in the Kanban view")


-  You can drag a card and move it to other lanes. 

    **In the Status-based Kanban view:**

    - Moving a card to other lanes in the Status-based Kanban view opens the Opportunity status change dialog box.
    
      > [!div class="mx-imgBorder"]  
      > ![Close opportunity](../sales-enterprise/media/close-opportunity-in-kanban-view.png "Close opportunity")

    - You can drag an opportunity card from the Open pane to the Won or Close lanes. 
    
    - When you move the card to the Won or Lost lanes, it's closed and becomes inactive—you can't edit the fields on the card.
    
    - You can still reopen a closed opportunity by moving a card from the Won or Lost lanes to the Open lane. 
    
    - When you're dragging a card to move to another lane, the lanes where the card can't be dropped appear dimmed.

    **In the Business process flow-based view:**
    
    - Moving a card to other lanes in the Business process flow-based Kanban view opens the main Opportunity form with the business process flow pop-up window.

      > [!div class="mx-imgBorder"]  
      > ![Main Opportunity form](../sales-enterprise/media/main-opportunity-form.png "Main Opportunity form")

    - You can move the card from the current lane to the consecutive next or previous lane. Swim lanes where the card can't be dropped appear dimmed.

    - When you're dragging a card to move to another lane, the lanes where the card can't be dropped appear dimmed.


### See also

[Add the Kanban control to Opportunity or Activity entities](add-kanban-control-sp.md)  
[Create or edit opportunities](manage-opportunities-sales-professional.md)  
