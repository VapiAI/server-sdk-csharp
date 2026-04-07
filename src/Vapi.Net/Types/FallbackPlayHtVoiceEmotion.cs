using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackPlayHtVoiceEmotionSerializer))]
public enum FallbackPlayHtVoiceEmotion
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

internal class FallbackPlayHtVoiceEmotionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackPlayHtVoiceEmotion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackPlayHtVoiceEmotion
    > _stringToEnum = new()
    {
        { "female_happy", FallbackPlayHtVoiceEmotion.FemaleHappy },
        { "female_sad", FallbackPlayHtVoiceEmotion.FemaleSad },
        { "female_angry", FallbackPlayHtVoiceEmotion.FemaleAngry },
        { "female_fearful", FallbackPlayHtVoiceEmotion.FemaleFearful },
        { "female_disgust", FallbackPlayHtVoiceEmotion.FemaleDisgust },
        { "female_surprised", FallbackPlayHtVoiceEmotion.FemaleSurprised },
        { "male_happy", FallbackPlayHtVoiceEmotion.MaleHappy },
        { "male_sad", FallbackPlayHtVoiceEmotion.MaleSad },
        { "male_angry", FallbackPlayHtVoiceEmotion.MaleAngry },
        { "male_fearful", FallbackPlayHtVoiceEmotion.MaleFearful },
        { "male_disgust", FallbackPlayHtVoiceEmotion.MaleDisgust },
        { "male_surprised", FallbackPlayHtVoiceEmotion.MaleSurprised },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackPlayHtVoiceEmotion,
        string
    > _enumToString = new()
    {
        { FallbackPlayHtVoiceEmotion.FemaleHappy, "female_happy" },
        { FallbackPlayHtVoiceEmotion.FemaleSad, "female_sad" },
        { FallbackPlayHtVoiceEmotion.FemaleAngry, "female_angry" },
        { FallbackPlayHtVoiceEmotion.FemaleFearful, "female_fearful" },
        { FallbackPlayHtVoiceEmotion.FemaleDisgust, "female_disgust" },
        { FallbackPlayHtVoiceEmotion.FemaleSurprised, "female_surprised" },
        { FallbackPlayHtVoiceEmotion.MaleHappy, "male_happy" },
        { FallbackPlayHtVoiceEmotion.MaleSad, "male_sad" },
        { FallbackPlayHtVoiceEmotion.MaleAngry, "male_angry" },
        { FallbackPlayHtVoiceEmotion.MaleFearful, "male_fearful" },
        { FallbackPlayHtVoiceEmotion.MaleDisgust, "male_disgust" },
        { FallbackPlayHtVoiceEmotion.MaleSurprised, "male_surprised" },
    };

    public override FallbackPlayHtVoiceEmotion Read(
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
        FallbackPlayHtVoiceEmotion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackPlayHtVoiceEmotion ReadAsPropertyName(
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
        FallbackPlayHtVoiceEmotion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
