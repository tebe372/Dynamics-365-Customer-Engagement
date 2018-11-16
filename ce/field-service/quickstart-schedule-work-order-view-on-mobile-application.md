---
title: "Quickstart #1: Schedule a work order and view it on the mobile application - Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/02/2018
ms.reviewer: "krbjoran"
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Quickstart \#1: Schedule a work order and view it on the mobile application

This quickstart demonstrates how to create and schedule a work order as a dispatcher, and view the work order on the mobile application as a field technician.

Estimated Duration: 20 minutes

Steps:

1.  Set up a dispatcher role

2.  Create a work order or select a sample one

3.  Set up a resource (field technician) role

4.  Create a bookable resource

5.  Add the bookable resource to the schedule board

6.  Schedule the work order to the bookable resource

7.  Download the Field Service Mobile (2017) mobile app

8.  Sign into the mobile application as a technician

9. View the work order on the mobile application

## Prerequisites

This quickstart assumes you have the Field Service solution and the mobile solution installed. We strongly recommend using the sample data imported from the package deployer. You will also need access to a mobile device with access to the Windows, Apple, or Android app stores.

### Ensure the Field Service application is installed

When logged in as a Dynamics 365 system administrator, you should see the Field Service module in the menu, as seen in the following screenshot.

![Quickstart 1 Schedule a work order and view it on the mobile application image1](media/qs-1-img1.png)  

See the [Field Service installation walkthrough](install-field-service.md) if you don't see Field Service in the menu.   

### Ensure the mobile solution is installed

When logged in as a system administrator, Woodford appears under **Settings > Solutions** (and as an icon under Settings). See the following screenshots for reference.

![Screenshot of Schedule a work order and view it on the mobile application image2](media/qs-1-img2.png)  

![Screenshot of Schedule a work order and view it on the mobile application image3](media/qs-1-img3.png)  

See the [mobile solution activation walkthrough](activate-fs-mobile-app-license.md) if you don't see Woodford in the menu.

### Ensure the sample data is imported

If the sample data has been imported, you'll see multiple records under **Field Service &gt; Work Orders**.

![Screenshot of Schedule a work order and view it on the mobile application image4](media/qs-1-img4.png)

See these [instructions for importing sample data](install-sample-data-8-x.md) for more information. 

## 1. Set up a dispatcher role 

- Within Dynamics 365, navigate to **Settings** &gt; **Security** &gt; **Users**

- Select a user and then **Manage Roles**

![Screenshot of Schedule a work order and view it on the mobile application image6](media/qs-1-img6.png)

- Assign the user the **Field Service – Administrator** role. This will give your user scheduling, dispatching, and configuration capabilities. If this user is solely a dispatcher, then assign the **Field Service—Dispatcher** role.

## 2. Create a work order or select a sample one

If you have sample data, skip this step.

- Navigate to **Field Service &gt; Work Orders**

- Select +New

- On the work order summary tab, set up the following parameters: 
    - Service Account = **\[select from list or create a new one. Eg. Contoso\]**
    - Work Order Type = **\[select from list or create a new one. Eg. Inspection\]**
    - System Status = **Open-Unscheduled**
    
![Screenshot of Schedule a work order and view it on the mobile application image7](media/qs-1-img7.png)  
 
- On the work order settings tab, set up the following parameters: 
    - Price List = **\[select from list or create new one. Eg. Default Price List\]**
    - Taxable = **No**
    
![Screenshot of Schedule a work order and view it on the mobile application image8](media/qs-1-img8.png) 

- On the work order address tab, enter a valid address

![Screenshot of Schedule a work order and view it on the mobile application image9](media/qs-1-img9.png)  

- Save and close the work order

## 3. Set up a resource (field technician) role 

Now we need to designate one of our users as a field technician.

- Navigate to **Settings** > **Security** > **Users**

- Select the D365 User (different than your dispatcher/administrator user) that will be a field technician and assign him/her the **Field Service – Resource** security role (and only this role).

![Screenshot of Schedule a work order and view it on the mobile application image10](media/qs-1-img10.png)

- Open the field technician’s user record and select “**Field Security Profiles**” in the ribbon, as seen in the following screenshots.

![Screenshot of Schedule a work order and view it on the mobile application image11](media/qs-1-img11.png)

![Screenshot of Schedule a work order and view it on the mobile application image12](media/qs-1-img12.png)

- Assign the field technician user the **Field Service – Resource** field security profile. This step is very important; field technicians can't edit fields on mobile work orders without being assigned this secruity profile. 

![Screenshot of Schedule a work order and view it on the mobile application image13](media/qs-1-img13.png)

![Screenshot of Schedule a work order and view it on the mobile application image14](media/qs-1-img14.png)

If you don't have a user to assign this role, create a new one by navigating to the [admin center in the Office 365 interface](https://login.microsoftonline.com).

![Screenshot of Schedule a work order and view it on the mobile application image15](media/qs-1-img15.png)![Screenshot of Schedule a work order and view it on the mobile application image16](media/qs-1-img16.png)

![Screenshot of Schedule a work order and view it on the mobile application image17](media/qs-1-img17.png)

> [!NOTE]
> This user must have a valid Dynamics 365 for Field Service license. Verify you can log into D365 with the new user record as you may need to reset a temporary password.

Finally, we want to **geocode** our field technician user record. Field technician locations are very important in Field Service because they are used for scheduling and routing.

- In Dynamics 365, navigate to the field technician’s user record in **Settings &gt; Users**

- Every user record has an address taken from the user record in Office 365. Ensure an address is present.

