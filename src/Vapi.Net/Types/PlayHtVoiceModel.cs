using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PlayHtVoiceModelSerializer))]
public enum PlayHtVoiceModel
{
    [EnumMember(Value = "PlayHT2.0")]
    PlayHt20,

    [EnumMember(Value = "PlayHT2.0-turbo")]
    PlayHt20Turbo,

    [EnumMember(Value = "Play3.0-mini")]
    Play30Mini,

    [EnumMember(Value = "PlayDialog")]
    PlayDialog,
}

internal class PlayHtVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PlayHtVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PlayHtVoiceModel
    > _stringToEnum = new()
    {
        { "PlayHT2.0", PlayHtVoiceModel.PlayHt20 },
        { "PlayHT2.0-turbo", PlayHtVoiceModel.PlayHt20Turbo },
        { "Play3.0-mini", PlayHtVoiceModel.Play30Mini },
        { "PlayDialog", PlayHtVoiceModel.PlayDialog },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PlayHtVoiceModel,
        string
    > _enumToString = new()
    {
        { PlayHtVoiceModel.PlayHt20, "PlayHT2.0" },
        { PlayHtVoiceModel.PlayHt20Turbo, "PlayHT2.0-turbo" },
        { PlayHtVoiceModel.Play30Mini, "Play3.0-mini" },
        { PlayHtVoiceModel.PlayDialog, "PlayDialog" },
    };

    public override PlayHtVoiceModel Read(
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
        PlayHtVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PlayHtVoiceModel ReadAsPropertyName(
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
        PlayHtVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
