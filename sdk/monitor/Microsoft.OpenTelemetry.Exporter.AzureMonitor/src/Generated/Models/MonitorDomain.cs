// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> The abstract common base of all domains. </summary>
    public partial class MonitorDomain
    {
        /// <summary> Initializes a new instance of MonitorDomain. </summary>
        /// <param name="version"> Schema version. </param>
        public MonitorDomain(int version)
        {
            Version = version;
        }

        /// <summary> Schema version. </summary>
        public int Version { get; }
    }
}
