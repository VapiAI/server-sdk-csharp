using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdatePieInsightFromCallTableDtoGroupBySerializer))]
public enum UpdatePieInsightFromCallTableDtoGroupBy
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

internal class UpdatePieInsightFromCallTableDtoGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdatePieInsightFromCallTableDtoGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdatePieInsightFromCallTableDtoGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", UpdatePieInsightFromCallTableDtoGroupBy.AssistantId },
        { "workflowId", UpdatePieInsightFromCallTableDtoGroupBy.WorkflowId },
        { "squadId", UpdatePieInsightFromCallTableDtoGroupBy.SquadId },
        { "phoneNumberId", UpdatePieInsightFromCallTableDtoGroupBy.PhoneNumberId },
        { "type", UpdatePieInsightFromCallTableDtoGroupBy.Type },
        { "endedReason", UpdatePieInsightFromCallTableDtoGroupBy.EndedReason },
        { "customerNumber", UpdatePieInsightFromCallTableDtoGroupBy.CustomerNumber },
        { "campaignId", UpdatePieInsightFromCallTableDtoGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            UpdatePieInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdatePieInsightFromCallTableDtoGroupBy,
        string
    > _enumToString = new()
    {
        { UpdatePieInsightFromCallTableDtoGroupBy.AssistantId, "assistantId" },
        { UpdatePieInsightFromCallTableDtoGroupBy.WorkflowId, "workflowId" },
        { UpdatePieInsightFromCallTableDtoGroupBy.SquadId, "squadId" },
        { UpdatePieInsightFromCallTableDtoGroupBy.PhoneNumberId, "phoneNumberId" },
        { UpdatePieInsightFromCallTableDtoGroupBy.Type, "type" },
        { UpdatePieInsightFromCallTableDtoGroupBy.EndedReason, "endedReason" },
        { UpdatePieInsightFromCallTableDtoGroupBy.CustomerNumber, "customerNumber" },
        { UpdatePieInsightFromCallTableDtoGroupBy.CampaignId, "campaignId" },
        {
            UpdatePieInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override UpdatePieInsightFromCallTableDtoGroupBy Read(
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
        UpdatePieInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdatePieInsightFromCallTableDtoGroupBy ReadAsPropertyName(
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
        UpdatePieInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
