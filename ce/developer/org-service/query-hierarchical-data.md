---
title: "Query hierarchical data (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "Dynamics 365 for Customer Engagement (online) Customer Engagement introduces the capability to define specific self-referencing one-to-many entity relationships as hierarchical. Read how you can build queries that return data in these hierarchies"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: ed3d7166-8865-433d-b889-b0fadba25d64
caps.latest.revision: 20
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Query hierarchical data

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement introduces the capability to define specific self-referencing one-to-many entity relationships as hierarchical. You can write queries that return related data in these hierarchies.  
  
 You can take advantage of new query condition operators to query entities with explicit hierarchical relationships. These operators only apply for the entity relationship specifically defined as a hierarchical relationship. You can use new condition operators to retrieve this hierarchical data when you query using <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> or <xref:Microsoft.Xrm.Sdk.Query.FetchExpression>.  
  
<a name="BKMK_ConditionOperators"></a>   
## Condition operators for hierarchical data  
 Use the following operators to set conditions when querying hierarchical data.  
  
|FetchXML|ConditionOperator|Description|  
|--------------|-----------------------|-----------------|  
|`above`|`Above`|Returns all records in referenced record's hierarchical ancestry line.|  
|`eq-or-above`|`AboveOrEqual`|Returns the referenced record and all records above it in the hierarchy.|  
|`under`|`Under`|Returns all child records below the referenced record in the hierarchy|  
|`eq-or-under`|`UnderOrEqual`|Returns the referenced record and all child records below it in the hierarchy|  
|`not-under`|`NotUnder`|Returns all records not below the referenced record in the hierarchy|  
|`eq-owneduseroruserhierarchy`|`OwnedByMeOrMyReports`|When hierarchical security models are used, Equals current user or their reporting hierarchy|  
|`eq-useroruserhierarchyandteams`|`OwnedByMeOrMyReportsAndTeams`|When hierarchical security models are used, Equals current user and their teams or current user's reporting hierarchy and their teams|  
  
### Recursion limits when querying hierarchical data  
 Because querying hierarchical data can be resource intensive, there is a default limit of 100 recursions allowed conditions for hierarchical queries using the `Above`, `AboveOrEqual`, `Under`, `UnderOrEqual`, and `NotUnder` condition operators.  
  
 These limits can be adjusted using [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] commands through the deployment web service. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Administer the deployment using Windows PowerShell](https://technet.microsoft.com/library/dn531202.aspx).  
  
 `OwnedByMeOrMyReports` and `OwnedByMeOrMyReportsAndTeams` are hierarchical security condition operators that depend on the **Hierarchy Depth** setting that can be found in **Settings** > **Security** > **Hierarchy Security**. The value of this setting is stored in the `Organization.MaxDepthForHierarchicalSecurityModel` attribute.  
  
<a name="BKMK_ChildCountAggregate"></a>   
## Retrieve the number of hierarchically related child records  
 Use the `rowaggregate` attribute in a FetchXML based query to retrieve the number of hierarchically related child records. When this value is set to `CountChildren` a value that includes the total number of child records for the record is included in the <xref:Microsoft.Xrm.Sdk.EntityCollection>. For example, the following query will include an `AccountChildren` aggregate value representing the number of child account records in the hierarchical relationship where the `{0}` parameter represents the `AccountId` of the parent record.  
  
```xml  
<fetch distinct='false' no-lock='false' mapping='logical'>  
  <entity name='account'>  
    <attribute name='name' />  
    <attribute name='accountid' />  
    <attribute name='accountid' rowaggregate='CountChildren' alias='AccountChildren'/>  
    <filter type='and'>  
      <condition attribute='accountid' operator='under' value='{0}' />  
    </filter>  
  </entity>  
</fetch>  
  
```  
  
> [!NOTE]
>  The aggregate value returned represents all the child records, including any that the user may not have access to read.  
  
### See also  
 [Customize entity relationship metadata](../customize-entity-relationship-metadata.md)   
 [Build Queries with FetchXML](build-queries-fetchxml.md)   
 [Build Queries with QueryExpression](build-queries-with-queryexpression.md)   
 [FetchXML Schema](fetchxml-schema.md)   
 <xref:Microsoft.Xrm.Sdk.Query.ConditionOperator>   
 [Video: Hierarchy Visualization in Microsoft Dynamics CRM 2015](http://youtu.be/_dGBE6icLNw)
