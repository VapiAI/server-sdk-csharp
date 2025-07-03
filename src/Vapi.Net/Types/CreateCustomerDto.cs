using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateCustomerDto
{
    /// <summary>
    /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.
    ///
    /// Use cases:
    /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.
    /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.
    ///
    /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).
    ///
    /// @default true (E164 check is enabled)
    /// </summary>
    [JsonPropertyName("numberE164CheckEnabled")]
    public bool? NumberE164CheckEnabled { get; set; }

    /// <summary>
    /// This is the extension that will be dialed after the call is answered.
    /// </summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>
    /// These are the overrides for the assistant's settings and template variables specific to this customer.
    /// This allows customization of the assistant's behavior for individual customers in batch calls.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// This is the number of the customer.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// This is the SIP URI of the customer.
    /// </summary>
    [JsonPropertyName("sipUri")]
    public string? SipUri { get; set; }

    /// <summary>
    /// This is the name of the customer. This is just for your own reference.
    ///
    /// For SIP inbound calls, this is extracted from the `From` SIP header with format `"Display Name" &lt;sip:username@domain&gt;`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the email of the customer.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// This is the external ID of the customer.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

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
