using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Subscription
{
    /// <summary>
    /// This is the unique identifier for the subscription.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the timestamp when the subscription was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the timestamp when the subscription was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the type / tier of the subscription.
    /// </summary>
    [JsonPropertyName("type")]
    public required SubscriptionType Type { get; set; }

    /// <summary>
    /// This is the status of the subscription. Past due subscriptions are subscriptions
    /// with past due payments.
    /// </summary>
    [JsonPropertyName("status")]
    public required SubscriptionStatus Status { get; set; }

    /// <summary>
    /// This is the number of credits the subscription currently has.
    ///
    /// Note: This is a string to avoid floating point precision issues.
    /// </summary>
    [JsonPropertyName("credits")]
    public required string Credits { get; set; }

    /// <summary>
    /// This is the total number of active calls (concurrency) across all orgs under this subscription.
    /// </summary>
    [JsonPropertyName("concurrencyCounter")]
    public required double ConcurrencyCounter { get; set; }

    /// <summary>
    /// This is the default concurrency limit for the subscription.
    /// </summary>
    [JsonPropertyName("concurrencyLimitIncluded")]
    public required double ConcurrencyLimitIncluded { get; set; }

    /// <summary>
    /// This is the number of free phone numbers the subscription has
    /// </summary>
    [JsonPropertyName("phoneNumbersCounter")]
    public double? PhoneNumbersCounter { get; set; }

    /// <summary>
    /// This is the maximum number of free phone numbers the subscription can have
    /// </summary>
    [JsonPropertyName("phoneNumbersIncluded")]
    public double? PhoneNumbersIncluded { get; set; }

    /// <summary>
    /// This is the purchased add-on concurrency limit for the subscription.
    /// </summary>
    [JsonPropertyName("concurrencyLimitPurchased")]
    public required double ConcurrencyLimitPurchased { get; set; }

    /// <summary>
    /// This is the ID of the monthly job that charges for subscription add ons and phone numbers.
    /// </summary>
    [JsonPropertyName("monthlyChargeScheduleId")]
    public double? MonthlyChargeScheduleId { get; set; }

    /// <summary>
    /// This is the ID of the monthly job that checks whether the credit balance of the subscription
    /// is sufficient for the monthly charge.
    /// </summary>
    [JsonPropertyName("monthlyCreditCheckScheduleId")]
    public double? MonthlyCreditCheckScheduleId { get; set; }

    /// <summary>
    /// This is the Stripe customer ID.
    /// </summary>
    [JsonPropertyName("stripeCustomerId")]
    public string? StripeCustomerId { get; set; }

    /// <summary>
    /// This is the Stripe payment ID.
    /// </summary>
    [JsonPropertyName("stripePaymentMethodId")]
    public string? StripePaymentMethodId { get; set; }

    /// <summary>
    /// If this flag is true, then the user has purchased slack support.
    /// </summary>
    [JsonPropertyName("slackSupportEnabled")]
    public bool? SlackSupportEnabled { get; set; }

    /// <summary>
    /// If this subscription has a slack support subscription, the slack channel's ID will be stored here.
    /// </summary>
    [JsonPropertyName("slackChannelId")]
    public string? SlackChannelId { get; set; }

    /// <summary>
    /// This is the HIPAA enabled flag for the subscription. It determines whether orgs under this
    /// subscription have the option to enable HIPAA compliance.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    /// <summary>
    /// This is the ID for the Common Paper agreement outlining the HIPAA contract.
    /// </summary>
    [JsonPropertyName("hipaaCommonPaperAgreementId")]
    public string? HipaaCommonPaperAgreementId { get; set; }

    /// <summary>
    /// This is the Stripe fingerprint of the payment method (card). It allows us
    /// to detect users who try to abuse our system through multiple sign-ups.
    /// </summary>
    [JsonPropertyName("stripePaymentMethodFingerprint")]
    public string? StripePaymentMethodFingerprint { get; set; }

    /// <summary>
    /// This is the customer's email on Stripe.
    /// </summary>
    [JsonPropertyName("stripeCustomerEmail")]
    public string? StripeCustomerEmail { get; set; }

    /// <summary>
    /// This is the email of the referrer for the subscription.
    /// </summary>
    [JsonPropertyName("referredByEmail")]
    public string? ReferredByEmail { get; set; }

    /// <summary>
    /// This is the auto reload plan configured for the subscription.
    /// </summary>
    [JsonPropertyName("autoReloadPlan")]
    public AutoReloadPlan? AutoReloadPlan { get; set; }

    /// <summary>
    /// The number of minutes included in the subscription.
    /// </summary>
    [JsonPropertyName("minutesIncluded")]
    public double? MinutesIncluded { get; set; }

    /// <summary>
    /// The number of minutes used in the subscription.
    /// </summary>
    [JsonPropertyName("minutesUsed")]
    public double? MinutesUsed { get; set; }

    /// <summary>
    /// This is the timestamp at which the number of monthly free minutes is scheduled to reset at.
    /// </summary>
    [JsonPropertyName("minutesUsedNextResetAt")]
    public DateTime? MinutesUsedNextResetAt { get; set; }

    /// <summary>
    /// The per minute charge on minutes that exceed the included minutes. Enterprise only.
    /// </summary>
    [JsonPropertyName("minutesOverageCost")]
    public double? MinutesOverageCost { get; set; }

    /// <summary>
    /// The list of providers included in the subscription. Enterprise only.
    /// </summary>
    [JsonPropertyName("providersIncluded")]
    public IEnumerable<string>? ProvidersIncluded { get; set; }

    /// <summary>
    /// The maximum number of outbound calls this subscription may make in a day. Resets every night.
    /// </summary>
    [JsonPropertyName("outboundCallsDailyLimit")]
    public double? OutboundCallsDailyLimit { get; set; }

    /// <summary>
    /// The current number of outbound calls the subscription has made in the current day.
    /// </summary>
    [JsonPropertyName("outboundCallsCounter")]
    public double? OutboundCallsCounter { get; set; }

    /// <summary>
    /// This is the timestamp at which the outbound calls counter is scheduled to reset at.
    /// </summary>
    [JsonPropertyName("outboundCallsCounterNextResetAt")]
    public DateTime? OutboundCallsCounterNextResetAt { get; set; }

    /// <summary>
    /// This is the IDs of the coupons applicable to this subscription.
    /// </summary>
    [JsonPropertyName("couponIds")]
    public IEnumerable<string>? CouponIds { get; set; }

    /// <summary>
    /// This is the number of credits left obtained from a coupon.
    /// </summary>
    [JsonPropertyName("couponUsageLeft")]
    public string? CouponUsageLeft { get; set; }

    /// <summary>
    /// This is the invoice plan for the subscription.
    /// </summary>
    [JsonPropertyName("invoicePlan")]
    public InvoicePlan? InvoicePlan { get; set; }

    /// <summary>
    /// This is the PCI enabled flag for the subscription. It determines whether orgs under this
    /// subscription have the option to enable PCI compliance.
    /// </summary>
    [JsonPropertyName("pciEnabled")]
    public bool? PciEnabled { get; set; }

    /// <summary>
    /// This is the ID for the Common Paper agreement outlining the PCI contract.
    /// </summary>
    [JsonPropertyName("pciCommonPaperAgreementId")]
    public string? PciCommonPaperAgreementId { get; set; }

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
