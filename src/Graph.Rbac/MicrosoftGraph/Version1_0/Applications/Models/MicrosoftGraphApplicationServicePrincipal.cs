// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Applications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// applicationServicePrincipal
    /// </summary>
    public partial class MicrosoftGraphApplicationServicePrincipal
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftGraphApplicationServicePrincipal class.
        /// </summary>
        public MicrosoftGraphApplicationServicePrincipal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftGraphApplicationServicePrincipal class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="application"></param>
        /// <param name="servicePrincipal"></param>
        public MicrosoftGraphApplicationServicePrincipal(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), MicrosoftGraphApplication application = default(MicrosoftGraphApplication), MicrosoftGraphServicePrincipal servicePrincipal = default(MicrosoftGraphServicePrincipal))
        {
            AdditionalProperties = additionalProperties;
            Application = application;
            ServicePrincipal = servicePrincipal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public MicrosoftGraphApplication Application { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicePrincipal")]
        public MicrosoftGraphServicePrincipal ServicePrincipal { get; set; }

    }
}
