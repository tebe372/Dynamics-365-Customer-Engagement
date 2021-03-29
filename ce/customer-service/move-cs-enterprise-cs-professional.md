---
title: "Move from Dynamics 365 Customer Service Enterprise edition to Dynamics 365 Customer Service Professional | MicrosoftDocs"
description: "Follow the steps in this topic to move from Dynamics 365 Customer Service Enterprise edition to Dynamics 365 Customer Service Professional."
ms.date: 03/29/2021
ms.service:
  - "dynamics-365-customer-service"
ms.topic: article
author: platkat
ms.author: ktaylor
manager: shujoshi
---

# Move from Dynamics 365 Customer Service Enterprise to Dynamics 365 Customer Service Professional

Customer Service Professional is targeted at businesses that have fewer needs and do not require the full capabilities Customer Service Enterprise. If you ever want to switch from Customer Service Enterprise to Customer Service Professional, do the following:

1.	Purchase a Customer Service Professional subscription.

2.	Assign Customer Service Professional licenses to the users and remove the Customer Service Enterprise licesnses from the users.

3.	Review the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).


## Purchase Dynamics 365 Customer Service Professional subscription

1.  Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the Dynamics 365 account that has admin permissions.

2.  In the navigation pane, expand **Billing** and select **Purchase Services**, and then select the Dynamics 365 Customer Service Professional tile. 

    **KAT: COULD NOT VERIFY WITH CONTOSOSUITESP ADMIN ACCOUNT.**
<!--
    > [!div class="mx-imgBorder"]
    > ![Select Dynamics 365 Sales Professional tile](media/select-dynamics365-sales-pro-tile.png "Select Dynamics 365 Sales Professional tile") 
-->
3.  Select **Buy**, and then follow the steps to purchase new licenses. 
<!--
    > [!div class="mx-imgBorder"]
    > ![Select Buy](media/buy-sales-professional.png "Select Buy") 
-->

## Assign and remove licenses

After you’ve purchased the licenses, assign the licenses to users. 

1.	In the Microsoft 365 admin center navigation pane, select **Users** > **Active users**.

2.	Select multiple users, and then select **Manage product licenses**. 
    
    > [!div class="mx-imgBorder"]
    > ![Assign licenses to multiple users](media/assign-licenses-multiple-users.png "Assign licenses to multiple users")

3.	Select **Replace** to unassign existing licenses and assign new ones. 

4.	Select the license for your Dynamics 365 Customer Service Professional plan. 

    **KAT: COULD NOT VERIFY WITH CONTOSOSUITESP ADMIN ACCOUNT. The only option available was Dynamics 365 Customer Engagement plan.**
    
    > [!div class="mx-imgBorder"]
    > ![Assign licenses to multiple users](media/assign-licenses-multiple-users.png do-not-use-d365-ce.png "CE Plan licenses")

5.	Click **Save changes**. 

6.	Review the license status on the **Active users** page and make other assignments as needed. 


> [!IMPORTANT]
> As per contractual agreement, you can't mix and match Enterprise and Professional users on the same instance. If you plan to keep Professional licenses, make sure you abide by the contractual requirements. More information: [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)


### See also

[Dynamics 365 Licensing Update](https://docs.microsoft.com/dynamics365/licensing/update)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
