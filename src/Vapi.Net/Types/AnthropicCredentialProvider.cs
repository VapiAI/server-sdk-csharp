using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AnthropicCredentialProviderSerializer))]
public enum AnthropicCredentialProvider
{
    [EnumMember(Value = "anthropic")]
    Anthropic,
}

internal class AnthropicCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AnthropicCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AnthropicCredentialProvider
    > _stringToEnum = new() { { "anthropic", AnthropicCredentialProvider.Anthropic } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AnthropicCredentialProvider,
        string
    > _enumToString = new() { { AnthropicCredentialProvider.Anthropic, "anthropic" } };

    public override AnthropicCredentialProvider Read(
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
        AnthropicCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AnthropicCredentialProvider ReadAsPropertyName(
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
        AnthropicCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
