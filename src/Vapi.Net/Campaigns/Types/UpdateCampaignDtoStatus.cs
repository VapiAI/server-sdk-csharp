using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateCampaignDtoStatusSerializer))]
public enum UpdateCampaignDtoStatus
{
    [EnumMember(Value = "ended")]
    Ended,
}

internal class UpdateCampaignDtoStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateCampaignDtoStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateCampaignDtoStatus
    > _stringToEnum = new() { { "ended", UpdateCampaignDtoStatus.Ended } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateCampaignDtoStatus,
        string
    > _enumToString = new() { { UpdateCampaignDtoStatus.Ended, "ended" } };

    public override UpdateCampaignDtoStatus Read(
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
        UpdateCampaignDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateCampaignDtoStatus ReadAsPropertyName(
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
        UpdateCampaignDtoStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
