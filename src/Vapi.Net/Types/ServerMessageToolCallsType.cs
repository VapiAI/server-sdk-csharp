using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageToolCallsTypeSerializer))]
public enum ServerMessageToolCallsType
{
    [EnumMember(Value = "tool-calls")]
    ToolCalls,
}

internal class ServerMessageToolCallsTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageToolCallsType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageToolCallsType
    > _stringToEnum = new() { { "tool-calls", ServerMessageToolCallsType.ToolCalls } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageToolCallsType,
        string
    > _enumToString = new() { { ServerMessageToolCallsType.ToolCalls, "tool-calls" } };

    public override ServerMessageToolCallsType Read(
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
        ServerMessageToolCallsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageToolCallsType ReadAsPropertyName(
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
        ServerMessageToolCallsType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
