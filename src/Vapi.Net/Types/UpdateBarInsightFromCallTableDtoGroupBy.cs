using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateBarInsightFromCallTableDtoGroupBySerializer))]
public enum UpdateBarInsightFromCallTableDtoGroupBy
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

internal class UpdateBarInsightFromCallTableDtoGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateBarInsightFromCallTableDtoGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateBarInsightFromCallTableDtoGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", UpdateBarInsightFromCallTableDtoGroupBy.AssistantId },
        { "workflowId", UpdateBarInsightFromCallTableDtoGroupBy.WorkflowId },
        { "squadId", UpdateBarInsightFromCallTableDtoGroupBy.SquadId },
        { "phoneNumberId", UpdateBarInsightFromCallTableDtoGroupBy.PhoneNumberId },
        { "type", UpdateBarInsightFromCallTableDtoGroupBy.Type },
        { "endedReason", UpdateBarInsightFromCallTableDtoGroupBy.EndedReason },
        { "customerNumber", UpdateBarInsightFromCallTableDtoGroupBy.CustomerNumber },
        { "campaignId", UpdateBarInsightFromCallTableDtoGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            UpdateBarInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateBarInsightFromCallTableDtoGroupBy,
        string
    > _enumToString = new()
    {
        { UpdateBarInsightFromCallTableDtoGroupBy.AssistantId, "assistantId" },
        { UpdateBarInsightFromCallTableDtoGroupBy.WorkflowId, "workflowId" },
        { UpdateBarInsightFromCallTableDtoGroupBy.SquadId, "squadId" },
        { UpdateBarInsightFromCallTableDtoGroupBy.PhoneNumberId, "phoneNumberId" },
        { UpdateBarInsightFromCallTableDtoGroupBy.Type, "type" },
        { UpdateBarInsightFromCallTableDtoGroupBy.EndedReason, "endedReason" },
        { UpdateBarInsightFromCallTableDtoGroupBy.CustomerNumber, "customerNumber" },
        { UpdateBarInsightFromCallTableDtoGroupBy.CampaignId, "campaignId" },
        {
            UpdateBarInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override UpdateBarInsightFromCallTableDtoGroupBy Read(
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
        UpdateBarInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateBarInsightFromCallTableDtoGroupBy ReadAsPropertyName(
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
        UpdateBarInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
