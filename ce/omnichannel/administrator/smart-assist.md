---
title: "Assist agents with next-best steps | MicrosoftDocs"
description: "Learn about how to smartly assist agents with the next-best steps in the Omnichannel Administrator app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 203CB28E-C1AF-4A0E-820B-55563A6AD45C
ms.custom: 
---

# Preview: Assist agents with next-best steps

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview of smart assist

In the customer service industry, often agents lack of real-time insights to understand and take a next-best course of action that caters to the needs of the customer. The lack of real-time insights makes the agent to spend more time to provide an appropriate solution leading to an increase in the Average Handling Time (AHT) and decrease in the customer satisfaction.

Smart assist provides suggestions such as Knowledge articles and similar cases to agents on what is the next-best course of action they need to take based on the real-time context of the customer interaction. The suggestions are intelligent and helps the agents to be more productive with knowledge articles, similar cases, and much more. 

The smart assist feature provides uniform suggestion across the channels like Chat for Dynamics 365 Customer Service, SMS, and Facebook making it a consistent and an intelligent experience for agents.

## Value proposition

- Contextual suggestions based on the real-time context.
 
- Intelligent and action-oriented suggestions for agents to send responses or execute the automated actions.

- Improved Average Handling Time (AHT) and First Call Resolution (FCR).

## Pre-requisites

- Install Dynamics 365 Productivity Tools solutions

- Develop a custom bot and integrate with Omnichannel for Customer Service app to use the Smart Assist feature.

## Walkthrough to enable smart assist

[Step 1: Develop a smart assist bot](#step-1-develop-a-custom-smart-assist-bot)

[Step 2: Integrate smart assist bot](#step-2-integrate-smart-assist-bot)

[Step 3: Add smart assist bot to workstream](#step-3-add-smart-assist-bot-to-a-workstream)

[Step 4: Add smart assist control to form](#step-4-add-smart-assist-control-to-a-form)

## Step 1: Develop a custom smart assist bot

Develop a custom bot and integrate with Omnichannel for Customer Service app to use the Smart Assist feature. 

### Purpose of smart assist bot

The smart assist bot interprets the conversation context in real-time and provides suggestions to the agents. The smart assist bot sends the suggestions using the [Microsoft Adaptive cards](https://docs.microsoft.com/adaptive-cards/). 

You can embed macros and custom actions within a suggestion with the of use web resources.

For example:

**Custom action:** An agent is displayed with a Knowledge article card with a **Send Link** button. You can implement a custom action to copy and paste the link in the communication panel when agent selects the **Send Link** button.

**Macro:**: An agent is displayed with a Create Case card. You can implement a macro with the card to open a new form to create a case when an agent selects the **Create case** button on the card. While developing the Adaptive cards, you need to specify the name of the macro.

To learn more, see [Smart assist bot](../developer/smart-assist-bot.md)

## Step 2: Integrate smart assist bot

## Step 3: Add smart assist bot to a workstream

After you integrate the smart assist bot with the omnichannel system, you need to add the bot to the workstream so that the agents who are part of this workstream can see the suggestions.

1. Sign in to Omnichannel Administrator app

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a workstream for which you want to add the smart assist bot.

4. Select the **Smart Assist** tab.

5. Select **+ Add Existing** in the **Smart Assist** section. The **Lookup Records** pane appears.

6. Select the search icon to see the list of available smart assist bots, and select a bot from the list, and then select **Add**. <br> You can multiple bots to a workstream based on your business requirement.

7. Select **Save** the workstream changes.
 
## Step 4: Add smart assist control to a form

After you add the smart assist bot to a workstream, you must add the smart assist field to the form where you want to show it for the agents.

1. Sign in to the Common Data Service platform.

2. Select **Settings** > **Customizations** > **Customize the System**. **Solution Explorer** opens in a new window.

3. Expand **Entities** and select the entity for which you want to add the field. In this procedure, let us add to the **Customer Summary** form in the **Conversation** entity.

4. Expand **Conversation** > **Forms** > **Customer Summary**. The **Customer Summary** form opens in a new window.

5. Select **INSERT** tab from the command bar, and then select **Section** > **One Column** in the command bar.

    > [!div class=mx-imgBorder] 
    > ![Add section](../media/agent-script-control5.png "Add section")

6. Select the section, and then select **Change Properties** from the command bar. The **Section Properties** dialog appears.

7. Specify **Smart Assist** as the value for both **Name** and **Label** field.

8. Select the **Show the label of this section on the Form**  check box, and then select **OK**.

    > [!div class=mx-imgBorder] 
    > ![Add name and show label](../media/smart-assist-control8.png "Add name and show label")

9. Select a field of type **Text** from **Field Explorer**. For example, the **Title** field is of type **Text**. If you hover the cursor on a field, you can view the type.

    > [!div class=mx-imgBorder] 
    > ![Add field of type Text](../media/agent-script-control9.png "Add field of type Text")

10. Drag and drop the **Title** field to the section you added in earlier step.

11. Select the **Title** field in the **Smart Assist** section, and then select **Change Properties** from the command bar. The **Field Properties** dialog appears.

12. Clear the **Display the label on the form** check box in the **Display** tab.

    > [!div class=mx-imgBorder] 
    > ![Clear display label](../media/agent-script-control12.png "Clear display label")

13. Select the **Controls** tab in the **Field Properties** dialog, and then select **Add Control**.

    > [!div class=mx-imgBorder] 
    > ![Add smart assist control](../media/agent-script-control13.png "Add smart assist control")

14. Select **Smart Assist control** in the **Add Control** dialog, and then select **Add**.

15. Choose the **Web** radio button for the **Smart Assist control** option, and then select **OK**.

    > [!div class=mx-imgBorder] 
    > ![Choose web option](../media/smart-assist-control15.png "Choose web option")

16. Select **Save** to save the changes.

17. Select **Publish** to publish the customizations.

## See also
 
[Macros](macros.md)

[Agent scripts](agent-scripts.md)