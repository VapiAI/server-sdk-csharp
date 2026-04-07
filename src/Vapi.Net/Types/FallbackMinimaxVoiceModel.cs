using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMinimaxVoiceModelSerializer))]
public enum FallbackMinimaxVoiceModel
{
    [EnumMember(Value = "speech-02-hd")]
    Speech02Hd,

    [EnumMember(Value = "speech-02-turbo")]
    Speech02Turbo,

    [EnumMember(Value = "speech-2.5-turbo-preview")]
    Speech25TurboPreview,
}

internal class FallbackMinimaxVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMinimaxVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMinimaxVoiceModel
    > _stringToEnum = new()
    {
        { "speech-02-hd", FallbackMinimaxVoiceModel.Speech02Hd },
        { "speech-02-turbo", FallbackMinimaxVoiceModel.Speech02Turbo },
        { "speech-2.5-turbo-preview", FallbackMinimaxVoiceModel.Speech25TurboPreview },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMinimaxVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackMinimaxVoiceModel.Speech02Hd, "speech-02-hd" },
        { FallbackMinimaxVoiceModel.Speech02Turbo, "speech-02-turbo" },
        { FallbackMinimaxVoiceModel.Speech25TurboPreview, "speech-2.5-turbo-preview" },
    };

    public override FallbackMinimaxVoiceModel Read(
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
        FallbackMinimaxVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMinimaxVoiceModel ReadAsPropertyName(
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
        FallbackMinimaxVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
