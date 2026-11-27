using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptReplay : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the HTTPS URL of the recording, fetched when each run starts and
    /// never stored. Use a presigned URL that stays valid until the run executes.
    /// WAV, MP3, FLAC and OGG are supported; MP4 and M4A only when the file was
    /// written for streaming.
    /// </summary>
    [JsonPropertyName("recordingUrl")]
    public required string RecordingUrl { get; set; }

    /// <summary>
    /// This is the answer key, inline. Supply this or `answerKeyUrl`, not both.
    /// Organizations with HIPAA, PCI or zero data retention enabled must use
    /// `answerKeyUrl`, so no answer key is stored.
    /// </summary>
    [JsonPropertyName("answerKey")]
    public TranscriptAnswerKey? AnswerKey { get; set; }

    /// <summary>
    /// This is the HTTPS URL of a JSON answer key with the same shape as
    /// `answerKey`, fetched when each run starts and never stored.
    /// </summary>
    [JsonPropertyName("answerKeyUrl")]
    public string? AnswerKeyUrl { get; set; }

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
