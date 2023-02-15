---
title: Understand how to uninstall Sales Premium Add-ons
description: Uninstall the Sales Premium Add-ons for Dynamics 365 Sales if you don't want to use it in your organization.
ms.date: 02/15/2023
ms.custom: bap-template
ms.topic: how-to
author: udaykirang
ms.author: udag
manager: shujoshi

---
# Uninstall Sales Premium Add-ons 

You can uninstall the Sales Premium Add-ons for Dynamics 365 Sales if you don't want to use it in your organization. 

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## How to uninstall Sales Premium
  
1.	As an administrator, sign in to your sales app.
2.	Go to **Advanced settings**, and then select **Settings** > **Customization** > **Solutions**.  
3.	On the **Solutions** page, select each of the following solutions one at a time in the order they're specified, and then select **Delete**.  
    - SalesInsightsAddOn
    - msdyn_ConversationIntelligence
    - msdyn_acceleratedsales
    - msdyn_Sequence
    - msdynce_RelationshipAssistantAddOn
    - msdyn_connectiongraph
    - PredictiveLeadScoring
    - PredictiveOpportunityScoring
    - msdyn_PredictiveScoringCommon
    - RelationshipAnalytics
    - SalesInsightsMDLConfig
 
Although you've deleted the solutions, your organization data might still be stored in Azure Data Lake Storage. To completely remove data and reclaim the data storage, contact Dynamics 365 support.  

## What happens to data

After you uninstall Sales Premium, Dynamics 365 won't keep any Sales Premium data for your organization in the storage locations where it's hosted.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Introduction](../sales/intro-admin-guide-sales-insights.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
