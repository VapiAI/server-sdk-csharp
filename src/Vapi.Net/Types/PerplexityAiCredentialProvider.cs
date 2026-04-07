using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PerplexityAiCredentialProviderSerializer))]
public enum PerplexityAiCredentialProvider
{
    [EnumMember(Value = "perplexity-ai")]
    PerplexityAi,
}

internal class PerplexityAiCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PerplexityAiCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PerplexityAiCredentialProvider
    > _stringToEnum = new() { { "perplexity-ai", PerplexityAiCredentialProvider.PerplexityAi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        PerplexityAiCredentialProvider,
        string
    > _enumToString = new() { { PerplexityAiCredentialProvider.PerplexityAi, "perplexity-ai" } };

    public override PerplexityAiCredentialProvider Read(
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
        PerplexityAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PerplexityAiCredentialProvider ReadAsPropertyName(
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
        PerplexityAiCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
