using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LatencyEvaluationResultAggregationSerializer))]
public enum LatencyEvaluationResultAggregation
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

internal class LatencyEvaluationResultAggregationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LatencyEvaluationResultAggregation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LatencyEvaluationResultAggregation
    > _stringToEnum = new()
    {
        { "mean", LatencyEvaluationResultAggregation.Mean },
        { "median", LatencyEvaluationResultAggregation.Median },
        { "p95", LatencyEvaluationResultAggregation.P95 },
        { "max", LatencyEvaluationResultAggregation.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LatencyEvaluationResultAggregation,
        string
    > _enumToString = new()
    {
        { LatencyEvaluationResultAggregation.Mean, "mean" },
        { LatencyEvaluationResultAggregation.Median, "median" },
        { LatencyEvaluationResultAggregation.P95, "p95" },
        { LatencyEvaluationResultAggregation.Max, "max" },
    };

    public override LatencyEvaluationResultAggregation Read(
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
        LatencyEvaluationResultAggregation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LatencyEvaluationResultAggregation ReadAsPropertyName(
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
        LatencyEvaluationResultAggregation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
