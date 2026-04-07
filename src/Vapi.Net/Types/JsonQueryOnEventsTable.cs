using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record JsonQueryOnEventsTable : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of query. Only allowed type is "vapiql-json".
    /// </summary>
    [JsonPropertyName("type")]
    public required JsonQueryOnEventsTableType Type { get; set; }

    /// <summary>
    /// This is the table that will be queried.
    /// Must be "events" for event-based insights.
    /// </summary>
    [JsonPropertyName("table")]
    public required JsonQueryOnEventsTableTable Table { get; set; }

    /// <summary>
    /// The event type to query
    /// </summary>
    [JsonPropertyName("on")]
    public required JsonQueryOnEventsTableOn On { get; set; }

    /// <summary>
    /// This is the operation to perform on matching events.
    /// - "count": Returns the raw count of matching events
    /// - "percentage": Returns (count of matching events / total calls) * 100
    /// </summary>
    [JsonPropertyName("operation")]
    public required JsonQueryOnEventsTableOperation Operation { get; set; }

    /// <summary>
    /// These are the filters to apply to the events query.
    /// Each filter filters on a field specific to the event type.
    /// </summary>
    [JsonPropertyName("filters")]
    public IEnumerable<
        OneOf<EventsTableStringCondition, EventsTableNumberCondition, EventsTableBooleanCondition>
    >? Filters { get; set; }

    /// <summary>
    /// This is the name of the query.
    /// It will be used to label the query in the insight board on the UI.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
