using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerFindAllV2RequestSortBySerializer))]
public enum CampaignControllerFindAllV2RequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class CampaignControllerFindAllV2RequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerFindAllV2RequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerFindAllV2RequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", CampaignControllerFindAllV2RequestSortBy.CreatedAt },
        { "duration", CampaignControllerFindAllV2RequestSortBy.Duration },
        { "cost", CampaignControllerFindAllV2RequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerFindAllV2RequestSortBy,
        string
    > _enumToString = new()
    {
        { CampaignControllerFindAllV2RequestSortBy.CreatedAt, "createdAt" },
        { CampaignControllerFindAllV2RequestSortBy.Duration, "duration" },
        { CampaignControllerFindAllV2RequestSortBy.Cost, "cost" },
    };

    public override CampaignControllerFindAllV2RequestSortBy Read(
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
        CampaignControllerFindAllV2RequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerFindAllV2RequestSortBy ReadAsPropertyName(
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
        CampaignControllerFindAllV2RequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
