using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SpeechmaticsTranscriberRegionSerializer))]
public enum SpeechmaticsTranscriberRegion
{
    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "us")]
    Us,
}

internal class SpeechmaticsTranscriberRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SpeechmaticsTranscriberRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SpeechmaticsTranscriberRegion
    > _stringToEnum = new()
    {
        { "eu", SpeechmaticsTranscriberRegion.Eu },
        { "us", SpeechmaticsTranscriberRegion.Us },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SpeechmaticsTranscriberRegion,
        string
    > _enumToString = new()
    {
        { SpeechmaticsTranscriberRegion.Eu, "eu" },
        { SpeechmaticsTranscriberRegion.Us, "us" },
    };

    public override SpeechmaticsTranscriberRegion Read(
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
        SpeechmaticsTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SpeechmaticsTranscriberRegion ReadAsPropertyName(
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
        SpeechmaticsTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
