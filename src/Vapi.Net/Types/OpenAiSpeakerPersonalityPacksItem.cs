using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiSpeakerPersonalityPacksItemSerializer))]
public enum OpenAiSpeakerPersonalityPacksItem
{
    [EnumMember(Value = "eager-listener")]
    EagerListener,

    [EnumMember(Value = "idle-hummer")]
    IdleHummer,

    [EnumMember(Value = "bouncy")]
    Bouncy,

    [EnumMember(Value = "unhurried")]
    Unhurried,
}

internal class OpenAiSpeakerPersonalityPacksItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiSpeakerPersonalityPacksItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiSpeakerPersonalityPacksItem
    > _stringToEnum = new()
    {
        { "eager-listener", OpenAiSpeakerPersonalityPacksItem.EagerListener },
        { "idle-hummer", OpenAiSpeakerPersonalityPacksItem.IdleHummer },
        { "bouncy", OpenAiSpeakerPersonalityPacksItem.Bouncy },
        { "unhurried", OpenAiSpeakerPersonalityPacksItem.Unhurried },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiSpeakerPersonalityPacksItem,
        string
    > _enumToString = new()
    {
        { OpenAiSpeakerPersonalityPacksItem.EagerListener, "eager-listener" },
        { OpenAiSpeakerPersonalityPacksItem.IdleHummer, "idle-hummer" },
        { OpenAiSpeakerPersonalityPacksItem.Bouncy, "bouncy" },
        { OpenAiSpeakerPersonalityPacksItem.Unhurried, "unhurried" },
    };

    public override OpenAiSpeakerPersonalityPacksItem Read(
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
        OpenAiSpeakerPersonalityPacksItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiSpeakerPersonalityPacksItem ReadAsPropertyName(
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
        OpenAiSpeakerPersonalityPacksItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
