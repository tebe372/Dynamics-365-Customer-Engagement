---
title: Configure Copilot in Dynamics 365 Sales
description: Learn how to configure Copilot in Dynamics 365 Sales to use fields that are most relevant to your business for generating summaries and catch up information.
ms.date: 10/05/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Configure Copilot in Dynamics 365 Sales

You can configure the fields that copilot should use to generate summaries and catch up information.  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Configure record summary and catch up fields

By default, Copilot uses the first seven fields in the default lead and opportunity view to generate summaries and last 10 updates in the audit history of the record to generate catch ups. You can configure a view with fields that are most relevant for your business and have Copilot use it for generating summaries and catch ups. You can configure different views for summary and catch up.

1. In the Sales Hub app, [create a system view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view) with the fields that you want to use for generating summaries and catch up information.


1. Go to the Change area and select **App Settings**.  
1. Under **General Settings**, select **Copilot**.
1. Select **Record summary**, and then select the view you'd like to use for generating summaries for leads and opportunities.  
    You'll see the first seven fields listed under the **Fields** column. These fields will be used to [generate summaries](use-sales-copilot.md#summarize-an-opportunity-or-a-lead).  

    :::image type="content" source="media/copilot-record-summary-settings.svg" alt-text="Screenshot of the Record summary settings in Copilot":::

1. Select **Record catch up**, and then select **Turn audit on**.  
    As catch up summaries are generated from the audit history, you must turn on auditing to use this feature. Ensure to enable user access to the audit history and audit summary. For more information, see [Grant audit access to users](enable-setup-copilot.md#grant-audit-access-to-users).
  
1. Select the view you'd like to use for generating catch up information for leads and opportunities.  
    You'll see the first 10 fields listed the under **Fields** column. Changes to these fields are only reported in the catch ups. If you select the **Default system view**, the last 10 updates in the audit history of the record are used to [generate catch ups](use-sales-copilot.md#catch-up-with-an-opportunity-or-lead).

    :::image type="content" source="media/copilot-record-catchup-settings.svg" alt-text="Screenshot of the Record catch up settings in Copilot":::
    
1. Save the changes.

> [!IMPORTANT]
> If you update or remove fields in any of the selected views, open the **Copilot** settings page, select a different view, save the changes, and then select the updated view. Ensure that you see the updated fields listed under the **Fields** column. 

## See also

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)

