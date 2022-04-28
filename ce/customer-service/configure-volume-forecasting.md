---
title: "Configure case and conversation volume forecasting in Customer Service | Microsoft Docs"
description: "Learn how to configure the Forecast report for cases and conversations in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 04/28/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Configure case and conversation volume forecasting (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Customer service supervisors in your organization need to ensure that they have an adequate number of agents available to serve their customers. Overcapacity results in higher costs, while under capacity results in longer customer wait times, which in turn can negatively impact customer satisfaction. 

As an administrator, you can configure the Forecast report to help your supervisors plan the right level of staffing for your business based on predicted volumes of cases and conversations.

Supervisors can use the Forecast report for case and conversation volumes in the following ways:

- Forecast upcoming case and conversation volumes based on historical traffic. For conversation volume forecasting, if chatbots are set up for your conversational channels, conversations handled by chatbots that have no human agent joined are excluded from the forecasting, so that you can rely on the predicted conversation volumes for human agent staffing.
- Visualize forecast volumes on a daily, weekly, and monthly interval basis, for a time range up to six months (depending on how many days of cases or conversations were created in the past).
- Slice and dice forecasted volumes by channel and queue.
- Automatically detect seasonality from historical traffic with the settings option to import your service calendar. This helps the forecasting model to accurately predict case or conversation volume during special, seasonal events.

> [!Note]
> The Forecast report is currently available in certain geographical locations. More information: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md).

## How the case and conversation volume forecasting works

The Forecast report uses a set of forecasting models to predict case and conversation volumes based on historical case and conversation data. The models use ensemble forecasting method with seasonality support (automatic detection or custom settings) to enhance the quality of forecasting.

The report can forecast for a date range up to six months, depending on how many days of historical data are available and used. In general, the models can forecast the half of the input date range, with the following conditions.

- If the historical data time range is less than 12 months, forecasting time range is the half of the input time range. For example, eight months of historical date range can forecast for next four months.
- If the historical range equals or is more than 12 months (up to 24 months), the report will forecast for next six months. 

The historical data must meet the following minimum requirements for the models to generate forecasting. Otherwise, an error message will be posted on the admin settings page.  

- At least two weeks of historical data is available. 
- For case volume forecasting, the number of days when no case is created should be less than 30 percent per queue. 
- For conversation forecasting, the average daily volume should be more than 50 per queue, and number of days when no case is created should be less than 30 percent per queue.


## Prerequisites

To configure the Forecast report, you must have the System administrator role.

For users in your organization to be able to access the Forecast report, they must have the Customer Service Manager role.

## Enable the case and conversation forecasting reports in Customer Service

The configuration steps for enabling case and conversation forecasting reports are similar but must be done separately. First, you must toggle on the feature, and then you can configure the settings for it.

1. In the Customer Service admin center app, in **Operations**, select **Insights**. The Insights page is displayed.

1. In the **Report settings** section, do the following steps:

   For case volume forecasting:<br>

   a. Next to **Case forecasting (preview)**, select **Manage**. The **Case forecasting (preview)** page is displayed.
   
   b. Toggle **Enable case forecasting** to **On**, and then select **Save**. Continue with the configuration steps that follow in the rest of this procedure.
   
   For conversation volume forecasting:<br>
   
   a. For conversation volume forecasting, next to **Conversation forecasting (preview)**, select **Manage**. The **Conversation forecasting (preview)** page is displayed.
   
   b. Toggle **Enable conversation forecasting** to **On**, and then select **Save**. Continue with the configuration steps that follow in the rest of this procedure.

1. The report reflects the day on which it’s enabled. If you want to choose a different day of the month for the report to be updated, in **Refresh schedules**, select the day you want.

1. After the report is generated for the first time, you’ll see a **Model run summary** section above **Refresh schedules** that displays the date and time on which the forecast was last created. The time reflects your time zone. If you want to set a different default time zone, do the following steps:

   a. Select the **Settings** (gear) icon in the top-right corner of the app, and then select **Personal Settings**. The Set Personal Options page is displayed.
   
   b. In **Set the time zone you are in**, choose the time zone you want from the dropdown menu.
   
   c. Select **OK**.
  
1. If you want to change the time zone to use for daily forecasting, in **Time zone for daily forecasting**, select time zone you want.

1. If you want to select a particular date that the data starts from, in **Historical data start date (optional), choose the **Start date** you want. The latest (closest) date that the start date can be is at least two weeks back from the current date. If nothing is selected, the start date will be decided based on the earliest creation date of all of your historical records, up to two years. If the start date you select is earlier than two years, only last two years of data will be used.

1. If you want to specify seasonal, in **Seasonality**, select the **Use schedules from Holiday Calendar** check box. Selecting the **Holiday Calendar** link opens the **All Holiday Schedules** page, where you can create a new schedule or select an existing schedule.

1. Save your changes. If this is the first time you’ve turned on the forecast feature, it may take up to 24 hours until the forecasting data is ready to view in the Forecast report. 

### See also

[Forecast case and conversation volumes](use-volume-forecasting.md)<br>
[Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md)
