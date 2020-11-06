// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.OpenTelemetry.Exporter.AzureMonitor.Models
{
    public partial class MetricDataPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("ns");
                writer.WriteStringValue(Namespace);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(DataPointType))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(DataPointType.Value.ToString());
            }
            writer.WritePropertyName("value");
            writer.WriteNumberValue(Value);
            if (Optional.IsDefined(Count))
            {
                if (Count != null)
                {
                    writer.WritePropertyName("count");
                    writer.WriteNumberValue(Count.Value);
                }
                else
                {
                    writer.WriteNull("count");
                }
            }
            if (Optional.IsDefined(Min))
            {
                if (Min != null)
                {
                    writer.WritePropertyName("min");
                    writer.WriteNumberValue(Min.Value);
                }
                else
                {
                    writer.WriteNull("min");
                }
            }
            if (Optional.IsDefined(Max))
            {
                if (Max != null)
                {
                    writer.WritePropertyName("max");
                    writer.WriteNumberValue(Max.Value);
                }
                else
                {
                    writer.WriteNull("max");
                }
            }
            if (Optional.IsDefined(StdDev))
            {
                if (StdDev != null)
                {
                    writer.WritePropertyName("stdDev");
                    writer.WriteNumberValue(StdDev.Value);
                }
                else
                {
                    writer.WriteNull("stdDev");
                }
            }
            writer.WriteEndObject();
        }
    }
}
