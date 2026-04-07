using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureOpenAiCredentialProviderSerializer))]
public enum AzureOpenAiCredentialProvider
{
    [EnumMember(Value = "azure-openai")]
    AzureOpenai,
}

internal class AzureOpenAiCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureOpenAiCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureOpenAiCredentialProvider
    > _stringToEnum = new() { { "azure-openai", AzureOpenAiCredentialProvider.AzureOpenai } };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureOpenAiCredentialProvider,
        string
    > _enumToString = new() { { AzureOpenAiCredentialProvider.AzureOpenai, "azure-openai" } };

    public override AzureOpenAiCredentialProvider Read(
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
        AzureOpenAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureOpenAiCredentialProvider ReadAsPropertyName(
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
        AzureOpenAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
