---
title: "Set up a Postman environment (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Learn how to set up and configure a Postman environment that connects with Dynamics 365 for Customer Engagement online and on-premises environments."
ms.custom: 
ms.date: 12/20/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 955BA444-A53D-4843-9429-833B1636E2B4
caps.latest.revision: 7
author: SushantSikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Set up a Postman environment

You can use Postman to connect to your [!INCLUDE[](../../includes/pn-dyn-365.md)] for Customer Engagement apps instance and to compose Web API requests, send them, and view responses. Managing authentication challenges many people. This topic describes how to configure a Postman environment to work for both online and on-premises environments.

You can use a Postman environment to save a set of variables that you use to connect. These values can be accessed within Postman by using this syntax: `{{name}}`. [!INCLUDE[](../../includes/sdk-for-more-info-about.md)] Postman variables, see [Postman Documentation > Variables](https://www.getpostman.com/docs/v6/postman/environments_and_globals/variables).

## Prerequisites

* Have an online or on-premises environment you can connect to. 
* Download and install the [Postman desktop application](https://www.getpostman.com/apps).

Select the connection option that works for your environment: 

* [Connect with an online environment](#bkmk_connectonline)
* [Connect with an on-premises environment](#bkmk_connectonpremise)

<a name="bkmk_connectonline"></a> 

## Connect with an online environment

> [!NOTE]
> This environment uses a client ID for an application that is registered for all Dynamics 365 for Customer Engagement apps online environments. You must register your application using the steps described in [Walkthrough: Register a Dynamics 365 for Customer Engagement app with Azure Active Directory](../walkthrough-register-dynamics-365-app-azure-active-directory.md).

Use these steps to create a Postman environment that you can use to connect with your Dynamics 365 for Customer Engagement apps (online) instance:

1. Launch the Postman desktop application.
1. Select the **Environment Options** gear icon in the top-right corner. 
1. In the **Manage Environments** dialog box, select the **Add** button to add a new environment.
  
  ![Click on Add button to add a new Postman environment](../media/postman-manage-env.png "Click on Add button to add a new Postman       environment")<br>
  
1. In the dialog box that opens, type a name for the environment. Then add the following key-value pairs into the editing space.

    |||
    |----|---|
    |url|`https://<add your environment name, like ‘myorg.crm’>.dynamics.com`|
    |clientid|`51f81489-12ee-4a9e-aaae-a2591f45987d`|
    |version|`9.0`|
    |webapiurl|`{{url}}/api/data/v{{version}}/`|
    |callback|`https://callbackurl`|
    |authurl|`https://login.microsoftonline.com/common/oauth2/authorize?resource={{url}}`|

    ![Create a new Postman environment to connect with Online instance](../media/postman-add-online-env.png "Create a new Postman   environment to connect with Online instance")<br>

1. Replace the instance URL placeholder value with the URL of your Dynamics 365 for Customer Engagement apps instance, and select **Add** to save the environment.

1. Close the **Manage environments** dialog box.  

### Generate an access token to use with your environment

To connect using **OAuth 2.0**, you must have an access token. Use the following steps to get a new access token:

1. Make sure the new environment you created is selected.
1. Select the **Authorization** tab.
1. Set the **Type** to **OAuth 2.0**.
1. Verify that you have selected the environment that you created.
1. Select **Get New Access Token**

    ![In Authorization tab, set Type to OAuth 2.0](../media/postman-set-type.png)<br>
1. Set the following values in the dialog box. Select `Implicit` from the **Grant Type** drop-down menu. You can set the **Token Name** to whatever you like, and leave other keys set to default values.<br>

    ![Get new Access Token](../media/postman-access-token.png "Get new Access Token")<br>

    > [!NOTE]
    > If you are configuring environments in Postman for multiple Dynamics 365 for Customer Engagement apps instances using different user credentials, you might need to delete the cookies cached by Postman. Select the **Cookies** link, which can be found under the **Send** button, and remove the saved cookies from the **Manage Cookies** dialog box.<br>![Remove Cookies](../media/postman-cookies.png "Remove Cookies")<br>
    > Some of these cookies are very persistent. You can delete some of them in groups, but you might have to delete others individually.   You might need to do this twice to ensure that no cookies remain.

1. Select **Request Token**. When you do this, an Azure Active Directory sign-in page appears. Enter your username and password.
1. After the token is generated, scroll to the bottom and select **Use Token**. This closes the **Manage Access Tokens** dialog box. 
1. After you have added a token, you can select which token to apply to requests. On the **Available Tokens** drop-down list, select the token you have just created. The Authorization header gets added to the Web API request.


See [Test your connection](#test-your-connection) for steps to verify your connection.

<a name="bkmk_connectonpremise"></a>

## Connect with an on-premises environment

1. Launch the Postman desktop application.
2. Select the **Environment Options** gear icon in the top-right corner. 
3. In the **Manage Environments** dialog box, select the **Add** button to add a new environment.
4. In the dialog box that opens, add a name for the environment. Then copy the following key-value pairs into the editing space.

  |||
  |----|---|
  |url|`http://yourservername/yourorgname`|
  |version|`8.2`|
  |webapiurl|`{{url}}/api/data/v{{version}}/`|

  ![Create a new Postman environment to connect with On-premise instance](../media/postman-add-onprem-env.png "Create a new Postman   environment to connect with On-premise instance")

5. Replace the instance URL placeholder value with your Dynamics 365 for Customer Engagement apps instance URL, and select **Add** to save the environment.
6. Close the **Manage environments** dialog box.

### Set credentials

1. On the Authorization tab, select **NTLM Authentication [Beta]**.
1. Set the following values in the form:<br>
•	**Username**.  Type the alias only; do not include the domain.<br>
•	**Password**. You have the option to show the password.<br>
•	**Domain**. You must set this if you are accessing the account from a different domain, although you can set it to **~** so that the default domain of the server is used.<br>

Your authentication might look like this if you are logging in as an administrator.<br>

![Click on Authorization tab, and select NTLM Authentication](../media/postman-ntlm-auth.png "Click on Authorization tab, and select NTLM Authentication")



## Test your connection

Create a new Web API request to test the connection with your Dynamics 365 for Customer Engagement apps instance. Use the <xref href="Microsoft.Dynamics.CRM.WhoAmI?text=WhoAmI function" />:
1. Select `GET` as the HTTP method and add `{{webapiurl}}WhoAmI` in the editing space.
  ![WhoAmI function request](../media/postman-whoami-request.png "WhoAmI function request")
2. Select **Send** to send this request.
3. If your request is successful, you see the data from the <xref href="Microsoft.Dynamics.CRM.WhoAmIResponse?text=WhoAmIResponse ComplexType" /> that is returned by the <xref href="Microsoft.Dynamics.CRM.WhoAmI?text=WhoAmI Function" />.

## See also

[Use Postman to perform operations](use-postman-perform-operations.md)<br>
[Use the Dynamics 365 for Customer Engagement Web API](../use-microsoft-dynamics-365-web-api.md)<br>
[Walkthrough: Register a Dynamics 365 for Customer Engagement app with Azure Active Directory](../walkthrough-register-dynamics-365-app-azure-active-directory.md)
