using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Recording : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
