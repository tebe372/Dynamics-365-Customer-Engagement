---
title: "Set up Dynamics 365 for Marketing | Microsoft Docs"
description: "How to run the setup wizard for Dynamics 365 for Marketing"
keywords: setup; licensing; FRE; Azure; privacy; marketing services; marketing insights service
ms.date: 06/17/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: f722b098-be63-412a-aadc-7b34d11fa668
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Purchase and set up Dynamics 365 for Marketing

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Read this topic to learn how to set up a new Dynamics 365 for Marketing instance after you have purchased a license.

> [!TIP]
> A trial version of Dynamics 365 for Marketing is also available. If you'd like to set up a trial, see [Sign up for a free trial of Dynamics 365 for Marketing](trial-signup.md) for instructions. This topic describes how to set up a production version.

<a name="how-licensed"></a>

## How Marketing is licensed

Dynamics 365 for Marketing is licensed per instance, with each instance priced according to the number of *marketing contacts* stored in your database. Marketing contacts only include those that you engage with marketing activities such as emails, landing pages, forms, LinkedIn integration, events, and surveys. Contacts that you never engage in marketing activities won't be counted as part of your Dynamics 365 for Marketing license. While you're planning your marketing activities, please be sure to purchase enough marketing contacts to remain within your quota.

> [!NOTE]
> When you sign up for Dynamics 365 for Marketing, you'll choose a licensing option that defines your contract period and various quotas for that period. Each of the contacts that you engage through marketing activities during the contract period count against your total contact quota, even if you delete, or otherwise stop marketing to, an existing marketing contact during the contract period. You can only reduce your purchased contact quota on contract renewal date.

Unlike most other Dynamics 365 for Customer Engagement apps, Marketing isn't priced per user, so users already licensed to access any Customer Engagement app on an instance where Marketing is installed will also be able to access Marketing without requiring you to purchase any additional licenses. You can even request any number of free (&quot;zero dollar&quot;) Marketing licenses to assign to users that don't have a Customer Engagement license, but these aren't valid for apps other than Marketing.

In some cases, you may be entitled to a free Marketing license for one or more of your Customer Engagement instances. This may be triggered by purchasing a Customer Engagement app bundle and/or by purchasing a certain minimal number of seat licenses for your other Customer Engagement apps. Free licenses such as these usually also include a limited quota of free marketing contacts, which you can increase by purchasing additional capacity.

