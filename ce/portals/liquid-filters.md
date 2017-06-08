---
title: "Use Liquid filters for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 1915b631-a46a-455b-8343-a34a5d273436
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Liquid filters



Liquid filters are used to modify the output of strings, numbers, variables, and objects. They are separated from the value to which they are being applied by a |.

`{{ 'hal 9000' | upcase }} <!-- Output: HAL 9000 -->`

Some filters accept parameters. Filters can also be combined, and are applied in order from left to right.

```
{{ 2 | times: 2 | minus: 1 }} <!-- Output: 3 -->

{{ "Hello, " | append: user.firstname }} <!-- Output: Hello, Dave -->
```

### **Filters**

The following topics describe each type of filter:

[Array filters](#array-filters)  

[Entity List filters](#entity-list-filters)  

[Date filters](#date-filters)  

[Math filters](#math-filters)  

[String filters](#string-filters)  

[Type filters](#type-filters)  

[URL filters](#url-filters)  

[Additional filters](#additional-filters)  


## Array filters



Array filters are used to work with [*Liquid types*](liquid-types.md).  

### **batch**

Divides an array into multiple arrays of a given size.

**Code**

```
{% assign batches = entityview.records | batch: 2 %}

{% for batch in batches %}

<ul>

{% for item in batch %}

<li>{{ item.fullname }}</li>

{% endfor %}

</ul>

{% endfor %}
```

**Output**

```
<ul>

<li>John Smith</li>

<li>Dave Thomas</li>

</ul>

<ul>

<li>Jake Johnson</li>

<li>Jack Robinson</li>

</ul>
```

### **concat**

Concatenates two arrays into a single new array.

Given a single item as a parameter, concat returns a new array that consists of the original array, with the given item as the last element.

**Code**

```
Group #1: {{ group1 | join: ', ' }}

Group #2: {{ group2 | join: ', ' }}

Group #1 + Group #2: {{ group1 | concat: group2 | join: ', ' }}

Group #1 + Leslie: {{ group1 | concat: 'Leslie' | join: ', ' }}
```

**Output**

```
Group #1: John, Pete, Hannah

Group #2: Joan, Bill

Group #1 + Group #2: John, Pete, Hannah, Joan, Bill

Group #1 + Leslie: John, Pete, Hannah, Leslie
```

### **except**

Select all the objects in an array where a given attribute does not have a given value. (This is the inverse of**where**.)

**Code**

```
{% assign redmond = entityview.records | except: 'address1_city', 'Redmond' %}

{% for item in redmond %}

{{ item.fullname }}

{% endfor %}
```

**Output**

```
Jack Robinson
```

### **first**

Returns the first element of an array.

first can also be used with a special dot notation, in cases where it needs to be used inside a tag.

**Code**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | first }}

{% if words.first == "This" %}

The first word is "This".

{% endif %}
```

**Output**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | first }}

{% if words.first == "This" %}

The first word is "This".

{% endif %}
```

### **group_by**

Group the items in an array by a given attribute.

**Code**

```
{% assign groups = entityview.records | group_by: 'address1_city' %}

{% for group in groups %}

{{ group.key }}:

{% for item in group.items %}

{{ item.fullname }}

{% endfor %}

{% endfor %}
```

**Output**

```
Redmond:

John Smith

Dave Thomas

Jake Johnson

New York:

Jack Robinson
```

### **join**

Joins the elements of an array with the character passed as the parameter. The result is a single string.

**Code**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | join: ", " }}
```

**Output**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | join: ", " }}
```

### **last**

Returns the last element of an array.

last can also be used with a special dot notation, in cases where it needs to be used inside a tag.

**Code**

```
{% assign words = "This is a run of text" | split: " " -%}

{{ words | last }}

{% if words.last == "text" -%}

The last word is "text".

{% endif -%}
```

**Output**

```
{% assign words = "This is a run of text" | split: " " -%}

{{ words | last }}

{% if words.last == "text" -%}

The last word is "text".

{% endif -%}
```

### **order\_by**

Returns the elements of an array ordered by a given attribute of the elements of the array.

Optionally, you can provide desc as a second parameter to sort the elements in descending order, rather than ascending.

**Code**

```
{{ entityview.records | order_by: 'fullname' | join: ', ' }}

{{ entityview.records | order_by: 'fullname', 'desc' | join: ', ' }}
```

**Output**

```
Dave Thomas, Jack Robinson, Jake Johnson, John Smith

John Smith, Jake Johnson, Jack Robinson, Dave Thomas
```

### **random**

Returns a single randomly-selected item from the array.

**Code**

```
{{ group1 | join: ', ' }}

{{ group1 | random }}
```

**Output**

```
John, Pete, Hannah

Pete
```

### **select**

Selects the value of a given attribute for each item in an array, and returns these values as an array.

**Code**

```
{{ entityview.records | select: 'address1_city' | join: ', ' }}
```

**Output**

```
Redmond, New York
```

### **shuffle**

Applied to an array, returns a new array with the same items, in randomized order.

**Code**

```
{{ group1 | join: ', ' }}

{{ group1 | shuffle | join: ', ' }}
```

**Output**

```
John, Pete, Hannah

Hannah, John, Pete
```

### **size**

Returns the number of items in an array.

size can also be used with a special dot notation, in cases where it needs to be used inside a tag.

**Code**

```
{% assign words = "This is a run of text" | split: " " -%}

{{ words | size }}

{% if words.size == 6 -%}

The text contains 6 words.

{% endif -%}
```

**Output**

```
{% assign words = "This is a run of text" | split: " " -%}

{{ words | size }}

{% if words.size == 6 -%}

The text contains 6 words.

{% endif -%}
```

### **skip**

Skips a given number of items in an array, and returns the rest.

**Code**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | skip: 3 | join: ', ' }}
```

**Output**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | skip: 3 | join: ', ' }}
```

### **take**

Takes a given number of items from the array, returning the taken items.

**Code**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | take: 3 | join: ', ' }}
```
**Output**

```
{% assign words = "This is a run of text" | split: " " %}

