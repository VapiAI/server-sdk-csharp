using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackOpenAiTranscriberModelSerializer))]
public enum FallbackOpenAiTranscriberModel
{
    [EnumMember(Value = "gpt-4o-transcribe")]
    Gpt4OTranscribe,

    [EnumMember(Value = "gpt-4o-mini-transcribe")]
    Gpt4OMiniTranscribe,
}

internal class FallbackOpenAiTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackOpenAiTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackOpenAiTranscriberModel
    > _stringToEnum = new()
    {
        { "gpt-4o-transcribe", FallbackOpenAiTranscriberModel.Gpt4OTranscribe },
        { "gpt-4o-mini-transcribe", FallbackOpenAiTranscriberModel.Gpt4OMiniTranscribe },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackOpenAiTranscriberModel,
        string
    > _enumToString = new()
    {
        { FallbackOpenAiTranscriberModel.Gpt4OTranscribe, "gpt-4o-transcribe" },
        { FallbackOpenAiTranscriberModel.Gpt4OMiniTranscribe, "gpt-4o-mini-transcribe" },
    };

    public override FallbackOpenAiTranscriberModel Read(
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
        FallbackOpenAiTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackOpenAiTranscriberModel ReadAsPropertyName(
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
        FallbackOpenAiTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
