// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines a data change detection policy that captures changes using the
    /// Integrated Change Tracking feature of Azure SQL Database.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.SqlIntegratedChangeTrackingPolicy")]
    public partial class SqlIntegratedChangeTrackingPolicy : DataChangeDetectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SqlIntegratedChangeTrackingPolicy class.
        /// </summary>
        public SqlIntegratedChangeTrackingPolicy() { }


    }
}
