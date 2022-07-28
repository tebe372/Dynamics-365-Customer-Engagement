---
title: "Connect using an existing Azure resource | MicrosoftDocs"
description: "Use this article to understand how to connect to Azure Communication Services using an existing Azure resource."
ms.date: 06/09/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Advanced: Connect using an existing Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can use an existing Azure resource from any of your Azure subscriptions, *available under any tenant*, to connect with voice or SMS channels. If you had previously disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

Before you connect an existing Azure resource to Azure Communication Services, you must perform the following steps.

- Check whether the **Get started** button to connect to an existing Azure resource is visible on the **Phone numbers** page. The **Get Started** button appears only in the following scenarios.
    - The trial has ended after the free calling time has elapsed.
    - You've manually ended the trial.
    - You've disconnected from the Azure resource. More information: [Disconnect from Azure Communication Services resource](voice-channel-disconnect-from-acs.md)
- Get the name and ID of your Azure resource from the Azure portal.
   To get the resource name and ID, open your resource on the Azure portal, go to **Settings** > **Properties**. Note the values of the **Id** and **Resource name** fields.
- Get the connection string of your Azure resource from the Azure portal. More information: [Access your connection string and endpoints](/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp#access-your-connection-strings-and-service-endpoints)
- Get the application (client) ID and tenant (directory) ID for your registered app. More information: [Get application and tenant IDs](#get-application-and-tenant-ids)

## Connect using an existing Azure resource

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.    
    2. Select **Manage** for **Phone numbers**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
   In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**. The **Connect to Azure Communication Services** dialog opens.
2. Select **Use existing resource**.
3. In the **Use existing resource** dialog, fill in the following fields using the resource details retrieved from the Azure portal.
   - **ACS Resource Name**: Enter the resource name.
   - **ACS Resource ID**: Enter the resource ID.
   - **Connection string**: Enter the connection string.
   - **Event grid app ID**: Enter the application (client) ID.
   - **Event grid app tenant ID**: Enter the tenant (directory) ID.
4. Select **Connect**. Your existing resource is now connected to Azure Communication Services.
5. Select **Add number**. The **Add phone number** page is displayed.
6. Add a new phone number. More information: [Acquire new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers)

You can now configure the voice workstream settings for the phone number, set up inbound and outbound calling, and also enable recording and SMS services.

### Enable recording and SMS services

Azure Communication Services integrates with Azure Event Grid to send real-time event notifications for chat, telephony, SMS, video, and voice-calling events. The Azure Event Grid, in turn, uses event subscriptions to route event messages to subscribers. More information: [Event Grid](/azure/event-grid/overview)

So, to enable voice recording and SMS services, you must configure your applications to listen to Azure Communication Services events by registering event grid system topics, and then subscribe to the specific recording or SMS events by creating Event Grid subscriptions on the Azure portal. More information: [System topics in Azure Event Grid](/azure/event-grid/system-topics)

> [!Note]
> - When you connect your event subscription, you must use the same application ID and directory ID for the app registration as you did when you first connected to your Azure resource. To check which app ID and directory ID you used, select the filter icon in the top right and search for communication provider setting entries.
> - You can only set one web hook endpoint at a time using the following procedure, so if you'd like to enable both the services, you must run the procedure two times to set the respective web hook endpoints.

1. Open the **Event Grid System Topics** service on the Azure portal.
2. Create and deploy an event grid system topic. More information: [Create a system topic](/azure/event-grid/create-view-manage-system-topics#create-a-system-topic)
3. On the **Event Grid System Topic** page that's created, select the **Subscription** link.
4. In the resource subscription page, select **Settings** > **Resource providers**, and then check if the **Microsoft.EventGrid** provider is listed as **Registered**. If the event grid is not registered, select the record, and then select **Re-register** to register it.
5. Open the resource on the Azure portal, go to **Events**, and select **Event Subscription**.
6. In the **Create Event Subscription** dialog, enter the following details in the **Basic** tab.
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** from the dropdown list.
    - **Topic Types**: Select **Azure Communication Services** from the dropdown list.
    - **Subscription**: Select your subscription from the dropdown list.
    - **Resource Group**: Select the resource group.
    - **Resource**: Select the resource.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the dropdown.
    - **Filter to Event Types**: For recording services, select the **Recording File Status Updated (Preview)** option from the dropdown list.
    - **Endpoint Type**: Select **Web Hook** from the dropdown list.
    - **Endpoint**: Select **Select an endpoint** and in the **Select Web Hook** dialog that opens, enter the recording or SMS web hook endpoint as follows.
        - To enable recording services, get the **Recording Web Hook Endpoint** and paste the value in the **Subscriber Endpoint** field, and select **Confirm Selection**. More information: [Get the Recording Web Hook Endpoint](#get-the-subscriber-endpoint-for-recording)
        - To enable SMS services, get the **SMS Web Hook Endpoint** and paste the value in the **Subscriber Endpoint** field, and select **Confirm Selection**. More information: [Get the SMS Web Hook Endpoint](#get-the-subscriber-endpoint-for-sms)
7. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
   - **AAD Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
   - **AAD Application ID or URI**: Enter the application (client) ID of your Azure resource.
8. Select **Create** to create the event subscription endpoint for recording. This might take some time, so if you get a sync error, try refreshing after some time.

For information about enabling call recordings and transcripts for a voice workstream in Omnichannel for Customer Service, see [Configure call recordings and transcripts](voice-channel-configure-transcripts.md).

#### Get application and tenant IDs

1. Open the **App registrations** page on the Azure portal in a separate window or tab.
    If you're registering your app on the Azure portal for the first time, then do the following.
    1. On the **Register an application** page, enter the following details.
        - **Name**: Enter a name for your application.
        - **Supported account types**: Select **Accounts in any organizational directory (Any Azure AD directory - Multitenant)**.
    2. Select **Register**.
2. Select the value of the **Application (client) ID** field, select the **Copy to clipboard** button, and then note the value.
3. Select the value of the **Directory (tenant) ID** field, select the **Copy to clipboard** button, and then note the value.

#### Get the subscriber endpoint for recording

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    2. Select **Manage** for **Phone numbers**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**. 
2. In the **Phone numbers** page that opens, select a phone number, and then select **Advanced**.
3. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **Recording Web Hook Endpoint** and note the value.

#### Get the subscriber endpoint for SMS

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
   In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**.
2. In the **Phone numbers** page that opens, select a phone number, and then select **Advanced**.
3. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **SMS Web Hook Endpoint** and note the value.


### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-route-queues.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]