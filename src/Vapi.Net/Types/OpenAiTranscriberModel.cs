using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiTranscriberModelSerializer))]
public enum OpenAiTranscriberModel
{
    [EnumMember(Value = "gpt-4o-transcribe")]
    Gpt4OTranscribe,

    [EnumMember(Value = "gpt-4o-mini-transcribe")]
    Gpt4OMiniTranscribe,
}

internal class OpenAiTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiTranscriberModel
    > _stringToEnum = new()
    {
        { "gpt-4o-transcribe", OpenAiTranscriberModel.Gpt4OTranscribe },
        { "gpt-4o-mini-transcribe", OpenAiTranscriberModel.Gpt4OMiniTranscribe },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiTranscriberModel,
        string
    > _enumToString = new()
    {
        { OpenAiTranscriberModel.Gpt4OTranscribe, "gpt-4o-transcribe" },
        { OpenAiTranscriberModel.Gpt4OMiniTranscribe, "gpt-4o-mini-transcribe" },
    };

    public override OpenAiTranscriberModel Read(
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
        OpenAiTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiTranscriberModel ReadAsPropertyName(
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
        OpenAiTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
