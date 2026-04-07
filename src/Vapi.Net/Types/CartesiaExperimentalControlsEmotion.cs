using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CartesiaExperimentalControlsEmotionSerializer))]
public enum CartesiaExperimentalControlsEmotion
{
    [EnumMember(Value = "anger:lowest")]
    AngerLowest,

    [EnumMember(Value = "anger:low")]
    AngerLow,

    [EnumMember(Value = "anger:high")]
    AngerHigh,

    [EnumMember(Value = "anger:highest")]
    AngerHighest,

    [EnumMember(Value = "positivity:lowest")]
    PositivityLowest,

    [EnumMember(Value = "positivity:low")]
    PositivityLow,

    [EnumMember(Value = "positivity:high")]
    PositivityHigh,

    [EnumMember(Value = "positivity:highest")]
    PositivityHighest,

    [EnumMember(Value = "surprise:lowest")]
    SurpriseLowest,

    [EnumMember(Value = "surprise:low")]
    SurpriseLow,

    [EnumMember(Value = "surprise:high")]
    SurpriseHigh,

    [EnumMember(Value = "surprise:highest")]
    SurpriseHighest,

    [EnumMember(Value = "sadness:lowest")]
    SadnessLowest,

    [EnumMember(Value = "sadness:low")]
    SadnessLow,

    [EnumMember(Value = "sadness:high")]
    SadnessHigh,

    [EnumMember(Value = "sadness:highest")]
    SadnessHighest,

    [EnumMember(Value = "curiosity:lowest")]
    CuriosityLowest,

    [EnumMember(Value = "curiosity:low")]
    CuriosityLow,

    [EnumMember(Value = "curiosity:high")]
    CuriosityHigh,

    [EnumMember(Value = "curiosity:highest")]
    CuriosityHighest,
}

internal class CartesiaExperimentalControlsEmotionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CartesiaExperimentalControlsEmotion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CartesiaExperimentalControlsEmotion
    > _stringToEnum = new()
    {
        { "anger:lowest", CartesiaExperimentalControlsEmotion.AngerLowest },
        { "anger:low", CartesiaExperimentalControlsEmotion.AngerLow },
        { "anger:high", CartesiaExperimentalControlsEmotion.AngerHigh },
        { "anger:highest", CartesiaExperimentalControlsEmotion.AngerHighest },
        { "positivity:lowest", CartesiaExperimentalControlsEmotion.PositivityLowest },
        { "positivity:low", CartesiaExperimentalControlsEmotion.PositivityLow },
        { "positivity:high", CartesiaExperimentalControlsEmotion.PositivityHigh },
        { "positivity:highest", CartesiaExperimentalControlsEmotion.PositivityHighest },
        { "surprise:lowest", CartesiaExperimentalControlsEmotion.SurpriseLowest },
        { "surprise:low", CartesiaExperimentalControlsEmotion.SurpriseLow },
        { "surprise:high", CartesiaExperimentalControlsEmotion.SurpriseHigh },
        { "surprise:highest", CartesiaExperimentalControlsEmotion.SurpriseHighest },
        { "sadness:lowest", CartesiaExperimentalControlsEmotion.SadnessLowest },
        { "sadness:low", CartesiaExperimentalControlsEmotion.SadnessLow },
        { "sadness:high", CartesiaExperimentalControlsEmotion.SadnessHigh },
        { "sadness:highest", CartesiaExperimentalControlsEmotion.SadnessHighest },
        { "curiosity:lowest", CartesiaExperimentalControlsEmotion.CuriosityLowest },
        { "curiosity:low", CartesiaExperimentalControlsEmotion.CuriosityLow },
        { "curiosity:high", CartesiaExperimentalControlsEmotion.CuriosityHigh },
        { "curiosity:highest", CartesiaExperimentalControlsEmotion.CuriosityHighest },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CartesiaExperimentalControlsEmotion,
        string
    > _enumToString = new()
    {
        { CartesiaExperimentalControlsEmotion.AngerLowest, "anger:lowest" },
        { CartesiaExperimentalControlsEmotion.AngerLow, "anger:low" },
        { CartesiaExperimentalControlsEmotion.AngerHigh, "anger:high" },
        { CartesiaExperimentalControlsEmotion.AngerHighest, "anger:highest" },
        { CartesiaExperimentalControlsEmotion.PositivityLowest, "positivity:lowest" },
        { CartesiaExperimentalControlsEmotion.PositivityLow, "positivity:low" },
        { CartesiaExperimentalControlsEmotion.PositivityHigh, "positivity:high" },
        { CartesiaExperimentalControlsEmotion.PositivityHighest, "positivity:highest" },
        { CartesiaExperimentalControlsEmotion.SurpriseLowest, "surprise:lowest" },
        { CartesiaExperimentalControlsEmotion.SurpriseLow, "surprise:low" },
        { CartesiaExperimentalControlsEmotion.SurpriseHigh, "surprise:high" },
        { CartesiaExperimentalControlsEmotion.SurpriseHighest, "surprise:highest" },
        { CartesiaExperimentalControlsEmotion.SadnessLowest, "sadness:lowest" },
        { CartesiaExperimentalControlsEmotion.SadnessLow, "sadness:low" },
        { CartesiaExperimentalControlsEmotion.SadnessHigh, "sadness:high" },
        { CartesiaExperimentalControlsEmotion.SadnessHighest, "sadness:highest" },
        { CartesiaExperimentalControlsEmotion.CuriosityLowest, "curiosity:lowest" },
        { CartesiaExperimentalControlsEmotion.CuriosityLow, "curiosity:low" },
        { CartesiaExperimentalControlsEmotion.CuriosityHigh, "curiosity:high" },
        { CartesiaExperimentalControlsEmotion.CuriosityHighest, "curiosity:highest" },
    };

    public override CartesiaExperimentalControlsEmotion Read(
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
        CartesiaExperimentalControlsEmotion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CartesiaExperimentalControlsEmotion ReadAsPropertyName(
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
        CartesiaExperimentalControlsEmotion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
