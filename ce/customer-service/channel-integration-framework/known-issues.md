---
title: "Known issues for Dynamics 365 Channel Integration Framework | Microsoft Docs"
description: "Learn about known issues and workarounds for Dynamics 365 Channel Integration Framework."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Known issues and workarounds for Dynamics 365 Channel Integration Framework

Here are some common issues that you might encounter while using Dynamics 365 Channel Integration Framework.

## Switching sessions

If the session title is in the format of a telephone number, it isn't possible to switch sessions. 

## Sample softphone widget

You won't be able to use the Hold, Mute, Dialer pad, and More options buttons in the sample softphone widget.

## Default sessions for providers

Providers might need a customer-less default session to show a dialer experience in the communication widget, and conversation dashboards in the application tab, and so on.  The framework doesn't support configurable default sessions for providers. However, to achieve this, they can create a session template with relevant application tabs and load the same when their widget is loaded. 


## Form flickering when communication widget is expanded

If you have a form open when you expand the communication widget, you'll observe that the form flickers. The flickering will be observed only if any of the following conditions apply.

-	The form section layout is four columns.
-	The form has a web resource that defines the row size to 40 or greater, and also sets the form section layout to four columns.
-	Screen size is 23.6 inches or more.

You'll not observe flickering if the form has just one row and if all cells in the row are filled. Also, you'll not observe this if there are 4 columns and 4 rows with non-empty cells. Flickering of forms is observed when there are two or more rows, with or without empty cells.

The resolution is to adjust the screen size.


## See also

[What's new in Dynamics 365 Channel Integration Framework](whats-new-channel-integration-framework.md)<br />
[Frequently asked questions](faq-channel-integration-framework.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
