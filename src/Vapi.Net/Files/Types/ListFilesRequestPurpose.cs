using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ListFilesRequestPurposeSerializer))]
public enum ListFilesRequestPurpose
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "composer-attachment")]
    ComposerAttachment,

    [EnumMember(Value = "knowledge-base-v2")]
    KnowledgeBaseV2,
}

internal class ListFilesRequestPurposeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ListFilesRequestPurpose>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ListFilesRequestPurpose
    > _stringToEnum = new()
    {
        { "assistant", ListFilesRequestPurpose.Assistant },
        { "composer-attachment", ListFilesRequestPurpose.ComposerAttachment },
        { "knowledge-base-v2", ListFilesRequestPurpose.KnowledgeBaseV2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ListFilesRequestPurpose,
        string
    > _enumToString = new()
    {
        { ListFilesRequestPurpose.Assistant, "assistant" },
        { ListFilesRequestPurpose.ComposerAttachment, "composer-attachment" },
        { ListFilesRequestPurpose.KnowledgeBaseV2, "knowledge-base-v2" },
    };

    public override ListFilesRequestPurpose Read(
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
        ListFilesRequestPurpose value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ListFilesRequestPurpose ReadAsPropertyName(
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
        ListFilesRequestPurpose value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
