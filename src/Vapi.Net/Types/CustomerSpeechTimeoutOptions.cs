using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Controls how long a hook waits for customer speech, how often it can trigger, and when its trigger counter resets.
/// </summary>
[Serializable]
public record CustomerSpeechTimeoutOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Controls whether the hook's trigger counter resets after the customer speaks. Defaults to `never`.
    /// </summary>
    [JsonPropertyName("triggerResetMode")]
    public CustomerSpeechTimeoutOptionsTriggerResetMode? TriggerResetMode { get; set; }

    /// <summary>
    /// This is the timeout in seconds before action is triggered.
    /// The clock starts when the assistant finishes speaking and remains active until the user speaks.
    ///
    /// @default 7.5
    /// @minimum 2
    /// @maximum 1000
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
