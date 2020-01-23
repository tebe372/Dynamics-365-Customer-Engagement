---
title: "Overview | MicrosoftDocs"
description: "Provides information about how you can extend event management  web application functionality."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 09/06/2019
ms.service: dynamics-365-marketing
ms.technology:
  - "marketing"
ms.topic: "article"
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Overview

The event management feature helps you to organize, manage, and process the events. When you install the event management solution, you get an event portal which gives the users a web application where they can get to know more about the event details. More information: [Event Portal](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/set-up-event-portal).

The event portal consists of two parts:

1. Frontend
2. REST API backend

You can implement the frontend using any of the available frameworks. The frontend part is a single page application and is fully customizable. The backend and the customization of the backend depends on the hosting type.

You can host a custom event website in two ways:

1. [Self-hosted](self-hosted.md)
2. [Dynamics 365 Portal hosted](portal-hosted.md)

## Prerequisites

You can build your frontend or customize the provided demo event website.

> [!NOTE]
> The provided demo event website is an [Angular framework](https://angular.io/guide/quickstart) based website. However, since the backend is not dependent on the frontend, you can use any framework of your choice.

To get started with customizing the demo event website, you need to follow these steps:

1. Download the [source code](#download-sample-event-website). Make sure that the version of the source code matches the version of the event management solution installed in your instance. More information: [Download sample event website](#download-sample-event-website)

2. Install [Node.js](https://nodejs.org/en/download) version 10.x or higher.

3. Open Command Prompt or Powershell and run the command to check whether the installation is successful or not.

   ```CLI
    node -v
    ```

    > [!NOTE]
    > If you have a terminal or shell already open, restart it before typing in the command.

4. Run the command to install the Angular CLI (command line interface) required to build and run the Angular application. More information: [Angular CLI](https://cli.angular.io/).
   ```CLI
   npm install -g @angular/cli
   ```

5. Navigate into the directory where you have downloaded the [source code](#download-sample-event-website) and run the command to fetch all the necessary packages required to run the website.

    ```CLI
    npm install
    ```

   > [!NOTE]
   > You need to run the command in the same directory where the `package.json` file is located.

6. See [public API documentation](https://go.microsoft.com/fwlink/?linkid=2042224) to interact with the backend services.
7. Dynamics 365 Marketing instance with Event Management solution and Portals solution installed. To install, see [Dynamics 365 Marketing](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/trial-signup)

## Download sample event website

Select the version you would like to download from the table below.

| Name | Release | Changes | Uploaded |
|--|--|--|--|
|Sample Event Website| 1.19.0 (December release)| - Fix accesibility issues. <br/>- Update website languages. <br/>- Improve speaker page. <br/>- Minor improvements and bug fixes.| [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/191201-EventWebsite.zip)
|Sample Event Website| 1.18.0 (October release)| - Minor improvements and bug fixes. | [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/191001-EventWebsite.zip)
|Sample Event Website| 1.17.0 (September release)|- Improve workflow for paid events. <br/>- Fix compatibility issues for IE11. <br/>- Improve event details page. <br/>- Minor improvements and bug fixes.| [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190901-EventWebsite.zip)
|Sample Event Website| 1.16.0 (August release)|- Improve loading behavior of event page. <br/>- Improve UI/UX of custom registration field of type boolean. <br/>- Minor improvements and bugfixes.| [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190802-EventWebsite.zip)
|Sample Event Website| 1.15.0 (July release)| - Add information to the session list view, if the session is full. <br/>- Add validation to custom registration fields. <br/>- Improve translations. <br/>- Fixing missing font-awesome icons after deploying to Portals. <br/>- Minor improvements and bug fixes.| [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190701-EventWebsite.zip)
| Sample Event Website | 1.14.0 (June release) | Upgrade to Angular 7, improve UI & UX of checkout page, update and improve translations, improve DeployToD365Instance.ps1 script, improve custom registration field validation, other bug fixes | [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190601-EventWebsite.zip) |
| Sample Event Website | 1.13.0 (April release) | Waitlist functionality on session level, UI polishing, bug fixes | [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190401-EventWebsite.zip) |
| Sample Event Website | 1.12.2 (March release) | UI & UX improvements, bug fixes | [Download](https://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/190302-EventWebsite.zip) |

## Environment Configuration parameters

 The **src\environments** folder contains sample configuration files for different environments (self-hosted, portal hosted, development). The configuration set up for the custom event website is made by creating an `environment.ts` file inside the `\src\environments` folder. You can find instructions on how to change the configuration in the related topics [Environment configuration for self-hosted](self-hosted.md) and [Environment configuration for Portal hosted](portal-hosted.md).

Some of the parameters that you need to understand before you start configuring your custom event website:

|Parameter|Description|
|-----|-----|
|**production**| Enables or disables the production mode of the Angular application. More information: [Angular Documentation](https://angular.io/api/core/enableProdMode).|
|**buildVersion** |This field links to the version specified in the `package.json` file by default. There is no need to change this property. However, if you prefer not to expose the version of the application, you can set it to `null`.|
|**apiEndpoint** | The URL that points to the event management API endpoint (which is used to retrieve information of events and to make registrations).|
|**localizationEndpoint** | Points to the URL where the localization files are stored (by default they are stored in the root directory).|
|**imagesEndpoint** | Specifies the base URL from where images are served. This configuration enables you to serve images from a different location which might be required if you want to use a content delivery network or image processing service.|
|**useRestStack** | This setting specifies which API is used. If set to true, then the new event management public API is used. If set to false, then the deprecated event management Portal API is used. This API can only be used if you host the custom event website on Portals. To use the new event management public API, you need to register the web application.|
|**emApplicationtoken**| This token authenticates your web application against the event management public API. You can retrieve the application token by registering a new web application in Dynamics 365 Marketing instance. This token is not required if you're using the deprecated event management Portal API.
|**isAuthenticationEnabled** | This flag specifies whether the user authentication is supported or not (i.e., user can register or sign in). If set to false, then the application doesn't display a way to sign in or register.|
|**useAadB2C** | Specifies whether you want to use **Azure Active Directory B2C identity management** for authentication. If you want to use **Dynamics 365 Portals identity management** then this flag needs to be set to false. If AAD B2C is enabled, then you need to configure the `aadB2CConfig` variable.|
|**aadB2CConfig** | Configuration object used by event management application when **AAD B2C identity management** is enabled. |
|**useMockData** | This setting can be used to return mock objects instead of making real API calls.|

## Backend customization

 System customizer wants to add a new field to the existing event management entity and wants to see that field in the event website. For example if the **custom_new_field** field is added to the **evtmgmt_pass** entity. The passes for the event can be retrieved using the API endpoint `api/v2.0/events/{readableEventId}/passes`, but the result doesn't contain the newly added field.

To expose the new field to be visible in the API, follow the steps below:

1. Open your Dynamics 365 Marketing instance.
1. Open **Advanced Find**
1. Select the **Website Entity Configurations** entity from the dropdown and click on **Results**
1. Click on **New Website Entity Configuration** to create a new record.
1. Enter the name of your choice in the **Name** field.
1. Select the entity that you want an extra field to be visible in the **Selected Entity** field.
1. Write a JSON array that contains the new custom field that should be visible through the API in the **Selected fields**. This exposes the new custom field through the API, and you can utilize it in the frontend.

### See also

[Self-hosted](self-hosted.md)<br />
[Dynamics 365 Portal hosted](portal-hosted.md)<br/>
[Localization](event-portal-localization.md)<br />
[Host your custom event website on Azure](host-custom-event-website-on-azure.md)
