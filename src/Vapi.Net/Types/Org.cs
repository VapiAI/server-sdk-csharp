using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Org
{
    /// <summary>
    /// When this is enabled, no logs, recordings, or transcriptions will be stored. At the end of the call, you will still receive an end-of-call-report message to store on your server. Defaults to false.
    /// When HIPAA is enabled, only OpenAI/Custom LLM or Azure Providers will be available for LLM and Voice respectively.
    /// This is due to the compliance requirements of HIPAA. Other providers may not meet these requirements.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    [JsonPropertyName("subscription")]
    public Subscription? Subscription { get; set; }

    /// <summary>
    /// This is the ID of the subscription the org belongs to.
    /// </summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>
    /// This is the unique identifier for the org.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the org was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the org was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the Stripe customer for the org.
    /// </summary>
    [JsonPropertyName("stripeCustomerId")]
    public string? StripeCustomerId { get; set; }

    /// <summary>
    /// This is the subscription for the org.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionId")]
    public string? StripeSubscriptionId { get; set; }

    /// <summary>
    /// This is the subscription's subscription item.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionItemId")]
    public string? StripeSubscriptionItemId { get; set; }

    /// <summary>
    /// This is the subscription's current period start.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionCurrentPeriodStart")]
    public DateTime? StripeSubscriptionCurrentPeriodStart { get; set; }

    /// <summary>
    /// This is the subscription's status.
    /// </summary>
    [JsonPropertyName("stripeSubscriptionStatus")]
    public string? StripeSubscriptionStatus { get; set; }

    /// <summary>
    /// This is the plan for the org.
    /// </summary>
    [JsonPropertyName("plan")]
    public OrgPlan? Plan { get; set; }

    /// <summary>
    /// This is the secret key used for signing JWT tokens for the org.
    /// </summary>
    [JsonPropertyName("jwtSecret")]
    public string? JwtSecret { get; set; }

    /// <summary>
    /// This is the total number of call minutes used by this org across all time.
    /// </summary>
    [JsonPropertyName("minutesUsed")]
    public double? MinutesUsed { get; set; }

    /// <summary>
    /// This is the name of the org. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
    /// </summary>
    [JsonPropertyName("channel")]
    public OrgChannel? Channel { get; set; }

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
