---
title: "Personalize content (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to personalize content in Dynamics 365 Marketing."
ms.date: 03/07/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Personalize content

Dynamics 365 Marketing's real-time marketing features offer powerful personalization capabilities. In this article, you'll learn how to set default values for personalized data, preview personalized content, personalize text messages and push notifications, and use advanced personalization features like related tables and conditional content.

## Default values

Use default values to ensure your message always has appropriate content, even if the data is missing or blank. For example, if you are personalizing your message with a customer’s first name, you can add “customer” as the default value. That way your message will always be complete.

To set a default value:

1. Add a personalized element.
1. Enter the default content in the **Default value** field.

> [!div class="mx-imgBorder"]
> ![Screenshot of Default value field.](media/real-time-marketing-personalization-default.png)

## Preview personalized content

You can preview your personalized content in the **Preview and test** view. By default, preview will display the default content for that placeholder:

> [!div class="mx-imgBorder"]
> ![Screenshot of preview and test with a default value.](media/real-time-marketing-personalization-test-default.png)

You can also add content in the **Test send sample data** field to preview how it will look in your email. To add test send sample data, select the **Edit sample data** button:

> [!div class="mx-imgBorder"]
> ![Screenshot of preview and test with a sample data value.](media/real-time-marketing-personalization-test-sample.png)

## Personalize text messages and push notifications

You can add personalized content to your messages by selecting the ![Text and push personalization button.](media/real-time-marketing-sms-personalize-button.png "Text and push personalization button") icon:

> [!div class="mx-imgBorder"]
> ![Screenshot showing use of the text and push personalization button.](media/real-time-marketing-sms-personalize-example.png)

## Related tables

Related tables are signified with the ![Related table icon.](media/real-time-marketing-personalization-related-table.png "Related table icon") icon next to the item in the data source selection screen. For example: ![Related table example.](media/real-time-marketing-personalization-related-example.png "Related table example")

Select this field to navigate to the related table:

> [!div class="mx-imgBorder"]
> ![Screenshot showing use an example related table.](media/real-time-marketing-personalization-related-traverse2.png)

You can also search for fields in the related table (only the currently selected table will return results).

> [!div class="mx-imgBorder"]
> ![Screenshot showing a related table search.](media/real-time-marketing-personalization-related-search.png)

To navigate between levels, select the breadcrumbs:

> [!div class="mx-imgBorder"]
> ![Screenshot showing personalization breadcrumbs.](media/real-time-marketing-personalization-breadcrumbs.png)

Once you’ve selected a field, the full path to that field is displayed in the data binding.

> [!div class="mx-imgBorder"]
> ![Screenshot showing the full path to the field.](media/real-time-marketing-personalization-related-path.png)

## Conditional content

Conditional (if-then-else) statements display content depending on whether one or more conditional expressions resolve to true or false. You can add the code required to create these statements in the designer or in the HTML view. You can then use the placeholder dialog to specify the condition to be evaluated.

```
{{#if placeholderName}}
   Content displayed when the expression is true
{{else if placeholderName2}}
   Content displayed when the first expression is false and the second one is true
.
.
.
{{else}}
   Content displayed when all expressions are false
{{/if}}
```

If you are adding code to HTML, make sure to put comments around the code:

```
<!-- {{#if placeholderName }} -->
    <h1>Content displayed when the expression is true</h1>
<!-- {{/if}} -->
```

In the code, you only specify the placeholder name. To set up the condition, go to the **Personalize** tab in the **Toolbox**:

> [!div class="mx-imgBorder"]
> ![Screenshot showing the personalize tab with placeholders.](media/real-time-marketing-personalization-condition-setup.png)

For example, you can add code to personalize a greeting based on country:

```
{{#if placeholderName}}
    Hola
{{else if ckForDenmark}}
    Hallo
{{else}}
    Hi
{{/if}} {{contact.firstname}}!
```

Then, select the placeholder name to configure. Next, select a field and the condition to compare. In this example, the first placeholder will activate the condition if the contact's address is in Spain:

> [!div class="mx-imgBorder"]
> ![Screenshot showing placeholder configuration.](media/real-time-marketing-personalization-condition-compare.png)

Next, configure the condition to check the contact’s address for Denmark:

