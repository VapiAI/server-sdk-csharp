using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AnalyticsOperation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the aggregation operation you want to perform.
    /// </summary>
    [JsonPropertyName("operation")]
    public required AnalyticsOperationOperation Operation { get; set; }

    /// <summary>
    /// This is the columns you want to perform the aggregation operation on.
    /// </summary>
    [JsonPropertyName("column")]
    public required AnalyticsOperationColumn Column { get; set; }

    /// <summary>
    /// This is the alias for column name returned. Defaults to `${operation}${column}`.
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

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
