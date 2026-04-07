using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GladiaTranscriberLanguageBehaviourSerializer))]
public enum GladiaTranscriberLanguageBehaviour
{
    [EnumMember(Value = "manual")]
    Manual,

    [EnumMember(Value = "automatic single language")]
    AutomaticSingleLanguage,

    [EnumMember(Value = "automatic multiple languages")]
    AutomaticMultipleLanguages,
}

internal class GladiaTranscriberLanguageBehaviourSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GladiaTranscriberLanguageBehaviour>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GladiaTranscriberLanguageBehaviour
    > _stringToEnum = new()
    {
        { "manual", GladiaTranscriberLanguageBehaviour.Manual },
        { "automatic single language", GladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage },
        {
            "automatic multiple languages",
            GladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GladiaTranscriberLanguageBehaviour,
        string
    > _enumToString = new()
    {
        { GladiaTranscriberLanguageBehaviour.Manual, "manual" },
        { GladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage, "automatic single language" },
        {
            GladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages,
            "automatic multiple languages"
        },
    };

    public override GladiaTranscriberLanguageBehaviour Read(
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
        GladiaTranscriberLanguageBehaviour value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GladiaTranscriberLanguageBehaviour ReadAsPropertyName(
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
        GladiaTranscriberLanguageBehaviour value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
