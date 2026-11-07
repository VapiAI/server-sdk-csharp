using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Fallback configuration for transcribing speech with OpenAI, including model and language.
/// </summary>
[Serializable]
public record FallbackOpenAiTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the model that will be used for the transcription.
    /// Digit formatting can differ by model: `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
    /// </summary>
    [JsonPropertyName("model")]
    public required FallbackOpenAiTranscriberModel Model { get; set; }

    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackOpenAiTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// These are words and phrases the model should recognize, such as names, brands, and product terms.
    /// Supported only by `gpt-transcribe`. Each keyword is one line and must not contain `&lt;` or `&gt;`. Maximum 16,384 keywords.
    /// </summary>
    [JsonPropertyName("keywords")]
    public IEnumerable<string>? Keywords { get; set; }

    /// <summary>
    /// This is free-text context for the transcription, such as the topic of the call or the expected vocabulary.
    /// Maximum length: 8,192 characters for `gpt-transcribe`, and 1,024 characters for `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`.
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }

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
