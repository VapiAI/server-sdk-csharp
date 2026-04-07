using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SuccessEvaluationPlanRubricSerializer))]
public enum SuccessEvaluationPlanRubric
{
    [EnumMember(Value = "NumericScale")]
    NumericScale,

    [EnumMember(Value = "DescriptiveScale")]
    DescriptiveScale,

    [EnumMember(Value = "Checklist")]
    Checklist,

    [EnumMember(Value = "Matrix")]
    Matrix,

    [EnumMember(Value = "PercentageScale")]
    PercentageScale,

    [EnumMember(Value = "LikertScale")]
    LikertScale,

    [EnumMember(Value = "AutomaticRubric")]
    AutomaticRubric,

    [EnumMember(Value = "PassFail")]
    PassFail,
}

internal class SuccessEvaluationPlanRubricSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SuccessEvaluationPlanRubric>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SuccessEvaluationPlanRubric
    > _stringToEnum = new()
    {
        { "NumericScale", SuccessEvaluationPlanRubric.NumericScale },
        { "DescriptiveScale", SuccessEvaluationPlanRubric.DescriptiveScale },
        { "Checklist", SuccessEvaluationPlanRubric.Checklist },
        { "Matrix", SuccessEvaluationPlanRubric.Matrix },
        { "PercentageScale", SuccessEvaluationPlanRubric.PercentageScale },
        { "LikertScale", SuccessEvaluationPlanRubric.LikertScale },
        { "AutomaticRubric", SuccessEvaluationPlanRubric.AutomaticRubric },
        { "PassFail", SuccessEvaluationPlanRubric.PassFail },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SuccessEvaluationPlanRubric,
        string
    > _enumToString = new()
    {
        { SuccessEvaluationPlanRubric.NumericScale, "NumericScale" },
        { SuccessEvaluationPlanRubric.DescriptiveScale, "DescriptiveScale" },
        { SuccessEvaluationPlanRubric.Checklist, "Checklist" },
        { SuccessEvaluationPlanRubric.Matrix, "Matrix" },
        { SuccessEvaluationPlanRubric.PercentageScale, "PercentageScale" },
        { SuccessEvaluationPlanRubric.LikertScale, "LikertScale" },
        { SuccessEvaluationPlanRubric.AutomaticRubric, "AutomaticRubric" },
        { SuccessEvaluationPlanRubric.PassFail, "PassFail" },
    };

    public override SuccessEvaluationPlanRubric Read(
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
        SuccessEvaluationPlanRubric value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SuccessEvaluationPlanRubric ReadAsPropertyName(
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
        SuccessEvaluationPlanRubric value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
