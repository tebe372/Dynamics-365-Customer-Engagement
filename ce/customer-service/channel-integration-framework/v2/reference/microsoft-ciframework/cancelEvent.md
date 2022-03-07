---
title: "cancelEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about cancelEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 03/08/2022
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# cancelEvent (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

Hides a notification based on the cancellation ID.

## Syntax

`Microsoft.CIFramework.notifyEvent(cancellationToken, correlationId).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required     | Description     |
|-----------------|----------|--------------|-----------------|
| cancellationToken| String  | Yes       | JSON input      |
| correlationId   | GUID     | No           | Used to group all related API calls together for diagnostic telemetry.          |
| successCallback | Function | No           | On success callback, response object will have the information about whether customer selected Accept or Reject. |
| errorCallback   | Function | No           | A function to call when the operation fails.  |

## Callback function details

The following objects are passed into successCallback and errorCallback functions.

### successCallback function

Sample JSON object:

```json
{
	"value": {"actionName" : "Accept",
     "responseReason" : "Accept"}
}
```

**Parameters**

| actionName   |  responseReason                    |     Description                            |
|--------------|------------------------------------|--------------------------------------------|
| Accept       | Accept                             | When user accepts the notification  |
| Accept       | AutoAccept                         | The notification is accepted by default via a notification template |
| Reject       | DeclinedByAgent                    | When user rejects the notification |
| Reject       | NotificationQueueLimitExceeded     | The notification is rejected if the limit exceeds ten notifications in the queue |
| Reject       | NotificationQueueTimeLimitExceeded | When a notification in the queue exceeds the configured timeout period |
| Timeout      | DisplayTimeout                     | When user doesn't respond to the notification within the timeout period |

### errorCallback function

Sample JSON object:

```json
{
	"message" : "<error details>",
	"msdyn_name" : "NotifyEvent"
}
```

**Parameters**

| message                          |  Description                            |
|-------------------------------   |-----------------------------------------|
| NotificationTemplateNotFoundError | When the specified template name is not found |
| RejectAfterClientError            | An unknown exception occurred (occurs when the Platform API call fails or some input parameter is missing) |

## Example

```javascript
var input = {
	templateName: "msdyn_chat_incoming_unauthenticated",
	// unique name of the configured template
	templateParameters: {
	}
}
Microsoft.CIFramework.notifyEvent(input).then(
	function success(result) {
		console.log(result);
		// Perform operations
	},
	function (error) {
		console.log(error.message);
		// Handle error conditions
	}
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
