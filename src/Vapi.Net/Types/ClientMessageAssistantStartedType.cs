using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageAssistantStartedTypeSerializer))]
public enum ClientMessageAssistantStartedType
{
    [EnumMember(Value = "assistant.started")]
    AssistantStarted,
}

internal class ClientMessageAssistantStartedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageAssistantStartedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageAssistantStartedType
    > _stringToEnum = new()
    {
        { "assistant.started", ClientMessageAssistantStartedType.AssistantStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageAssistantStartedType,
        string
    > _enumToString = new()
    {
        { ClientMessageAssistantStartedType.AssistantStarted, "assistant.started" },
    };

    public override ClientMessageAssistantStartedType Read(
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
        ClientMessageAssistantStartedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageAssistantStartedType ReadAsPropertyName(
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
        ClientMessageAssistantStartedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
