using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
