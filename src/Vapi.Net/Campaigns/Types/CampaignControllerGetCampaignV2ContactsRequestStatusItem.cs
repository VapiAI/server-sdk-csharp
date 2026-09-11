using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerGetCampaignV2ContactsRequestStatusItemSerializer))]
public enum CampaignControllerGetCampaignV2ContactsRequestStatusItem
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

internal class CampaignControllerGetCampaignV2ContactsRequestStatusItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerGetCampaignV2ContactsRequestStatusItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerGetCampaignV2ContactsRequestStatusItem
    > _stringToEnum = new()
    {
        {
            "contact.pending",
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactPending
        },
        {
            "contact.dispatched",
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactDispatched
        },
        {
            "contact.completed",
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactCompleted
        },
        {
            "contact.failed",
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactFailed
        },
        {
            "contact.skipped",
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactSkipped
        },
        {
            "contact.predial-failed",
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactPredialFailed
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerGetCampaignV2ContactsRequestStatusItem,
        string
    > _enumToString = new()
    {
        {
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactPending,
            "contact.pending"
        },
        {
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactDispatched,
            "contact.dispatched"
        },
        {
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactCompleted,
            "contact.completed"
        },
        {
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactFailed,
            "contact.failed"
        },
        {
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactSkipped,
            "contact.skipped"
        },
        {
            CampaignControllerGetCampaignV2ContactsRequestStatusItem.ContactPredialFailed,
            "contact.predial-failed"
        },
    };

    public override CampaignControllerGetCampaignV2ContactsRequestStatusItem Read(
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
        CampaignControllerGetCampaignV2ContactsRequestStatusItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerGetCampaignV2ContactsRequestStatusItem ReadAsPropertyName(
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
        CampaignControllerGetCampaignV2ContactsRequestStatusItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
