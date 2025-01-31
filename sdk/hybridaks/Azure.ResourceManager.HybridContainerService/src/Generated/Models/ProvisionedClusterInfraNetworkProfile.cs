// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> InfraNetworkProfile - List of infra network profiles for the provisioned cluster. </summary>
    internal partial class ProvisionedClusterInfraNetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterInfraNetworkProfile"/>. </summary>
        public ProvisionedClusterInfraNetworkProfile()
        {
            VnetSubnetIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterInfraNetworkProfile"/>. </summary>
        /// <param name="vnetSubnetIds"> Array of references to azure resource corresponding to the Network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}. </param>
        internal ProvisionedClusterInfraNetworkProfile(IList<ResourceIdentifier> vnetSubnetIds)
        {
            VnetSubnetIds = vnetSubnetIds;
        }

        /// <summary> Array of references to azure resource corresponding to the Network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}. </summary>
        public IList<ResourceIdentifier> VnetSubnetIds { get; }
    }
}
