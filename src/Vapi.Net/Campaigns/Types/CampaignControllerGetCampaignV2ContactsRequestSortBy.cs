using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerGetCampaignV2ContactsRequestSortBySerializer))]
public enum CampaignControllerGetCampaignV2ContactsRequestSortBy
{
    [EnumMember(Value = "position")]
    Position,

    [EnumMember(Value = "status")]
    Status,
}

internal class CampaignControllerGetCampaignV2ContactsRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerGetCampaignV2ContactsRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerGetCampaignV2ContactsRequestSortBy
    > _stringToEnum = new()
    {
        { "position", CampaignControllerGetCampaignV2ContactsRequestSortBy.Position },
        { "status", CampaignControllerGetCampaignV2ContactsRequestSortBy.Status },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerGetCampaignV2ContactsRequestSortBy,
        string
    > _enumToString = new()
    {
        { CampaignControllerGetCampaignV2ContactsRequestSortBy.Position, "position" },
        { CampaignControllerGetCampaignV2ContactsRequestSortBy.Status, "status" },
    };

    public override CampaignControllerGetCampaignV2ContactsRequestSortBy Read(
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
        CampaignControllerGetCampaignV2ContactsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerGetCampaignV2ContactsRequestSortBy ReadAsPropertyName(
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
        CampaignControllerGetCampaignV2ContactsRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
