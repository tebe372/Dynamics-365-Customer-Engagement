---
title: "Configure actions for workflows or dialogs in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6dbc0f10-7ac5-4685-ab74-22d24bf7102d
caps.latest.revision: 19
ms.author: "rdubois"
manager: "brycho"
---
# Configure custom actions from a workflow or dialog
You can enable a custom action from a workflow or dialog without writing code. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Invoke custom action from a workflow or dialog](../customize/invoke-custom-actions-workflow-dialog.md).  
  
 You may also create an action so that a developer can use it in code or you may need to edit an action that was previously defined. Like workflow processes, consider the following:  
  
-   What should the action do?  
  
-   Under what conditions should the action be performed?  
  
 
Unlike workflow processes, you don’t need to set the following options:  
  
- **Start When**: Actions start when code calls the message generated for them.  
  
- **Scope**: Actions always run in the context of the calling user.  
  
- **Run in the background**: Actions are always real-time workflows.  
  
Actions also have something that workflow processes don’t – input and output arguments. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define process arguments](../customize/configure-actions.md#BKMK_DefineProcessArgs)  
  
<a name="create"></a>   
## Create an action  
  
> [!IMPORTANT]
>  If you’re creating an action to include as part of a solution that will be distributed, create it in the context of the solution. Go to **Settings** > **Solutions** and locate the unmanaged solution that this action will be part of. Then, in the menu bar, select **New** > **Process**. This ensures that the customization prefix associated with the name of the action will be consistent with other components in the solution. After you create the action, you can’t change the prefix.  
  
 Like workflow processes, actions have the following properties in the **Create Process** dialog box.  
  
 **Process name**  
 After you enter a name for the process, a unique name will be created for it by removing any spaces or special characters from the process name.  
  
 **Category**  
 This property establishes that this is an action process. You can’t change this after you save the process.  
  
 **Entity**  
 With actions processes, you can select an entity to provide context for the workflow just like other types of processes, but you also have the option to choose **None (global)**. Use this if your action doesn’t require the context of a specific entity. You can’t change this after you save the process.  
  
 **Type**  
 Use this property to choose whether to build a new action from scratch or to start from an existing template.  
  
<a name="edit"></a>   
## Edit an action  
 You must deactivate processes before you can edit them.  
  
 You can edit an action that was created as part of an unmanaged solution or included in a solution installed in your organization. If the solution is a managed solution, you might not be able to edit it. The solution publisher has the option to edit the managed properties so that the action installed with a managed solution can’t be edited.  
  
 When an action is saved, a unique name is generated based on the process name. This unique name has the customization prefix added from the solution publisher. This is the name of the message that a developer will use in their code.  
  
 When editing an action you have the following options:  
  
 **Process Name**  
 After the process is created and the unique name is generated from the process name, you can edit the process name. You might want to apply a naming convention to make it easier to locate specific processes.  
  
 **Unique Name**  
 When an action is saved, a unique name is generated based on the process name. This unique name has the customization prefix from the solution publisher added. This is the name of the message that a developer will use in their code. Don’t change this unique name if the process has been activated and code is in place expecting to call the action using this name.  
  
> [!IMPORTANT]
>  After the action is activated and code is written to use a unique name, the unique name must not be changed without also changing the code that references it.  
  
 **Enable rollback**  
 Generally, processes that support transactions will “undo” (or roll back) the entire operation if any part of them fails. There are some exceptions to this. Some actions developers might do in code initiated by the action might not support transactions. For example, if the code perform actions in other systems that are beyond the scope of the transaction. Those can’t be rolled back by the action running in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Some messages in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] platform don’t support transactions. But everything you can do just with the user interface of the action will support transactions. All the actions that are part of a real-time workflow are considered in transaction, but with actions you have the option to opt out of this.  
  
 You should consult with the developer who will use this message to determine whether it must be in transaction or not. Generally, an action should be in transaction if the actions performed by the business process don’t make sense unless all of them are completed successfully. The classic example is transferring funds between two bank accounts. If you withdraw funds from one account you must deposit them in the other. If either fails, both must fail.  
  
