---
title: How to use new resource management features for Dynamics 365 for Project Service (version 3.x)
description: An English-language guide to new resource management capabilities in Project Service Automation for Dynamics 365
author: jburrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 11/15/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Resource your project in the Project Service app  

[!INCLUDE[cc-applies-to-psa-app-3.x](../../includes/cc-applies-to-psa-app-3x.md)]

You can staff your project with a team of generic or named resources in Dynamics
365 for Project Service Automation. Here are the various methods you can use to add and
assign team members and manage their bookings and assignments.

## Booking and assigning a “named” bookable resource on a task and project team

You can  add a named (or real) resource to your project team by booking them
directly onto the team.

> [!div class="mx-imgBorder"] 
> ![Screenshot of adding a team member from the team tab](../media/RM-how-to-1.png "Screenshot of adding a team member from the team tab")

To do this, select New on the Team tab of your project.

> [!div class="mx-imgBorder"] 
> ![Screenshot of adding a team member on the quick create form](../media/RM-how-to-2.png "Screenshot of adding a team member on the quick create form")

Select the bookable resource. The role will be populated with their default role
(if they have one), but you can change it if needed. Select the from and to
dates for the resource. Select the allocation method of the resource’s capacity:

-   Full capacity

-   Percentage capacity

-   By hours – distribute evenly

-   By hours – front load

Select if you want the team member to be an approver for the project. Selecting
yes, means that they can approve submitted time or expense entries for this
project.

Once the resource is part of the team, you can switch to the schedule tab and
assign them to tasks. The resource picker that is launched from the task grid
will show the team members for the project under Team Members.

> [!div class="mx-imgBorder"] 
> ![Screenshot of assigning a team member to a task on the schedule tab](../media/RM-how-to-3.png "Screenshot of assigning a team member to a task on the schedule tab")

In version 3, resource bookings and task assignments are not tightly coupled. This means that
when you use the resource picker in the schedule, you can potentially assign tasks to team
members for more hours than their bookings cover on the project.

You can see differences in team member bookings and assignments in either the
team tab or the resource reconciliation tab, where you can reconcile differences between
bookings and assignments for resources at a detailed level.

> [!div class="mx-imgBorder"] 
> ![Screenshot of the resource reconciliation tab](../media/RM-how-to-4.png "Screenshot of the resource reconciliation tab")

You can also use the resource picker in the schedule tab to select bookable resources
that are not already part of the project team. They show on the resource picker as
Other Resources

> [!div class="mx-imgBorder"] 
> ![Screenshot of assigning a non-team member resource to a task](../media/RM-how-to-5.png "Screenshot of a non-team member resource to a task")

When you do this, the resource is added to the project team and assigned to the task, but no bookings are
made for them.

> [!div class="mx-imgBorder"] 
> ![Screenshot of team member with assignments and no bookings](../media/RM-how-to-6.png "Screenshot of a team member with assignements and no bookings")

You can use the reconciliation tab’s extend bookings capability or the schedule
board to book the resource’s capacity to the project.

![](media/94d4a65675b02692180f948651b7ae34.png)

Once a team member is booked on your project, you can either use maintain
bookings or use the Schedule Board directly to manage their bookings.

![](media/0c76de23ef9cd384f3272be217887e7b.png)

## Assigning a generic bookable resource on a task and project team and then fulfilling with a “named” resource via Schedule Board 

In addition to booking and assigning named or real resources to your project,
you can assign generic resources to project tasks. These resources can serve as placeholders for
named resources until you are ready to staff your project with named resources. This manifests itself
mainly in the generic resource assignment and fulfilment scenario.

To do this you can type the position name of the generic resource in the
resource cell of the schedule or click the resource icon in the cell and open
the resource picker and type the name of the generic resource you wish to create.

![](media/376961383a6b6f866f04f63f6207211d.png)

This will open a team member quick create panel that allows you to set the role
and organization unit of the generic resource team member.

![](media/2b6c13d7480d09cec866c33405d17e7d.png)

Once created, it is assigned to the task and you can continue to assign that
generic resource to other tasks in the task schedule.

![](media/d8c768c0f124862621c82b9b1e606c23.png)

