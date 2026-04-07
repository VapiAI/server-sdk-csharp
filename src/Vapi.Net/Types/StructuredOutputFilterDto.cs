using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record StructuredOutputFilterDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
