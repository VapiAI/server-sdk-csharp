using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallBatchResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Subscription limits at the end of this batch
    /// </summary>
    [JsonPropertyName("subscriptionLimits")]
    public SubscriptionLimits? SubscriptionLimits { get; set; }

    /// <summary>
    /// This is the list of calls that were created.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<Call> Results { get; set; } = new List<Call>();

    /// <summary>
    /// This is the list of calls that failed to be created.
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<CallBatchError> Errors { get; set; } = new List<CallBatchError>();

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
