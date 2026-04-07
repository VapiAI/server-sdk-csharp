using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BarInsightFromCallTableGroupBySerializer))]
public enum BarInsightFromCallTableGroupBy
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

internal class BarInsightFromCallTableGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<BarInsightFromCallTableGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BarInsightFromCallTableGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", BarInsightFromCallTableGroupBy.AssistantId },
        { "workflowId", BarInsightFromCallTableGroupBy.WorkflowId },
        { "squadId", BarInsightFromCallTableGroupBy.SquadId },
        { "phoneNumberId", BarInsightFromCallTableGroupBy.PhoneNumberId },
        { "type", BarInsightFromCallTableGroupBy.Type },
        { "endedReason", BarInsightFromCallTableGroupBy.EndedReason },
        { "customerNumber", BarInsightFromCallTableGroupBy.CustomerNumber },
        { "campaignId", BarInsightFromCallTableGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            BarInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        BarInsightFromCallTableGroupBy,
        string
    > _enumToString = new()
    {
        { BarInsightFromCallTableGroupBy.AssistantId, "assistantId" },
        { BarInsightFromCallTableGroupBy.WorkflowId, "workflowId" },
        { BarInsightFromCallTableGroupBy.SquadId, "squadId" },
        { BarInsightFromCallTableGroupBy.PhoneNumberId, "phoneNumberId" },
        { BarInsightFromCallTableGroupBy.Type, "type" },
        { BarInsightFromCallTableGroupBy.EndedReason, "endedReason" },
        { BarInsightFromCallTableGroupBy.CustomerNumber, "customerNumber" },
        { BarInsightFromCallTableGroupBy.CampaignId, "campaignId" },
        {
            BarInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override BarInsightFromCallTableGroupBy Read(
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
        BarInsightFromCallTableGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BarInsightFromCallTableGroupBy ReadAsPropertyName(
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
        BarInsightFromCallTableGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
