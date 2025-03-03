using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AzureSpeechTranscriber
{
    /// <summary>
    /// This is the language that will be set for the transcription. The list of languages Azure supports can be found here: https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=stt
    /// </summary>
    [JsonPropertyName("language")]
    public AzureSpeechTranscriberLanguage? Language { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
