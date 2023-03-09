---
title: Provide permissions to access and share a forecast
description: Provide permissions to view, access, and share a forecast in Dynamics 365 Sales.
ms.date: 03/15/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.custom: 
  - dyn365-sales
---

# Provide permissions to access and share a forecast  

After you've [selected general properties and scheduled your forecast](./define-general-properties-scheduling-forecast.md), define who can view, access, and share it.

Use the **Permissions** step to:

- [Define the owner of the forecast](#define-the-forecast-owner)
- [Provide access to users who have specific security roles to view the forecast](#provide-access-to-additional-roles)
- [Allow users to share their forecast records with other users](#enable-or-disable-forecast-sharing)

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Define the forecast owner

A forecast owner can view, share, and adjust the forecast. You can assign a user or a business unit (BU) as the owner.

In the **Owner lookup field (preview)**, select who owns the forecast.

- To assign ownership of all forecasts in the BU to all users in the BU, select **Business Unit** or **Owning Business Unit**. The BU ownership is only available to hierarchy entities that have a BU relationship. Entities such as territory and product are not connected to any BUs and hence can't use BU ownership.

- To assign ownership to a specific user, select a system user. For example, if you select **Created by** user as the owner of an account-based forecast, then users who created accounts will own the forecast for their respective accounts.  

- To assign ownership to a parent hierarchy, select **Manager** (user-based forecasts) or **Parent Business** (BU-based forecasts). For example, when you select **Parent Business** as the owner of a BU-based forecast, all users in the parent BU can view and update the forecasts of their child BU.  
    :::image type="content" source="media/forecast-owner-lookup-field.png" alt-text="Owner lookup field with Parent Business as the owner.":::

If you change the default value in **Owner lookup field (preview)**, the corresponding column is added to the forecast grid.  

## Provide access to additional roles

In the **Additional security roles** section, select an option to give access to users who aren't part of the hierarchy:

- **No additional security roles**: This option gives access only to the selected hierarchy users. Users who have other security roles in the organization can't view the forecast. This option is selected by default.
- **All security roles can read this forecast**: This option gives read-only access to all the security roles in your organization.
- **Specific security roles**: Use this option to specify the security roles to receive either read-only access, or read-only and adjustment access.

A message under the security roles gives more information about how the forecast security is applied, based on your selections.

:::image type="content" source="./media/forecast-permissions.png" alt-text="A screenshot of the Permissions step of the Forecast configuration page, with additional security roles defined.":::

## Enable or disable forecast sharing

By default, forecasts can't be shared. If you turn on forecast sharing, users can share only the forecasts that they own. For more information, see [Who owns the forecast?](./faqs-sales.md#who-owns-the-forecast)

In the **Share forecast** section, select one of the following options:

- **None**: The forecast can't be shared with anyone. If it's already been shared, users it was shared with can no longer access it.
- **Read-only**: The forecast can be shared to view, but not to edit.
- **Read and adjust**: The forecast can be shared either to view, or to view and edit. Select this option to share the forecast to users with different levels of access.

When you've finished setting permissions, select **Next**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

<table>
<tr><td>

> [!div class="nextstepaction"]
> [Previous step: Define general properties and scheduling](define-general-properties-scheduling-forecast.md)
</td><td>

> [!div class="nextstepaction"]
> [Next step: Choose layout and columns](choose-layout-and-columns-forecast.md)
</td></tr>
</table>

### See also

[Configure forecasts in your organization](configure-forecast.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
