// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a reference to Key Vault Key
    /// </summary>
    public partial class KeyVaultKeyReference
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReference class.
        /// </summary>
        public KeyVaultKeyReference() { }

        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReference class.
        /// </summary>
        public KeyVaultKeyReference(string keyUrl, SubResource sourceVault)
        {
            KeyUrl = keyUrl;
            SourceVault = sourceVault;
        }

        /// <summary>
        /// Gets or sets the URL referencing a key in a Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "keyUrl")]
        public string KeyUrl { get; set; }

        /// <summary>
        /// Gets or sets the Relative URL of the Key Vault containing the key
        /// </summary>
        [JsonProperty(PropertyName = "sourceVault")]
        public SubResource SourceVault { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (KeyUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyUrl");
            }
            if (SourceVault == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceVault");
            }
        }
    }
}
