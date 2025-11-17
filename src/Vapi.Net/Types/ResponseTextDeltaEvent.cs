using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseTextDeltaEvent
{
    /// <summary>
    /// Index of the content part
    /// </summary>
    [JsonPropertyName("content_index")]
    public required double ContentIndex { get; set; }

    /// <summary>
    /// Text delta being added
    /// </summary>
    [JsonPropertyName("delta")]
    public required string Delta { get; set; }

    /// <summary>
    /// ID of the output item
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; set; }

    /// <summary>
    /// Index of the output item
    /// </summary>
    [JsonPropertyName("output_index")]
    public required double OutputIndex { get; set; }

    /// <summary>
    /// Event type
    /// </summary>
    [JsonPropertyName("type")]
    public required ResponseTextDeltaEventType Type { get; set; }

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
