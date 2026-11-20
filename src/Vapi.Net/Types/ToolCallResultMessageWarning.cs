using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolCallResultMessageWarning : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The kind of warning. Currently:
    /// - `oversized-tool-response`: the tool's serialized response exceeded the
    ///   recommended size and is likely to bloat the model context, increasing
    ///   latency and risking truncation of earlier instructions.
    /// </summary>
    [JsonPropertyName("type")]
    public required ToolCallResultMessageWarningType Type { get; set; }

    /// <summary>
    /// The estimated number of tokens in the serialized tool response.
    /// </summary>
    [JsonPropertyName("tokenCount")]
    public required double TokenCount { get; set; }

    /// <summary>
    /// The threshold (in tokens) above which the warning is raised.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required double Threshold { get; set; }

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
