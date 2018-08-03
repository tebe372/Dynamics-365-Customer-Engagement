---
title: Troubleshoot SLA timer issue in Customer Service Hub app | Microsoft Docs
description: Know how to fix the issue where SLA Timer does not stop, when state is changed from OnHold to InProgress on a Holiday
keywords: Customer Service Hub; SLA Timer; SLA state; SLA wait time; SLA failure time
author: anjgupta
applies_to: Dynamics 365 (online) 
ms.author: anjgup
manager: shujoshi
ms.date: 08/03/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 689d7cfb-dfd9-4e65-85f3-a422617f1a0f
ms.custom: dyn365-customerservice
---

# SLA timer does not pause when its state is changed from InProgress to OnHold on a holiday

## Issue

Once triggered, the SLA timer continues to run even when its state is changed from *InProgress* to *OnHold*. 

When a holiday is configured, the status of the case is updated to *OnHold* to pause the case SLA. However, the pause functionality associated with the *OnHold* status doesn't function correctly. Therefore, the timer continues to run even on a holiday when it should be paused.

Due to this, it includes the holiday hours, non-business hours, and pause time (only business hours) while projecting the SLA warning or failure time. 

## Resolution

This is an intended functionality. Business hours are defined by your organization while scheduling working days and holidays. SLA warning and failure time adhere to those settings and is calculated on the basis of the defined hours.

See the following scenarios to understand how the SLA *Wait* and *Failure* time is calculated:

- Create a case during non-working hours. Pause and resume the case before wprking hours start. Hold time between *Pause* and *Resume* will not be considered.
- Create a case during non-working hours. Pause and resume the case during business working hours. Hold time will be considered and *Wait* and *Failure* time will be extended based on hold time.
- Create a case during working hours. Pause the case during working hours. Resume the case during non-working hours. Hold time will not be considered for *Wait* and *Failure* time.
- Create a case during working hours. Pause the case during non-working hours and resume it during working hours. *Warn* time and *Fail* time will be recalculated.

## More help

[Track SLA details with Timer Control](customer-service-hub-user-guide-case-sla.md#track-sla-details-with-timer-control)

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)


