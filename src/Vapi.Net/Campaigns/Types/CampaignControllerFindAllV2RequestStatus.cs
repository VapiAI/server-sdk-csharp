using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerFindAllV2RequestStatusSerializer))]
public enum CampaignControllerFindAllV2RequestStatus
{
    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "ended")]
    Ended,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "archived")]
    Archived,
}

internal class CampaignControllerFindAllV2RequestStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerFindAllV2RequestStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerFindAllV2RequestStatus
    > _stringToEnum = new()
    {
        { "scheduled", CampaignControllerFindAllV2RequestStatus.Scheduled },
        { "in-progress", CampaignControllerFindAllV2RequestStatus.InProgress },
        { "ended", CampaignControllerFindAllV2RequestStatus.Ended },
        { "cancelled", CampaignControllerFindAllV2RequestStatus.Cancelled },
        { "archived", CampaignControllerFindAllV2RequestStatus.Archived },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerFindAllV2RequestStatus,
        string
    > _enumToString = new()
    {
        { CampaignControllerFindAllV2RequestStatus.Scheduled, "scheduled" },
        { CampaignControllerFindAllV2RequestStatus.InProgress, "in-progress" },
        { CampaignControllerFindAllV2RequestStatus.Ended, "ended" },
        { CampaignControllerFindAllV2RequestStatus.Cancelled, "cancelled" },
        { CampaignControllerFindAllV2RequestStatus.Archived, "archived" },
    };

    public override CampaignControllerFindAllV2RequestStatus Read(
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
        CampaignControllerFindAllV2RequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerFindAllV2RequestStatus ReadAsPropertyName(
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
        CampaignControllerFindAllV2RequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
