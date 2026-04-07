using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InvoicePlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the name of the company.
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// This is the address of the company.
    /// </summary>
    [JsonPropertyName("companyAddress")]
    public string? CompanyAddress { get; set; }

    /// <summary>
    /// This is the tax ID of the company.
    /// </summary>
    [JsonPropertyName("companyTaxId")]
    public string? CompanyTaxId { get; set; }

    /// <summary>
    /// This is the preferred invoicing email of the company. If not specified, defaults to the subscription's email.
    /// </summary>
    [JsonPropertyName("companyEmail")]
    public string? CompanyEmail { get; set; }

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
