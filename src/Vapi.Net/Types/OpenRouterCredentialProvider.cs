using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenRouterCredentialProviderSerializer))]
public enum OpenRouterCredentialProvider
{
    [EnumMember(Value = "openrouter")]
    Openrouter,
}

internal class OpenRouterCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenRouterCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenRouterCredentialProvider
    > _stringToEnum = new() { { "openrouter", OpenRouterCredentialProvider.Openrouter } };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenRouterCredentialProvider,
        string
    > _enumToString = new() { { OpenRouterCredentialProvider.Openrouter, "openrouter" } };

    public override OpenRouterCredentialProvider Read(
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
        OpenRouterCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenRouterCredentialProvider ReadAsPropertyName(
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
        OpenRouterCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