> [!div class="mx-imgBorder"]
> ![Screenshot showing contact address configuration for Denmark.](media/real-time-marketing-personalization-condition-denmark.png)

You can preview the effect of the conditions in **Preview and test** by changing the sample data for the conditions to true. Placeholder 1 true:

> [!div class="mx-imgBorder"]
> ![Screenshot showing conditions set to true.](media/real-time-marketing-personalization-condition-denmark-true.png)

Placeholder 2 true:

> [!div class="mx-imgBorder"]
> ![Screenshot showing conditions set to false.](media/real-time-marketing-personalization-condition-denmark-false.png)

### Partial and relative dates in conditional content

You can use relative and partial dates when defining a condition that uses dates, allowing you to create more flexible personalized content.

#### Partial dates

Partial dates allow you to define a conditions such as "Birthday is Today" or "Birthday is this month." The available options for partial dates are as follows:

- Day can be checked for any day, today, a specific day (such as the 15th), or a day (or days) of the week (such as Monday and Wednesday).
- Month can be checked for any month, this month, or a specific month (such as February).
- Year can be checked for any year, this year, or a specific year (1922-2027).

> [!div class="mx-imgBorder"]
> ![Screenshot showing partial date settings.](media/real-time-marketing-partial.png)

#### Relative dates

Relative dates allow you to define conditions such as "Birthday is next month" or "Birthday was 2 days before today." Options here include ability to specify number of Days, months, or years "from today" or "before today."

> [!div class="mx-imgBorder"]
> ![Screenshot showing relative date settings.](media/real-time-marketing-relative.png)

## Lists of content

Lists (each) statements allow you to format and display repeated content for a given table. You can add the code required to create these statements in the designer or in the HTML view. You can then use the placeholder dialog to specify the list to be evaluated including the number of rows to display and the order to display them in.

```
{{#each placeholderName}}
   Repeated content to display
{{/each}}
```

If you are adding code to HTML, make sure to put comments around the code:

```
<!-- {{#each placeholderName }} -->
    <h1>Repeated content to display</h1>
<!-- {{/each}} -->
```

In the code, you only specify the placeholder name. To set up the list, go to the **Personalize** tab in the **Toolbox**:

> [!div class="mx-imgBorder"]
> ![Screenshot showing the Personalize with list setup.](media/real-time-marketing-personalization-list-setup.png)

For example, you want to create an email with a list of products the customer has.

First, create a list placeholder and select the table you what to use for the list:

> [!div class="mx-imgBorder"]
> ![Screenshot showing selecting a table to use for the list.](media/real-time-marketing-personalization-lists-examplestep1.png)

Next, add any attributes you want to display as the repeated content in the list:

> [!div class="mx-imgBorder"]
> ![Screenshot showing attributes to display.](media/real-time-marketing-personalization-lists-examplestep2.png)

You can also specify which attribute to order the list by and how many items you want displayed:

> [!div class="mx-imgBorder"]
> ![Screenshot showing attribute order and number of items.](media/real-time-marketing-personalization-lists-examplestep3.png)

Finally, save and use the Code generator to copy the list code to the designer:

> [!div class="mx-imgBorder"]
> ![Screenshot showing the list code in the Code generator.](media/real-time-marketing-personalization-lists-examplestep4.png)

## Code generator

You can use the Code generator tool to create code for your condition and list placeholders to copy.

To access the Code generator, go to the **Personalize** tab in the **Toolbox**:

> [!div class="mx-imgBorder"]
> ![Screenshot showing access to the Code generator.](media/real-time-marketing-personalization-codegenerator1.png)

You can select either a condition or list placeholder to build your code for:

> [!div class="mx-imgBorder"]
> ![Screenshot showing condition or list selection.](media/real-time-marketing-personalization-codegenerator2.png)

For conditions, you can add additional else cases or a default case:

> [!div class="mx-imgBorder"]
> ![Screenshot showing else or default.](media/real-time-marketing-personalization-codegenerator3.png)

For lists, you can add or delete additional attributes (these changes will be saved to your list placeholder):

> [!div class="mx-imgBorder"]
> ![Screenshot showing added attributes.](media/real-time-marketing-personalization-codegenerator4.png)
