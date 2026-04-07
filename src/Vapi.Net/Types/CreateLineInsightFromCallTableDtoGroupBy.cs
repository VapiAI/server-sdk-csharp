using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateLineInsightFromCallTableDtoGroupBySerializer))]
public enum CreateLineInsightFromCallTableDtoGroupBy
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

internal class CreateLineInsightFromCallTableDtoGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateLineInsightFromCallTableDtoGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateLineInsightFromCallTableDtoGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", CreateLineInsightFromCallTableDtoGroupBy.AssistantId },
        { "workflowId", CreateLineInsightFromCallTableDtoGroupBy.WorkflowId },
        { "squadId", CreateLineInsightFromCallTableDtoGroupBy.SquadId },
        { "phoneNumberId", CreateLineInsightFromCallTableDtoGroupBy.PhoneNumberId },
        { "type", CreateLineInsightFromCallTableDtoGroupBy.Type },
        { "endedReason", CreateLineInsightFromCallTableDtoGroupBy.EndedReason },
        { "customerNumber", CreateLineInsightFromCallTableDtoGroupBy.CustomerNumber },
        { "campaignId", CreateLineInsightFromCallTableDtoGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            CreateLineInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateLineInsightFromCallTableDtoGroupBy,
        string
    > _enumToString = new()
    {
        { CreateLineInsightFromCallTableDtoGroupBy.AssistantId, "assistantId" },
        { CreateLineInsightFromCallTableDtoGroupBy.WorkflowId, "workflowId" },
        { CreateLineInsightFromCallTableDtoGroupBy.SquadId, "squadId" },
        { CreateLineInsightFromCallTableDtoGroupBy.PhoneNumberId, "phoneNumberId" },
        { CreateLineInsightFromCallTableDtoGroupBy.Type, "type" },
        { CreateLineInsightFromCallTableDtoGroupBy.EndedReason, "endedReason" },
        { CreateLineInsightFromCallTableDtoGroupBy.CustomerNumber, "customerNumber" },
        { CreateLineInsightFromCallTableDtoGroupBy.CampaignId, "campaignId" },
        {
            CreateLineInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override CreateLineInsightFromCallTableDtoGroupBy Read(
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
        CreateLineInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateLineInsightFromCallTableDtoGroupBy ReadAsPropertyName(
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
        CreateLineInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
