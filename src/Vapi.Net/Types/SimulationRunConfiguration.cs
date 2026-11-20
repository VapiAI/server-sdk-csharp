using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunConfiguration : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Generate directly attached target structured outputs. Default false. Enabled extraction may incur additional model charges.
    /// </summary>
    [JsonPropertyName("includeTargetStructuredOutputs")]
    public bool? IncludeTargetStructuredOutputs { get; set; }

    /// <summary>
    /// Transport configuration for the simulation run
    /// </summary>
    [JsonPropertyName("transport")]
    public SimulationRunTransportConfiguration? Transport { get; set; }

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
