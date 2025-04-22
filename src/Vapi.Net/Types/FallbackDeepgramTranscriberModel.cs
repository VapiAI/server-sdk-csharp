using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackDeepgramTranscriberModel>))]
public enum FallbackDeepgramTranscriberModel
{
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
}
