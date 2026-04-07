using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateTrieveKnowledgeBaseDtoProviderSerializer))]
public enum CreateTrieveKnowledgeBaseDtoProvider
{
    [EnumMember(Value = "trieve")]
    Trieve,
}

internal class CreateTrieveKnowledgeBaseDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateTrieveKnowledgeBaseDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateTrieveKnowledgeBaseDtoProvider
    > _stringToEnum = new() { { "trieve", CreateTrieveKnowledgeBaseDtoProvider.Trieve } };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateTrieveKnowledgeBaseDtoProvider,
        string
    > _enumToString = new() { { CreateTrieveKnowledgeBaseDtoProvider.Trieve, "trieve" } };

    public override CreateTrieveKnowledgeBaseDtoProvider Read(
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
        CreateTrieveKnowledgeBaseDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateTrieveKnowledgeBaseDtoProvider ReadAsPropertyName(
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
        CreateTrieveKnowledgeBaseDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
