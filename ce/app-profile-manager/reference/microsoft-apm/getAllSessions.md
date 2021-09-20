---
title: "getAllSessions method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getAllSessions API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# getAllSessions (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Returns the unique identifier of all sessions.

## Syntax

`Microsoft.Apm.getAllSessions();`

## Return value

Collection of session identifiers.

## Example

```JavaScript
const sessionIds = Microsoft.Apm.getAllSessions();
sessionIds.forEach(id=> {
        console.log(id);
});
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
