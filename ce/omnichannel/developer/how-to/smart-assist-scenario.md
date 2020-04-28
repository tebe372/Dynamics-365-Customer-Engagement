---
title: "Implement a custom scenario for smart assist bot | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 04/25/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Implement a custom scenario for smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

This topic provides information on how you can enable similar case suggestions in your smart assist bot.

## Prerequisites

> [!IMPORTANT]
> Read the topic [Build a smart assist bot](smart-assist-bot.md) for information on how to get started with building a custom smart assist bot. 

- You need to have an understanding on how to create a bot using [Azure Bot Service](https://docs.microsoft.com/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0). <!--When you register your bot with Azure Bot Service, you will obtain `Microsoft App ID` and `Client secret` which you will need to update the `appsettings.json` file in the bot.-->
- Create a LUIS app by following the instructions mentioned in [Add natural language understanding to your bot](https://docs.microsoft.com/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp). See the section [Retrieve application information from the LUIS.ai portal](https://docs.microsoft.com/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=csharp#retrieve-application-information-from-the-luisai-portal) for information on how to retrieve the values you need to setup the bot.

## Scenario: Similar case suggestion

This scenario enables you to suggest similar cases with open case action button. The customer service agent is presented with a list of similar cases as a recommendation. The agent clicks on the case that he finds most similar and relevant, and then goes to the case note and looks at the resolution in note. The agent suggests the same resolution to the customer over chat.

### Generate intent to interpret the context of the conversation

It is necessary analyze the conversation and understand its context before recommending an action to the agent. Use [Language Understanding (LUIS)](https://luis.ai) to find the intent of the ongoing conversation. Here is an example on how you can create a LUIS app to find intent from a given text: [Quickstart: Use prebuilt Home automation app](/azure/cognitive-services/luis/luis-get-started-create-app).

You can create intents for each issue type or topic that you want to address for incoming requests from customers or the most common topics being discussed.  

For the example scenario of similar case recommendations for ‘printer noise’ issue, create an intent with the same name and add 10-15 examples like ‘printer noise, loud noise from printer, printer making grinding noise, loud clicking noise, loud sound’ etc. The LUIS app then needs to be trained for this intent.  

### Author adaptive cards to display recommendations in the smart assist UI

[Adaptive cards](https://adaptivecards.io) is an open-source standard that helps apps and services exchange rich snippets of native UI.<!-- The smart assist bot interprets the conversation context in real-time and provides recommendations to the agents. -->

### Custom actions for implementing custom functionalities

Custom actions can help you implement custom functionalities in your smart assist bot.

Given below are the steps for enabling the similar case scenario.

1. **Set up Similarity Rules**

Setup similarity rule by following the steps 1 to 7 in mentioned here: [Create a new similarity rule to view similar cases](https://docs.microsoft.com/dynamics365/customer-service/suggest-similar-cases-for-a-case#create-a-new-similarity-rule-to-view-similar-cases).
 
2. **Turn Relevance search ON**

Turn On Relevance Search in the administrator section. More information: [Enable a field for exact matching of similar cases](https://docs.microsoft.com/dynamics365/customer-service/suggest-similar-cases-for-a-case#enable-a-field-for-exact-matching-of-similar-cases). 
  
3. **Similar cases API**

Similar cases can be fetched using the `GetSimilarRecords` function. But before you execute the Web API query with this function, make sure that you have set up similarity rules. More information: [Use advanced similarity rules to view similar case suggestions](https://docs.microsoft.com/dynamics365/customer-service/suggest-similar-cases-for-a-case). Also, make sure to enable **Relevance Search** in the administrator section to ensure that similarity rules work in the expected manner. Also, in the **Match Field** section add a few criteria such as case title and case type.

**Request**

```http
GET [Organization URI]/api/data/v9.1/GetSimilarRecords(Id=@Id,Filter=@Filter,ReturnFields=@ReturnFields)?@Id={"@odata.id":"incidents(<incident id>)"}&@Filter=null&@ReturnFields={"AllColumns":false,"Columns":["title","description"]}
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0 
```

Replace the `incident id` in the Web API request above with the unique identifier of the case for which you want to find similar cases.

**Response**

```json
{
    "@odata.context": "[Organization URI]/api/data/v9.1/$metadata#incidents",
    "value": [
        {
            "@odata.type": "#Microsoft.Dynamics.CRM.incident",
            "@odata.etag": "W/\"1571835\"",
            "title": "Product question re warranty",
            "modifiedon": "2019-03-03T12:58:25Z",
            "incidentid": "f69e62a8-90df-e311-9565-a45d36fc5fe8"
        },
        {
            "@odata.type": "#Microsoft.Dynamics.CRM.incident",
            "@odata.etag": "W/\"1572750\"",
            "title": "Shipment question re order",
            "modifiedon": "2019-03-03T12:58:27Z",
            "incidentid": "129f62a8-90df-e311-9565-a45d36fc5fe8"
        }
    ]
}
```

<!--The custom actions required for implementing similar case suggestions include the following:

1. Open any entity form using the [openForm](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-navigation/openform) client API.
2. Copy to Conversation Control.
3. Open th URL in App tab.
-->
#### Calling custom actions using adaptive cards

<!--### Macros

Macros are a compilations of sequential actions that are reusable for different sessions. These can be used to automate repetitive and monotonous actions that in turn reduce human errors and improve agent productivity. For information on how to build a macro, see [Create macro](../../administrator/macros.md#create-macro).

You can use the `actions` key in adaptive cards JSON and mention the macro or custom action that you want to call, as shown in the example below.

The type is always `Action.Submit` and title can be anything the user wants to name the action.

```json
"actions": [
		{
			"type": "Action.Submit",
			"title": "Accepted",
			"data": {
				"MacroName": "SendEmail",
				"MacroParameters": {
					"subject": "Upgrade offer"
				}
			},
			"iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
		}
	]
```

See also: [Automate tasks with macros](../../administrator/macros.md).
-->
You will have to create a web resource if you want to use embed a custom action within a suggestion. See the Power Apps topic on [Create your own actions](/powerapps/developer/common-data-service/custom-actions) for information on how to build a custom action. See the topic [Web resources in model-driven apps](/powerapps/maker/model-driven-apps/create-edit-web-resources) for information on how to create web resources. These web resources will have to be uploaded under the **Customer Summary Form**, as shown in the screenshot below.

<!--Macros are a compilations of sequential actions that are reusable for different sessions. These can be used to automate repetitive and monotonous actions that in turn reduce human errors and improve agent productivity. For information on how to build a macro, see [Create macro](../../administrator/macros.md#create-a-macro).
-->
![Customer summary form](../../media/conversation-entity-customer-summary.png "Customer summary form")

<!--To use a custom action, replace `MacroName` and `MacroParameters` with `CustomAction` and `CustomParameters` respectively in the adaptive card JSON. The value provided for `CustomAction` key should be the same as the name of the method that is to be called.

```json
"actions": [
		{
			"type": "Action.Submit",
			"title": "Accepted",
			"data": {
				"CustomAction": "SendEmail",
				"CustomParameters": {
					"subject": "Upgrade offer"
				}
			},
			"iconUrl": "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAANCAYAAACZ3F9/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE8SURBVHgBnVLBUQJBEOxd1z8BALWgAWAEagSQAfLw5CdEIBkIP+UeEoIZyGUAAchtnVT55cXDu5txDrkqQKHUeexu7Uz3dO8OrBc18I/QWul6xYtC682bfwGq6nV0xazqSqkFg63sE9LxwD1U3MGOdJSOoVCY+cUWx6YFpqmm45fqTfRk26Hd2zFbqt48pI/4zI0qizyxUqJVU1NWxYPXYfl5q+MaPoYxtc3EzC+PwsfSZWrQY/7+Dipnl+M9xOc+aWAuZJYYmDCha7766nMibrhhMditt52woJemI6RNqekjSQaZJbNmqyFOppuA0/bbhTDf0lJyjD7F229gbPvdcpogv1wBGHdpKnxAz/nl4Cfl6kQmhxXqIDUROR35jjFBjZxfCnAgDMvkQPwRw2FHzkEgiAKK0+5vAXl8ArWLn19rFeLfAAAAAElFTkSuQmCC"
		}
	]
```
-->
<!--
Consider the scenario wherein you want the smart assist bot to be able to search and recommend knowledge base articles. The actions required are given below.

**Open knowledge base article**

This action opens knowledge base article in an app tab in edit mode or opens up a knowledge base form.
-->

Given below are the supported custom actions.

**OpenForm custom action**

This custom action enables you to open any entity record.

```json
{
              "type": "Action.Submit",
              "title": "Open",
              "data": {
                             "CustomAction": "OpenForm",
                             "CustomParameters": {
                                           "entityName": "incident",
                                           "entityId": "c3356c37-bba6-4067-b1a1-8c66e1c203a1",
                                           "data": {}
                             }
              }
}
```

**SendKB custom action**

This custom action enables you to send a knowledge base article. <!--It copies the knowledge base article URL to Conversation Control, which is then sent to the customer when the agent clicks on send button.-->
<!--
The custom actions required for implementing knowledge base search in the smart assist bot include the following:

1. Open any entity form using the [openForm](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-navigation/openform) client API.
2. Copy to Conversation Control.
3. Open th URL in App tab.
-->

> [!NOTE]
> The `CustomAction` key should contain `SendKB` and `kbLink` key should contain the link of the KB article. You cannot have another custom action with the same name as `SendKB`.

```json
{

          "type": "Action.Submit",
          "title": "Send",
          "data": {
                          "CustomAction": "SendKB",
                          "CustomParameters": {
                          "kbLink": "https://ocddemoebc.powerappsportals.com/knowledgebase/article/KA-01011/en-us"
                  }
          }
}
```

You can use the client-side APIs to open knowledge base articles. See [Client API reference for model driven apps](/powerapps/developer/model-driven-apps/clientapi/reference) for more information.

<!--## Samples for adaptive cards

Based on the intent extracted from an ongoing conversation, you can provide appropriate recommendations to the agent using adaptive cards. This section covers some examples for adaptive cards that can be used for various scenarios. You can use the [Adaptive Cards Designer](https://adaptivecards.io/designer/) to create your own adaptive card template.
-->

## See also

[Build a smart assist bot](smart-assist-bot.md)<br />
[Sample code: Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot)<br />
[Smart assist for agents](../../administrator/smart-assist.md)