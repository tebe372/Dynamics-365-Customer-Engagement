---
title: "Dynamics 365 for Marketing Readme (Known Issues) | MicrosoftDocs"
ms.date: 11/27/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: 
- Dynamics 365 for Customer Engagement (online)
- Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 78dc5157-cf1d-4e32-ace7-9e71763e7510
author: kamaybac
ms.author: kamaybac
manager: annbe
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Dynamics 365 for Marketing readme

This document provides important, late-breaking information about known issues and workarounds for Dynamics 365 for Marketing.

## Trials

- Trials are subject to the [Dynamics 365 for Marketing trial limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).
- You can't use the sign-up process to add more users to a Marketing trial that is running on a trial tenant without a mailbox set up for the organization admin. Instead, each new user must be added in a specific way. For more information, see [Add more users to a Marketing trial running on a trial Office 365 tenant](trial-signup.md#add-users).
- You can't sign up using an \@microsoft.com email address. If you are a Microsoft employee and would like to sign up for a trial, follow the instructions given in [Sign up for a managed Office 365 trial tenant and install the Marketing trial on it](trial-signup.md#get-managed-tenant).

## Configuration, installation, and first-run experience

### Known issues

- The setup process can take up to two hours. The process might restart automatically during this time, which can result in multiple success (or failure) notifications being sent to you by email.
- When a Dynamics 365 for Marketing customer has a license for the Marketing product but does not have a CRM license, any attempt to install the Marketing application will fail. As a temporary workaournd, a Marketing customer can install a trial CRM Customer Engagement plan, which would work for 30 days. For more details on creating a trial, click here. <!--- 1183223 -->

### Fixed issues

- You will now always receive an email summarizing the outcome of your setup.<br><del>*First-run experience success and failure emails sometimes aren't delivered.*</del>

## Customer journeys

### Known issues

- Triggers set to react to a specific "link clicked" after an email tile show multiple options for the same link. These triggers might not work correctly because clicks are not always attributed to the correct link. <!--- 759533 -->
- Deactivated contacts won't receive any emails from journeys they were participating in, but they might continue to be included in other actions, such as tasks and workflows. <!--- 759533 -->  
- Insights for journeys, emails, and marketing pages may take up to six hours to display.
- If you stop a live customer journey, then add contacts to the target segment, and restart the journey, those added contacts might receive emails sent by this journey more than once. <!-- 1196442 -->
- On non-English instances, when you save a customer journey using the **Save as template** function, the resulting template always gets saved with its language set to English. To fix this, go to **Marketing > Customer journey templates**, open the template, and change its **Language** setting to the correct value. When you're creating a new customer journey from a template, you can use the template gallery's **Language** drop-down list to show templates in any selected language. <!-- 1287079 -->

### Fixed issues

- Users can now check for errors on both the **General** and **Designer** tabs of a customer journey.<br><del>*The “checking for errors” operation triggered in the customer journey’s **General** tab results in a time-out. Users can continue   to “check for errors” from the **Designer** tab.*</del> <!-- 1208237 -->
- The snapshot view generated for a customer journey now displays all tiles.<br><del>*The snapshot view generated for journeys might be missing some tiles.*</del>  <!--- 690797 -->

## Segmentation

### Known issues

- Segment names can't have spaces&mdash;use underscores instead.<!-- 695837 -->
- You can't include lookup fields among your segmentation criteria.<!-- 852372 -->  
- Metadata used for building conditions and drop-downs shown on the designer isn't localized for non-English organizations. <!-- 992449 -->
- The **Save** button isn't visible on the command bar after the initial save of the segment. Use the **Save** button in the lower-right corner of the page instead. <!-- 862491 -->
- When trying to estimate the size of a segment where the query doesn't end in a contact, the system displays a server communication error. To correct this error, make sure your segment definition ends with a clause that links to the contact entity as described in [Design profile-based dynamic segments](segments-profile.md). <!-- 1226384 -->
- When you're adding members to a static segment, you can filter the list of available contacts to find the ones you want to add. Sometimes, after adding some filters and selecting **Apply**, the segment definition may stop showing its members. To fix this, save the segment, go back to the segment list, and then reopen it; you should now see the list of members and can continue working on it. <!-- 1282842 -->
- Static segments are limited to a maximum of 1600 members.

### Fixed issues

- Subscription lists now remove unsubscribed contacts from running journeys.<br><del>*Dynamic segments based on subscription marketing lists don't remove unsubscribed contacts from running journeys. The unsubscribe request will be honored in future journeys.*</del>.
- When you go live with a new segment, the **Members** tab now displays correct status messages as the segment is being provisioned.<br><del>*If you go live with a new segment and then open the **Members** tab right away, you'll see a message telling you that the segment doesn't exist (even though it does). Reload the page, or open another tab and come back, to view the correct message (that the segment is being provisioned). Later, once the segment is finished provisioning, you'll see the list of contacts it contains here.*</del> <!-- 1251946 -->

