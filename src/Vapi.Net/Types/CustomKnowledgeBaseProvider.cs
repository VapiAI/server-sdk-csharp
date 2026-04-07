using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CustomKnowledgeBaseProviderSerializer))]
public enum CustomKnowledgeBaseProvider
{
    [EnumMember(Value = "custom-knowledge-base")]
    CustomKnowledgeBase,
}

internal class CustomKnowledgeBaseProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CustomKnowledgeBaseProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CustomKnowledgeBaseProvider
    > _stringToEnum = new()
    {
        { "custom-knowledge-base", CustomKnowledgeBaseProvider.CustomKnowledgeBase },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CustomKnowledgeBaseProvider,
        string
    > _enumToString = new()
    {
        { CustomKnowledgeBaseProvider.CustomKnowledgeBase, "custom-knowledge-base" },
    };

    public override CustomKnowledgeBaseProvider Read(
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
        CustomKnowledgeBaseProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CustomKnowledgeBaseProvider ReadAsPropertyName(
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
        CustomKnowledgeBaseProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
