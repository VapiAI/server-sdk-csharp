using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoHighLevelCalendarAvailabilityToolWithToolCallTypeSerializer))]
public enum GoHighLevelCalendarAvailabilityToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.calendar.availability.check")]
    GohighlevelCalendarAvailabilityCheck,
}

internal class GoHighLevelCalendarAvailabilityToolWithToolCallTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoHighLevelCalendarAvailabilityToolWithToolCallType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoHighLevelCalendarAvailabilityToolWithToolCallType
    > _stringToEnum = new()
    {
        {
            "gohighlevel.calendar.availability.check",
            GoHighLevelCalendarAvailabilityToolWithToolCallType.GohighlevelCalendarAvailabilityCheck
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoHighLevelCalendarAvailabilityToolWithToolCallType,
        string
    > _enumToString = new()
    {
        {
            GoHighLevelCalendarAvailabilityToolWithToolCallType.GohighlevelCalendarAvailabilityCheck,
            "gohighlevel.calendar.availability.check"
        },
    };

    public override GoHighLevelCalendarAvailabilityToolWithToolCallType Read(
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
        GoHighLevelCalendarAvailabilityToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoHighLevelCalendarAvailabilityToolWithToolCallType ReadAsPropertyName(
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
        GoHighLevelCalendarAvailabilityToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
