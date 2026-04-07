using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnalyticsQueryGroupByItemSerializer))]
public enum AnalyticsQueryGroupByItem
{
    [EnumMember(Value = "type")]
    Type,

    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "endedReason")]
    EndedReason,

    [EnumMember(Value = "analysis.successEvaluation")]
    AnalysisSuccessEvaluation,

    [EnumMember(Value = "status")]
    Status,
}

internal class AnalyticsQueryGroupByItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnalyticsQueryGroupByItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnalyticsQueryGroupByItem
    > _stringToEnum = new()
    {
        { "type", AnalyticsQueryGroupByItem.Type },
        { "assistantId", AnalyticsQueryGroupByItem.AssistantId },
        { "endedReason", AnalyticsQueryGroupByItem.EndedReason },
        { "analysis.successEvaluation", AnalyticsQueryGroupByItem.AnalysisSuccessEvaluation },
        { "status", AnalyticsQueryGroupByItem.Status },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnalyticsQueryGroupByItem,
        string
    > _enumToString = new()
    {
        { AnalyticsQueryGroupByItem.Type, "type" },
        { AnalyticsQueryGroupByItem.AssistantId, "assistantId" },
        { AnalyticsQueryGroupByItem.EndedReason, "endedReason" },
        { AnalyticsQueryGroupByItem.AnalysisSuccessEvaluation, "analysis.successEvaluation" },
        { AnalyticsQueryGroupByItem.Status, "status" },
    };

    public override AnalyticsQueryGroupByItem Read(
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
        AnalyticsQueryGroupByItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnalyticsQueryGroupByItem ReadAsPropertyName(
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
        AnalyticsQueryGroupByItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
