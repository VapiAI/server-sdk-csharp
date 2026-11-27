using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TranscriptMetricEvaluationResultComparatorSerializer))]
public enum TranscriptMetricEvaluationResultComparator
{
    [EnumMember(Value = "=")]
    EqualTo,

    [EnumMember(Value = "!=")]
    NotEquals,

    [EnumMember(Value = ">")]
    GreaterThan,

    [EnumMember(Value = "<")]
    LessThan,

    [EnumMember(Value = ">=")]
    GreaterThanOrEqualTo,

    [EnumMember(Value = "<=")]
    LessThanOrEqualTo,
}

internal class TranscriptMetricEvaluationResultComparatorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TranscriptMetricEvaluationResultComparator>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TranscriptMetricEvaluationResultComparator
    > _stringToEnum = new()
    {
        { "=", TranscriptMetricEvaluationResultComparator.EqualTo },
        { "!=", TranscriptMetricEvaluationResultComparator.NotEquals },
        { ">", TranscriptMetricEvaluationResultComparator.GreaterThan },
        { "<", TranscriptMetricEvaluationResultComparator.LessThan },
        { ">=", TranscriptMetricEvaluationResultComparator.GreaterThanOrEqualTo },
        { "<=", TranscriptMetricEvaluationResultComparator.LessThanOrEqualTo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TranscriptMetricEvaluationResultComparator,
        string
    > _enumToString = new()
    {
        { TranscriptMetricEvaluationResultComparator.EqualTo, "=" },
        { TranscriptMetricEvaluationResultComparator.NotEquals, "!=" },
        { TranscriptMetricEvaluationResultComparator.GreaterThan, ">" },
        { TranscriptMetricEvaluationResultComparator.LessThan, "<" },
        { TranscriptMetricEvaluationResultComparator.GreaterThanOrEqualTo, ">=" },
        { TranscriptMetricEvaluationResultComparator.LessThanOrEqualTo, "<=" },
    };

    public override TranscriptMetricEvaluationResultComparator Read(
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
        TranscriptMetricEvaluationResultComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TranscriptMetricEvaluationResultComparator ReadAsPropertyName(
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
        TranscriptMetricEvaluationResultComparator value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
