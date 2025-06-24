using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VoicemailDetectionBackoffPlan
{
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
