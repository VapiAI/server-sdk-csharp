using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BackgroundSoundUrlValidationResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the URL currently serves a live media file. When false, calls configured with this URL silently play no background sound.
    /// </summary>
    [JsonPropertyName("valid")]
    public required bool Valid { get; set; }

    /// <summary>
    /// Why validation failed. Only present when valid is false.
    /// </summary>
    [JsonPropertyName("reason")]
    public BackgroundSoundUrlValidationResultReason? Reason { get; set; }

    /// <summary>
    /// The HTTP status the URL returned, when a response was received.
    /// </summary>
    [JsonPropertyName("status")]
    public double? Status { get; set; }

    /// <summary>
    /// The content-type the URL returned, when a response was received.
    /// </summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

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
