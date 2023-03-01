---
title: Troubleshoot issues for integrated search providers
description: Learn how to troubleshoot errors related to data on the Insights tab. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/01/2023
ms.custom: bap-template
---

# Troubleshoot issues for integrated search providers (preview)

The article describes the troubleshooting steps to diagnose and fix issues for integrated search providers.

## Data doesn't get updated on the Insights tab for integrated search providers (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

## Symptoms

Data isn't updated on the **Insights** tab even after the scheduled refresh interval time.

## Resolution

Perform the following troubleshooting steps to diagnose and fix the issue:

- Check whether the root URL and the sitemap URL are configured correctly. There is a possibility that there is some misconfiguration or the URLs provided don't exist. Check the URLs on the browser to make sure that they are valid ones.
- Check if the **External Reference Id** field is mapped to a unique field in the source property. As the ID is expected to be unique, mapping repeated or non-unique fields for this field from the source will cause issues when articles are ingested.
- Make sure that you haven't selected the **No refresh** option for **Refresh interval** for a data provider.
- If the source is authenticated, make sure that the secret provided is correct.

If the issue persists, raise a Microsoft Support ticket.

For detailed information on managing a search provider, go to: [Manage integrated search providers (preview)](add-search-provider.md#manage-integrated-search-providers-preview).