---
title: "Delete or deactivate a segment"
description: "Permanently delete a segment that is no longer required in your organization, or deactivate to retain the segment in the application in inactive mode."
ms.date: 10/26/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---
# Delete or deactivate a segment 

You can deactivate or delete a segment that's no longer required in your organization. Deactivation retains the segment in the application, but records won't be connected to it in the future. When a segment is deleted, segment records that are already connected to a sequence won't be affected.

## License and role requirements
| Requirement | What you need? |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## To delete or deactivate a segment 

1.	Sign in to your Dynamics 365 Sales Hub app.
2.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
3.	Under **Sales accelerator**, select **Segments**.

    The **Segments** page opens with the list of available segments.  

    >[!div class="mx-imgBorder"]
    >![Segments page with list of segments](media/sa-segment-edit-list-lead-segments.png "Segments page with list of segments")  

4.	Hover over the segment, select **More options**, and then do one of the following:

    -	Select **Deactivate**, and in the confirmation message that appears, select **Deactivate**.

        >[!NOTE]
        >If there are any sequences attached to the segment, the names of the sequences are displayed in the message.

        >[!div class="mx-imgBorder"]
        >![Deactivate segment](media/sa-segment-deactivate-segment.png "Deactivate segment")

        The segment is deactivated in the application.

    -	Select **Delete**, and in the confirmation message that appears, select **Delete permanently**.

        >[!NOTE]
        >If there are any sequences attached to the segment, the names of the sequences are displayed in the message.

        >[!div class="mx-imgBorder"]
        >![Delete segment](media/sa-segment-delete-segment.png "Delete segment")

        The segment is removed permanently from the application.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate a segment](create-and-activate-a-segment.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]