![Screenshot of Schedule a work order and view it on the mobile application image18](media/qs-1-img18.png)  

   - If there is no address, navigate to the Office 365 admin center and enter an address for the user

![Screenshot of Schedule a work order and view it on the mobile application image19](media/qs-1-img19.png)  

![Screenshot of Schedule a work order and view it on the mobile application image20](media/qs-1-img20.png)  

   - In Dynamics 365, refresh the field technician user record to see the address from Office 365

Next, we need to enable geocoding in your Dynamics 365 organization. Geocoding allows the solution to stamp latitudes and longitudes to addresses.

- Navigate to **Resource Scheduling &gt; Administration &gt; Scheduling Parameters**

![Screenshot of Schedule a work order and view it on the mobile application image22](media/qs-1-img22.png)  

- Set **Connect to Maps** to **Yes**.

- The API key should be filled out automatically and uses Bing Maps API. This allows us to attach a latitude and longitude to the user record's address

![Screenshot of Schedule a work order and view it on the mobile application image23](media/qs-1-img23.png)  

- Navigate back to the user record and select **Geocode** in the ribbon. This geocodes the address on the user record taken from Office 365.

![Screenshot of Schedule a work order and view it on the mobile application image24](media/qs-1-img24.png)  

- Confirm the address

![Screenshot of Schedule a work order and view it on the mobile application image25](media/qs-1-img25.png)  


- Select **Change** and the Latitude and Longitude will be populated under the Scheduling section of the user record

![Screenshot of Schedule a work order and view it on the mobile application image26](media/qs-1-img26.png)  

![Screenshot of Schedule a work order and view it on the mobile application image27](media/qs-1-img27.png)  

> [!NOTE]
> If you have trouble populating an address or geocoding an address, you can manually enter a latitude and longitude into the fields on the user record.

Congratulations! You have successfully set up key users and security roles. You're well on your way to using Field Service. 

## 4. Create a bookable resource

Now it's time to create a bookable resource that relates to the field technician user set up in the previous step. This lets you schedule work orders for the field technician, which he/she can see in the mobile application.

- In Dynamics 365, navigate to **Field Service** &gt; **Administration** &gt; **Resources**

![Screenshot of Schedule a work order and view it on the mobile application image28](media/qs-1-img28.png)

- Select **+New**

- Create a new resource (Field Technician) with the following parameters: 

    - Resource Type = **User**
    - User = **\[User record you assigned Resource role to\]**
    - Warehouse = **\[assign a warehouse or create a new one. Ex: Truck 1\]**
    - Hourly Rate = **$60**
    - Start Location = **Resource Address**
    - End Location = **Resource Address**
    - Display on Schedule Board = **Yes**
    - Enable for Availability Search = **Yes**

![Screenshot of Schedule a work order and view it on the mobile application image29](media/qs-1-img29.png)

![Screenshot of Schedule a work order and view it on the mobile application image30](media/qs-1-img30.png)   

## 5. Add the bookable resource to the schedule board

Lets add this new field technician to the schedule board

Navigate to **Field Service** &gt; **Schedule Board**

![Screenshot of Schedule a work order and view it on the mobile application image32](media/qs-1-img32.png)

In the left pane of the schedule board, select **Options** &gt; **Select Resources**

![Screenshot of Schedule a work order and view it on the mobile application image33](media/qs-1-img33.png)

Find your new **field technician** with a Resource Type = **User** and move him/her to the right to selected resources, then choose **Apply**

![Screenshot of Schedule a work order and view it on the mobile application image34](media/qs-1-img34.png)![Screenshot of Schedule a work order and view it on the mobile application image35](media/qs-1-img35.png)

## 6. Schedule the work order to the bookable resource

In the lower pane, find the work order you created or select a sample work order. This work order should be found in both the Open Requirements view and the Unscheduled Work Orders view, click and drag the work order from the bottom to the new Field technician

![Screenshot of Schedule a work order and view it on the mobile application image36](media/qs-1-img36.png)

Let’s now view this scheduled work order on the mobile application as a field technician.

## 7. Download the Field Service Mobile (2017) mobile app

Download the **Field Service Mobile (2017)** mobile app from the Windows, Apple, or Android app stores onto a phone, tablet, or Windows 10 device.

![Screenshot of Schedule a work order and view it on the mobile application image37](media/qs-1-img37.png)

## 8. Sign into the mobile application as a technician

Navigate to the **Field Service Mobile (2017)** mobile app on your Windows, iOS, or Android device, then **Setup** and sign in with the credentials of the User record of your Field Technician

![Screenshot of Schedule a work order and view it on the mobile application image38](media/qs-1-img38.png)

![Screenshot of Schedule a work order and view it on the mobile application image39](media/qs-1-img39.png)

URL: **\[enter the URL of your Dynamics 365 org. Ex: https://org.crm.dynamics.com]\**

Username: **\[enter the username of the User associated with your Field Technician. Ex: username@org.onmicrosoft.com]\**

Password: **\[enter the password of the User associated with your Field Technician\]**

> [!NOTE]
> If you recently created a User to be a field technician, log in to the web browser with this user first as you may need to reset a temporary password.

![Screenshot of Schedule a work order and view it on the mobile application image40](media/qs-1-img40.png)

##  9. View the work order on the mobile application 

In the **Booking** tab, the booking (work order) is scheduled to the field technician.

![Screenshot of Schedule a work order and view it on the mobile application image41](media/qs-1-img41.png)

> [!NOTE]
> You should see only bookings assigned to the field technician resource. This is because the field technician has a security role of Field Service – Resource. If you see many bookings for many different resources, it most likely means you're signed in to the mobile application as an administrator.
