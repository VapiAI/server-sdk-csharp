using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PlayHtVoiceIdEnumSerializer))]
public enum PlayHtVoiceIdEnum
{
    [EnumMember(Value = "jennifer")]
    Jennifer,

    [EnumMember(Value = "melissa")]
    Melissa,

    [EnumMember(Value = "will")]
    Will,

    [EnumMember(Value = "chris")]
    Chris,

    [EnumMember(Value = "matt")]
    Matt,

    [EnumMember(Value = "jack")]
    Jack,

    [EnumMember(Value = "ruby")]
    Ruby,

    [EnumMember(Value = "davis")]
    Davis,

    [EnumMember(Value = "donna")]
    Donna,

    [EnumMember(Value = "michael")]
    Michael,
}

internal class PlayHtVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PlayHtVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PlayHtVoiceIdEnum
    > _stringToEnum = new()
    {
        { "jennifer", PlayHtVoiceIdEnum.Jennifer },
        { "melissa", PlayHtVoiceIdEnum.Melissa },
        { "will", PlayHtVoiceIdEnum.Will },
        { "chris", PlayHtVoiceIdEnum.Chris },
        { "matt", PlayHtVoiceIdEnum.Matt },
        { "jack", PlayHtVoiceIdEnum.Jack },
        { "ruby", PlayHtVoiceIdEnum.Ruby },
        { "davis", PlayHtVoiceIdEnum.Davis },
        { "donna", PlayHtVoiceIdEnum.Donna },
        { "michael", PlayHtVoiceIdEnum.Michael },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PlayHtVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { PlayHtVoiceIdEnum.Jennifer, "jennifer" },
        { PlayHtVoiceIdEnum.Melissa, "melissa" },
        { PlayHtVoiceIdEnum.Will, "will" },
        { PlayHtVoiceIdEnum.Chris, "chris" },
        { PlayHtVoiceIdEnum.Matt, "matt" },
        { PlayHtVoiceIdEnum.Jack, "jack" },
        { PlayHtVoiceIdEnum.Ruby, "ruby" },
        { PlayHtVoiceIdEnum.Davis, "davis" },
        { PlayHtVoiceIdEnum.Donna, "donna" },
        { PlayHtVoiceIdEnum.Michael, "michael" },
    };

    public override PlayHtVoiceIdEnum Read(
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
        PlayHtVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PlayHtVoiceIdEnum ReadAsPropertyName(
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
        PlayHtVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
