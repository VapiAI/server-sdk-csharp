using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAssemblyAiTranscriberLanguageSerializer))]
public enum FallbackAssemblyAiTranscriberLanguage
{
    [EnumMember(Value = "multi")]
    Multi,

    [EnumMember(Value = "en")]
    En,
}

internal class FallbackAssemblyAiTranscriberLanguageSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAssemblyAiTranscriberLanguage>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAssemblyAiTranscriberLanguage
    > _stringToEnum = new()
    {
        { "multi", FallbackAssemblyAiTranscriberLanguage.Multi },
        { "en", FallbackAssemblyAiTranscriberLanguage.En },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAssemblyAiTranscriberLanguage,
        string
    > _enumToString = new()
    {
        { FallbackAssemblyAiTranscriberLanguage.Multi, "multi" },
        { FallbackAssemblyAiTranscriberLanguage.En, "en" },
    };

    public override FallbackAssemblyAiTranscriberLanguage Read(
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
        FallbackAssemblyAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAssemblyAiTranscriberLanguage ReadAsPropertyName(
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
        FallbackAssemblyAiTranscriberLanguage value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
