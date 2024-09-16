using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record GladiaTranscriber
{
    [JsonPropertyName("model")]
    public GladiaTranscriberModel? Model { get; set; }

    [JsonPropertyName("languageBehaviour")]
    public GladiaTranscriberLanguageBehaviour? LanguageBehaviour { get; set; }

    /// <summary>
    /// Defines the language to use for the transcription. Required when languageBehaviour is 'manual'.
    /// </summary>
    [JsonPropertyName("language")]
    public GladiaTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Provides a custom vocabulary to the model to improve accuracy of transcribing context specific words, technical terms, names, etc. If empty, this argument is ignored.
    /// ⚠️ Warning ⚠️: Please be aware that the transcription_hint field has a character limit of 600. If you provide a transcription_hint longer than 600 characters, it will be automatically truncated to meet this limit.
    /// </summary>
    [JsonPropertyName("transcriptionHint")]
    public string? TranscriptionHint { get; set; }

    /// <summary>
    /// If prosody is true, you will get a transcription that can contain prosodies i.e. (laugh) (giggles) (malefic laugh) (toss) (music)… Default value is false.
    /// </summary>
    [JsonPropertyName("prosody")]
    public bool? Prosody { get; set; }

    /// <summary>
    /// If true, audio will be pre-processed to improve accuracy but latency will increase. Default value is false.
    /// </summary>
    [JsonPropertyName("audioEnhancer")]
    public bool? AudioEnhancer { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
