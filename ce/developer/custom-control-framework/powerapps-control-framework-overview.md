---
title: "PowerApps Control Framework Overview for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "The topic provides PowerApps Control for Dynamics 365 Customer Engagement."
ms.date: 01/12/2018
ms.service: "crm-online"
ms.topic: "index-page"
ms.assetid: 135481cd-4583-4e49-8f58-02f32a9b054a
applies_to: 
  - "Dynamics 365 (online)"
author: ""
ms.author: "nabuthuk"
manager: "jdaly"
---
# PowerApps Control Framework Overview

[!INCLUDE [cc_applies_to_update_9_0_0](../../includes/cc_applies_to_update_9_0_0.md)]

Use the **PowerApps Control Framework (PCF)** to create custom controls to provide enhanced experiences for people to view and work with data in forms, views, and dashboards. For example: 
-	Replace a field that displays a numeric text value with a dial or slider control. 
- Transform a list into an entirely different visual experience bound to the data set like a “Calendar” or “Map”.

Majority of the controls found in model-driven apps that use the **Unified Interface** are implemented using PCF. Custom controls are metadata driven, configurable, reusable, solution aware and responsive. As a developer, you will implement an interface and the application will take care of the rest.

> [!NOTE] 
> Custom controls are supported only on Unified Interface. 

## What are custom controls?

Custom controls are a type of solution component, which means they can be included in a solution and installed in different environments. More information: Package and distribute extensions using solutions.

Custom controls created using PCF enable a developer to add custom visualization and logic for various UI elements. You can view custom controls in the solution explorer, but there is no way to add or edit them in the application. 

You add custom controls by including them in a solution and then importing it into the system. Once they are in the system, customizers can configure form fields, sub-grids, views, and dashboard sub-grids to use them in place of default controls. 

Data about custom controls is stored in the *CustomControl* and *CustomControlResource* entities. 
The CustomControl entity has the following important attributes:


|Attribute  |	Description|
|---|---|
|Manifest |An XML document describing application metadata about the control|
|Name | The name of the control described in the manifest| 
|Version |	The version number of the control described in the manifest|

The *CustomControlResource* entity is related to the *CustomControl* entity to provide details about the resources used by the control. The *CustomControlResource.WebResourceId* attribute contains the value of the *WebResource.WebResourceId* for the *WebResource* entity record that will contain the definition of the resource used by the custom control.

### Manifest
The manifest is the metadata file that defines a control. It is an XML document that describes:
- The namespace of the control.
- The kind of data it can be bound to, either a field or a data-set.
- Any properties that can be configured in the application when the control is added.
- A list of web resource files that the control needs. 
  - One of them must be a JavaScript web resource. This JavaScript must include a function that will instantiate an object. This implements an interface that exposes methods that are required for the control to work. This is called the control implementation library.
- The name of a JavaScript function in the control implementation library that will return an object that applies the required control interface. 

When someone configures a control in the application, the data in the manifest will filter out available controls so that only valid controls for the context are available for configuration.The properties defined in the manifest for a control are rendered as configuration fields so that the person configuring the control can specify values. These property values are then available to your control function at run time.More information: Manifest file reference

### Control implementation library
Each custom control must have one JavaScript library that includes the definition of a function which will return an object that implements the methods described in the custom control interface. 
The object can implement the following methods:
- init (Required)
- updateView (Required)
- getOutputs (Optional)
- destroy (Required)

These methods control the lifecycle of the custom control. 

#### Page load
When the page loads, the application requires an object to work with. Using data from the Manifest, the code will get the object by calling
```js
var obj =  new ["namespace on manifest"].["constructor on maifest"]();
```
If the namespace and constructor values from the manifest were *"MyNameSpace"* and *"LinearInputControl"* respectively, the code run to instantiate the object would be this:
```js
var controlObj = new MyNameSpace.LinearInputControl();
```
When the page is ready, it will initialize the control by calling the init function. The page will call the init function with a set of parameters.
```js
controlObj.init(context,notifyOutputChanged,state,container);
```
|Parameter|	Description|
|---|---|
|context| Contains all the information about how the control is configured and all the PCF API's that can be used within the custom control.For example, the *context.parameters.["property name from manifest"]* can be used to access an input property.|
|notifyOutputChanged |	A function that your code will call to alert the framework that the control has new outputs ready to be retrieved asynchronously. You must implement this within the init function. More information: User changes data.|
|state|Contains control data from the previous page load in the current session.|
|container|An HTML div element to which you will append the HTML elements for the UI that defines your control. To display the value in your UI, you must get the data from the context.parameters.controlValue object. You must implement this in the init function.|


### User changes data
After the page loads, your control is just displaying the data until the user interacts with the control to change the data. When this occurs, you can manage it any way you like, but you must call the function passed in as notifyOutputChanged parameter in the init function. When you use this function, the platform will then respond by calling the getOutputs method that you must implement. The getOutputs methods will return any values that represent changes a user made. For a field control, this would typically be the new value for the control.

### App changes data
If the data is changed by the platform it will call the updateView method of your control object and pass a new context object as a parameter. You must implement this method and use it to update the value displayed in the control.

### Page close
When the user navigates away from the page the control will lose scope and usually all the memory allocated in that page for the objects in your control will be cleared. However, some items based on the browser implementation mechanism might stay and consume memory. Typically, these are event handlers. If user wants to store the information, they should implement the “setControlState” method so that the information will be given next time within the same session.
You should define a destroy method in your object. This will be called when the page closes and you should use it to remove any clean up code such as removing any event handlers. 

Before you go ahead and start creating your custom controls, make sure you have all the pre-requisites. 



### Related topics

[PowerApps Control Framework API Reference](reference/index.md)<br />
[PowerApps Control Framework Manifest Schema Reference](manifest-schema-reference/index.md)
