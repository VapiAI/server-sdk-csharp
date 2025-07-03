using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InworldVoice
{
    /// <summary>
    /// This is the flag to toggle voice caching for the assistant.
    /// </summary>
    [JsonPropertyName("cachingEnabled")]
    public bool? CachingEnabled { get; set; }

    /// <summary>
    /// Available voices by language:
    /// • en: Alex, Ashley, Craig, Deborah, Dennis, Edward, Elizabeth, Hades, Julia, Pixie, Mark, Olivia, Priya, Ronald, Sarah, Shaun, Theodore, Timothy, Wendy, Dominus
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
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required InworldVoiceVoiceId VoiceId { get; set; }

    /// <summary>
    /// This is the model that will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// Language code for Inworld TTS synthesis
    /// </summary>
    [JsonPropertyName("languageCode")]
    public InworldVoiceLanguageCode? LanguageCode { get; set; }

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
