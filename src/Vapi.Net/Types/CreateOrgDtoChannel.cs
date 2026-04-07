using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateOrgDtoChannelSerializer))]
public enum CreateOrgDtoChannel
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

internal class CreateOrgDtoChannelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateOrgDtoChannel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateOrgDtoChannel
    > _stringToEnum = new()
    {
        { "daily", CreateOrgDtoChannel.Daily },
        { "default", CreateOrgDtoChannel.Default },
        { "weekly", CreateOrgDtoChannel.Weekly },
        { "intuit", CreateOrgDtoChannel.Intuit },
        { "hcs", CreateOrgDtoChannel.Hcs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateOrgDtoChannel,
        string
    > _enumToString = new()
    {
        { CreateOrgDtoChannel.Daily, "daily" },
        { CreateOrgDtoChannel.Default, "default" },
        { CreateOrgDtoChannel.Weekly, "weekly" },
        { CreateOrgDtoChannel.Intuit, "intuit" },
        { CreateOrgDtoChannel.Hcs, "hcs" },
    };

    public override CreateOrgDtoChannel Read(
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
        CreateOrgDtoChannel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateOrgDtoChannel ReadAsPropertyName(
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
        CreateOrgDtoChannel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
