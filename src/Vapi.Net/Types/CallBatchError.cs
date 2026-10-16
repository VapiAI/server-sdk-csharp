using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Error returned for one customer entry in a batch call request.
/// </summary>
[Serializable]
public record CallBatchError : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Customer configuration associated with the failed call.
    /// </summary>
    [JsonPropertyName("customer")]
    public required CreateCustomerDto Customer { get; set; }

    /// <summary>
    /// Error message explaining why the call could not be created.
    /// </summary>
    [JsonPropertyName("error")]
    public required string Error { get; set; }

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