Once you have assigned the generic resource you can generate a resource requirement for
it and fulfil it either by directly booking or submitting a resource request to
a resource manager. Also, on the team member grid, generic resources can
be added directly in addition to the resource picker experience as documented
above. They are added with a resource requirement that is based on the start/end
dates and allocation method specified in the quick create form.

![](media/30219f2698badeaeab18b800bc7c5da1.png)

You can see a difference if you add the generic team member directly and then
assign more tasks to the generic resource than they have required hours to cover. You
can click Generate Requirement to regenerate the requirement to true up the required hours 
against assignments.

You can also click the resource requirement link in the team grid to open the requirement and add skills, preferred
resources, etc.

![](media/dfa38b56bd18fdbb4698fc6411eb3d5e.png)

### Booking a named resource directly

You can select a generic resource with a requirement and click Book on the Team tab of the project or open the resource
requirement and click the book button there.

![](media/dfa38b56bd18fdbb4698fc6411eb3d5e.png)

This will open the Schedule Assistant which you use to select and book a named
resource onto your project team.

![](media/00514ba537ffe069e2d3b8ae3236ce0a.png)

When the booking is complete and totally fulfilled by a named resource, the
generic resource is replaced with the named resource on the team.

![](media/7a92bf18953e1dd64b84e5c7f92dcfbf.png)

The assignment on the schedule is updated with the named resource as well.

![](media/dfa38b56bd18fdbb4698fc6411eb3d5e.png)

### Submitting a resource request 

You can also submit a generated resource requirement as a resource request for
fulfillment by a resource manager persona.

Once you have generated a resource requirement for a generic team member, click on the
Submit Request button.

![](media/94d4a65675b02692180f948651b7ae34.png)

The request status of the generic team member will change to Submitted.

![](media/f736aa1e89eba46a752113a76446dadc.png)

Once the request is fulfilled by the resource manager, the generic resource will be
replaced by a named resource if the resource manager has fulfilled the request
or the generic resource will remain on the team and the request status will change to Needs Review, if
the resource manager has proposed a named resource.

### Accepting or rejecting a proposed resource 

When the resource manager proposes a named resource back to the project manager,
the generic team member’s request status changes to Needs Review.

![](media/f736aa1e89eba46a752113a76446dadc.png)

Click on the arrow to open to open the team member and click on the Proposed
Resources tab.

![](media/30219f2698badeaeab18b800bc7c5da1.png)

The grid shows the proposed resource’s current bookings and bookings once the
proposal is accepted. From here you can select the proposed resource and click
Accept Proposals for them to be booked onto your team.  You can also reject the resource and resubmit the request.

![](media/376961383a6b6f866f04f63f6207211d.png)

As with directly fulfilling a generic resource with a named resource, the
generic resource will be replaced and the assigned tasks will be updated with the named team member.

## Multiple named resources fulfilling a generic resource 

Fulfilling a requirement for a generic resource with multiple real resources
follows the same flow as a single resource described above.

For example, here is a task with a duration of 5 days and effort hours of
120hrs. This task cannot be completed by one resource that works a typical 8hr
day over a 5 day week.

![](media/e07afe06cbd51a1401c163dd77ea02e1.png)

The requirement is for 120hrs of a technical consultant over 5 days.

![](media/307bbe5dfda2ccbd800bdd305f513ee5.png)

Thus, you will need to book multiple resources to fulfill the requirement.

![](media/f764852a1f13dc1130010b7fd1cd908c.png)

The main difference in this scenario is that the generic resource remains on the
team with the assignment to the task and the booked real team members are not
assigned as part of the position. The project manager will then be able to
assign the work as they see fit to the real resources. The Reconciliation view
can assist a project manager in breaking up the bookings across multiple
resources to task assignments. The reason this is not done automatically is
because in any scenario more complicated than the simple one above, such as
where you have a bundle of tasks making up the requirement, the intent of how
the project manager wants to assign, needs to be assumed by the system. Since
the system cannot understand intent, chances are the assumptions will be
different than intended and an incorrect or unpredictable result will happen.
So, the predictable outcome is that the generic remains assigned until the
project manager deliberately assigns, with the assistance of the Reconciliation
view.


