using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardAssignmentCoverageDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pending")]
    public required int Pending { get; set; }

    [JsonPropertyName("unmatched")]
    public required int Unmatched { get; set; }

    [JsonPropertyName("skipped")]
    public required int Skipped { get; set; }

    [JsonPropertyName("unavailable")]
    public required int Unavailable { get; set; }

    [JsonPropertyName("error")]
    public required int Error { get; set; }

    [JsonPropertyName("coverageGapCount")]
    public required int CoverageGapCount { get; set; }

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
