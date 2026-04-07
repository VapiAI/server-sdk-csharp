using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignEndedReasonSerializer))]
public enum CampaignEndedReason
{
    [EnumMember(Value = "campaign.scheduled.ended-by-user")]
    CampaignScheduledEndedByUser,

    [EnumMember(Value = "campaign.in-progress.ended-by-user")]
    CampaignInProgressEndedByUser,

    [EnumMember(Value = "campaign.ended.success")]
    CampaignEndedSuccess,
}

internal class CampaignEndedReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignEndedReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignEndedReason
    > _stringToEnum = new()
    {
        { "campaign.scheduled.ended-by-user", CampaignEndedReason.CampaignScheduledEndedByUser },
        { "campaign.in-progress.ended-by-user", CampaignEndedReason.CampaignInProgressEndedByUser },
        { "campaign.ended.success", CampaignEndedReason.CampaignEndedSuccess },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignEndedReason,
        string
    > _enumToString = new()
    {
        { CampaignEndedReason.CampaignScheduledEndedByUser, "campaign.scheduled.ended-by-user" },
        { CampaignEndedReason.CampaignInProgressEndedByUser, "campaign.in-progress.ended-by-user" },
        { CampaignEndedReason.CampaignEndedSuccess, "campaign.ended.success" },
    };

    public override CampaignEndedReason Read(
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
        CampaignEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignEndedReason ReadAsPropertyName(
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
        CampaignEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
