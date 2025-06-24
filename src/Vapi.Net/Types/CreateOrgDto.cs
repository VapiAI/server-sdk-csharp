using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateOrgDto
{
    /// <summary>
    /// When this is enabled, no logs, recordings, or transcriptions will be stored. At the end of the call, you will still receive an end-of-call-report message to store on your server. Defaults to false.
    /// When HIPAA is enabled, only OpenAI/Custom LLM or Azure Providers will be available for LLM and Voice respectively.
    /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    /// <summary>
    /// This is the ID of the subscription the org belongs to.
    /// </summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>
    /// This is the name of the org. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
    /// </summary>
    [JsonPropertyName("channel")]
    public CreateOrgDtoChannel? Channel { get; set; }

    /// <summary>
    /// This is the monthly billing limit for the org. To go beyond $1000/mo, please contact us at support@vapi.ai.
    /// </summary>
    [JsonPropertyName("billingLimit")]
    public double? BillingLimit { get; set; }

    /// <summary>
    /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.
    ///
    /// The order of precedence is:
    ///
    /// 1. assistant.server
    /// 2. phoneNumber.server
    /// 3. org.server
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    /// <summary>
    /// This is the concurrency limit for the org. This is the maximum number of calls that can be active at any given time. To go beyond 10, please contact us at support@vapi.ai.
    /// </summary>
    [JsonPropertyName("concurrencyLimit")]
    public double? ConcurrencyLimit { get; set; }

    /// <summary>
    /// Stores the information about the compliance plan enforced at the organization level. Currently pciEnabled is supported through this field.
    /// When this is enabled, any logs, recordings, or transcriptions will be shipped to the customer endpoints if provided else lost.
    /// At the end of the call, you will receive an end-of-call-report message to store on your server, if webhook is provided.
    /// Defaults to false.
    /// When PCI is enabled, only PCI-compliant Providers will be available for LLM, Voice and transcribers.
    /// This is due to the compliance requirements of PCI. Other providers may not meet these requirements.
    /// </summary>
    [JsonPropertyName("compliancePlan")]
    public CompliancePlan? CompliancePlan { get; set; }

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
