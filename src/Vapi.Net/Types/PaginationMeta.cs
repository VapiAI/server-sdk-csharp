using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PaginationMeta
{
    [JsonPropertyName("itemsPerPage")]
    public required double ItemsPerPage { get; set; }

    [JsonPropertyName("totalItems")]
    public required double TotalItems { get; set; }

    [JsonPropertyName("currentPage")]
    public required double CurrentPage { get; set; }

    [JsonPropertyName("itemsBeyondRetention")]
    public bool? ItemsBeyondRetention { get; set; }

    [JsonPropertyName("createdAtLe")]
    public DateTime? CreatedAtLe { get; set; }

    [JsonPropertyName("createdAtGe")]
    public DateTime? CreatedAtGe { get; set; }

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
