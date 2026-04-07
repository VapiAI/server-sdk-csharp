using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageSpeechUpdateTypeSerializer))]
public enum ClientMessageSpeechUpdateType
{
    [EnumMember(Value = "speech-update")]
    SpeechUpdate,
}

internal class ClientMessageSpeechUpdateTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageSpeechUpdateType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageSpeechUpdateType
    > _stringToEnum = new() { { "speech-update", ClientMessageSpeechUpdateType.SpeechUpdate } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageSpeechUpdateType,
        string
    > _enumToString = new() { { ClientMessageSpeechUpdateType.SpeechUpdate, "speech-update" } };

    public override ClientMessageSpeechUpdateType Read(
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
        ClientMessageSpeechUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageSpeechUpdateType ReadAsPropertyName(
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
        ClientMessageSpeechUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