{{ words | take: 3 | join: ', ' }}
```

### **then\_by**

Adds additional subsequent ordering to an array already ordered by**order\_by**.

Optionally, you can provide desc as a second parameter to sort the elements in descending order, rather than ascending.

**Code**

```
{{ entityview.records | order_by: 'address1_city' | then_by: 'fullname' | join: ', ' }}

{{ entityview.records | order_by: 'address1_city' | then_by: 'fullname', 'desc' | join: ', ' }}
```

**Output**

```
Dave Thomas, Jack Robinson, Jake Johnson, John Smith

John Smith, Jake Johnson, Jack Robinson, Dave Thomas
```

### **where**

Select all the objects in an array where a given attribute has a given value.

**Code**

```
{% assign redmond = entityview.records | where: 'address1_city', 'Redmond' %}

{% for item in redmond %}

{{ item.fullname }}

{% endfor %}
```

**Output**

```
John Smith

Dave Thomas

Jake Johnson
```


## Date filters

Date filters can be used for date arithmetic or to convert DateTime values into various formats.

### **date**

Formats a DateTime value using a .NET format string.

[*Standard Date and Time Format Strings*](https://msdn.microsoft.com/library/az4se3k1(v=vs.110).aspx)  

[*Custom Date and Time Format Strings*](https://msdn.microsoft.com/library/8kb3ddd4(v=vs.110).aspx)  

**Code**

```
{{ now | date: 'g' }}

{{ now | date: 'MMMM dd, yyyy' }}
```

**Output**

```
{{ now | date: 'g' }}

{{ now | date: 'MMMM dd, yyyy' }}
```

### **date\_add\_days**

Adds the specified number of whole and fractional days to the DateTime value. The parameter can be positive or negative.

**Code**

```
{{ now }}

{{ now | date_add_days: 1 }}

{{ now | date_add_days: -2.5 }}
```

**Output**

```
{{ now }}

{{ now | date_add_days: 1 }}

{{ now | date_add_days: -2.5 }}
```

### **date\_add\_hours**

Adds the specified number of whole and fractional hours to the DateTime value. The parameter can be positive or negative.

**Code**

```
{{ now }}

{{ now | date_add_hours: 1 }}

{{ now | date_add_hours: -2.5 }}
```

**Output**

```
{{ now }}

{{ now | date_add_hours: 1 }}

{{ now | date_add_hours: -2.5 }}
```

### **date\_add\_minutes**

Adds the specified number of whole and fractional minutes to the DateTime value. The parameter can be positive or negative.

**Code**

```
{{ now }}

{{ now | date_add_minutes: 10 }}

{{ now | date_add_minutes: -2.5 }}
```


**Output**

```
{{ now }}

