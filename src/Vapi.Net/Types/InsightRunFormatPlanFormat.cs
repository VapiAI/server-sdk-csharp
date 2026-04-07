using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InsightRunFormatPlanFormatSerializer))]
public enum InsightRunFormatPlanFormat
{
    [EnumMember(Value = "raw")]
    Raw,

    [EnumMember(Value = "recharts")]
    Recharts,
}

internal class InsightRunFormatPlanFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InsightRunFormatPlanFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InsightRunFormatPlanFormat
    > _stringToEnum = new()
    {
        { "raw", InsightRunFormatPlanFormat.Raw },
        { "recharts", InsightRunFormatPlanFormat.Recharts },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InsightRunFormatPlanFormat,
        string
    > _enumToString = new()
    {
        { InsightRunFormatPlanFormat.Raw, "raw" },
        { InsightRunFormatPlanFormat.Recharts, "recharts" },
    };

    public override InsightRunFormatPlanFormat Read(
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
        InsightRunFormatPlanFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InsightRunFormatPlanFormat ReadAsPropertyName(
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
        InsightRunFormatPlanFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
