using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackDeepgramTranscriberModelSerializer))]
public enum FallbackDeepgramTranscriberModel
{
    [EnumMember(Value = "flux-general-en")]
    FluxGeneralEn,

    [EnumMember(Value = "nova-3")]
    Nova3,

    [EnumMember(Value = "nova-3-general")]
    Nova3General,

    [EnumMember(Value = "nova-3-medical")]
    Nova3Medical,

    [EnumMember(Value = "nova-2")]
    Nova2,

    [EnumMember(Value = "nova-2-general")]
    Nova2General,

    [EnumMember(Value = "nova-2-meeting")]
    Nova2Meeting,

    [EnumMember(Value = "nova-2-phonecall")]
    Nova2Phonecall,

    [EnumMember(Value = "nova-2-finance")]
    Nova2Finance,

    [EnumMember(Value = "nova-2-conversationalai")]
    Nova2Conversationalai,

    [EnumMember(Value = "nova-2-voicemail")]
    Nova2Voicemail,

    [EnumMember(Value = "nova-2-video")]
    Nova2Video,

    [EnumMember(Value = "nova-2-medical")]
    Nova2Medical,

    [EnumMember(Value = "nova-2-drivethru")]
    Nova2Drivethru,

    [EnumMember(Value = "nova-2-automotive")]
    Nova2Automotive,

    [EnumMember(Value = "nova")]
    Nova,

    [EnumMember(Value = "nova-general")]
    NovaGeneral,

    [EnumMember(Value = "nova-phonecall")]
    NovaPhonecall,

    [EnumMember(Value = "nova-medical")]
    NovaMedical,

    [EnumMember(Value = "enhanced")]
    Enhanced,

    [EnumMember(Value = "enhanced-general")]
    EnhancedGeneral,

    [EnumMember(Value = "enhanced-meeting")]
    EnhancedMeeting,

    [EnumMember(Value = "enhanced-phonecall")]
    EnhancedPhonecall,

    [EnumMember(Value = "enhanced-finance")]
    EnhancedFinance,

    [EnumMember(Value = "base")]
    Base,

    [EnumMember(Value = "base-general")]
    BaseGeneral,

    [EnumMember(Value = "base-meeting")]
    BaseMeeting,

    [EnumMember(Value = "base-phonecall")]
    BasePhonecall,

    [EnumMember(Value = "base-finance")]
    BaseFinance,

    [EnumMember(Value = "base-conversationalai")]
    BaseConversationalai,

    [EnumMember(Value = "base-voicemail")]
    BaseVoicemail,

    [EnumMember(Value = "base-video")]
    BaseVideo,

    [EnumMember(Value = "whisper")]
    Whisper,
}

