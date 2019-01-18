---
title: "Use the XRM tooling common login control in your client applications (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "The Dynamics 365 for Customer Engagement apps SDK provides you with a template for Visual Studio that enables you to use the common login control in your client applications. The code for Dynamics 365 for Customer Engagement authentication, credential storage and retrieval, and diagnostic logging is built into the template so that you can quickly leverage these capabilities in your Windows client applications for Dynamics 365 for Customer Engagement"
ms.custom: 
ms.date: 1/16/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: f77b2a20-0a30-4211-a1d9-74923d3eeae1
caps.latest.revision: 27
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Use the XRM tooling common login control in your client applications

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

There is a template for Visual Studio that enables you to use the common login control in your client applications. The code for [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] authentication, credential storage and retrieval, and diagnostic logging is built into the template so that you can quickly leverage these capabilities in your Windows client applications for [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. The common login control is an implementation of the <xref:Microsoft.Xrm.Tooling.CrmConnectControl>, and the control resembles the following image.  
  
 ![XRM Tooling common login control](../media/crm-sdk-v6-commonlogincontrol.png "XRM Tooling common login control")  
  
<a name="Prereq"></a>

## Prerequisites
  
- **.NET Framework 4.6.2**
  
- Visual Studio 2017 (recommended)  
   
- Connected to Internet so that you can download/restore the required Nuget packages while using the project template.  
  
<a name="NewProjectUsingTemplate"></a>
   
## Create a WPF application using the common login control template
  
Here is a quick way to create a **Windows Presentation Foundation (WPF)** application that leverages the common login control and the underlying code for authentication, credential storage and reuse, and default tracing or logging.  
  
1. Start Visual Studio 2017, and create a new project.  
  
2. In the **New Project** dialog box:  
  
   1. From the list of installed templates, expand **Visual C#**, and select **Dynamics 365 for Customer Engagement apps SDK Templates**.  
  
   2. Ensure that **.NET Framework 4.6.2** is selected.  
  
   3. Select **WPF Application for Dynamics 365 for Customer Engagement apps**.  
  
   4. Specify the name and location of the project, and click **OK**.  
  
   > [!div class="mx-imgBorder"]
   > ![WPF Application for Dynamics 365 for Customer Engagement template](../media/crm-sdk-v6-xrmtooling-newproject.png "WPF Application for Dynamics 365 for Customer Engagement template")  
  
> [!NOTE]
> **Known Issue with Visual Studio 2015**
> 
> When you are running your project/solution in VS 2015 in debug mode, you may not be able to connect. This happens regardless of whether you are using a Target Framework of 4.6.2 or higher. This can occur because the Visual Studio hosting process is compiled against .NET 4.5 which means by default it does not support TLS 1.2. You can disable the Visual Studio hosting process as a work around. 
>
> Right-click on the name of your project in Visual Studio and then click **Properties**. On the **Debug** tab you can uncheck the **Enable the Visual Studio hosting process** option. 
>
> This only impacts the debug experience in VS 2015. This does not impact the binaries or executable that are built. The same issue does not occur in Visual Studio 2017.

3. To test the project:  
  
   1. Save the project and press F5 or click **Debug** > **Start Debugging** to verify if the project compiles successfully. On successful compilation, you’ll see a MainWindow with **Login to Dynamics 365 for Customer Engagement apps** button. Click the button to display the common login control.  
  
   2. Test the authentication by providing your credentials to connect to **Dynamics 365 for Customer Engagement apps**, and then click **Login**. A message displays your connection status.  
  
   For a sample that uses the common login control template to connect to Customer Engagement and perform various operations, see [Sample: Quick start for XRM Tooling API](sample-quick-start-xrm-tooling-api.md).  
  
<a name="Add"></a>

## Add the common login control template to your existing WPF application

If you already have a WPF client application, you can easily add the common login control template to it to leverage the uniform sign-in experience and the underlying code for Customer Engagement authentication, credential storage and reuse, and default tracing or logging. In this case, you must create a control in the user interface of your existing client application to call the common login control, instantiate an instance of the Customer Engagement connection object, and then use the connection object to perform various operations in Customer Engagement.  
  
1. Open an existing WPF application project in Visual Studio. For this example, let’s assume that the name of your WPF application project is `SampleWPFApp`.  
  
2. Add the common login control template to your project.  
  
   1.  In the **Solution Explorer** pane, right-click the project name, and click **Add** > **New Item**.  
  
   2.  In the **Add New Item** dialog box, from the list of installed templates, expand **Visual C#**, and select **Dynamics 365 for Customer Engagement apps SDK Templates**. Click **Dynamics 365 for Customer Engagement apps Login Form for WPF Applications**, and click **OK**.  
  
   ![Add the common login control template](../media/crm-sdk-v6-xrmtooling-addtemplate01.png "Add the common login control template")  
  
3. The newly added `CrmLoginForm1.xaml` login control is displayed in the XAML designer area. If it isn’t displayed, double-click the `CrmLoginForm1.xaml` file in the **Solution Explorer** pane.  
  
   ![Verify that the login control renders properly](../media/crm-sdk-v6-xrmtooling-addtemplate03.png "Verify that the login control renders properly")  
  
4. You must now call the newly added login control from your application. To do this, add a **Button** control on your MainWindow.xaml file, and set the name and content to **btnSignIn** and **Sign in to Dynamics 365 for Customer Engagement apps** respectively.  
  
   ![Add a control to call the login form](../media/crm-sdk-v6-xrmtooling-addtemplate02.png "Add a control to call the login form")  
  
5. Double-click the button to add code for the click event of the **btnSignIn** button in the MainWindow.xaml.cs file.  
  
6. Add the following sample code in the click event of the **btnSignIn** button to call the CrmLoginForm1 control, and create an instance of the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] connection object.  
  
   ```csharp
   // Establish the Login control.  
   CRMLoginForm1 ctrl = new CRMLoginForm1();  
  
   // Wire event to login response.   
   ctrl.ConnectionToCrmCompleted += ctrl_ConnectionToCrmCompleted;  
  
   // Show the login control.   
   ctrl.ShowDialog();  
  
   // Handle the returned CRM connection object.  
   // On successful connection, display the CRM version and connected org name   
   if (ctrl.CrmConnectionMgr != null && ctrl.CrmConnectionMgr.CrmSvc != null && ctrl.CrmConnectionMgr.CrmSvc.IsReady)  
   {  
       MessageBox.Show("Connected to CRM! Version: " + ctrl.CrmConnectionMgr.CrmSvc.ConnectedOrgVersion.ToString() +   
       " Org: " + ctrl.CrmConnectionMgr.CrmSvc.ConnectedOrgUniqueName, "Connection Status");  
  
       // Perform your actions here  
   }  
   else  
   {  
       MessageBox.Show("Cannot connect; try again!", "Connection Status");  
   }  
   ```  
  
