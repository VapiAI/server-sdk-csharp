using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalUserEditableTypeSerializer))]
public enum EvalUserEditableType
{
    [EnumMember(Value = "chat.mockConversation")]
    ChatMockConversation,
}

internal class EvalUserEditableTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalUserEditableType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalUserEditableType
    > _stringToEnum = new()
    {
        { "chat.mockConversation", EvalUserEditableType.ChatMockConversation },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalUserEditableType,
        string
    > _enumToString = new()
    {
        { EvalUserEditableType.ChatMockConversation, "chat.mockConversation" },
    };

    public override EvalUserEditableType Read(
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
        EvalUserEditableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalUserEditableType ReadAsPropertyName(
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
        EvalUserEditableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
