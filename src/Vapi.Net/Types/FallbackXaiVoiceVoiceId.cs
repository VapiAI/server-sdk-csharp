using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackXaiVoiceVoiceIdSerializer))]
public enum FallbackXaiVoiceVoiceId
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

internal class FallbackXaiVoiceVoiceIdSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackXaiVoiceVoiceId>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackXaiVoiceVoiceId
    > _stringToEnum = new()
    {
        { "eve", FallbackXaiVoiceVoiceId.Eve },
        { "ara", FallbackXaiVoiceVoiceId.Ara },
        { "rex", FallbackXaiVoiceVoiceId.Rex },
        { "sal", FallbackXaiVoiceVoiceId.Sal },
        { "leo", FallbackXaiVoiceVoiceId.Leo },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackXaiVoiceVoiceId,
        string
    > _enumToString = new()
    {
        { FallbackXaiVoiceVoiceId.Eve, "eve" },
        { FallbackXaiVoiceVoiceId.Ara, "ara" },
        { FallbackXaiVoiceVoiceId.Rex, "rex" },
        { FallbackXaiVoiceVoiceId.Sal, "sal" },
        { FallbackXaiVoiceVoiceId.Leo, "leo" },
    };

    public override FallbackXaiVoiceVoiceId Read(
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
        FallbackXaiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackXaiVoiceVoiceId ReadAsPropertyName(
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
        FallbackXaiVoiceVoiceId value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
