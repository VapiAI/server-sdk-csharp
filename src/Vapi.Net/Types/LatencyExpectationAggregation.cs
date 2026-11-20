using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LatencyExpectationAggregationSerializer))]
public enum LatencyExpectationAggregation
{
    [EnumMember(Value = "mean")]
    Mean,

    [EnumMember(Value = "median")]
    Median,

    [EnumMember(Value = "p95")]
    P95,

    [EnumMember(Value = "max")]
    Max,
}

internal class LatencyExpectationAggregationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LatencyExpectationAggregation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LatencyExpectationAggregation
    > _stringToEnum = new()
    {
        { "mean", LatencyExpectationAggregation.Mean },
        { "median", LatencyExpectationAggregation.Median },
        { "p95", LatencyExpectationAggregation.P95 },
        { "max", LatencyExpectationAggregation.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LatencyExpectationAggregation,
        string
    > _enumToString = new()
    {
        { LatencyExpectationAggregation.Mean, "mean" },
        { LatencyExpectationAggregation.Median, "median" },
        { LatencyExpectationAggregation.P95, "p95" },
        { LatencyExpectationAggregation.Max, "max" },
    };

    public override LatencyExpectationAggregation Read(
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
        LatencyExpectationAggregation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LatencyExpectationAggregation ReadAsPropertyName(
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
        LatencyExpectationAggregation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
