using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackAssemblyAiTranscriberSpeechModelSerializer))]
public enum FallbackAssemblyAiTranscriberSpeechModel
{
    [EnumMember(Value = "universal-streaming-english")]
    UniversalStreamingEnglish,

    [EnumMember(Value = "universal-streaming-multilingual")]
    UniversalStreamingMultilingual,
}

internal class FallbackAssemblyAiTranscriberSpeechModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackAssemblyAiTranscriberSpeechModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackAssemblyAiTranscriberSpeechModel
    > _stringToEnum = new()
    {
        {
            "universal-streaming-english",
            FallbackAssemblyAiTranscriberSpeechModel.UniversalStreamingEnglish
        },
        {
            "universal-streaming-multilingual",
            FallbackAssemblyAiTranscriberSpeechModel.UniversalStreamingMultilingual
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackAssemblyAiTranscriberSpeechModel,
        string
    > _enumToString = new()
    {
        {
            FallbackAssemblyAiTranscriberSpeechModel.UniversalStreamingEnglish,
            "universal-streaming-english"
        },
        {
            FallbackAssemblyAiTranscriberSpeechModel.UniversalStreamingMultilingual,
            "universal-streaming-multilingual"
        },
    };

    public override FallbackAssemblyAiTranscriberSpeechModel Read(
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
        FallbackAssemblyAiTranscriberSpeechModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackAssemblyAiTranscriberSpeechModel ReadAsPropertyName(
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
        FallbackAssemblyAiTranscriberSpeechModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
