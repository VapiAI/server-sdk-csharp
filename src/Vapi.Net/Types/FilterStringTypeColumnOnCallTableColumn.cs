using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterStringTypeColumnOnCallTableColumnSerializer))]
public enum FilterStringTypeColumnOnCallTableColumn
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

    [EnumMember(Value = "customerNumber")]
    CustomerNumber,

    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "endedReason")]
    EndedReason,

    [EnumMember(Value = "forwardedPhoneNumber")]
    ForwardedPhoneNumber,

    [EnumMember(Value = "campaignId")]
    CampaignId,
}

internal class FilterStringTypeColumnOnCallTableColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterStringTypeColumnOnCallTableColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterStringTypeColumnOnCallTableColumn
    > _stringToEnum = new()
    {
        { "assistantId", FilterStringTypeColumnOnCallTableColumn.AssistantId },
        { "workflowId", FilterStringTypeColumnOnCallTableColumn.WorkflowId },
        { "squadId", FilterStringTypeColumnOnCallTableColumn.SquadId },
        { "phoneNumberId", FilterStringTypeColumnOnCallTableColumn.PhoneNumberId },
        { "type", FilterStringTypeColumnOnCallTableColumn.Type },
        { "customerNumber", FilterStringTypeColumnOnCallTableColumn.CustomerNumber },
        { "status", FilterStringTypeColumnOnCallTableColumn.Status },
        { "endedReason", FilterStringTypeColumnOnCallTableColumn.EndedReason },
        { "forwardedPhoneNumber", FilterStringTypeColumnOnCallTableColumn.ForwardedPhoneNumber },
        { "campaignId", FilterStringTypeColumnOnCallTableColumn.CampaignId },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterStringTypeColumnOnCallTableColumn,
        string
    > _enumToString = new()
    {
        { FilterStringTypeColumnOnCallTableColumn.AssistantId, "assistantId" },
        { FilterStringTypeColumnOnCallTableColumn.WorkflowId, "workflowId" },
        { FilterStringTypeColumnOnCallTableColumn.SquadId, "squadId" },
        { FilterStringTypeColumnOnCallTableColumn.PhoneNumberId, "phoneNumberId" },
        { FilterStringTypeColumnOnCallTableColumn.Type, "type" },
        { FilterStringTypeColumnOnCallTableColumn.CustomerNumber, "customerNumber" },
        { FilterStringTypeColumnOnCallTableColumn.Status, "status" },
        { FilterStringTypeColumnOnCallTableColumn.EndedReason, "endedReason" },
        { FilterStringTypeColumnOnCallTableColumn.ForwardedPhoneNumber, "forwardedPhoneNumber" },
        { FilterStringTypeColumnOnCallTableColumn.CampaignId, "campaignId" },
    };

    public override FilterStringTypeColumnOnCallTableColumn Read(
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
        FilterStringTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterStringTypeColumnOnCallTableColumn ReadAsPropertyName(
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
        FilterStringTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
