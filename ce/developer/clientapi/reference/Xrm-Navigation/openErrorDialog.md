---
title: "openErrorDialog (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 9749143d-c159-4833-aff9-d8bc2c3395f3
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# openErrorDialog (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/openErrorDialog-description.md](./includes/openErrorDialog-description.md)]

## Syntax

`Xrm.Navigation.openErrorDialog(errorOptions).then(successCallback,errorCallback);`

## Parameters

|Name |Type |Required |Description |
|---|---|---|---|
|errorOptions|Object|Yes|An object to specify the options for error dialog. The object contains the following attributes:<br/>- **details**: (Optional) String. Details about the error. When you specify this, the **Download Log File** button is available in the error message, and clicking it will let users download a text file with the content specified in this attribute.<br/>- **errorCode**: (Optional) Number. The error code. If you just set **errorCode**, the message for the error code is automatically retrieved from the server and displayed in the error dialog. If you specify an invalid **errorCode** value, an error dialog with a default error message is displyed.<br/>- **message**: (Optional) String. The message to be displayed in the error dialog.<br/><br/>You must set either the **errorCode** or **message** attribute. |
|successCallback|function|No|A function to execute when the error dialog is closed.|
|errorCallback|function|No|A function to execute when the operation fails.|

## Example

The following code sample passes an incorrect errorCode (1234) to display an error dialog with default message:

```JavaScript
Xrm.Navigation.openErrorDialog({ errorCode:1234 }).then(
    function (success) {
        console.log(success);        
    },
    function (error) {
        console.log(error);
    });
```

This displays an error dialog with the default message:

![Error dialog with default message](../../../media//clientapi_sampleerrordialog.png)

### Related topics

[Xrm.Navigation](../xrm-navigation.md)

