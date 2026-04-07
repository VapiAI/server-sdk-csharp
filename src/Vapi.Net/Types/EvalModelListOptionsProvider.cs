using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalModelListOptionsProviderSerializer))]
public enum EvalModelListOptionsProvider
{
    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "anthropic")]
    Anthropic,

    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "groq")]
    Groq,

    [EnumMember(Value = "custom-llm")]
    CustomLlm,
}

internal class EvalModelListOptionsProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalModelListOptionsProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalModelListOptionsProvider
    > _stringToEnum = new()
    {
        { "openai", EvalModelListOptionsProvider.Openai },
        { "anthropic", EvalModelListOptionsProvider.Anthropic },
        { "google", EvalModelListOptionsProvider.Google },
        { "groq", EvalModelListOptionsProvider.Groq },
        { "custom-llm", EvalModelListOptionsProvider.CustomLlm },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalModelListOptionsProvider,
        string
    > _enumToString = new()
    {
        { EvalModelListOptionsProvider.Openai, "openai" },
        { EvalModelListOptionsProvider.Anthropic, "anthropic" },
        { EvalModelListOptionsProvider.Google, "google" },
        { EvalModelListOptionsProvider.Groq, "groq" },
        { EvalModelListOptionsProvider.CustomLlm, "custom-llm" },
    };

    public override EvalModelListOptionsProvider Read(
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
        EvalModelListOptionsProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalModelListOptionsProvider ReadAsPropertyName(
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
        EvalModelListOptionsProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
