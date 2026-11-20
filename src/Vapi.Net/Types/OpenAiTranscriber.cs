using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration for transcribing speech during assistant conversations with OpenAI, including model, language, and fallback settings.
/// </summary>
[Serializable]
public record OpenAiTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the model that will be used for the transcription.
    /// Digit formatting can differ by model: `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
    /// </summary>
    [JsonPropertyName("model")]
    public required OpenAiTranscriberModel Model { get; set; }

    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public OpenAiTranscriberLanguage? Language { get; set; }

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

    /// <summary>
    /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackTranscriberPlan? FallbackPlan { get; set; }

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
