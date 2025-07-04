using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CloneVoiceDto
{
    /// <summary>
    /// This is the name of the cloned voice in the provider account.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the description of your cloned voice.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Serialized labels dictionary for the voice.
    /// </summary>
    [JsonPropertyName("labels")]
    public string? Labels { get; set; }

    /// <summary>
    /// These are the files you want to use to clone your voice. Only Audio files are supported.
    /// </summary>
    [JsonPropertyName("files")]
    public IEnumerable<string> Files { get; set; } = new List<string>();

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
