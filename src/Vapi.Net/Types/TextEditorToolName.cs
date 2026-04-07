using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TextEditorToolNameSerializer))]
public enum TextEditorToolName
{
    [EnumMember(Value = "str_replace_editor")]
    StrReplaceEditor,
}

internal class TextEditorToolNameSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TextEditorToolName>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TextEditorToolName
    > _stringToEnum = new() { { "str_replace_editor", TextEditorToolName.StrReplaceEditor } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TextEditorToolName,
        string
    > _enumToString = new() { { TextEditorToolName.StrReplaceEditor, "str_replace_editor" } };

    public override TextEditorToolName Read(
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
        TextEditorToolName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TextEditorToolName ReadAsPropertyName(
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
        TextEditorToolName value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
