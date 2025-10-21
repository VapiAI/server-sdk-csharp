using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CustomerSpeechTimeoutOptions
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
