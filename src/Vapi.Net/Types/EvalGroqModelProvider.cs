using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(EvalGroqModelProviderSerializer))]
public enum EvalGroqModelProvider
{
    [EnumMember(Value = "groq")]
    Groq,
}

internal class EvalGroqModelProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<EvalGroqModelProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        EvalGroqModelProvider
    > _stringToEnum = new() { { "groq", EvalGroqModelProvider.Groq } };

    private static readonly global::System.Collections.Generic.Dictionary<
        EvalGroqModelProvider,
        string
    > _enumToString = new() { { EvalGroqModelProvider.Groq, "groq" } };

    public override EvalGroqModelProvider Read(
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
        EvalGroqModelProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override EvalGroqModelProvider ReadAsPropertyName(
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
        EvalGroqModelProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
