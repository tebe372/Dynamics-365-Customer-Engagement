---
title: "Predefined security roles for Sales (Dynamics 365 Sales) | MicrosoftDocs"
description: "Predefined security roles define permissions and access levels specific to different sales personas. Assign users to appropriate security roles to grant them adequate access to the system."
ms.date: 10/11/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Predefined security roles for Sales

Predefined security roles define permissions and access levels specific to different sales personas. Assign users to appropriate security roles to grant them adequate access to the system.

## Predefined security roles

Security roles control users access to data through a set of access levels and permissions. The combination of access levels and permissions that are included in a specific security role defines  users access to data and their interactions with that data. For more information, see [Security roles and privileges](/power-platform/admin/security-roles-privileges)

The predefined security roles for Sales include permissions and access levels that the default sales personas will need. For example, the Sales Manager and Salesperson security roles can be associated with the respective users in your organization. As a system administrator, you can verify the permissions and access levels granted for each role and modify it to suit your needs. For more information, see [Create or edit a security role](/power-platform/admin/create-edit-security-role).

| **Security roles** | **Who needs it?** | **Applies to** | **Access granted** |
| --- | --- | --- | --- |
| System Administrator | Users who has full permission to install, configure, upgrade, customize, or administer the environment, including creating, modifying, and assigning security roles. Can view all data in the environment. | Sales Enterprise and Sales Premium | Install, configure, customize, manage permissions, and access all the features in the application. |
| Vice President of Sales | Users who typically manage the sales organization for several business units or the entire organization. | Sales Enterprise and Sales Premium | Same permissions as the Sales Manager, except that their scope of access is broader. |
| Sales Manager | Users who manage a team of sellers and are responsible for the team's performance. They are also responsible for creating and managing products, setting sales targets, and projecting sales forecasts. | Sales Enterprise and Sales Premium | Access to product management, sales management, sales forecasting, and goal management. |
| Sales Professional Manager | Users who manage a team of sellers and are responsible for the team's performance. They are also responsible for creating and managing products, price lists, and unit groups. | Sales Professional | Access to product, account and contact management. |
| Sales Professional Person | Sellers who work on opportunities, quotes, orders, and invoices. | Sales Professional | Access to everything from lead to order – Lead, Opportunities, Quote, Order, Invoice.\</br\>Create accounts and contacts, and track goals |
| Salesperson | Sellers who work on opportunities, quotes, orders, and invoices. | Sales Enterprise and Sales Premium | Access to everything from lead to order – Lead, Opportunities, Quote, Order, Invoice.\</br\>Create accounts and contacts, and track goals. |
| Forecast Appuser | System security role. Do not assign this role to any users. | Sales Enterprise and Sales Premium | Internal role used by Dynamics 365 to perform certain forecasting operations. |
| Forecast Manager | Sales manager or an equivalent role who is responsible for configuring forecasts in the organization. | Sales Enterprise and Sales Premium | Configure, clone, deactivate, adjust, or delete a forecast. |
| Forecast user | Any user in the organization who needs access to the forecast data for tracking and analysis | Sales Enterprise and Sales Premium | View forecast and drill-down forecast data |
| Playbook Manager | Sales manager or an equivalent role that creates playbooks for the organization. | Sales Enterprise and Sales Premium | Create playbook categories and playbook templates, and add documents to the playbook template. |
| Playbook User | Sales representatives who use playbooks while working on a record | Sales Enterprise and Sales Premium | Launch playbooks in the context of an entity, mark a playbook as completed, and track playbook activities. |
| Sales team member | Users who don't need the full capabilities of an enterprise application. These users will have a dedicated license, use a dedicated app, and get the Sales Team member security role to support their scenario.  More information: [Sales Team Member app for users with Team Member license](sales-team-member.md). | Sales Enterprise and Sales Premium | Access to the Sales Team Member App. Read access to contacts, accounts, leads, and opportunities. Add notes and activities, such as tasks. |
| Sales Professional app access | Users who need to access the Sales Professional app. | Sales Professional | Access to the Sales Professional App. |
| Sequence Manager | Sales manager or an equivalent role that creates and manages sequences, segments, and assignment rules for the organization. | Sales Premium | Create, edit, delete, and deactivate the following features in sales accelerator:<br>- Sequences<br>- Segments<br>- Assignment rules |
| System Customizer | Users who has full permission to customize the environment. However, users with this role can only view records for environment entities that they create. | Sales Enterprise and Sales Premium | Create (self), Read (self), Write (self), Delete (self), and Customizations across all features in the application. |

## What are core sales roles

The core sales roles correspond to the core sales personas in an organization. These roles have access to majority of the sales activities such as managing leads, opportunities, quotes, orders, invoices, and so on. 

The following core sales roles are predefined for Sales Enterprise and Sales Premium licenses:

- Salesperson
- Sales Manager
- Vice President of Sales

The following core sales roles are predefined for the Sales Professional license:
- Sales Professional Person
- Sales Professional Manager

Other roles such as Forecast manager, Playbook user, and so on are functional roles and can be assigned to users who perform these functions.  

## Assign security roles to users

Associate one or more security roles to a user depending on their roles and responsibilities. For example, if a Sales Manager is also
responsible for enforcing best practices for Playbooks, assign the Sales Manager and Playbook Manager security roles to that user.

**Follow these steps:**

1. In the Sales Hub app, select the Settings icon in the top-right
   corner, and select **Advanced Settings**.

2. Select **Settings** in the Business Management interface, and
   go to **Security** under **System**.

3. Select **Users**, and then select the user account.

4. Select **Manage Roles**, and choose the roles that you want to assign to the user.

5. Notify the user and have them check their permissions.

### See also   

[Create users and assign security roles](/power-platform/admin/create-users-assign-online-security-roles)
