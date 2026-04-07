using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackSpeechmaticsTranscriberOperatingPointSerializer))]
public enum FallbackSpeechmaticsTranscriberOperatingPoint
{
    [EnumMember(Value = "standard")]
    Standard,

    [EnumMember(Value = "enhanced")]
    Enhanced,
}

internal class FallbackSpeechmaticsTranscriberOperatingPointSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackSpeechmaticsTranscriberOperatingPoint>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackSpeechmaticsTranscriberOperatingPoint
    > _stringToEnum = new()
    {
        { "standard", FallbackSpeechmaticsTranscriberOperatingPoint.Standard },
        { "enhanced", FallbackSpeechmaticsTranscriberOperatingPoint.Enhanced },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackSpeechmaticsTranscriberOperatingPoint,
        string
    > _enumToString = new()
    {
        { FallbackSpeechmaticsTranscriberOperatingPoint.Standard, "standard" },
        { FallbackSpeechmaticsTranscriberOperatingPoint.Enhanced, "enhanced" },
    };

    public override FallbackSpeechmaticsTranscriberOperatingPoint Read(
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
        FallbackSpeechmaticsTranscriberOperatingPoint value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackSpeechmaticsTranscriberOperatingPoint ReadAsPropertyName(
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
        FallbackSpeechmaticsTranscriberOperatingPoint value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
