using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignSummaryStatusSerializer))]
public enum CampaignSummaryStatus
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

internal class CampaignSummaryStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignSummaryStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignSummaryStatus
    > _stringToEnum = new()
    {
        { "scheduled", CampaignSummaryStatus.Scheduled },
        { "in-progress", CampaignSummaryStatus.InProgress },
        { "ended", CampaignSummaryStatus.Ended },
        { "cancelled", CampaignSummaryStatus.Cancelled },
        { "archived", CampaignSummaryStatus.Archived },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignSummaryStatus,
        string
    > _enumToString = new()
    {
        { CampaignSummaryStatus.Scheduled, "scheduled" },
        { CampaignSummaryStatus.InProgress, "in-progress" },
        { CampaignSummaryStatus.Ended, "ended" },
        { CampaignSummaryStatus.Cancelled, "cancelled" },
        { CampaignSummaryStatus.Archived, "archived" },
    };

    public override CampaignSummaryStatus Read(
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
        CampaignSummaryStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignSummaryStatus ReadAsPropertyName(
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
        CampaignSummaryStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
