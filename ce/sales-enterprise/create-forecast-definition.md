---
title: "Create a forecast definition (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Define the data and period to use for the purpose of forecasting in Dynamics 365 for Sales."
keywords: ""
ms.date: 04/05/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1"
ms.assetid: 1517b3d4-639b-4fec-bbbc-8474320d1867
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

# Create a forecast definition

Applies to Dynamics 365 for Customer Engagement apps version 9.1.x

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 for Customer Engagement apps Technical Support won’t be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?linkid=870960).
> - To know more about the feature's availability in your region, see [When will the April 2019 features be enabled for customers who did not opt in to the preview?](/power-platform/admin/preview-april-2019-updates#when-will-the-april-2019-features-be-enabled-for-customers-who-did-not-opt-in-to-the-preview)

Capture information about parameters such as the period for which the forecast should be generated or the data to use for forecasting.

## Prerequisites

Before creating a forecast definition, review the following requisites:

- Administrator, forecast manager, or forecast user role is assigned to you.
- All the users under your hierarchy are assigned forecast manager or forecast user role.
- No users are disabled under your hierarchy when you publish the forecast definition.
 
## Create forecast definition

1.	Sign in to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)].

2.  Select the site map icon ![Icon to open site map](media/site-map-new.png "Icon to open site map"), and in the lower left of the site map, select the **Change area** icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area"), and then select the **App Settings** area.	

3.	In the site map, select **Forecast definitions**.
 
4.	On the command bar, select **New**.

5.	In the **General** section of the Forecast definition record, enter the following information:

    -  **Forecast name**. Enter a descriptive name that explains what the forecast is about. For example, My team’s forecast.

    -  **Forecast metric**. Select a metric for forecasting. It is a lookup to the **Goal metric** entity. The field that you select here is used in aggregating data for the forecast. Only the opportunity fields of type amount (revenue) are available for selection. 
    
    -  **Quota source**. Select whether the targets used for the purpose of forecasting will be based on existing goals or manual targets. If this is set to Goal based, then when the forecast is being generated, the system looks for the matching goal based on the forecast metric and rollup query In-progress (Money) you’ve selected and the Goal owner, and uses the quota/target defined in the goal.

    - **Rollup query**. This is a lookup to the **Rollup query** entity. Select a rollup query to define which records to consider for forecasting. For example, to include only the opportunities coming from the East region in the forecast, you can create a rollup query to filter only the opportunities with accounts in the East region and use it in the forecast definition.

        > [!NOTE]
        > Only the rollup queries with opportunity as the parent entity are available and valid for selection.
    - **Owner**. If you are creating the forecast definition for yourself, choose your name as owner. Otherwise, choose the username for whom you are creating the forecast definition. Based on the hierarchy of the selected username the forecast definition is created.

        For example, Bert Hair (manager) requests Wade Roque (reports to Bert) to create a forecast definition for Bert. While creating the forecast definition, Wade selects Bert Hair as the owner so the forecast definition is created based on the Bert's hierarchy. 

      > [!div class="mx-imgBorder"]
      > ![Forecast definition record](media/forecast-definition-form.png "Forecast definition record")

6.  In the **Scheduling** section of the Forecast definition form, enter the following:

    -  **Forecast period**. Select whether the forecast is to be generated monthly, quarterly or for a custom period. Quarterly is selected by default.

    -  **Fiscal year**. Select the fiscal year for the forecast. This is populated based on the org’s fiscal year settings.

    -  **Start month/Start quarter**. Select when to start forecasting. If you select the forecast period as Monthly, select the month from which you want to start forecasting. If you select the forecast period as Quarterly, select the quarter from which forecasting should start.

    -  **Number of forecasts**. Enter the number of forecasts that need to be generated. You can only create one forecast when the Forecast period is custom. 

        > [!NOTE]
        > If you select the Forecast period as monthly, Fiscal year as FY19, Start month as January, and Number of forecasts as 4, the forecasts that are generated are grouped by four months, January, February, March, and April. In such case, the Forecast start and end date is automatically set to Jan 1, 2019, and April 30, 2019, respectively.

    -  **Start date**. If you selected **Custom** in **Forecast period**, select the start date to identify the date when the forecasting should start.

    -  **End date**. If you selected **Custom** in **Forecast period**, select the end date to identify the date when the forecasting should stop.

7.	Select **Save**.

8.	To generate forecasts based on this definition, publish the forecast definition. On the command bar, select **Publish**. After a forecast definition is published, it becomes read-only.
 
Generating a forecast is a background process. After all the forecasts are generated, the forecast definition’s state and status is set to Published and Success respectively.

> [!div class="mx-imgBorder"]
> ![Published forecast definition](media/published-forecast-definitions.png "Published forecast definition")


## See also
[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  
[View forecasts](view-forecasts.md)
