using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InsightRunFormatPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the format of the data to return.
    /// If not provided, defaults to "raw".
    /// Raw provides the data as fetched from the database, with formulas evaluated.
    /// Recharts provides the data in a format that can is ready to be used by recharts.js to render charts.
    /// </summary>
    [JsonPropertyName("format")]
    public InsightRunFormatPlanFormat? Format { get; set; }

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
