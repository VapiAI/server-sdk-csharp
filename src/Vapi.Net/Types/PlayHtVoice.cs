using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record PlayHtVoice
{
    /// <summary>
    /// This determines whether fillers are injected into the model output before inputting it into the voice provider.
    ///
    /// Default `false` because you can achieve better results with prompting the model.
    /// </summary>
    [JsonPropertyName("fillerInjectionEnabled")]
    public bool? FillerInjectionEnabled { get; set; }

    /// <summary>
    /// This is the provider-specific ID that will be used.
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required OneOf<PlayHtVoiceIdEnum, string> VoiceId { get; set; }

    /// <summary>
    /// This is the speed multiplier that will be used.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// A floating point number between 0, exclusive, and 2, inclusive. If equal to null or not provided, the model's default temperature will be used. The temperature parameter controls variance. Lower temperatures result in more predictable results, higher temperatures allow each run to vary more, so the voice may sound less like the baseline voice.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// An emotion to be applied to the speech.
    /// </summary>
    [JsonPropertyName("emotion")]
    public PlayHtVoiceEmotion? Emotion { get; set; }

    /// <summary>
    /// A number between 1 and 6. Use lower numbers to reduce how unique your chosen voice will be compared to other voices.
    /// </summary>
    [JsonPropertyName("voiceGuidance")]
    public double? VoiceGuidance { get; set; }

    /// <summary>
    /// A number between 1 and 30. Use lower numbers to to reduce how strong your chosen emotion will be. Higher numbers will create a very emotional performance.
    /// </summary>
    [JsonPropertyName("styleGuidance")]
    public double? StyleGuidance { get; set; }

    /// <summary>
    /// A number between 1 and 2. This number influences how closely the generated speech adheres to the input text. Use lower values to create more fluid speech, but with a higher chance of deviating from the input text. Higher numbers will make the generated speech more accurate to the input text, ensuring that the words spoken align closely with the provided text.
    /// </summary>
    [JsonPropertyName("textGuidance")]
    public double? TextGuidance { get; set; }

    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
