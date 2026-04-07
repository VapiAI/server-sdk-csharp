using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnalyticsOperationColumnSerializer))]
public enum AnalyticsOperationColumn
{
    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "cost")]
    Cost,

    [EnumMember(Value = "costBreakdown.llm")]
    CostBreakdownLlm,

    [EnumMember(Value = "costBreakdown.stt")]
    CostBreakdownStt,

    [EnumMember(Value = "costBreakdown.tts")]
    CostBreakdownTts,

    [EnumMember(Value = "costBreakdown.vapi")]
    CostBreakdownVapi,

    [EnumMember(Value = "costBreakdown.transport")]
    CostBreakdownTransport,

    [EnumMember(Value = "costBreakdown.analysisBreakdown.summary")]
    CostBreakdownAnalysisBreakdownSummary,

    [EnumMember(Value = "costBreakdown.transcriber")]
    CostBreakdownTranscriber,

    [EnumMember(Value = "costBreakdown.ttsCharacters")]
    CostBreakdownTtsCharacters,

    [EnumMember(Value = "costBreakdown.llmPromptTokens")]
    CostBreakdownLlmPromptTokens,

    [EnumMember(Value = "costBreakdown.llmCompletionTokens")]
    CostBreakdownLlmCompletionTokens,

    [EnumMember(Value = "costBreakdown.llmCachedPromptTokens")]
    CostBreakdownLlmCachedPromptTokens,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "concurrency")]
    Concurrency,

    [EnumMember(Value = "minutesUsed")]
    MinutesUsed,
}

internal class AnalyticsOperationColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnalyticsOperationColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnalyticsOperationColumn
    > _stringToEnum = new()
    {
        { "id", AnalyticsOperationColumn.Id },
        { "cost", AnalyticsOperationColumn.Cost },
        { "costBreakdown.llm", AnalyticsOperationColumn.CostBreakdownLlm },
        { "costBreakdown.stt", AnalyticsOperationColumn.CostBreakdownStt },
        { "costBreakdown.tts", AnalyticsOperationColumn.CostBreakdownTts },
        { "costBreakdown.vapi", AnalyticsOperationColumn.CostBreakdownVapi },
        { "costBreakdown.transport", AnalyticsOperationColumn.CostBreakdownTransport },
        {
            "costBreakdown.analysisBreakdown.summary",
            AnalyticsOperationColumn.CostBreakdownAnalysisBreakdownSummary
        },
        { "costBreakdown.transcriber", AnalyticsOperationColumn.CostBreakdownTranscriber },
        { "costBreakdown.ttsCharacters", AnalyticsOperationColumn.CostBreakdownTtsCharacters },
        { "costBreakdown.llmPromptTokens", AnalyticsOperationColumn.CostBreakdownLlmPromptTokens },
        {
            "costBreakdown.llmCompletionTokens",
            AnalyticsOperationColumn.CostBreakdownLlmCompletionTokens
        },
        {
            "costBreakdown.llmCachedPromptTokens",
            AnalyticsOperationColumn.CostBreakdownLlmCachedPromptTokens
        },
        { "duration", AnalyticsOperationColumn.Duration },
        { "concurrency", AnalyticsOperationColumn.Concurrency },
        { "minutesUsed", AnalyticsOperationColumn.MinutesUsed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnalyticsOperationColumn,
        string
    > _enumToString = new()
    {
        { AnalyticsOperationColumn.Id, "id" },
        { AnalyticsOperationColumn.Cost, "cost" },
        { AnalyticsOperationColumn.CostBreakdownLlm, "costBreakdown.llm" },
        { AnalyticsOperationColumn.CostBreakdownStt, "costBreakdown.stt" },
        { AnalyticsOperationColumn.CostBreakdownTts, "costBreakdown.tts" },
        { AnalyticsOperationColumn.CostBreakdownVapi, "costBreakdown.vapi" },
        { AnalyticsOperationColumn.CostBreakdownTransport, "costBreakdown.transport" },
        {
            AnalyticsOperationColumn.CostBreakdownAnalysisBreakdownSummary,
            "costBreakdown.analysisBreakdown.summary"
        },
        { AnalyticsOperationColumn.CostBreakdownTranscriber, "costBreakdown.transcriber" },
        { AnalyticsOperationColumn.CostBreakdownTtsCharacters, "costBreakdown.ttsCharacters" },
        { AnalyticsOperationColumn.CostBreakdownLlmPromptTokens, "costBreakdown.llmPromptTokens" },
        {
            AnalyticsOperationColumn.CostBreakdownLlmCompletionTokens,
            "costBreakdown.llmCompletionTokens"
        },
        {
            AnalyticsOperationColumn.CostBreakdownLlmCachedPromptTokens,
            "costBreakdown.llmCachedPromptTokens"
        },
        { AnalyticsOperationColumn.Duration, "duration" },
        { AnalyticsOperationColumn.Concurrency, "concurrency" },
        { AnalyticsOperationColumn.MinutesUsed, "minutesUsed" },
    };

    public override AnalyticsOperationColumn Read(
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
        AnalyticsOperationColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnalyticsOperationColumn ReadAsPropertyName(
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
        AnalyticsOperationColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
