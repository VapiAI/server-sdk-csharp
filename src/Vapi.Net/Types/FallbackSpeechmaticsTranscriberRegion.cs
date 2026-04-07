using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSpeechmaticsTranscriberRegionSerializer))]
public enum FallbackSpeechmaticsTranscriberRegion
{
    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "us")]
    Us,
}

internal class FallbackSpeechmaticsTranscriberRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSpeechmaticsTranscriberRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSpeechmaticsTranscriberRegion
    > _stringToEnum = new()
    {
        { "eu", FallbackSpeechmaticsTranscriberRegion.Eu },
        { "us", FallbackSpeechmaticsTranscriberRegion.Us },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSpeechmaticsTranscriberRegion,
        string
    > _enumToString = new()
    {
        { FallbackSpeechmaticsTranscriberRegion.Eu, "eu" },
        { FallbackSpeechmaticsTranscriberRegion.Us, "us" },
    };

    public override FallbackSpeechmaticsTranscriberRegion Read(
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
        FallbackSpeechmaticsTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSpeechmaticsTranscriberRegion ReadAsPropertyName(
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
        FallbackSpeechmaticsTranscriberRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
