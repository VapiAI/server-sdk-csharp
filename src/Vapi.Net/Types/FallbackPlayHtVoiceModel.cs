using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackPlayHtVoiceModelSerializer))]
public enum FallbackPlayHtVoiceModel
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

internal class FallbackPlayHtVoiceModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackPlayHtVoiceModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackPlayHtVoiceModel
    > _stringToEnum = new()
    {
        { "PlayHT2.0", FallbackPlayHtVoiceModel.PlayHt20 },
        { "PlayHT2.0-turbo", FallbackPlayHtVoiceModel.PlayHt20Turbo },
        { "Play3.0-mini", FallbackPlayHtVoiceModel.Play30Mini },
        { "PlayDialog", FallbackPlayHtVoiceModel.PlayDialog },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackPlayHtVoiceModel,
        string
    > _enumToString = new()
    {
        { FallbackPlayHtVoiceModel.PlayHt20, "PlayHT2.0" },
        { FallbackPlayHtVoiceModel.PlayHt20Turbo, "PlayHT2.0-turbo" },
        { FallbackPlayHtVoiceModel.Play30Mini, "Play3.0-mini" },
        { FallbackPlayHtVoiceModel.PlayDialog, "PlayDialog" },
    };

    public override FallbackPlayHtVoiceModel Read(
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
        FallbackPlayHtVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackPlayHtVoiceModel ReadAsPropertyName(
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
        FallbackPlayHtVoiceModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
