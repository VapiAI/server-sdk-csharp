using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LineInsightFromCallTableGroupBySerializer))]
public enum LineInsightFromCallTableGroupBy
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

internal class LineInsightFromCallTableGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<LineInsightFromCallTableGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LineInsightFromCallTableGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", LineInsightFromCallTableGroupBy.AssistantId },
        { "workflowId", LineInsightFromCallTableGroupBy.WorkflowId },
        { "squadId", LineInsightFromCallTableGroupBy.SquadId },
        { "phoneNumberId", LineInsightFromCallTableGroupBy.PhoneNumberId },
        { "type", LineInsightFromCallTableGroupBy.Type },
        { "endedReason", LineInsightFromCallTableGroupBy.EndedReason },
        { "customerNumber", LineInsightFromCallTableGroupBy.CustomerNumber },
        { "campaignId", LineInsightFromCallTableGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            LineInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LineInsightFromCallTableGroupBy,
        string
    > _enumToString = new()
    {
        { LineInsightFromCallTableGroupBy.AssistantId, "assistantId" },
        { LineInsightFromCallTableGroupBy.WorkflowId, "workflowId" },
        { LineInsightFromCallTableGroupBy.SquadId, "squadId" },
        { LineInsightFromCallTableGroupBy.PhoneNumberId, "phoneNumberId" },
        { LineInsightFromCallTableGroupBy.Type, "type" },
        { LineInsightFromCallTableGroupBy.EndedReason, "endedReason" },
        { LineInsightFromCallTableGroupBy.CustomerNumber, "customerNumber" },
        { LineInsightFromCallTableGroupBy.CampaignId, "campaignId" },
        {
            LineInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override LineInsightFromCallTableGroupBy Read(
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
        LineInsightFromCallTableGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LineInsightFromCallTableGroupBy ReadAsPropertyName(
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
        LineInsightFromCallTableGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
