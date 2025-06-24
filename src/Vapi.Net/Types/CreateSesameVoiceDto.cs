using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSesameVoiceDto
{
    /// <summary>
    /// The name of the voice.
    /// </summary>
    [JsonPropertyName("voiceName")]
    public string? VoiceName { get; set; }

    /// <summary>
    /// The transcript of the utterance.
    /// </summary>
    [JsonPropertyName("transcription")]
    public string? Transcription { get; set; }

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
