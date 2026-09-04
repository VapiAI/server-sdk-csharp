using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignSummaryServerMessagesItemSerializer))]
public enum CampaignSummaryServerMessagesItem
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

internal class CampaignSummaryServerMessagesItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignSummaryServerMessagesItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignSummaryServerMessagesItem
    > _stringToEnum = new()
    {
        { "campaign.started", CampaignSummaryServerMessagesItem.CampaignStarted },
        { "campaign.cancelled", CampaignSummaryServerMessagesItem.CampaignCancelled },
        { "campaign.ended", CampaignSummaryServerMessagesItem.CampaignEnded },
        { "campaign.archived", CampaignSummaryServerMessagesItem.CampaignArchived },
        { "campaign.unarchived", CampaignSummaryServerMessagesItem.CampaignUnarchived },
        { "contact.dispatched", CampaignSummaryServerMessagesItem.ContactDispatched },
        { "contact.completed", CampaignSummaryServerMessagesItem.ContactCompleted },
        { "contact.failed", CampaignSummaryServerMessagesItem.ContactFailed },
        { "contact.skipped", CampaignSummaryServerMessagesItem.ContactSkipped },
        { "contact.predial-failed", CampaignSummaryServerMessagesItem.ContactPredialFailed },
        { "campaign.job.continued", CampaignSummaryServerMessagesItem.CampaignJobContinued },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignSummaryServerMessagesItem,
        string
    > _enumToString = new()
    {
        { CampaignSummaryServerMessagesItem.CampaignStarted, "campaign.started" },
        { CampaignSummaryServerMessagesItem.CampaignCancelled, "campaign.cancelled" },
        { CampaignSummaryServerMessagesItem.CampaignEnded, "campaign.ended" },
        { CampaignSummaryServerMessagesItem.CampaignArchived, "campaign.archived" },
        { CampaignSummaryServerMessagesItem.CampaignUnarchived, "campaign.unarchived" },
        { CampaignSummaryServerMessagesItem.ContactDispatched, "contact.dispatched" },
        { CampaignSummaryServerMessagesItem.ContactCompleted, "contact.completed" },
        { CampaignSummaryServerMessagesItem.ContactFailed, "contact.failed" },
        { CampaignSummaryServerMessagesItem.ContactSkipped, "contact.skipped" },
        { CampaignSummaryServerMessagesItem.ContactPredialFailed, "contact.predial-failed" },
        { CampaignSummaryServerMessagesItem.CampaignJobContinued, "campaign.job.continued" },
    };

    public override CampaignSummaryServerMessagesItem Read(
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
        CampaignSummaryServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignSummaryServerMessagesItem ReadAsPropertyName(
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
        CampaignSummaryServerMessagesItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
