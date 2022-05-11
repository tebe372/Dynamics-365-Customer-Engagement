---
title: "Learn the limitations of service-level agreements in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn the limitations of service-level agreements in Dynamics 365 Customer Service."
ms.date: 05/11/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# SLA Limitations

The following limitations apply to the Unified Interface apps:

- The **Applicable When** and **Success Conditions** won't work as expected if they are configured for related entities.

    - **Applicable when** conditions, if defined on the related entity, will work only for the first time when they are met, and the KPI instance will be set to **In Progress**. After that, any update to the related entity will not cancel the existing KPI instance if the conditions of the same SLA item are false, or create a new KPI instance if there is a change in the SLA item.
    - Success conditions defined on the related entity will never be true and the KPI instance once set to **In Progress** will never succeed, even if conditions are met. It will continue to be in **In Progress**, **Nearing NonCompliance**, or **Noncompliant** status.
    - The above limitations will work only if the related entity lookup record of the target entity is updated.
    
- Multiple SLA items can't be defined with the same **Applicable When** criteria and different **Success Conditions** for an SLA.


### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
