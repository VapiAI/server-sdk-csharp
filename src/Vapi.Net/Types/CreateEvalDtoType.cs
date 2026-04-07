using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateEvalDtoTypeSerializer))]
public enum CreateEvalDtoType
{
    [EnumMember(Value = "chat.mockConversation")]
    ChatMockConversation,
}

internal class CreateEvalDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateEvalDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateEvalDtoType
    > _stringToEnum = new() { { "chat.mockConversation", CreateEvalDtoType.ChatMockConversation } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateEvalDtoType,
        string
    > _enumToString = new() { { CreateEvalDtoType.ChatMockConversation, "chat.mockConversation" } };

    public override CreateEvalDtoType Read(
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
        CreateEvalDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateEvalDtoType ReadAsPropertyName(
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
        CreateEvalDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
