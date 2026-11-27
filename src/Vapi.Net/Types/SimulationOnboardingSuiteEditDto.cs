using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingSuiteEditDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Simulation in the suite whose scenario is rewritten.
    /// </summary>
    [JsonPropertyName("simulationId")]
    public required string SimulationId { get; set; }

    /// <summary>
    /// Natural-language instructions for revising this simulation's scenario, such as "Have the caller ask for a refund after 30 days."
    /// </summary>
    [JsonPropertyName("instruction")]
    public required string Instruction { get; set; }

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
