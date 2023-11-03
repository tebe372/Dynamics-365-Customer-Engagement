---
title: Remove Omnichannel for Customer Service
description: Perform the steps mentioned in the article to remove Omnichannel for Customer Service and disable all the messaging channels in an organization.
author: neeranelli
ms.author: nenellim
ms.topic: how-to
ms.date: 11/03/2023
ms.reviewer:
ms.collection:
ms.custom: bap-template
---

# Remove Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can remove Omnichannel for Customer Service and disable all channels for a Dynamics 365 Customer Service organization.

> [!NOTE]
> Omnichannel for Customer Service is automatically removed if you do any of the following:
>
> - Delete the Dynamics 365 CRM instance from the Dynamics 365 admin center.
> - Reset the Dynamics 365 CRM instance from the Dynamics 365 admin center.
> - Modify or change the Dynamics 365 CRM instance to a different organization ID.
>
> Removing Omnichannel for Customer Service will not delete Omnichannel solutions. To delete Omnichannel solutions, see [Delete Omnichannel solutions](delete-solution.md).  

To remove the Omnichannel for Customer Service from the organization,

1. In **Power Platform admin center**, on the **Environments** page, select the environment in which you wan tto remove Omnichannel for Customer Service.

    > [!div class=mx-imgBorder]
    > ![Manage omnichannel.](media/OC-provisioning-ppadmin.png)

2. In the left pane, expand **Resources**, and select **Dynamics 365 Apps**.
3. On the **Dynamics 365 apps** page, select **More commands** beside **Omnichannel for Customer Service**, and then select **Manage**.
4. On the **Manage *<environment_name>*** page, select **Delete**.

    ![Remove button on the Manage Omnichannel instances page.](media/choose-remove-manage-instances.png "Remove button on the Manage Omnichannel instances page")

5. In the confirmation dialog box, select **Remove** to proceed.

    > [!div class=mx-imgBorder]
    > ![Remove confirmation dialog box.](media/removal-confirmation-dialog-box.png "Remove confirmation dialog box")

> [!IMPORTANT]
> When you remove Omnichannel for Customer Service, all channels in the selected organization are disabled.

If you need Omnichannel for Customer Service again, you can enable it from the **Manage environments** view.

## Next steps

[Uninstall solutions in Omnichannel for Customer Service](delete-solution.md)  

### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Delete Omnichannel solutions](delete-solution.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
