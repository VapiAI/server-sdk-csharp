using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateToolTemplateDtoTypeSerializer))]
public enum CreateToolTemplateDtoType
{
    [EnumMember(Value = "tool")]
    Tool,
}

internal class CreateToolTemplateDtoTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateToolTemplateDtoType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateToolTemplateDtoType
    > _stringToEnum = new() { { "tool", CreateToolTemplateDtoType.Tool } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateToolTemplateDtoType,
        string
    > _enumToString = new() { { CreateToolTemplateDtoType.Tool, "tool" } };

    public override CreateToolTemplateDtoType Read(
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
        CreateToolTemplateDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateToolTemplateDtoType ReadAsPropertyName(
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
        CreateToolTemplateDtoType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
