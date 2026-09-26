using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CampaignContactCounters : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pending")]
    public required double Pending { get; set; }

    [JsonPropertyName("dispatched")]
    public required double Dispatched { get; set; }

    [JsonPropertyName("completed")]
    public required double Completed { get; set; }

    [JsonPropertyName("failed")]
    public required double Failed { get; set; }

    [JsonPropertyName("skipped")]
    public required double Skipped { get; set; }

    [JsonPropertyName("predialFailed")]
    public required double PredialFailed { get; set; }

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
