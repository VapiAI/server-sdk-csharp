using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateCustomKnowledgeBaseDtoProviderSerializer))]
public enum UpdateCustomKnowledgeBaseDtoProvider
{
    [EnumMember(Value = "custom-knowledge-base")]
    CustomKnowledgeBase,
}

internal class UpdateCustomKnowledgeBaseDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateCustomKnowledgeBaseDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateCustomKnowledgeBaseDtoProvider
    > _stringToEnum = new()
    {
        { "custom-knowledge-base", UpdateCustomKnowledgeBaseDtoProvider.CustomKnowledgeBase },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateCustomKnowledgeBaseDtoProvider,
        string
    > _enumToString = new()
    {
        { UpdateCustomKnowledgeBaseDtoProvider.CustomKnowledgeBase, "custom-knowledge-base" },
    };

    public override UpdateCustomKnowledgeBaseDtoProvider Read(
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
        UpdateCustomKnowledgeBaseDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateCustomKnowledgeBaseDtoProvider ReadAsPropertyName(
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
        UpdateCustomKnowledgeBaseDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
