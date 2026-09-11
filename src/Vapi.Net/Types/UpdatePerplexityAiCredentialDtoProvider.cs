using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdatePerplexityAiCredentialDtoProviderSerializer))]
public enum UpdatePerplexityAiCredentialDtoProvider
{
    [EnumMember(Value = "perplexity-ai")]
    PerplexityAi,
}

internal class UpdatePerplexityAiCredentialDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdatePerplexityAiCredentialDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdatePerplexityAiCredentialDtoProvider
    > _stringToEnum = new()
    {
        { "perplexity-ai", UpdatePerplexityAiCredentialDtoProvider.PerplexityAi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdatePerplexityAiCredentialDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdatePerplexityAiCredentialDtoProvider.PerplexityAi, "perplexity-ai" },
    };

    public override UpdatePerplexityAiCredentialDtoProvider Read(
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
        UpdatePerplexityAiCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdatePerplexityAiCredentialDtoProvider ReadAsPropertyName(
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
        UpdatePerplexityAiCredentialDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
