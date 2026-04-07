using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageToolCallsResultTypeSerializer))]
public enum ClientMessageToolCallsResultType
{
    [EnumMember(Value = "tool-calls-result")]
    ToolCallsResult,
}

internal class ClientMessageToolCallsResultTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageToolCallsResultType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageToolCallsResultType
    > _stringToEnum = new()
    {
        { "tool-calls-result", ClientMessageToolCallsResultType.ToolCallsResult },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageToolCallsResultType,
        string
    > _enumToString = new()
    {
        { ClientMessageToolCallsResultType.ToolCallsResult, "tool-calls-result" },
    };

    public override ClientMessageToolCallsResultType Read(
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
        ClientMessageToolCallsResultType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageToolCallsResultType ReadAsPropertyName(
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
        ClientMessageToolCallsResultType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
