using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the version of the Vapi transcriber. Vapi manages the underlying
    /// model and routing. When omitted, the latest version is used.
    ///
    /// Managed version params are additive-only and `'latest'` is an auto-update
    /// channel — see the param-evolution INVARIANT in `vapiManaged/types.ts`.
    /// </summary>
    [JsonPropertyName("version")]
    public VapiTranscriberVersion? Version { get; set; }

    /// <summary>
    /// This is the language for transcription as an ISO 639-1 code (e.g. `en`).
    /// Selecting a language locks transcription to it. For multiple languages,
    /// use `languages` instead. When neither `language` nor `languages` is set,
    /// the transcriber auto-detects the spoken language.
    /// </summary>
    [JsonPropertyName("language")]
    public VapiTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// These are the languages for transcription as ISO 639-1 codes. Set one or
    /// more codes to restrict and bias recognition to those languages. An empty
    /// array `[]` (or omitting both this and `language`) enables auto-detection
    /// of the spoken language.
    /// </summary>
    [JsonPropertyName("languages")]
    public IEnumerable<VapiTranscriberLanguagesItem>? Languages { get; set; }

    /// <summary>
    /// These are custom keywords/vocabulary to boost recognition of use-case
    /// specific words (company names, product names, jargon).
    /// </summary>
    [JsonPropertyName("keywords")]
    public IEnumerable<string>? Keywords { get; set; }

    /// <summary>
    /// This is the turn-taking mode. `intelligent` uses the underlying model's
    /// native end-of-turn detection; `manual` ignores it and waits a fixed
    /// end-of-turn delay. Defaults to `intelligent`.
    /// </summary>
    [JsonPropertyName("turnTaking")]
    public VapiTranscriberTurnTaking? TurnTaking { get; set; }

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
