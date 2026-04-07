using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoHighLevelCalendarEventCreateToolWithToolCallTypeSerializer))]
public enum GoHighLevelCalendarEventCreateToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.calendar.event.create")]
    GohighlevelCalendarEventCreate,
}

internal class GoHighLevelCalendarEventCreateToolWithToolCallTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoHighLevelCalendarEventCreateToolWithToolCallType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoHighLevelCalendarEventCreateToolWithToolCallType
    > _stringToEnum = new()
    {
        {
            "gohighlevel.calendar.event.create",
            GoHighLevelCalendarEventCreateToolWithToolCallType.GohighlevelCalendarEventCreate
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoHighLevelCalendarEventCreateToolWithToolCallType,
        string
    > _enumToString = new()
    {
        {
            GoHighLevelCalendarEventCreateToolWithToolCallType.GohighlevelCalendarEventCreate,
            "gohighlevel.calendar.event.create"
        },
    };

    public override GoHighLevelCalendarEventCreateToolWithToolCallType Read(
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
        GoHighLevelCalendarEventCreateToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoHighLevelCalendarEventCreateToolWithToolCallType ReadAsPropertyName(
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
        GoHighLevelCalendarEventCreateToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
