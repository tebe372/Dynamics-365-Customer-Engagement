---
title: "Build and host a custom event portal | MicrosoftDocs"
description: "Provides information about how you can extend event management  web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 02/21/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Build and host a custom event portal

The Dynamics 365 Event Management feature helps you to organize, manage and process the events. When you install the Event Management solution, you will get an **Event Portal** which gives the users a web application where they can get to know more about the event details. More information: [Event Portal](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/set-up-event-portal).

The Event Management event portal consists of two parts:

- Frontend (e.g. Angular, Vanilla JS,...)
- REST API backend

The frontend part is a single page application created using the [Angular](https://angular.io) framework and is fully customizable. The backend and the customization of the backend depends on the type of hosting.

You can host custom event portal in two ways:

- [Self-hosted](self-hosted.md)
- [Dynamics 365 Portal hosted](portal-hosted.md)

## Prerequisites

You either can build your own frontend or customize the provided demo event portal.

> [!NOTE]
> For the provided demo event portal the [Angular framework](https://angular.io/guide/quickstart) is used. However, since the backend is not dependent on the frontend you can use whatever framework you would like to use.

To get started with customizing the provided demo event portal you need to follow this steps:

1. Install [Node.js](https://nodejs.org/en/download) (we recommend Node.js version 10.x).

1. Open a terminal/shell of your choice (e.g. Command Prompt or Powershell) and enter the following command to check whether the installation is successful or not.
```CLI
node -v
```
> [!NOTE]
> If you have a terminal/shell already open, please restart it before typing in the command.

1. Run the following command to install the Angular CLI (command line interface) tools. This is required to build and run the Angular app. More information: [Angular CLI](https://cli.angular.io/).
```CLI
npm install -g @angular/cli
```

1. Download the [Source code](https://go.microsoft.com/fwlink/?linkid=2020107).

1. Go into the directory where you have downloaded the source code and run the following command to fetch all the necessary packages that are required to run the website. 
```CLI
npm install
```
> [!NOTE]
> The command needs to be executed in the same directory where the `package.json` file is located.

## Configuration

All the configuration for your custom event portal can be made by creating an `environment.ts` file in `\src\environments`. This directory contains sample configuration files for different environments (self hosted, portal hosted, development). You can find instructions on how to change the configuration in the related topics [Environment configuration for self hosted](self-hosted.md) and [Environment configuration for portal hosted](portal-hosted.md). Here are some of the settings that you need to know:

- **production** - Used internally by **Angular** to differentiate between production and development environments.
- **apiEndpoint** - Used by event management application. Points to the API endpoint that **Angular** services use.
- **localizationEndpoint** - Points to the localization endpoint that Event Management localization system uses to fetch the localized labels.
- **useRestStack** - Used by event management application to adjust to different types of APIs used when utilizing self-hosted approach against Dynamics 365 hosted approach. Self-hosted approach uses REST API.
- **isAuthenticationEnabled** - Used by event management application to turn on support user authentication. If false login/logout dropdown will not be shown on the navigation bar.
- **useAadB2C** - Used by event management application to enable **Azure Active Directory B2C identity management** (for self-hosted) and **Dynamics 365 Portals identity management** (for Dynamics 365 Portal hosted).
- **useMockData** - Used by event management for development purposes. Overrides **Angular** application data services to return mock data.
- **aadB2CConfig** - Configuration object used by event management application when **AAD B2C identity management** is enabled. 

## Development

Run the command `ng serve` from your working directory to build and locally serve the website. Additionally, this command prints the URL and port where you can reach the application (default is `localhost:4200`).

## Backend customization

Most of the customization possibilities for the Event Management application are found on the front-end, but there is also a use case when customizer adds a new field to the existing Event Management entity and would like to see that field in the website. For example if `custom_new_field` field is added to the `evtmgmt_pass` entity. The passes for the event can be retrieved using API endpoint `api/v1.0/events/{readableEventId}/passes`, but the result won't contain newly added field. To expose the new fields to be visible in API, you should do the following:

1. Open your Dynamics 365 instance.
1. Open Advanced Find view
1. Select `Website Entity Configuration` entity and hit results button
1. Create new record
1. Enter a name that will be meaningful to you
1. Select the entity that you want an extra field to be visible for (`Pass` in this example)
1. Write a Json array that contains the extra custom fields that should be visible through the API. In this example: `["custom_new_field"]`. Be careful to form proper Json. 

This will expose your new custom field through the API and you should be able to utilize it in the front-end.

> [!div class="nextstepaction"]
> [Self-hosted](self-hosted.md)<br /><br />
> [Dynamics 365 Portal hosted](portal-hosted.md)<br /><br />
> [Localization](event-portal-localization.md)