{{ now | date_add_minutes: 10 }}

{{ now | date_add_minutes: -2.5 }}
```

### **date\_add\_months**

Adds the specified number of whole months to the DateTime value. The parameter can be positive or negative.

**Code**

```
{{ now }}

{{ now | date_add_months: 1 }}

{{ now | date_add_months: -2 }}
```

**Output**

```
{{ now }}

{{ now | date_add_months: 1 }}

{{ now | date_add_months: -2 }}
```

### **date\_add\_seconds**

Adds the specified number of whole and fractional seconds to the DateTime value. The parameter can be positive or negative.

**Code**

```
{{ now }}

{{ now | date_add_seconds: 10 }}

{{ now | date_add_seconds: -1.25 }}
```

**Output**

```
{{ now }}

{{ now | date_add_seconds: 10 }}

{{ now | date_add_seconds: -1.25 }}
```

### **date\_add\_years**

Adds the specified number of whole years to the DateTime value. The parameter can be positive or negative.

**Code**

```
{{ now }}

{{ now | date_add_years: 1 }}

{{ now | date_add_years: -2 }}
```

**Output**

```
{{ now }}

{{ now | date_add_years: 1 }}

{{ now | date_add_years: -2 }}
```

### **date\_to\_iso8601**

Formats a DateTime value according to the [*ISO 8601*](http://en.wikipedia.org/wiki/ISO_8601) standard. Useful when creating [*Atom feeds*](http://tools.ietf.org/html/rfc4287), or the HTML5 &lt;time&gt; element.  

**Code**

```
{{ now | date_to_iso8601 }}
```

**Output**

```
{{ now | date_to_iso8601 }}
```

### **date\_to\_rfc822**

Formats a DateTime value according to the [*RFC 822*](https://www.ietf.org/rfc/rfc0822.txt) standard. Useful when creating [*RSS feeds*](http://cyber.law.harvard.edu/rss/rss.html).  

**Code**

```
{{ now | date_to_rfc822 }}
```

**Output**

```
{{ now | date_to_rfc822 }}
```


## Entity list filters

Entity List filters are used to work with certain [*entitylist*](#entitylist) attribute values, and to help create entity list views.  

### **current\_sort**

Given a sort expression, returns the current sort direction for a given attribute.

**Code**

```
{{ 'name ASC, createdon DESC' | current_sort: 'createdon' }}
```

**Output**

```
DESC
```

### **metafilters**

Parses an *[entitylist](#entitylist)* filter\_definition JSON value into filter option group objects.  

metafilters can be optionally provided with a current attribute filter query and current [*entitylist*](#entitylist), allowing the returned filter objects to be flagged as either selected or unselected.  

### **reverse\_sort**

Given a sort direction, returns the opposite sort direction.

**Code**

```
<!-- Sort direction is not case-sensitive -->

{{ 'ASC' | reverse_sort }}

{{ 'desc' | reverse_sort }}
```

**Output**

```
DESC

ASC
```


## Math filters

Math filters allow you to perform mathematical operations on [*Liquid types*](liquid-types.md).  

As with all filters, math filters can be chained, and are applied in order from left to right.

**Code**

```
{{ 10 | times: 2 | minus: 5 | divided_by: 3 }}
```

**Output**

```
{{ 10 | times: 2 | minus: 5 | divided_by: 3 }}
```

### **ceil**

Rounds a value up to the nearest integer.

**Code**

```
{{ 4.6 | ceil }}

{{ 4.3 | ceil }}
```

**Output**

```
5

5
```

### **divided\_by**

Divides a number by another number.

**Code**

```
{{ 10 | divided_by: 2 }}

{{ 10 | divided_by: 3 }}

{{ 10.0 | divided_by: 3 }}
```

**Output**

```
{{ 10 | divided_by: 2 }}

{{ 10 | divided_by: 3 }}

{{ 10.0 | divided_by: 3 }}
```

### **floor**

Rounds a value down to the nearest integer.

**Code**

```
{{ 4.6 | floor }}

{{ 4.3 | floor }}
```

**Output**

```
4

4
```

### **minus**

Subtracts a number from another number.

**Code**

```
<!-- entityview.page = 11 -->

{{ entityview.page | minus: 1 }}

{{ 10 | minus: 1.1 }}

{{ 10.1 | minus: 1 }}
```

**Output**

```
10

