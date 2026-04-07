using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateTextEditorToolDtoSubTypeSerializer))]
public enum UpdateTextEditorToolDtoSubType
{
    [EnumMember(Value = "text_editor_20241022")]
    TextEditor20241022,
}

internal class UpdateTextEditorToolDtoSubTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateTextEditorToolDtoSubType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateTextEditorToolDtoSubType
    > _stringToEnum = new()
    {
        { "text_editor_20241022", UpdateTextEditorToolDtoSubType.TextEditor20241022 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateTextEditorToolDtoSubType,
        string
    > _enumToString = new()
    {
        { UpdateTextEditorToolDtoSubType.TextEditor20241022, "text_editor_20241022" },
    };

    public override UpdateTextEditorToolDtoSubType Read(
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
        UpdateTextEditorToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateTextEditorToolDtoSubType ReadAsPropertyName(
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
        UpdateTextEditorToolDtoSubType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
