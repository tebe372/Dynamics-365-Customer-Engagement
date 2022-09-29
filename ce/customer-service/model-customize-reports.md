---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using Power BI."
ms.date: 10/03/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Model customization of historical analytics reports in Customer Service (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

Dynamics 365 Power BI extensibility feature enables you to extend out-of-the-box Customer Service Power BI data model and integrate with other data sets to produce new custom metrics. You can customize the out-of-the-box standard reports and add your own KPIs and custom metrics to the reports to view the key metrics that are relevant to your organization. You can also drill down to add your metrics to the report as required.

The key capabilities of model customization include the ability to:

- Edit the out-of-the-box data model and add new metrics in addition to the out-of-the-box metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from Customer Service workspace.

This article describes how to enable the data model customization feature and set up the workspace for Microsoft to provision the out-of-the-box data model in a read-only workspace, and a workspace where the customized report can be published to render it in the Customer Service workspace.

## Prerequisites

Before you begin with the customization, you must have the following prerequisites:

- Have at least one of the historical reports enabled for Customer service manager, Omnichannel.
- Have access to Power BI for Microsoft service account.
- Have administrative privileges for Dynamics 365 Customer Service and Power BI.
- Have a Power BI Professional or Power BI Premium license for all supervisors and administrators.

- As a system administrator, you must create and add a security group for Power BI service. Follow these steps to create and add a security group:

   1. Create a security group in Azure Active Directory (Azure AD), and add **Dynamics 365 Analytics** as a member of the security group. More information: [Create a basic group and add members using Azure Active Directory](/azure/active-directory/fundamentals/active-directory-groups-create-azure-portal)
   

   1. As a Power BI administrator, enable the **Service Principal** in the **Developer settings** in the Power BI admin portal and the security group that you created in Azure AD.
   
      a. Sign in to [Power BI service](https://app.powerbi.com) and go to **Settings** > **Admin portal**.

        > [!div class=mx-imgBorder]
        > ![Select Admin portal.](media/supervisor-admin-powerbi-select-admin-portal.png "Select Admin portal")

      b. In the admin portal, go to **Tenant settings** > **Developer settings** > **Allow service principals to use Power BI APIs**.

      c. Enable **Allow service principals to use Power BI APIs** By setting the toggle to **Yes** and specify the security group to which you want to give access by selecting **Specify the security groups (Recommended)** option, and then entering the security groups.

        > [!div class=mx-imgBorder]
        > ![Enable service principals for security group.](media/supervisor-admin-enable-service-principals.png "Enable service principals for security group")

      d. Select **Apply**.

The following section describes a step-by-step process to enable model customization of your historical analytics reports.

### Enable the Embedded Power BI report extensibility - Historical data model customization (preview) option

You need to enable the option to be able to extend the out-of-the-box Power BI data model and add new metrics to your reports.

 1. In the Customer Service admin center site map, select **Insights** in **Operations**.
 1. On the **Insights** page, **Report settings** section, for **Embedded Power BI extensibility - Data model customization (preview)**, select **Manage**.
 1. On the **Embedded Power BI extensibility - Data model customization (preview)** page, set the **Enable embedded Power BI data model customization** toggle to **On**.
 
:::image type="content" source="media/model-csac.png" alt-text="Enable Model customization in Customer Service admin center":::
 
After you've enabled the **Embedded Power BI report extensibility - Historical data model customization (preview)** option, perform the steps described in the following section.
 
## Step 1: Select a Power BI workspace for historical analytics

You must select a workspace to specify the destination where your customized reports will be published. You can either select a workspace from the dropdown list and select **Save** or create a new workspace.

To create a new workspace:
 1. Select **Create new workspace**.
 1. In the **Create Power BI workspace** dialog, provide a workspace name and select **Create**.
 1. Select **Save**. The report provisioning process is initiated.
 
:::image type="content" source="media/enable-model-step1.png" alt-text="Select your workspace":::

> [!NOTE]
> - The report will be provisioned in your Power BI tenant and not in Microsoft Power BI tenant. A hidden workspace will be created where the data set will be hosted, which will connect to Power BI. The report will be provisioned in your workspace and the Power BI files will be published into this workspace.      
> - This dataset is maintained by Dynamics Customer Service and is refreshed on a daily basis. We recommend that you don't make changes to this dataset, as it may lead to report malfunction.

## Step 2: Grant permissions for data set and reports

After the report is provisioned, perform the following steps to grant authoring (read or write) permissions for Power users and read permissions for supervisors.

:::image type="content" source="media/enable-model-step2.png" alt-text="Grant permissions for data set and reports":::

1. Select **Give permissions to access out-of-the-box Power BI Data model**.
 :::image type="content" source="media/share-report.png" alt-text="Give permissions":::

   1. Share the report by selecting **Share** . More information: [Share access to a dataset (preview)](/power-bi/connect-data/service-datasets-share)

   1. Select **Share dataset**.
   1. On the **Share dataset** dialog, search and provide the recipients name or email address.
   1. Select the checkboxes for the various permissions that you want to set for the recipient.
   1. Select **Grant accesss.**
   :::image type="content" source="media/share-dataset.png" alt-text="Search for recipients ont eh Share dataset dialog":::

1. Select **Give permissions to customize Power BI Report**. This will take you to the workspace in Power BI where the sample reports will be provided. These reports are the copy of your out-of-the-box reports. You can make changes to the reports.

      :::image type="content" source="media/grant-permissions.png" alt-text="Grant permissions":::
    1. Select **Access**.
    1. If you want to embed the report back to Dynamics 365 and share it with someone, make sure you grant the person workspace contributor role or above.
    :::image type="content" source="media/grant-permissions_role.png" alt-text="Grant roles":::

1. After providing access, if you need to update a report, select the required report and then select **Edit**. 
    :::image type="content" source="media/model_update-report.png" alt-text="Update an existing report by selecting Edit option":::

1. You may also create a report in one of the following ways:

   1. Create a report online.
       1. Select the Power BI data model in Step 2 and from the **Create a report** dropdown list, select **Auto-create**.
       
       :::image type="content" source="media/model-create-report-online.png" alt-text="Create a report online from the Power BI data model"::: 

   1. Create a report using Power BI Desktop and create a live connection to datasets in the Power BI service:
        1. On the Power BI desktop, select **Get Data**.
        1. On the **Get Data** dialog, select **Power Platform**, and then select **Power BI data sets**.
        1. Select **Connect**.
        :::image type="content" source="media/model-powerdataset.png" alt-text="Select Power BI data set":::
        1. On the **Data hub** dialog, select the report you want to embed to Customer Service and select **Connect**.
        :::image type="content" source="media/model-data-hub-dialog.png" alt-text="Select your report on the Data hub dialog":::
        1. On the **Connect to your data** dialog, select the database or the specific tables that you want to connect to.
        1. Select **Submit**.
        :::image type="content" source="media/model-select-dataset.png" alt-text="Select your tables that you want to connect to.":::
        
        1. After the database or tables that you have selected in the  previous step, get added to your data model, save the changes you made to your file.
        :::image type="content" source="media/model-save-data-model-changes.png" alt-text="Save your changes.":::
        1. On the **Publish to Power BI** dialog, select the workspace that you specified on Step 1 and then select **Select**.
         :::image type="content" source="media/model-select-workspace-created-in-step-two.png" alt-text="Select the destination which you specified in Step 2":::
        Your reports will be published to Power BI.
        

## Step 3: Embed customized report from Power BI workspace to Dynamics 365

After you've created and published the report, go back to the Customer Service admin center **Insights** page, and select **Add reports**. You'll now be able to select the reports that you want to see on the Customer Service workspace site map.

:::image type="content" source="media/enable-model-step3.png" alt-text="Add report to site map":::

1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, step 3, select **Add report**.
1. Enter a name and select **Add**. You can add a maximum of 40 reports.
 
## Step 4: Render reports in Customer Service workspace

1. In the Customer Service workspace site map, select the **Plus** icon.
1. Select **Customized reports** from the dropdown list and then select the report that you want to view.

:::image type="content" source="media/customized-reports-option.png" alt-text="View your reports in Customer Service workspace":::

## Data model and report mapping

For more information on data model and report mapping, see [Data model and report mapping for historical analytics reports in Customer Service](oob-data-models.md#data-model-and-report-mapping-for-historical-analytics-reports-in-customer-service)

### See also

[Visual customization of historical analytics reports in Customer Service](customize-reports.md#visual-customization-of-historical-analytics-reports-in-customer-service)  
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md) <br>
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md) <br>
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md) <br>
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
