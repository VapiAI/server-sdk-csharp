using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolCallResultMessageWarningTypeSerializer))]
public enum ToolCallResultMessageWarningType
{
    [EnumMember(Value = "oversized-tool-response")]
    OversizedToolResponse,
}

internal class ToolCallResultMessageWarningTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolCallResultMessageWarningType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolCallResultMessageWarningType
    > _stringToEnum = new()
    {
        { "oversized-tool-response", ToolCallResultMessageWarningType.OversizedToolResponse },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolCallResultMessageWarningType,
        string
    > _enumToString = new()
    {
        { ToolCallResultMessageWarningType.OversizedToolResponse, "oversized-tool-response" },
    };

    public override ToolCallResultMessageWarningType Read(
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
        ToolCallResultMessageWarningType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolCallResultMessageWarningType ReadAsPropertyName(
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
        ToolCallResultMessageWarningType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
