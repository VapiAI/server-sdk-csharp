using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageTranscriptConfidenceSourceSerializer))]
public enum ClientMessageTranscriptConfidenceSource
{
    [EnumMember(Value = "provider")]
    Provider,

    [EnumMember(Value = "derived")]
    Derived,
}

internal class ClientMessageTranscriptConfidenceSourceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageTranscriptConfidenceSource>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageTranscriptConfidenceSource
    > _stringToEnum = new()
    {
        { "provider", ClientMessageTranscriptConfidenceSource.Provider },
        { "derived", ClientMessageTranscriptConfidenceSource.Derived },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageTranscriptConfidenceSource,
        string
    > _enumToString = new()
    {
        { ClientMessageTranscriptConfidenceSource.Provider, "provider" },
        { ClientMessageTranscriptConfidenceSource.Derived, "derived" },
    };

    public override ClientMessageTranscriptConfidenceSource Read(
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
        ClientMessageTranscriptConfidenceSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageTranscriptConfidenceSource ReadAsPropertyName(
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
        ClientMessageTranscriptConfidenceSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
