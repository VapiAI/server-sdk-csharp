using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SubscriptionStatusSerializer))]
public enum SubscriptionStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "frozen")]
    Frozen,
}

internal class SubscriptionStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SubscriptionStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SubscriptionStatus
    > _stringToEnum = new()
    {
        { "active", SubscriptionStatus.Active },
        { "frozen", SubscriptionStatus.Frozen },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SubscriptionStatus,
        string
    > _enumToString = new()
    {
        { SubscriptionStatus.Active, "active" },
        { SubscriptionStatus.Frozen, "frozen" },
    };

    public override SubscriptionStatus Read(
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
        SubscriptionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SubscriptionStatus ReadAsPropertyName(
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
        SubscriptionStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
