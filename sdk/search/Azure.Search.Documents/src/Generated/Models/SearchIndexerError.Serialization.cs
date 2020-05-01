// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class SearchIndexerError
    {
        internal static SearchIndexerError DeserializeSearchIndexerError(JsonElement element)
        {
            string key = default;
            string errorMessage = default;
            int statusCode = default;
            string name = default;
            string details = default;
            string documentationLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    documentationLink = property.Value.GetString();
                    continue;
                }
            }
            return new SearchIndexerError(key, errorMessage, statusCode, name, details, documentationLink);
        }
    }
}