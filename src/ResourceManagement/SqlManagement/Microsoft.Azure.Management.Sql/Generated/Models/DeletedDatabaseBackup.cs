// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database restorable deleted database.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DeletedDatabaseBackup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DeletedDatabaseBackup class.
        /// </summary>
        public DeletedDatabaseBackup() { }

        /// <summary>
        /// Initializes a new instance of the DeletedDatabaseBackup class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="databaseName">Gets the Azure SQL Database
        /// name.</param>
        /// <param name="creationDate">Gets the creation date of the Azure SQL
        /// Database.</param>
        /// <param name="deletionDate">Gets the deletion date of the Azure SQL
        /// Database.</param>
        /// <param name="earliestRestoreDate">Gets the recovery period starte
        /// date of the Azure SQL Database. This records the start date and
        /// time when recovery is available for this Azure SQL
        /// Database.</param>
        /// <param name="edition">Gets the edition of the Azure SQL
        /// Database.</param>
        /// <param name="maxSizeBytes">Gets the max size of the Azure SQL
        /// Database expressed in bytes.</param>
        /// <param name="serviceLevelObjective">Gets the Service Level
        /// Objective of the Azure SQL Database.</param>
        /// <param name="elasticPoolName">Gets the name of the Azure SQL
        /// Elastic Pool the database is in.</param>
        public DeletedDatabaseBackup(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string databaseName = default(string), System.DateTime? creationDate = default(System.DateTime?), System.DateTime? deletionDate = default(System.DateTime?), System.DateTime? earliestRestoreDate = default(System.DateTime?), string edition = default(string), long? maxSizeBytes = default(long?), string serviceLevelObjective = default(string), string elasticPoolName = default(string))
            : base(location, id, name, type, tags)
        {
            DatabaseName = databaseName;
            CreationDate = creationDate;
            DeletionDate = deletionDate;
            EarliestRestoreDate = earliestRestoreDate;
            Edition = edition;
            MaxSizeBytes = maxSizeBytes;
            ServiceLevelObjective = serviceLevelObjective;
            ElasticPoolName = elasticPoolName;
        }

        /// <summary>
        /// Gets the Azure SQL Database name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; private set; }

        /// <summary>
        /// Gets the creation date of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the deletion date of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.deletionDate")]
        public System.DateTime? DeletionDate { get; private set; }

        /// <summary>
        /// Gets the recovery period starte date of the Azure SQL Database.
        /// This records the start date and time when recovery is available
        /// for this Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; private set; }

        /// <summary>
        /// Gets the edition of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; private set; }

        /// <summary>
        /// Gets the max size of the Azure SQL Database expressed in bytes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; private set; }

        /// <summary>
        /// Gets the Service Level Objective of the Azure SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceLevelObjective")]
        public string ServiceLevelObjective { get; private set; }

        /// <summary>
        /// Gets the name of the Azure SQL Elastic Pool the database is in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.elasticPoolName")]
        public string ElasticPoolName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
