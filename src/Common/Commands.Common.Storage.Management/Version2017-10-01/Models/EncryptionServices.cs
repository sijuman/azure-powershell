// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Version2017_10_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A list of services that support encryption.
    /// </summary>
    public partial class EncryptionServices
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionServices class.
        /// </summary>
        public EncryptionServices()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionServices class.
        /// </summary>
        /// <param name="blob">The encryption function of the blob storage
        /// service.</param>
        /// <param name="file">The encryption function of the file storage
        /// service.</param>
        /// <param name="table">The encryption function of the table storage
        /// service.</param>
        /// <param name="queue">The encryption function of the queue storage
        /// service.</param>
        public EncryptionServices(EncryptionService blob = default(EncryptionService), EncryptionService file = default(EncryptionService), EncryptionService table = default(EncryptionService), EncryptionService queue = default(EncryptionService))
        {
            Blob = blob;
            File = file;
            Table = table;
            Queue = queue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the encryption function of the blob storage service.
        /// </summary>
        [JsonProperty(PropertyName = "blob")]
        public EncryptionService Blob { get; set; }

        /// <summary>
        /// Gets or sets the encryption function of the file storage service.
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public EncryptionService File { get; set; }

        /// <summary>
        /// Gets the encryption function of the table storage service.
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public EncryptionService Table { get; private set; }

        /// <summary>
        /// Gets the encryption function of the queue storage service.
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public EncryptionService Queue { get; private set; }

    }
}
