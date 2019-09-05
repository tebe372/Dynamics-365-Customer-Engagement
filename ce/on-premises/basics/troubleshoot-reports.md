---
title: "Troubleshoot problems with data not displaying in a report (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
ms.assetid: 886fee0f-d97b-4baf-9019-63ee11cdf329
caps.latest.revision: 27
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Troubleshoot problems with data not displaying in a report

There are several possible reasons why data that you expect to be in a report does not appear:  
  
- **Insufficient security permissions**. If you don't have permission in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to view a record, it will not appear in the report.  
  
- **Data is not entered.** The person entering data may have left fields empty.  
  
- **Data does not match the criteria for the report.** Many reports include a default filter that displays only active records, or you may have selected criteria that don’t have any matching record. Try changing the report filter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit the default filter of a report](../basics/edit-default-filter-report.md)  
  
- **You may be viewing a cached copy of the report.** By default, data in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] reports is pulled from the database each time you run a report. However, your system administrator may have changed a report to run from the cache. If data you entered recently is not included in the report, you may have an older version of the report from the cache. To refresh the report, on the Report toolbar, click or tap the **Refresh** button ![Refresh button](../basics/media/htm-lviewer-grid-refresh.gif "Refresh button").  
  
- **You may not have permission to read records in a sub-report.** If you do not have permission to read record types that are included in a sub-report, you will get an error message saying that the sub-report could not be displayed.  
  
- **Your Microsoft Internet Explorer privacy settings may block required cookies.** For chart reports, if instead of seeing the chart, you see a red letter X, your privacy settings may be blocking a cookie that is required for the chart control. To fix this problem, in your browser, enable cookies for the server that is running Reporting Services.  
  
<!--- **If you are offline, your local data groups may not include all the data.** If you are using the report from [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] while you are offline, you must have a local data group that includes all the data that will be in the report. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Example of going offline with Dynamics 365 for Outlook](../outlook-add-in/example-going-offline-dynamics-365-outlook.md)-->

### See Also
[Run a report](../basics/run-report.md)
