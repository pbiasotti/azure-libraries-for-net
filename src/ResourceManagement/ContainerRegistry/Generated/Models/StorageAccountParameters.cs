// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerRegistry;
    using Microsoft.Azure.Management.ContainerRegistry.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters of a storage account for a container registry.
    /// </summary>
    public partial class StorageAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountParameters class.
        /// </summary>
        public StorageAccountParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountParameters class.
        /// </summary>
        /// <param name="name">The name of the storage account.</param>
        /// <param name="accessKey">The access key to the storage
        /// account.</param>
        public StorageAccountParameters(string name, string accessKey)
        {
            Name = name;
            AccessKey = accessKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the access key to the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (AccessKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessKey");
            }
        }
    }
}
