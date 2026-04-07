using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(DeepgramTranscriberModelSerializer))]
public enum DeepgramTranscriberModel
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

internal class DeepgramTranscriberModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<DeepgramTranscriberModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        DeepgramTranscriberModel
    > _stringToEnum = new()
    {
        { "flux-general-en", DeepgramTranscriberModel.FluxGeneralEn },
        { "nova-3", DeepgramTranscriberModel.Nova3 },
        { "nova-3-general", DeepgramTranscriberModel.Nova3General },
        { "nova-3-medical", DeepgramTranscriberModel.Nova3Medical },
        { "nova-2", DeepgramTranscriberModel.Nova2 },
        { "nova-2-general", DeepgramTranscriberModel.Nova2General },
        { "nova-2-meeting", DeepgramTranscriberModel.Nova2Meeting },
        { "nova-2-phonecall", DeepgramTranscriberModel.Nova2Phonecall },
        { "nova-2-finance", DeepgramTranscriberModel.Nova2Finance },
        { "nova-2-conversationalai", DeepgramTranscriberModel.Nova2Conversationalai },
        { "nova-2-voicemail", DeepgramTranscriberModel.Nova2Voicemail },
        { "nova-2-video", DeepgramTranscriberModel.Nova2Video },
        { "nova-2-medical", DeepgramTranscriberModel.Nova2Medical },
        { "nova-2-drivethru", DeepgramTranscriberModel.Nova2Drivethru },
        { "nova-2-automotive", DeepgramTranscriberModel.Nova2Automotive },
        { "nova", DeepgramTranscriberModel.Nova },
        { "nova-general", DeepgramTranscriberModel.NovaGeneral },
        { "nova-phonecall", DeepgramTranscriberModel.NovaPhonecall },
        { "nova-medical", DeepgramTranscriberModel.NovaMedical },
        { "enhanced", DeepgramTranscriberModel.Enhanced },
        { "enhanced-general", DeepgramTranscriberModel.EnhancedGeneral },
        { "enhanced-meeting", DeepgramTranscriberModel.EnhancedMeeting },
        { "enhanced-phonecall", DeepgramTranscriberModel.EnhancedPhonecall },
        { "enhanced-finance", DeepgramTranscriberModel.EnhancedFinance },
        { "base", DeepgramTranscriberModel.Base },
        { "base-general", DeepgramTranscriberModel.BaseGeneral },
        { "base-meeting", DeepgramTranscriberModel.BaseMeeting },
        { "base-phonecall", DeepgramTranscriberModel.BasePhonecall },
        { "base-finance", DeepgramTranscriberModel.BaseFinance },
        { "base-conversationalai", DeepgramTranscriberModel.BaseConversationalai },
        { "base-voicemail", DeepgramTranscriberModel.BaseVoicemail },
        { "base-video", DeepgramTranscriberModel.BaseVideo },
        { "whisper", DeepgramTranscriberModel.Whisper },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        DeepgramTranscriberModel,
        string
    > _enumToString = new()
    {
        { DeepgramTranscriberModel.FluxGeneralEn, "flux-general-en" },
        { DeepgramTranscriberModel.Nova3, "nova-3" },
        { DeepgramTranscriberModel.Nova3General, "nova-3-general" },
        { DeepgramTranscriberModel.Nova3Medical, "nova-3-medical" },
        { DeepgramTranscriberModel.Nova2, "nova-2" },
        { DeepgramTranscriberModel.Nova2General, "nova-2-general" },
        { DeepgramTranscriberModel.Nova2Meeting, "nova-2-meeting" },
        { DeepgramTranscriberModel.Nova2Phonecall, "nova-2-phonecall" },
        { DeepgramTranscriberModel.Nova2Finance, "nova-2-finance" },
        { DeepgramTranscriberModel.Nova2Conversationalai, "nova-2-conversationalai" },
        { DeepgramTranscriberModel.Nova2Voicemail, "nova-2-voicemail" },
        { DeepgramTranscriberModel.Nova2Video, "nova-2-video" },
        { DeepgramTranscriberModel.Nova2Medical, "nova-2-medical" },
        { DeepgramTranscriberModel.Nova2Drivethru, "nova-2-drivethru" },
        { DeepgramTranscriberModel.Nova2Automotive, "nova-2-automotive" },
        { DeepgramTranscriberModel.Nova, "nova" },
        { DeepgramTranscriberModel.NovaGeneral, "nova-general" },
        { DeepgramTranscriberModel.NovaPhonecall, "nova-phonecall" },
        { DeepgramTranscriberModel.NovaMedical, "nova-medical" },
        { DeepgramTranscriberModel.Enhanced, "enhanced" },
        { DeepgramTranscriberModel.EnhancedGeneral, "enhanced-general" },
        { DeepgramTranscriberModel.EnhancedMeeting, "enhanced-meeting" },
        { DeepgramTranscriberModel.EnhancedPhonecall, "enhanced-phonecall" },
        { DeepgramTranscriberModel.EnhancedFinance, "enhanced-finance" },
        { DeepgramTranscriberModel.Base, "base" },
        { DeepgramTranscriberModel.BaseGeneral, "base-general" },
        { DeepgramTranscriberModel.BaseMeeting, "base-meeting" },
        { DeepgramTranscriberModel.BasePhonecall, "base-phonecall" },
        { DeepgramTranscriberModel.BaseFinance, "base-finance" },
        { DeepgramTranscriberModel.BaseConversationalai, "base-conversationalai" },
        { DeepgramTranscriberModel.BaseVoicemail, "base-voicemail" },
        { DeepgramTranscriberModel.BaseVideo, "base-video" },
        { DeepgramTranscriberModel.Whisper, "whisper" },
    };

    public override DeepgramTranscriberModel Read(
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
        DeepgramTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override DeepgramTranscriberModel ReadAsPropertyName(
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
        DeepgramTranscriberModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
