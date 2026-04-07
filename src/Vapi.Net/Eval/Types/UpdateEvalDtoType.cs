using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateEvalDtoTypeSerializer))]
public enum UpdateEvalDtoType
{
    [EnumMember(Value = "chat.mockConversation")]
    ChatMockConversation,
}

internal class UpdateEvalDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateEvalDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateEvalDtoType
    > _stringToEnum = new() { { "chat.mockConversation", UpdateEvalDtoType.ChatMockConversation } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateEvalDtoType,
        string
    > _enumToString = new() { { UpdateEvalDtoType.ChatMockConversation, "chat.mockConversation" } };

    public override UpdateEvalDtoType Read(
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
        UpdateEvalDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateEvalDtoType ReadAsPropertyName(
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
        UpdateEvalDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
