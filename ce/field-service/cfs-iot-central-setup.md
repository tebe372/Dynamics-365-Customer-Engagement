---
title: "Prerequisites for Connected Field Service for IoT Central | MicrosoftDocs"
ms.custom: "dyn365-fieldservice"
ms.date: 09/24/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.author: "krbjoran"
ms.manager: "shellyhaverkamp"
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# Prerequisites for setting up Connected Field Service for Azure IoT Central

Ready to connect Azure IoT Central to Connected Field Service (CFS) using Microsoft Flow -- to see how you can harness the power of the Internet of Things (IoT) to improve customer service (without writing any code)?

Before you take this tutorial, you need to complete four tasks:
- Provision the Azure IoT Central solution using the Sample Contoso template.
- Get a Dynamics 365 for Field Service tenant with system administrator credentials. 
- Install the Dynamics 365 Connected Field Service add-on from the Dynamics 365 admin center.
- Install Connected Field Service sample data.

This topic provides you with links to everything you need, and walks you through the steps to get started.

## Provision the Azure IoT Central solution using the sample Contoso template
The sample Contoso template contains a **Refrigerated Vending Machine** device template, which you need to create your device type and generate a simulated device for testing purposes.

First, [navigate to Azure IoT Central](https://azure.microsoft.com/services/iot-central/). Then choose **Get started**. To start creating your new Azure IoT Central application, choose **New Application**. 
 
On the **Create Application** dialog: 
 1. Choose the **Paid** payment plan (you won't be asked for a credit card). 
 2. Choose the **Sample Contoso** template. 
 3. Then choose **Create**.
> [!div class="mx-imgBorder"]
> ![Azure IoT Central with payment plan and template selected](media/Azure-IoT-Central-create-app-dialog.PNG "Azure IoT Central with payment plan and template selected")  

After a few seconds, you'll see the Contoso home page. 
> [!div class="mx-imgBorder"]
> ![Contoso home page for Azure IoT Central](media/Azure-IoT-Central-Contoso-home-dialog.PNG "Contoso home page for Azure IoT Central")

## Get a Dynamics 365 for Field Service tenant with system administrator credentials 

You'll need a Dynamics 365 for Field Service tenant that you can connect your IoT solution to.
     
New to Field Service and need a tenant? No worries. [Sign up for a free trial for development purposes](https://appsource.microsoft.com/product/dynamics-365/mscrm.40fd37ef-dca4-4b0d-9f41-d16703b7d070).

## Install the Dynamics 365 Connected Field Service add-on from the Dynamics 365 admin center  

The free Connected Field Service add-on automatically provisions a number of Azure IoT services seamlessly on top of Dynamics 365 for Field Service. 
 
To install Connected Field Service:
1. Navigate to the Dynamics 365 admin center. 
2. On the **Instances** page, select the Dynamics 365 for Field Service tenant, and then edit **Solutions**. 
3. On the **Manage your solutions** page, select **Connected Field Service version 1.0.18260.2**, and then choose **Install**. Follow the on-screen instructions to complete the installation.
    
## Install Connected Field Service sample data    
Next, you'll need to download and install the Connected Field Service sample data package, which is designed for use with the Contoso template in Azure IoT Central. The sample data also includes an **IoT Sample - Process alert** workflow that showcases automated alert triaging.

To install the Connected Field Service sample data:
1. [Download the PackageDeployer zip file](https://aka.ms/cfsdemodata).
2. In Windows File Manager, go to the folder where you downloaded the zip file. 
3. Right-click the zip file, and then select **Properties**. 
4. On the Properties dialog, select **Unblock**. Click **OK**.
> [!div class="mx-imgBorder"]
> ![PackageDeployer properties dialog with Unblock selected](media/cfs-iot-package-deployer.png "PackageDeployer properties dialog with Unblock selected")

5. Right-click the zip file, select **Extract All**, and then select **Extract**.
6. Double-click **packagedeployer.exe** to run it and install the sample data. 
7. When prompted, enter your system administrator credentials to sign in to your Dynamics 365 tenant. When you see the Azure IoT Central and Connected Field Service sample data deployment page, follow the on-screen instructions to complete the installation.

That's it! You're ready to take the tutorial.
   
Next step: [Receive IoT alerts from IoT Central](cfs-iot-central-alerts.md) 
