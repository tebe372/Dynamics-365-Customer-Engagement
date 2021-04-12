---
title: "Create an event-based journey (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a real-time marketing event-based journey in Dynamics 365 Marketing."
ms.date: 04/01/2021
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

# Create an event-based journey

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that is subject to legal or regulatory compliance requirements.

Event-based customer journeys enable you to react to customers’ actions in real time. Journeys can be triggered based on real-world interactions like walking into a store and connecting to Wi-Fi. Journeys can also be triggered by virtual interactions such as visiting a shopping site. The real-time nature of the journey ensures that you can respond to customers immediately and convert their expression of interest into a sale.

## Creating an event-based journey for abandoned cart reminders

To illustrate the capabilities of an event-based journey we will create a personalized, multi-channel event-based journey that can be used to bring prospective buyers with abandoned carts back to your website to complete their purchase.  

## Pre-requisites 

### Create custom event triggers

- Work with your website team to capture the customer's *Abandoned cart* and *Purchase completed* actions as custom event triggers. For more information on creating custom events, see [Real-time event triggers](real-time-marketing-event-triggers.md).
- The *Abandoned cart* event trigger should be raised whenever a customer adds products to the cart but does not complete the purchase.  
- The *Purchase completed* event should be raised whenever a customer completes their purchase. 

### Create email, text and push notification

We will use three touchpoints across various channels to remind customers to complete their purchase.

- **Initial email reminder**: As soon as a customer abandons a cart they will get an email to remind them to complete their purchase.  
- **Second text reminder**: If the customer has not opened their email one day after the initial reminder, then try to reach them via a text message.
- **Final push notification**: If the customer has not completed their purchase one day after the second reminder, send a final push notification.
 
You can build the journey while the content is in *Draft* state. In order to publish and go live with the journey, the content must be in the *Ready to send* state.

## Set the journey start

When creating an event-based journey you can specify the following properties to configure how customers start the journey.

- **Choose an event trigger**: The event trigger that customers must perform to start the journey. We want customers to start the journey when they abandon their cart, so select the *Abandoned cart* event as the event trigger.
- **Repeating this journey**: Lets you specify whether a customer can repeat the journey and how soon can they repeat it if they perform the event trigger again. For an abandoned cart reminder journey this can be *immediately*, as the *Abandoned cart* event is only triggered once for every abandoned cart. For other types of journeys, especially those involving event triggers that are more frequent like visiting a website, you may want to consider adding some delay before letting people repeat the journey.  
- **Start date and time**: Customers can start the journey after only if they perform the event trigger after this start date and time. Select a today's date if you want the journey to start listening to the abandoned cart event trigger immediately after it has been published.  

![Create an event-based journey](media/event-based-journey.png "Create an event-based journey")

Additional configuration for starting the journey can be found in the journey taskpane. See [Real-time marketing journey reference](real-time-marketing-tile-reference.md).  

## Set the journey goal

The goal for this journey is to *drive a purchase*. You can use the *Purcase completed* event trigger to correctly track and capture when users meet this goal. Set the *amount of people needed for this goal* can be set to 50% to indicate you want at least 50% of customers who abandon carts and are targeted by this journey to go on to complete the purchase.
 
![Set the journey goal](media/event-based-journey-goal.png "Set the journey goal")

## Set the journey exit

By default, customers leave the journey when they have completed all the steps. However, you can set additional journey exits by using event triggers. For this journey, you want to make sure you only send the reminder messages if customers have not yet completed their purchase. By setting the journey exit to the *Purchase completed* event you can ensure that the moment any customer completes the purchase they will exit the journey and no longer receive the reminder messages. Setting the journey exit to an event trigger provides an easy way to remove customers who perform the event trigger from the journey helping you ensure customers do not receive irrelevant messages from your customer journey. 

![Set journey exit](media/event-based-journey-exit.png "Set journey exit")

## Add the abandoned cart reminders

Use the plus sign on the journey canvas to add the abandoned cart reminders to your journey.

1. **Send an email** : Select the *Initial email reminder* email that you want to send. For the **Send to** field, select the attribute which contains the email address you want to send the email to.

2. **Add an if/then branch** : In the **Branch off this** field select the preview email *Initial email reminder*. You want to **Wait for** the *Email opened* event trigger. Set the time limit to *1 day*. This if/then branch will check to see if the customer opens the *Initial email reminder* email within one day after it was sent. If the customer opens the email within one day, they will immediately go down the yes branch. If the customer has not opened the email one day after it was sent then they will go down the no branch.

3. **Send a text message** : Under the no branch you can send the *Second text reminder*. For the **Send to** field, select the attribute which contains the phone number you want to send the text message to. This text message will only be sent if the customer did not open the first email message within a day. Since the if/then branch already has a time limit of one day, the text message will be sent one day after the email was sent.

4. **Add a wait** : Add a wait and select *A set amount of time*. Set the duration to *1 day*. This will ensure that customers wait for one day after the text message before moving forward to the next step.

5. **Send a push notification** : As the final step, send the *Final push notification* reminder.

![Abandoned cart journey](media/event-based-abandoned-cart-journey.png "Abandoned cart journey")

## Publish the journey

After adding all the steps to the journey canvas, the journey is ready to go live and message real customers. Before publishing the journey you must make sure all related content - email, text messages or push notifications are in the **Ready to send** state. Any event triggers must also be published and and their code integrated. The journey cannot be modified after its published, so its a good idea to verify all the steps in the journey are exactly how you want them before publishing.

Once the journey is published and live, you can look at [analytics](real-time-marketing-analytics.md) to understand how the journey is performing.
  