using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiSpeaker : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Omit to use model.systemPrompt, or system-role messages when systemPrompt is absent. An explicit empty string is preserved.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? Instructions { get; set; }

    /// <summary>
    /// Personality packs append speaking-style guidance to the speaker prompt. Set to an array of pack IDs and test one pack at a time. These are prompt instructions, not fixed speed controls.
    /// </summary>
    [JsonPropertyName("personalityPacks")]
    public IEnumerable<OpenAiSpeakerPersonalityPacksItem>? PersonalityPacks { get; set; }

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
