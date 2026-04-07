using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record DialPlanEntry : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The phone number ID to use for calling the customers in this entry.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public required string PhoneNumberId { get; set; }

    /// <summary>
    /// The list of customers to call using this phone number.
    /// </summary>
    [JsonPropertyName("customers")]
    public IEnumerable<CreateCustomerDto> Customers { get; set; } = new List<CreateCustomerDto>();

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