> [!NOTE]
>  You can’t enable rollback if a custom action is invoked directly from within a workflow or dialog. You can enable rollback if an action is triggered by a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web services message.  
  
 **Activate As**  
 Like all processes, you can activate the process as a template and use it as an advanced starting point for processes that follow a similar pattern.  
  
 **Define Process Arguments**  
 In this area, you’ll specify any data that the action expects to start and what data will be passed out of the action. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define process arguments](../customize/configure-actions.md#BKMK_DefineProcessArgs)  
  
 **Add Stages, Conditions and Actions**  
 Like other processes, you specify what actions to perform and when to perform them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add stages, conditions and actions](../customize/configure-actions.md#BKMK_AddStagesConditionsAndActions)  
  a
<a name="BKMK_DefineProcessArgs"></a>   
### Define process arguments  
 When a developer uses a message, they may begin with some data that they can pass into the message. For example, to create a new case record, there might be the case title value that is passed in as a the input argument.  
  
 When the message is finished, the developer may need to pass some data that was changed or generated by the message to another operation in their code. This data is the output argument.  
  
 Both input and output arguments must have a name, a type, and some information about whether the argument is always required. You can also provide a description.  
  
 The name of the message and the information about all the process arguments represent the “signature” for the message. After an action is activated and is being used in code, the signature must not change. If this signature changes, any code that uses the message will fail. The only exception to this may be changing one of the parameters so that it is not always required.  
  
 You can change the order of the arguments by sorting them or moving them up or down because the arguments are identified by name, not by the order. Also, changing the description won’t break code using the message.  
  
#### Action process argument types  
 The following table describes the action process argument types.  
  
|Type|Description|  
|----------|-----------------|  
|Boolean|A `true` or `false` value.|  
|DateTime|A value that stores date and time information.|  
|Decimal|A number value with decimal precision. Used when precision is extremely important.|  
|Entity|A [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record for the specified entity. When you select Entity, the drop-down is enabled and allows you to select the entity type.|  
|EntityCollection|A collection of entity records.|  
|EntityReference|An object that contains the name, ID, and type of an entity record that uniquely identifies it. When you select EntityReference, the drop-down is enabled and allows you to select the entity type.|  
|Float|A number value with decimal precision. Used when data comes from a measurement that isn’t absolutely precise.|  
|Integer|A whole number.|  
|Money|A value that stores data about an amount of money.|  
|Picklist|A value that represents an option for an OptionSet attribute.|  
|String|A text value.|  
  
> [!NOTE]
> **EntityCollection** argument values can’t be set in the user interface for conditions or actions. These are provided for use by developers in custom code. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create your own actions](http://go.microsoft.com/fwlink/p/?LinkID=513292)  
  
<a name="BKMK_AddStagesConditionsAndActions"></a>   
### Add stages and steps  
 Actions are a type of process very similar to real-time workflows. All the steps that can be used in real-time workflows can be used in actions. For information about the steps that can be used for both real-time workflows and actions, see [Workflow stages and steps](../customize/configure-workflow-steps.md#BKMK_WorkflowStagesAndSteps).  
  
 In addition to the steps that can be used for real-time workflows, actions also have the **Assign Value** step that is similar to the one used to set variables or input arguments in dialogs. In actions, these can be used only to set output arguments. You can use the form assistant to set output arguments to specific values or, more likely, to values from the record that the action is running against, records related to that record with a many-to-one relationship, records created in an earlier step, or values that are part of the process itself.  
  
### See also  
 [Actions](../customize/actions.md)   
 [Invoke custom actions from a workflow or dialog](../customize/invoke-custom-actions-workflow-dialog.md)   
 [Monitoring real-time workflows and actions](../customize/monitor-manage-processes.md#BKMK_MonitorSyncWorkflows)
 [Workflow processes](../customize/workflow-processes.md)   
 [Dialogs](../customize/dialogs.md)   
 [Business process flows](../customize/business-process-flows-overview.md)   
 [Monitor and manage processes](../customize/monitor-manage-processes.md)   
 [Create your own actions](http://go.microsoft.com/fwlink/p/?LinkID=513292)
 [Types of processes](../customize/guide-staff-common-tasks-processes.md)
