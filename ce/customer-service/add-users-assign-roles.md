---
title: "Assign roles, enable users for Omnichannel for Customer Service | MicrosoftDocs"
description: "Perform the steps to assign roles to users and enable them in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/21/2022
---

# Assign roles and enable users for Omnichannel for Customer Service



[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Roles in Omnichannel for Customer Service

The Dynamics 365 users can access and perform different functions based on the roles that are assigned to them. The following roles can be assigned individually or in combination based on the tasks that need to be performed:

- **Basic User:** Required by all users of Omnichannel for Customer Service.
- **Omnichannel administrator:**  Required for performing administrator tasks; also requires the **System Administrator** role to manage user roles and privileges in Omnichannel for Customer Service.
- **Omnichannel supervisor:** Required for performing supervisor tasks.
- **Omnichannel agent:** Required for performing agent tasks.
- **Productivity tools user:** Required by users of Dynamics 365 Productivity Tools.
- **Productivity tools administrator:** Required by administrator users of Dynamics 365 Productivity Tools.
- **App Profile Manager Administrator:** Required for creating and assigning app profiles to users of Customer Service and Omnichannel for Customer Service.
- **App Profile User:** Required by users of Customer Service and Omnichannel for Customer Service.

For information on the App Profile Manager Administrator and App Profile User roles, see [Roles and privileges associated with app profile manager](../app-profile-manager/security-roles.md)

Additionally, the **Customer Service Representative** role is required to work with the Case entity.

Use the Microsoft 365 admin center to create user accounts for every user who needs access to Omnichannel for Customer Service. For more information, see [Create users and assign security roles](/power-platform/admin/create-users-assign-online-security-roles).

## Assign roles to users

To be able to map roles to personas in role persona mapping, you must assign the roles to users directly and not through team memberships. For more information about role persona mapping, see [Role persona mapping](role-persona-mapping.md).

Perform the following steps to assign roles to users in the advanced settings area of Dynamics 365:

1. Select **Settings** > **Advanced Settings** on the command bar. The **Settings** page is displayed in a new browser tab.

2. Select **Settings** > **Security** > **Users**.

3. Select the users from the list for whom you want to assign a security role.

4. Select **Manage Roles** in the menu. The security roles available for the business unit are displayed.

5. In the **Manage User Roles** dialog box, select the security roles that you want to assign to the user, and then select **OK**.

To view and manage users in omnichannel for Customer Service, see [Manage users in Omnichannel for Customer Service](users-user-profiles.md).

## Understand roles and their privileges

Each role in Omnichannel for Customer Service can perform a set of actions based on the privileges that are listed as follows.

| Privileges | Omnichannel administrator | Omnichannel supervisor| Omnichannel agent|Productivity tools user| Productivity tools administrator|
|---------|---------|-----------|---------|---------|---------|
| Can view user list/presence list/workstream list/queue list/PBI config list | Yes | Yes ||||
| Can edit roles of a user | Yes |||||
| Can edit default presence and default capacity of a user | Yes | Yes ||||
| Can edit queue assignment of a user | Yes | Yes ||||
| Can add/edit/delete presence | Yes |||||
| Can add/remove users from presence | Yes | Yes ||||
| Can add/edit/delete presence associations | Yes |||||
| Can add/edit/delete workstreams | Yes |||||
| Can add/edit/delete channel settings, context settings, routing rules | Yes |||||
| Can add/edit/delete queues | Yes |||||
| Can add/remove agents from queue | Yes | Yes ||||
| Can add/edit/delete bots | Yes |||||
| Can view/add/edit/delete quick replies | Yes | Yes ||||
| Can add/edit/delete PBI config | Yes |||||
| Can view/add/edit/delete operating hours | Yes |||||
| Can view/add/edit/delete auth settings | Yes |||||
| Can view operating hours || Yes ||||
| Can monitor, assign, and transfer conversations || Yes ||||
| Can view user list/presence list/workstream list/queue list ||| Yes |||
| Can view quick replies ||| Yes |||
| Can read agent script |||| Yes ||
| Can read agent script step |||| Yes ||
| Can read workflow |||| Yes ||
| Can read `msdyn_actioninputparamete`r |||| Yes | Yes |
| Can read `msdyn_actionoutputparameter` |||| Yes | Yes |
| Can read `msdyn_inputparameters` |||| Yes | Yes |
| Can read `msdyn_macroconnector` |||| Yes | Yes |
| Can read `msdyn_parameterdefinition` |||| Yes | Yes |
| Can read `msdyn_designeroptions` |||| Yes | Yes |
| Can read `msdyn_macroactiontemplate` |||| Yes | Yes |
| Can read macro action |||| Yes ||
| Can create/read/write/append/delete agent script ||||| Yes |
| Can create/read/write/append/delete agent script step ||||| Yes |
| Can create/read/write/append/delete agent script workflow ||||| Yes |
| Can read `msdyn_macrosolutionconfiguration` ||||| Yes |
| Can create/read/write/append/delete macro action ||||| Yes |

## Configure permissions to access secure columns

Administrator users will need column-level permissions on secure columns when they configure the following features and channels:

- Authentication settings
- Azure Communication Services
- Geo location providers
- Google's Business Messages channel
- Payment profiles for Apple Messages for Business channel
- SMS channels through TeleSign and Twilio
- Twitter channel
- WeChat channel
- WhatsApp channel

The secure columns can be identified by the information icon that's present for the column.

The entities and their secret attributes are as follows.

| Entity | Secret attributes |
| msdyn_authenticationsettings | msdyn_authenticationclientsecret |
| msdyn_liveworkstreams (for SMS)  | msdyn_secureapikey  |
| msdyn_ocapplepaies | msdyn_ocbase64merchantcertstring <br> msdyn_ocbase64merchantcertstringcontd <br> msdyn_ocmerchantcertificatepassword  |
| msdyn_ocbotchannelregistrationsecrets | msdyn_securemsappsecret |
| msdyn_occommunicationprovidersetting | msdyn_securesecret |
| msdyn_oc_geolocationprovider | msdyn_secureproviderapikey |
| msdyn_ocgooglebusinessmessagesagentaccounts  | msdyn_agentaccountclienttoken  |
| msdyn_ocgooglebusinessmessagespartneraccounts  | msdyn_partneraccountclienttoken <br> msdyn_base64credentialfilestring <br> msdyn_base64credentialfilestringcontd  |
| msdyn_ocsmssettingsecrets  | msdyn_secureapikey |
| msdyn_octwitterapplication  | msdyn_securetwitterconsumersecret <br> msdyn_securetwitterconsumerkey  |
| msdyn_octwitterhandlesecrets  | msdyn_useraccesstoken <br> msdyn_useraccesstokensecret  |
| msdyn_ocwechatchannelconfig | msdyn_secureapplicationsecret <br> msdyn_securetoken <br> msdyn_secureencodingaeskey   |
| msdyn_ocwhatsappchannelaccount | msdyn_secureauthenticationtoken |

**Manage permissions on secret attributes**

1. In Power Platform admin center, create or update the column security profile.
1. Provide the read, update, or create permissions to the profile on the secret attributes that are mentioned in the preceding table.

**More information**

- [Associate security profiles and set permissions](/power-platform/admin/set-up-security-permissions-field#associate-security-profiles-and-set-permissions)
- [Overview of entities](developer/reference/entities/overview-entity-ref.md) 

### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Roles and privileges associated with app profile manager](../app-profile-manager/security-roles.md)  
[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Role personas for unified routing](role-persona-mapping.md)  
[Guide agents with scripts](../app-profile-manager/agent-scripts.md)  
[Automate tasks with macros](../app-profile-manager/macros.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
