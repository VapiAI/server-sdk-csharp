using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageVoiceInputTypeSerializer))]
public enum ClientMessageVoiceInputType
{
    [EnumMember(Value = "voice-input")]
    VoiceInput,
}

internal class ClientMessageVoiceInputTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageVoiceInputType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageVoiceInputType
    > _stringToEnum = new() { { "voice-input", ClientMessageVoiceInputType.VoiceInput } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageVoiceInputType,
        string
    > _enumToString = new() { { ClientMessageVoiceInputType.VoiceInput, "voice-input" } };

    public override ClientMessageVoiceInputType Read(
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
        ClientMessageVoiceInputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageVoiceInputType ReadAsPropertyName(
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
        ClientMessageVoiceInputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
