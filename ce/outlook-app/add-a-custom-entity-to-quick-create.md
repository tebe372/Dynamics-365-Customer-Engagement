---
title: "Add a custom table to the quick create menu in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Add a custom table to appear to the quick create menu in Dynamics 365 App for Outlook.
ms.date: 04/28/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Customize which tables appear in quick create  

An app maker can enable a table or a custom table to appear in the create **New** menu (quick create) in Dynamics 365 App for Outlook. 



|Before: Quick create menu  |After: Quick create menu with custom table added |
|---------|---------|
| ![Quick create menu before adding a new table](media/custom-table-before.png)     |     ![A custom table has been added to the quick create menu](media/custom-table-after.png "Power Apps mobile user interface with model-driven and canvas apps")  |


## Step 1: Enable a table to appear in **New** (quick create) menu

1 Sign in to [Power Apps](https://make.powerapps.com).

2. On the left nav, select **Data** to expand it and then select **Tables**.  

   > [!div class="mx-imgBorder"]
   > ![Go to Tables in maker portal](media/maker-data-tables.png)
   
  
3. Select a table then on the command bar, select **Settings**. 

   > [!div class="mx-imgBorder"]
   >![Select settings](media/maker-row-settings.png "Select setting")

5. Expand **More settings** > **Create and update settings** and then select the checkbox for **Enable quick create forms**.

   > [!div class="mx-imgBorder"]
   > ![Enable the table for quick create](media/enable-table-quick-create.png)

6. Select **Done** and then **Save Table**.

## Step 2: Create a quick create form  
  
1. Sign in to [Power Apps](https://make.powerapps.com).

2.  Expand **Data**, select **Tables**, select the table that you enabled for **Enable quick create forms** , and then select the **Forms** tab.  

   > [!div class="mx-imgBorder"]
   >![Select the forms tab for the table](media/table-forms-tab.png)

3.  On the toolbar, select **Add form** > **Quick Create Form**.  
  
4.  In the form designer drag any columns from the **Column Explorer** into the sections on the form.  
  
5.  When you are finished, select **Save**.  
  
6.  Select **Publish** to see the new form in the application.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
