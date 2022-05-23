---
title: "Experiment and refine real-time marketing journeys (Dynamics 365 Marketing) | Microsoft Docs"
description: "Experiment and refine real-time marketing journeys in Dynamics 365 Marketing."
ms.date: 12/06/2021

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

# Experiment and refine real-time marketing journeys

Real-time marketing in Dynamics 365 Marketing uses powerful A/B tests to examine your trigger-based customer journeys, allowing you to gain insights into how best to reach your customers.

Using A/B tests, you can measure which channel or content messaging strategy leads to higher success. Each test compares a control group of users (version A) against a variant (version B). The control group receives a default experience. The variant group receives a different experience or message. By comparing the results of the groups, you can determine which is the most effective.

The journey usually will run the entire test automatically. The test starts by sending versions A and B to a small part of your audience as they funnel through the journey. The journey then analyzes the interaction results and chooses a winner based on your selected criteria (click through, open rate, or journey goal). The journey then sends the winning version to the rest of your audience automatically.

## Creating and adding an A/B test:

1. Create your initial content [in the email editor](real-time-marketing-email.md), as usual. Perfect the content and be sure to check it for errors to make sure it can go live.
1. When your content is ready, go to **Real-time marketing** > **Customer engagement** > **Journeys** and select an existing journey or create a new one.
1. After you select a journey, select the plus sign (**+**) to add an element, and then do the following:
    - Select the **Test message or channels against each other** element in the dialog.
    - Choose which channel you want to test in version A and version B, and then select **Create test**.
1. A side pane titled **A/B test** will open. Enter the following information in the side pane:

    > [!div class="mx-imgBorder"]
    > ![A/B test side panel.](media/real-time-marketing-abtest-sidepane.png "A/B test side panel")

    - **Display name**: To identify your test, enter a name for it. This name is displayed in the A/B test panel and in the customer journey analytics when you are looking at which tests are running. Once the journey is live, you cannot rename your test.  
    - **Versions**: Pick the content for the channel you prepared in step 1. You can do this through a dropdown list by either selecting the child tiles in the journey builder, or by making a selection on the side panel.
    - **Audience**: Choose the audience distribution you would like. The slider is automatically on 50-50, but you can set the slider to your desired distribution. The minimum a version can receive is 10 percent, and the maximum is 90 percent. Remember that, traditionally, version A is your control group and version B is your variant.
    - **Winning metric**: You can set the winning condition for your test by choosing a winning metric: The version with the most journey goal events hit, the most clicks, or the most opens.  
    - **This test ends**: You can also choose between ending the test automatically or at a specific date and time. For best results, we recommend letting the test determine a winner automatically when the results reach statistical significance. Once a clear winner is determined, the system will send the winning version to the rest of your audience. The losing version will be discarded.
    - **Default version**: Lastly, choose a default version in case the test doesn't end successfully. In cases where a winner has not been determined by the deadline specified through the date and time, the default version is automatically sent.
1. Finish setting up your journey as usual and then go live.

> [!NOTE]
> You can add up to five tests per journey by repeating the steps above. You can test similar channels (email A versus email B) or test different channels (email versus text message).

## Monitor the lifecycle of your A/B tests

After you have published your journey, you can open it to track the lifecycle of your tests.

- **Draft**: These tests haven't run yet, so you can still edit the settings.
- **In progress**: These tests are currently being run. The settings are locked and you can’t make significant changes.  
- **Stopped**: Theses tests are stopped and the marketer can choose which version to send.
- **Ended**: These are tests were completed by finding a statistically significant winner or by timing out when scheduled to end at a set date and time. Ended tests cannot be reused.

## Understand your results

There are three possible A/B test result outcomes:

- **Test concluded with a clear winner**: The test concluded that one version is performing better than the other. The winning version has a “winner” badge and is distributed to any new customers that funnel through the journey.
- **Test was not conclusive**: The test concluded that recipients are as likely to engage with version A as with version B. In this case, the default version is sent to any new customers that funnel through the journey.
- **The test was stopped**: This means that you or one of your coworkers stopped the test before it could conclude. In this case, the version specified by you or your coworker is sent to any new customers that funnel through the journey.

### See also

[Create real-time marketing emails](real-time-marketing-email.md)  
