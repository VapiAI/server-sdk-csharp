using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VariableExtractionAlias
{
    /// <summary>
    /// This is the key of the variable.
    ///
    /// This variable will be accessible during the call as `{{key}}` and stored in `call.artifact.variableValues` after the call.
    ///
    /// Rules:
    /// - Must start with a letter (a-z, A-Z).
    /// - Subsequent characters can be letters, numbers, or underscores.
    /// - Minimum length of 1 and maximum length of 40.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// This is the value of the variable.
    ///
    /// This can reference existing variables, use filters, and perform transformations.
    ///
    /// Examples: "{{name}}", "{{customer.email}}", "Hello {{name | upcase}}"
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
