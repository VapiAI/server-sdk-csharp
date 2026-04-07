using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EventsTableBooleanConditionOperatorSerializer))]
public enum EventsTableBooleanConditionOperator
{
    [EnumMember(Value = "=")]
    EqualTo,
}

internal class EventsTableBooleanConditionOperatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EventsTableBooleanConditionOperator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EventsTableBooleanConditionOperator
    > _stringToEnum = new() { { "=", EventsTableBooleanConditionOperator.EqualTo } };

    private static readonly global::System.Collections.Generic.Dictionary<
        EventsTableBooleanConditionOperator,
        string
    > _enumToString = new() { { EventsTableBooleanConditionOperator.EqualTo, "=" } };

    public override EventsTableBooleanConditionOperator Read(
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
        EventsTableBooleanConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EventsTableBooleanConditionOperator ReadAsPropertyName(
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
        EventsTableBooleanConditionOperator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
