---
title: "NextRole Tag Unified Service Desk  Customer Enagagement| MicrosoftDocs"
description: "The following sample finds a control one position after the second control with a push button role."
ms.date: 08/23/2017
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
---
# NextRole Tag Unified Service Desk
The `<NextRole>` tag functions like the `<Next>` tag, but it applies to the accessibility role of the control. The attributes of the tag are same as the `<Next>` tag. The following sample finds a control one position after the second control with a push button role.  
  
```xml  
<JAccControl name="TestButton">  
<Path>  
<NextRole match="2"offset="1">push button</NextRole>  
</Path>  
</JAccControl>  
  
```  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
