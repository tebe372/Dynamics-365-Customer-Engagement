---
title: "logAnalyticsEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the logAnalyticsEvent method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 11/18/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# logAnalyticsEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 

Invoke this method to log analytics for custom events.

## Syntax

`Microsoft.CIFramework.logAnalyticsEvent(data, eventName, correlationId).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required     | Description |
|-----------------|----------|--------------|-------------|
| data            | String   | Yes          | JSON input                               |
| eventName       | String   | Yes          | Name of the event                               |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry. |
| successCallback | Function | No           | A function to call when the promise is successfully returned. |
| errorCallback   | Function | No           | A function to call when the request to return the promise fails. |

The structure of the `data` parameter JSON is shown below. It is mandatory to include these two fields: `conversationId` and `providerSessionId`.

```json
{
	"conversationId": "<Conversation identifier>",
	"providerSessionId": "<Channel Integration Framework Provider Id>",
	"clientSessionId":"<Client session identifier>",
	"participantId":"<Participant identifier>",
	"events": [
		{
			"kpiEventName": "<Name of the associated KPI event>",
			"kpiEventReason": "<Reason due to which the KPI event was created>",
			"eventTimestamp": "<Timestamp at which the event occurred>",
			"additionalData": "<Additional data related to the session>",
			"notificationResponseAction":"<Agent notification response action value>",
			"externalCorrelationId": "<External system correlation Id>",
			"customData": [
				{
					"attribute": "<name>",
					"value": "<value>"
				}
			]
		}
	]
}
```
## Return value

Promise with value as string

### See also

[initLogAnalytics method](./updateconversation.md)<br />
[Channel Analytics](../../channel-analytics.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