{{ 10 | minus: 1.1 }}

{{ 10.1 | minus: 1 }}
```

### **modulo**

Divides a number by another number and returns the remainder.

**Code**

```
{{ 12 | modulo: 5 }}
```

**Output**

```
{{ 12 | modulo: 5 }}
```

### **plus**

Adds a number to another number.

**Code**

```
<!-- entityview.page = 11 -->

{{ entityview.page | plus: 1 }}

{{ 10 | plus: 1.1 }}

{{ 10.1 | plus: 1 }}
```

**Output**

```
12

{{ 10 | plus: 1.1 }}

{{ 10.1 | plus: 1 }}
```

### **round**

Rounds a value to the nearest integer or specified number of decimals.

**Code**

```
{{ 4.6 | round }}

{{ 4.3 | round }}

{{ 4.5612 | round: 2 }}
```

**Output**

```
5

4

4.56
```

### **times**

Multiplies a number by another number.

**Code**

```
{{ 10 | times: 2 }}

{{ 10 | times: 2.2 }}

{{ 10.1 | times: 2 }}
```

**Output**

```
{{ 10 | times: 2 }}

{{ 10 | times: 2.2 }}

{{ 10.1 | times: 2 }}
```


## String filters

String filters manipulate [*Liquid types*](liquid-types.md).  

### **append**

Appends a string to the end of another string.

**Code**

```
{{ 'filename' | append: '.js' }}
```

**Output**

```
{{ 'filename' | append: '.js' }}
```

### **capitalize**

capitalizes the first word in a string.

**Code**

```
{{ 'capitalize me' | capitalize }}
```

**Output**

```
{{ 'capitalize me' | capitalize }}
```

### **downcase**

Converts a string into lowercase.

**Code**

```
{{ 'MIxed Case TExt' | downcase }}
```

**Output**

```
{{ 'MIxed Case TExt' | downcase }}
```

### **escape**

HTML-escapes a string.

**Code**

```
{{ '<p>test</p>' | escape }}
```

**Output**

```
<p>test</p>
```

### **newline\_to\_br**

Inserts a &lt;br /&gt; line break HTML tag at each line break in a string.

**Code**

```
{% capture text %}

A

B

C

{% endcapture %}

{{ text | newline_to_br }}
```

**Output**

```
A<br />

B<br />

C<br />
```

### **prepend**

Prepends a string to the beginning of another string.

**Code**

```
{{ 'Jane Johnson' | prepend: 'Dr. ' }}
```

**Output**

```
{{ 'Jane Johnson' | prepend: 'Dr. ' }}
```

### **remove**

Remove all occurrences of a substring from a string.

**Code**

```
{{ 'Hello, Dave. How are you, Dave?' | remove: 'Dave' }}
```

**Output**

```
{{ 'Hello, Dave. How are you, Dave?' | remove: 'Dave' }}
```

### **remove\_first**

Removes the first occurrence of a substring from a string.

**Code**

```
{{ 'Hello, Dave. How are you, Dave?' | remove_first: 'Dave' }}
```

**Output**

```
{{ 'Hello, Dave. How are you, Dave?' | remove_first: 'Dave' }}
```

### **replace**

Replaces all occurrences of a string with a substring.

**Code**

```
{{ 'Hello, Dave. How are you, Dave?' | replace: 'Dave', 'John' }}
```

**Output**

```
{{ 'Hello, Dave. How are you, Dave?' | replace: 'Dave', 'John' }}
```

### **replace\_first**

Replaces the first occurrence of a string with a substring.

**Code**

```
{{ 'Hello, Dave. How are you, Dave?' | replace_first: 'Dave', 'John' }}
```

**Output**

```
{{ 'Hello, Dave. How are you, Dave?' | replace_first: 'Dave', 'John' }}
```

### **split**

The split filter takes on a substring as a parameter. The substring is used as a delimiter to divide a string into an array.

**Code**

```
{% assign words = "This is a demo of the split filter" | split: ' ' %}

First word: {{ words.first }}

First word: {{ words[0] }}

Second word: {{ words[1] }}

Last word: {{ words.last }}

All words: {{ words | join: ', ' }}
```

**Output**

```
{% assign words = "This is a demo of the split filter" | split: ' ' %}

First word: {{ words.first }}

First word: {{ words[0] }}

Second word: {{ words[1] }}

