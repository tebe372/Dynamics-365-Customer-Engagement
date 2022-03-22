---
title: Configure forecasts in your organization
description: Configure forecasts based on revenue or quantity to predict how much revenue your sales team will generate in a given time frame.
ms.date: 03/15/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---

# Configure forecasts in your organization

A forecast helps your organization predict how much revenue your sales team will generate in a given time frame. When done correctly, forecasting can play a significant role in your company's success.  

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager<br>See [Predefined security roles for Sales](security-roles-for-sales.md) |

## How forecasting helps organizations?

Using forecasts:

- Sellers can track performance against targets and identify pipeline risks that might jeopardize their ability to hit them.
- Managers can track individual sales performance against quotas to proactively provide coaching.
- Directors can use forecast trends to anticipate departmental sales and reallocate resources if necessary.
- Organization leaders can use the projected estimates to change the product strategy or provide updated projections to investors.

>[!NOTE]
>Forecasting isn't supported on Government Community Cloud (GCC) or mobile devices.

## Configure forecasting

You can configure forecasts that are based on revenue or quantity. You define the type of forecast, its hierarchy, permissions for accessing it, and the details you want to appear on the forecast grid. After a forecast is activated, your sales team can view the revenue, or quantity, and pipeline projections.

Forecasting is available in your organization by default.

1. Sign in to the **Sales Hub** app.
1. In the site map, select the Change area icon ![Icon to change the work area](./media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.
1. Under **Performance management**, select **Forecast configuration**.

    :::image type="content" source="./media/forecast-enable-forecasting-enabled.png" alt-text="A screenshot of the forecast configuration page in Sales Hub Performance Management settings.":::

1. [Select a template](./select-template-forecast.md).
1. [Define general properties and scheduling](./define-general-properties-scheduling-forecast.md).
1. [Provide access permissions](./provide-permissions-forecast.md).
1. [Configure columns and layouts](./choose-layout-and-columns-forecast.md).
1. [Add filters](./add-additional-filters.md).
1. [Configure and manage drill-down entities](./configure-manage-drill-downs.md).
1. [Configure advanced settings](./forecast-configure-advanced-settings.md).
1. [Activate the forecast and upload data](./activate-upload-simple-columns-data-forecast.md).

### Use APIs to upload forecast data

After a forecast is activated, you can use the msdyn_ForecastApi custom action to upload forecasting data to simple columns. For more information, see [msdyn_ForecastApi action](developer/reference/custom-actions/msdyn_ForecastApi.md).

## Find your forecasts

In the **Sales** site map, you'll find **Forecasts** under **Performance**.

:::image type="content" source="./media/forecast-select-sales-performance-forecasts.png" alt-text="A screenshot of the Sales Hub site map that shows Forecasts under Performance.":::

In the **Opportunity** form, **Forecast Category** appears above **Description**.

:::image type="content" source="./media/capture-forecast-category-opportunity-form.png" alt-text="A screenshot of an opportunity form with the Forecast category expanded.":::

 The categories define the confidence level of closing the opportunity. You can add custom values for your organization if you need to. To learn more, see [Capture forecast category for opportunity](./capture-forecast-category-opportunity.md).

>[!NOTE]
>
>- Forecast category options include **Won** and **Lost**. If an opportunity is closed as **Won** or **Lost**, the **Opportunity Forecast Category Mapping Process** out-of-the-box workflow automatically changes the forecast category to match.
>- To view the **Opportunity Forecast Category Mapping Process** workflow, go to **Settings** > **Process Center** > **Processes** and select the **All Processes** view. Search for and open the **Opportunity Forecast Category Mapping Process** workflow. You can customize or deactivate the workflow according to your organization's requirements.
>- Are you using a custom option set instead of forecast category? You'll need to create a workflow to automatically sync the opportunity status with your option set to make sure that the projection is accurate.
>- To learn more, see [Use workflow processes to automate processes that don't require user interaction](/power-automate/get-started-logic-flow).

If you don't want to see the forecast category in the opportunity form, you'll need to customize the form. You can't use the **Visible by default** option to hide it. To learn more, see [Unable to hide forecast category field in opportunity forms](./ts-forecasts.md#hide_forecast_category_field).

>[!IMPORTANT]
>The forecasting feature is intended to help sales managers or supervisors enhance their team’s performance. It is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with users. This also includes adequately notifying users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with users may be monitored, recorded, or stored.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

<table>
<tr><td>

> [!div class="nextstepaction"]
> [Next step: Select a template](select-template-forecast.md)
</td></tr>
</table>

### See also

[Blog: Tips for setting up sales forecasting in Dynamics 365 Sales](https://cloudblogs.microsoft.com/dynamics365/it/2020/11/23/tips-for-setting-up-sales-forecasting-in-dynamics-365-sales/)
[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)
[View forecasts](view-forecasts.md)
[About premium forecasting](/dynamics365/ai/sales/configure-premium-forecasting)  
[msdyn_ForecastApi action](developer/reference/custom-actions/msdyn_ForecastApi.md)  
[Forecasting FAQs](faqs-sales.md#forecasting)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
