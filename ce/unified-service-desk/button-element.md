---
title: "ButtonElement | MicrosoftDocs"
description: "The topic explains about <ButtonElement> element syntax and the elements, which is one of the binding elements of the WebDDA."
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
# ButtonElement
`<ButtonElement>` is one of the binding elements of WebDDA. This topic describes the syntax and the elements of `<ButtonElement>`  
  
## \<ButtonElement> syntax  
 The `<ButtonElement>` element associates a named control to a `<button/> HTML` element. The following code snippet shows how `<ButtonElement>` is used:  
  
```xml  
<ButtonElement name="control name">  
Search Path Elements  
</ButtonElement>  
  
```  
  
## Elements of \<ButtonElement>  
 The following table describes the elements of `<ButtonElement>`  
  
|Element|Description|  
|-------------|-----------------|  
|FindControl|Returns `True` or `False` depending on whether the control can be found on the UI.|  
|GetControlValue|Returns the URL text.|  
|SetControlValue|Throws an `UnsupportedControlOperation` exception.|  
|ExecuteControlAction|Executes a `Click()` command on the control.|  
  
### See also  
 [WebDDA](../unified-service-desk/web-dda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
