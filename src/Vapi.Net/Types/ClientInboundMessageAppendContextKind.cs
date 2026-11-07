using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientInboundMessageAppendContextKindSerializer))]
public enum ClientInboundMessageAppendContextKind
{
    [EnumMember(Value = "commentary")]
    Commentary,

    [EnumMember(Value = "thinking")]
    Thinking,

    [EnumMember(Value = "instructions")]
    Instructions,
}

internal class ClientInboundMessageAppendContextKindSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientInboundMessageAppendContextKind>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientInboundMessageAppendContextKind
    > _stringToEnum = new()
    {
        { "commentary", ClientInboundMessageAppendContextKind.Commentary },
        { "thinking", ClientInboundMessageAppendContextKind.Thinking },
        { "instructions", ClientInboundMessageAppendContextKind.Instructions },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientInboundMessageAppendContextKind,
        string
    > _enumToString = new()
    {
        { ClientInboundMessageAppendContextKind.Commentary, "commentary" },
        { ClientInboundMessageAppendContextKind.Thinking, "thinking" },
        { ClientInboundMessageAppendContextKind.Instructions, "instructions" },
    };

    public override ClientInboundMessageAppendContextKind Read(
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
        ClientInboundMessageAppendContextKind value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientInboundMessageAppendContextKind ReadAsPropertyName(
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
        ClientInboundMessageAppendContextKind value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
