using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageTranscriptTranscriptTypeSerializer))]
public enum ServerMessageTranscriptTranscriptType
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "final")]
    Final,
}

internal class ServerMessageTranscriptTranscriptTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageTranscriptTranscriptType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageTranscriptTranscriptType
    > _stringToEnum = new()
    {
        { "partial", ServerMessageTranscriptTranscriptType.Partial },
        { "final", ServerMessageTranscriptTranscriptType.Final },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageTranscriptTranscriptType,
        string
    > _enumToString = new()
    {
        { ServerMessageTranscriptTranscriptType.Partial, "partial" },
        { ServerMessageTranscriptTranscriptType.Final, "final" },
    };

    public override ServerMessageTranscriptTranscriptType Read(
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
        ServerMessageTranscriptTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageTranscriptTranscriptType ReadAsPropertyName(
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
        ServerMessageTranscriptTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
