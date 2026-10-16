using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSesameVoiceDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the audio file of the utterance to clone the voice from.
    /// Consumed by multer via FileInterceptor('file'), so it never reaches
    /// class-validator; declared here (like CreateFileDTO.file) so the OpenAPI
    /// spec is truthful about the multipart request body.
    /// </summary>
    [JsonPropertyName("file")]
    public required string File { get; set; }

    /// <summary>
    /// The name of the voice.
    /// </summary>
    [JsonPropertyName("voiceName")]
    public required string VoiceName { get; set; }

    /// <summary>
    /// The transcript of the utterance.
    /// </summary>
    [JsonPropertyName("transcription")]
    public required string Transcription { get; set; }

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
