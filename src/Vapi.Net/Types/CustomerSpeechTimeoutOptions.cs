using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CustomerSpeechTimeoutOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the timeout in seconds before action is triggered.
    /// The clock starts when the assistant finishes speaking and remains active until the user speaks.
    ///
    /// @default 7.5
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public required double TimeoutSeconds { get; set; }

    /// <summary>
    /// This is the maximum number of times the hook will trigger in a call.
    ///
    /// @default 3
    /// </summary>
    [JsonPropertyName("triggerMaxCount")]
    public double? TriggerMaxCount { get; set; }

    /// <summary>
    /// This is whether the counter for hook trigger resets the user speaks.
    ///
    /// @default never
    /// </summary>
    [JsonPropertyName("triggerResetMode")]
    public object? TriggerResetMode { get; set; }

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
