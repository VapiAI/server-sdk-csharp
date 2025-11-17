using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InsightRunFormatPlan
{
    /// <summary>
    /// This is the format of the data to return.
    /// If not provided, defaults to "raw".
    /// Raw provides the data as fetched from the database, with formulas evaluated.
    /// Recharts provides the data in a format that can is ready to be used by recharts.js to render charts.
    /// </summary>
    [JsonPropertyName("format")]
    public InsightRunFormatPlanFormat? Format { get; set; }

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