7. Add the definition of the `ctrl_ConnectionToCrmCompleted` event below the click event of the button:  
  
   ```csharp  
   private void ctrl_ConnectionToCrmCompleted(object sender, EventArgs e)  
   {  
       if (sender is CRMLoginForm1)  
       {  
           this.Dispatcher.Invoke(() =>  
           {  
               ((CRMLoginForm1)sender).Close();  
           });  
       }  
   }  
   ```  
  
8. This is how your MainWindow.xaml.cs file appears after adding code from the previous two steps:  
  
   ![Sample code](../media/crm-sdk-v6-xrmtooling-addtemplate04.png "Sample code")  
  
9. To test the project:  
  
   1. Save the project and press F5 or click **Debug** > **Start Debugging** to verify if the project compiles successfully. On successful compilation, you will see a MainWindow with the new **Sign In to Dynamics 365 for Customer Engagement apps** button. Click it to display the common login control.  
  
   2. Test the authentication by providing your credentials to connect to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], and then click **Login**. If successful, a message appears stating the version and the organization name that you are connected to. Click **OK** to close the message.  
  
   ![Project test results](../media/crm-sdk-v6-xrmtooling-addtemplate05.png "Project test results")  
  
    3.  If you click **Sign In to Dynamics 365 for Customer Engagement apps** again, the application prompts you to either choose the saved credentials from the last sign-in activity, or to re-enter the new credentials.  
  
   ![Stored credentials](../media/crm-sdk-v6-xrmtooling-addtemplate06.png "Stored credentials")  
  
### See also  
 [Sample: Quick start for XRM Tooling API](sample-quick-start-xrm-tooling-api.md)   
 [Build windows client applications using the XRM tools](../build-windows-client-applications-xrm-tools.md)
