using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreatePieInsightFromCallTableDtoGroupBySerializer))]
public enum CreatePieInsightFromCallTableDtoGroupBy
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

internal class CreatePieInsightFromCallTableDtoGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreatePieInsightFromCallTableDtoGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreatePieInsightFromCallTableDtoGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", CreatePieInsightFromCallTableDtoGroupBy.AssistantId },
        { "workflowId", CreatePieInsightFromCallTableDtoGroupBy.WorkflowId },
        { "squadId", CreatePieInsightFromCallTableDtoGroupBy.SquadId },
        { "phoneNumberId", CreatePieInsightFromCallTableDtoGroupBy.PhoneNumberId },
        { "type", CreatePieInsightFromCallTableDtoGroupBy.Type },
        { "endedReason", CreatePieInsightFromCallTableDtoGroupBy.EndedReason },
        { "customerNumber", CreatePieInsightFromCallTableDtoGroupBy.CustomerNumber },
        { "campaignId", CreatePieInsightFromCallTableDtoGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            CreatePieInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreatePieInsightFromCallTableDtoGroupBy,
        string
    > _enumToString = new()
    {
        { CreatePieInsightFromCallTableDtoGroupBy.AssistantId, "assistantId" },
        { CreatePieInsightFromCallTableDtoGroupBy.WorkflowId, "workflowId" },
        { CreatePieInsightFromCallTableDtoGroupBy.SquadId, "squadId" },
        { CreatePieInsightFromCallTableDtoGroupBy.PhoneNumberId, "phoneNumberId" },
        { CreatePieInsightFromCallTableDtoGroupBy.Type, "type" },
        { CreatePieInsightFromCallTableDtoGroupBy.EndedReason, "endedReason" },
        { CreatePieInsightFromCallTableDtoGroupBy.CustomerNumber, "customerNumber" },
        { CreatePieInsightFromCallTableDtoGroupBy.CampaignId, "campaignId" },
        {
            CreatePieInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override CreatePieInsightFromCallTableDtoGroupBy Read(
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
        CreatePieInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreatePieInsightFromCallTableDtoGroupBy ReadAsPropertyName(
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
        CreatePieInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
