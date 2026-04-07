using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateToolTemplateDtoProviderSerializer))]
public enum UpdateToolTemplateDtoProvider
{
    [EnumMember(Value = "make")]
    Make,

    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,

    [EnumMember(Value = "function")]
    Function,
}

internal class UpdateToolTemplateDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateToolTemplateDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateToolTemplateDtoProvider
    > _stringToEnum = new()
    {
        { "make", UpdateToolTemplateDtoProvider.Make },
        { "gohighlevel", UpdateToolTemplateDtoProvider.Gohighlevel },
        { "function", UpdateToolTemplateDtoProvider.Function },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateToolTemplateDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateToolTemplateDtoProvider.Make, "make" },
        { UpdateToolTemplateDtoProvider.Gohighlevel, "gohighlevel" },
        { UpdateToolTemplateDtoProvider.Function, "function" },
    };

    public override UpdateToolTemplateDtoProvider Read(
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
        UpdateToolTemplateDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateToolTemplateDtoProvider ReadAsPropertyName(
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
        UpdateToolTemplateDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
