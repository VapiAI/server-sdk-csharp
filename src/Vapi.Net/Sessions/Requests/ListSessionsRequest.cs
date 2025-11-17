using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ListSessionsRequest
{
    /// <summary>
    /// This is the name of the customer. This is just for your own reference.
    ///
    /// For SIP inbound calls, this is extracted from the `From` SIP header with format `"Display Name" &lt;sip:username@domain&gt;`.
    /// </summary>
    [JsonIgnore]
    public string? Name { get; set; }

    /// <summary>
    /// This is the ID of the assistant to filter sessions by.
    /// </summary>
    [JsonIgnore]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the ID of the squad to filter sessions by.
    /// </summary>
    [JsonIgnore]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the ID of the workflow to filter sessions by.
    /// </summary>
    [JsonIgnore]
    public string? WorkflowId { get; set; }

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
    [JsonIgnore]
    public bool? NumberE164CheckEnabled { get; set; }

    /// <summary>
    /// This is the extension that will be dialed after the call is answered.
    /// </summary>
    [JsonIgnore]
    public string? Extension { get; set; }

    /// <summary>
    /// These are the overrides for the assistant's settings and template variables specific to this customer.
    /// This allows customization of the assistant's behavior for individual customers in batch calls.
    /// </summary>
    [JsonIgnore]
    public string? AssistantOverrides { get; set; }

    /// <summary>
    /// This is the number of the customer.
    /// </summary>
    [JsonIgnore]
    public string? Number { get; set; }

    /// <summary>
    /// This is the SIP URI of the customer.
    /// </summary>
    [JsonIgnore]
    public string? SipUri { get; set; }

    /// <summary>
    /// This is the email of the customer.
    /// </summary>
    [JsonIgnore]
    public string? Email { get; set; }

    /// <summary>
    /// This is the external ID of the customer.
    /// </summary>
    [JsonIgnore]
    public string? ExternalId { get; set; }

    /// <summary>
    /// This is the page number to return. Defaults to 1.
    /// </summary>
    [JsonIgnore]
    public double? Page { get; set; }

    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [JsonIgnore]
    public ListSessionsRequestSortOrder? SortOrder { get; set; }

    /// <summary>
    /// This is the maximum number of items to return. Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public double? Limit { get; set; }

    /// <summary>
    /// This will return items where the createdAt is greater than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtGt { get; set; }

    /// <summary>
    /// This will return items where the createdAt is less than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtLt { get; set; }

    /// <summary>
    /// This will return items where the createdAt is greater than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtGe { get; set; }

    /// <summary>
    /// This will return items where the createdAt is less than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtLe { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is greater than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtGt { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is less than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtLt { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is greater than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtGe { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is less than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtLe { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
