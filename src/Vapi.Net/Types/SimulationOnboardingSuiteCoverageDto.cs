using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingSuiteCoverageDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Requirements at least one simulation covers.
    /// </summary>
    [JsonPropertyName("covered")]
    public required double Covered { get; set; }

    /// <summary>
    /// Requirements in the agreed draft.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; set; }

    /// <summary>
    /// Requirements no simulation covers, and why.
    /// </summary>
    [JsonPropertyName("gaps")]
    public IEnumerable<SimulationOnboardingCoverageGapDto> Gaps { get; set; } =
        new List<SimulationOnboardingCoverageGapDto>();

    /// <summary>
    /// Planned scenarios an edit with `retryFailed` would regenerate.
    /// </summary>
    [JsonPropertyName("retryable")]
    public required double Retryable { get; set; }

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
