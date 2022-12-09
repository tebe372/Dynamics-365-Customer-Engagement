---
title: "Define your Message parts (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your message parts in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 12/08/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---
# Define your Message parts

## Applicable channels: SMS, Custom

### Why you need it:

If you're creating a custom channel and you want to describe the message parts that the channel operates with (for example, title, subtitle, text), then you must define records for the **Channel Message Part** entity. At least one message part is required per custom channel.  **At your solution’s import**, a new row for every message part will be created at the **msdyn_channelmessagepart** table.

> [!IMPORTANT]
> Sms channel type requires exactly one message part with name “text” as it will be used by   the default Marketing SMS editor.

#### Message parts contract:

Entity logical name: **msdyn_channelmessagepart**
Entity set name: **msdyn_channelmessageparts**
Primary Id attribute name: **msdyn_channelmessagepartid**

• **msdyn_name**: string – Name for the message part. This value is later used as a key to map message part information with outbound message content.

• **msdyn_displayname**: string – Display name.

• **msdyn_description**: string – Description.

• **msdyn_channeldefinitionid**: GUID – Channel definition id, must match the channel definition id of the channel.

• **msdyn_type**: OptionSet – Channel type, currently supported values:
o	192350000 plaintext

More types will be introduced in further releases.

• **msdyn_isrequired**: bit - Indicates whether the part is required.

• **msdyn_maxlength**: int - max length for the part

#### How to define it:

Message parts are defined in the **customizations.xml** as solution aware components. Place every **msdyn_channelmessagepart** under **ImportExportXml** > **msdyn_channelmessageparts** elements. Note that each message part element **msdyn_channelmessagepart** must include its own unique id in the form of GUID as XML attribute **msdyn_channelmessagepartid**. 

#### Example of customizations.xml including message parts

```
<ImportExportXml xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <msdyn_channelmessageparts>
    <msdyn_channelmessagepart msdyn_channelmessagepartid="15d57b1a-ddcd-4bb1-9af6-c691567ab9ef">
      <msdyn_channeldefinitionid>
        <msdyn_channeldefinitionid>b1b25a46-6da0-4c08-9cf3-505e613c8e30</msdyn_channeldefinitionid>
      </msdyn_channeldefinitionid>
      <msdyn_description>Text</msdyn_description>
      <msdyn_displayname>Text</msdyn_displayname>
      <msdyn_isrequired>1</msdyn_isrequired>
      <msdyn_maxlength>1000</msdyn_maxlength>
      <msdyn_name>text</msdyn_name>
      <msdyn_type>192350000</msdyn_type>
      <statecode>0</statecode>
      <statuscode>1</statuscode>
    </msdyn_channelmessagepart>
  </msdyn_channelmessageparts>
</ImportExportXml>
```