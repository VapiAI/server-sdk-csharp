using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignContactWithOutcomeStatusSerializer))]
public enum CampaignContactWithOutcomeStatus
{
    [EnumMember(Value = "contact.pending")]
    ContactPending,

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
}

internal class CampaignContactWithOutcomeStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignContactWithOutcomeStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignContactWithOutcomeStatus
    > _stringToEnum = new()
    {
        { "contact.pending", CampaignContactWithOutcomeStatus.ContactPending },
        { "contact.dispatched", CampaignContactWithOutcomeStatus.ContactDispatched },
        { "contact.completed", CampaignContactWithOutcomeStatus.ContactCompleted },
        { "contact.failed", CampaignContactWithOutcomeStatus.ContactFailed },
        { "contact.skipped", CampaignContactWithOutcomeStatus.ContactSkipped },
        { "contact.predial-failed", CampaignContactWithOutcomeStatus.ContactPredialFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignContactWithOutcomeStatus,
        string
    > _enumToString = new()
    {
        { CampaignContactWithOutcomeStatus.ContactPending, "contact.pending" },
        { CampaignContactWithOutcomeStatus.ContactDispatched, "contact.dispatched" },
        { CampaignContactWithOutcomeStatus.ContactCompleted, "contact.completed" },
        { CampaignContactWithOutcomeStatus.ContactFailed, "contact.failed" },
        { CampaignContactWithOutcomeStatus.ContactSkipped, "contact.skipped" },
        { CampaignContactWithOutcomeStatus.ContactPredialFailed, "contact.predial-failed" },
    };

    public override CampaignContactWithOutcomeStatus Read(
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
        CampaignContactWithOutcomeStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignContactWithOutcomeStatus ReadAsPropertyName(
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
        CampaignContactWithOutcomeStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
