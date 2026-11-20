using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EndedReasonCondition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the membership operator applied against `values`.
    ///
    /// - 'oneOf': the structured output runs only if the call's ended reason is in `values`.
    /// - 'notOneOf': the structured output runs only if the call's ended reason is NOT in `values`.
    /// </summary>
    [JsonPropertyName("operator")]
    public required EndedReasonConditionOperator Operator { get; set; }

    /// <summary>
    /// These are the ended reasons compared against the call's ended reason.
    ///
    /// Any string is accepted so configurations never break when new ended
    /// reasons are introduced. Must contain at least one value.
    /// </summary>
    [JsonPropertyName("values")]
    public IEnumerable<string> Values { get; set; } = new List<string>();

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