internal class FallbackDeepgramTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackDeepgramTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackDeepgramTranscriberModel
    > _stringToEnum = new()
    {
        { "flux-general-en", FallbackDeepgramTranscriberModel.FluxGeneralEn },
        { "nova-3", FallbackDeepgramTranscriberModel.Nova3 },
        { "nova-3-general", FallbackDeepgramTranscriberModel.Nova3General },
        { "nova-3-medical", FallbackDeepgramTranscriberModel.Nova3Medical },
        { "nova-2", FallbackDeepgramTranscriberModel.Nova2 },
        { "nova-2-general", FallbackDeepgramTranscriberModel.Nova2General },
        { "nova-2-meeting", FallbackDeepgramTranscriberModel.Nova2Meeting },
        { "nova-2-phonecall", FallbackDeepgramTranscriberModel.Nova2Phonecall },
        { "nova-2-finance", FallbackDeepgramTranscriberModel.Nova2Finance },
        { "nova-2-conversationalai", FallbackDeepgramTranscriberModel.Nova2Conversationalai },
        { "nova-2-voicemail", FallbackDeepgramTranscriberModel.Nova2Voicemail },
        { "nova-2-video", FallbackDeepgramTranscriberModel.Nova2Video },
        { "nova-2-medical", FallbackDeepgramTranscriberModel.Nova2Medical },
        { "nova-2-drivethru", FallbackDeepgramTranscriberModel.Nova2Drivethru },
        { "nova-2-automotive", FallbackDeepgramTranscriberModel.Nova2Automotive },
        { "nova", FallbackDeepgramTranscriberModel.Nova },
        { "nova-general", FallbackDeepgramTranscriberModel.NovaGeneral },
        { "nova-phonecall", FallbackDeepgramTranscriberModel.NovaPhonecall },
        { "nova-medical", FallbackDeepgramTranscriberModel.NovaMedical },
        { "enhanced", FallbackDeepgramTranscriberModel.Enhanced },
        { "enhanced-general", FallbackDeepgramTranscriberModel.EnhancedGeneral },
        { "enhanced-meeting", FallbackDeepgramTranscriberModel.EnhancedMeeting },
        { "enhanced-phonecall", FallbackDeepgramTranscriberModel.EnhancedPhonecall },
        { "enhanced-finance", FallbackDeepgramTranscriberModel.EnhancedFinance },
        { "base", FallbackDeepgramTranscriberModel.Base },
        { "base-general", FallbackDeepgramTranscriberModel.BaseGeneral },
        { "base-meeting", FallbackDeepgramTranscriberModel.BaseMeeting },
        { "base-phonecall", FallbackDeepgramTranscriberModel.BasePhonecall },
        { "base-finance", FallbackDeepgramTranscriberModel.BaseFinance },
        { "base-conversationalai", FallbackDeepgramTranscriberModel.BaseConversationalai },
        { "base-voicemail", FallbackDeepgramTranscriberModel.BaseVoicemail },
        { "base-video", FallbackDeepgramTranscriberModel.BaseVideo },
        { "whisper", FallbackDeepgramTranscriberModel.Whisper },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackDeepgramTranscriberModel,
        string
    > _enumToString = new()
    {
        { FallbackDeepgramTranscriberModel.FluxGeneralEn, "flux-general-en" },
        { FallbackDeepgramTranscriberModel.Nova3, "nova-3" },
        { FallbackDeepgramTranscriberModel.Nova3General, "nova-3-general" },
        { FallbackDeepgramTranscriberModel.Nova3Medical, "nova-3-medical" },
        { FallbackDeepgramTranscriberModel.Nova2, "nova-2" },
        { FallbackDeepgramTranscriberModel.Nova2General, "nova-2-general" },
        { FallbackDeepgramTranscriberModel.Nova2Meeting, "nova-2-meeting" },
        { FallbackDeepgramTranscriberModel.Nova2Phonecall, "nova-2-phonecall" },
        { FallbackDeepgramTranscriberModel.Nova2Finance, "nova-2-finance" },
        { FallbackDeepgramTranscriberModel.Nova2Conversationalai, "nova-2-conversationalai" },
        { FallbackDeepgramTranscriberModel.Nova2Voicemail, "nova-2-voicemail" },
        { FallbackDeepgramTranscriberModel.Nova2Video, "nova-2-video" },
        { FallbackDeepgramTranscriberModel.Nova2Medical, "nova-2-medical" },
        { FallbackDeepgramTranscriberModel.Nova2Drivethru, "nova-2-drivethru" },
        { FallbackDeepgramTranscriberModel.Nova2Automotive, "nova-2-automotive" },
        { FallbackDeepgramTranscriberModel.Nova, "nova" },
        { FallbackDeepgramTranscriberModel.NovaGeneral, "nova-general" },
        { FallbackDeepgramTranscriberModel.NovaPhonecall, "nova-phonecall" },
        { FallbackDeepgramTranscriberModel.NovaMedical, "nova-medical" },
        { FallbackDeepgramTranscriberModel.Enhanced, "enhanced" },
        { FallbackDeepgramTranscriberModel.EnhancedGeneral, "enhanced-general" },
        { FallbackDeepgramTranscriberModel.EnhancedMeeting, "enhanced-meeting" },
        { FallbackDeepgramTranscriberModel.EnhancedPhonecall, "enhanced-phonecall" },
        { FallbackDeepgramTranscriberModel.EnhancedFinance, "enhanced-finance" },
        { FallbackDeepgramTranscriberModel.Base, "base" },
        { FallbackDeepgramTranscriberModel.BaseGeneral, "base-general" },
        { FallbackDeepgramTranscriberModel.BaseMeeting, "base-meeting" },
        { FallbackDeepgramTranscriberModel.BasePhonecall, "base-phonecall" },
        { FallbackDeepgramTranscriberModel.BaseFinance, "base-finance" },
        { FallbackDeepgramTranscriberModel.BaseConversationalai, "base-conversationalai" },
        { FallbackDeepgramTranscriberModel.BaseVoicemail, "base-voicemail" },
        { FallbackDeepgramTranscriberModel.BaseVideo, "base-video" },
        { FallbackDeepgramTranscriberModel.Whisper, "whisper" },
    };

    public override FallbackDeepgramTranscriberModel Read(
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
        FallbackDeepgramTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackDeepgramTranscriberModel ReadAsPropertyName(
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
        FallbackDeepgramTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
