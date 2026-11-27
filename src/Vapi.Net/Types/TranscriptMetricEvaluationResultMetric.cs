using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TranscriptMetricEvaluationResultMetricSerializer))]
public enum TranscriptMetricEvaluationResultMetric
{
    [EnumMember(Value = "wer")]
    Wer,
}

internal class TranscriptMetricEvaluationResultMetricSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TranscriptMetricEvaluationResultMetric>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TranscriptMetricEvaluationResultMetric
    > _stringToEnum = new() { { "wer", TranscriptMetricEvaluationResultMetric.Wer } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TranscriptMetricEvaluationResultMetric,
        string
    > _enumToString = new() { { TranscriptMetricEvaluationResultMetric.Wer, "wer" } };

    public override TranscriptMetricEvaluationResultMetric Read(
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
        TranscriptMetricEvaluationResultMetric value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TranscriptMetricEvaluationResultMetric ReadAsPropertyName(
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
        TranscriptMetricEvaluationResultMetric value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
