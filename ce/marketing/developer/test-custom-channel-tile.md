---
title: "Step 4: Test your custom channel tile (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Provides information on how you can make the custom channel tile available in the customer journey designer in Dynamics 365 Marketing."
keywords: developer; dev; developer guide; system configuration
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: developer-guide
ms.assetid: 1f1a8244-2dc5-4de2-b7f8-719a46c82861
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Step 4: Test your custom channel tile

To make the custom channel tile available in the customer journey designer:

1. Create a solution. More information: [Create a solution](/powerapps/maker/common-data-service/create-solution)
2. Add the tile CSS file as a **Style Sheet (CSS)** web resource to the solution you created. Note the generated file name as the name will contain publisher prefix (for example, sample_). This file name needs to be used in the tile XML file. More information: [Create or edit web resources to extend a web application](/powerapps/maker/model-driven-apps/create-edit-web-resources)
3. Add the tile XML file as a **Data (XML)** web resource to the solution you created. The file name must end with 'CustomerJourneyDesignerTileConfig.xml’.
4. Save the solution and publish all customizations.
5. Create a customer journey to open the customer journey designer. Go to **Marketing** > **Marketing Execution** > **Customer Journeys**, and then select **New**. For more information about creating a journey, see [Create a simple customer journey](../../marketing/create-simple-customer-journey.md).
    
    The tile should show up in the **Custom Content** section of the tile library in the customer journey designer.

    ![Custom Content tiles](../media/marketing-custom-channel-tile.png)


> [!div class="nextstepaction"]
> [Publish custom channel on AppSource](publish-custom-channel-appsource.md)

## See also

[Web resources for Common Data Service](/powerapps/developer/model-driven-apps/web-resources)
