using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PieInsightFromCallTableGroupBySerializer))]
public enum PieInsightFromCallTableGroupBy
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

internal class PieInsightFromCallTableGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<PieInsightFromCallTableGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PieInsightFromCallTableGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", PieInsightFromCallTableGroupBy.AssistantId },
        { "workflowId", PieInsightFromCallTableGroupBy.WorkflowId },
        { "squadId", PieInsightFromCallTableGroupBy.SquadId },
        { "phoneNumberId", PieInsightFromCallTableGroupBy.PhoneNumberId },
        { "type", PieInsightFromCallTableGroupBy.Type },
        { "endedReason", PieInsightFromCallTableGroupBy.EndedReason },
        { "customerNumber", PieInsightFromCallTableGroupBy.CustomerNumber },
        { "campaignId", PieInsightFromCallTableGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            PieInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PieInsightFromCallTableGroupBy,
        string
    > _enumToString = new()
    {
        { PieInsightFromCallTableGroupBy.AssistantId, "assistantId" },
        { PieInsightFromCallTableGroupBy.WorkflowId, "workflowId" },
        { PieInsightFromCallTableGroupBy.SquadId, "squadId" },
        { PieInsightFromCallTableGroupBy.PhoneNumberId, "phoneNumberId" },
        { PieInsightFromCallTableGroupBy.Type, "type" },
        { PieInsightFromCallTableGroupBy.EndedReason, "endedReason" },
        { PieInsightFromCallTableGroupBy.CustomerNumber, "customerNumber" },
        { PieInsightFromCallTableGroupBy.CampaignId, "campaignId" },
        {
            PieInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override PieInsightFromCallTableGroupBy Read(
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
        PieInsightFromCallTableGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PieInsightFromCallTableGroupBy ReadAsPropertyName(
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
        PieInsightFromCallTableGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
