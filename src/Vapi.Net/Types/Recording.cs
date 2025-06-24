using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Recording
{
    /// <summary>
    /// This is the stereo recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("stereoUrl")]
    public string? StereoUrl { get; set; }

    /// <summary>
    /// This is the video recording url for the call. To enable, set `assistant.artifactPlan.videoRecordingEnabled`.
    /// </summary>
    [JsonPropertyName("videoUrl")]
    public string? VideoUrl { get; set; }

    /// <summary>
    /// This is video recording start delay in ms. To enable, set `assistant.artifactPlan.videoRecordingEnabled`. This can be used to align the playback of the recording with artifact.messages timestamps.
    /// </summary>
    [JsonPropertyName("videoRecordingStartDelaySeconds")]
    public double? VideoRecordingStartDelaySeconds { get; set; }

    /// <summary>
    /// This is the mono recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("mono")]
    public Mono? Mono { get; set; }

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
