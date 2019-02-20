---
title: "Add dynamic content to marketing emails (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to add field values, set up content settings information, conditional statements, and while loops to your email designs in Dynamics 365 for Marketing"
keywords: email; marketing email; dynamic content; content settings
ms.date: 12/17/2018
ms.service:
  - dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 5134e656-31ae-4984-8045-fcd76b98719a
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer: renwe
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Add dynamic content to email messages

Dynamic content gets resolved just before a message is sent to a specific individual. You'll typically use dynamic content to merge information from the recipient's contact record (such as first and last name), to place special links, and to place information and links from the content settings. If you're comfortable working in code, you can also create custom logic that includes conditional statements, for-each loops, and more. You can use dynamic content anywhere in your message body and can also use a few types of dynamic values in the message header fields (subject, from address, and from name).

<a name="content-settings"></a>

## Use content settings to set up repositories of standard and required values for email messages

Content settings are sets of standard and required values that are available for use in marketing email messages. Each includes a subscription-center link, a forward-to-a-friend link, social-media links, your postal address, and other information that can be placed into the message as dynamic values by using the assist-edit feature.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is delivered with a single default set of content settings, which is preconfigured to use the default subscription center (also included out of the box). You can customize this set as needed, and you can also create additional sets. You'll set up each customer journey to use a specific content-settings set, which means that all messages sent by that journey will use the same set. However, each journey can use a different set, which means that you can use an identical marketing-email design in two or more customer journeys, each specifying a different set of content settings. If you have more than one set of content settings, exactly one of them will be the default and will be applied automatically to each new customer journey that you create.

The values for content settings are first evaluated at send time, which means that you can edit a content-settings set at any time, and all pending and future email messages will automatically use the latest values.

Each content-settings record that you use must be available to the external marketing services, which manage email assembly and delivery. Therefore, you must publish your content-settings records by choosing **Go Live** whenever you create a new one.

> [!NOTE]
> If you have other types of values that you often use in email messages, and/or that you want to manage at the customer-journey level, then you can add them as custom fields to the content-settings entity just as you can for other types of entities in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. However, in the current release, all custom fields for the content-settings entity must be of type text (string). [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Customizing Marketing](customize.md)

To view, edit, or create a content-settings set:

1. Go to **Marketing** > **Templates**  >  **Content Settings**.

1. A standard list page opens where you can view, sort, search, and filter the list to find a specific record and use buttons on the command bar to add or remove a record. Select a record to open it for editing or select **New** on the command bar to create a new one.

1. The **Content Settings** form opens. If you are editing a record that is already live, you must choose **Edit** in the command bar before you can edit it. If you are creating a new one, you can just start filling in the fields.  

    ![The content-settings form](media/content-settings-form.png "The content-settings form")

1. Make the following settings, as needed:

    - **Name**: Enter a name for the customer-settings set. This is the name shown when you're assigning content settings to a customer journey or email-message preview.
    - **Owner**: Shows the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] user who created the set.
    - **Address main**: Enter the main part of your organization's postal address. All marketing email messages must include a valid main address taken from a content-settings set.
    - **Address line 2**: Enter supplemental postal address information (if needed).
    - **Default**: Set to **Yes** to make the current content-settings set the default for all new customer journeys. There must always be exactly one default; if you change the default, the existing default will automatically be changed to **No**.
    - **LinkedIn URL**,  **Twitter URL**,  **Facebook URL**, and  **YouTube URL**: For each of these social-media services, enter the URL for the landing page for your organization.  
    - **Subscription center**: Specify an existing marketing page that is set up as a subscription center. Select the  **&lt;/&gt;**  button to choose from a list of available pages. All marketing email messages must include a valid subscription-center link taken from a content-settings set.
    - **Forward to a friend**: Specify an existing marketing page that is set up as a forward-to-a-friend page. Select the  **&lt;/&gt;**  button to choose from a list of available pages.

1. Select **Save** in the bottom-right corner of the window to save your settings.

1. If you are editing a content-settings record that was already live, then the record is republished automatically when you save it. If you are creating a new record, then select **Go live** on the command bar to publish it to the marketing services so you can start using it.

