using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageTranscriptConfidenceSourceSerializer))]
public enum ServerMessageTranscriptConfidenceSource
{
    [EnumMember(Value = "provider")]
    Provider,

    [EnumMember(Value = "derived")]
    Derived,
}

internal class ServerMessageTranscriptConfidenceSourceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageTranscriptConfidenceSource>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageTranscriptConfidenceSource
    > _stringToEnum = new()
    {
        { "provider", ServerMessageTranscriptConfidenceSource.Provider },
        { "derived", ServerMessageTranscriptConfidenceSource.Derived },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageTranscriptConfidenceSource,
        string
    > _enumToString = new()
    {
        { ServerMessageTranscriptConfidenceSource.Provider, "provider" },
        { ServerMessageTranscriptConfidenceSource.Derived, "derived" },
    };

    public override ServerMessageTranscriptConfidenceSource Read(
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
        ServerMessageTranscriptConfidenceSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageTranscriptConfidenceSource ReadAsPropertyName(
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
        ServerMessageTranscriptConfidenceSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
