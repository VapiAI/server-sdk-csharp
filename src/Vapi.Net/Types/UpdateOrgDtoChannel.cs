using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateOrgDtoChannelSerializer))]
public enum UpdateOrgDtoChannel
{
    [EnumMember(Value = "daily")]
    Daily,

    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "weekly")]
    Weekly,

    [EnumMember(Value = "intuit")]
    Intuit,

    [EnumMember(Value = "hcs")]
    Hcs,
}

internal class UpdateOrgDtoChannelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateOrgDtoChannel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateOrgDtoChannel
    > _stringToEnum = new()
    {
        { "daily", UpdateOrgDtoChannel.Daily },
        { "default", UpdateOrgDtoChannel.Default },
        { "weekly", UpdateOrgDtoChannel.Weekly },
        { "intuit", UpdateOrgDtoChannel.Intuit },
        { "hcs", UpdateOrgDtoChannel.Hcs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateOrgDtoChannel,
        string
    > _enumToString = new()
    {
        { UpdateOrgDtoChannel.Daily, "daily" },
        { UpdateOrgDtoChannel.Default, "default" },
        { UpdateOrgDtoChannel.Weekly, "weekly" },
        { UpdateOrgDtoChannel.Intuit, "intuit" },
        { UpdateOrgDtoChannel.Hcs, "hcs" },
    };

    public override UpdateOrgDtoChannel Read(
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
        UpdateOrgDtoChannel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateOrgDtoChannel ReadAsPropertyName(
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
        UpdateOrgDtoChannel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
