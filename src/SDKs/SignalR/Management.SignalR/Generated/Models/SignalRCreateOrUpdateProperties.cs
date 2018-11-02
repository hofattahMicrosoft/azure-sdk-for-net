// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings used to provision or configure the resource.
    /// </summary>
    public partial class SignalRCreateOrUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the SignalRCreateOrUpdateProperties
        /// class.
        /// </summary>
        public SignalRCreateOrUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRCreateOrUpdateProperties
        /// class.
        /// </summary>
        /// <param name="hostNamePrefix">Prefix for the hostName of the SignalR
        /// service. Retained for future use.
        /// The hostname will be of format:
        /// &amp;lt;hostNamePrefix&amp;gt;.service.signalr.net.</param>
        public SignalRCreateOrUpdateProperties(string hostNamePrefix = default(string))
        {
            HostNamePrefix = hostNamePrefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets prefix for the hostName of the SignalR service.
        /// Retained for future use.
        /// The hostname will be of format:
        /// &amp;amp;lt;hostNamePrefix&amp;amp;gt;.service.signalr.net.
        /// </summary>
        [JsonProperty(PropertyName = "hostNamePrefix")]
        public string HostNamePrefix { get; set; }

    }
}