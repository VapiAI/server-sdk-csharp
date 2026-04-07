using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackSonioxTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Soniox model to use for transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackSonioxTranscriberModel? Model { get; set; }

    /// <summary>
    /// The language for transcription. Uses ISO 639-1 codes. Soniox supports 60+ languages with a single universal model.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackSonioxTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// When enabled, restricts transcription to the language specified in the language field. When disabled, the model can detect and transcribe any of 60+ supported languages. Defaults to true.
    /// </summary>
    [JsonPropertyName("languageHintsStrict")]
    public bool? LanguageHintsStrict { get; set; }

    /// <summary>
    /// Maximum delay in milliseconds between when the speaker stops and when the endpoint is detected. Lower values mean faster turn-taking but more false endpoints. Range: 500-3000. Default: 500.
    /// </summary>
    [JsonPropertyName("maxEndpointDelayMs")]
    public double? MaxEndpointDelayMs { get; set; }

    /// <summary>
    /// Custom vocabulary terms to boost recognition accuracy. Useful for brand names, product names, and domain-specific terminology. Maps to Soniox context.terms.
    /// </summary>
    [JsonPropertyName("customVocabulary")]
    public IEnumerable<string>? CustomVocabulary { get; set; }

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
