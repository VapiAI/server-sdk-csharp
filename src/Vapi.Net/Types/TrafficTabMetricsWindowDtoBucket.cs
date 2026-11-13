using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficTabMetricsWindowDtoBucketSerializer))]
public enum TrafficTabMetricsWindowDtoBucket
{
    [EnumMember(Value = "hour")]
    Hour,

    [EnumMember(Value = "day")]
    Day,
}

internal class TrafficTabMetricsWindowDtoBucketSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficTabMetricsWindowDtoBucket>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficTabMetricsWindowDtoBucket
    > _stringToEnum = new()
    {
        { "hour", TrafficTabMetricsWindowDtoBucket.Hour },
        { "day", TrafficTabMetricsWindowDtoBucket.Day },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficTabMetricsWindowDtoBucket,
        string
    > _enumToString = new()
    {
        { TrafficTabMetricsWindowDtoBucket.Hour, "hour" },
        { TrafficTabMetricsWindowDtoBucket.Day, "day" },
    };

    public override TrafficTabMetricsWindowDtoBucket Read(
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
        TrafficTabMetricsWindowDtoBucket value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficTabMetricsWindowDtoBucket ReadAsPropertyName(
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
        TrafficTabMetricsWindowDtoBucket value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
