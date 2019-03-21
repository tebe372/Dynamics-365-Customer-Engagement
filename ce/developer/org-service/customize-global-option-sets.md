---
title: "Customize global option sets | MicrosoftDocs"
ms.custom: 
ms.date: 11/20/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 6786ff10-0e38-4f5c-b973-c682d1d60de5
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Customize global option sets

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Typically, you use global option sets to set fields so that different fields can share the same set of options, which are maintained in one location. You can reuse global option sets. You will also see them used in request parameters in a manner similar to an enumeration.  
  
 When you define an option value by using <xref:Microsoft.Xrm.Sdk.Messages.CreateOptionSetRequest>, 
 we recommend that you let the system assign a value. You do this by passing a **null** value when you create the 
 new `OptionMetadata` instance. When you define an option, it will contain an option value prefix specific to the 
 context of the publisher set for the solution that the option set is created in. 
 This prefix helps reduce the chance of creating duplicate option sets for a managed solution, 
 and in any option sets that are defined in organizations where your managed solution is installed. For more information, 
 see [Merge option set options](../understand-managed-solutions-merged.md#merge-option-set-options).  
 
 ## Messages  
 The following table lists the messages that you can use with global option sets.  
  
|Message|Web API Operation|SDK Assembly|  
|-------------|----------------------------|--------------------------------|  
|CreateOptionSet|Use `POST` request to create a new global option set.|<xref:Microsoft.Xrm.Sdk.Messages.CreateOptionSetRequest>|  
|DeleteOptionSet|Use `DELETE` request to delete a global optin set.|<xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionSetRequest>|  
|DeleteOptionValue</br>Deletes one of the values in a global option set.|<xref href="Microsoft.Dynamics.CRM.DeleteOptionValue?text=DeleteOptionValue Action" />|<xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest>|    
|InsertOptionValue</br>Inserts a new option into a global option set.|<xref href="Microsoft.Dynamics.CRM.InsertOptionValue?text=InsertOptionValue Action" />|<xref:Microsoft.Xrm.Sdk.Messages.InsertOptionValueRequest>|  
|InsertStatusValue</br>Inserts a new option into the global option set used in the `Status` attribute.|<xref href="Microsoft.Dynamics.CRM.InsertOptionValue?text=InsertStatusValue Action" />|<xref:Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest>|  
|OrderOption</br>Changes the relative order of the options in an option set.|<xref href="Microsoft.Dynamics.CRM.OrderOption?text=OrderOption Action" />|<xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest>|  
|RetrieveAllOptionSets|Use `GET` request to retrieve all the global option sets.|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllOptionSetsRequest>|  
|RetrieveOptionSet|Use `GET` request to retrieve a global option set.|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveOptionSetRequest>|    
|UpdateOptionSet|Use `PUT` request to update a global option set.|<xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionSetRequest>|  
|UpdateOptionValue|</br>Updates an option in a global option set.|<xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionValueRequest>|  
|UpdateStateValue</br>Inserts a new option into the option set used in the `Status` attribute.|<xref href="Microsoft.Dynamics.CRM.OrderOption?text=UpdateStateValue Action" />|<xref:Microsoft.Xrm.Sdk.Messages.UpdateStateValueRequest>|   

<a name="BKMK_RetrieveAGlobalOptionSet"></a>   
## Retrieve a global option set  
 The following sample shows how to retrieve a global option set by name using the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveOptionSetRequest> message:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets6](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets6.cs#workwithglobaloptionsets6)]  
  
<a name="BKMK_CreateGlobalOptionSet"></a>   
## Create a global option set  
 Use the <xref:Microsoft.Xrm.Sdk.Messages.CreateOptionSetRequest> message to create a new global option set. Set the 
 <xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadataBase.IsGlobal> property to `true` to indicate that the option set is global. The following code example creates a global option set called “Example Option Set”:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets2](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets2.cs#workwithglobaloptionsets2)]  
  
<a name="BKMK_CreatePicklistWithGlobalOptionSet"></a>   
## Create a picklist that uses a global option set  
 The following sample shows how to create a picklist attribute that uses a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets3](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets3.cs#workwithglobaloptionsets3)]  
  
<a name="BKMK_UpdateGlobalOptionSet"></a>   
## Update a global option set  
 The following sample shows how to update the label for a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionSetRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets4](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets4.cs#workwithglobaloptionsets4)]  
  
<a name="BKMK_OrderingOptions"></a>   
## Ordering options  
 The following sample shows how the options in a global option set can be ordered by using 
 <xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets8](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets8.cs#workwithglobaloptionsets8)]  
  
<a name="BKMK_RetrieveAllGlobalOptionSets"></a>   
## Retrieve all global option sets  
 The following sample shows how to retrieve all global option sets by using 
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllOptionSetsRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets9](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets9.cs#workwithglobaloptionsets9)]  
  
<a name="BKMK_DeleteAGlobalOptionSet"></a>   
## Delete a global option set

 The following sample shows how to check whether a global option set is being used by another solution component by using `RetrieveDependentComponents` message (<xref href="Microsoft.Dynamics.CRM.RetrieveDependentComponents?text=RetrieveDependentComponents Function" /> or <xref:Microsoft.Crm.Sdk.Messages.RetrieveDependentComponentsRequest>), and then how to delete it by using `DeleteOptionSet` message (For Organization Service, use <xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionSetRequest>):  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets12](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets12.cs#workwithglobaloptionsets12)]  
  
### See also  
 [Customize Dynamics 365 for Customer Engagement applications](../customize-dev/customize-applications.md)   
 [Extend the Metadata Model for Dynamics 365 for Customer Engagement apps](use-organization-service-metadata.md)   
 [Insert, update, delete, and order global option set options](insert-update-delete-order-global-option-set-options.md)   
 [Sample: Create Global Option Set](sample-create-global-option-set.md)   
 [Sample: Work with Global Option Sets](sample-work-global-option-sets.md)   
 [Sample: Dump Global Option Set Information to a File](sample-dump-global-option-set-information-file.md)
