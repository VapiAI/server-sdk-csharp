using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TimeRangeStepSerializer))]
public enum TimeRangeStep
{
    [EnumMember(Value = "second")]
    Second,

    [EnumMember(Value = "minute")]
    Minute,

    [EnumMember(Value = "hour")]
    Hour,

    [EnumMember(Value = "day")]
    Day,

    [EnumMember(Value = "week")]
    Week,

    [EnumMember(Value = "month")]
    Month,

    [EnumMember(Value = "quarter")]
    Quarter,

    [EnumMember(Value = "year")]
    Year,

    [EnumMember(Value = "decade")]
    Decade,

    [EnumMember(Value = "century")]
    Century,

    [EnumMember(Value = "millennium")]
    Millennium,
}

internal class TimeRangeStepSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TimeRangeStep>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TimeRangeStep
    > _stringToEnum = new()
    {
        { "second", TimeRangeStep.Second },
        { "minute", TimeRangeStep.Minute },
        { "hour", TimeRangeStep.Hour },
        { "day", TimeRangeStep.Day },
        { "week", TimeRangeStep.Week },
        { "month", TimeRangeStep.Month },
        { "quarter", TimeRangeStep.Quarter },
        { "year", TimeRangeStep.Year },
        { "decade", TimeRangeStep.Decade },
        { "century", TimeRangeStep.Century },
        { "millennium", TimeRangeStep.Millennium },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TimeRangeStep,
        string
    > _enumToString = new()
    {
        { TimeRangeStep.Second, "second" },
        { TimeRangeStep.Minute, "minute" },
        { TimeRangeStep.Hour, "hour" },
        { TimeRangeStep.Day, "day" },
        { TimeRangeStep.Week, "week" },
        { TimeRangeStep.Month, "month" },
        { TimeRangeStep.Quarter, "quarter" },
        { TimeRangeStep.Year, "year" },
        { TimeRangeStep.Decade, "decade" },
        { TimeRangeStep.Century, "century" },
        { TimeRangeStep.Millennium, "millennium" },
    };

    public override TimeRangeStep Read(
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
        TimeRangeStep value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TimeRangeStep ReadAsPropertyName(
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
        TimeRangeStep value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
