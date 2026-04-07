using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MinimaxVoiceModelSerializer))]
public enum MinimaxVoiceModel
{
    [EnumMember(Value = "speech-02-hd")]
    Speech02Hd,

    [EnumMember(Value = "speech-02-turbo")]
    Speech02Turbo,

    [EnumMember(Value = "speech-2.5-turbo-preview")]
    Speech25TurboPreview,
}

internal class MinimaxVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MinimaxVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MinimaxVoiceModel
    > _stringToEnum = new()
    {
        { "speech-02-hd", MinimaxVoiceModel.Speech02Hd },
        { "speech-02-turbo", MinimaxVoiceModel.Speech02Turbo },
        { "speech-2.5-turbo-preview", MinimaxVoiceModel.Speech25TurboPreview },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MinimaxVoiceModel,
        string
    > _enumToString = new()
    {
        { MinimaxVoiceModel.Speech02Hd, "speech-02-hd" },
        { MinimaxVoiceModel.Speech02Turbo, "speech-02-turbo" },
        { MinimaxVoiceModel.Speech25TurboPreview, "speech-2.5-turbo-preview" },
    };

    public override MinimaxVoiceModel Read(
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
        MinimaxVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MinimaxVoiceModel ReadAsPropertyName(
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
        MinimaxVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
