// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    internal class InteractionResourceFormatOperationSource : IOperationSource<InteractionResourceFormatResource>
    {
        private readonly ArmClient _client;

        internal InteractionResourceFormatOperationSource(ArmClient client)
        {
            _client = client;
        }

        InteractionResourceFormatResource IOperationSource<InteractionResourceFormatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = InteractionResourceFormatData.DeserializeInteractionResourceFormatData(document.RootElement);
            return new InteractionResourceFormatResource(_client, data);
        }

        async ValueTask<InteractionResourceFormatResource> IOperationSource<InteractionResourceFormatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = InteractionResourceFormatData.DeserializeInteractionResourceFormatData(document.RootElement);
            return new InteractionResourceFormatResource(_client, data);
        }
    }
}
