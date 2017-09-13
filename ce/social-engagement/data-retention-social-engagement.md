---
title: "Data retention in Social Engagement | Microsoft Docs"
description: "Find out how long data is stored when working with Social Engagement."
ms.custom: ""
ms.date: 09/12/2017
ms.reviewer: ""
ms.service: mse
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: d3617d7f-29df-42e9-baff-4625ab4ee85a
caps.latest.revision: 14
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# Data retention in Social Engagement
Get to know which user data gets stored when you work with [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] and how long this data persists. Whenever data is stored in [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)], either as acquired posts or user settings, it’s stored in a database. While posts end up in a central data store, all other data is stored in a solution-specific database.  
  
## Storage of private messages and direct messages as regular posts  
If at least one user has added a social profile to an organization’s [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] solution and the acquisition is allowed for private messages of this social profile, private messages of this profile can be acquired.  
  
> [!NOTE]
>  A user with permissions to work with search topics can create rules that acquire the private messages and similar posts that are found through public searches. When a private message is stored in the database, it’s visible to every user who can access [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] in the same organization.  
  
## Data retention when deleting a social profile  
If a solution has acquired private messages from a social profile, and its owner removes the social profile, all private messages from this profile are hidden in the user interface immediately after removal.  
  
However, the direct messages persist in the central database unless the solution is de-provisioned or the posts become older than two years (730 days).  
  
## Data retention when deleting a private message  
If a solution has acquired private messages from a social profile and the owner of the social profile deletes one of these messages, the deleted message won’t show on the user interface anymore.  
  
## Data retention upon deleting an organization or de-provisioning an organization  
If the global administrator decides to de-provision the [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] solution for an organization, all related data such as posts, search topics, direct messages, and user permissions are deleted 180 days after the organization’s subscription is canceled.  
  
### See Also  
[Manage social profiles](../social-engagement/manage-social-profiles.md)   
[Understand user roles](../social-engagement/user-roles.md)   
[Work with posts](../social-engagement/work-with-posts.md)
 
