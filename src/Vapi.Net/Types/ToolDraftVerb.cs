using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolDraftVerbSerializer))]
public enum ToolDraftVerb
{
    [EnumMember(Value = "INFO")]
    Info,

    [EnumMember(Value = "MESSAGE")]
    Message,

    [EnumMember(Value = "NOTIFY")]
    Notify,
}

internal class ToolDraftVerbSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolDraftVerb>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolDraftVerb
    > _stringToEnum = new()
    {
        { "INFO", ToolDraftVerb.Info },
        { "MESSAGE", ToolDraftVerb.Message },
        { "NOTIFY", ToolDraftVerb.Notify },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolDraftVerb,
        string
    > _enumToString = new()
    {
        { ToolDraftVerb.Info, "INFO" },
        { ToolDraftVerb.Message, "MESSAGE" },
        { ToolDraftVerb.Notify, "NOTIFY" },
    };

    public override ToolDraftVerb Read(
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
        ToolDraftVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolDraftVerb ReadAsPropertyName(
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
        ToolDraftVerb value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
