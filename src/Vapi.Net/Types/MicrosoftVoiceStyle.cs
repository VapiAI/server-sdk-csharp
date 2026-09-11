using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MicrosoftVoiceStyleSerializer))]
public enum MicrosoftVoiceStyle
{
    [EnumMember(Value = "adventurous")]
    Adventurous,

    [EnumMember(Value = "angry")]
    Angry,

    [EnumMember(Value = "caring")]
    Caring,

    [EnumMember(Value = "cheerful")]
    Cheerful,

    [EnumMember(Value = "confused")]
    Confused,

    [EnumMember(Value = "curious")]
    Curious,

    [EnumMember(Value = "determined")]
    Determined,

    [EnumMember(Value = "disappointed")]
    Disappointed,

    [EnumMember(Value = "disgusted")]
    Disgusted,

    [EnumMember(Value = "embarrassed")]
    Embarrassed,

    [EnumMember(Value = "empathy")]
    Empathy,

    [EnumMember(Value = "encouraging")]
    Encouraging,

    [EnumMember(Value = "excited")]
    Excited,

    [EnumMember(Value = "fearful")]
    Fearful,

    [EnumMember(Value = "friendly")]
    Friendly,

    [EnumMember(Value = "happy")]
    Happy,

    [EnumMember(Value = "hopeful")]
    Hopeful,

    [EnumMember(Value = "jealous")]
    Jealous,

    [EnumMember(Value = "joyful")]
    Joyful,

    [EnumMember(Value = "nostalgic")]
    Nostalgic,

    [EnumMember(Value = "reflective")]
    Reflective,

    [EnumMember(Value = "regretful")]
    Regretful,

    [EnumMember(Value = "relieved")]
    Relieved,

    [EnumMember(Value = "sad")]
    Sad,

    [EnumMember(Value = "serious")]
    Serious,

    [EnumMember(Value = "shouting")]
    Shouting,

    [EnumMember(Value = "softvoice")]
    Softvoice,

    [EnumMember(Value = "surprised")]
    Surprised,

    [EnumMember(Value = "whispering")]
    Whispering,
}

internal class MicrosoftVoiceStyleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MicrosoftVoiceStyle>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MicrosoftVoiceStyle
    > _stringToEnum = new()
    {
        { "adventurous", MicrosoftVoiceStyle.Adventurous },
        { "angry", MicrosoftVoiceStyle.Angry },
        { "caring", MicrosoftVoiceStyle.Caring },
        { "cheerful", MicrosoftVoiceStyle.Cheerful },
        { "confused", MicrosoftVoiceStyle.Confused },
        { "curious", MicrosoftVoiceStyle.Curious },
        { "determined", MicrosoftVoiceStyle.Determined },
        { "disappointed", MicrosoftVoiceStyle.Disappointed },
        { "disgusted", MicrosoftVoiceStyle.Disgusted },
        { "embarrassed", MicrosoftVoiceStyle.Embarrassed },
        { "empathy", MicrosoftVoiceStyle.Empathy },
        { "encouraging", MicrosoftVoiceStyle.Encouraging },
        { "excited", MicrosoftVoiceStyle.Excited },
        { "fearful", MicrosoftVoiceStyle.Fearful },
        { "friendly", MicrosoftVoiceStyle.Friendly },
        { "happy", MicrosoftVoiceStyle.Happy },
        { "hopeful", MicrosoftVoiceStyle.Hopeful },
        { "jealous", MicrosoftVoiceStyle.Jealous },
        { "joyful", MicrosoftVoiceStyle.Joyful },
        { "nostalgic", MicrosoftVoiceStyle.Nostalgic },
        { "reflective", MicrosoftVoiceStyle.Reflective },
        { "regretful", MicrosoftVoiceStyle.Regretful },
        { "relieved", MicrosoftVoiceStyle.Relieved },
        { "sad", MicrosoftVoiceStyle.Sad },
        { "serious", MicrosoftVoiceStyle.Serious },
        { "shouting", MicrosoftVoiceStyle.Shouting },
        { "softvoice", MicrosoftVoiceStyle.Softvoice },
        { "surprised", MicrosoftVoiceStyle.Surprised },
        { "whispering", MicrosoftVoiceStyle.Whispering },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MicrosoftVoiceStyle,
        string
    > _enumToString = new()
    {
        { MicrosoftVoiceStyle.Adventurous, "adventurous" },
        { MicrosoftVoiceStyle.Angry, "angry" },
        { MicrosoftVoiceStyle.Caring, "caring" },
        { MicrosoftVoiceStyle.Cheerful, "cheerful" },
        { MicrosoftVoiceStyle.Confused, "confused" },
        { MicrosoftVoiceStyle.Curious, "curious" },
        { MicrosoftVoiceStyle.Determined, "determined" },
        { MicrosoftVoiceStyle.Disappointed, "disappointed" },
        { MicrosoftVoiceStyle.Disgusted, "disgusted" },
        { MicrosoftVoiceStyle.Embarrassed, "embarrassed" },
        { MicrosoftVoiceStyle.Empathy, "empathy" },
        { MicrosoftVoiceStyle.Encouraging, "encouraging" },
        { MicrosoftVoiceStyle.Excited, "excited" },
        { MicrosoftVoiceStyle.Fearful, "fearful" },
        { MicrosoftVoiceStyle.Friendly, "friendly" },
        { MicrosoftVoiceStyle.Happy, "happy" },
        { MicrosoftVoiceStyle.Hopeful, "hopeful" },
        { MicrosoftVoiceStyle.Jealous, "jealous" },
        { MicrosoftVoiceStyle.Joyful, "joyful" },
        { MicrosoftVoiceStyle.Nostalgic, "nostalgic" },
        { MicrosoftVoiceStyle.Reflective, "reflective" },
        { MicrosoftVoiceStyle.Regretful, "regretful" },
        { MicrosoftVoiceStyle.Relieved, "relieved" },
        { MicrosoftVoiceStyle.Sad, "sad" },
        { MicrosoftVoiceStyle.Serious, "serious" },
        { MicrosoftVoiceStyle.Shouting, "shouting" },
        { MicrosoftVoiceStyle.Softvoice, "softvoice" },
        { MicrosoftVoiceStyle.Surprised, "surprised" },
        { MicrosoftVoiceStyle.Whispering, "whispering" },
    };

    public override MicrosoftVoiceStyle Read(
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
        MicrosoftVoiceStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MicrosoftVoiceStyle ReadAsPropertyName(
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
        MicrosoftVoiceStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
