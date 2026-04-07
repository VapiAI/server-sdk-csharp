using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(McpToolMetadataProtocolSerializer))]
public enum McpToolMetadataProtocol
{
    [EnumMember(Value = "sse")]
    Sse,

    [EnumMember(Value = "shttp")]
    Shttp,
}

internal class McpToolMetadataProtocolSerializer
    : global::System.Text.Json.Serialization.JsonConverter<McpToolMetadataProtocol>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        McpToolMetadataProtocol
    > _stringToEnum = new()
    {
        { "sse", McpToolMetadataProtocol.Sse },
        { "shttp", McpToolMetadataProtocol.Shttp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        McpToolMetadataProtocol,
        string
    > _enumToString = new()
    {
        { McpToolMetadataProtocol.Sse, "sse" },
        { McpToolMetadataProtocol.Shttp, "shttp" },
    };

    public override McpToolMetadataProtocol Read(
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
        McpToolMetadataProtocol value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override McpToolMetadataProtocol ReadAsPropertyName(
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
        McpToolMetadataProtocol value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
