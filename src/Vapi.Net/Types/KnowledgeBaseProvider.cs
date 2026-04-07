using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(KnowledgeBaseProviderSerializer))]
public enum KnowledgeBaseProvider
{
    [EnumMember(Value = "google")]
    Google,
}

internal class KnowledgeBaseProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<KnowledgeBaseProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        KnowledgeBaseProvider
    > _stringToEnum = new() { { "google", KnowledgeBaseProvider.Google } };

    private static readonly global::System.Collections.Generic.Dictionary<
        KnowledgeBaseProvider,
        string
    > _enumToString = new() { { KnowledgeBaseProvider.Google, "google" } };

    public override KnowledgeBaseProvider Read(
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
        KnowledgeBaseProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override KnowledgeBaseProvider ReadAsPropertyName(
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
        KnowledgeBaseProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
