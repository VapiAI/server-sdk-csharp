using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackGladiaTranscriberLanguageBehaviourSerializer))]
public enum FallbackGladiaTranscriberLanguageBehaviour
{
    [EnumMember(Value = "manual")]
    Manual,

    [EnumMember(Value = "automatic single language")]
    AutomaticSingleLanguage,

    [EnumMember(Value = "automatic multiple languages")]
    AutomaticMultipleLanguages,
}

internal class FallbackGladiaTranscriberLanguageBehaviourSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackGladiaTranscriberLanguageBehaviour>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackGladiaTranscriberLanguageBehaviour
    > _stringToEnum = new()
    {
        { "manual", FallbackGladiaTranscriberLanguageBehaviour.Manual },
        {
            "automatic single language",
            FallbackGladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage
        },
        {
            "automatic multiple languages",
            FallbackGladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackGladiaTranscriberLanguageBehaviour,
        string
    > _enumToString = new()
    {
        { FallbackGladiaTranscriberLanguageBehaviour.Manual, "manual" },
        {
            FallbackGladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage,
            "automatic single language"
        },
        {
            FallbackGladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages,
            "automatic multiple languages"
        },
    };

    public override FallbackGladiaTranscriberLanguageBehaviour Read(
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
        FallbackGladiaTranscriberLanguageBehaviour value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackGladiaTranscriberLanguageBehaviour ReadAsPropertyName(
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
        FallbackGladiaTranscriberLanguageBehaviour value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
