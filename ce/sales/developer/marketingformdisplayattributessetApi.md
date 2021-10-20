---
title: "Customize quick campaign form using marketingformdisplayattributesset Web API (Dynamics 365 Sales) | MicrosoftDocs"
description: Customize quick campaign form using marketingformdisplayattributesset Web API in Dynamics 365 Sales.
ms.date: 05/26/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---
# Customize quick campaign and campaign activity distribution forms 

## Requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System customizer <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||


You can use the **marketingformdisplayattributesset** Web API to customize the quick campaign and distribute campaign activity forms to meet the specific needs of your organization. Customization allows users to enter the information they need quickly. 

>[!NOTE]
>Customization of quick campaign and campaign activity distribution forms is not available in the application by default. Contact Microsoft Support to enable this feature for your organization. 

## Action parameters  

The **marketingformdisplayattributesset** action expects the following input parameters:

| Parameter name | Required? | Type | Description |
|----------------|----------|------|-------------|
| ```entitylogicalname``` | Yes | Edm.String | Specifies the name of the entity for custom form.<br>**Note:** Each `entitylogicalname` must have only one record in the application. If there is more than one record, the application considers the record based on which it was first created. To view the list of records, make a GET API call:<br>```GET [Organization URI]/api/data/v9.0/marketingformdisplayattributesset```<br>```HTTP/1.1``` |
| ```displayattributelist``` | Yes | Edm.String | Specifies the list of attributes to be displayed in custom form. <br> You can get the attribute names from system customizations. For example, to view the attribute names of **Phone Call**, go to **Advance settings** > **Customizations** > **Customize the system** > **Entities** > **Phone Call** > **Fields** and the names are listed under **Name** column. <br>![Phone call attribute names under system customization settings.](../media/dev-phone-call-field-names.png "Phone call attribute names under system customization settings")|
| ```name``` | Yes | Edm.String | Specifies the name of the quick campaign or distribute campaign activity form attributes settings. |

## Action example

```html
POST [Organization URI]/api/data/v9.0/marketingformdisplayattributesset
HTTP/1.1
Accept: application/json
Content-Type: application/json; charset=utf-8
OData-MaxVersion: 4.0
OData-Version: 4.0
{
    "entitylogicalname" : "phonecall",
    "displayattributelist" : "[\"lastonholdtime\", \"transactioncurrencyid\", \"owningbusinessunit\", \"isregularactivity\", \"actualdurationminutes\", \"subcategory\"]",
    "name" : "Phone Call"
}
```

### Response  

```json
HTTP/1.1 204 No Content
OData-Version: 4.0
```

### See also

[Create a quick campaign using in-app marketing (Sales)](../create-quick-campaign-using-app-marketing-sales.md)    
[Add an activity to a campaign using in-app marketing (Sales)](../add-activity-campaign-using-app-marketing-sales.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
