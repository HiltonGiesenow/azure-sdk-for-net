// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> L2NetworkPatchParameters represents the body of the request to patch the L2 network. </summary>
    public partial class NetworkCloudL2NetworkPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkCloudL2NetworkPatch"/>. </summary>
        public NetworkCloudL2NetworkPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudL2NetworkPatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        internal NetworkCloudL2NetworkPatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
