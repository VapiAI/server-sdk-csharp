using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BarInsightGroupBySerializer))]
public enum BarInsightGroupBy
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

internal class BarInsightGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<BarInsightGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BarInsightGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", BarInsightGroupBy.AssistantId },
        { "workflowId", BarInsightGroupBy.WorkflowId },
        { "squadId", BarInsightGroupBy.SquadId },
        { "phoneNumberId", BarInsightGroupBy.PhoneNumberId },
        { "type", BarInsightGroupBy.Type },
        { "endedReason", BarInsightGroupBy.EndedReason },
        { "customerNumber", BarInsightGroupBy.CustomerNumber },
        { "campaignId", BarInsightGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            BarInsightGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BarInsightGroupBy,
        string
    > _enumToString = new()
    {
        { BarInsightGroupBy.AssistantId, "assistantId" },
        { BarInsightGroupBy.WorkflowId, "workflowId" },
        { BarInsightGroupBy.SquadId, "squadId" },
        { BarInsightGroupBy.PhoneNumberId, "phoneNumberId" },
        { BarInsightGroupBy.Type, "type" },
        { BarInsightGroupBy.EndedReason, "endedReason" },
        { BarInsightGroupBy.CustomerNumber, "customerNumber" },
        { BarInsightGroupBy.CampaignId, "campaignId" },
        {
            BarInsightGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override BarInsightGroupBy Read(
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
        BarInsightGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BarInsightGroupBy ReadAsPropertyName(
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
        BarInsightGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
