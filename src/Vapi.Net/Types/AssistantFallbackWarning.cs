using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantFallbackWarning : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Machine-readable reason for the warning.
    /// </summary>
    [JsonPropertyName("code")]
    public required AssistantFallbackWarningCode Code { get; set; }

    /// <summary>
    /// Path of the setting the warning is about, relative to the assistant:
    /// `voice.fallbackPlan.voices[1]` for one fallback, or
    /// `voice.fallbackPlan.voices` for the whole list.
    /// </summary>
    [JsonPropertyName("slot")]
    public required string Slot { get; set; }

    /// <summary>
    /// Human-readable explanation, in sentence case.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

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
