using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterStringArrayTypeColumnOnCallTableColumnSerializer))]
public enum FilterStringArrayTypeColumnOnCallTableColumn
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

internal class FilterStringArrayTypeColumnOnCallTableColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterStringArrayTypeColumnOnCallTableColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterStringArrayTypeColumnOnCallTableColumn
    > _stringToEnum = new()
    {
        { "assistantId", FilterStringArrayTypeColumnOnCallTableColumn.AssistantId },
        { "workflowId", FilterStringArrayTypeColumnOnCallTableColumn.WorkflowId },
        { "squadId", FilterStringArrayTypeColumnOnCallTableColumn.SquadId },
        { "phoneNumberId", FilterStringArrayTypeColumnOnCallTableColumn.PhoneNumberId },
        { "type", FilterStringArrayTypeColumnOnCallTableColumn.Type },
        { "customerNumber", FilterStringArrayTypeColumnOnCallTableColumn.CustomerNumber },
        { "status", FilterStringArrayTypeColumnOnCallTableColumn.Status },
        { "endedReason", FilterStringArrayTypeColumnOnCallTableColumn.EndedReason },
        {
            "forwardedPhoneNumber",
            FilterStringArrayTypeColumnOnCallTableColumn.ForwardedPhoneNumber
        },
        { "campaignId", FilterStringArrayTypeColumnOnCallTableColumn.CampaignId },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterStringArrayTypeColumnOnCallTableColumn,
        string
    > _enumToString = new()
    {
        { FilterStringArrayTypeColumnOnCallTableColumn.AssistantId, "assistantId" },
        { FilterStringArrayTypeColumnOnCallTableColumn.WorkflowId, "workflowId" },
        { FilterStringArrayTypeColumnOnCallTableColumn.SquadId, "squadId" },
        { FilterStringArrayTypeColumnOnCallTableColumn.PhoneNumberId, "phoneNumberId" },
        { FilterStringArrayTypeColumnOnCallTableColumn.Type, "type" },
        { FilterStringArrayTypeColumnOnCallTableColumn.CustomerNumber, "customerNumber" },
        { FilterStringArrayTypeColumnOnCallTableColumn.Status, "status" },
        { FilterStringArrayTypeColumnOnCallTableColumn.EndedReason, "endedReason" },
        {
            FilterStringArrayTypeColumnOnCallTableColumn.ForwardedPhoneNumber,
            "forwardedPhoneNumber"
        },
        { FilterStringArrayTypeColumnOnCallTableColumn.CampaignId, "campaignId" },
    };

    public override FilterStringArrayTypeColumnOnCallTableColumn Read(
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
        FilterStringArrayTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterStringArrayTypeColumnOnCallTableColumn ReadAsPropertyName(
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
        FilterStringArrayTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
