---
title: "TextAreaElement in Unified Service Desk | MicrosoftDocs"
description: "Learn about using TextAreaElement in Unified Service Desk used to associate a named control with a text area element on the HTML page."
ms.custom: 
  - dyn365-USD
ms.date: 08/23/2017
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# TextAreaElement in Unified Service Desk
`<TextAreaElement>` element associates a named control with a text area element on the `HTML` page. This topic describes the elements of `<TextAreaElement>`.  
  
## \<TextAreaElement> syntax  
 The following code snippet shows how `<TextAreaElement>` is used.  
  
```xml  
<TextAreaElement name="name goes here">  
Search Path Elements  
</TextAreaElement>  
  
```  
  
## Elements of \<TextAreaElement>  
 The following table describes the elements of the `<TextAreaElement>` tag:  
  
|Element|Description|  
|-------------|-----------------|  
|`FindControl`|Returns `True` if the control can be found on the user interface (UI), otherwise `False`.|  
|`GetControlValue`|Returns the value of the text area element.|  
|`SetControlValue`|Sets the value of a text area element.|  
|`ExecuteControlAction`|Throws an `UnsupportedControlOperation` exception.|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
