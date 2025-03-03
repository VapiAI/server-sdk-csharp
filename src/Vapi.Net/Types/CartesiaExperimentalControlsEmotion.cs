using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CartesiaExperimentalControlsEmotion>))]
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
