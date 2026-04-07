using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TrieveKnowledgeBaseSearchPlanSearchTypeSerializer))]
public enum TrieveKnowledgeBaseSearchPlanSearchType
{
    [EnumMember(Value = "fulltext")]
    Fulltext,

    [EnumMember(Value = "semantic")]
    Semantic,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "bm25")]
    Bm25,
}

internal class TrieveKnowledgeBaseSearchPlanSearchTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TrieveKnowledgeBaseSearchPlanSearchType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TrieveKnowledgeBaseSearchPlanSearchType
    > _stringToEnum = new()
    {
        { "fulltext", TrieveKnowledgeBaseSearchPlanSearchType.Fulltext },
        { "semantic", TrieveKnowledgeBaseSearchPlanSearchType.Semantic },
        { "hybrid", TrieveKnowledgeBaseSearchPlanSearchType.Hybrid },
        { "bm25", TrieveKnowledgeBaseSearchPlanSearchType.Bm25 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TrieveKnowledgeBaseSearchPlanSearchType,
        string
    > _enumToString = new()
    {
        { TrieveKnowledgeBaseSearchPlanSearchType.Fulltext, "fulltext" },
        { TrieveKnowledgeBaseSearchPlanSearchType.Semantic, "semantic" },
        { TrieveKnowledgeBaseSearchPlanSearchType.Hybrid, "hybrid" },
        { TrieveKnowledgeBaseSearchPlanSearchType.Bm25, "bm25" },
    };

    public override TrieveKnowledgeBaseSearchPlanSearchType Read(
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
        TrieveKnowledgeBaseSearchPlanSearchType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TrieveKnowledgeBaseSearchPlanSearchType ReadAsPropertyName(
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
        TrieveKnowledgeBaseSearchPlanSearchType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
