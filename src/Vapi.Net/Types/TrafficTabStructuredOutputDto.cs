using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficTabStructuredOutputDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("structuredOutputId")]
    public required string StructuredOutputId { get; set; }

    [JsonPropertyName("type")]
    public required TrafficTabStructuredOutputDtoType Type { get; set; }

    /// <summary>
    /// Calls in the window where this output produced a result.
    /// </summary>
    [JsonPropertyName("present")]
    public required double Present { get; set; }

    [JsonPropertyName("numeric")]
    public TrafficTabStructuredOutputNumericDto? Numeric { get; set; }

    /// <summary>
    /// Top 10 values by count, for string/boolean outputs.
    /// </summary>
    [JsonPropertyName("valueCounts")]
    public IEnumerable<TrafficTabStructuredOutputValueCountDto>? ValueCounts { get; set; }

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
