using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignStatusSerializer))]
public enum CampaignStatus
{
    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "ended")]
    Ended,
}

internal class CampaignStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignStatus
    > _stringToEnum = new()
    {
        { "scheduled", CampaignStatus.Scheduled },
        { "in-progress", CampaignStatus.InProgress },
        { "ended", CampaignStatus.Ended },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignStatus,
        string
    > _enumToString = new()
    {
        { CampaignStatus.Scheduled, "scheduled" },
        { CampaignStatus.InProgress, "in-progress" },
        { CampaignStatus.Ended, "ended" },
    };

    public override CampaignStatus Read(
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
        CampaignStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignStatus ReadAsPropertyName(
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
        CampaignStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
