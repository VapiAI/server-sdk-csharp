using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TalkscriberTranscriber
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// This is the language that will be set for the transcription. The list of languages Whisper supports can be found here: https://github.com/openai/whisper/blob/main/whisper/tokenizer.py
    /// </summary>
    [JsonPropertyName("language")]
    public TalkscriberTranscriberLanguage? Language { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
