using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageLanguageChangeDetected
{
    /// <summary>
    /// This is the type of the message. "language-change-detected" is sent when the transcriber is automatically switched based on the detected language.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "language-change-detected";

    /// <summary>
    /// This is the language the transcriber is switched to.
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; }

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
