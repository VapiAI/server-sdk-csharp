using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VariableExtractionAlias : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
