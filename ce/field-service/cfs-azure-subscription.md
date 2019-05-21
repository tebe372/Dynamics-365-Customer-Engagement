---
title: "Azure subscription prerequisites for Connected Field Service with IoTHub | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/21/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---


# Azure subscription prerequisites for Connected Field Service with IoTHub

When deploying and administering Connected Field Service (CFS) with IoTHub, there are a few considerations and prerequisites for your Azure subscription. 

## Prerequesites 

1.  CFS with IoTHub can only be deployed and administered to one Azure tenant, which should be the home (first) Azure tenant tied to your credentials.

2. In order to deploy and administer IotHub, you must have one of the following Azure security roles:

- Owner in Role Assignments (see the following screenshot)
- One of the following administrator roles:
  - Co-administrator
  - Service administrator
  - Account administrator

> [!div class="mx-imgBorder"]
> ![Screenshot of azure security role dropdown](./media/cfs-azure-api-management-owner.png)


3. You will only see subscriptions that are tied to your login's **primary active directory**. For example, david@contoso.com will only see subscriptions from the contoso.com directory. If jason@fabrikam.com invites David into their fabrikam.onmicrosoft.com subscription, David will not be able to use the fabrikam subscription on the deployment app.


4. Your user must have permission to use the Dynamics API within the Azure active directory tenant.

> [!div class="mx-imgBorder"]
> ![Screenshot of CRM API access](./media/cfs-azure-api-management.png)

