using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PlayHtVoiceEmotionSerializer))]
public enum PlayHtVoiceEmotion
{
    [EnumMember(Value = "female_happy")]
    FemaleHappy,

    [EnumMember(Value = "female_sad")]
    FemaleSad,

    [EnumMember(Value = "female_angry")]
    FemaleAngry,

    [EnumMember(Value = "female_fearful")]
    FemaleFearful,

    [EnumMember(Value = "female_disgust")]
    FemaleDisgust,

    [EnumMember(Value = "female_surprised")]
    FemaleSurprised,

    [EnumMember(Value = "male_happy")]
    MaleHappy,

    [EnumMember(Value = "male_sad")]
    MaleSad,

    [EnumMember(Value = "male_angry")]
    MaleAngry,

    [EnumMember(Value = "male_fearful")]
    MaleFearful,

    [EnumMember(Value = "male_disgust")]
    MaleDisgust,

    [EnumMember(Value = "male_surprised")]
    MaleSurprised,
}

internal class PlayHtVoiceEmotionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PlayHtVoiceEmotion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PlayHtVoiceEmotion
    > _stringToEnum = new()
    {
        { "female_happy", PlayHtVoiceEmotion.FemaleHappy },
        { "female_sad", PlayHtVoiceEmotion.FemaleSad },
        { "female_angry", PlayHtVoiceEmotion.FemaleAngry },
        { "female_fearful", PlayHtVoiceEmotion.FemaleFearful },
        { "female_disgust", PlayHtVoiceEmotion.FemaleDisgust },
        { "female_surprised", PlayHtVoiceEmotion.FemaleSurprised },
        { "male_happy", PlayHtVoiceEmotion.MaleHappy },
        { "male_sad", PlayHtVoiceEmotion.MaleSad },
        { "male_angry", PlayHtVoiceEmotion.MaleAngry },
        { "male_fearful", PlayHtVoiceEmotion.MaleFearful },
        { "male_disgust", PlayHtVoiceEmotion.MaleDisgust },
        { "male_surprised", PlayHtVoiceEmotion.MaleSurprised },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PlayHtVoiceEmotion,
        string
    > _enumToString = new()
    {
        { PlayHtVoiceEmotion.FemaleHappy, "female_happy" },
        { PlayHtVoiceEmotion.FemaleSad, "female_sad" },
        { PlayHtVoiceEmotion.FemaleAngry, "female_angry" },
        { PlayHtVoiceEmotion.FemaleFearful, "female_fearful" },
        { PlayHtVoiceEmotion.FemaleDisgust, "female_disgust" },
        { PlayHtVoiceEmotion.FemaleSurprised, "female_surprised" },
        { PlayHtVoiceEmotion.MaleHappy, "male_happy" },
        { PlayHtVoiceEmotion.MaleSad, "male_sad" },
        { PlayHtVoiceEmotion.MaleAngry, "male_angry" },
        { PlayHtVoiceEmotion.MaleFearful, "male_fearful" },
        { PlayHtVoiceEmotion.MaleDisgust, "male_disgust" },
        { PlayHtVoiceEmotion.MaleSurprised, "male_surprised" },
    };

    public override PlayHtVoiceEmotion Read(
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
        PlayHtVoiceEmotion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PlayHtVoiceEmotion ReadAsPropertyName(
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
        PlayHtVoiceEmotion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
