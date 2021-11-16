---  
title: "Trial FAQ - Dynamics 365 Sales Enterprise | Microsoft Docs"
description: "Solutions to common questions related to Dynamics 365 Sales Enterprise trial sign up and management. Learn how to resolve platform and app-specific issues."
author: lavanyakr01
ms.author: lavanyakr
ms.date: 08/31/2021
ms.topic: get-started
ms.service: dynamics-365-sales
ms.custom: template-trial-faq
ms.reviewer: shujoshi
---
# Dynamics 365 Sales Enterprise trial FAQ 

The Sales Enterprise trial offers a straightforward experience for sign-up, login, and usage. However, if you're stuck or have questions about the trial, check out this page for answers.

[!INCLUDE[trial-faq-platform](../shared/trials/trial-faq-platform.md)]

### Can I convert the trial to a paid license?

Yes, you can purchase licenses through direct, credit card purchase at admin.microsoft.com. Or, you can work with sales to establish a volume licensing or enterprise agreement. Visit our [Pricing page](https://dynamics.microsoft.com/pricing/) for more information on pricing and purchasing.

To purchase the license using an existing account, work with the administrator of the account to apply for licenses.

After you have applied for the license to your tenant, you can publish your environment to production. You can remove the sample data. However, you have to manually reset the configuration and remove any test data that you've added. We recommend that you create a fresh environment to use for your production environment and add the configurations you’d like to move forward with.

### What are the trial limits and quotas?

The following limitations apply for the trial:

- The trial is available to you for 30 days. After that, you can request for an extension for another 30 days, buy a paid license, or sign up for a new trial.  
- The trial will expire if there’s no activity on the app for 14 consecutive days. Expired trials cannot be reactivated. However, you can start a new trial.  
- You can have only one active trial per app at a time. You can sign up again after your current trial for the app ends.

## Dynamics 365 Sales Enterprise-specific questions

### How do I start using the trial?

When the trial is ready, you can get started with the following resources:

**Explore product tours and videos for key capabilities**

The trial comes with product tours and videos, highlighting the important scenarios that you could try in the app and get the maximum value in minimal time. Select the **Get started** page and open the tour for the scenario that you are interested in. Once you understand how different entities are connected to offer value, try the scenarios with sample data or with your own data. 

**Play around with the mobile app**

Install the Sales mobile app and explore the functionalities that you can access on the move. Open the **Get started** page and scroll down to the **Take it to go** section to download the app. For more information on using the app, see [Use the Dynamics 365 Sales mobile app](sales-mobile/use-sales-mobile-app.md). If you run into issues, see [What should I do if I don't see any apps in the mobile app](#what-should-i-do-if-i-dont-see-any-apps-in-the-mobile-app). 

**Deep dive into more scenarios**

If you want to test scenarios beyond the ones covered in the product tour, go ahead and take a plunge. Browse through other capabilities from the sitemap (left pane). Visit the [Help hub](help-hub.md) for assistance.

### What features are available in the trial?

Your trial includes a simplified Sales Enterprise Trial app with a few important capabilities to get you started quickly. However, you can access the fully functional, Dynamics 365 Sales Premium environment with the following licenses and capabilities pre-installed:

**Dynamics 365 Sales Enterprise**
- Manage sales pipeline from lead to cash
- Manage sales forecasting
- Manage products, goals, playbooks
- Enable seamless collaboration by integrating Dynamics 365 with Microsoft Teams

To get started with the Sales Enterprise functionalities, see [Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md)

**Dynamics 365 Sales Insights**

- Sell smartly using Sales accelerator that builds a strong and prioritized pipeline, offers context, and surfaces automated recommendations
- Improve seller coaching and sales potential with conversation intelligence
- Get the AI-powered assistant to stay on top of your activities
- Prioritize leads and opportunities using predictive scoring
- Analyze revenue outcome by using predictive forecasting

To get started with the Sales Insights functionalities, see [Sales Insights Add-in for Dynamics 365 Sales Help & Training](/ai/sales/help-hub). To enable Sales Insights, see [Enable and configure standard Sales Insights features](/ai/sales/intro-admin-guide-sales-insights#enable-and-configure-standard-sales-insights-features).

> [!NOTE]
> Sales Insights functionalities are restricted to specific regions. For information on supported regions, see [In which region is Sales Insights available?](/ai/sales/faqs-sales-insights#general). If you are not in a supported region, you can only  access the Sales Enterprise functionalities.  

**Dynamics 365 Power Platform**
- Administer and customize your Dynamics 365 Sales environment to fit your needs  

### What should I do if I don't see any apps in the mobile app

When you log into the Dynamics 365 mobile app for the first time, you might encounter the following message:

```You currently have no apps```

**To view your trial apps,**

1. Select your avatar on the mobile app and select **Settings**.  

1. Enable the **Show non-production apps** option.  
    You can now see all the apps that you've access to. 
1. Select **Sales trial** to log into your trial. 
 
### Why is the sample data not available to all trial users?

Sample data related to forecasting and Sales accelerator are only available to the user who signed up for the trial. 

**To give access to other trial users**: 

1. Select **Leads** in the sitemap (left pane).  
1. Select the sample data and select **Assign** in the command bar. 
1. In the **Assign to** field, select **User or Team** and then pick the user or team name. 
   If you haven't created the team yet, you can select **New Record** in the **User or Team** drop-down to create a team and add the trial users. You can then come back and perform steps 1 to 3.

### How do I remove sample data from the trial?

Sample data resembles real life data and helps you learn how the product works if it was deployed in an organization. In some cases, you may want to remove sample data. For example, the sample data is interfering with the scenarios you want to try out.

**To remove sample data:**

1. In the Sales sitemap, select the **Get Started** page.  
1. Scroll down to the **Manage sample data** section and select **Remove sample data**.
     After you confirm, it takes a few seconds to remove the sample data.
    > [!NOTE]
    > This action doesn't delete the data that you have added in the trial app.

### How do I restore sample data?

If you have modified the sample data and want to restore it back to the original, you can do so.

**To restore sample data:**

1. In the Sales sitemap, select the **Get Started** page.  
1. Scroll down to the **Manage sample data** section and select **Remove sample data**.  
1. After the existing sample data is completely removed, you'll see **Add sample data**.  
1. Select **Add sample data** to add the fresh sample data.

### Is the Sales trial available in all geographical regions?

Though you can sign up for the trial from any region, the Sales Insights functionalities are restricted to specific regions. For information on supported regions, see [In which region is Sales Insights available?](/ai/sales/faqs-sales-insights#general). If you are not in a supported region, you can only access the Sales core functionalities.   

### See also
- [Sign up for a free trial](sign-up-for-sales-trial.md)
