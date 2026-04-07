using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackInworldVoiceModelSerializer))]
public enum FallbackInworldVoiceModel
{
    [EnumMember(Value = "inworld-tts-1")]
    InworldTts1,
}

internal class FallbackInworldVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackInworldVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackInworldVoiceModel
    > _stringToEnum = new() { { "inworld-tts-1", FallbackInworldVoiceModel.InworldTts1 } };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackInworldVoiceModel,
        string
    > _enumToString = new() { { FallbackInworldVoiceModel.InworldTts1, "inworld-tts-1" } };

    public override FallbackInworldVoiceModel Read(
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
        FallbackInworldVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackInworldVoiceModel ReadAsPropertyName(
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
        FallbackInworldVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
