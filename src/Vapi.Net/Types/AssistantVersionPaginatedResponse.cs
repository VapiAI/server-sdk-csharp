using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantVersionPaginatedResponse
{
    [JsonPropertyName("results")]
    public IEnumerable<object> Results { get; set; } = new List<object>();

    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    [JsonPropertyName("nextPageState")]
    public string? NextPageState { get; set; }

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
