using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseObject
{
    /// <summary>
    /// Unique identifier for this Response
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The object type
    /// </summary>
    [JsonPropertyName("object")]
    public required ResponseObjectObject Object { get; set; }

    /// <summary>
    /// Unix timestamp (in seconds) of when this Response was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required double CreatedAt { get; set; }

    /// <summary>
    /// Status of the response
    /// </summary>
    [JsonPropertyName("status")]
    public required ResponseObjectStatus Status { get; set; }

    /// <summary>
    /// Error message if the response failed
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// Output messages from the model
    /// </summary>
    [JsonPropertyName("output")]
    public IEnumerable<ResponseOutputMessage> Output { get; set; } =
        new List<ResponseOutputMessage>();

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
