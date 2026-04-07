using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VoicemailDetectionBackoffPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the number of seconds to wait before starting the first retry attempt.
    /// </summary>
    [JsonPropertyName("startAtSeconds")]
    public double? StartAtSeconds { get; set; }

    /// <summary>
    /// This is the interval in seconds between retry attempts.
    /// </summary>
    [JsonPropertyName("frequencySeconds")]
    public double? FrequencySeconds { get; set; }

    /// <summary>
    /// This is the maximum number of retry attempts before giving up.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

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
