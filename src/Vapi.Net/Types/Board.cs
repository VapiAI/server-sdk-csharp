using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Board : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<OneOf<BoardInsightItem, BoardMetricWidgetItem>>? Items { get; set; }

    /// <summary>
    /// This is the unique identifier for the Board.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this Board belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the Board was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the Board was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Server-owned key for system-provisioned boards. User create/update DTOs do
    /// not accept this field.
    /// </summary>
    [JsonPropertyName("systemKey")]
    public string? SystemKey { get; set; }

    /// <summary>
    /// This is the name of the Board.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the layout of the Board.
    /// </summary>
    [JsonPropertyName("layout")]
    public required BoardLayout Layout { get; set; }

    /// <summary>
    /// This is the timerange override for the board.
    /// By default, individual insights have their own timerange.
    /// This is a global override for the board which will be passed to all insights on the board.
    /// </summary>
    [JsonPropertyName("timeRangeOverride")]
    public InsightTimeRangeWithStep? TimeRangeOverride { get; set; }

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
