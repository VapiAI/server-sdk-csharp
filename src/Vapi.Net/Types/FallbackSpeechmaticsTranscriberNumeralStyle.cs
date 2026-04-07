using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSpeechmaticsTranscriberNumeralStyleSerializer))]
public enum FallbackSpeechmaticsTranscriberNumeralStyle
{
    [EnumMember(Value = "written")]
    Written,

    [EnumMember(Value = "spoken")]
    Spoken,
}

internal class FallbackSpeechmaticsTranscriberNumeralStyleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSpeechmaticsTranscriberNumeralStyle>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSpeechmaticsTranscriberNumeralStyle
    > _stringToEnum = new()
    {
        { "written", FallbackSpeechmaticsTranscriberNumeralStyle.Written },
        { "spoken", FallbackSpeechmaticsTranscriberNumeralStyle.Spoken },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSpeechmaticsTranscriberNumeralStyle,
        string
    > _enumToString = new()
    {
        { FallbackSpeechmaticsTranscriberNumeralStyle.Written, "written" },
        { FallbackSpeechmaticsTranscriberNumeralStyle.Spoken, "spoken" },
    };

    public override FallbackSpeechmaticsTranscriberNumeralStyle Read(
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
        FallbackSpeechmaticsTranscriberNumeralStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSpeechmaticsTranscriberNumeralStyle ReadAsPropertyName(
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
        FallbackSpeechmaticsTranscriberNumeralStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
