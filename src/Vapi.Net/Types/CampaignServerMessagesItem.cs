using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignServerMessagesItemSerializer))]
public enum CampaignServerMessagesItem
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

internal class CampaignServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignServerMessagesItem
    > _stringToEnum = new()
    {
        { "campaign.started", CampaignServerMessagesItem.CampaignStarted },
        { "campaign.cancelled", CampaignServerMessagesItem.CampaignCancelled },
        { "campaign.ended", CampaignServerMessagesItem.CampaignEnded },
        { "campaign.archived", CampaignServerMessagesItem.CampaignArchived },
        { "campaign.unarchived", CampaignServerMessagesItem.CampaignUnarchived },
        { "contact.dispatched", CampaignServerMessagesItem.ContactDispatched },
        { "contact.completed", CampaignServerMessagesItem.ContactCompleted },
        { "contact.failed", CampaignServerMessagesItem.ContactFailed },
        { "contact.skipped", CampaignServerMessagesItem.ContactSkipped },
        { "contact.predial-failed", CampaignServerMessagesItem.ContactPredialFailed },
        { "campaign.job.continued", CampaignServerMessagesItem.CampaignJobContinued },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignServerMessagesItem,
        string
    > _enumToString = new()
    {
        { CampaignServerMessagesItem.CampaignStarted, "campaign.started" },
        { CampaignServerMessagesItem.CampaignCancelled, "campaign.cancelled" },
        { CampaignServerMessagesItem.CampaignEnded, "campaign.ended" },
        { CampaignServerMessagesItem.CampaignArchived, "campaign.archived" },
        { CampaignServerMessagesItem.CampaignUnarchived, "campaign.unarchived" },
        { CampaignServerMessagesItem.ContactDispatched, "contact.dispatched" },
        { CampaignServerMessagesItem.ContactCompleted, "contact.completed" },
        { CampaignServerMessagesItem.ContactFailed, "contact.failed" },
        { CampaignServerMessagesItem.ContactSkipped, "contact.skipped" },
        { CampaignServerMessagesItem.ContactPredialFailed, "contact.predial-failed" },
        { CampaignServerMessagesItem.CampaignJobContinued, "campaign.job.continued" },
    };

    public override CampaignServerMessagesItem Read(
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
        CampaignServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignServerMessagesItem ReadAsPropertyName(
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
        CampaignServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
