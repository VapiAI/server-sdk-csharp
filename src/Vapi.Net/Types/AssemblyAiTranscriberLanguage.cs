using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssemblyAiTranscriberLanguageSerializer))]
public enum AssemblyAiTranscriberLanguage
{
    [EnumMember(Value = "multi")]
    Multi,

    [EnumMember(Value = "en")]
    En,
}

internal class AssemblyAiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssemblyAiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssemblyAiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "multi", AssemblyAiTranscriberLanguage.Multi },
        { "en", AssemblyAiTranscriberLanguage.En },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssemblyAiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { AssemblyAiTranscriberLanguage.Multi, "multi" },
        { AssemblyAiTranscriberLanguage.En, "en" },
    };

    public override AssemblyAiTranscriberLanguage Read(
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
        AssemblyAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssemblyAiTranscriberLanguage ReadAsPropertyName(
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
        AssemblyAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