<a name="assist-edit"></a>

## Use assist-edit to place dynamic field values

The **Assist Edit**  button  **&lt;/&gt;**  helps you construct valid dynamic expressions to position field values from recipient contact records, the message content settings, and other database values. This button is provided on the text formatting toolbar whenever you select a text element in the graphical designer. The button is also provided for some settings fields, such as the subject, from-address, and from-name fields.

Start by positioning your cursor in the field where you want to insert the dynamic text, and then select the  **Assist Edit**  button  **&lt;/&gt;**  to open a drop-down list showing a selection of data sources appropriate for your current context, which can include some or all of the following:

- **Contact[context]**: Places a field value, such as a first name, from each recipient's contact record.
- **Content settings[context]**: Places a field value from the content settings—a subscription center URL, forwarding URL, and the sender postal address are included here.
- **Message[context]**: Places values that relate to the message itself; currently, this includes the open-as-webpage URL and the various dynamic values used in [double opt-in emails](double-opt-in.md).
- **Account**: Places a value from a specific account record.
- **Contact**: Places a value from a specific contact record (not the recipient's record).
- **Event**: Places a link to a specific event sign-up page, or a field value from the page.
- **Lead**: Places a value from a specific lead record.
- **Marketing list**: Places a value from a specific marketing list.
- **Marketing list member**: Places a value from a specific marketing list member.
- **Marketing page**: Places a link to a specific marketing page, or a field value from the page.
- **Survey**: Places a link to a specific online survey (Voice of the Customer), or a field value from the survey.

> [!NOTE]
> Entities shown by assist edit that include **[context]** in their name take values that can change for each recipient (such as the recipient's name). Entities that don't include **[context]** in their name must refer to a specific record ID, which doesn't change for each recipient. Note also that the **[context]** label isn't included in the code placed on the page when you're done.

> [!NOTE]
> The entities included in the assist-edit menu are those that you are currently syncing with the customer-insights service, which means that you might see more entities than those mentioned in the previous list. If you need to show information from an entity that isn't listed, then ask your admin to add that entity to the customer-insights service. If you are an admin, then see [Choose entities to sync with the customer-insights services](marketing-settings.md#dci-sync) for instructions.

After you've selected a source, the  **Assist Edit**  drop-down list is updated to show individual fields that are available from that source. Choose one of these to place the value or link. The result is an expression that uses a format such as `{{EntityName.FieldName}}` or `{{EntityName(RecordID).FieldName}}`, though more complex expressions can also be generated depending on the options you pick. Here are some examples:

-  `{{contact.firstname}}`  
Places the recipient's first name.
- `{{msdyncrm_contentsettings.msdyncrm_subscriptioncenter}}`  
Places the URL for the subscription center page identified in the content settings configured for the customer journey that sends the message.
- `{{msdyncrm_contentsettings.msdyncrm_forwardtoafriend}}`  
Places the URL to the forwarding page identified in the content settings configured for the customer journey that sends the message.
- `{{Message.ViewAsWebpageURL}}`  
Places the URL for opening the current message in a web browser.
- `{{msevtmgt_event(8a519395-856c-4e22-b560-650ce6d6a79d).msevtmgt_webinarurl}}`  
Places the webinar URL for the event identified by the specified event ID (in parentheses).
- `{{msdyn_survey(39128da2-c968-4627-9595-f030b6571be4).msdyn_name}}`  
Places the name of the survey identified by the specified survey ID (in parentheses).

## Find record IDs

Non-contextual field expressions (which use the form  `{{EntityName(RecordID).FieldName}}`) require a record ID to identify the specific record the value must come from. To find the ID for any record:

1. Open the record you want to reference
2. Look at the URL shown in your browser's address bar, which should show a URL such as:  
`https://<MyOrg>.crm.dynamics.com/main.aspx?appid=c8cba597-4754-e811-a859-000d3a1be1a3&pagetype=entityrecord&etn=msevtmgt_event&id=5acc43d5-356e-e811-a960-000d3a1cae35`
3. Find the part of the URL that starts with `&id=`, which is followed by the ID number of your current record. Copy that number (the value only) and use it in your expression.

## Dynamic values in To, From-name, From-address, and Reply-to fields

On the **Summary** tab of the **Marketing Email** form, you can make various non-content-related settings for your message in the **Advanced Header** section. This includes values and expressions for establishing the to, from-name, from-address, and reply-to values the message will use.

![Advanced header settings for email messages](media/email-advanced-header-settings.png "Advanced header settings for email messages")

Though these settings provide assist-edit buttons, you must only place static values, or values from the **Contact[context]** entity, such as `{{contact.emailaddress1}}` (which is the default for the **To** address). These settings don't currently support any other entities or lookup-field values.

> [!TIP]
> You can include conditional statements in the **Advanced Header** fields—for example, to use `contact.emailaddress2` if `contact.emailaddress1` is empty. But you can still only refer to the contact entity in your conditional expressions and displayed fields.

<a name="advanced-dynamic-content"></a>

## Advanced dynamic content


You can add advanced logical processing to your email designs, which can make the content even more responsive to recipients, demographics, and context. This type of customization requires you to have a basic understanding of scripting and programming. 

As you've seen in previous examples, dynamic content is surrounded by double braces ( `{{` and `}}` ). This includes both standard field values that you add using the assist-edit feature, and the more advanced programming constructs described in this section.

> [!TIP]
> If you want to display double braces in a message, rather than use them to denote the start or end of a code block, then prepend (escape) the first brace with a backslash, such as `\{{` or `\}}`. The slashes won't appear in your final, rendered message, but the double braces will.

### Fetch custom values from fields and lookup fields

As we've seen, you can use the assist-edit feature to insert both context-sensitive and specific-record values from your database in your email messages—the result is an expression that uses a format such as `{{EntityName.FieldName}}` or `{{EntityName(RecordID).FieldName}}`, as illustrated in the examples shown in [Use assist-edit to place dynamic field values](#assist-edit).

> [!TIP]
> If you require the types of data that are supported by assist-edit, then it's usually best to use the assist-edit feature to place the code. This will ensure that the entity and field names match those used in the database and will help you avoid misspellings.

You can place nearly any database value into your messages using the same types of syntax created when using assist-edit, but you'll need to find the correct entity, relationship, and field names (for example, by using the tools for [customizing entities, relationships and fields](../customize/customize-entities-relationships-fields.md)).

> [!NOTE]
> You can only use data from entities that are synced with the customer-insights service (and therefore also listed in the assist-edit menu). If you need to show information from an entity that isn't yet synced, then talk to your admin. If you are an admin, then see [Choose entities to sync with the customer-insights services](marketing-settings.md#dci-sync) for instructions.

In addition, you can also construct expressions that fetch values from lookup fields (which link to related records) by adding an extra "hop" in your expression, where each hop (also known as an _access operator_) is indicated by a period (.), such as:

- `{{EntityName.RelationshipName.FieldName}}`
- `{{EntityName(RecordID).RelationshipName.FieldName}}`

Here are a few useful examples for placing lookup field values:

- `{{contact.contact_account_parentcustomerid.name}}`  
This expression finds the name of the account for the company where a contact works.
- `{{contact.contact_account_msa_managingpartnerid.name}}`  
This expression finds the name of the managing partner for the account for the company where a contact works.

> [!IMPORTANT]
> You can use, at most, two hops (periods) in your field expressions.

> [!IMPORTANT]
> Field values from lookups and related tables aren't shown in the **Preview** tab of the designer, or in test sends. To test your related-field expressions, set up a simple customer journey to deliver the message to yourself.

### Conditional statements and comparisons

Conditional (if-then-else) statements display content depending on whether one or more conditional expressions resolve to true or false. You can add the code required to create these statements by placing it within a text element, or by placing custom-code elements in between the other design elements. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [How to enter advanced dynamic content in the designer](#enter-code)

Conditional statements take the following form:

 ```Handlebars
{{#if (<operator> <value1> <value>)}}
      Content displayed when the expression is true
{{else if (<operator> <value1> <value>)}}
      Content displayed when the first expression is false and the second one is true
.
.
.
{{else}}
      <p>Content displayed when all expressions are false</p>
{{/if}}
```

Where:

- The conditional block must always open with `{{#if … }}`.
- Conditional expressions must be contained in parentheses.
- Conditional expressions start with an &lt;operator&gt;, which must be one of the values listed in the following table. It establishes how the first value is to be compared to the second value.
- &lt;value1&gt; and &lt;value2&gt; are values to be compared by the conditional expression, and each can be either dynamic or constant values. If either &lt;value1&gt; or &lt;value2&gt; is a constant string value (not a number or expression), then it must be surrounded with single quotes ('); for real numbers, use a period (.) as a decimal delineator.
- `{{else}}` and `{{else if … }}` clauses are optional.
- The conditional block must always close with `{{/if}}`.

The following table lists all the operators that you can use in your conditional expressions. Other operators are not currently available, nor can you use complex Boolean expressions (such as with AND or OR operators) in your conditional expressions.

| **[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] syntax (case sensitive)** | **Operator** |
| --- | --- |
| eq | Equal to |
| ne | Not equal to |
| lt | Less than |
| gt | Greater than |
| lte | Less than or equal to |
| gte | Greater than or equal to |

For example, this conditional statement could be used to establish the language used in a message salutation based on the country of each message recipient:

 ```Handlebars
<p>{{#if (eq contact.address1_country 'Denmark')}}
     Hej
{{else if (eq contact.address1_country 'US')}}
     Hi
{{/if}} {{contact.firstname}}!</p>
```

> [!TIP]
> You can test for empty field values by using:  
> ```Handlebars
> {{#if (eq contact.lastname '')}}
> ```
> Where `''` is two single quotation marks, not a double quotation mark. This finds empty fields, but not null fields.

> [!TIP]
> Though you can't use complex Boolean expressions in your conditional expressions, you can implement similar functionality as follows:
> 
> Not supported:  
> ```Handlebars
> {{#if A and B}}<DisplayedContent>{{/if}
> ```
> Is equivalent to (supported):
> ```Handlebars
> {{#if A}}{{#if B}}<DisplayedContent>{{/if}}{{/if}}
> ```
> &nbsp;  
> Not supported:
> ```Handlebars
> {{#if A or B}}<DisplayedContent>{{/if}
> ```
> Is equivalent to (supported):
> ```Handlebars
> {{#if A}}<DisplayedContent>{{/if}} {{#if B}}<DisplayedContent>{{/if}}
> ```

> [!TIP]
> When you are testing for values that are stored as an option set in the database, use the index values for the option set, not the display values. For example, you might have a field called `contact.customertypecode`, which holds an integer to identify the type of customer it is. Each customer type code also has a display name, such that 0 = "copper", 1 = "silver", and 2 = "gold". In this case, you must set up your expression to use the index (integer), not the matching display value. Therefore, if you're looking for gold customers, you should use:
> ```Handlebars
> {{#if (eq contact.customertypecode 2)}}
> ```

> [!TIP]
> When you are testing large numerical values, such as "1,932,333", then leave out the thousands separator (,) in the comparison statement, even though you might often see these presented in the UI. To test for this value, your expression should therefore look something like:
> ```Handlebars
> {{#if (eq contact.customernumber 1932333)}}
> ```

### For-each loops

For-each loops let you step through a collection of records that are related to a specific current record—for example, to provide a list of all the recent transactions associated with a given contact. You can add the code required to create these statements by placing it within a text element, or by placing custom-code elements in between the other design elements. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [How to enter advanced dynamic content in the designer](#enter-code)

For-each loops take the following form:

 ```Handlebars
{{#each Entity.RelationshipName }}
    ...
    {{this.RelatedField1}}
    ...
    {{this.RelatedField2}}
    ...
{{/each}}
``` 

Where:

- The loop block must always open with `{{#each … }}`.
- `Entity.RelationshipName` identifies the set of related records that the loop will iterate over.
- The loop starts with the first available related record, and repeats for each available related record until all related records have been listed. Note that the related records will be returned in an arbitrary and unpredictable order.
- `{{this.RelatedField<n>}}` identifies a field name from the related record. The "this" part of this expression refers to the related record being processed in the current loop iteration, and must be followed by a valid field name for the related entity. You can include any number of fields in each loop.
- The loop block must always close with `{{/each}}`.

For example, your database could include a list of products that a contact has ordered. You could list these in an email message using code such as:

```Handlebars
<p>You have purchased:</p>
<ul>
<!-- {{#each contact.contact_product_productid}} -->
<li>{{this.name}}</li>
<!-- {{/each}} -->
</ul>
``` 

In this example, the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] system has been customized to include a [custom entity](../customize/create-edit-entities.md) called _product_, which is set up with a 1:N [relationship](../customize/create-edit-entity-relationships.md) between the _contact_ and _product_ entities on the _productid_ field. For the product entity to be available to your email messages, it must also be [synced](marketing-settings.md#dci-sync) with the customer-insights database (as usual).

<a name="enter-code"></a>

## How to enter advanced dynamic content in the designer

You must be careful when entering advanced dynamic code in the designer because there are many, sometimes unexpected, ways to get it wrong, which will break your code. Here are some tips for how to enter and test your code:

- Use custom-code elements place code snippets between design elements on the **Designer** tab. This is much more visible and reliable than placing the code directly into the HTML using the **HTML** tab. However, you might also use dynamic code *within* a text element, in which case you'll probably need to clean up that code on the **HTML** tab, as mentioned later in this list. (When working in the [full-page editor](custom-template-attributes.md#show-toolbox), double click on a custom-code element to edit its content.)
    ![The custom-code element](media/custom-code-element.png "The custom-code element")
- When you enter code into a text element on the **Designer** tab, any extra spaces and carriage returns that you add will create `&nbsp;`and `<p>` tags in your code, which can break it. Always go to the **HTML** tab afterwards, where you'll see all of these extra tags, and be sure to remove them.
- When you enter code into a text element, all of your dynamic-content code must either be contained within a set of start and end tags (such as `<p>` and `</p>`) or within an HTML comment (for code that is entirely separate from displayed text). Do not place code outside of comments or valid HTML tag pairs (or custom-code elements), as that will confuse the editor (especially if you switch between the **HTML** and **Design** tabs). You must work on the **HTML** tab inspect and correct the HTML within your text elements.
- Do not place carriage returns between code elements that are part of the same expression (such as in a for-each loop) unless you enclose each line within its own set of HTML tags (as illustrated in the for-each loop example given after this list).
- The [assist-edit](#assist-edit) feature is often helpful for constructing expressions that fetch values from your database because it helps you find database table, field, and relation names. This tool is available when working within a text element on the **Designer** tab, and when entering values is certain fields that support it (like the email subject). Assist-edit isn't available when working on the **HTML** tab or within a custom code element, so you can instead start by using assist-edit in any text element, and then cut/paste the resulting expression into your custom-code element or HTML.
- The relationship name that you use when creating loops or placing lookup values must match the one used in the customer-insights services. This relationship name is not necessarily the same as the one used to customize [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. To find the correct relationship name, use the [assist-edit](#assist-edit) feature.
- Field values from lookups and related tables aren't shown in the **Preview** tab of the designer, or in test sends. To test your related-field expressions, set up a simple customer journey to deliver the message to yourself.

For example, you could set up the salutation line of an email message by entering the following onto the **HTML** tab of the designer (either inside or outside of a text element):

```Handlebars
<p>{{#if (eq contact.address1_country 'Denmark')}}Hej{{else if (eq contact.address1_country 'US')}}Hi{{/if}}{{contact.firstname}}!</p>
```

The following example (also shown previously) shows how to use comments to enclose code that exists entirely outside of displayed content (also on the **HTML** tab):

```Handlebars
<p>You have purchased:</p>
<ul>
<!-- {{#each contact.contact_product_productid}} -->
<li>{{this.name}}</li>
<!-- {{/each}} -->
</ul>
```

### See also

[Design your digital content](design-digital-content.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)  
[Create automated campaigns with customer journeys](customer-journeys-create-automated-campaigns.md)
