using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TavusVoiceVoiceIdZeroSerializer))]
public enum TavusVoiceVoiceIdZero
{
    [EnumMember(Value = "r52da2535a")]
    R52Da2535A,
}

internal class TavusVoiceVoiceIdZeroSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TavusVoiceVoiceIdZero>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TavusVoiceVoiceIdZero
    > _stringToEnum = new() { { "r52da2535a", TavusVoiceVoiceIdZero.R52Da2535A } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TavusVoiceVoiceIdZero,
        string
    > _enumToString = new() { { TavusVoiceVoiceIdZero.R52Da2535A, "r52da2535a" } };

    public override TavusVoiceVoiceIdZero Read(
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
        TavusVoiceVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TavusVoiceVoiceIdZero ReadAsPropertyName(
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
        TavusVoiceVoiceIdZero value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