Last word: {{ words.last }}

All words: {{ words | join: ', ' }}
```

### **strip\_html**

Strips all HTML tags from a string.

**Code**

```
<p>Hello</p>
```

**Output**

```
Hello
```

### **strip\_newlines**

Strips any line breaks from a string.

**Code**

```
{% capture text %}

A

B

C

{% endcapture %}

{{ text | strip_newlines }}
```

**Output**

```
ABC
```

### **text\_to\_html**

Formats a plain text string as simple HTML. All text will be HTML encoded, blocks of text separated by a blank line will be wrapped in paragraph &lt;p&gt; tags, single line breaks will be replaced with &lt;br&gt;, and URLs will be converted to hyperlinks.

**Code**

```
{{ note.notetext | text_to_html }}
```

**Output**

```
<p>This is the first paragraph of notetext. It contains a URL: <a href="http://example.com/" rel="nofollow">http://example.com</a></p>

<p>This is a second paragraph.</p>
```

### **truncate**

Truncates a string down to a given number of characters. An ellipsis (...) is appended to the string and is included in the character count.

**Code**

```
{{ 'This is a long run of text.' | truncate: 10 }}
```

**Output**

```
{{ 'This is a long run of text.' | truncate: 10 }}
```

### **truncate\_words**

Truncates a string down to a given number of words. An ellipsis (...) is appended to the truncated string.

**Code**

```
{{ 'This is a long run of text.' | truncate_words: 3 }}
```

**Output**

```
{{ 'This is a long run of text.' | truncate_words: 3 }}
```

### **upcase**

Converts a string into uppercase.

**Code**

```
{{ 'MIxed Case TExt' | upcase }}
```

**Output**

```
{{ 'MIxed Case TExt' | upcase }}
```

### **url\_escape**

URI-escape a string, for inclusion in a URL.

**Code**

```
{{ 'This & that//' | url_escape }}
```

**Output**

```
This+%26+that%2F%2F
```

### **xml\_escape**

XML-escape a string, for inclusion in XML output.

**Code**

```
{{ '<p>test</p>' | xml_escape }}
```

**Output**

```
<p>test</p>
```


## Type filters

Type filters allow you to convert values of one type into other types.

### **boolean**

Attempts to convert a string value into a Boolean. If the value is already a Boolean, it will be returned unchanged. If the value cannot be converted into a Boolean, null will be returned.

This filter will also accept "on", "enabled", or "yes" as true, and "off", "disabled", and "no" as false.

> [!Note] [*Additional filters*](#additional-filters)

**Code**

```
{{ true | boolean }}

{{ 'false' | boolean }}

{{ 'enabled' | boolean }}

{{ settings['something/enabled'] | boolean | default: false }}
```

**Output**

```
{{ true | boolean }}

{{ 'false' | boolean }}

{{ 'enabled' | boolean }}

false
```

### **decimal**

Attempts to convert a string value into a decimal number. If the value is already a decimal number, it will be returned unchanged. If the value cannot be converted into a decimal number, null will be returned.

> [!Note] [*Additional filters*](#additional-filters) 

**Code**

```
{{ 10.1 | decimal }}

{{ '3.14' | decimal }}

{{ 'text' | decimal | default: 3.14 }}
```

**Output**

```
{{ 10.1 | decimal }}

{{ '3.14' | decimal }}

{{ 'text' | decimal | default: 3.14 }}
```

### **integer**

Attempts to convert a string value into an integer. If the value is already an integer, it will be returned unchanged. If the value cannot be converted into an integer, null will be returned.

> [!Note] [*Additional filters*](#additional-filters)  

**Code**

```
{{ 10 | integer }}

{{ '10' | integer }}

{{ '10.1' | integer }}

{{ 'text' | integer | default: 2 }}
```

**Output**

```
{{ 10 | integer }}

{{ '10' | integer }}

{{ '10.1' | integer }}

{{ 'text' | integer | default: 2 }}
```

### **string**

Attempts to convert a value into its string representation. If the value is already a string, it will be returned unchanged. If the value is null, null will be returned.



## URL filters

URL filters allow you to build or extract parts of URLs.

### **add\_query**

Appends a query string parameter to a URL. If the parameter already exists in the URL, the parameter value will be updated.

If this filter is applied to a full absolute URL, an updated absolute URL will be the result. If it is applied to a path, an updated path will be the result.

**Code**

```
{{ 'http://example.com/path?page=1' | add_query: 'foo', 'bar' }}

