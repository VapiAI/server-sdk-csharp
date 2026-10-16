using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateCampaignDtoServerMessagesItemSerializer))]
public enum CreateCampaignDtoServerMessagesItem
{
    [EnumMember(Value = "campaign.started")]
    CampaignStarted,

    [EnumMember(Value = "campaign.cancelled")]
    CampaignCancelled,

    [EnumMember(Value = "campaign.ended")]
    CampaignEnded,

    [EnumMember(Value = "campaign.archived")]
    CampaignArchived,

    [EnumMember(Value = "campaign.unarchived")]
    CampaignUnarchived,

    [EnumMember(Value = "contact.dispatched")]
    ContactDispatched,

    [EnumMember(Value = "contact.completed")]
    ContactCompleted,

    [EnumMember(Value = "contact.failed")]
    ContactFailed,

    [EnumMember(Value = "contact.skipped")]
    ContactSkipped,

    [EnumMember(Value = "contact.predial-failed")]
    ContactPredialFailed,

    [EnumMember(Value = "campaign.job.continued")]
    CampaignJobContinued,
}

internal class CreateCampaignDtoServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateCampaignDtoServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateCampaignDtoServerMessagesItem
    > _stringToEnum = new()
    {
        { "campaign.started", CreateCampaignDtoServerMessagesItem.CampaignStarted },
        { "campaign.cancelled", CreateCampaignDtoServerMessagesItem.CampaignCancelled },
        { "campaign.ended", CreateCampaignDtoServerMessagesItem.CampaignEnded },
        { "campaign.archived", CreateCampaignDtoServerMessagesItem.CampaignArchived },
        { "campaign.unarchived", CreateCampaignDtoServerMessagesItem.CampaignUnarchived },
        { "contact.dispatched", CreateCampaignDtoServerMessagesItem.ContactDispatched },
        { "contact.completed", CreateCampaignDtoServerMessagesItem.ContactCompleted },
        { "contact.failed", CreateCampaignDtoServerMessagesItem.ContactFailed },
        { "contact.skipped", CreateCampaignDtoServerMessagesItem.ContactSkipped },
        { "contact.predial-failed", CreateCampaignDtoServerMessagesItem.ContactPredialFailed },
        { "campaign.job.continued", CreateCampaignDtoServerMessagesItem.CampaignJobContinued },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateCampaignDtoServerMessagesItem,
        string
    > _enumToString = new()
    {
        { CreateCampaignDtoServerMessagesItem.CampaignStarted, "campaign.started" },
        { CreateCampaignDtoServerMessagesItem.CampaignCancelled, "campaign.cancelled" },
        { CreateCampaignDtoServerMessagesItem.CampaignEnded, "campaign.ended" },
        { CreateCampaignDtoServerMessagesItem.CampaignArchived, "campaign.archived" },
        { CreateCampaignDtoServerMessagesItem.CampaignUnarchived, "campaign.unarchived" },
        { CreateCampaignDtoServerMessagesItem.ContactDispatched, "contact.dispatched" },
        { CreateCampaignDtoServerMessagesItem.ContactCompleted, "contact.completed" },
        { CreateCampaignDtoServerMessagesItem.ContactFailed, "contact.failed" },
        { CreateCampaignDtoServerMessagesItem.ContactSkipped, "contact.skipped" },
        { CreateCampaignDtoServerMessagesItem.ContactPredialFailed, "contact.predial-failed" },
        { CreateCampaignDtoServerMessagesItem.CampaignJobContinued, "campaign.job.continued" },
    };

    public override CreateCampaignDtoServerMessagesItem Read(
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
        CreateCampaignDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateCampaignDtoServerMessagesItem ReadAsPropertyName(
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
        CreateCampaignDtoServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
