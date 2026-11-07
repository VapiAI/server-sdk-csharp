using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SimulationRunPaymentRequiredResponseReasonSerializer))]
public enum SimulationRunPaymentRequiredResponseReason
{
    [EnumMember(Value = "wallet_missing")]
    WalletMissing,

    [EnumMember(Value = "subscription_frozen")]
    SubscriptionFrozen,

    [EnumMember(Value = "payment_method_missing")]
    PaymentMethodMissing,

    [EnumMember(Value = "insufficient_credits")]
    InsufficientCredits,

    [EnumMember(Value = "billing_limit")]
    BillingLimit,

    [EnumMember(Value = "initial_payment_missing")]
    InitialPaymentMissing,
}

internal class SimulationRunPaymentRequiredResponseReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SimulationRunPaymentRequiredResponseReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SimulationRunPaymentRequiredResponseReason
    > _stringToEnum = new()
    {
        { "wallet_missing", SimulationRunPaymentRequiredResponseReason.WalletMissing },
        { "subscription_frozen", SimulationRunPaymentRequiredResponseReason.SubscriptionFrozen },
        {
            "payment_method_missing",
            SimulationRunPaymentRequiredResponseReason.PaymentMethodMissing
        },
        { "insufficient_credits", SimulationRunPaymentRequiredResponseReason.InsufficientCredits },
        { "billing_limit", SimulationRunPaymentRequiredResponseReason.BillingLimit },
        {
            "initial_payment_missing",
            SimulationRunPaymentRequiredResponseReason.InitialPaymentMissing
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SimulationRunPaymentRequiredResponseReason,
        string
    > _enumToString = new()
    {
        { SimulationRunPaymentRequiredResponseReason.WalletMissing, "wallet_missing" },
        { SimulationRunPaymentRequiredResponseReason.SubscriptionFrozen, "subscription_frozen" },
        {
            SimulationRunPaymentRequiredResponseReason.PaymentMethodMissing,
            "payment_method_missing"
        },
        { SimulationRunPaymentRequiredResponseReason.InsufficientCredits, "insufficient_credits" },
        { SimulationRunPaymentRequiredResponseReason.BillingLimit, "billing_limit" },
        {
            SimulationRunPaymentRequiredResponseReason.InitialPaymentMissing,
            "initial_payment_missing"
        },
    };

    public override SimulationRunPaymentRequiredResponseReason Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        SimulationRunPaymentRequiredResponseReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SimulationRunPaymentRequiredResponseReason ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        SimulationRunPaymentRequiredResponseReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
