using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackTavusVoiceVoiceIdZeroSerializer))]
public enum FallbackTavusVoiceVoiceIdZero
{
    [EnumMember(Value = "r52da2535a")]
    R52Da2535A,
}

internal class FallbackTavusVoiceVoiceIdZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackTavusVoiceVoiceIdZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackTavusVoiceVoiceIdZero
    > _stringToEnum = new() { { "r52da2535a", FallbackTavusVoiceVoiceIdZero.R52Da2535A } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackTavusVoiceVoiceIdZero,
        string
    > _enumToString = new() { { FallbackTavusVoiceVoiceIdZero.R52Da2535A, "r52da2535a" } };

    public override FallbackTavusVoiceVoiceIdZero Read(
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
        FallbackTavusVoiceVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackTavusVoiceVoiceIdZero ReadAsPropertyName(
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
        FallbackTavusVoiceVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
