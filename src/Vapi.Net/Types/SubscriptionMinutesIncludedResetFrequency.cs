using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SubscriptionMinutesIncludedResetFrequencySerializer))]
public enum SubscriptionMinutesIncludedResetFrequency
{
    [EnumMember(Value = "monthly")]
    Monthly,

    [EnumMember(Value = "annually")]
    Annually,
}

internal class SubscriptionMinutesIncludedResetFrequencySerializer
    : global::System.Text.Json.Serialization.JsonConverter<SubscriptionMinutesIncludedResetFrequency>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SubscriptionMinutesIncludedResetFrequency
    > _stringToEnum = new()
    {
        { "monthly", SubscriptionMinutesIncludedResetFrequency.Monthly },
        { "annually", SubscriptionMinutesIncludedResetFrequency.Annually },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SubscriptionMinutesIncludedResetFrequency,
        string
    > _enumToString = new()
    {
        { SubscriptionMinutesIncludedResetFrequency.Monthly, "monthly" },
        { SubscriptionMinutesIncludedResetFrequency.Annually, "annually" },
    };

    public override SubscriptionMinutesIncludedResetFrequency Read(
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
        SubscriptionMinutesIncludedResetFrequency value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SubscriptionMinutesIncludedResetFrequency ReadAsPropertyName(
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
        SubscriptionMinutesIncludedResetFrequency value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
