using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LangfuseCredentialProviderSerializer))]
public enum LangfuseCredentialProvider
{
    [EnumMember(Value = "langfuse")]
    Langfuse,
}

internal class LangfuseCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LangfuseCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LangfuseCredentialProvider
    > _stringToEnum = new() { { "langfuse", LangfuseCredentialProvider.Langfuse } };

    private static readonly global::System.Collections.Generic.Dictionary<
        LangfuseCredentialProvider,
        string
    > _enumToString = new() { { LangfuseCredentialProvider.Langfuse, "langfuse" } };

    public override LangfuseCredentialProvider Read(
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
        LangfuseCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LangfuseCredentialProvider ReadAsPropertyName(
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
        LangfuseCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
