using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAzureOpenAiCredentialDtoProviderSerializer))]
public enum UpdateAzureOpenAiCredentialDtoProvider
{
    [EnumMember(Value = "azure-openai")]
    AzureOpenai,
}

internal class UpdateAzureOpenAiCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAzureOpenAiCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAzureOpenAiCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "azure-openai", UpdateAzureOpenAiCredentialDtoProvider.AzureOpenai },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAzureOpenAiCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateAzureOpenAiCredentialDtoProvider.AzureOpenai, "azure-openai" },
    };

    public override UpdateAzureOpenAiCredentialDtoProvider Read(
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
        UpdateAzureOpenAiCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAzureOpenAiCredentialDtoProvider ReadAsPropertyName(
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
        UpdateAzureOpenAiCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
