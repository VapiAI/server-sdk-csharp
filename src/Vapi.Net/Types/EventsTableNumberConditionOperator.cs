using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EventsTableNumberConditionOperatorSerializer))]
public enum EventsTableNumberConditionOperator
{
    [EnumMember(Value = "=")]
    EqualTo,

    [EnumMember(Value = "!=")]
    NotEquals,

    [EnumMember(Value = ">")]
    GreaterThan,

    [EnumMember(Value = ">=")]
    GreaterThanOrEqualTo,

    [EnumMember(Value = "<")]
    LessThan,

    [EnumMember(Value = "<=")]
    LessThanOrEqualTo,
}

internal class EventsTableNumberConditionOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EventsTableNumberConditionOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EventsTableNumberConditionOperator
    > _stringToEnum = new()
    {
        { "=", EventsTableNumberConditionOperator.EqualTo },
        { "!=", EventsTableNumberConditionOperator.NotEquals },
        { ">", EventsTableNumberConditionOperator.GreaterThan },
        { ">=", EventsTableNumberConditionOperator.GreaterThanOrEqualTo },
        { "<", EventsTableNumberConditionOperator.LessThan },
        { "<=", EventsTableNumberConditionOperator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EventsTableNumberConditionOperator,
        string
    > _enumToString = new()
    {
        { EventsTableNumberConditionOperator.EqualTo, "=" },
        { EventsTableNumberConditionOperator.NotEquals, "!=" },
        { EventsTableNumberConditionOperator.GreaterThan, ">" },
        { EventsTableNumberConditionOperator.GreaterThanOrEqualTo, ">=" },
        { EventsTableNumberConditionOperator.LessThan, "<" },
        { EventsTableNumberConditionOperator.LessThanOrEqualTo, "<=" },
    };

    public override EventsTableNumberConditionOperator Read(
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
        EventsTableNumberConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EventsTableNumberConditionOperator ReadAsPropertyName(
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
        EventsTableNumberConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
