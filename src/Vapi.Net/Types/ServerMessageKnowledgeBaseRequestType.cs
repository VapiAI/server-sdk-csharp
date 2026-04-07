using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageKnowledgeBaseRequestTypeSerializer))]
public enum ServerMessageKnowledgeBaseRequestType
{
    [EnumMember(Value = "knowledge-base-request")]
    KnowledgeBaseRequest,
}

internal class ServerMessageKnowledgeBaseRequestTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageKnowledgeBaseRequestType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageKnowledgeBaseRequestType
    > _stringToEnum = new()
    {
        { "knowledge-base-request", ServerMessageKnowledgeBaseRequestType.KnowledgeBaseRequest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageKnowledgeBaseRequestType,
        string
    > _enumToString = new()
    {
        { ServerMessageKnowledgeBaseRequestType.KnowledgeBaseRequest, "knowledge-base-request" },
    };

    public override ServerMessageKnowledgeBaseRequestType Read(
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
        ServerMessageKnowledgeBaseRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageKnowledgeBaseRequestType ReadAsPropertyName(
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
        ServerMessageKnowledgeBaseRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
