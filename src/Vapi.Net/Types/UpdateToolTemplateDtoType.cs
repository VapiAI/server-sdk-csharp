using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateToolTemplateDtoTypeSerializer))]
public enum UpdateToolTemplateDtoType
{
    [EnumMember(Value = "tool")]
    Tool,
}

internal class UpdateToolTemplateDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateToolTemplateDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateToolTemplateDtoType
    > _stringToEnum = new() { { "tool", UpdateToolTemplateDtoType.Tool } };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateToolTemplateDtoType,
        string
    > _enumToString = new() { { UpdateToolTemplateDtoType.Tool, "tool" } };

    public override UpdateToolTemplateDtoType Read(
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
        UpdateToolTemplateDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateToolTemplateDtoType ReadAsPropertyName(
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
        UpdateToolTemplateDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