{{ '/path?page=1' | add_query: 'page', 2 }}
```

**Output**

```
{{ 'http://example.com/path?page=1' | add_query: 'foo', 'bar' }}

{{ '/path?page=1' | add_query: 'page', 2 }}
```

### **base**

Gets the base URL of a given URL.

**Code**

```
{{ 'http://example.com/path?foo=bar&page=2' | base }}
```

**Output**

```
http://example.com
```

### **host**

Gets the host part of a URL.

**Code**

```
{{ 'http://example.com/path?foo=bar&page=2' | host }}
```

**Output**

```
{{ 'http://example.com/path?foo=bar&page=2' | host }}
```

### **path**

Gets the path part of a URL.

**Code**

```
{{ 'http://example.com/path?foo=bar&page=2' | path }}

{{ '/path?foo=bar&page=2' | path }}
```

**Output**

```
{{ 'http://example.com/path?foo=bar&page=2' | path }}

{{ '/path?foo=bar&page=2' | path }}
```

### **path\_and\_query**

Gets the path and query part of a URL.

**Code**

```
{{ 'http://example.com/path?foo=bar&page=2' | path_and_query }}

{{ '/path?foo=bar&page=2' | path_and_query }}
```

**Output**

```
/path?foo=bar&page=2

/path?foo=bar&page=2
```

### **port**

Gets the port number of a URL.

**Code**

```
{{ 'http://example.com/path?foo=bar&page=2' | port }}

{{ 'https://example.com/path?foo=bar&page=2' | port }}

{{ 'https://example.com:9000/path?foo=bar&page=2' | port }}
```

**Output**

```
{{ 'http://example.com/path?foo=bar&page=2' | port }}

{{ 'https://example.com/path?foo=bar&page=2' | port }}

{{ 'https://example.com:9000/path?foo=bar&page=2' | port }}
```

### **remove\_query**

Removes a query string parameter from a URL. If the parameter does not exists in the URL, the URL will be returned unchanged.

If this filter is applied to a full absolute URL, an updated absolute URL will be the result. If it is applied to a path, an updated path will be the result.

**Code**

```
{{ 'http://example.com/path?page=1' | remove_query: 'page' }}

{{ '/path?page=1' | remove_query: 'page' }}
```

**Output**

```
{{ 'http://example.com/path?page=1' | remove_query: 'page' }}

{{ '/path?page=1' | remove_query: 'page' }}
```

### **scheme**

Gets the scheme part of a URL.

**Code**

```
{{ 'http://example.com/path?foo=bar&page=2' | scheme }}

{{ 'https://example.com/path?foo=bar&page=2' | scheme }}
```

**Output**

```
{{ 'http://example.com/path?foo=bar&page=2' | scheme }}

{{ 'https://example.com/path?foo=bar&page=2' | scheme }}
```


## Additional filters

These filters provide useful general functionality.

### **default**

Returns a default value for any variable with no assigned value (i.e. null).

**Code**

```
{{ snippets["Header"] | default: 'My Website' }}
```

**Output**

```
<!-- If a snippet with the name "Header" returns null -->

My Website
```

### **file\_size**

Applied to a number value representing a number of bytes, returns a formatted file size with a unit of appropriate scale.

Optionally, a precision parameter can be passed, to control the number of decimal places in the result. The default precision is 1.

**Code**

```
{{ 10000000 | file_size }}

{{ 2050 | file_size: 0 }}

{{ entity.notes.first.filesize | file_size: 2 }}
```

**Output**

```
9.5 MB

2 KB

207.14 KB
```

### **has\_role**

Applied to a [*user*](#user), returns true if the user belongs to the given role. Returns false if not.  

**Code**

```
{% assign is_admin = user | has_role: 'Administrators' %}

{% if is_admin %}

User is an administrator.

{% endif %}
```

### **liquid**

Renders a string as Liquid code. This code will have access to the current Liquid execution context (variables, etc.).

> [!Note] 
> This filter should be used with caution and should generally only be applied to values that are under the exclusive control of portal content authors, or other users that can be trusted to write Liquid code.

**Code**

```
{{ page.adx_copy | liquid }}
```

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Store source content by using web templates*](store-content-web-templates.md)  
[*Understand Liquid operators*](liquid-operators.md) 
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](#liquid-filters)  