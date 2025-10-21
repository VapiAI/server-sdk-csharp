using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallControllerFindAllPaginatedRequestStructuredOutputsValue
{
    /// <summary>
    /// Equal to
    /// </summary>
    [JsonPropertyName("eq")]
    public string? Eq { get; set; }

    /// <summary>
    /// Not equal to
    /// </summary>
    [JsonPropertyName("neq")]
    public string? Neq { get; set; }

    /// <summary>
    /// Greater than
    /// </summary>
    [JsonPropertyName("gt")]
    public string? Gt { get; set; }

    /// <summary>
    /// Greater than or equal to
    /// </summary>
    [JsonPropertyName("gte")]
    public string? Gte { get; set; }

    /// <summary>
    /// Less than
    /// </summary>
    [JsonPropertyName("lt")]
    public string? Lt { get; set; }

    /// <summary>
    /// Less than or equal to
    /// </summary>
    [JsonPropertyName("lte")]
    public string? Lte { get; set; }

    /// <summary>
    /// Contains
    /// </summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>
    /// Not contains
    /// </summary>
    [JsonPropertyName("notContains")]
    public string? NotContains { get; set; }

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
