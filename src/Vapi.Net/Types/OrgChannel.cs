using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OrgChannelSerializer))]
public enum OrgChannel
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

internal class OrgChannelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OrgChannel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OrgChannel
    > _stringToEnum = new()
    {
        { "daily", OrgChannel.Daily },
        { "default", OrgChannel.Default },
        { "weekly", OrgChannel.Weekly },
        { "intuit", OrgChannel.Intuit },
        { "hcs", OrgChannel.Hcs },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OrgChannel,
        string
    > _enumToString = new()
    {
        { OrgChannel.Daily, "daily" },
        { OrgChannel.Default, "default" },
        { OrgChannel.Weekly, "weekly" },
        { OrgChannel.Intuit, "intuit" },
        { OrgChannel.Hcs, "hcs" },
    };

    public override OrgChannel Read(
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
        OrgChannel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OrgChannel ReadAsPropertyName(
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
        OrgChannel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
