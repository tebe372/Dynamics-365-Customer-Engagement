---
title: "Push notification setup for application developers (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn developer settings for push notifications for real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 08/02/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Push notification setup for application developers

[Push notification configuration for real-time marketing](real-time-marketing-push-notifications.md) requires some setup that must be completed by an app developer. To complete the mobile app configuration, you must register devices.

Once the configuration is complete, you must also implement user mapping at runtime. This ensures that the correct person in the Marketing app (represented as a contact, lead, or Customer Insights profile) is mapped to the person using the mobile app on a particular device.

## Device registration for iOS applications

To register a device running an iOS application, the following request should be issued:

Request URL:

```
POST {PublicEndpoint}/api/v1.0/orgs/{OrganizationId}/pushchannel/apps/{ApplicationId}/devices/{UserId}
```

Request Body:
```
{
    "ApnsDeviceContract": {
        "ApnsToken": {ApnsToken}
    },
    "ApiToken": {ApiToken}
}
```
Parameters:

- **PublicEndpoint**: Taken from the "Public Endpoint" field of the mobile app configuration entity.
- **OrganizationId**: Taken from the "Organization ID" field of the mobile app configuration entity.
- **ApplicationId**: Taken from the "Application ID" field of the mobile app configuration entity.
- **UserId**: Identifier of the user in CRM. Can be a contact ID, a lead ID, or a Customer Insights profile ID.
- **ApiToken**: Access token taken from the "Access Tokens" section of the mobile app configuration entity.
- **ApnsToken**: Device registration token. [Learn more about how to locate the token](https://developer.apple.com/documentation/usernotifications/registering_your_app_with_apns).

## Device registration for Android applications

To register a device for an Android application, the following request should be issued:

Request URL:

```
POST {PublicEndpoint}/api/v1.0/orgs/{OrganizationId}/pushchannel/apps/{ApplicationId}/devices/{UserId}
```

Request Body:

```
{
    "FcmDeviceContract": {
        "FcmToken": {FcmToken}
    },
    "ApiToken": {ApiToken}
}
```

Parameters:

- **PublicEndpoint**: Taken from the "Public Endpoint" field of the mobile app configuration entity.
- **OrganizationId**: Taken from the "Organization ID" field of the mobile app configuration entity.
- **ApplicationId**: Taken from the "Application ID" field of the mobile app configuration entity.
- **UserId**: Identifier of the user in CRM. Can be a contact ID, a lead ID, or a Customer Insights profile ID.
- **ApiToken**: Access token taken from the "Access Tokens" section of the mobile app configuration entity.
- **FcmToken**: Device registration token. [Learn more about how to locate the token.](https://firebase.google.com/docs/cloud-messaging/android/client#retrieve-the-current-registration-token)

## Implement user mapping

Once the device registration setup is complete, you should configure mapping from Dynamics 365 Marketing customers to mobile application users. This ensures that the correct person (represented with the correct entity and record ID) receives the expected mobile push notification.

This step is not related to the mobile application setup (whether on Android or Apple devices), but rather, to the logical connection between the person represented as a Marketing record and the counterpart mobile application user.

To implement user mapping:

1. Select the correct Marketing app entity. This step is crucial because, in the Marketing app, it is possible to orchestrate to multiple Microsoft Dataverse entities (such as a contact, lead, or Customer Insights profile).
1. Ensure that the correct record ID is passed along to the mobile application. The mobile application should identify the user with that ID.

## User mapping example

As an example, if the contact Dataverse entity is used and the email address field is used as the unique key for an end user as a contact, one possibility to retrieve the correct ID using an OData GET call to Dataverse is the following:

```    
https://<your Marketing instance>.dynamics.com/api/data/v9.0/contacts?$filter=emailaddress1 eq 'andrew@contosoltd.com'
```

Sending this query to Dataverse returns a single contact that has 'andrew@contosoltd.com' as the email address. Once this ID is acquired (in this example, a contact ID), it should be used as the UserId parameter in the mobile application.

There are more options available to implement this mapping and they depend upon the needs and requirements of your scenario.