using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackMicrosoftVoiceStyleSerializer))]
public enum FallbackMicrosoftVoiceStyle
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

internal class FallbackMicrosoftVoiceStyleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackMicrosoftVoiceStyle>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackMicrosoftVoiceStyle
    > _stringToEnum = new()
    {
        { "adventurous", FallbackMicrosoftVoiceStyle.Adventurous },
        { "angry", FallbackMicrosoftVoiceStyle.Angry },
        { "caring", FallbackMicrosoftVoiceStyle.Caring },
        { "cheerful", FallbackMicrosoftVoiceStyle.Cheerful },
        { "confused", FallbackMicrosoftVoiceStyle.Confused },
        { "curious", FallbackMicrosoftVoiceStyle.Curious },
        { "determined", FallbackMicrosoftVoiceStyle.Determined },
        { "disappointed", FallbackMicrosoftVoiceStyle.Disappointed },
        { "disgusted", FallbackMicrosoftVoiceStyle.Disgusted },
        { "embarrassed", FallbackMicrosoftVoiceStyle.Embarrassed },
        { "empathy", FallbackMicrosoftVoiceStyle.Empathy },
        { "encouraging", FallbackMicrosoftVoiceStyle.Encouraging },
        { "excited", FallbackMicrosoftVoiceStyle.Excited },
        { "fearful", FallbackMicrosoftVoiceStyle.Fearful },
        { "friendly", FallbackMicrosoftVoiceStyle.Friendly },
        { "happy", FallbackMicrosoftVoiceStyle.Happy },
        { "hopeful", FallbackMicrosoftVoiceStyle.Hopeful },
        { "jealous", FallbackMicrosoftVoiceStyle.Jealous },
        { "joyful", FallbackMicrosoftVoiceStyle.Joyful },
        { "nostalgic", FallbackMicrosoftVoiceStyle.Nostalgic },
        { "reflective", FallbackMicrosoftVoiceStyle.Reflective },
        { "regretful", FallbackMicrosoftVoiceStyle.Regretful },
        { "relieved", FallbackMicrosoftVoiceStyle.Relieved },
        { "sad", FallbackMicrosoftVoiceStyle.Sad },
        { "serious", FallbackMicrosoftVoiceStyle.Serious },
        { "shouting", FallbackMicrosoftVoiceStyle.Shouting },
        { "softvoice", FallbackMicrosoftVoiceStyle.Softvoice },
        { "surprised", FallbackMicrosoftVoiceStyle.Surprised },
        { "whispering", FallbackMicrosoftVoiceStyle.Whispering },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackMicrosoftVoiceStyle,
        string
    > _enumToString = new()
    {
        { FallbackMicrosoftVoiceStyle.Adventurous, "adventurous" },
        { FallbackMicrosoftVoiceStyle.Angry, "angry" },
        { FallbackMicrosoftVoiceStyle.Caring, "caring" },
        { FallbackMicrosoftVoiceStyle.Cheerful, "cheerful" },
        { FallbackMicrosoftVoiceStyle.Confused, "confused" },
        { FallbackMicrosoftVoiceStyle.Curious, "curious" },
        { FallbackMicrosoftVoiceStyle.Determined, "determined" },
        { FallbackMicrosoftVoiceStyle.Disappointed, "disappointed" },
        { FallbackMicrosoftVoiceStyle.Disgusted, "disgusted" },
        { FallbackMicrosoftVoiceStyle.Embarrassed, "embarrassed" },
        { FallbackMicrosoftVoiceStyle.Empathy, "empathy" },
        { FallbackMicrosoftVoiceStyle.Encouraging, "encouraging" },
        { FallbackMicrosoftVoiceStyle.Excited, "excited" },
        { FallbackMicrosoftVoiceStyle.Fearful, "fearful" },
        { FallbackMicrosoftVoiceStyle.Friendly, "friendly" },
        { FallbackMicrosoftVoiceStyle.Happy, "happy" },
        { FallbackMicrosoftVoiceStyle.Hopeful, "hopeful" },
        { FallbackMicrosoftVoiceStyle.Jealous, "jealous" },
        { FallbackMicrosoftVoiceStyle.Joyful, "joyful" },
        { FallbackMicrosoftVoiceStyle.Nostalgic, "nostalgic" },
        { FallbackMicrosoftVoiceStyle.Reflective, "reflective" },
        { FallbackMicrosoftVoiceStyle.Regretful, "regretful" },
        { FallbackMicrosoftVoiceStyle.Relieved, "relieved" },
        { FallbackMicrosoftVoiceStyle.Sad, "sad" },
        { FallbackMicrosoftVoiceStyle.Serious, "serious" },
        { FallbackMicrosoftVoiceStyle.Shouting, "shouting" },
        { FallbackMicrosoftVoiceStyle.Softvoice, "softvoice" },
        { FallbackMicrosoftVoiceStyle.Surprised, "surprised" },
        { FallbackMicrosoftVoiceStyle.Whispering, "whispering" },
    };

    public override FallbackMicrosoftVoiceStyle Read(
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
        FallbackMicrosoftVoiceStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackMicrosoftVoiceStyle ReadAsPropertyName(
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
        FallbackMicrosoftVoiceStyle value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
