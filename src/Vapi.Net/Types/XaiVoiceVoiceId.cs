using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(XaiVoiceVoiceIdSerializer))]
public enum XaiVoiceVoiceId
{
    [EnumMember(Value = "eve")]
    Eve,

    [EnumMember(Value = "ara")]
    Ara,

    [EnumMember(Value = "rex")]
    Rex,

    [EnumMember(Value = "sal")]
    Sal,

    [EnumMember(Value = "leo")]
    Leo,
}

internal class XaiVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<XaiVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        XaiVoiceVoiceId
    > _stringToEnum = new()
    {
        { "eve", XaiVoiceVoiceId.Eve },
        { "ara", XaiVoiceVoiceId.Ara },
        { "rex", XaiVoiceVoiceId.Rex },
        { "sal", XaiVoiceVoiceId.Sal },
        { "leo", XaiVoiceVoiceId.Leo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        XaiVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { XaiVoiceVoiceId.Eve, "eve" },
        { XaiVoiceVoiceId.Ara, "ara" },
        { XaiVoiceVoiceId.Rex, "rex" },
        { XaiVoiceVoiceId.Sal, "sal" },
        { XaiVoiceVoiceId.Leo, "leo" },
    };

    public override XaiVoiceVoiceId Read(
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
        XaiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override XaiVoiceVoiceId ReadAsPropertyName(
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
        XaiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
