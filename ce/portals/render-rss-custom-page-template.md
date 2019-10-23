---
title: "Render an RSS feed using custom page template for a portal | MicrosoftDocs"
description: "Instructions to create a custom page template and use it to render an RSS feed."
ms.custom: 
  - dyn365-portal
ms.date: 04/08/2019
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 24413b7a-1fcc-4146-a8c9-899ef9cdcceb
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---
# Create a custom page template to render an RSS feed
In this example, we'll create a custom page template to render an [RSS feed](http://en.wikipedia.org/wiki/RSS) of news articles, using Liquid and a Web Template Page Template. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Store source content by using web templates](store-content-web-templates.md)  

## Step 1: Create a new model-driven app

First, we'll create a new model-driven app that we'll use to load the data for our feed. In this example, we'll make it a view on Web Pages, and use this entity to store our articles. We can use this view to configure the sorting and filtering of results, and include as columns the entity attributes that we want available in our Liquid template.

![Edit a page template](media/edit-page-template.png "Edit a page template")  

## Step 2: Create a web template for RSS feed

In this step, we'll create a web template for our RSS feed. This template will be applied to a particular webpage in our website, so we'll use the title and summary of that page as the title and description of the feed. The we'll use the entityview tag to load our newly-created News Articles view. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Common Data Service entity tags](dynamics-entity-tags.md). Note that we also set the **MIME Type** field of the Web Template to application/rss+xml. This indicates what the response content type could be when our template is rendered.  

![Configure a web template for an RSS feed](media/web-template-rss-feed.png "Configure a web template for an RSS feed")  

### RSS Feed (Web Template)

```xml
<?xml version=1.0 encoding=UTF-8 ?>
<rss version=2.0>
  <channel>
    <title>{{ page.title | xml_escape }}</title>
    <description>{{ page.description | strip_html | xml_escape }}</description>
    <link>{{ request.url | xml_escape }}</link>
    {% entityview logical_name:'adx_webpage', name:'News Articles', page_size:20 -%}
      {% for item in entityview.records %}
        <item>
          <title>{{ item.adx_name | xml_escape }}</title>
          <description>{{ item.adx_copy | escape }}</description>
          <link>{{ request.url | base | xml_escape }}{{ item.url | xml_escape }}</link>
          <guid>{{ item.id | xml_escape }}</guid>
          <pubDate>{{ item.createdon | date_to_rfc822 }}</pubDate>
        </item>
      {% endfor -%}
    {% endentityview %}
  </channel>
</rss>
```

## Step 3: Create a page template to assign RSS feed template

Now, we'll create a new page template, allowing us to assign our RSS feed template to any webpage in our website. Note that we deselect **Use Website Header and Footer**, as we want to take over rendering of the entire page response for our feed.

![Configure a page template for an RSS feed](media/page-template-rss-feed.png "Configure a page template for an RSS feed")  

## Step 4: Create a web page to host RSS feed

Now all that's left is to create a new web page to host our feed, giving it a title and summary, and assigning it our RSS Feed template. We can do this in Portalsor by using the portal content editing features:

![Add a new child page](media/add-new-child-page.png "Add a new child page")  

Now, when we request this new webpage, we'll receive our RSS feed XML:

![Example of an RSS feed](media/rss-feed-example.png "Example of an RSS feed")  

In this example, we've seen how we can combine Liquid, Web Templates, model-driven app views, and portals content management features to create a custom RSS feed. The combination of these features adds powerful customization capabilities to any portal application.

### See also

[Create advanced templates for portals](create-advanced-templates.md)  
[Create a custom page template by using Liquid and a web template page template](create-custom-template.md)  
[Render the entity list associated with the current page](render-entity-list-current-page.md)  
[Render a website header and primary navigation bar](render-site-header-primary-navigation.md)  
[Render up to three levels of page hierarchy by using hybrid navigation](hybrid-navigation-render-page-hierachy.md)  

