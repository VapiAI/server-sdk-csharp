using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateTestSuiteTestChatDtoTypeSerializer))]
public enum UpdateTestSuiteTestChatDtoType
{
    [EnumMember(Value = "chat")]
    Chat,
}

internal class UpdateTestSuiteTestChatDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateTestSuiteTestChatDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateTestSuiteTestChatDtoType
    > _stringToEnum = new() { { "chat", UpdateTestSuiteTestChatDtoType.Chat } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateTestSuiteTestChatDtoType,
        string
    > _enumToString = new() { { UpdateTestSuiteTestChatDtoType.Chat, "chat" } };

    public override UpdateTestSuiteTestChatDtoType Read(
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
        UpdateTestSuiteTestChatDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateTestSuiteTestChatDtoType ReadAsPropertyName(
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
        UpdateTestSuiteTestChatDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
