using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record OpenAiFunctionParameters
{
    /// <summary>
    /// This must be set to 'object'. It instructs the model to return a JSON object containing the function call properties.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This provides a description of the properties required by the function.
    /// JSON Schema can be used to specify expectations for each property.
    /// Refer to [this doc](https://ajv.js.org/json-schema.html#json-data-type) for a comprehensive guide on JSON Schema.
    /// </summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, JsonSchema> Properties { get; set; } =
        new Dictionary<string, JsonSchema>();

    /// <summary>
    /// This specifies the properties that are required by the function.
    /// </summary>
    [JsonPropertyName("required")]
    public IEnumerable<string>? Required { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
