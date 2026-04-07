using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunItemMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is a snapshot of the assistant at run creation time.
    /// </summary>
    [JsonPropertyName("assistant")]
    public object? Assistant { get; set; }

    /// <summary>
    /// This is a snapshot of the squad at run creation time.
    /// </summary>
    [JsonPropertyName("squad")]
    public object? Squad { get; set; }

    /// <summary>
    /// This is a snapshot of the scenario at run creation time.
    /// </summary>
    [JsonPropertyName("scenario")]
    public object? Scenario { get; set; }

    /// <summary>
    /// This is a snapshot of the personality at run creation time.
    /// </summary>
    [JsonPropertyName("personality")]
    public object? Personality { get; set; }

    /// <summary>
    /// This is a snapshot of the simulation at run creation time.
    /// </summary>
    [JsonPropertyName("simulation")]
    public object? Simulation { get; set; }

    /// <summary>
    /// This is the call-related data (transcript, messages, recording).
    /// </summary>
    [JsonPropertyName("call")]
    public SimulationRunItemCallMetadata? Call { get; set; }

    /// <summary>
    /// Hook execution state for this run item (used for idempotency + debugging).
    /// </summary>
    [JsonPropertyName("hooks")]
    public object? Hooks { get; set; }

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
