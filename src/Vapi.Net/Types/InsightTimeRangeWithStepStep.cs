using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InsightTimeRangeWithStepStepSerializer))]
public enum InsightTimeRangeWithStepStep
{
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
}

internal class InsightTimeRangeWithStepStepSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InsightTimeRangeWithStepStep>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InsightTimeRangeWithStepStep
    > _stringToEnum = new()
    {
        { "minute", InsightTimeRangeWithStepStep.Minute },
        { "hour", InsightTimeRangeWithStepStep.Hour },
        { "day", InsightTimeRangeWithStepStep.Day },
        { "week", InsightTimeRangeWithStepStep.Week },
        { "month", InsightTimeRangeWithStepStep.Month },
        { "quarter", InsightTimeRangeWithStepStep.Quarter },
        { "year", InsightTimeRangeWithStepStep.Year },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InsightTimeRangeWithStepStep,
        string
    > _enumToString = new()
    {
        { InsightTimeRangeWithStepStep.Minute, "minute" },
        { InsightTimeRangeWithStepStep.Hour, "hour" },
        { InsightTimeRangeWithStepStep.Day, "day" },
        { InsightTimeRangeWithStepStep.Week, "week" },
        { InsightTimeRangeWithStepStep.Month, "month" },
        { InsightTimeRangeWithStepStep.Quarter, "quarter" },
        { InsightTimeRangeWithStepStep.Year, "year" },
    };

    public override InsightTimeRangeWithStepStep Read(
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
        InsightTimeRangeWithStepStep value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InsightTimeRangeWithStepStep ReadAsPropertyName(
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
        InsightTimeRangeWithStepStep value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
