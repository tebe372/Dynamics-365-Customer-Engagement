---
title: "openForm (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 0206c43b-b1fc-490d-a867-1d75331885a8
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# openForm (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/openForm-description.md](./includes/openForm-description.md)]

## Syntax

`Xrm.Navigation.openForm(entityFormOptions,formParameters).then(successCallback,errorCallback);`

## Parameters


<table style="width:100%">
  <tr>
    <th>Name</th>
    <th>Type</th> 
    <th>Required</th>
    <th>Description</th>
  </tr>
  <tr>
    <td>entityFormOptions</td>
    <td>Object</td> 
    <td>Yes</td>
    <td>Entity form options for opening the form. The object contains the following attributes:<ul>
<li><b>cmdbar</b>: (Optional) Boolean. Indicates whether to display the command bar. If you do not specify this parameter, the command bar is displayed by default.</li>
<li><b>createFromEntity</b>: (Optional) Lookup. Designates a record that will provide default values based on mapped attribute values. The lookup object has the following String properties: <code>entityType</code>, <code>id</code>, and <code>name</code> (optional).</li>
<li><b>entityId</b>: (Optional) String. ID of the entity record to display the form for.</li>
<li><b>entityName</b>: (Optional) String. Logical name of the entity to display the form for.</li>
<li><b>formId</b>: (Optional) String. ID of the form instance to be displayed.</li>
<li><b>height</b>: (Optional) Number. Height of the form window to be displayed in pixels.</li>
<li><b>navBar</b>: (Optional) String. Controls whether the navigation bar is displayed and whether application navigation is available using the areas and subareas defined in the sitemap. Valid vlaues are: "on", "off", or "entity".<ul><li><code>on</code>: The navigation bar is displayed. This is the default behavior if the <b>navBar</b> parameter is not used.</li>
<li><code>off</code>: The navigation bar is not displayed. People can navigate using other user interface elements or the back and forward buttons.</li><li><code>entity</code>: On an entity form, only the navigation options for related entities are available. After navigating to a related entity, a back button is displayed in the navigation bar to allow returning to the original record.</li></ul></li>
<li><b>openInNewWindow</b>: (Optional) Boolean. Indicates whether to display form in a new window.</li>
<li><b>windowPosition</b>: (Optional) Number. Specify one of the following values for the window position of the form on the screen:<ul><li><code>1:center</code></li><li><code>2:side</code></li></ul>
<li><b>processId</b>: (Optional) String. ID of the business process to be displayed on the form.</li>
<li><b>processInstanceId</b>: (Optional) String. ID of the business process instance to be displayed on the form.</li>
<li><b>relationship</b>: (Optional) Object. Define a relationship object to display the related records on the form. The object has the following attributes.
<table style="width:100%">
  <tr>
    <th>Name</th>
    <th>Type</th> 
    <th>Description</th>
<tr>
<td>attributeName</td>
<td>String</td>
<td>Name of the attribute used for relationship.</td>
</tr>
<tr>
<td>name</td>
<td>String</td>
<td>Name of the relationship.</td>
</tr>
<tr>
<td>navigationPropertyName</td>
<td>String</td>
<td>Name of the navigation property for this relationship.</td>
</tr>
<tr>
<td>relationshipType</td>
<td>Number</td>
<td>Relationship type. Specify one of the following values:
<ul><li><code>0:OneToMany</code></li><li><code>1:ManyToMany</code></li></ul></td>
</tr>
<tr>
<td>roleType</td>
<td>Number</td>
<td>Role type in relationship. Specify one of the following values:
<ul><li><code>1:Referencing</code></li><li><code>2:AssociationEntity</code></li></ul></td>
</tr>
</table>
</li>
<li><b>selectedStageId</b>: (Optional) String. ID of the selected stage in business process instance.</li>
<li><b>useQuickCreateForm</b>: (Optional) Boolean. Indicates whether to open a quick create form.</li>
<li><b>width</b>: (Optional) Number. Width of the form window to be displayed in pixels.</li>
</ul>
</tr>
<tr>
<td>formParameters</td>
<td>Object</td>
<td>No</td>
<td>A dictionary object that passes extra parameters to the form. Invalid parameters will cause an error.<br/><br/>For information about passing parameters to a form, see [Set field values using parameters passed to a form](../../../set-field-values-using-parameters-passed-form.md) and [Configure a form to accept custom querystring parameters](../../../configure-form-accept-custom-querystring-parameters.md) </td>
</tr>
<tr>
<td>successCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to execute when the entity form or quick create form is displayed. For an existing entity or when the entity form is opened, it passed a single lookup value to the function. For the quick create, it will return as many items as were created and in the order they were created.
</td>
</tr>
<tr>
<td>errorCallback</td>
<td>Function</td>
<td>No</td>
<td>A function to execute when the operation fails.</td>
</tr>
</table>

## Remarks

You must use this method to display entity or quick create forms instead of the deprecated  [Xrm.Utility.openEntityForm](https://msdn.microsoft.com/library/jj602956.aspx#openEntityForm) and  [Xrm.Utility.openQuickCreate](https://msdn.microsoft.com/library/jj602956.aspx#openQuickCreate) methods.

## Example

The following sample code opens a contact form with some pre-populated values:

```JavaScript
// Set entity form options to open a Contact form
var entityFormOptions = {};
entityFormOptions["entityName"] = "contact";

// Set default values for the Contact form
var formParameters = {};
formParameters["fullname"] = "Sample Contact";
formParameters["emailaddress1"] = "contact@adventure-works.com";
formParameters["jobtitle"] = "Sr. Marketing Manager";
formParameters["donotemail"] = "1";
formParameters["description"] = "Default values for this record were set programmatically.";

// Open the form.
Xrm.Navigation.openForm(entityFormOptions, formParameters).then(
    function (success) {
        console.log(success);
    },
    function (error) {
        console.log(error);
    });
```

### Related topics

[Xrm.Navigation](../xrm-navigation.md)