## Email marketing

### Known issues

- The default content-settings record must be live before you can send any marketing emails or view heatmaps on **Insights** pages. Usually, the default content-settings record goes live automatically when your setup is complete, but sometimes this isn't the case. To solve this, set up and publish your default content-settings record manually as described in [Use content settings to set up repositories of standard and required values](dynamic-email-content.md#content-settings).
- Selecting **Stop** on a live email will prevent it from being used in future journeys, but it will continue to function in existing live journeys, which will continue to deliver it.
- If you reuse the same email multiple times (within the same journey or in different journeys) you will see incorrect performance results on its **Insights** pages.
- Many email templates have placeholder images. You should replace these placeholder images with actual images so that marketing emails look professional.
- For certain organizations that upgraded recently, test send may not work. If you encounter this issue, please contact Microsoft Support.<!-- 1267485 -->
- The email designer requires that you be very careful when entering code for advanced dynamic content. It's easy to produce non-working code. If you want to use this feature, be sure to review the notes given in [How to enter code in the designer](dynamic-email-content.md#enter-code)
- Support for dynamic email content is being expanded to include look-up values, relations, and logical functions like conditionals and for-each loops. We are rolling this capability out gradually, so it may not yet be available on your tenant. For more information about this feature, and how to find out if it's available to you, see [Advanced dynamic content](dynamic-email-content.md#advanced-dynamic-content). Be sure also to read [How to enter advanced dynamic content in the designer](dynamic-email-content.md#enter-code) for important tips on how to mix these dynamic features into your designs.

### Fixed issues

- When you create a new keyword, the **Save and close** button now correctly returns you to the **Keywords** list.<br><del>*When you save a new keyword for templates or files from a quick-create form, the keyword list isn't displayed, but the record is created successfully.*</del> <!-- 1033440 -->

## Marketing pages and forms

