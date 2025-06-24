using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ClientMessageTranscript
{
    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
    /// </summary>
    [JsonPropertyName("type")]
    public required ClientMessageTranscriptType Type { get; set; }

    /// <summary>
    /// This is the timestamp of the message.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double? Timestamp { get; set; }

    /// <summary>
    /// This is the call that the message is associated with.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

    /// <summary>
    /// This is the customer that the message is associated with.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the assistant that the message is associated with.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the role for which the transcript is for.
    /// </summary>
    [JsonPropertyName("role")]
    public required ClientMessageTranscriptRole Role { get; set; }

    /// <summary>
    /// This is the type of the transcript.
    /// </summary>
    [JsonPropertyName("transcriptType")]
    public required ClientMessageTranscriptTranscriptType TranscriptType { get; set; }

    /// <summary>
    /// This is the transcript content.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required string Transcript { get; set; }

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
