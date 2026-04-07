using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CustomMessageTypeSerializer))]
public enum CustomMessageType
{
    [EnumMember(Value = "custom-message")]
    CustomMessage,
}

internal class CustomMessageTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CustomMessageType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CustomMessageType
    > _stringToEnum = new() { { "custom-message", CustomMessageType.CustomMessage } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CustomMessageType,
        string
    > _enumToString = new() { { CustomMessageType.CustomMessage, "custom-message" } };

    public override CustomMessageType Read(
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
        CustomMessageType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CustomMessageType ReadAsPropertyName(
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
        CustomMessageType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
