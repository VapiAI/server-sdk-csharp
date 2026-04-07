using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateToolTemplateDtoProviderSerializer))]
public enum CreateToolTemplateDtoProvider
{
    [EnumMember(Value = "make")]
    Make,

    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,

    [EnumMember(Value = "function")]
    Function,
}

internal class CreateToolTemplateDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateToolTemplateDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateToolTemplateDtoProvider
    > _stringToEnum = new()
    {
        { "make", CreateToolTemplateDtoProvider.Make },
        { "gohighlevel", CreateToolTemplateDtoProvider.Gohighlevel },
        { "function", CreateToolTemplateDtoProvider.Function },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateToolTemplateDtoProvider,
        string
    > _enumToString = new()
    {
        { CreateToolTemplateDtoProvider.Make, "make" },
        { CreateToolTemplateDtoProvider.Gohighlevel, "gohighlevel" },
        { CreateToolTemplateDtoProvider.Function, "function" },
    };

    public override CreateToolTemplateDtoProvider Read(
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
        CreateToolTemplateDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateToolTemplateDtoProvider ReadAsPropertyName(
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
        CreateToolTemplateDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
