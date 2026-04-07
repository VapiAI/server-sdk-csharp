using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateBarInsightFromCallTableDtoGroupBySerializer))]
public enum CreateBarInsightFromCallTableDtoGroupBy
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

internal class CreateBarInsightFromCallTableDtoGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateBarInsightFromCallTableDtoGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateBarInsightFromCallTableDtoGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", CreateBarInsightFromCallTableDtoGroupBy.AssistantId },
        { "workflowId", CreateBarInsightFromCallTableDtoGroupBy.WorkflowId },
        { "squadId", CreateBarInsightFromCallTableDtoGroupBy.SquadId },
        { "phoneNumberId", CreateBarInsightFromCallTableDtoGroupBy.PhoneNumberId },
        { "type", CreateBarInsightFromCallTableDtoGroupBy.Type },
        { "endedReason", CreateBarInsightFromCallTableDtoGroupBy.EndedReason },
        { "customerNumber", CreateBarInsightFromCallTableDtoGroupBy.CustomerNumber },
        { "campaignId", CreateBarInsightFromCallTableDtoGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            CreateBarInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateBarInsightFromCallTableDtoGroupBy,
        string
    > _enumToString = new()
    {
        { CreateBarInsightFromCallTableDtoGroupBy.AssistantId, "assistantId" },
        { CreateBarInsightFromCallTableDtoGroupBy.WorkflowId, "workflowId" },
        { CreateBarInsightFromCallTableDtoGroupBy.SquadId, "squadId" },
        { CreateBarInsightFromCallTableDtoGroupBy.PhoneNumberId, "phoneNumberId" },
        { CreateBarInsightFromCallTableDtoGroupBy.Type, "type" },
        { CreateBarInsightFromCallTableDtoGroupBy.EndedReason, "endedReason" },
        { CreateBarInsightFromCallTableDtoGroupBy.CustomerNumber, "customerNumber" },
        { CreateBarInsightFromCallTableDtoGroupBy.CampaignId, "campaignId" },
        {
            CreateBarInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override CreateBarInsightFromCallTableDtoGroupBy Read(
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
        CreateBarInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateBarInsightFromCallTableDtoGroupBy ReadAsPropertyName(
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
        CreateBarInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
