using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateFilesRequestPurposeSerializer))]
public enum CreateFilesRequestPurpose
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "composer-attachment")]
    ComposerAttachment,

    [EnumMember(Value = "knowledge-base-v2")]
    KnowledgeBaseV2,
}

internal class CreateFilesRequestPurposeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateFilesRequestPurpose>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateFilesRequestPurpose
    > _stringToEnum = new()
    {
        { "assistant", CreateFilesRequestPurpose.Assistant },
        { "composer-attachment", CreateFilesRequestPurpose.ComposerAttachment },
        { "knowledge-base-v2", CreateFilesRequestPurpose.KnowledgeBaseV2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateFilesRequestPurpose,
        string
    > _enumToString = new()
    {
        { CreateFilesRequestPurpose.Assistant, "assistant" },
        { CreateFilesRequestPurpose.ComposerAttachment, "composer-attachment" },
        { CreateFilesRequestPurpose.KnowledgeBaseV2, "knowledge-base-v2" },
    };

    public override CreateFilesRequestPurpose Read(
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
        CreateFilesRequestPurpose value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateFilesRequestPurpose ReadAsPropertyName(
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
        CreateFilesRequestPurpose value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
