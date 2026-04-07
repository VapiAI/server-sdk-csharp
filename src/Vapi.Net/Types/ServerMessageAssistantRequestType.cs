using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageAssistantRequestTypeSerializer))]
public enum ServerMessageAssistantRequestType
{
    [EnumMember(Value = "assistant-request")]
    AssistantRequest,
}

internal class ServerMessageAssistantRequestTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageAssistantRequestType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageAssistantRequestType
    > _stringToEnum = new()
    {
        { "assistant-request", ServerMessageAssistantRequestType.AssistantRequest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageAssistantRequestType,
        string
    > _enumToString = new()
    {
        { ServerMessageAssistantRequestType.AssistantRequest, "assistant-request" },
    };

    public override ServerMessageAssistantRequestType Read(
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
        ServerMessageAssistantRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageAssistantRequestType ReadAsPropertyName(
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
        ServerMessageAssistantRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
