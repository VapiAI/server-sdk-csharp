using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PieInsightGroupBySerializer))]
public enum PieInsightGroupBy
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

internal class PieInsightGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<PieInsightGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PieInsightGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", PieInsightGroupBy.AssistantId },
        { "workflowId", PieInsightGroupBy.WorkflowId },
        { "squadId", PieInsightGroupBy.SquadId },
        { "phoneNumberId", PieInsightGroupBy.PhoneNumberId },
        { "type", PieInsightGroupBy.Type },
        { "endedReason", PieInsightGroupBy.EndedReason },
        { "customerNumber", PieInsightGroupBy.CustomerNumber },
        { "campaignId", PieInsightGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            PieInsightGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PieInsightGroupBy,
        string
    > _enumToString = new()
    {
        { PieInsightGroupBy.AssistantId, "assistantId" },
        { PieInsightGroupBy.WorkflowId, "workflowId" },
        { PieInsightGroupBy.SquadId, "squadId" },
        { PieInsightGroupBy.PhoneNumberId, "phoneNumberId" },
        { PieInsightGroupBy.Type, "type" },
        { PieInsightGroupBy.EndedReason, "endedReason" },
        { PieInsightGroupBy.CustomerNumber, "customerNumber" },
        { PieInsightGroupBy.CampaignId, "campaignId" },
        {
            PieInsightGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override PieInsightGroupBy Read(
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
        PieInsightGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PieInsightGroupBy ReadAsPropertyName(
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
        PieInsightGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
