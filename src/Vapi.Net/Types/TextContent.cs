using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Localized text content used as a language-specific message variant.
/// </summary>
[Serializable]
public record TextContent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Selects text as the content type.
    /// </summary>
    [JsonPropertyName("type")]
    public required TextContentType Type { get; set; }

    /// <summary>
    /// Text spoken or displayed for this content variant.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>
    /// Language code associated with this text variant.
    /// </summary>
    [JsonPropertyName("language")]
    public required TextContentLanguage Language { get; set; }

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
