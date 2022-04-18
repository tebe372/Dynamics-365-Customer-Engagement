---
title: "Customize live chat widgets using data tags | MicrosoftDocs"
description: "Use this article to understand how you can customize chat widgets by using data tags on the chat widget script in Omnichannel admin center and Omnichannel Administration apps."
ms.date: 02/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---
# Customize live chat widgets using data tags

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## Introduction

Live chat widgets can be customized by using data tags on the widget script.

|Attribute name|Description|Example|
|----|-----|-----|
|`data-hide-chat-button`| When the HTML snippet is added to a website, a widget shows up on that website by default. In some cases, you might want to implement the chat widget by using your own button. Use this data tag to hide the chat button. | Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration app as shown in the following example.<br /><br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-hide-chat-button="true"></script>`|
|`data-enable-telemetry`| By default, telemetry data collection is turned on for all widgets. Set the value of this data tag to `false` if you want to disable telemetry data collection. More information: [Live chat widget telemetry](live-chat-telemetry.md)|Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration page, as shown in the following example.<br /><br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-enable-telemetry="false"></script>` |
|`data-render-mobile`| Open the chat widget in mobile mode. The chat widget doesn't have a header when used on a mobile device. More information: [Customize live chat widget for mobile apps](render-live-chat-widget-mobile.md#render-the-live-chat-widget-using-embedded-code)|Add this tag to the chat widget script as shown in the following example. <br /><br>`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-render-mobile="true" ></script>` |
|`data-color-override`| Use this data tag to override the default chat widget theme color. This override will take priority over any color theme settings on the Omnichannel Administration page.|Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration page. In the following example script, the chat widget theme color is changed to blue.<br /><br>`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-color-override="#0000FF"></script>` |
|`data-font-family-override`| Use this data tag to override the default chat widget font family.<br />If your website has a custom font uploaded, that can also be used to override the default font family.<br />The default font family is `"Segoe UI",Arial,sans-serif`.|Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration page. In the following example script, the chat widget font family is set to Roboto as a first priority, otherwise the font family is Segoe UI.<br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-font-family-override="Roboto; Segoe UI"></script>` |
|`data-open-in-window`| Use this data tag to open the chat widget in a new window. You can set this tag to `true` or `false` (default value). By default, the chat widget will open in the same browser window. If set to `true`, the chat widget will open in a new browser window when selected. | `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-open-in-window="true"></script>`|
|`data-suggested-action-layout`| Use this data tag to display the suggested actions vertically. By default, the suggested actions are displayed horizontally. To display the suggested actions vertically, set the value of this data tag as `stacked`. | Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration page as shown in the following example.<br /><br /> `<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-suggested-action-layout="stacked"></script>`|
|`data-enable-lcw-autofill`| Use this data tag to enable the chat widget to autofill the browser window in embedded mode. | Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration page as shown in the following example. <br /><br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-enable-lcw-autofill="true"></script>`|
|`data-custom-close-button-text`| Use this data tag to customize the close button of the chat widget. The input is a text string that'll appear in place of the default ‘X’ close button. | Add this tag to the chat widget script that you got from the Omnichannel admin center or Omnichannel Administration app as shown in the following example. <br /><br />`<script id="Microsoft_Omnichannel_LCWidget" src="<valid-src>" data-app-id="<valid-app-id>" data-org-id="<valid-org-id>" data-org-url="<valid-org-url>" data-custom-close-button-text="End Chat"></script>`|
||||

### See also

[Start chat proactively](start-proactive-chat.md)  
[Live chat SDK reference](developer/omnichannel-reference.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
