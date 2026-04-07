using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SpeechmaticsTranscriberNumeralStyleSerializer))]
public enum SpeechmaticsTranscriberNumeralStyle
{
    [EnumMember(Value = "written")]
    Written,

    [EnumMember(Value = "spoken")]
    Spoken,
}

internal class SpeechmaticsTranscriberNumeralStyleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SpeechmaticsTranscriberNumeralStyle>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SpeechmaticsTranscriberNumeralStyle
    > _stringToEnum = new()
    {
        { "written", SpeechmaticsTranscriberNumeralStyle.Written },
        { "spoken", SpeechmaticsTranscriberNumeralStyle.Spoken },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SpeechmaticsTranscriberNumeralStyle,
        string
    > _enumToString = new()
    {
        { SpeechmaticsTranscriberNumeralStyle.Written, "written" },
        { SpeechmaticsTranscriberNumeralStyle.Spoken, "spoken" },
    };

    public override SpeechmaticsTranscriberNumeralStyle Read(
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
        SpeechmaticsTranscriberNumeralStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SpeechmaticsTranscriberNumeralStyle ReadAsPropertyName(
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
        SpeechmaticsTranscriberNumeralStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
