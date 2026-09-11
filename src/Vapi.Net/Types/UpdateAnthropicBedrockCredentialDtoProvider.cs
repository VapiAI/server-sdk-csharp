using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAnthropicBedrockCredentialDtoProviderSerializer))]
public enum UpdateAnthropicBedrockCredentialDtoProvider
{
    [EnumMember(Value = "anthropic-bedrock")]
    AnthropicBedrock,
}

internal class UpdateAnthropicBedrockCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAnthropicBedrockCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAnthropicBedrockCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "anthropic-bedrock", UpdateAnthropicBedrockCredentialDtoProvider.AnthropicBedrock },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAnthropicBedrockCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateAnthropicBedrockCredentialDtoProvider.AnthropicBedrock, "anthropic-bedrock" },
    };

    public override UpdateAnthropicBedrockCredentialDtoProvider Read(
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
        UpdateAnthropicBedrockCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAnthropicBedrockCredentialDtoProvider ReadAsPropertyName(
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
        UpdateAnthropicBedrockCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
