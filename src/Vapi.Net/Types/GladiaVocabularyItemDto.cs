using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GladiaVocabularyItemDto
{
    /// <summary>
    /// The vocabulary word or phrase
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    /// <summary>
    /// Alternative pronunciations for the vocabulary item
    /// </summary>
    [JsonPropertyName("pronunciations")]
    public IEnumerable<string>? Pronunciations { get; set; }

    /// <summary>
    /// Intensity for this specific vocabulary item (0.0 to 1.0)
    /// </summary>
    [JsonPropertyName("intensity")]
    public double? Intensity { get; set; }

    /// <summary>
    /// Language code for this vocabulary item (ISO 639-1)
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

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
