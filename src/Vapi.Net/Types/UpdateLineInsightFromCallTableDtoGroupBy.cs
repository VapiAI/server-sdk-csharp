using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateLineInsightFromCallTableDtoGroupBySerializer))]
public enum UpdateLineInsightFromCallTableDtoGroupBy
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

internal class UpdateLineInsightFromCallTableDtoGroupBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateLineInsightFromCallTableDtoGroupBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateLineInsightFromCallTableDtoGroupBy
    > _stringToEnum = new()
    {
        { "assistantId", UpdateLineInsightFromCallTableDtoGroupBy.AssistantId },
        { "workflowId", UpdateLineInsightFromCallTableDtoGroupBy.WorkflowId },
        { "squadId", UpdateLineInsightFromCallTableDtoGroupBy.SquadId },
        { "phoneNumberId", UpdateLineInsightFromCallTableDtoGroupBy.PhoneNumberId },
        { "type", UpdateLineInsightFromCallTableDtoGroupBy.Type },
        { "endedReason", UpdateLineInsightFromCallTableDtoGroupBy.EndedReason },
        { "customerNumber", UpdateLineInsightFromCallTableDtoGroupBy.CustomerNumber },
        { "campaignId", UpdateLineInsightFromCallTableDtoGroupBy.CampaignId },
        {
            "artifact.structuredOutputs[OutputID]",
            UpdateLineInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateLineInsightFromCallTableDtoGroupBy,
        string
    > _enumToString = new()
    {
        { UpdateLineInsightFromCallTableDtoGroupBy.AssistantId, "assistantId" },
        { UpdateLineInsightFromCallTableDtoGroupBy.WorkflowId, "workflowId" },
        { UpdateLineInsightFromCallTableDtoGroupBy.SquadId, "squadId" },
        { UpdateLineInsightFromCallTableDtoGroupBy.PhoneNumberId, "phoneNumberId" },
        { UpdateLineInsightFromCallTableDtoGroupBy.Type, "type" },
        { UpdateLineInsightFromCallTableDtoGroupBy.EndedReason, "endedReason" },
        { UpdateLineInsightFromCallTableDtoGroupBy.CustomerNumber, "customerNumber" },
        { UpdateLineInsightFromCallTableDtoGroupBy.CampaignId, "campaignId" },
        {
            UpdateLineInsightFromCallTableDtoGroupBy.ArtifactStructuredOutputsOutputId,
            "artifact.structuredOutputs[OutputID]"
        },
    };

    public override UpdateLineInsightFromCallTableDtoGroupBy Read(
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
        UpdateLineInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateLineInsightFromCallTableDtoGroupBy ReadAsPropertyName(
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
        UpdateLineInsightFromCallTableDtoGroupBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
