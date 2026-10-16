using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerFindAllRequestSortBySerializer))]
public enum CampaignControllerFindAllRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class CampaignControllerFindAllRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerFindAllRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerFindAllRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", CampaignControllerFindAllRequestSortBy.CreatedAt },
        { "duration", CampaignControllerFindAllRequestSortBy.Duration },
        { "cost", CampaignControllerFindAllRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerFindAllRequestSortBy,
        string
    > _enumToString = new()
    {
        { CampaignControllerFindAllRequestSortBy.CreatedAt, "createdAt" },
        { CampaignControllerFindAllRequestSortBy.Duration, "duration" },
        { CampaignControllerFindAllRequestSortBy.Cost, "cost" },
    };

    public override CampaignControllerFindAllRequestSortBy Read(
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
        CampaignControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerFindAllRequestSortBy ReadAsPropertyName(
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
        CampaignControllerFindAllRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
