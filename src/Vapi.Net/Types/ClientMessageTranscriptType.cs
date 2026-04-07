using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageTranscriptTypeSerializer))]
public enum ClientMessageTranscriptType
{
    [EnumMember(Value = "transcript")]
    Transcript,

    [EnumMember(Value = "transcript[transcriptType=\"final\"]")]
    TranscriptTranscriptTypeFinal,
}

internal class ClientMessageTranscriptTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageTranscriptType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageTranscriptType
    > _stringToEnum = new()
    {
        { "transcript", ClientMessageTranscriptType.Transcript },
        {
            "transcript[transcriptType=\"final\"]",
            ClientMessageTranscriptType.TranscriptTranscriptTypeFinal
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageTranscriptType,
        string
    > _enumToString = new()
    {
        { ClientMessageTranscriptType.Transcript, "transcript" },
        {
            ClientMessageTranscriptType.TranscriptTranscriptTypeFinal,
            "transcript[transcriptType=\"final\"]"
        },
    };

    public override ClientMessageTranscriptType Read(
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
        ClientMessageTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageTranscriptType ReadAsPropertyName(
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
        ClientMessageTranscriptType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
