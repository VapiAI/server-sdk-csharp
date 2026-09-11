using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageCampaignPredialTypeSerializer))]
public enum ServerMessageCampaignPredialType
{
    [EnumMember(Value = "campaign.predial")]
    CampaignPredial,
}

internal class ServerMessageCampaignPredialTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageCampaignPredialType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageCampaignPredialType
    > _stringToEnum = new()
    {
        { "campaign.predial", ServerMessageCampaignPredialType.CampaignPredial },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageCampaignPredialType,
        string
    > _enumToString = new()
    {
        { ServerMessageCampaignPredialType.CampaignPredial, "campaign.predial" },
    };

    public override ServerMessageCampaignPredialType Read(
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
        ServerMessageCampaignPredialType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageCampaignPredialType ReadAsPropertyName(
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
        ServerMessageCampaignPredialType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