You can choose to run your marketing pages, landing pages, and events website either on an external web server (such as your own CMS system) or on a Dynamics 365 portal running on the same tenant as your Dynamics 365 for Marketing instance. If you want to run these features on a Dynamics 365 portal, then you must have a free portals license available on your tenant before you run the Dynamics 365 for Marketing setup wizard, but if you will use an external website, then no portals license is needed. (Depending on the Dynamics 365 for Marketing licensing plan you have chosen, your license may include a free portal provided no other free portals are already in use on your tenant.) [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Decide whether to install Dynamics 365 for Marketing with or without a Dynamics 365 portal](portal-optional.md) and [When do I need a portal license, and how can I get one?](setup-troubleshooting.md#why-portal)

For more information about licensing, see the [Administration and setup FAQ](setup-troubleshooting.md). For complete licensing details, including specific quotas and other conditions, see the  [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).

## Prerequisites and requirements

> [!IMPORTANT]
> To run the setup wizard, you must meet all the following requirements:
> 
> - You must already have a Microsoft 365 tenant.
> - An unconfigured Dynamics 365 for Marketing app must be available on your tenant.
> - **You must be running [!include[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] or higher** (supplied together with most trial and stand-alone Marketing setups).
> - You must not already have a Dynamics 365 for Marketing app installed on your Customer Engagement instance. You can have at most one Dynamics 365 for Marketing per Customer Engagement instance, and each  Dynamics 365 for Marketing app can only be used with one Customer Engagement instance.
> - You must sign into your tenant with a user account that has all the following:
>   - Admin privileges on the Customer Engagement instance where you are installing Marketing.
>   - Permissions to register applications in [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)]. The global administrator always has this right, but other accounts can also have it. See [Do I have permissions to register applications on Azure?](setup-troubleshooting.md#register-apps-azure) for information about how to confirm this setting for your account.
> - A known issue currently prevents you from running the setup wizard unless you have a Customer Engagement license assigned to you on your tenant. However, although most of our customers do have this license, it's not actually required by the terms of the Dynamics 365 for Marketing license agreement. A workaround is available for users who need to install Marketing without having a Customer Engagement license assigned to them&mdash;see [Configuration, installation, and first-run experience](readme.md#configuration-installation-and-first-run-experience) in the readme for details.
> - If you want to integrate with a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal (optional), then an unconfigured portal app must be available on your tenant. Depending on the Dynamics 365 for Marketing licensing plan you have chosen, your license may include a free portal (provided no other free portals are already in use on your tenant), or you may need to purchase a portal license before you can set up the integration. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [When do I need a portal license, and how can I get one?](setup-troubleshooting.md#why-portal)
> - You must be located in a country/region where the product is supported. To read the latest list of countries/regions where you can use Dynamics 365 for Marketing, download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).
> - Close all other browser windows and tabs before starting.
> - Clear your browser cache before starting.
> 
> If you run into trouble while working with the setup wizard, see the [Administration and setup FAQ](setup-troubleshooting.md) for some possible solutions.

> [!IMPORTANT]
> Your system is constrained by certain limits and quotas that apply to the number of contacts you can market to, monthly email messages you can send, Litmus previews you can view, and more. Please familiarize yourself with the terms and limits of the product before you begin to use it. The limits are different based on whether you are running a trial, preview, or subscribed version of the product.
> 
> - For subscribed (paid) versions, please download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).
> - For trial and previews, see [Dynamics 365 for Marketing limits for trials and previews](trial-preview-limits.md).
> 
> You can keep an eye on your usage levels by going to  **Settings**  >  **Advanced settings**  >  **Other settings**  >  **Quota limits**  in Dynamics 365 for Marketing. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Quota limits](quota-management.md)
> 
> See also the  [Readme](https://go.microsoft.com/fwlink/p/?linkid=864736) document for the latest news and updates.

> [!IMPORTANT]
> Problems can occur if you try to reinstall Dynamics 365 for Marketing on an instance where it was previously uninstalled. Before you can reinstall Marketing onto an instance where it was previously uninstalled, you must do one of the following:
> 
> - [Reset the instance](../admin/manage-sandbox-instances.md#BKMK_Reset) before starting to reinstall Marketing (only possible on sandbox instances).
> - If a reset isn't possible (for example, because you aren't working with a sandbox instance) then please [contact Microsoft Support](setup-troubleshooting.md#contact-support) before attempting to reinstall Marketing.

## Add a Marketing app to your Microsoft 365 tenant

There are many ways to add one or more Marketing apps to your Microsoft 365 tenant. For example, you can purchase it from the [Dynamics 365 for Marketing overview page](https://dynamics.microsoft.com/en-us/marketing/overview/), or by going to **Billing** > **Purchase services** in your Microsoft 365 admin center, or by contacting your Microsoft sales representative or channel partner. As mentioned previously, you might even qualify to have a free Marketing app added to your tenant.

- On purchasing a license, an unconfigured Dynamics 365 for Marketing app will be automatically added to your tenant.
- If you are entitled to a free license, then see [My Customer Engagement license agreement entitles me to a free Dynamics 365 for Marketing license. How can I get the free app added to my tenant?](setup-troubleshooting.md#claim-free-license) for details about how to find or obtain it.

You can have any number of Marketing apps available on your tenant. Initially, each of these apps will be unconfigured and unassigned to any [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instance. Later, you'll run the Marketing setup wizard to assign the app to an instance and configure it.

## Run the Marketing setup wizard

After purchasing your license for Dynamics 365 for Marketing, you'll have an unconfigured Dynamics 365 for Marketing app available on your tenant, but you still need to set it up for use. The Marketing setup wizard will help you review all the relevant privacy policies and set up and integrate its various elements.

To set up a new Marketing instance:

1. Go to [admin.microsoft.com](https://admin.microsoft.com) and sign in to your Microsoft 365 tenant using an administrator account that has a Dynamics 365 for Marketing license assigned.

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Go to the **Applications** tab of the Dynamics 365 for Marketing admin center.
   > [!IMPORTANT]
   > Don't work on the **Instances** tab when setting up Marketing. Though you can open details about an instance there and see that the various Marketing apps and solutions are available, your setup is likely to fail or be incomplete if you try to work from there.

   ![Set up Marketing using the Applications tab, not the Instances tab](media/purchase-app-tab.png "Set up Marketing using the Applications tab, not the Instances tab")

1. Find and select an unconfigured **Dynamics 365 Marketing Application** in the list on the **Applications** tab. Then choose **Manage** from the side panel.  

    ![Choose an app and then select the Manage button](media/purchase-manage-button.png "Choose an app and then select the Manage button")

   > [!NOTE]
   > If you see the Marketing app listed several times, then you probably have several Marketing apps available on your tenant. Marketing apps that are already configured show an instance ID appended to the app name and show a value of **Configured** in the **Status** column. Marketing apps that aren't assigned show a value of **Not configured** in the **Status** column and don't include an instance ID in their name.

1. The setup wizard launches, which you will use to make initial settings for the app. The first page of the wizard lets you choose where you will install the app and to choose whether to set up a portal to run your marketing pages and event website.

    ![Choose an organization and name your portal](media/setup-form-1.png "Choose an organization and name your portal")

1. From the top drop-down list, select the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization where you want to add Dynamics 365 for Marketing. (A [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] *organization* is another name for a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] *instance*.)

1. Select one of the following **Web hosting** options ():
    - **Use own webserver**: Select this option if you will run your landing pages and event website on an external webserver or CMS system. This option doesn't require a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals license and won't install the portal.
    - **Use Dynamics 365 portals**: Select this option if you will run your landing pages and event website on a dedicated [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal running on your tenant and linked to  your Dynamics 365 for Marketing instance. This requires a dedicated [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals license, but in some cases a portals license may be included with your Marketing license. 

    [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Decide whether to install Dynamics 365 for Marketing with or without a Dynamics 365 portal](portal-optional.md)

1. If you selected to **Use Dynamics 365 portals**, then enter a prefix for your portal URL in the field provided. You can also see what the full URL will be here. All your portals are hosted on your tenant, which uses a [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]-owned domain name, plus the subdomain name that you choose here. Your contacts and customers can see the URL when they open a portal, so you should choose a subdomain name that they will recognize, such as your organization's name. The subdomain that you choose must also be unique among all other subdomains in the same tenant; you'll be notified to try again if you pick one that's already in use.

1. Select  **Continue**  to continue. Dynamics 365 for Marketing includes several services, solutions, and apps, some of which require you to consider and accept various license agreements and privacy statements. The second page of the setup wizard lists each of these and provides links for more information. It also asks you to enter your organization's postal address.

    ![Provide consent and enter your postal address](media/setup-form-2.png "Provide consent and enter your postal address")


1. Carefully read the consent text shown for each check box, and follow the links to make sure you understand all the relevant issues. If you agree with the terms, then mark each check box as you go to indicate your consent. Some of these are optional, so you can still use the product without them, though the related features will be disabled. Other features are required, so you won't be able to use Dynamics 365 for Marketing without agreeing to them.

2. Type the full physical street address for your organization in the field provided. All marketing email messages sent by Dynamics 365 for Marketing must include the physical street address of your organization, and several other required elements. These requirements help maximize email deliverability while also helping make sure you conform to common legal requirements for marketing email.  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Best practices for email marketing](get-ready-email-marketing.md)

3. Select  **Setup**  to start setting up the app. A page will open that tracks the setup progress, which typically takes about three hours to set up a paid instance.

## Privacy notice

[!INCLUDE[cc-privacy-marketing-fre](../includes/cc-privacy-marketing-fre.md)]

### See also

[How Dynamics 365 for Marketing uses cookies](cookies.md)  
[Engage with customers online with portals](portals.md)
