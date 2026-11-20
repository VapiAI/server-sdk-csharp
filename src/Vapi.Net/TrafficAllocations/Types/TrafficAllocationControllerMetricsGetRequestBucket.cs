using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrafficAllocationControllerMetricsGetRequestBucketSerializer))]
public enum TrafficAllocationControllerMetricsGetRequestBucket
{
    [EnumMember(Value = "hour")]
    Hour,

    [EnumMember(Value = "day")]
    Day,
}

internal class TrafficAllocationControllerMetricsGetRequestBucketSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrafficAllocationControllerMetricsGetRequestBucket>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrafficAllocationControllerMetricsGetRequestBucket
    > _stringToEnum = new()
    {
        { "hour", TrafficAllocationControllerMetricsGetRequestBucket.Hour },
        { "day", TrafficAllocationControllerMetricsGetRequestBucket.Day },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrafficAllocationControllerMetricsGetRequestBucket,
        string
    > _enumToString = new()
    {
        { TrafficAllocationControllerMetricsGetRequestBucket.Hour, "hour" },
        { TrafficAllocationControllerMetricsGetRequestBucket.Day, "day" },
    };

    public override TrafficAllocationControllerMetricsGetRequestBucket Read(
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
        TrafficAllocationControllerMetricsGetRequestBucket value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrafficAllocationControllerMetricsGetRequestBucket ReadAsPropertyName(
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
        TrafficAllocationControllerMetricsGetRequestBucket value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
