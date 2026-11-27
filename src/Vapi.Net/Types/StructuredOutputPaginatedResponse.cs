using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A paginated collection of structured-output definitions and metadata describing the result set.
/// </summary>
[Serializable]
public record StructuredOutputPaginatedResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The structured-output definitions returned for the current page.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<StructuredOutput> Results { get; set; } = new List<StructuredOutput>();

    /// <summary>
    /// Pagination metadata for the structured-output result set.
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