- When configuring a form on a page, we recommend that you enter a confirmation message or a redirect URL, so users can see that they successfully submitted the form.
- It can take up to a minute after a marketing page goes live before its public link (full page URL) is ready. Visitors might see an error message on the page prior to this.
- Marketing pages from the sample data might not go live for some organizations (especially on Italian or Japanese localizations). But you can still create new pages and go live with them. <!-- 1156824 -->
- Forms submitted over HTTP (not HTTPS) generate interaction records that don't include the contact ID, which means these interactions can't be used in interaction-based segments. If you are hosting a form on an external page (not hosted on a Dynamics 365 for Marketing marketing page), then make sure your page uses HTTPS.
- Some client-side malware protection tools parse each incoming email, resolve all the links it contains, and then deliver a modified message in which the links have been replaced with their resolved destinations. This process can interfere with the mechanism that Dynamics 365 for Marketing uses to identify the contact that has clicked on a subscription center link, which means the subscription center won’t work for these contacts. We are working on a fix for this issue.
- The default lead-matching strategy for landing pages matches email address and landing-page ID (msdyncrm_marketingpageid). Currently, a limitation in the UI means that it's not possible to add the landing-page ID to any new or existing lead-matching strategy. Therefore, you shouldn't remove this attribute from the provided default lead-matching strategy unless you are sure you will never use this kind of strategy. If you have removed this attribute and need it back, or if you need to add it to a custom lead-matching strategy, please contact Microsoft Support. More information: [Set matching strategies](marketing-settings.md#matching-strategy) <!-- 1309673 -->

## Reusable content blocks

- Any CSS styles that you include in your reusable content blocks could be overruled by styles in the document where you eventually host the content. If you want to prevent this, design your content blocks with inline styles that include the `!important` attribute.

## Lead scoring and management

- Lead scoring results might take up to one hour to be calculated.
- When you're creating lead scoring rules, drop-down lists might not be localized for non-English languages.
- When you're creating a lead scoring model and add a condition, the "Email sent" condition isn't shown in the list of options. Use the "Sent" condition instead. <!--- 1289271 -->

## Insights

### Known issues

- Web interactions performed by a contact when they were anonymous are currently not attributed to them when the contact is created. These interactions can be viewed under the related entity (marketing page, website etc.) and are leveraged to compute the insights for the entity. <!--- 1276305 --> 

## Event management

### Known issues

- If you disable anonymous registration for the event portal, then customer organizations must create a registerer account using the portal, after which the registerer can register as many attendees from their organization as needed. However, the registerer can't use the portal to create an account using an email address that belongs to a contact already in Dynamics 365 for Marketing. To set up an existing contact as a registerer, create a [portal invitation](../portals/invite-contacts.md) and then send the invitation code to the contact by email.
- Even though surveys are available in the app (such as for emails, journeys, and events), this feature currently has limited functionality. Anonymous surveys can be added to emails but can't serve as triggers in customer journeys. Please contact Microsoft Support for more information.
- When you create a recurring event with a weekly cadence, the check box for **Monday** is automatically selected both when you first create the event series, and each time you open the event series for editing. Any time you create or edit a weekly series, be sure to clear the **Monday** check box if you don't mean to include it.

### Fixed issues

- Events now have sample data.<br><del>*Sample data is no longer available for events. We expect to provide it again in a future update.*</del>
- The event website installed on your Dynamics 365 portal is no longer overwritten after each app update, so any customizations you make to that site will be preserved when you update the app.<br><del>The event portal included with Dynamics 365 for Marketing is intended for demo and testing purposes only. Any customizations that you make to the sample event portal will likely get overwritten the next time you update Dynamics 365 for Marketing.</del>

## Videos

- When you add a video to a marketing page, the **Designer** tab shows it as a thumbnail image rather than as an embedded video in an iframe. However, the embedded video iframe will still be shown correctly on the live page when you publish it. <!-- Provided as a tip -->
- When you add a video to a marketing page or email, its thumbnail isn't shown on the **Preview** tab of the designer. However, the video is embedded correctly and will be shown in delivered emails and live marketing pages. <!-- 1277775 -->

## Social listening for campaigns

- The [social listening feature](https://docs.microsoft.com/en-us/business-applications-release-notes/October18/dynamics365-marketing/marketing/social-listening-campaigns) currently requires that you set it up manually as described in [Integrate Social Engagement with Dynamics 365 for Customer Engagement](../social-engagement/integrate-social-engagement-dynamics-365.md). We will soon roll out a smoother setup experience fine-tuned for the Marketing app. Keep an eye on the [Dynamics 365 Team Blog](https://blogs.msdn.microsoft.com/crm/) for updates.
- The social listening control may not show data on some Dynamics 365 for Marketing instances. If you experience this issue, please contact Microsoft Support. <!--- This is for the UCI FCB that's required to be switched on, and requires a platform upgrade. We can also manually flip this FCB on an org by org basis by updating a DB value -->

## Designer feature protection

- Designer feature protection enables admins to limit access to the HTML tab and/or Litmus previews for content designers. However, the protection only applies to users who have read access to the *Designer Feature Access* entity. Users without this read access will always be able to see the HTML and Litmus features, even if you use designer feature protection to block them. To solve this, make sure all user roles provide read access to the *Designer Feature Access* entity. If you are using the out-of-box user roles supplied with the product, then these should automatically update to include this access when you apply the October 2018 (or later) update, but if you use custom user roles you need to add this access explicitly after updating. More information: [Manage security, users, and teams](../admin/manage-security-users-and-teams.md)

## Websites

- The *websites* feature records all visits to any web page that has a Dynamics 365 for Marketing tracking script on it. Each log entry includes a timestamp and, if possible, links to a known contact. If the visitor isn’t a known contact, then that visit is logged as anonymous. The website tracking script sets a cookie, so the system can group visits into sessions, even for anonymous visits. When a contact submits a landing-page form, the system sets the same cookie (if not present already) and can thereafter match the cookie ID to a contact ID because the landing-page submission will either create or match a contact. Once a visitor is known, all future website visits will be logged with that user's ID. However, previous visits will remain anonymous (the system doesn't back-fill the contact ID to the existing visitor log).

## General

- If you have different Dynamics 365 for Marketing sessions open in other browser windows or tabs, and then open the Marketing app in the same browser, it will authenticate using the same user that you have open in the other sessions. We recommend that you restart the browser each time you need to sign in using a different user account.
- Please refrain from deactivating publishable Marketing records. Instead, set the publishing states (Status Reason), and use **Stop** buttons to manage records that are no longer required. More information: [Go live with publishable entities and track their status](go-live.md)
- Dynamics 365 for Marketing is currently supported only on the following browsers: Microsoft Edge, Google Chrome, and Apple Safari on Mac. More information: [Browser and system requirements](browser-requirements.md)
- Right-to-left (RTL) language support currently has the following limitations: the segmentation designer is usable, but shows its user-interface elements in the wrong order; and the supplied content samples (marketing-page templates, email templates, form templates, and event website) aren't provided in RTL layouts.
