using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record PaginationMeta
{
    [JsonPropertyName("itemsPerPage")]
    public required double ItemsPerPage { get; set; }

    [JsonPropertyName("totalItems")]
    public required double TotalItems { get; set; }

    [JsonPropertyName("currentPage")]
    public required double CurrentPage { get; set; }

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
