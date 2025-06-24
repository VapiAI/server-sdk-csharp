using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InvoicePlan
{
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
