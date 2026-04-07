using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateToolTemplateDtoVisibilitySerializer))]
public enum CreateToolTemplateDtoVisibility
{
    [EnumMember(Value = "public")]
    Public,

    [EnumMember(Value = "private")]
    Private,
}

internal class CreateToolTemplateDtoVisibilitySerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateToolTemplateDtoVisibility>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateToolTemplateDtoVisibility
    > _stringToEnum = new()
    {
        { "public", CreateToolTemplateDtoVisibility.Public },
        { "private", CreateToolTemplateDtoVisibility.Private },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateToolTemplateDtoVisibility,
        string
    > _enumToString = new()
    {
        { CreateToolTemplateDtoVisibility.Public, "public" },
        { CreateToolTemplateDtoVisibility.Private, "private" },
    };

    public override CreateToolTemplateDtoVisibility Read(
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
        CreateToolTemplateDtoVisibility value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateToolTemplateDtoVisibility ReadAsPropertyName(
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
        CreateToolTemplateDtoVisibility value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
