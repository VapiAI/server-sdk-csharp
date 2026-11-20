using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A paginated collection of saved eval definitions and metadata describing the result set.
/// </summary>
[Serializable]
public record EvalPaginatedResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The eval definitions returned for the current page.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<Eval> Results { get; set; } = new List<Eval>();

    /// <summary>
    /// Pagination metadata for the eval result set.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required PaginationMeta Metadata { get; set; }

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
