using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VapiVoiceVoiceId>))]
public enum VapiVoiceVoiceId
{
    [EnumMember(Value = "Elliot")]
    Elliot,

    [EnumMember(Value = "Rohan")]
    Rohan,

    [EnumMember(Value = "Lily")]
    Lily,

    [EnumMember(Value = "Savannah")]
    Savannah,

    [EnumMember(Value = "Hana")]
    Hana,

    [EnumMember(Value = "Neha")]
    Neha,

    [EnumMember(Value = "Cole")]
    Cole,

    [EnumMember(Value = "Harry")]
    Harry,

    [EnumMember(Value = "Paige")]
    Paige,

    [EnumMember(Value = "Spencer")]
    Spencer,
}
