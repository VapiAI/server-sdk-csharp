using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnalysisCostAnalysisTypeSerializer))]
public enum AnalysisCostAnalysisType
{
    [EnumMember(Value = "summary")]
    Summary,

    [EnumMember(Value = "structuredData")]
    StructuredData,

    [EnumMember(Value = "successEvaluation")]
    SuccessEvaluation,

    [EnumMember(Value = "structuredOutput")]
    StructuredOutput,
}

internal class AnalysisCostAnalysisTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnalysisCostAnalysisType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnalysisCostAnalysisType
    > _stringToEnum = new()
    {
        { "summary", AnalysisCostAnalysisType.Summary },
        { "structuredData", AnalysisCostAnalysisType.StructuredData },
        { "successEvaluation", AnalysisCostAnalysisType.SuccessEvaluation },
        { "structuredOutput", AnalysisCostAnalysisType.StructuredOutput },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnalysisCostAnalysisType,
        string
    > _enumToString = new()
    {
        { AnalysisCostAnalysisType.Summary, "summary" },
        { AnalysisCostAnalysisType.StructuredData, "structuredData" },
        { AnalysisCostAnalysisType.SuccessEvaluation, "successEvaluation" },
        { AnalysisCostAnalysisType.StructuredOutput, "structuredOutput" },
    };

    public override AnalysisCostAnalysisType Read(
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
        AnalysisCostAnalysisType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnalysisCostAnalysisType ReadAsPropertyName(
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
        AnalysisCostAnalysisType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
