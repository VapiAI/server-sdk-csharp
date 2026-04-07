using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateTextEditorToolDtoSubTypeSerializer))]
public enum CreateTextEditorToolDtoSubType
{
    [EnumMember(Value = "text_editor_20241022")]
    TextEditor20241022,
}

internal class CreateTextEditorToolDtoSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateTextEditorToolDtoSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateTextEditorToolDtoSubType
    > _stringToEnum = new()
    {
        { "text_editor_20241022", CreateTextEditorToolDtoSubType.TextEditor20241022 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateTextEditorToolDtoSubType,
        string
    > _enumToString = new()
    {
        { CreateTextEditorToolDtoSubType.TextEditor20241022, "text_editor_20241022" },
    };

    public override CreateTextEditorToolDtoSubType Read(
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
        CreateTextEditorToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateTextEditorToolDtoSubType ReadAsPropertyName(
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
        CreateTextEditorToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
