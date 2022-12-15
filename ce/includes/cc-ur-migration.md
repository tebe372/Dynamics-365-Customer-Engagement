- **Entity display name**: When you create the schema, select the entities in the same sequence as mentioned in the table.
- **Attribute display name**: We recommend that you select the attributes defined in the following table. You don't need to select the out-of-the-box system defined attributes like Created By, Created On, Modified By, Modified On, and Owner. You can select custom attributes, if required.
- **Use FetchXML to filter records**: For each entity, use the appropriate fetch xml query that's mentioned in the following table to get single, multiple, or all records based on your requirement. For single or multiple records, you need to use source organization to get the correct name in uiname and GUID in value. If required, you can use the advanced find option to construct the appropriate FetchXML query.
 - **Configure import settings**: For the Decision contract entity, ensure that you select the **Do not update existing records** checkbox.
 
   > [!Note]
   > The sample query listed in the following table gets single or multiple records. The query has considered the entity as incident and task. Based on your requirements, be sure to update the entity logical name in the FetchXML query.
