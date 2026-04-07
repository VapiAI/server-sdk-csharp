using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssemblyAiTranscriberSpeechModelSerializer))]
public enum AssemblyAiTranscriberSpeechModel
{
    [EnumMember(Value = "universal-streaming-english")]
    UniversalStreamingEnglish,

    [EnumMember(Value = "universal-streaming-multilingual")]
    UniversalStreamingMultilingual,
}

internal class AssemblyAiTranscriberSpeechModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssemblyAiTranscriberSpeechModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssemblyAiTranscriberSpeechModel
    > _stringToEnum = new()
    {
        {
            "universal-streaming-english",
            AssemblyAiTranscriberSpeechModel.UniversalStreamingEnglish
        },
        {
            "universal-streaming-multilingual",
            AssemblyAiTranscriberSpeechModel.UniversalStreamingMultilingual
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssemblyAiTranscriberSpeechModel,
        string
    > _enumToString = new()
    {
        {
            AssemblyAiTranscriberSpeechModel.UniversalStreamingEnglish,
            "universal-streaming-english"
        },
        {
            AssemblyAiTranscriberSpeechModel.UniversalStreamingMultilingual,
            "universal-streaming-multilingual"
        },
    };

    public override AssemblyAiTranscriberSpeechModel Read(
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
        AssemblyAiTranscriberSpeechModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssemblyAiTranscriberSpeechModel ReadAsPropertyName(
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
        AssemblyAiTranscriberSpeechModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
