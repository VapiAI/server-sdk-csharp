using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TemplateProviderSerializer))]
public enum TemplateProvider
{
    [EnumMember(Value = "make")]
    Make,

    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,

    [EnumMember(Value = "function")]
    Function,
}

internal class TemplateProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TemplateProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TemplateProvider
    > _stringToEnum = new()
    {
        { "make", TemplateProvider.Make },
        { "gohighlevel", TemplateProvider.Gohighlevel },
        { "function", TemplateProvider.Function },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TemplateProvider,
        string
    > _enumToString = new()
    {
        { TemplateProvider.Make, "make" },
        { TemplateProvider.Gohighlevel, "gohighlevel" },
        { TemplateProvider.Function, "function" },
    };

    public override TemplateProvider Read(
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
        TemplateProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TemplateProvider ReadAsPropertyName(
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
        TemplateProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
