using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record PhoneNumberPaginatedResponse
{
    /// <summary>
    /// A list of phone numbers, which can be of any provider type.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<object> Results { get; set; } = new List<object>();

    /// <summary>
    /// Metadata about the pagination.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
