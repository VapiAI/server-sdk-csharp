using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignSummaryEndedReasonSerializer))]
public enum CampaignSummaryEndedReason
{
    [EnumMember(Value = "campaign.scheduled.ended-by-user")]
    CampaignScheduledEndedByUser,

    [EnumMember(Value = "campaign.in-progress.ended-by-user")]
    CampaignInProgressEndedByUser,

    [EnumMember(Value = "campaign.ended.success")]
    CampaignEndedSuccess,
}

internal class CampaignSummaryEndedReasonSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignSummaryEndedReason>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignSummaryEndedReason
    > _stringToEnum = new()
    {
        {
            "campaign.scheduled.ended-by-user",
            CampaignSummaryEndedReason.CampaignScheduledEndedByUser
        },
        {
            "campaign.in-progress.ended-by-user",
            CampaignSummaryEndedReason.CampaignInProgressEndedByUser
        },
        { "campaign.ended.success", CampaignSummaryEndedReason.CampaignEndedSuccess },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignSummaryEndedReason,
        string
    > _enumToString = new()
    {
        {
            CampaignSummaryEndedReason.CampaignScheduledEndedByUser,
            "campaign.scheduled.ended-by-user"
        },
        {
            CampaignSummaryEndedReason.CampaignInProgressEndedByUser,
            "campaign.in-progress.ended-by-user"
        },
        { CampaignSummaryEndedReason.CampaignEndedSuccess, "campaign.ended.success" },
    };

    public override CampaignSummaryEndedReason Read(
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
        CampaignSummaryEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignSummaryEndedReason ReadAsPropertyName(
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
        CampaignSummaryEndedReason value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
