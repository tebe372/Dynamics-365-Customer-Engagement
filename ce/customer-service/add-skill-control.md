---
title: "Skill control for routed records| MicrosoftDocs"
description: "Learn how to add a skill control on forms to view skills of any routed record."
ms.date: 08/25/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Add a skill control for routed records

Dynamics 365 provides an out-of-the box custom control that you can embed on any of your forms to view the skills of any routed record. To be able to add the skill control, you must have the System Administrator or System Customizer security role, or equivalent permissions. For more information about your security role, go to [View your user profile](../basics/view-your-user-profile.md).

In the following example, to add a skill control named **Skills** to the case form:

1. In Dynamics 365, go to **Advanced Settings**, select **Customizations**, and then select **Customize the System**. 

2. On the site map of the page that appears, under **Components**, expand **Entities**, select **Case**, and then select **Forms**. 

3. In the **Active Forms** list that appears on the grid, select the form where you want to add the skill control. In this example, we selected the **Case for Interactive experience** form.

4. On the **Insert** tab, select **Section**, and then select **One Column**. Drag the section to the form.
 
5. From the **Field Explorer**, select a field that supports a single line of text (such as **Case Title**) to add to the section you just created. Save the form.

6. Select the field you just added, and then select **Change Properties**. 

   In the **Field Properties** dialog that appears, select the **Display** tab and enter a label name for the field, such as **Skills**.

7. On the **Controls** tab, select **Add Control**. 
  
   In the **Add Control** dialog that appears, select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the dropdown list, and then select **OK**.

8. Save and publish the solution.

The skill control is added to the **Case Interactive experience** form. Your agents will now be able to view the newly added custom control on all routed records in Customer Service Hub. 

> [!NOTE]
> To customize a form to add the skill control in Customer Service workspace or the Omnichannel admin center, you can add the control to the **Case for Multisession experience** form.


### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure work classification rule](configure-work-classification.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]