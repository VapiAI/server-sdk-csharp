using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageSpeechUpdateStatusSerializer))]
public enum ClientMessageSpeechUpdateStatus
{
    [EnumMember(Value = "started")]
    Started,

    [EnumMember(Value = "stopped")]
    Stopped,
}

internal class ClientMessageSpeechUpdateStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageSpeechUpdateStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageSpeechUpdateStatus
    > _stringToEnum = new()
    {
        { "started", ClientMessageSpeechUpdateStatus.Started },
        { "stopped", ClientMessageSpeechUpdateStatus.Stopped },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageSpeechUpdateStatus,
        string
    > _enumToString = new()
    {
        { ClientMessageSpeechUpdateStatus.Started, "started" },
        { ClientMessageSpeechUpdateStatus.Stopped, "stopped" },
    };

    public override ClientMessageSpeechUpdateStatus Read(
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
        ClientMessageSpeechUpdateStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageSpeechUpdateStatus ReadAsPropertyName(
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
        ClientMessageSpeechUpdateStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
