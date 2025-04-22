using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record OpenAiVoicemailDetectionPlan
{
    /// <summary>
    /// This is how long should we listen in order to determine if we were sent to voicemail or not?
    ///
    /// @default 15
    /// </summary>
    [JsonPropertyName("voicemailExpectedDurationSeconds")]
    public required double VoicemailExpectedDurationSeconds { get; set; }

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
