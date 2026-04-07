using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CustomLlmCredentialProviderSerializer))]
public enum CustomLlmCredentialProvider
{
    [EnumMember(Value = "custom-llm")]
    CustomLlm,
}

internal class CustomLlmCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CustomLlmCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CustomLlmCredentialProvider
    > _stringToEnum = new() { { "custom-llm", CustomLlmCredentialProvider.CustomLlm } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CustomLlmCredentialProvider,
        string
    > _enumToString = new() { { CustomLlmCredentialProvider.CustomLlm, "custom-llm" } };

    public override CustomLlmCredentialProvider Read(
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
        CustomLlmCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CustomLlmCredentialProvider ReadAsPropertyName(
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
        CustomLlmCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
