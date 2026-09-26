using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CampaignControllerFindAllV2RequestSortOrderSerializer))]
public enum CampaignControllerFindAllV2RequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}

internal class CampaignControllerFindAllV2RequestSortOrderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CampaignControllerFindAllV2RequestSortOrder>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CampaignControllerFindAllV2RequestSortOrder
    > _stringToEnum = new()
    {
        { "ASC", CampaignControllerFindAllV2RequestSortOrder.Asc },
        { "DESC", CampaignControllerFindAllV2RequestSortOrder.Desc },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CampaignControllerFindAllV2RequestSortOrder,
        string
    > _enumToString = new()
    {
        { CampaignControllerFindAllV2RequestSortOrder.Asc, "ASC" },
        { CampaignControllerFindAllV2RequestSortOrder.Desc, "DESC" },
    };

    public override CampaignControllerFindAllV2RequestSortOrder Read(
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
        CampaignControllerFindAllV2RequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CampaignControllerFindAllV2RequestSortOrder ReadAsPropertyName(
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
        CampaignControllerFindAllV2RequestSortOrder value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
