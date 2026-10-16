using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A directed connection between two workflow nodes, with an optional AI-evaluated transition condition.
/// </summary>
[Serializable]
public record Edge : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Condition that must evaluate to true to follow this edge.
    /// </summary>
    [JsonPropertyName("condition")]
    public AiEdgeCondition? Condition { get; set; }

    /// <summary>
    /// Name of the source workflow node.
    /// </summary>
    [JsonPropertyName("from")]
    public required string From { get; set; }

    /// <summary>
    /// Name of the destination workflow node.
    /// </summary>
    [JsonPropertyName("to")]
    public required string To { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the edge.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

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
