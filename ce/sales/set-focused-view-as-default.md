---
title: Enable focused view and set it as the default view
description: Enable focused view manually for entities other than contact, account, lead, and opportunity and set it as the default view for any entity in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.topic: how-to 
ms.date: 08/07/2023
ms.custom: bap-template 
---

# Enable focused view and set it as default

In focused view, sellers can view and manage their CRM records and their associated activities on one page. This view makes it easier for sellers to stay focused on their tasks and reduces the need to navigate between multiple screens. It also allows sellers to better organize and prioritize their tasks.

## To enable focused view and set it as default

Focused view is enabled by default for contact, account, lead, and opportunity entities. However, you must enable it manually for all other entities. You can also set it as the default view for any entity so that sellers don't have to switch to focused view each time they access their entity list. 
  
> [!NOTE]
>- When you set focused view as the default view, users can't switch to list view. If users must be able to use both views, set list view as the default view.
>- Focused view is not available for the Activities entity.

Use the following steps to enable focused view or set it as the default:  

1. In the Sales Hub app, select **Settings** > **Advanced Settings**.
1. On the **Settings** menu, select **Customizations** > **Customize the system**.
1. On the Power Apps Default Solution page, select **Entities** > ***Entity name***. For example, select **Entities** > **Quote**.  
1. To add the control for entities other than contact, account, lead, and opportunity, follow these steps:
    
    1. On the **Controls** tab, select **Add Control**.
    1. In the **Add Control** dialog box, select **Focused view**, and then select **Add**.
    
    :::image type="content" source="media/focused-view-control.png" alt-text="Screenshot of the Control tab with focused view added to the list of controls for the Quote entity." lightbox="media/focused-view-control.png":::
1. To set focused view as the default view, select **Focused view** for web, phone, and tablet on the **Controls** tab.  
    
    
1. Save and publish your changes.

   Focused view is now enabled and set as the default view for quotes.

### See also

[View and manage records in focused view](focused-view.md)  
[Focused view FAQs](faq-sales.yml#focused-view)
