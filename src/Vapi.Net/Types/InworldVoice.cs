using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InworldVoice : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the flag to toggle voice caching for the assistant.
    /// </summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>
    /// Available voices by language:
    /// • en: Alex, Ashley, Craig, Deborah, Dennis, Edward, Elizabeth, Hades, Julia, Pixie, Mark, Olivia, Priya, Ronald, Sarah, Shaun, Theodore, Timothy, Wendy, Dominus, Hana, Clive, Carter, Blake, Luna
    /// • zh: Yichen, Xiaoyin, Xinyi, Jing
    /// • nl: Erik, Katrien, Lennart, Lore
    /// • fr: Alain, Hélène, Mathieu, Étienne
    /// • de: Johanna, Josef
    /// • it: Gianni, Orietta
    /// • ja: Asuka, Satoshi
    /// • ko: Hyunwoo, Minji, Seojun, Yoona
    /// • pl: Szymon, Wojciech
    /// • pt: Heitor, Maitê
    /// • es: Diego, Lupita, Miguel, Rafael
    /// • ru: Svetlana, Elena, Dmitry, Nikolai
    /// • hi: Riya, Manoj
    /// • he: Yael, Oren
    /// • ar: Nour, Omar
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required InworldVoiceVoiceId VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public InworldVoiceModel? Model { get; set; }

    /// <summary>
    /// Language code for Inworld TTS synthesis
    /// </summary>
    [JsonPropertyName("languageCode")]
    public InworldVoiceLanguageCode? LanguageCode { get; set; }

    /// <summary>
    /// A floating point number between 0, exclusive, and 2, inclusive. If equal to null or not provided, the model's default temperature of 1.1 will be used. The temperature parameter controls variance.
    /// Higher values will make the output more random and can lead to more expressive results. Lower values will make it more deterministic.
    /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// A floating point number between 0.5, inclusive, and 1.5, inclusive. If equal to null or not provided, the model's default speaking speed of 1.0 will be used.
    /// Values above 0.8 are recommended for higher quality.
    /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.
    /// </summary>
    [JsonPropertyName("speakingRate")]
    public double? SpeakingRate { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    /// <summary>
    /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackPlan? FallbackPlan { get; set; }

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
