---
title: "Manage notification templates in Omnichannel Administration app | MicrosoftDocs"
description: "Learn about managing notification templates in Omnichannel Administration app"
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Manage notification templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

When an agent gets a notification, it displays certain information such as which customer the conversation request is coming from, the timeout period after which the notification will disappear, and some buttons such as accept and reject. Each organization has varied business requirements and wants the notifications to show relevant information to the agents in the notification.

The notification templates are introduced to show relevant information to agents. A notification template in Omnichannel Administration app is a combination of notification related information that is reusable. The template is used to configure what information is displayed to the agents and supervisors for an incoming conversation, escalation, transfer, consult, and so on.

As an administrator, system integrator, or partner, you can use the templates or create new ones to show information that matter most to your business.

You must associate the notification templates to a session template.

## Slug for notification field header

Slug is the replacement parameter that omnichannel system populates at runtime based on the context variables.

The notification shows certain fields and values, called **Field header** and **Value** respectively.

For example, customer Kenny Smith initiates a conversation. When the agent sees the notification, it displays **Customer Name** as **Kenny Smith**.

Here, **Field header** is **Customer Name** and the **Value** is **Kenny Smith**.

For Omnichannel system to identify the name of the customer as **Kenny Smith**, as an administrator, you must configure slugs as the value. The Omnichannel system replaces the slug with the actual value that was extracted based on the context variables.

Omnichannel system supports the following slugs.

| Slug | Description |
|------------|-----------------------------------|
| `{customerName}` | Name of the customer who initiated the conversation. |
| `{caseId}` | GUID of a case. The system displays the case Id only if a cased is linked to the conversation. |
| `{caseTitle}` | Title of the case. The system displays the title of the case only if a cased linked to the conversation. |
| `{queueId}` | GUID of a queue. |
| `{visitorLanguage}` | The language of the customer who initiated the conversation. |
| `{visitorDevice}` | The device of the customer who initiated the conversation. |
| `{entityRoutingLogicalName}` | Name of the entity if the notification is for entity records. |
| `{entityRoutingRecordId}` | GUID of the entity record if the notification is for entity records. To learn more, see [Entity records routing](entity-channel.md). |
| `{customerEntityName}` | Name of the entity (contact or account entity) if the customer is authenticated. |
| `{customerRecordId}` | GUID of the entity (contact or account entity) if the customer is authenticated. |
|`{<name of the pre-chat survey question>}` | All the pre-chat survey questions that are configured for a workstream can be used as the slug The format is same as the question. |

## Create a notification template

1.	Sign in to the Omnichannel Administration app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select **+ New** in the **Active Notifications** page.

4.	Specify the following in the **New Notification** page.

    | Tab | Name | Value description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|
    | General | Name | Specify the name for the notification. This name wouldn't be visible for the agents at the run-time. | Authenticated chat notification |
    | General | Title | Provide a title to the notification that you want the agents to see at the run-time. | Incoming chat conversation |
    | General | Icon | Select web resource path to add an icon. | /webresources/msdyn_chat_icon_zfp.svg <br><br> **Note:** This is the default value. You can change the icon as your requirement. |
    | General | Timeout (seconds) | Provide a duration in seconds; after this duration, the notification disappears. | 120. <br><br> **Note:** This is the default value. You can change the duration as per your requirement.
    | General | Accept Button | Specify a text for the accept button. This text appears for the agents to accept a conversation request. | Accept <br><br> **Note:** This is the default value. You can change the text as per your requirement. |
    | General | Reject Button | Set the toggle to yes if you want to show the reject button to agents. <br> After you set the toggle to Yes, the button text box appears. Specify a text for the accept button. This text appears for the agents to reject a conversation request. | Reject <br><br> **Note:** This is the default value. You can change the text as per your requirement. |

     > [!div class=mx-imgBorder] 
     > ![Create notification template](../media/notification-template1.png "Create notification template")

5.	Select **Save** to save the notification template. After you save, the **Notification Fields** section appears on the page.

6.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

7.	Select the search icon in the **Look for Records** box. If there are no records, you see a message: **No records found. Create a new record.**.

8.	Select **+ New** to create a new notification field. A confirm dialog box appears, asking whether you want to leave the page. Select **OK**.

9.	Specify the following in the **New Notification Field** page.

    | Tab | Name | Value description | Example |
    |---------|--------------------|-----------------------------------------------|--------------------|    
    | General | Name | Specify the name for the notification. This name won't be visible to the agents at the runtime. | Name of the customer |
    | General | Field header | Provide a name to the field header. This appears in the notification that agents see at the runtime. | Name |
    | General | Value | Provide a slug value that appears against **Field header** in the notification. <br><br> To learn more, see [Slug for notification field header](#slug-for-notification-field-header). |{customerName} |

    > [!div class=mx-imgBorder]
    > ![Create notification field](../media/notification-field.png "Create notification field")

10.	Select the back arrow on the browser to go to the notification template you created. Alternatively, you can select **Notifications** in the sitemap and then select the template you created.

11.	Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

12.	Select the name of the notification field you created, and then select **Add**. For example, **Name of the customer**.

13.	Repeat steps 6 through 12 to add more notification fields.

14.	Select **Save** to save the notification template changes.

## Edit a notification field

As an administrator, you can edit the value of a notification field header in the grid.

1.	Sign in to the Omnichannel Administration app.

2.	Select **Notifications** under **Templates** in the sitemap.

3.	Select the notification you want to edit on the **Active Notifications** page.

4.	Select a notification field you want to edit and then select the record to edit it.

5.	Select the save icon in thr grid.

## Customize notification

Let's see a scenario: In the Contoso Pvt Ltd customer service center, every case notification that is shown to an agent needs to have the following:

**Title of the notification**: A new case is assigned

**Notification fields**:

- **Case priority**: Priority of the case such high or low.
- **Case title**: Title of the case.
- **Device**: Device from which the case was created by the customer.
- **Language**: Language of the customer.

As an administrator, you need to customize the notification template to show the title and notification fields.

### Step 1: Create a notification template with the following values

| Tab | Name | Value |
|---------|--------------------|-----------------------------------------------|
| General | Name | Customized case notification template |
| General | Title | A new case is assigned |
| General | Icon |/webresources/msdyn_chat_icon_zfp.svg <br><br> **Note:** This is the default value. |
| General | Timeout (seconds) | 120. <br><br> **Note:** This is the default value. |
| General | Accept Button | Accept <br><br> **Note:** This is the default value.|
| General | Reject Button | Reject <br><br> Set the toggle to yes to show the reject button to agents. <br> After you set the toggle to **Yes**, the button text box appears. <br><br> **Note:** This is the default value.|

### Step 2: Create the Notification Fields with the following values

| Name | Field header | Value |
|---------|--------------------|-----------------------------------------------|--------------------|    
| Case priority | Case priority | `{$odata.incident.prioritycode.?$filter=incidentid eq '{caseId}'&$select=prioritycode}` |
| Case title | Case title | `{$odata.incident.title.?$filter=incidentid eq '{caseId}'&$select=title}` |
| Device | Device | `{visitorDevice}` |
| Language | Language | `{visitorLanguage}` |

> [!div class=mx-imgBorder] 
> ![Customize notification template](../media/customize-notification-template.png "Customize notification template")

### Step 3: Save the changes


## See also

- [Manage session templates](session-templates.md)
- [Manage application tab templates](application-tab-templates.md)
- [Associate templates with workstreams](associate-templates.md)
