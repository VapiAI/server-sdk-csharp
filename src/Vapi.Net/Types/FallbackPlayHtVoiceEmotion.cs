using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackPlayHtVoiceEmotion>))]
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
