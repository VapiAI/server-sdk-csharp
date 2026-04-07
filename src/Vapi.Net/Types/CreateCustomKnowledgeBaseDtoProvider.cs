using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateCustomKnowledgeBaseDtoProviderSerializer))]
public enum CreateCustomKnowledgeBaseDtoProvider
{
    [EnumMember(Value = "custom-knowledge-base")]
    CustomKnowledgeBase,
}

internal class CreateCustomKnowledgeBaseDtoProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateCustomKnowledgeBaseDtoProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateCustomKnowledgeBaseDtoProvider
    > _stringToEnum = new()
    {
        { "custom-knowledge-base", CreateCustomKnowledgeBaseDtoProvider.CustomKnowledgeBase },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateCustomKnowledgeBaseDtoProvider,
        string
    > _enumToString = new()
    {
        { CreateCustomKnowledgeBaseDtoProvider.CustomKnowledgeBase, "custom-knowledge-base" },
    };

    public override CreateCustomKnowledgeBaseDtoProvider Read(
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
        CreateCustomKnowledgeBaseDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateCustomKnowledgeBaseDtoProvider ReadAsPropertyName(
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
        CreateCustomKnowledgeBaseDtoProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
