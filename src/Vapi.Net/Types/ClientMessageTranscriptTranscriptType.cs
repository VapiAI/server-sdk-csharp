using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageTranscriptTranscriptTypeSerializer))]
public enum ClientMessageTranscriptTranscriptType
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "final")]
    Final,
}

internal class ClientMessageTranscriptTranscriptTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageTranscriptTranscriptType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageTranscriptTranscriptType
    > _stringToEnum = new()
    {
        { "partial", ClientMessageTranscriptTranscriptType.Partial },
        { "final", ClientMessageTranscriptTranscriptType.Final },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageTranscriptTranscriptType,
        string
    > _enumToString = new()
    {
        { ClientMessageTranscriptTranscriptType.Partial, "partial" },
        { ClientMessageTranscriptTranscriptType.Final, "final" },
    };

    public override ClientMessageTranscriptTranscriptType Read(
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
        ClientMessageTranscriptTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageTranscriptTranscriptType ReadAsPropertyName(
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
        ClientMessageTranscriptTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
