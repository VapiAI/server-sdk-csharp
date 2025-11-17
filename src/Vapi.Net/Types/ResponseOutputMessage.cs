using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseOutputMessage
{
    /// <summary>
    /// The unique ID of the output message
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Content of the output message
    /// </summary>
    [JsonPropertyName("content")]
    public IEnumerable<ResponseOutputText> Content { get; set; } = new List<ResponseOutputText>();

    /// <summary>
    /// The role of the output message
    /// </summary>
    [JsonPropertyName("role")]
    public required ResponseOutputMessageRole Role { get; set; }

    /// <summary>
    /// The status of the message
    /// </summary>
    [JsonPropertyName("status")]
    public required ResponseOutputMessageStatus Status { get; set; }

    /// <summary>
    /// The type of the output message
    /// </summary>
    [JsonPropertyName("type")]
    public required ResponseOutputMessageType Type { get; set; }

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
