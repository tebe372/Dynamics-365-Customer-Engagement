---
title: Set up external knowledge search providers (Dynamics 365 Customer Service) | MicrosoftDocs
description: Learn how to set up a search provider for knowledge management in Dynamics 365 Customer Service
ms.date: 09/27/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-msdyn_kmfederatedsearchconfig
 - D365-Entity-incident
 - D365-UI-form
 - Dynamics 365 
 - Customer Service
 - Customer Engagement
---

# Set up external knowledge search providers

Knowledge management plays a vital role in enabling organizations to deliver world-class customer care. Allowing the agents to create rich, high-quality knowledge resources and showing the right knowledge content across engagement modalities (including self-service, assisted service, and onsite service) expedites issue resolution and drives customer and agent satisfaction and productivity. 

The ability to create, import, and share knowledge bases is a core capability of successful support delivery. With knowledge management, agents and supervisors can author knowledge articles from templates, add knowledge search providers from multiple sources (SharePoint, Microsoft Search, and other Dynamics 365 organizations), and receive AI-triggered knowledge suggestions while helping customers to accelerate support delivery.

You can use search providers to federate the search of files, documents, or articles from data sources outside of your current Dynamics 365 organization. Federated search is also supported in sovereign regions.

You can set up the following search providers:

  -	**Cross-Organizational Search**: This option allows you to specify a different organization under the same tenant of the current organization and search the articles from that organization. The list from the current tenant is automatically identified. If the tenant has organizations located across multiple geographical locations, search data transfer happens across these locations.
  -	**Sharepoint**: This option requires you to enter the SharePoint URL, which must also be a part of the same tenant as that of the current organization.
  -	**Microsoft Graph connector**: This option is for organizations that already use Microsoft Search to index all external data. You only need to specify the unique connection ID when you create the connector. To learn more about Microsoft Graph connectors, see [Overview of Microsoft Graph connectors](/microsoftsearch/connectors-overview).
  
From an authentication perspective, your agents must have access to external content, or they won't be able to view search results. 

## Set up a search provider

> [!NOTE]
>
> Before you set up a search provider, ensure that your firewall doesn't block the https://www.d365ccafpi.com/ domain. Otherwise, users will encounter errors.

You can set up a search provider in the Customer Service admin center or Customer Service Hub app by performing the following steps:

1. Go to **Search providers**.
  
### [Customer Service admin center](#tab/customerserviceadmincenter)

  1. In the site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
  2. In the **Search providers** section, select **Manage**.

### [Customer Service Hub](#tab/customerservicehub)

* In the site map, go to **Service Management**, and select **Search providers** in **Knowledge Base Management**.

---

2.	Select **New**.

3.	On the **New Search provider** page, **General** section, enter the name and owner of the search provider. Optionally, you can enter a description.
     
5. In the **Details** section, select the organization and the type of search provider you want to use from the **Select organization** and the **Search Type** dropdown, respectively.

    :::image type="content" source="media/search-provider-details.png" alt-text="Search provider details":::

6. Select **Save**.

## Post-configuration agent experience

After you have configured the search providers, an agent who uses the search functionality can view links in their search results for each search provider included in their current org.

>[!NOTE]
>
>If at least one knowledge search provider is enabled and configured, then the configured value for article search results will not be applicable. For each configured search provider, three article search results will be displayed. Agents can select **Show more** to view additional results. For more information on articles shown in search results, see [Add the Knowledge Base Search control to forms](./add-knowledge-base-search-control-forms.md).

   > [!div class=mx-imgBorder]
   > ![Agent view of search providers.](media/search-provider-agent.png "Agent view of available search providers")
   
For more information about the agent search experience, see [Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md).

> [!NOTE]
>
> Custom roles must have **Read**, **Create**, **Append**, and **AppendTo** access to the following entities to see search results from other search providers:
> - Knowledge Federated Article
> -	Knowledge FederatedArticle Incident
   
### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)

[Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
