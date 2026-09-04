using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Result of the recording-consent flow, including consent type and the time consent was granted.
/// </summary>
[Serializable]
public record RecordingConsent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of recording consent.
    /// </summary>
    [JsonPropertyName("type")]
    public required RecordingConsentType Type { get; set; }

    /// <summary>
    /// This is the date and time the recording consent was granted.
    /// If not specified, it means the recording consent was not granted.
    /// </summary>
    [JsonPropertyName("grantedAt")]
    public DateTime? GrantedAt { get; set; }

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
