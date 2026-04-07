using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SubscriptionTypeSerializer))]
public enum SubscriptionType
{
    [EnumMember(Value = "pay-as-you-go")]
    PayAsYouGo,

    [EnumMember(Value = "enterprise")]
    Enterprise,

    [EnumMember(Value = "agency")]
    Agency,

    [EnumMember(Value = "startup")]
    Startup,

    [EnumMember(Value = "growth")]
    Growth,

    [EnumMember(Value = "scale")]
    Scale,
}

internal class SubscriptionTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SubscriptionType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SubscriptionType
    > _stringToEnum = new()
    {
        { "pay-as-you-go", SubscriptionType.PayAsYouGo },
        { "enterprise", SubscriptionType.Enterprise },
        { "agency", SubscriptionType.Agency },
        { "startup", SubscriptionType.Startup },
        { "growth", SubscriptionType.Growth },
        { "scale", SubscriptionType.Scale },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SubscriptionType,
        string
    > _enumToString = new()
    {
        { SubscriptionType.PayAsYouGo, "pay-as-you-go" },
        { SubscriptionType.Enterprise, "enterprise" },
        { SubscriptionType.Agency, "agency" },
        { SubscriptionType.Startup, "startup" },
        { SubscriptionType.Growth, "growth" },
        { SubscriptionType.Scale, "scale" },
    };

    public override SubscriptionType Read(
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
        SubscriptionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SubscriptionType ReadAsPropertyName(
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
        SubscriptionType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
