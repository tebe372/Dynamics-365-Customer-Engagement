---
title: "Connect to a new Azure resource | MicrosoftDocs"
description: "Use this article to understand how to connect to Azure Communication Services using a new Azure resource in Customer Service admin center."
ms.date: 05/27/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---
# Quickstart: Connect to a new Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

In the voice channel, you can quickly connect to Azure Communication Services, provision phone numbers, and set up outbound and inbound calling for your business by creating and deploying a new Azure resource.

## Prerequisites

Before you connect an Azure resource to Azure Communication Services, you must have the following details.

- An Azure subscription that's in the same tenant as your Dynamics 365 account. Ensure that your Azure subscription meets the [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability) requirements.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You'll be able to deploy your Azure Communication Services resource only if you have contributor-level permissions.
- If you're [using a trial phone number](voice-channel-manage-phone-numbers.md#use-trial-phone-number), you must end the trial to be able to see the options to connect to a new Azure resource.

> [!Important]
> 
> On the **Phone numbers** page, the **Get started** button to connect to a new Azure resource will appear only in the following scenarios.
> - The trial has ended after the free calling time has elapsed.
> - You've manually ended the trial.
> - You've [disconnected from the Azure resource](voice-channel-acs-resource.md#disconnect-from-azure-communication-services-resource).

## Connect to a new Azure resource

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   - In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**. 

1. Select **Get started**. The **Connect to Azure Communication Services** dialog opens.
1. Select **Create new resource** and enter the following details.
   - **Azure subscription**: Select a subscription from the dropdown list.
   - **Azure resource group**: Select an existing resource group or select **Create new**, and enter a name for a new resource group.
      > [!NOTE]
      > The resource group name should be unique within a subscription.
   - **Resource name**: Enter a name for the resource. The resource name can contain only letters, numbers, and hyphens.
1. Select **Deploy** to create and deploy the resource.

Your new Azure resource is connected to Azure Communication Services. You can now [acquire new phone numbers](voice-channel-manage-phone-numbers.md) for your organization via the new resource and also [enable recording and SMS services](voice-channel-sub-endpoints.md).

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-route-queues.md) 
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Enable recording and SMS services](voice-channel-sub-endpoints.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
