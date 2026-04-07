using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferAssistantModelProviderSerializer))]
public enum TransferAssistantModelProvider
{
    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "anthropic")]
    Anthropic,

    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "custom-llm")]
    CustomLlm,
}

internal class TransferAssistantModelProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferAssistantModelProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferAssistantModelProvider
    > _stringToEnum = new()
    {
        { "openai", TransferAssistantModelProvider.Openai },
        { "anthropic", TransferAssistantModelProvider.Anthropic },
        { "google", TransferAssistantModelProvider.Google },
        { "custom-llm", TransferAssistantModelProvider.CustomLlm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferAssistantModelProvider,
        string
    > _enumToString = new()
    {
        { TransferAssistantModelProvider.Openai, "openai" },
        { TransferAssistantModelProvider.Anthropic, "anthropic" },
        { TransferAssistantModelProvider.Google, "google" },
        { TransferAssistantModelProvider.CustomLlm, "custom-llm" },
    };

    public override TransferAssistantModelProvider Read(
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
        TransferAssistantModelProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferAssistantModelProvider ReadAsPropertyName(
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
        TransferAssistantModelProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
