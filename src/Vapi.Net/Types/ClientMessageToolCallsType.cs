using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageToolCallsTypeSerializer))]
public enum ClientMessageToolCallsType
{
    [EnumMember(Value = "tool-calls")]
    ToolCalls,
}

internal class ClientMessageToolCallsTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageToolCallsType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageToolCallsType
    > _stringToEnum = new() { { "tool-calls", ClientMessageToolCallsType.ToolCalls } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageToolCallsType,
        string
    > _enumToString = new() { { ClientMessageToolCallsType.ToolCalls, "tool-calls" } };

    public override ClientMessageToolCallsType Read(
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
        ClientMessageToolCallsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageToolCallsType ReadAsPropertyName(
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
        ClientMessageToolCallsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
