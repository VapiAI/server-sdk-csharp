using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TavusConversationProperties
{
    /// <summary>
    /// The maximum duration of the call in seconds. The default `maxCallDuration` is 3600 seconds (1 hour).
    /// Once the time limit specified by this parameter has been reached, the conversation will automatically shut down.
    /// </summary>
    [JsonPropertyName("maxCallDuration")]
    public double? MaxCallDuration { get; set; }

    /// <summary>
    /// The duration in seconds after which the call will be automatically shut down once the last participant leaves.
    /// </summary>
    [JsonPropertyName("participantLeftTimeout")]
    public double? ParticipantLeftTimeout { get; set; }

    /// <summary>
    /// Starting from conversation creation, the duration in seconds after which the call will be automatically shut down if no participant joins the call.
    /// Default is 300 seconds (5 minutes).
    /// </summary>
    [JsonPropertyName("participantAbsentTimeout")]
    public double? ParticipantAbsentTimeout { get; set; }

    /// <summary>
    /// If true, the user will be able to record the conversation.
    /// </summary>
    [JsonPropertyName("enableRecording")]
    public bool? EnableRecording { get; set; }

    /// <summary>
    /// If true, the user will be able to transcribe the conversation.
    /// You can find more instructions on displaying transcriptions if you are using your custom DailyJS components here.
    /// You need to have an event listener on Daily that listens for `app-messages`.
    /// </summary>
    [JsonPropertyName("enableTranscription")]
    public bool? EnableTranscription { get; set; }

    /// <summary>
    /// If true, the background will be replaced with a greenscreen (RGB values: `[0, 255, 155]`).
    /// You can use WebGL on the frontend to make the greenscreen transparent or change its color.
    /// </summary>
    [JsonPropertyName("applyGreenscreen")]
    public bool? ApplyGreenscreen { get; set; }

    /// <summary>
    /// The language of the conversation. Please provide the **full language name**, not the two-letter code.
    /// If you are using your own TTS voice, please ensure it supports the language you provide.
    /// If you are using a stock replica or default persona, please note that only ElevenLabs and Cartesia supported languages are available.
    /// You can find a full list of supported languages for Cartesia here, for ElevenLabs here, and for PlayHT here.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// The name of the S3 bucket where the recording will be stored.
    /// </summary>
    [JsonPropertyName("recordingS3BucketName")]
    public string? RecordingS3BucketName { get; set; }

    /// <summary>
    /// The region of the S3 bucket where the recording will be stored.
    /// </summary>
    [JsonPropertyName("recordingS3BucketRegion")]
    public string? RecordingS3BucketRegion { get; set; }

    /// <summary>
    /// The ARN of the role that will be assumed to access the S3 bucket.
    /// </summary>
    [JsonPropertyName("awsAssumeRoleArn")]
    public string? AwsAssumeRoleArn { get; set; }

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
