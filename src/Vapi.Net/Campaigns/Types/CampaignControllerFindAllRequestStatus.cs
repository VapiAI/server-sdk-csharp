using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerFindAllRequestStatusSerializer))]
public enum CampaignControllerFindAllRequestStatus
{
    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "ended")]
    Ended,
}

internal class CampaignControllerFindAllRequestStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerFindAllRequestStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerFindAllRequestStatus
    > _stringToEnum = new()
    {
        { "scheduled", CampaignControllerFindAllRequestStatus.Scheduled },
        { "in-progress", CampaignControllerFindAllRequestStatus.InProgress },
        { "ended", CampaignControllerFindAllRequestStatus.Ended },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerFindAllRequestStatus,
        string
    > _enumToString = new()
    {
        { CampaignControllerFindAllRequestStatus.Scheduled, "scheduled" },
        { CampaignControllerFindAllRequestStatus.InProgress, "in-progress" },
        { CampaignControllerFindAllRequestStatus.Ended, "ended" },
    };

    public override CampaignControllerFindAllRequestStatus Read(
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
        CampaignControllerFindAllRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerFindAllRequestStatus ReadAsPropertyName(
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
        CampaignControllerFindAllRequestStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
