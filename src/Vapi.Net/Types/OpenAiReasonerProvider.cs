using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiReasonerProviderSerializer))]
public enum OpenAiReasonerProvider
{
    [EnumMember(Value = "openai")]
    Openai,
}

internal class OpenAiReasonerProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiReasonerProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiReasonerProvider
    > _stringToEnum = new() { { "openai", OpenAiReasonerProvider.Openai } };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiReasonerProvider,
        string
    > _enumToString = new() { { OpenAiReasonerProvider.Openai, "openai" } };

    public override OpenAiReasonerProvider Read(
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
        OpenAiReasonerProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiReasonerProvider ReadAsPropertyName(
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
        OpenAiReasonerProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
