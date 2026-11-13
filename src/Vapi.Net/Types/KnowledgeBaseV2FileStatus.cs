using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(KnowledgeBaseV2FileStatusSerializer))]
public enum KnowledgeBaseV2FileStatus
{
    [EnumMember(Value = "indexing")]
    Indexing,

    [EnumMember(Value = "ready")]
    Ready,

    [EnumMember(Value = "failed")]
    Failed,
}

internal class KnowledgeBaseV2FileStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<KnowledgeBaseV2FileStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        KnowledgeBaseV2FileStatus
    > _stringToEnum = new()
    {
        { "indexing", KnowledgeBaseV2FileStatus.Indexing },
        { "ready", KnowledgeBaseV2FileStatus.Ready },
        { "failed", KnowledgeBaseV2FileStatus.Failed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        KnowledgeBaseV2FileStatus,
        string
    > _enumToString = new()
    {
        { KnowledgeBaseV2FileStatus.Indexing, "indexing" },
        { KnowledgeBaseV2FileStatus.Ready, "ready" },
        { KnowledgeBaseV2FileStatus.Failed, "failed" },
    };

    public override KnowledgeBaseV2FileStatus Read(
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
        KnowledgeBaseV2FileStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override KnowledgeBaseV2FileStatus ReadAsPropertyName(
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
        KnowledgeBaseV2FileStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
