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
    /// Represents an Azure SQL Server.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Server : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server() { }

        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="fullyQualifiedDomainName">Gets the fully qualified
        /// domain name of the server.</param>
        /// <param name="version">Gets the version of the server.</param>
        /// <param name="administratorLogin">Gets administrator username for
        /// the server.</param>
        /// <param name="administratorLoginPassword">Gets the administrator
        /// login password.</param>
        public Server(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string fullyQualifiedDomainName = default(string), string version = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string))
            : base(location, id, name, type, tags)
        {
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            Version = version;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
        }

        /// <summary>
        /// Gets the fully qualified domain name of the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets the version of the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets administrator username for the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; private set; }

        /// <summary>
        /// Gets the administrator login password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; private set; }

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
