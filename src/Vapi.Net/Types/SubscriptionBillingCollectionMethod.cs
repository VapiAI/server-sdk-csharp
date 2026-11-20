using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SubscriptionBillingCollectionMethodSerializer))]
public enum SubscriptionBillingCollectionMethod
{
    [EnumMember(Value = "charge_automatically")]
    ChargeAutomatically,

    [EnumMember(Value = "send_invoice")]
    SendInvoice,
}

internal class SubscriptionBillingCollectionMethodSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SubscriptionBillingCollectionMethod>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SubscriptionBillingCollectionMethod
    > _stringToEnum = new()
    {
        { "charge_automatically", SubscriptionBillingCollectionMethod.ChargeAutomatically },
        { "send_invoice", SubscriptionBillingCollectionMethod.SendInvoice },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SubscriptionBillingCollectionMethod,
        string
    > _enumToString = new()
    {
        { SubscriptionBillingCollectionMethod.ChargeAutomatically, "charge_automatically" },
        { SubscriptionBillingCollectionMethod.SendInvoice, "send_invoice" },
    };

    public override SubscriptionBillingCollectionMethod Read(
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
        SubscriptionBillingCollectionMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SubscriptionBillingCollectionMethod ReadAsPropertyName(
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
        SubscriptionBillingCollectionMethod value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
