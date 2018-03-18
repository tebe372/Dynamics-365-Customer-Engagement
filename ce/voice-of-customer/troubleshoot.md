---
title: "Troubleshoot Voice of the Customer | MicrosoftDocs"
description: "Learn how to troubleshoot issues in Voice of the Customer solution."
keywords: "troubleshoot voice of the customer"
ms.date: 01/26/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: C3787135-8818-42F6-A63C-F968EBB60802
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Troubleshooting the Voice of the Customer solution

This article provides information about troubleshooting issues in the Voice of the Customer solution.

## Reconfiguring Voice of the Customer

If the Voice of the Customer solution is accidentally deleted or misconfigured, it might not be able to receive survey responses. You can now repair or restore the Voice of the Customer configuration from the **Voice of the Customer Configurations** page.

> [!Note]
> You must be a survey administrator to reconfigure the Voice of the Customer solution.

1. Sign in to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
2. Go to **Settings** > **Voice of the Customer Configurations**.
3. Select **Configure** from the toolbar at the top of the screen.

  ![Configure Voice of the Customer](media/reconfigure-voc.png "Configure Voice of the Customer")  

> [!Note]
> If the solution cannot be reconfigured properly, an error message appears.

## Validating the Voice of the Customer solution

As a survey administrator, you can validate the status of your Voice of the Customer solution. Validation allows you to check if:
- Voice of the Customer configuration and provisioning is in its proper state.
- Survey lifecycle is working for the organization.
- Survey responses are being received properly.

To validate the Voice of the Customer solution:
1.	Sign in to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
2.	Go to **Settings** > **Voice of the Customer Configurations**.
3.	Select **Voice of the Customer Configuration** from the list of active configurations.
4.	Select **Validate** from the toolbar at the top of the screen. A confirmation message appears, asking your consent for the validation process to start.
5.	Select **OK** to start the validation process. The results are displayed under the **Voice of the Customer Validation Results** area.
6.	Select **Download Log File** to download the detailed report.

## Validating a survey

As a survey administrator, you can validate if a survey has created any issues.
1.	Sign in to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
2.	Go to **Voice of the Customer** > **Surveys**.
3.	Select the name of the survey you want to validate.
4.	Select **Validate Survey** from the toolbar at the top of the screen. A confirmation message appears, asking your consent for the validation process to start with or without publishing the survey.
5.	Select one of the following buttons in the confirmation message:
  - **Publish**: All the validation tests are performed.
  - **Skip Publish**: Only the validation tests that do not require publishing the survey are performed.
  
  The results are displayed under the **Survey Validation Results** area.
6.	Select **Download Log File** to download the detailed report.

### See also
[Plan a survey](plan-survey.md)   
[Design a basic survey](design-basic-survey.md)   
[Design an advanced survey](design-advanced-survey.md)   
[Distribute a survey](distribute-survey.md)
[Analyze survey data](analyze-survey-data.md)
