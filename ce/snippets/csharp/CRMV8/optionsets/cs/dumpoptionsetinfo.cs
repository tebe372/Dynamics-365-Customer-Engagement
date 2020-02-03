// <snippetdumpoptionsetinfo>


using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to retrieve and write out global option set values.
    /// </summary>
    public class DumpOptionSetInfo
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Create storage for new attributes being created
        public List<AttributeMetadata> addedAttributes;

        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See https://msdn.microsoft.com/library/0h88fahh.aspx
        public const int _languageCode = 1033;

        // Define the IDs/variables needed for this sample.
        public int _insertedStatusValue;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {

                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    #region How to dump option set info


                    RetrieveAllOptionSetsRequest retrieveAllOptionSetsRequest =
                         new RetrieveAllOptionSetsRequest();

                    // Execute the request
                    RetrieveAllOptionSetsResponse retrieveAllOptionSetsResponse =
                        (RetrieveAllOptionSetsResponse)_serviceProxy.Execute(
                        retrieveAllOptionSetsRequest);

                    // Create an instance of StreamWriter to write text to a file.
                    // The using statement also closes the StreamWriter.
		    // To view this file, right click the file and choose open with Excel. 
		    // Excel will figure out the schema and display the information in columns.

                    String filename = String.Concat("AllOptionSetValues.xml");
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        // Create Xml Writer.
                        XmlTextWriter metadataWriter = new XmlTextWriter(sw);

                        // Start Xml File.
                        metadataWriter.WriteStartDocument();

                        // Metadata Xml Node.
                        metadataWriter.WriteStartElement("Metadata");

                        if (retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0)
                        {
                            
                            foreach (OptionSetMetadataBase optionSetMetadataBase in
                                retrieveAllOptionSetsResponse.OptionSetMetadata)
                            {
                                if (optionSetMetadataBase.OptionSetType != null)
                                {
                                    if ((OptionSetType)optionSetMetadataBase.OptionSetType == OptionSetType.Picklist)
                                    {
                                        OptionSetMetadata optionSetMetadata = (OptionSetMetadata)optionSetMetadataBase;
                                        // Start OptionSet Node
                                        metadataWriter.WriteStartElement("OptionSet");
                                        metadataWriter.WriteAttributeString("OptionSetType", OptionSetType.Picklist.ToString());
                                        metadataWriter.WriteElementString("OptionSetDisplayName", 
                                            (optionSetMetadata.DisplayName.LocalizedLabels.Count > 0)? optionSetMetadata.DisplayName.LocalizedLabels[0].Label : String.Empty);

                                        // Writes the options
                                        metadataWriter.WriteStartElement("Options");

                                        foreach (OptionMetadata option in optionSetMetadata.Options)
                                        {
                                            metadataWriter.WriteStartElement("Option");
                                            metadataWriter.WriteElementString("OptionValue", option.Value.ToString());
                                            metadataWriter.WriteElementString("OptionDescription", option.Label.UserLocalizedLabel.Label.ToString());
                                            metadataWriter.WriteEndElement();
                                        }
                                        metadataWriter.WriteEndElement();

                                        // End OptionSet Node
                                        metadataWriter.WriteEndElement();
                                    }
                                    else if ((OptionSetType)optionSetMetadataBase.OptionSetType == OptionSetType.Boolean)
                                    {
                                        BooleanOptionSetMetadata optionSetMetadata = (BooleanOptionSetMetadata)optionSetMetadataBase;
                                        // Start OptionSet Node
                                        metadataWriter.WriteStartElement("OptionSet");
                                        metadataWriter.WriteAttributeString("OptionSetType", OptionSetType.Boolean.ToString());
                                        if (optionSetMetadata.DisplayName.LocalizedLabels.Count != 0)
                                            metadataWriter.WriteElementString("OptionSetDisplayName", optionSetMetadata.DisplayName.LocalizedLabels[0].Label);
                                        else
                                            metadataWriter.WriteElementString("OptionSetDisplayName", "UNDEFINED");

                                        // Writes the TrueOption
                                        metadataWriter.WriteStartElement("TrueOption");
                                        metadataWriter.WriteElementString("OptionValue", optionSetMetadata.TrueOption.Value.ToString());
                                        metadataWriter.WriteElementString("OptionDescription", optionSetMetadata.TrueOption.Label.UserLocalizedLabel.Label.ToString());
                                        metadataWriter.WriteEndElement();
                                        // Writes the FalseOption
                                        metadataWriter.WriteStartElement("FalseOption");
                                        metadataWriter.WriteElementString("OptionValue", optionSetMetadata.FalseOption.Value.ToString());
                                        metadataWriter.WriteElementString("OptionDescription", optionSetMetadata.FalseOption.Label.UserLocalizedLabel.Label.ToString());
                                        metadataWriter.WriteEndElement();

                                        // End OptionSet Node
                                        metadataWriter.WriteEndElement();
                                    }
                                }
                            }
                        }

                        // End Metadata Xml Node
                        metadataWriter.WriteEndElement();
                        metadataWriter.WriteEndDocument();

                        // Close xml writer.
                        metadataWriter.Close();
                    }


                    #endregion How to dump option set info



                    Console.WriteLine("Done.");

                    //DeleteRequiredRecords(promptForDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// Deletes/Reverts the record that was created/changed for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine(
                    "\nDo you want these entity records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
 
            }
        }
        #endregion How To Sample Code

        #region Main
        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                DumpOptionSetInfo app = new DumpOptionSetInfo();
                app.Run(config, false);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }

        }
        #endregion Main

    }
}

// </snippetdumpoptionsetinfo>