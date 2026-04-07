using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrieveKnowledgeBaseImportTypeSerializer))]
public enum TrieveKnowledgeBaseImportType
{
    [EnumMember(Value = "import")]
    Import,
}

internal class TrieveKnowledgeBaseImportTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrieveKnowledgeBaseImportType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrieveKnowledgeBaseImportType
    > _stringToEnum = new() { { "import", TrieveKnowledgeBaseImportType.Import } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrieveKnowledgeBaseImportType,
        string
    > _enumToString = new() { { TrieveKnowledgeBaseImportType.Import, "import" } };

    public override TrieveKnowledgeBaseImportType Read(
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
        TrieveKnowledgeBaseImportType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrieveKnowledgeBaseImportType ReadAsPropertyName(
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
        TrieveKnowledgeBaseImportType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
