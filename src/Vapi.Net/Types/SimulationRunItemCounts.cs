using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunItemCounts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Total number of run items
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; set; }

    /// <summary>
    /// Number of passed run items
    /// </summary>
    [JsonPropertyName("passed")]
    public required double Passed { get; set; }

    /// <summary>
    /// Number of failed run items
    /// </summary>
    [JsonPropertyName("failed")]
    public required double Failed { get; set; }

    /// <summary>
    /// Number of running/evaluating run items
    /// </summary>
    [JsonPropertyName("running")]
    public required double Running { get; set; }

    /// <summary>
    /// Number of queued run items
    /// </summary>
    [JsonPropertyName("queued")]
    public required double Queued { get; set; }

    /// <summary>
    /// Number of canceled run items
    /// </summary>
    [JsonPropertyName("canceled")]
    public required double Canceled { get; set; }

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
