using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvaluationPlanItemMetricSerializer))]
public enum EvaluationPlanItemMetric
{
    [EnumMember(Value = "wer")]
    Wer,
}

internal class EvaluationPlanItemMetricSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvaluationPlanItemMetric>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvaluationPlanItemMetric
    > _stringToEnum = new() { { "wer", EvaluationPlanItemMetric.Wer } };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvaluationPlanItemMetric,
        string
    > _enumToString = new() { { EvaluationPlanItemMetric.Wer, "wer" } };

    public override EvaluationPlanItemMetric Read(
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
        EvaluationPlanItemMetric value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvaluationPlanItemMetric ReadAsPropertyName(
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
        EvaluationPlanItemMetric value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
