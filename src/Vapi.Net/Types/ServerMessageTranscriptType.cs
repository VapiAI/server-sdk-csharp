using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageTranscriptTypeSerializer))]
public enum ServerMessageTranscriptType
{
    [EnumMember(Value = "transcript")]
    Transcript,

    [EnumMember(Value = "transcript[transcriptType=\"final\"]")]
    TranscriptTranscriptTypeFinal,
}

internal class ServerMessageTranscriptTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageTranscriptType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageTranscriptType
    > _stringToEnum = new()
    {
        { "transcript", ServerMessageTranscriptType.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            ServerMessageTranscriptType.TranscriptTranscriptTypeFinal
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageTranscriptType,
        string
    > _enumToString = new()
    {
        { ServerMessageTranscriptType.Transcript, "transcript" },
        {
            ServerMessageTranscriptType.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
    };

    public override ServerMessageTranscriptType Read(
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
        ServerMessageTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageTranscriptType ReadAsPropertyName(
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
        ServerMessageTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
