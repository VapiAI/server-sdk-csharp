using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Fallback configuration for transcribing speech with Cartesia, including model and language.
/// </summary>
[Serializable]
public record FallbackCartesiaTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Cartesia speech-to-text model used for transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackCartesiaTranscriberModel? Model { get; set; }

    /// <summary>
    /// The language code used for transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackCartesiaTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Ink 2 speech likelihood above which a turn starts. Higher values require stronger speech evidence. Must exceed turnEagerEndThreshold, which is 0.4 when unset. When unset, the Cartesia server default (currently 0.8) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
    /// </summary>
    [JsonPropertyName("turnStartThreshold")]
    public double? TurnStartThreshold { get; set; }

    /// <summary>
    /// Ink 2 speech likelihood below which an eager end fires. Higher values fire sooner. Must be below turnStartThreshold (0.8 when unset) and above turnEndThreshold (0.2 when unset). Eager ends are emitted as partial transcripts. With startSpeakingPlan.smartEndpointingPlan unset they do not start a model request, so tuning this changes when the event is observed rather than when the assistant replies. A smart endpointing plan receives them with Ink 2's other transcripts and decides reply timing itself. When unset, the Cartesia server default (currently 0.4) applies.
    /// </summary>
    [JsonPropertyName("turnEagerEndThreshold")]
    public double? TurnEagerEndThreshold { get; set; }

    /// <summary>
    /// Ink 2 speech likelihood below which a turn ends. Higher values end the turn sooner. Must be below turnEagerEndThreshold, which is 0.4 when unset; values at or above that therefore require raising turnEagerEndThreshold as well. When unset, the Cartesia server default (currently 0.2) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
    /// </summary>
    [JsonPropertyName("turnEndThreshold")]
    public double? TurnEndThreshold { get; set; }

    /// <summary>
    /// Maximum Ink 2 wait after speech stops, in milliseconds. Lower values force an earlier end. When unset, the Cartesia server default (currently 5600) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
    /// </summary>
    [JsonPropertyName("turnEndTimeoutMs")]
    public int? TurnEndTimeoutMs { get; set; }

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
