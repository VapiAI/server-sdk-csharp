using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ArtifactPlan
{
    /// <summary>
    /// This determines whether assistant's calls are recorded. Defaults to true.
    ///
    /// Usage:
    /// - If you don't want to record the calls, set this to false.
    /// - If you want to record the calls when `assistant.hipaaEnabled`, explicity set this to true and make sure to provide S3 or GCP credentials on the Provider Credentials page in the Dashboard.
    ///
    /// You can find the recording at `call.artifact.recordingUrl` and `call.artifact.stereoRecordingUrl` after the call is ended.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("recordingEnabled")]
    public bool? RecordingEnabled { get; set; }

    /// <summary>
    /// This determines whether the video is recorded during the call. Defaults to false. Only relevant for `webCall` type.
    ///
    /// You can find the video recording at `call.artifact.videoRecordingUrl` after the call is ended.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("videoRecordingEnabled")]
    public bool? VideoRecordingEnabled { get; set; }

    /// <summary>
    /// This is the plan for `call.artifact.transcript`. To disable, set `transcriptPlan.enabled` to false.
    /// </summary>
    [JsonPropertyName("transcriptPlan")]
    public TranscriptPlan? TranscriptPlan { get; set; }

    /// <summary>
    /// This is the path where the recording will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.
    ///
    /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.
    ///
    /// Usage:
    /// - If you want to upload the recording to a specific path, set this to the path. Example: `/my-assistant-recordings`.
    /// - If you want to upload the recording to the root of the bucket, set this to `/`.
    ///
    /// @default '/'
    /// </summary>
    [JsonPropertyName("recordingPath")]
    public string? RecordingPath { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
