using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LineInsightGroupBySerializer))]
public enum LineInsightGroupBy
{
    [EnumMember(Value = "assistantId")]
    AssistantId,

    [EnumMember(Value = "workflowId")]
    WorkflowId,

    [EnumMember(Value = "squadId")]
    SquadId,

    [EnumMember(Value = "phoneNumberId")]
    PhoneNumberId,

    [EnumMember(Value = "type")]
    Type,

    [EnumMember(Value = "endedReason")]
    EndedReason,

    [EnumMember(Value = "customerNumber")]
    CustomerNumber,

    [EnumMember(Value = "campaignId")]
    CampaignId,

    [EnumMember(Value = "artifact.structuredOutputs[OutputID]")]
    ArtifactStructuredOutputsOutputId,
}

internal class LineInsightGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<LineInsightGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LineInsightGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", LineInsightGroupBy.AssistantId },
        { "workflowId", LineInsightGroupBy.WorkflowId },
        { "squadId", LineInsightGroupBy.SquadId },
        { "phoneNumberId", LineInsightGroupBy.PhoneNumberId },
        { "type", LineInsightGroupBy.Type },
        { "endedReason", LineInsightGroupBy.EndedReason },
        { "customerNumber", LineInsightGroupBy.CustomerNumber },
        { "campaignId", LineInsightGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            LineInsightGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LineInsightGroupBy,
        string
    > _enumToString = new()
    {
        { LineInsightGroupBy.AssistantId, "assistantId" },
        { LineInsightGroupBy.WorkflowId, "workflowId" },
        { LineInsightGroupBy.SquadId, "squadId" },
        { LineInsightGroupBy.PhoneNumberId, "phoneNumberId" },
        { LineInsightGroupBy.Type, "type" },
        { LineInsightGroupBy.EndedReason, "endedReason" },
        { LineInsightGroupBy.CustomerNumber, "customerNumber" },
        { LineInsightGroupBy.CampaignId, "campaignId" },
        {
            LineInsightGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override LineInsightGroupBy Read(
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
        LineInsightGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LineInsightGroupBy ReadAsPropertyName(
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
        LineInsightGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
