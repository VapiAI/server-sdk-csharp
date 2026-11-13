using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardClassificationCoverageDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pending")]
    public required int Pending { get; set; }

    [JsonPropertyName("unavailable")]
    public required int Unavailable { get; set; }

    [JsonPropertyName("skipped")]
    public required int Skipped { get; set; }

    [JsonPropertyName("error")]
    public required int Error { get; set; }

    [JsonPropertyName("excluded")]
    public required int Excluded { get; set; }

    [JsonPropertyName("complete")]
    public required int Complete { get; set; }

    [JsonPropertyName("partial")]
    public required int Partial { get; set; }

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
