// <snippetcreateconnection>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to create a connection between two entities.
    /// </summary>
    public class CreateConnection
    {
        #region Class Level Members
        
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _connectionRoleId;
        public Guid _connectionId;
        public Guid _accountId;
        public Guid _contactId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Call the method to create any data that this sample requires.
        /// Create a new connection between the account and the contact.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
                /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();


                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Create a connection between the account and the contact.
                    // Assign a connection role to a record.
                    Connection newConnection = new Connection
                    {
                        Record1Id = new EntityReference(Account.EntityLogicalName,
                            _accountId),
                        Record1RoleId = new EntityReference(ConnectionRole.EntityLogicalName,
                            _connectionRoleId),                             
                        Record2RoleId = new EntityReference(ConnectionRole.EntityLogicalName,
                            _connectionRoleId),                            
                        Record2Id = new EntityReference(Contact.EntityLogicalName,
                            _contactId)
                    };

                    _connectionId = _serviceProxy.Create(newConnection);

                    Console.WriteLine(
                        "Created a connection between the account and the contact.");

                    DeleteRequiredRecords(promptForDelete);

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
        /// This method creates any entity records that this sample requires.
        /// Create a new connectionrole instance. 
        /// Create related Connection Role Object Type Code records
        /// for the account and the contact entities.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a Connection Role for account and contact
            ConnectionRole newConnectionRole = new ConnectionRole
            {
                Name = "Example Connection Role",
                Category = new OptionSetValue((int)connectionrole_category.Business)
            };

            _connectionRoleId = _serviceProxy.Create(newConnectionRole);
            Console.WriteLine("Created {0}.", newConnectionRole.Name);

            // Create a related Connection Role Object Type Code record for Account
            ConnectionRoleObjectTypeCode newAccountConnectionRoleTypeCode
                = new ConnectionRoleObjectTypeCode
                {
                    ConnectionRoleId = new EntityReference(
                        ConnectionRole.EntityLogicalName, _connectionRoleId),
                    AssociatedObjectTypeCode = Account.EntityLogicalName
                };

            _serviceProxy.Create(newAccountConnectionRoleTypeCode);
            Console.WriteLine(
                "Created a related Connection Role Object Type Code record for Account."
                );

            // Create a related Connection Role Object Type Code record for Contact
            ConnectionRoleObjectTypeCode newContactConnectionRoleTypeCode
                = new ConnectionRoleObjectTypeCode
                {
                    ConnectionRoleId = new EntityReference(
                        ConnectionRole.EntityLogicalName, _connectionRoleId),
                    AssociatedObjectTypeCode = Contact.EntityLogicalName
                };

            _serviceProxy.Create(newContactConnectionRoleTypeCode);
            Console.WriteLine(
                "Created a related Connection Role Object Type Code record for Contact."
                );

            // Associate the connection role with itself.
            AssociateRequest associateConnectionRoles = new AssociateRequest
            {
                Target = new EntityReference(ConnectionRole.EntityLogicalName,
                    _connectionRoleId),
                RelatedEntities = new EntityReferenceCollection()
                        {
                            new EntityReference(ConnectionRole.EntityLogicalName,
                                _connectionRoleId)
                        },
                // The name of the relationship connection role association 
                // relationship in MS CRM.
                Relationship = new Relationship()
                {
                    PrimaryEntityRole = EntityRole.Referencing, // Referencing or Referenced based on N:1 or 1:N reflexive relationship.
                    SchemaName = "connectionroleassociation_association"
                }
            };

            _serviceProxy.Execute(associateConnectionRoles);
            Console.WriteLine("Associated the connection role with itself.");

            // Create an Account
            Account setupAccount = new Account { Name = "Example Account" };
            _accountId = _serviceProxy.Create(setupAccount);
            Console.WriteLine("Created {0}.", setupAccount.Name);

            // Create a Contact
            Contact setupContact = new Contact { LastName = "Example Contact" };
            _contactId = _serviceProxy.Create(setupContact);
            Console.WriteLine("Created {0}.", setupContact.LastName);

            return;
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {
                _serviceProxy.Delete(Connection.EntityLogicalName, _connectionId);
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId);
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRoleId);

                Console.WriteLine("Entity records have been deleted.");
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

                CreateConnection app = new CreateConnection();
                app.Run(config, true);
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

// </snippetcreateconnection>